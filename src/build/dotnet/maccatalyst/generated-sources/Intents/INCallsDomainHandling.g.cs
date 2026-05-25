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
	/// <summary> Interface combining several interfaces related to various phone-call intents.</summary>
	[UnsupportedOSPlatform ("macos")]
	[ObsoletedOSPlatform ("ios13.0", "Implement 'INStartAudioCallIntentHandling, INStartVideoCallIntentHandling and INSearchCallHistoryIntentHandling' instead.")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Implement 'INStartAudioCallIntentHandling, INStartVideoCallIntentHandling and INSearchCallHistoryIntentHandling' instead.")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "INCallsDomainHandling", WrapperType = typeof (INCallsDomainHandlingWrapper))]
	public partial interface IINCallsDomainHandling : INativeObject, IDisposable, 
		Intents.IINSearchCallHistoryIntentHandling
		, Intents.IINStartAudioCallIntentHandling
		, Intents.IINStartVideoCallIntentHandling
	{
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INCallsDomainHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINCallsDomainHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INCallsDomainHandlingWrapper : BaseWrapper, IINCallsDomainHandling {
		public INCallsDomainHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INCallsDomainHandlingWrapper))]
		static INCallsDomainHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSearchCallHistoryIntentResponse" /> appropriate to the <see cref="T:Intents.INSearchCallHistoryIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleSearchCallHistory:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleSearchCallHistory (INSearchCallHistoryIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V89))]global::System.Action<INSearchCallHistoryIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V89.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleSearchCallHistory:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INStartAudioCallIntentResponse" /> appropriate to the <see cref="T:Intents.INStartAudioCallIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleStartAudioCall:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleStartAudioCall (INStartAudioCallIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V90))]global::System.Action<INStartAudioCallIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V90.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleStartAudioCall:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INStartVideoCallIntentResponse" /> appropriate to the <see cref="T:Intents.INStartVideoCallIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleStartVideoCall:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleStartVideoCall (INStartVideoCallIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V91))]global::System.Action<INStartVideoCallIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V91.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleStartVideoCall:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
