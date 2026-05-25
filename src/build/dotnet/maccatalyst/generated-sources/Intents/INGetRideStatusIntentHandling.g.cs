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
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "INGetRideStatusIntentHandling", WrapperType = typeof (INGetRideStatusIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleRideStatus", Selector = "handleGetRideStatus:completion:", ParameterType = new Type [] { typeof (Intents.INGetRideStatusIntent), typeof (global::System.Action<global::Intents.INGetRideStatusIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V114) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StartSendingUpdates", Selector = "startSendingUpdatesForGetRideStatus:toObserver:", ParameterType = new Type [] { typeof (Intents.INGetRideStatusIntent), typeof (Intents.IINGetRideStatusIntentResponseObserver) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StopSendingUpdates", Selector = "stopSendingUpdatesForGetRideStatus:", ParameterType = new Type [] { typeof (Intents.INGetRideStatusIntent) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Confirm", Selector = "confirmGetRideStatus:completion:", ParameterType = new Type [] { typeof (Intents.INGetRideStatusIntent), typeof (global::System.Action<global::Intents.INGetRideStatusIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V114) })]
	public partial interface IINGetRideStatusIntentHandling : INativeObject, IDisposable
	{
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INGetRideStatusIntentResponse" /> appropriate to the <see cref="T:Intents.INGetRideStatusIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("handleGetRideStatus:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleRideStatus (INGetRideStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V114))]global::System.Action<INGetRideStatusIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INGetRideStatusIntentResponse" /> appropriate to the <see cref="T:Intents.INGetRideStatusIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleRideStatus (IINGetRideStatusIntentHandling This, INGetRideStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V114))]global::System.Action<INGetRideStatusIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V114.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleGetRideStatus:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">To be added.</param><param name="observer">To be added.</param><summary>Developers may call this method to begin sending updates about the ride status.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("startSendingUpdatesForGetRideStatus:toObserver:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartSendingUpdates (INGetRideStatusIntent intent, IINGetRideStatusIntentResponseObserver observer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="intent">To be added.</param><param name="observer">To be added.</param><summary>Developers may call this method to begin sending updates about the ride status.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _StartSendingUpdates (IINGetRideStatusIntentHandling This, INGetRideStatusIntent intent, IINGetRideStatusIntentResponseObserver observer)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("startSendingUpdatesForGetRideStatus:toObserver:"), intent__handle__, observer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
			GC.KeepAlive (observer);
		}
		/// <param name="intent">To be added.</param><summary>Developers may call this method to end the sending of updates about the ride status.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("stopSendingUpdatesForGetRideStatus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopSendingUpdates (INGetRideStatusIntent intent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="intent">To be added.</param><summary>Developers may call this method to end the sending of updates about the ride status.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _StopSendingUpdates (IINGetRideStatusIntentHandling This, INGetRideStatusIntent intent)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("stopSendingUpdatesForGetRideStatus:"), intent__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation of a ride's status.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("confirmGetRideStatus:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Confirm (INGetRideStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V114))]global::System.Action<INGetRideStatusIntentResponse> completion)
		{
			_Confirm (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation of a ride's status.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Confirm (IINGetRideStatusIntentHandling This, INGetRideStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V114))]global::System.Action<INGetRideStatusIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V114.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmGetRideStatus:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[DynamicDependencyAttribute ("Confirm(Intents.INGetRideStatusIntent,System.Action{Intents.INGetRideStatusIntentResponse})")]
		[DynamicDependencyAttribute ("HandleRideStatus(Intents.INGetRideStatusIntent,System.Action{Intents.INGetRideStatusIntentResponse})")]
		[DynamicDependencyAttribute ("StartSendingUpdates(Intents.INGetRideStatusIntent,Intents.IINGetRideStatusIntentResponseObserver)")]
		[DynamicDependencyAttribute ("StopSendingUpdates(Intents.INGetRideStatusIntent)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INGetRideStatusIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINGetRideStatusIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINGetRideStatusIntentHandling" /> interface to support all the methods from the INGetRideStatusIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINGetRideStatusIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INGetRideStatusIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INGetRideStatusIntentHandling_Extensions {
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation of a ride's status.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Confirm (this IINGetRideStatusIntentHandling This, INGetRideStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V114))]global::System.Action<INGetRideStatusIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V114.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmGetRideStatus:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INGetRideStatusIntentHandlingWrapper : BaseWrapper, IINGetRideStatusIntentHandling {
		public INGetRideStatusIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INGetRideStatusIntentHandlingWrapper))]
		static INGetRideStatusIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INGetRideStatusIntentResponse" /> appropriate to the <see cref="T:Intents.INGetRideStatusIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleGetRideStatus:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleRideStatus (INGetRideStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V114))]global::System.Action<INGetRideStatusIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V114.CreateBlock (completion);
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
	}
}
