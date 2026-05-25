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
namespace CoreData {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSFetchedResultsControllerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "NSFetchedResultsControllerDelegate", WrapperType = typeof (NSFetchedResultsControllerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillChangeContent", Selector = "controllerWillChangeContent:", ParameterType = new Type [] { typeof (CoreData.NSFetchedResultsController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeObject", Selector = "controller:didChangeObject:atIndexPath:forChangeType:newIndexPath:", ParameterType = new Type [] { typeof (CoreData.NSFetchedResultsController), typeof (NSObject), typeof (NSIndexPath), typeof (CoreData.NSFetchedResultsChangeType), typeof (NSIndexPath) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeSection", Selector = "controller:didChangeSection:atIndex:forChangeType:", ParameterType = new Type [] { typeof (CoreData.NSFetchedResultsController), typeof (CoreData.INSFetchedResultsSectionInfo), typeof (UIntPtr), typeof (CoreData.NSFetchedResultsChangeType) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeContent", Selector = "controllerDidChangeContent:", ParameterType = new Type [] { typeof (CoreData.NSFetchedResultsController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SectionFor", Selector = "controller:sectionIndexTitleForSectionName:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (CoreData.NSFetchedResultsController), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSFetchedResultsControllerDelegate : INativeObject, IDisposable
	{
		/// <param name="controller">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("controllerWillChangeContent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillChangeContent (NSFetchedResultsController controller)
		{
			_WillChangeContent (this, controller);
		}
		/// <param name="controller">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillChangeContent (INSFetchedResultsControllerDelegate This, NSFetchedResultsController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("controllerWillChangeContent:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><param name="anObject">To be added.</param><param name="indexPath"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="type">To be added.</param><param name="newIndexPath"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("controller:didChangeObject:atIndexPath:forChangeType:newIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeObject (NSFetchedResultsController controller, NSObject anObject, NSIndexPath? indexPath, NSFetchedResultsChangeType type, NSIndexPath? newIndexPath)
		{
			_DidChangeObject (this, controller, anObject, indexPath, type, newIndexPath);
		}
		/// <param name="controller">To be added.</param><param name="anObject">To be added.</param><param name="indexPath"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="type">To be added.</param><param name="newIndexPath"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeObject (INSFetchedResultsControllerDelegate This, NSFetchedResultsController controller, NSObject anObject, NSIndexPath? indexPath, NSFetchedResultsChangeType type, NSIndexPath? newIndexPath)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var anObject__handle__ = anObject!.GetNonNullHandle (nameof (anObject));
			var indexPath__handle__ = indexPath.GetHandle ();
			var newIndexPath__handle__ = newIndexPath.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("controller:didChangeObject:atIndexPath:forChangeType:newIndexPath:"), controller__handle__, anObject__handle__, indexPath__handle__, (UIntPtr) (ulong) type, newIndexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (anObject);
			GC.KeepAlive (indexPath);
			GC.KeepAlive (newIndexPath);
		}
		/// <param name="controller">To be added.</param><param name="sectionInfo">To be added.</param><param name="sectionIndex">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("controller:didChangeSection:atIndex:forChangeType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeSection (NSFetchedResultsController controller, INSFetchedResultsSectionInfo sectionInfo, nuint sectionIndex, NSFetchedResultsChangeType type)
		{
			_DidChangeSection (this, controller, sectionInfo, sectionIndex, type);
		}
		/// <param name="controller">To be added.</param><param name="sectionInfo">To be added.</param><param name="sectionIndex">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeSection (INSFetchedResultsControllerDelegate This, NSFetchedResultsController controller, INSFetchedResultsSectionInfo sectionInfo, nuint sectionIndex, NSFetchedResultsChangeType type)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var sectionInfo__handle__ = sectionInfo!.GetNonNullHandle (nameof (sectionInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("controller:didChangeSection:atIndex:forChangeType:"), controller__handle__, sectionInfo__handle__, sectionIndex, (UIntPtr) (ulong) type);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (sectionInfo);
		}
		/// <param name="controller">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("controllerDidChangeContent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeContent (NSFetchedResultsController controller)
		{
			_DidChangeContent (this, controller);
		}
		/// <param name="controller">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeContent (INSFetchedResultsControllerDelegate This, NSFetchedResultsController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("controllerDidChangeContent:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><param name="sectionName">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("controller:sectionIndexTitleForSectionName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? SectionFor (NSFetchedResultsController controller, string sectionName)
		{
			return _SectionFor (this, controller, sectionName);
		}
		/// <param name="controller">To be added.</param><param name="sectionName">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string? _SectionFor (INSFetchedResultsControllerDelegate This, NSFetchedResultsController controller, string sectionName)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (sectionName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sectionName));
			var nssectionName = CFString.CreateNative (sectionName);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("controller:sectionIndexTitleForSectionName:"), controller__handle__, nssectionName), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			CFString.ReleaseNative (nssectionName);
			return ret!;
		}
		[DynamicDependencyAttribute ("DidChangeContent(CoreData.NSFetchedResultsController)")]
		[DynamicDependencyAttribute ("DidChangeObject(CoreData.NSFetchedResultsController,Foundation.NSObject,Foundation.NSIndexPath,CoreData.NSFetchedResultsChangeType,Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("DidChangeSection(CoreData.NSFetchedResultsController,CoreData.INSFetchedResultsSectionInfo,System.UIntPtr,CoreData.NSFetchedResultsChangeType)")]
		[DynamicDependencyAttribute ("SectionFor(CoreData.NSFetchedResultsController,System.String)")]
		[DynamicDependencyAttribute ("WillChangeContent(CoreData.NSFetchedResultsController)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFetchedResultsControllerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFetchedResultsControllerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSFetchedResultsControllerDelegate" /> interface to support all the methods from the NSFetchedResultsControllerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSFetchedResultsControllerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSFetchedResultsControllerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSFetchedResultsControllerDelegate_Extensions {
		/// <param name="controller">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillChangeContent (this INSFetchedResultsControllerDelegate This, NSFetchedResultsController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("controllerWillChangeContent:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><param name="anObject">To be added.</param><param name="indexPath"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="type">To be added.</param><param name="newIndexPath"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeObject (this INSFetchedResultsControllerDelegate This, NSFetchedResultsController controller, NSObject anObject, NSIndexPath? indexPath, NSFetchedResultsChangeType type, NSIndexPath? newIndexPath)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var anObject__handle__ = anObject!.GetNonNullHandle (nameof (anObject));
			var indexPath__handle__ = indexPath.GetHandle ();
			var newIndexPath__handle__ = newIndexPath.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr_NativeHandle (This.Handle, Selector.GetHandle ("controller:didChangeObject:atIndexPath:forChangeType:newIndexPath:"), controller__handle__, anObject__handle__, indexPath__handle__, (UIntPtr) (ulong) type, newIndexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (anObject);
			GC.KeepAlive (indexPath);
			GC.KeepAlive (newIndexPath);
		}
		/// <param name="controller">To be added.</param><param name="sectionInfo">To be added.</param><param name="sectionIndex">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeSection (this INSFetchedResultsControllerDelegate This, NSFetchedResultsController controller, INSFetchedResultsSectionInfo sectionInfo, nuint sectionIndex, NSFetchedResultsChangeType type)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			var sectionInfo__handle__ = sectionInfo!.GetNonNullHandle (nameof (sectionInfo));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("controller:didChangeSection:atIndex:forChangeType:"), controller__handle__, sectionInfo__handle__, sectionIndex, (UIntPtr) (ulong) type);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			GC.KeepAlive (sectionInfo);
		}
		/// <param name="controller">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeContent (this INSFetchedResultsControllerDelegate This, NSFetchedResultsController controller)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("controllerDidChangeContent:"), controller__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
		}
		/// <param name="controller">To be added.</param><param name="sectionName">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? SectionFor (this INSFetchedResultsControllerDelegate This, NSFetchedResultsController controller, string sectionName)
		{
			var controller__handle__ = controller!.GetNonNullHandle (nameof (controller));
			if (sectionName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (sectionName));
			var nssectionName = CFString.CreateNative (sectionName);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("controller:sectionIndexTitleForSectionName:"), controller__handle__, nssectionName), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (controller);
			CFString.ReleaseNative (nssectionName);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFetchedResultsControllerDelegateWrapper : BaseWrapper, INSFetchedResultsControllerDelegate {
		public NSFetchedResultsControllerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFetchedResultsControllerDelegateWrapper))]
		static NSFetchedResultsControllerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace CoreData {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSFetchedResultsControllerDelegate" /> (for the protocol <c>NSFetchedResultsControllerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSFetchedResultsControllerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__CoreData_NSFetchedResultsControllerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class NSFetchedResultsControllerDelegate : NSObject, INSFetchedResultsControllerDelegate {
		/// <summary>Creates a new <see cref="NSFetchedResultsControllerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSFetchedResultsControllerDelegate () : base (NSObjectFlag.Empty)
		{
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
		protected NSFetchedResultsControllerDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSFetchedResultsControllerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="controller">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("controllerDidChangeContent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeContent (NSFetchedResultsController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="anObject">To be added.</param><param name="indexPath"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="type">To be added.</param><param name="newIndexPath"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("controller:didChangeObject:atIndexPath:forChangeType:newIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeObject (NSFetchedResultsController controller, NSObject anObject, NSIndexPath? indexPath, NSFetchedResultsChangeType type, NSIndexPath? newIndexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="sectionInfo">To be added.</param><param name="sectionIndex">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("controller:didChangeSection:atIndex:forChangeType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeSection (NSFetchedResultsController controller, INSFetchedResultsSectionInfo sectionInfo, nuint sectionIndex, NSFetchedResultsChangeType type)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><param name="sectionName">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("controller:sectionIndexTitleForSectionName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? SectionFor (NSFetchedResultsController controller, string sectionName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="controller">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("controllerWillChangeContent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillChangeContent (NSFetchedResultsController controller)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSFetchedResultsControllerDelegate */
}
