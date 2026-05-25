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
	[Protocol (Name = "INGetAvailableRestaurantReservationBookingsIntentHandling", WrapperType = typeof (INGetAvailableRestaurantReservationBookingsIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleAvailableRestaurantReservationBookings", Selector = "handleGetAvailableRestaurantReservationBookings:completion:", ParameterType = new Type [] { typeof (Intents.INGetAvailableRestaurantReservationBookingsIntent), typeof (global::System.Action<global::Intents.INGetAvailableRestaurantReservationBookingsIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V126) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Confirm", Selector = "confirmGetAvailableRestaurantReservationBookings:completion:", ParameterType = new Type [] { typeof (Intents.INGetAvailableRestaurantReservationBookingsIntent), typeof (global::System.Action<global::Intents.INGetAvailableRestaurantReservationBookingsIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V126) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveAvailableRestaurantReservationBookings", Selector = "resolveRestaurantForGetAvailableRestaurantReservationBookings:withCompletion:", ParameterType = new Type [] { typeof (Intents.INGetAvailableRestaurantReservationBookingsIntent), typeof (global::System.Action<global::Intents.INRestaurantResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V98) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolvePartySizeAvailableRestaurantReservationBookings", Selector = "resolvePartySizeForGetAvailableRestaurantReservationBookings:withCompletion:", ParameterType = new Type [] { typeof (Intents.INGetAvailableRestaurantReservationBookingsIntent), typeof (global::System.Action<global::Intents.INIntegerResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V100) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolvePreferredBookingDateAvailableRestaurantReservationBookings", Selector = "resolvePreferredBookingDateComponentsForGetAvailableRestaurantReservationBookings:withCompletion:", ParameterType = new Type [] { typeof (Intents.INGetAvailableRestaurantReservationBookingsIntent), typeof (global::System.Action<global::Intents.INDateComponentsResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V99) })]
	public partial interface IINGetAvailableRestaurantReservationBookingsIntentHandling : INativeObject, IDisposable
	{
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INGetAvailableRestaurantReservationBookingsIntentResponse" /> appropriate to the <see cref="T:Intents.INGetAvailableRestaurantReservationBookingsIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("handleGetAvailableRestaurantReservationBookings:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleAvailableRestaurantReservationBookings (INGetAvailableRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V126))]global::System.Action<INGetAvailableRestaurantReservationBookingsIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INGetAvailableRestaurantReservationBookingsIntentResponse" /> appropriate to the <see cref="T:Intents.INGetAvailableRestaurantReservationBookingsIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleAvailableRestaurantReservationBookings (IINGetAvailableRestaurantReservationBookingsIntentHandling This, INGetAvailableRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V126))]global::System.Action<INGetAvailableRestaurantReservationBookingsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V126.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleGetAvailableRestaurantReservationBookings:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation that the developer's app can provide available reservations.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("confirmGetAvailableRestaurantReservationBookings:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Confirm (INGetAvailableRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V126))]global::System.Action<INGetAvailableRestaurantReservationBookingsIntentResponse> completion)
		{
			_Confirm (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation that the developer's app can provide available reservations.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Confirm (IINGetAvailableRestaurantReservationBookingsIntentHandling This, INGetAvailableRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V126))]global::System.Action<INGetAvailableRestaurantReservationBookingsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V126.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmGetAvailableRestaurantReservationBookings:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the restaurant for gathering available reservations.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveRestaurantForGetAvailableRestaurantReservationBookings:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveAvailableRestaurantReservationBookings (INGetAvailableRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V98))]global::System.Action<INRestaurantResolutionResult> completion)
		{
			_ResolveAvailableRestaurantReservationBookings (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the restaurant for gathering available reservations.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveAvailableRestaurantReservationBookings (IINGetAvailableRestaurantReservationBookingsIntentHandling This, INGetAvailableRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V98))]global::System.Action<INRestaurantResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V98.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveRestaurantForGetAvailableRestaurantReservationBookings:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the number of guests in the reservation.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolvePartySizeForGetAvailableRestaurantReservationBookings:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolvePartySizeAvailableRestaurantReservationBookings (INGetAvailableRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V100))]global::System.Action<INIntegerResolutionResult> completion)
		{
			_ResolvePartySizeAvailableRestaurantReservationBookings (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the number of guests in the reservation.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolvePartySizeAvailableRestaurantReservationBookings (IINGetAvailableRestaurantReservationBookingsIntentHandling This, INGetAvailableRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V100))]global::System.Action<INIntegerResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V100.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolvePartySizeForGetAvailableRestaurantReservationBookings:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the preferred dates for the reservation.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolvePreferredBookingDateComponentsForGetAvailableRestaurantReservationBookings:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolvePreferredBookingDateAvailableRestaurantReservationBookings (INGetAvailableRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V99))]global::System.Action<INDateComponentsResolutionResult> completion)
		{
			_ResolvePreferredBookingDateAvailableRestaurantReservationBookings (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the preferred dates for the reservation.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolvePreferredBookingDateAvailableRestaurantReservationBookings (IINGetAvailableRestaurantReservationBookingsIntentHandling This, INGetAvailableRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V99))]global::System.Action<INDateComponentsResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V99.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolvePreferredBookingDateComponentsForGetAvailableRestaurantReservationBookings:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[DynamicDependencyAttribute ("Confirm(Intents.INGetAvailableRestaurantReservationBookingsIntent,System.Action{Intents.INGetAvailableRestaurantReservationBookingsIntentResponse})")]
		[DynamicDependencyAttribute ("HandleAvailableRestaurantReservationBookings(Intents.INGetAvailableRestaurantReservationBookingsIntent,System.Action{Intents.INGetAvailableRestaurantReservationBookingsIntentResponse})")]
		[DynamicDependencyAttribute ("ResolveAvailableRestaurantReservationBookings(Intents.INGetAvailableRestaurantReservationBookingsIntent,System.Action{Intents.INRestaurantResolutionResult})")]
		[DynamicDependencyAttribute ("ResolvePartySizeAvailableRestaurantReservationBookings(Intents.INGetAvailableRestaurantReservationBookingsIntent,System.Action{Intents.INIntegerResolutionResult})")]
		[DynamicDependencyAttribute ("ResolvePreferredBookingDateAvailableRestaurantReservationBookings(Intents.INGetAvailableRestaurantReservationBookingsIntent,System.Action{Intents.INDateComponentsResolutionResult})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INGetAvailableRestaurantReservationBookingsIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINGetAvailableRestaurantReservationBookingsIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINGetAvailableRestaurantReservationBookingsIntentHandling" /> interface to support all the methods from the INGetAvailableRestaurantReservationBookingsIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINGetAvailableRestaurantReservationBookingsIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INGetAvailableRestaurantReservationBookingsIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INGetAvailableRestaurantReservationBookingsIntentHandling_Extensions {
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the confirmation that the developer's app can provide available reservations.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Confirm (this IINGetAvailableRestaurantReservationBookingsIntentHandling This, INGetAvailableRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V126))]global::System.Action<INGetAvailableRestaurantReservationBookingsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V126.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmGetAvailableRestaurantReservationBookings:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the restaurant for gathering available reservations.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveAvailableRestaurantReservationBookings (this IINGetAvailableRestaurantReservationBookingsIntentHandling This, INGetAvailableRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V98))]global::System.Action<INRestaurantResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V98.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveRestaurantForGetAvailableRestaurantReservationBookings:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the number of guests in the reservation.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolvePartySizeAvailableRestaurantReservationBookings (this IINGetAvailableRestaurantReservationBookingsIntentHandling This, INGetAvailableRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V100))]global::System.Action<INIntegerResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V100.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolvePartySizeForGetAvailableRestaurantReservationBookings:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may override this method to customize the resolution of the preferred dates for the reservation.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolvePreferredBookingDateAvailableRestaurantReservationBookings (this IINGetAvailableRestaurantReservationBookingsIntentHandling This, INGetAvailableRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V99))]global::System.Action<INDateComponentsResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V99.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolvePreferredBookingDateComponentsForGetAvailableRestaurantReservationBookings:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INGetAvailableRestaurantReservationBookingsIntentHandlingWrapper : BaseWrapper, IINGetAvailableRestaurantReservationBookingsIntentHandling {
		public INGetAvailableRestaurantReservationBookingsIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INGetAvailableRestaurantReservationBookingsIntentHandlingWrapper))]
		static INGetAvailableRestaurantReservationBookingsIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INGetAvailableRestaurantReservationBookingsIntentResponse" /> appropriate to the <see cref="T:Intents.INGetAvailableRestaurantReservationBookingsIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleGetAvailableRestaurantReservationBookings:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleAvailableRestaurantReservationBookings (INGetAvailableRestaurantReservationBookingsIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V126))]global::System.Action<INGetAvailableRestaurantReservationBookingsIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V126.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleGetAvailableRestaurantReservationBookings:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
