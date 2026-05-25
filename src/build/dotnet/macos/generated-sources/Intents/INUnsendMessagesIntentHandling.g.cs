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
	/// <summary>This interface represents the Objective-C protocol <c>INUnsendMessagesIntentHandling</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[Protocol (Name = "INUnsendMessagesIntentHandling", WrapperType = typeof (INUnsendMessagesIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleUnsendMessages", Selector = "handleUnsendMessages:completion:", ParameterType = new Type [] { typeof (Intents.INUnsendMessagesIntent), typeof (global::System.Action<global::Intents.INUnsendMessagesIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V77) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConfirmUnsendMessages", Selector = "confirmUnsendMessages:completion:", ParameterType = new Type [] { typeof (Intents.INUnsendMessagesIntent), typeof (global::System.Action<global::Intents.INUnsendMessagesIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V77) })]
	public partial interface IINUnsendMessagesIntentHandling : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("handleUnsendMessages:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleUnsendMessages (INUnsendMessagesIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V77))]global::System.Action<INUnsendMessagesIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleUnsendMessages (IINUnsendMessagesIntentHandling This, INUnsendMessagesIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V77))]global::System.Action<INUnsendMessagesIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V77.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleUnsendMessages:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[global::Foundation.OptionalMember]
		[Export ("confirmUnsendMessages:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ConfirmUnsendMessages (INUnsendMessagesIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V77))]global::System.Action<INUnsendMessagesIntentResponse> completion)
		{
			_ConfirmUnsendMessages (this, intent, completion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ConfirmUnsendMessages (IINUnsendMessagesIntentHandling This, INUnsendMessagesIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V77))]global::System.Action<INUnsendMessagesIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V77.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmUnsendMessages:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[DynamicDependencyAttribute ("ConfirmUnsendMessages(Intents.INUnsendMessagesIntent,System.Action{Intents.INUnsendMessagesIntentResponse})")]
		[DynamicDependencyAttribute ("HandleUnsendMessages(Intents.INUnsendMessagesIntent,System.Action{Intents.INUnsendMessagesIntentResponse})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INUnsendMessagesIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINUnsendMessagesIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINUnsendMessagesIntentHandling" /> interface to support all the methods from the INUnsendMessagesIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINUnsendMessagesIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INUnsendMessagesIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INUnsendMessagesIntentHandling_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ConfirmUnsendMessages (this IINUnsendMessagesIntentHandling This, INUnsendMessagesIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V77))]global::System.Action<INUnsendMessagesIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V77.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmUnsendMessages:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INUnsendMessagesIntentHandlingWrapper : BaseWrapper, IINUnsendMessagesIntentHandling {
		public INUnsendMessagesIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INUnsendMessagesIntentHandlingWrapper))]
		static INUnsendMessagesIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("handleUnsendMessages:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleUnsendMessages (INUnsendMessagesIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V77))]global::System.Action<INUnsendMessagesIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V77.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleUnsendMessages:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
