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
namespace Intents {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>INShareFocusStatusIntentHandling</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "INShareFocusStatusIntentHandling", WrapperType = typeof (INShareFocusStatusIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleShareFocusStatus", Selector = "handleShareFocusStatus:completion:", ParameterType = new Type [] { typeof (Intents.INShareFocusStatusIntent), typeof (global::System.Action<global::Intents.INShareFocusStatusIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V76) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConfirmShareFocusStatus", Selector = "confirmShareFocusStatus:completion:", ParameterType = new Type [] { typeof (Intents.INShareFocusStatusIntent), typeof (global::System.Action<global::Intents.INShareFocusStatusIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V76) })]
	public partial interface IINShareFocusStatusIntentHandling : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("handleShareFocusStatus:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleShareFocusStatus (INShareFocusStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V76))]global::System.Action<INShareFocusStatusIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleShareFocusStatus (IINShareFocusStatusIntentHandling This, INShareFocusStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V76))]global::System.Action<INShareFocusStatusIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V76.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleShareFocusStatus:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[global::Foundation.OptionalMember]
		[Export ("confirmShareFocusStatus:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ConfirmShareFocusStatus (INShareFocusStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V76))]global::System.Action<INShareFocusStatusIntentResponse> completion)
		{
			_ConfirmShareFocusStatus (this, intent, completion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ConfirmShareFocusStatus (IINShareFocusStatusIntentHandling This, INShareFocusStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V76))]global::System.Action<INShareFocusStatusIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V76.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmShareFocusStatus:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[DynamicDependencyAttribute ("ConfirmShareFocusStatus(Intents.INShareFocusStatusIntent,System.Action{Intents.INShareFocusStatusIntentResponse})")]
		[DynamicDependencyAttribute ("HandleShareFocusStatus(Intents.INShareFocusStatusIntent,System.Action{Intents.INShareFocusStatusIntentResponse})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INShareFocusStatusIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINShareFocusStatusIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINShareFocusStatusIntentHandling" /> interface to support all the methods from the INShareFocusStatusIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINShareFocusStatusIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INShareFocusStatusIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INShareFocusStatusIntentHandling_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ConfirmShareFocusStatus (this IINShareFocusStatusIntentHandling This, INShareFocusStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V76))]global::System.Action<INShareFocusStatusIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V76.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmShareFocusStatus:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INShareFocusStatusIntentHandlingWrapper : BaseWrapper, IINShareFocusStatusIntentHandling {
		public INShareFocusStatusIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INShareFocusStatusIntentHandlingWrapper))]
		static INShareFocusStatusIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("handleShareFocusStatus:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleShareFocusStatus (INShareFocusStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V76))]global::System.Action<INShareFocusStatusIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V76.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleShareFocusStatus:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
