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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace IdentityLookup {
	#pragma warning disable CS1573
	/// <summary>Interface that is used by a message filter extension to respond to queries.</summary>
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "ILMessageFilterQueryHandling", WrapperType = typeof (ILMessageFilterQueryHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleQueryRequest", Selector = "handleQueryRequest:context:completion:", ParameterType = new Type [] { typeof (IdentityLookup.ILMessageFilterQueryRequest), typeof (IdentityLookup.ILMessageFilterExtensionContext), typeof (global::System.Action<global::IdentityLookup.ILMessageFilterQueryResponse>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V78) })]
	public partial interface IILMessageFilterQueryHandling : INativeObject, IDisposable
	{
		/// <param name="queryRequest">The query for the message.</param><param name="context">The app extension context for deferring requests.</param><param name="completion">A handler that is run after the operation completes.</param><summary>Evaluates the specified request in the provided context, and runs a handler when the operation is complete.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("handleQueryRequest:context:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleQueryRequest (ILMessageFilterQueryRequest queryRequest, ILMessageFilterExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V78))]global::System.Action<ILMessageFilterQueryResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="queryRequest">The query for the message.</param><param name="context">The app extension context for deferring requests.</param><param name="completion">A handler that is run after the operation completes.</param><summary>Evaluates the specified request in the provided context, and runs a handler when the operation is complete.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleQueryRequest (IILMessageFilterQueryHandling This, ILMessageFilterQueryRequest queryRequest, ILMessageFilterExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V78))]global::System.Action<ILMessageFilterQueryResponse> completion)
		{
			var queryRequest__handle__ = queryRequest!.GetNonNullHandle (nameof (queryRequest));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V78.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleQueryRequest:context:completion:"), queryRequest__handle__, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (queryRequest);
			GC.KeepAlive (context);
		}
		[DynamicDependencyAttribute ("HandleQueryRequest(IdentityLookup.ILMessageFilterQueryRequest,IdentityLookup.ILMessageFilterExtensionContext,System.Action{IdentityLookup.ILMessageFilterQueryResponse})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ILMessageFilterQueryHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IILMessageFilterQueryHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ILMessageFilterQueryHandlingWrapper : BaseWrapper, IILMessageFilterQueryHandling {
		public ILMessageFilterQueryHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ILMessageFilterQueryHandlingWrapper))]
		static ILMessageFilterQueryHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="queryRequest">The query for the message.</param><param name="context">The app extension context for deferring requests.</param><param name="completion">A handler that is run after the operation completes.</param><summary>Evaluates the specified request in the provided context, and runs a handler when the operation is complete.</summary><remarks>To be added.</remarks>
		[Export ("handleQueryRequest:context:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleQueryRequest (ILMessageFilterQueryRequest queryRequest, ILMessageFilterExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V78))]global::System.Action<ILMessageFilterQueryResponse> completion)
		{
			var queryRequest__handle__ = queryRequest!.GetNonNullHandle (nameof (queryRequest));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V78.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleQueryRequest:context:completion:"), queryRequest__handle__, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (queryRequest);
			GC.KeepAlive (context);
		}
	}
}
