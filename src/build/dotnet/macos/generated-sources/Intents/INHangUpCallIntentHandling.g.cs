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
	/// <summary>This interface represents the Objective-C protocol <c>INHangUpCallIntentHandling</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos13.1")]
	[SupportedOSPlatform ("ios16.2")]
	[SupportedOSPlatform ("maccatalyst16.2")]
	[Protocol (Name = "INHangUpCallIntentHandling", WrapperType = typeof (INHangUpCallIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleHangUpCall", Selector = "handleHangUpCall:completion:", ParameterType = new Type [] { typeof (Intents.INHangUpCallIntent), typeof (global::System.Action<global::Intents.INHangUpCallIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V71) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConfirmHangUpCall", Selector = "confirmHangUpCall:completion:", ParameterType = new Type [] { typeof (Intents.INHangUpCallIntent), typeof (global::System.Action<global::Intents.INHangUpCallIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V71) })]
	public partial interface IINHangUpCallIntentHandling : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("handleHangUpCall:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleHangUpCall (INHangUpCallIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V71))]global::System.Action<INHangUpCallIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleHangUpCall (IINHangUpCallIntentHandling This, INHangUpCallIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V71))]global::System.Action<INHangUpCallIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V71.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleHangUpCall:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[global::Foundation.OptionalMember]
		[Export ("confirmHangUpCall:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ConfirmHangUpCall (INHangUpCallIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V71))]global::System.Action<INHangUpCallIntentResponse> completion)
		{
			_ConfirmHangUpCall (this, intent, completion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ConfirmHangUpCall (IINHangUpCallIntentHandling This, INHangUpCallIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V71))]global::System.Action<INHangUpCallIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V71.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmHangUpCall:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[DynamicDependencyAttribute ("ConfirmHangUpCall(Intents.INHangUpCallIntent,System.Action{Intents.INHangUpCallIntentResponse})")]
		[DynamicDependencyAttribute ("HandleHangUpCall(Intents.INHangUpCallIntent,System.Action{Intents.INHangUpCallIntentResponse})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INHangUpCallIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINHangUpCallIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINHangUpCallIntentHandling" /> interface to support all the methods from the INHangUpCallIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINHangUpCallIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INHangUpCallIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INHangUpCallIntentHandling_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ConfirmHangUpCall (this IINHangUpCallIntentHandling This, INHangUpCallIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V71))]global::System.Action<INHangUpCallIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V71.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmHangUpCall:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INHangUpCallIntentHandlingWrapper : BaseWrapper, IINHangUpCallIntentHandling {
		public INHangUpCallIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INHangUpCallIntentHandlingWrapper))]
		static INHangUpCallIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("handleHangUpCall:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleHangUpCall (INHangUpCallIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V71))]global::System.Action<INHangUpCallIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V71.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleHangUpCall:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
