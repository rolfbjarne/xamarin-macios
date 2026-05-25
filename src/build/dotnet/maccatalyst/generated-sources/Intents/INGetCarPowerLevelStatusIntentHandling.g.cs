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
	[Protocol (Name = "INGetCarPowerLevelStatusIntentHandling", WrapperType = typeof (INGetCarPowerLevelStatusIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleGetCarPowerLevelStatus", Selector = "handleGetCarPowerLevelStatus:completion:", ParameterType = new Type [] { typeof (Intents.INGetCarPowerLevelStatusIntent), typeof (global::System.Action<global::Intents.INGetCarPowerLevelStatusIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V95) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "StartSendingUpdates", Selector = "startSendingUpdatesForGetCarPowerLevelStatus:toObserver:", ParameterType = new Type [] { typeof (Intents.INGetCarPowerLevelStatusIntent), typeof (Intents.IINGetCarPowerLevelStatusIntentResponseObserver) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "StopSendingUpdates", Selector = "stopSendingUpdatesForGetCarPowerLevelStatus:", ParameterType = new Type [] { typeof (Intents.INGetCarPowerLevelStatusIntent) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Confirm", Selector = "confirmGetCarPowerLevelStatus:completion:", ParameterType = new Type [] { typeof (Intents.INGetCarPowerLevelStatusIntent), typeof (global::System.Action<global::Intents.INGetCarPowerLevelStatusIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V95) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveCarName", Selector = "resolveCarNameForGetCarPowerLevelStatus:withCompletion:", ParameterType = new Type [] { typeof (Intents.INGetCarPowerLevelStatusIntent), typeof (global::System.Action<global::Intents.INSpeakableStringResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V66) })]
	public partial interface IINGetCarPowerLevelStatusIntentHandling : INativeObject, IDisposable
	{
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INGetCarPowerLevelStatusIntentResponse" /> appropriate to the <see cref="T:Intents.INGetCarPowerLevelStatusIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("handleGetCarPowerLevelStatus:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleGetCarPowerLevelStatus (INGetCarPowerLevelStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V95))]global::System.Action<INGetCarPowerLevelStatusIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INGetCarPowerLevelStatusIntentResponse" /> appropriate to the <see cref="T:Intents.INGetCarPowerLevelStatusIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleGetCarPowerLevelStatus (IINGetCarPowerLevelStatusIntentHandling This, INGetCarPowerLevelStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V95))]global::System.Action<INGetCarPowerLevelStatusIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V95.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleGetCarPowerLevelStatus:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[global::Foundation.OptionalMember]
		[Export ("startSendingUpdatesForGetCarPowerLevelStatus:toObserver:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartSendingUpdates (INGetCarPowerLevelStatusIntent intent, IINGetCarPowerLevelStatusIntentResponseObserver observer)
		{
			_StartSendingUpdates (this, intent, observer);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _StartSendingUpdates (IINGetCarPowerLevelStatusIntentHandling This, INGetCarPowerLevelStatusIntent intent, IINGetCarPowerLevelStatusIntentResponseObserver observer)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("startSendingUpdatesForGetCarPowerLevelStatus:toObserver:"), intent__handle__, observer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
			GC.KeepAlive (observer);
		}
		[global::Foundation.OptionalMember]
		[Export ("stopSendingUpdatesForGetCarPowerLevelStatus:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopSendingUpdates (INGetCarPowerLevelStatusIntent intent)
		{
			_StopSendingUpdates (this, intent);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _StopSendingUpdates (IINGetCarPowerLevelStatusIntentHandling This, INGetCarPowerLevelStatusIntent intent)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("stopSendingUpdatesForGetCarPowerLevelStatus:"), intent__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to confirm whether the car's power levels can be accessed.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("confirmGetCarPowerLevelStatus:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Confirm (INGetCarPowerLevelStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V95))]global::System.Action<INGetCarPowerLevelStatusIntentResponse> completion)
		{
			_Confirm (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to confirm whether the car's power levels can be accessed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Confirm (IINGetCarPowerLevelStatusIntentHandling This, INGetCarPowerLevelStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V95))]global::System.Action<INGetCarPowerLevelStatusIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V95.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmGetCarPowerLevelStatus:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to resolve the car's name.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveCarNameForGetCarPowerLevelStatus:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveCarName (INGetCarPowerLevelStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V66))]global::System.Action<INSpeakableStringResolutionResult> completion)
		{
			_ResolveCarName (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to resolve the car's name.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveCarName (IINGetCarPowerLevelStatusIntentHandling This, INGetCarPowerLevelStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V66))]global::System.Action<INSpeakableStringResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V66.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveCarNameForGetCarPowerLevelStatus:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[DynamicDependencyAttribute ("Confirm(Intents.INGetCarPowerLevelStatusIntent,System.Action{Intents.INGetCarPowerLevelStatusIntentResponse})")]
		[DynamicDependencyAttribute ("HandleGetCarPowerLevelStatus(Intents.INGetCarPowerLevelStatusIntent,System.Action{Intents.INGetCarPowerLevelStatusIntentResponse})")]
		[DynamicDependencyAttribute ("ResolveCarName(Intents.INGetCarPowerLevelStatusIntent,System.Action{Intents.INSpeakableStringResolutionResult})")]
		[DynamicDependencyAttribute ("StartSendingUpdates(Intents.INGetCarPowerLevelStatusIntent,Intents.IINGetCarPowerLevelStatusIntentResponseObserver)")]
		[DynamicDependencyAttribute ("StopSendingUpdates(Intents.INGetCarPowerLevelStatusIntent)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INGetCarPowerLevelStatusIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINGetCarPowerLevelStatusIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINGetCarPowerLevelStatusIntentHandling" /> interface to support all the methods from the INGetCarPowerLevelStatusIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINGetCarPowerLevelStatusIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INGetCarPowerLevelStatusIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INGetCarPowerLevelStatusIntentHandling_Extensions {
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StartSendingUpdates (this IINGetCarPowerLevelStatusIntentHandling This, INGetCarPowerLevelStatusIntent intent, IINGetCarPowerLevelStatusIntentResponseObserver observer)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("startSendingUpdatesForGetCarPowerLevelStatus:toObserver:"), intent__handle__, observer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
			GC.KeepAlive (observer);
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StopSendingUpdates (this IINGetCarPowerLevelStatusIntentHandling This, INGetCarPowerLevelStatusIntent intent)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("stopSendingUpdatesForGetCarPowerLevelStatus:"), intent__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to confirm whether the car's power levels can be accessed.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Confirm (this IINGetCarPowerLevelStatusIntentHandling This, INGetCarPowerLevelStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V95))]global::System.Action<INGetCarPowerLevelStatusIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V95.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmGetCarPowerLevelStatus:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to resolve the car's name.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveCarName (this IINGetCarPowerLevelStatusIntentHandling This, INGetCarPowerLevelStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V66))]global::System.Action<INSpeakableStringResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V66.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveCarNameForGetCarPowerLevelStatus:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INGetCarPowerLevelStatusIntentHandlingWrapper : BaseWrapper, IINGetCarPowerLevelStatusIntentHandling {
		public INGetCarPowerLevelStatusIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INGetCarPowerLevelStatusIntentHandlingWrapper))]
		static INGetCarPowerLevelStatusIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INGetCarPowerLevelStatusIntentResponse" /> appropriate to the <see cref="T:Intents.INGetCarPowerLevelStatusIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleGetCarPowerLevelStatus:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleGetCarPowerLevelStatus (INGetCarPowerLevelStatusIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V95))]global::System.Action<INGetCarPowerLevelStatusIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V95.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleGetCarPowerLevelStatus:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
