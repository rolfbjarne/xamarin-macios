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
	/// <summary>Interface to resolve, confirm and handle Siri requests for the corresponding action.</summary><remarks>To be added.</remarks>
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "INGetUserCurrentRestaurantReservationBookingsIntentHandling", WrapperType = typeof (INGetUserCurrentRestaurantReservationBookingsIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleUserCurrentRestaurantReservationBookings", Selector = "handleGetUserCurrentRestaurantReservationBookings:completion:", ParameterType = new Type [] { typeof (Intents.INGetUserCurrentRestaurantReservationBookingsIntent), typeof (global::System.Action<global::Intents.INGetUserCurrentRestaurantReservationBookingsIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V129) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Confirm", Selector = "confirmGetUserCurrentRestaurantReservationBookings:completion:", ParameterType = new Type [] { typeof (Intents.INGetUserCurrentRestaurantReservationBookingsIntent), typeof (global::System.Action<global::Intents.INGetUserCurrentRestaurantReservationBookingsIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V129) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveUserCurrentRestaurantReservationBookings", Selector = "resolveRestaurantForGetUserCurrentRestaurantReservationBookings:withCompletion:", ParameterType = new Type [] { typeof (Intents.INGetUserCurrentRestaurantReservationBookingsIntent), typeof (global::System.Action<global::Intents.INRestaurantResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V98) })]
	public partial interface IINGetUserCurrentRestaurantReservationBookingsIntentHandling : INativeObject, IDisposable
	{
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INGetUserCurrentRestaurantReservationBookingsIntentResponse" /> appropriate to the <see cref="T:Intents.INGetUserCurrentRestaurantReservationBookingsIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("handleGetUserCurrentRestaurantReservationBookings:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleUserCurrentRestaurantReservationBookings (INGetUserCurrentRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V129))]global::System.Action<INGetUserCurrentRestaurantReservationBookingsIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INGetUserCurrentRestaurantReservationBookingsIntentResponse" /> appropriate to the <see cref="T:Intents.INGetUserCurrentRestaurantReservationBookingsIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleUserCurrentRestaurantReservationBookings (IINGetUserCurrentRestaurantReservationBookingsIntentHandling This, INGetUserCurrentRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V129))]global::System.Action<INGetUserCurrentRestaurantReservationBookingsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V129.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleGetUserCurrentRestaurantReservationBookings:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation of the user for the current reservation.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("confirmGetUserCurrentRestaurantReservationBookings:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Confirm (INGetUserCurrentRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V129))]global::System.Action<INGetUserCurrentRestaurantReservationBookingsIntentResponse> completion)
		{
			_Confirm (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation of the user for the current reservation.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Confirm (IINGetUserCurrentRestaurantReservationBookingsIntentHandling This, INGetUserCurrentRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V129))]global::System.Action<INGetUserCurrentRestaurantReservationBookingsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V129.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmGetUserCurrentRestaurantReservationBookings:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the user for the current reservation.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveRestaurantForGetUserCurrentRestaurantReservationBookings:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveUserCurrentRestaurantReservationBookings (INGetUserCurrentRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V98))]global::System.Action<INRestaurantResolutionResult> completion)
		{
			_ResolveUserCurrentRestaurantReservationBookings (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the user for the current reservation.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveUserCurrentRestaurantReservationBookings (IINGetUserCurrentRestaurantReservationBookingsIntentHandling This, INGetUserCurrentRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V98))]global::System.Action<INRestaurantResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V98.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveRestaurantForGetUserCurrentRestaurantReservationBookings:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[DynamicDependencyAttribute ("Confirm(Intents.INGetUserCurrentRestaurantReservationBookingsIntent,System.Action{Intents.INGetUserCurrentRestaurantReservationBookingsIntentResponse})")]
		[DynamicDependencyAttribute ("HandleUserCurrentRestaurantReservationBookings(Intents.INGetUserCurrentRestaurantReservationBookingsIntent,System.Action{Intents.INGetUserCurrentRestaurantReservationBookingsIntentResponse})")]
		[DynamicDependencyAttribute ("ResolveUserCurrentRestaurantReservationBookings(Intents.INGetUserCurrentRestaurantReservationBookingsIntent,System.Action{Intents.INRestaurantResolutionResult})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INGetUserCurrentRestaurantReservationBookingsIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINGetUserCurrentRestaurantReservationBookingsIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINGetUserCurrentRestaurantReservationBookingsIntentHandling" /> interface to support all the methods from the INGetUserCurrentRestaurantReservationBookingsIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINGetUserCurrentRestaurantReservationBookingsIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INGetUserCurrentRestaurantReservationBookingsIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INGetUserCurrentRestaurantReservationBookingsIntentHandling_Extensions {
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation of the user for the current reservation.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Confirm (this IINGetUserCurrentRestaurantReservationBookingsIntentHandling This, INGetUserCurrentRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V129))]global::System.Action<INGetUserCurrentRestaurantReservationBookingsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V129.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmGetUserCurrentRestaurantReservationBookings:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the user for the current reservation.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveUserCurrentRestaurantReservationBookings (this IINGetUserCurrentRestaurantReservationBookingsIntentHandling This, INGetUserCurrentRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V98))]global::System.Action<INRestaurantResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V98.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveRestaurantForGetUserCurrentRestaurantReservationBookings:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INGetUserCurrentRestaurantReservationBookingsIntentHandlingWrapper : BaseWrapper, IINGetUserCurrentRestaurantReservationBookingsIntentHandling {
		public INGetUserCurrentRestaurantReservationBookingsIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INGetUserCurrentRestaurantReservationBookingsIntentHandlingWrapper))]
		static INGetUserCurrentRestaurantReservationBookingsIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INGetUserCurrentRestaurantReservationBookingsIntentResponse" /> appropriate to the <see cref="T:Intents.INGetUserCurrentRestaurantReservationBookingsIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleGetUserCurrentRestaurantReservationBookings:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleUserCurrentRestaurantReservationBookings (INGetUserCurrentRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V129))]global::System.Action<INGetUserCurrentRestaurantReservationBookingsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V129.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleGetUserCurrentRestaurantReservationBookings:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
