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
	/// <summary>Interface combining several interfaces related to various ridesharing intents.</summary>
	[ObsoletedOSPlatform ("ios13.0", "Implement 'INListRideOptionsIntentHandling, INRequestRideIntentHandling, INGetRideStatusIntentHandling, INCancelRideIntentHandling and INSendRideFeedbackIntentHandling' instead.")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Implement 'INListRideOptionsIntentHandling, INRequestRideIntentHandling, INGetRideStatusIntentHandling, INCancelRideIntentHandling and INSendRideFeedbackIntentHandling' instead.")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "INRidesharingDomainHandling", WrapperType = typeof (INRidesharingDomainHandlingWrapper))]
	public partial interface IINRidesharingDomainHandling : INativeObject, IDisposable, 
		Intents.IINCancelRideIntentHandling
		, Intents.IINGetRideStatusIntentHandling
		, Intents.IINListRideOptionsIntentHandling
		, Intents.IINRequestRideIntentHandling
		, Intents.IINSendRideFeedbackIntentHandling
	{
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INRidesharingDomainHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINRidesharingDomainHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INRidesharingDomainHandlingWrapper : BaseWrapper, IINRidesharingDomainHandling {
		public INRidesharingDomainHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INRidesharingDomainHandlingWrapper))]
		static INRidesharingDomainHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INCancelRideIntentResponse" /> appropriate to the <see cref="T:Intents.INCancelRideIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleCancelRide:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleCancelRide (INCancelRideIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V106))]global::System.Action<INCancelRideIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V106.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleCancelRide:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INGetRideStatusIntentResponse" /> appropriate to the <see cref="T:Intents.INGetRideStatusIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleGetRideStatus:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleRideStatus (INGetRideStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V128))]global::System.Action<INGetRideStatusIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V128.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleGetRideStatus:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">To be added.</param><param name="observer">To be added.</param><summary>Developers may call this method to begin sending updates about the ride status.</summary><remarks>To be added.</remarks>
		[Export ("startSendingUpdatesForGetRideStatus:toObserver:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void StartSendingUpdates (INGetRideStatusIntent intent, IINGetRideStatusIntentResponseObserver observer)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("startSendingUpdatesForGetRideStatus:toObserver:"), intent__handle__, observer__handle__);
			GC.KeepAlive (intent);
			GC.KeepAlive (observer);
		}
		/// <param name="intent">To be added.</param><summary>Developers may call this method to end the sending of updates about the ride status.</summary><remarks>To be added.</remarks>
		[Export ("stopSendingUpdatesForGetRideStatus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void StopSendingUpdates (INGetRideStatusIntent intent)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("stopSendingUpdatesForGetRideStatus:"), intent__handle__);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INListRideOptionsIntentResponse" /> appropriate to the <see cref="T:Intents.INListRideOptionsIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleListRideOptions:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleListRideOptions (INListRideOptionsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V135))]global::System.Action<INListRideOptionsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V135.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleListRideOptions:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INRequestRideIntentResponse" /> appropriate to the <see cref="T:Intents.INRequestRideIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleRequestRide:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleRequestRide (INRequestRideIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V168))]global::System.Action<INRequestRideIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V168.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleRequestRide:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
		/// <param name="sendRideFeedbackintent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INSendRideFeedbackIntentResponse" /> appropriate to the <see cref="T:Intents.INSendRideFeedbackIntent" /> <paramref name="sendRideFeedbackintent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleSendRideFeedback:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleSendRideFeedback (INSendRideFeedbackIntent sendRideFeedbackintent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V170))]global::System.Action<INSendRideFeedbackIntentResponse> completion)
		{
			var sendRideFeedbackintent__handle__ = sendRideFeedbackintent!.GetNonNullHandle (nameof (sendRideFeedbackintent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V170.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleSendRideFeedback:completion:"), sendRideFeedbackintent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (sendRideFeedbackintent);
		}
	}
}
