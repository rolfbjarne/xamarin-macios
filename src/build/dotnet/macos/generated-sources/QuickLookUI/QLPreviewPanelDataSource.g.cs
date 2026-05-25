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
namespace QuickLookUI {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>QLPreviewPanelDataSource</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "QLPreviewPanelDataSource", WrapperType = typeof (QLPreviewPanelDataSourceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NumberOfPreviewItemsInPreviewPanel", Selector = "numberOfPreviewItemsInPreviewPanel:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (QuickLookUI.QLPreviewPanel) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PreviewItemAtIndex", Selector = "previewPanel:previewItemAtIndex:", ReturnType = typeof (QuickLookUI.IQLPreviewItem), ParameterType = new Type [] { typeof (QuickLookUI.QLPreviewPanel), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IQLPreviewPanelDataSource : INativeObject, IDisposable
	{
		/// <param name="panel">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("numberOfPreviewItemsInPreviewPanel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfPreviewItemsInPreviewPanel (QLPreviewPanel panel)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="panel">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _NumberOfPreviewItemsInPreviewPanel (IQLPreviewPanelDataSource This, QLPreviewPanel panel)
		{
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("numberOfPreviewItemsInPreviewPanel:"), panel__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			return ret!;
		}
		/// <param name="panel">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("previewPanel:previewItemAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IQLPreviewItem PreviewItemAtIndex (QLPreviewPanel panel, nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="panel">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IQLPreviewItem _PreviewItemAtIndex (IQLPreviewPanelDataSource This, QLPreviewPanel panel, nint index)
		{
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			IQLPreviewItem? ret;
			ret =  Runtime.GetINativeObject<IQLPreviewItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("previewPanel:previewItemAtIndex:"), panel__handle__, index), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			return ret!;
		}
		[DynamicDependencyAttribute ("NumberOfPreviewItemsInPreviewPanel(QuickLookUI.QLPreviewPanel)")]
		[DynamicDependencyAttribute ("PreviewItemAtIndex(QuickLookUI.QLPreviewPanel,System.IntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (QLPreviewPanelDataSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IQLPreviewPanelDataSource ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class QLPreviewPanelDataSourceWrapper : BaseWrapper, IQLPreviewPanelDataSource {
		public QLPreviewPanelDataSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (QLPreviewPanelDataSourceWrapper))]
		static QLPreviewPanelDataSourceWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="panel">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfPreviewItemsInPreviewPanel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint NumberOfPreviewItemsInPreviewPanel (QLPreviewPanel panel)
		{
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("numberOfPreviewItemsInPreviewPanel:"), panel__handle__);
			GC.KeepAlive (panel);
			return ret!;
		}
		/// <param name="panel">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("previewPanel:previewItemAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IQLPreviewItem PreviewItemAtIndex (QLPreviewPanel panel, nint index)
		{
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			IQLPreviewItem? ret;
			ret =  Runtime.GetINativeObject<IQLPreviewItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("previewPanel:previewItemAtIndex:"), panel__handle__, index), false)!;
			GC.KeepAlive (panel);
			return ret!;
		}
	}
}
namespace QuickLookUI {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IQLPreviewPanelDataSource" /> (for the protocol <c>QLPreviewPanelDataSource</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IQLPreviewPanelDataSource" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__QuickLookUI_QLPreviewPanelDataSource", false)]
	[Model]
	public unsafe abstract partial class QLPreviewPanelDataSource : NSObject, IQLPreviewPanelDataSource {
		/// <summary>Creates a new <see cref="QLPreviewPanelDataSource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected QLPreviewPanelDataSource () : base (NSObjectFlag.Empty)
		{
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
		protected QLPreviewPanelDataSource (NSObjectFlag t) : base (t)
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
		protected internal QLPreviewPanelDataSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="panel">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfPreviewItemsInPreviewPanel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfPreviewItemsInPreviewPanel (QLPreviewPanel panel)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="panel">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("previewPanel:previewItemAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IQLPreviewItem PreviewItemAtIndex (QLPreviewPanel panel, nint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class QLPreviewPanelDataSource */
}
