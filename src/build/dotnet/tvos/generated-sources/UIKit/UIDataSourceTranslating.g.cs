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
	/// <summary>Interface for managing data source objects.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UIDataSourceTranslating", WrapperType = typeof (UIDataSourceTranslatingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPresentationSectionIndex", Selector = "presentationSectionIndexForDataSourceSectionIndex:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (IntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetDataSourceSectionIndex", Selector = "dataSourceSectionIndexForPresentationSectionIndex:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (IntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPresentationIndexPath", Selector = "presentationIndexPathForDataSourceIndexPath:", ReturnType = typeof (NSIndexPath), ParameterType = new Type [] { typeof (NSIndexPath) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetDataSourceIndexPath", Selector = "dataSourceIndexPathForPresentationIndexPath:", ReturnType = typeof (NSIndexPath), ParameterType = new Type [] { typeof (NSIndexPath) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PerformUsingPresentationValues", Selector = "performUsingPresentationValues:", ParameterType = new Type [] { typeof (Action) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDAction) })]
	public partial interface IUIDataSourceTranslating : INativeObject, IDisposable
	{
		/// <param name="dataSourceSectionIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("presentationSectionIndexForDataSourceSectionIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetPresentationSectionIndex (nint dataSourceSectionIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="dataSourceSectionIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetPresentationSectionIndex (IUIDataSourceTranslating This, nint dataSourceSectionIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("presentationSectionIndexForDataSourceSectionIndex:"), dataSourceSectionIndex);
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="presentationSectionIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("dataSourceSectionIndexForPresentationSectionIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetDataSourceSectionIndex (nint presentationSectionIndex)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="presentationSectionIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetDataSourceSectionIndex (IUIDataSourceTranslating This, nint presentationSectionIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("dataSourceSectionIndexForPresentationSectionIndex:"), presentationSectionIndex);
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="dataSourceIndexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("presentationIndexPathForDataSourceIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath? GetPresentationIndexPath (NSIndexPath? dataSourceIndexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="dataSourceIndexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSIndexPath? _GetPresentationIndexPath (IUIDataSourceTranslating This, NSIndexPath? dataSourceIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var dataSourceIndexPath__handle__ = dataSourceIndexPath.GetHandle ();
			NSIndexPath? ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("presentationIndexPathForDataSourceIndexPath:"), dataSourceIndexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (dataSourceIndexPath);
			return ret!;
		}
		/// <param name="presentationIndexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("dataSourceIndexPathForPresentationIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSIndexPath? GetDataSourceIndexPath (NSIndexPath? presentationIndexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="presentationIndexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSIndexPath? _GetDataSourceIndexPath (IUIDataSourceTranslating This, NSIndexPath? presentationIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var presentationIndexPath__handle__ = presentationIndexPath.GetHandle ();
			NSIndexPath? ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("dataSourceIndexPathForPresentationIndexPath:"), presentationIndexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (presentationIndexPath);
			return ret!;
		}
		/// <param name="actionsToTranslate">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("performUsingPresentationValues:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PerformUsingPresentationValues ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action actionsToTranslate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="actionsToTranslate">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _PerformUsingPresentationValues (IUIDataSourceTranslating This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action actionsToTranslate)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (actionsToTranslate is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (actionsToTranslate));
			using var block_actionsToTranslate = Trampolines.SDAction.CreateBlock (actionsToTranslate);
			BlockLiteral *block_ptr_actionsToTranslate = &block_actionsToTranslate;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("performUsingPresentationValues:"), (IntPtr) block_ptr_actionsToTranslate);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("GetDataSourceIndexPath(Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("GetDataSourceSectionIndex(System.IntPtr)")]
		[DynamicDependencyAttribute ("GetPresentationIndexPath(Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("GetPresentationSectionIndex(System.IntPtr)")]
		[DynamicDependencyAttribute ("PerformUsingPresentationValues(System.Action)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDataSourceTranslatingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIDataSourceTranslating ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIDataSourceTranslatingWrapper : BaseWrapper, IUIDataSourceTranslating {
		public UIDataSourceTranslatingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIDataSourceTranslatingWrapper))]
		static UIDataSourceTranslatingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="dataSourceSectionIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("presentationSectionIndexForDataSourceSectionIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint GetPresentationSectionIndex (nint dataSourceSectionIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("presentationSectionIndexForDataSourceSectionIndex:"), dataSourceSectionIndex);
			return ret;
		}
		/// <param name="presentationSectionIndex">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dataSourceSectionIndexForPresentationSectionIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint GetDataSourceSectionIndex (nint presentationSectionIndex)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("dataSourceSectionIndexForPresentationSectionIndex:"), presentationSectionIndex);
			return ret;
		}
		/// <param name="dataSourceIndexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("presentationIndexPathForDataSourceIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSIndexPath? GetPresentationIndexPath (NSIndexPath? dataSourceIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var dataSourceIndexPath__handle__ = dataSourceIndexPath.GetHandle ();
			NSIndexPath? ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("presentationIndexPathForDataSourceIndexPath:"), dataSourceIndexPath__handle__), false)!;
			GC.KeepAlive (dataSourceIndexPath);
			return ret!;
		}
		/// <param name="presentationIndexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dataSourceIndexPathForPresentationIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSIndexPath? GetDataSourceIndexPath (NSIndexPath? presentationIndexPath)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var presentationIndexPath__handle__ = presentationIndexPath.GetHandle ();
			NSIndexPath? ret;
			ret =  Runtime.GetNSObject<NSIndexPath> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("dataSourceIndexPathForPresentationIndexPath:"), presentationIndexPath__handle__), false)!;
			GC.KeepAlive (presentationIndexPath);
			return ret!;
		}
		/// <param name="actionsToTranslate">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("performUsingPresentationValues:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void PerformUsingPresentationValues ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action actionsToTranslate)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (actionsToTranslate is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (actionsToTranslate));
			using var block_actionsToTranslate = Trampolines.SDAction.CreateBlock (actionsToTranslate);
			BlockLiteral *block_ptr_actionsToTranslate = &block_actionsToTranslate;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("performUsingPresentationValues:"), (IntPtr) block_ptr_actionsToTranslate);
		}
	}
}
