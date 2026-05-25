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
	[Protocol (Name = "INListRideOptionsIntentHandling", WrapperType = typeof (INListRideOptionsIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleListRideOptions", Selector = "handleListRideOptions:completion:", ParameterType = new Type [] { typeof (Intents.INListRideOptionsIntent), typeof (global::System.Action<global::Intents.INListRideOptionsIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V120) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Confirm", Selector = "confirmListRideOptions:completion:", ParameterType = new Type [] { typeof (Intents.INListRideOptionsIntent), typeof (global::System.Action<global::Intents.INListRideOptionsIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V120) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolvePickupLocation", Selector = "resolvePickupLocationForListRideOptions:withCompletion:", ParameterType = new Type [] { typeof (Intents.INListRideOptionsIntent), typeof (global::System.Action<global::Intents.INPlacemarkResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V121) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveDropOffLocation", Selector = "resolveDropOffLocationForListRideOptions:withCompletion:", ParameterType = new Type [] { typeof (Intents.INListRideOptionsIntent), typeof (global::System.Action<global::Intents.INPlacemarkResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V121) })]
	public partial interface IINListRideOptionsIntentHandling : INativeObject, IDisposable
	{
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INListRideOptionsIntentResponse" /> appropriate to the <see cref="T:Intents.INListRideOptionsIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("handleListRideOptions:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleListRideOptions (INListRideOptionsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V120))]global::System.Action<INListRideOptionsIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INListRideOptionsIntentResponse" /> appropriate to the <see cref="T:Intents.INListRideOptionsIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleListRideOptions (IINListRideOptionsIntentHandling This, INListRideOptionsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V120))]global::System.Action<INListRideOptionsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V120.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleListRideOptions:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation of the list of ride options.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("confirmListRideOptions:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Confirm (INListRideOptionsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V120))]global::System.Action<INListRideOptionsIntentResponse> completion)
		{
			_Confirm (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation of the list of ride options.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Confirm (IINListRideOptionsIntentHandling This, INListRideOptionsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V120))]global::System.Action<INListRideOptionsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V120.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmListRideOptions:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the pickup location.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolvePickupLocationForListRideOptions:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolvePickupLocation (INListRideOptionsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V121))]global::System.Action<INPlacemarkResolutionResult> completion)
		{
			_ResolvePickupLocation (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the pickup location.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolvePickupLocation (IINListRideOptionsIntentHandling This, INListRideOptionsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V121))]global::System.Action<INPlacemarkResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V121.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolvePickupLocationForListRideOptions:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the dropoff location.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveDropOffLocationForListRideOptions:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveDropOffLocation (INListRideOptionsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V121))]global::System.Action<INPlacemarkResolutionResult> completion)
		{
			_ResolveDropOffLocation (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the dropoff location.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveDropOffLocation (IINListRideOptionsIntentHandling This, INListRideOptionsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V121))]global::System.Action<INPlacemarkResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V121.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveDropOffLocationForListRideOptions:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[DynamicDependencyAttribute ("Confirm(Intents.INListRideOptionsIntent,System.Action{Intents.INListRideOptionsIntentResponse})")]
		[DynamicDependencyAttribute ("HandleListRideOptions(Intents.INListRideOptionsIntent,System.Action{Intents.INListRideOptionsIntentResponse})")]
		[DynamicDependencyAttribute ("ResolveDropOffLocation(Intents.INListRideOptionsIntent,System.Action{Intents.INPlacemarkResolutionResult})")]
		[DynamicDependencyAttribute ("ResolvePickupLocation(Intents.INListRideOptionsIntent,System.Action{Intents.INPlacemarkResolutionResult})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INListRideOptionsIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINListRideOptionsIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINListRideOptionsIntentHandling" /> interface to support all the methods from the INListRideOptionsIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINListRideOptionsIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INListRideOptionsIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INListRideOptionsIntentHandling_Extensions {
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation of the list of ride options.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Confirm (this IINListRideOptionsIntentHandling This, INListRideOptionsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V120))]global::System.Action<INListRideOptionsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V120.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmListRideOptions:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the pickup location.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolvePickupLocation (this IINListRideOptionsIntentHandling This, INListRideOptionsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V121))]global::System.Action<INPlacemarkResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V121.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolvePickupLocationForListRideOptions:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the dropoff location.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveDropOffLocation (this IINListRideOptionsIntentHandling This, INListRideOptionsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V121))]global::System.Action<INPlacemarkResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V121.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveDropOffLocationForListRideOptions:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INListRideOptionsIntentHandlingWrapper : BaseWrapper, IINListRideOptionsIntentHandling {
		public INListRideOptionsIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INListRideOptionsIntentHandlingWrapper))]
		static INListRideOptionsIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INListRideOptionsIntentResponse" /> appropriate to the <see cref="T:Intents.INListRideOptionsIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleListRideOptions:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleListRideOptions (INListRideOptionsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V120))]global::System.Action<INListRideOptionsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V120.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleListRideOptions:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
