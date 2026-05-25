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
namespace Intents {
	#pragma warning disable CS1573
	/// <summary>Interface combining several interfaces related to various car-related intents.</summary>
	[ObsoletedOSPlatform ("ios13.0", "Implement 'INActivateCarSignalIntentHandling, INSetCarLockStatusIntentHandling, INGetCarLockStatusIntentHandling and INGetCarPowerLevelStatusIntentHandling' instead.")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Implement 'INActivateCarSignalIntentHandling, INSetCarLockStatusIntentHandling, INGetCarLockStatusIntentHandling and INGetCarPowerLevelStatusIntentHandling' instead.")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "INCarCommandsDomainHandling", WrapperType = typeof (INCarCommandsDomainHandlingWrapper))]
	public partial interface IINCarCommandsDomainHandling : INativeObject, IDisposable, 
		Intents.IINActivateCarSignalIntentHandling
		, Intents.IINGetCarLockStatusIntentHandling
		, Intents.IINGetCarPowerLevelStatusIntentHandling
		, Intents.IINSetCarLockStatusIntentHandling
	{
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INCarCommandsDomainHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINCarCommandsDomainHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INCarCommandsDomainHandlingWrapper : BaseWrapper, IINCarCommandsDomainHandling {
		public INCarCommandsDomainHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INCarCommandsDomainHandlingWrapper))]
		static INCarCommandsDomainHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INActivateCarSignalIntentResponse" /> appropriate to the <see cref="T:Intents.INActivateCarSignalIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleActivateCarSignal:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleActivateCarSignal (INActivateCarSignalIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V79))]global::System.Action<INActivateCarSignalIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V79.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleActivateCarSignal:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INGetCarLockStatusIntentResponse" /> appropriate to the <see cref="T:Intents.INGetCarLockStatusIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleGetCarLockStatus:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleGetCarLockStatus (INGetCarLockStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V108))]global::System.Action<INGetCarLockStatusIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V108.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleGetCarLockStatus:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INGetCarPowerLevelStatusIntentResponse" /> appropriate to the <see cref="T:Intents.INGetCarPowerLevelStatusIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleGetCarPowerLevelStatus:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleGetCarPowerLevelStatus (INGetCarPowerLevelStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V109))]global::System.Action<INGetCarPowerLevelStatusIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V109.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleGetCarPowerLevelStatus:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSetCarLockStatusIntentResponse" /> appropriate to the <see cref="T:Intents.INSetCarLockStatusIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleSetCarLockStatus:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleSetCarLockStatus (INSetCarLockStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V110))]global::System.Action<INSetCarLockStatusIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V110.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleSetCarLockStatus:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
