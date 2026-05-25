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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Intents {
	#pragma warning disable CS1573
	/// <summary>Interface to resolve, confirm and handle Siri requests for the corresponding action.</summary><remarks>To be added.</remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "INSendRideFeedbackIntentHandling", WrapperType = typeof (INSendRideFeedbackIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleSendRideFeedback", Selector = "handleSendRideFeedback:completion:", ParameterType = new Type [] { typeof (Intents.INSendRideFeedbackIntent), typeof (global::System.Action<global::Intents.INSendRideFeedbackIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V155) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Confirm", Selector = "confirmSendRideFeedback:completion:", ParameterType = new Type [] { typeof (Intents.INSendRideFeedbackIntent), typeof (global::System.Action<global::Intents.INSendRideFeedbackIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V155) })]
	public partial interface IINSendRideFeedbackIntentHandling : INativeObject, IDisposable
	{
		/// <param name="sendRideFeedbackintent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSendRideFeedbackIntentResponse" /> appropriate to the <see cref="T:Intents.INSendRideFeedbackIntent" /> <paramref name="sendRideFeedbackintent" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("handleSendRideFeedback:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleSendRideFeedback (INSendRideFeedbackIntent sendRideFeedbackintent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V155))]global::System.Action<INSendRideFeedbackIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sendRideFeedbackintent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSendRideFeedbackIntentResponse" /> appropriate to the <see cref="T:Intents.INSendRideFeedbackIntent" /> <paramref name="sendRideFeedbackintent" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleSendRideFeedback (IINSendRideFeedbackIntentHandling This, INSendRideFeedbackIntent sendRideFeedbackintent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V155))]global::System.Action<INSendRideFeedbackIntentResponse> completion)
		{
			var sendRideFeedbackintent__handle__ = sendRideFeedbackintent!.GetNonNullHandle (nameof (sendRideFeedbackintent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V155.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleSendRideFeedback:completion:"), sendRideFeedbackintent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (sendRideFeedbackintent);
		}
		/// <param name="sendRideFeedbackIntent">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("confirmSendRideFeedback:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Confirm (INSendRideFeedbackIntent sendRideFeedbackIntent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V155))]global::System.Action<INSendRideFeedbackIntentResponse> completion)
		{
			_Confirm (this, sendRideFeedbackIntent, completion);
		}
		/// <param name="sendRideFeedbackIntent">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Confirm (IINSendRideFeedbackIntentHandling This, INSendRideFeedbackIntent sendRideFeedbackIntent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V155))]global::System.Action<INSendRideFeedbackIntentResponse> completion)
		{
			var sendRideFeedbackIntent__handle__ = sendRideFeedbackIntent!.GetNonNullHandle (nameof (sendRideFeedbackIntent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V155.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmSendRideFeedback:completion:"), sendRideFeedbackIntent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (sendRideFeedbackIntent);
		}
		[DynamicDependencyAttribute ("Confirm(Intents.INSendRideFeedbackIntent,System.Action{Intents.INSendRideFeedbackIntentResponse})")]
		[DynamicDependencyAttribute ("HandleSendRideFeedback(Intents.INSendRideFeedbackIntent,System.Action{Intents.INSendRideFeedbackIntentResponse})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INSendRideFeedbackIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINSendRideFeedbackIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINSendRideFeedbackIntentHandling" /> interface to support all the methods from the INSendRideFeedbackIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINSendRideFeedbackIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INSendRideFeedbackIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INSendRideFeedbackIntentHandling_Extensions {
		/// <param name="sendRideFeedbackIntent">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Confirm (this IINSendRideFeedbackIntentHandling This, INSendRideFeedbackIntent sendRideFeedbackIntent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V155))]global::System.Action<INSendRideFeedbackIntentResponse> completion)
		{
			var sendRideFeedbackIntent__handle__ = sendRideFeedbackIntent!.GetNonNullHandle (nameof (sendRideFeedbackIntent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V155.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmSendRideFeedback:completion:"), sendRideFeedbackIntent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (sendRideFeedbackIntent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INSendRideFeedbackIntentHandlingWrapper : BaseWrapper, IINSendRideFeedbackIntentHandling {
		public INSendRideFeedbackIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INSendRideFeedbackIntentHandlingWrapper))]
		static INSendRideFeedbackIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="sendRideFeedbackintent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSendRideFeedbackIntentResponse" /> appropriate to the <see cref="T:Intents.INSendRideFeedbackIntent" /> <paramref name="sendRideFeedbackintent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleSendRideFeedback:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleSendRideFeedback (INSendRideFeedbackIntent sendRideFeedbackintent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V155))]global::System.Action<INSendRideFeedbackIntentResponse> completion)
		{
			var sendRideFeedbackintent__handle__ = sendRideFeedbackintent!.GetNonNullHandle (nameof (sendRideFeedbackintent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V155.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleSendRideFeedback:completion:"), sendRideFeedbackintent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (sendRideFeedbackintent);
		}
	}
}
