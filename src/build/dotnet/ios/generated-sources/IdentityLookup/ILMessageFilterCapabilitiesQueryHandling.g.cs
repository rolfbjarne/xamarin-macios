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
	/// <summary>This interface represents the Objective-C protocol <c>ILMessageFilterCapabilitiesQueryHandling</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	[SupportedOSPlatform ("ios16.0")]
	[Protocol (Name = "ILMessageFilterCapabilitiesQueryHandling", WrapperType = typeof (ILMessageFilterCapabilitiesQueryHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleQueryRequest", Selector = "handleCapabilitiesQueryRequest:context:completion:", ParameterType = new Type [] { typeof (IdentityLookup.ILMessageFilterCapabilitiesQueryRequest), typeof (IdentityLookup.ILMessageFilterExtensionContext), typeof (global::System.Action<global::IdentityLookup.ILMessageFilterCapabilitiesQueryResponse>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V77) })]
	public partial interface IILMessageFilterCapabilitiesQueryHandling : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("handleCapabilitiesQueryRequest:context:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleQueryRequest (ILMessageFilterCapabilitiesQueryRequest capabilitiesQueryRequest, ILMessageFilterExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V77))]global::System.Action<ILMessageFilterCapabilitiesQueryResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleQueryRequest (IILMessageFilterCapabilitiesQueryHandling This, ILMessageFilterCapabilitiesQueryRequest capabilitiesQueryRequest, ILMessageFilterExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V77))]global::System.Action<ILMessageFilterCapabilitiesQueryResponse> completion)
		{
			var capabilitiesQueryRequest__handle__ = capabilitiesQueryRequest!.GetNonNullHandle (nameof (capabilitiesQueryRequest));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V77.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleCapabilitiesQueryRequest:context:completion:"), capabilitiesQueryRequest__handle__, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (capabilitiesQueryRequest);
			GC.KeepAlive (context);
		}
		[DynamicDependencyAttribute ("HandleQueryRequest(IdentityLookup.ILMessageFilterCapabilitiesQueryRequest,IdentityLookup.ILMessageFilterExtensionContext,System.Action{IdentityLookup.ILMessageFilterCapabilitiesQueryResponse})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ILMessageFilterCapabilitiesQueryHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IILMessageFilterCapabilitiesQueryHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class ILMessageFilterCapabilitiesQueryHandlingWrapper : BaseWrapper, IILMessageFilterCapabilitiesQueryHandling {
		public ILMessageFilterCapabilitiesQueryHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (ILMessageFilterCapabilitiesQueryHandlingWrapper))]
		static ILMessageFilterCapabilitiesQueryHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("handleCapabilitiesQueryRequest:context:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleQueryRequest (ILMessageFilterCapabilitiesQueryRequest capabilitiesQueryRequest, ILMessageFilterExtensionContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V77))]global::System.Action<ILMessageFilterCapabilitiesQueryResponse> completion)
		{
			var capabilitiesQueryRequest__handle__ = capabilitiesQueryRequest!.GetNonNullHandle (nameof (capabilitiesQueryRequest));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V77.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleCapabilitiesQueryRequest:context:completion:"), capabilitiesQueryRequest__handle__, context__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (capabilitiesQueryRequest);
			GC.KeepAlive (context);
		}
	}
}
