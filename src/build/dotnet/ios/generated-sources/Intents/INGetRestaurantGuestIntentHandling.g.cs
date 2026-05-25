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
	[Protocol (Name = "INGetRestaurantGuestIntentHandling", WrapperType = typeof (INGetRestaurantGuestIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleRestaurantGuest", Selector = "handleGetRestaurantGuest:completion:", ParameterType = new Type [] { typeof (Intents.INGetRestaurantGuestIntent), typeof (global::System.Action<global::Intents.INGetRestaurantGuestIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V127) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Confirm", Selector = "confirmGetRestaurantGuest:completion:", ParameterType = new Type [] { typeof (Intents.INGetRestaurantGuestIntent), typeof (global::System.Action<global::Intents.INGetRestaurantGuestIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V127) })]
	public partial interface IINGetRestaurantGuestIntentHandling : INativeObject, IDisposable
	{
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INGetRestaurantGuestIntentResponse" /> appropriate to the <see cref="T:Intents.INGetRestaurantGuestIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("handleGetRestaurantGuest:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleRestaurantGuest (INGetRestaurantGuestIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V127))]global::System.Action<INGetRestaurantGuestIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INGetRestaurantGuestIntentResponse" /> appropriate to the <see cref="T:Intents.INGetRestaurantGuestIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleRestaurantGuest (IINGetRestaurantGuestIntentHandling This, INGetRestaurantGuestIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V127))]global::System.Action<INGetRestaurantGuestIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V127.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleGetRestaurantGuest:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="guestIntent">To be added.</param><param name="completion">To be added.</param><summary>Developers may override this method to customize the confirmation of a guest for a restaurant reservation.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("confirmGetRestaurantGuest:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Confirm (INGetRestaurantGuestIntent guestIntent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V127))]global::System.Action<INGetRestaurantGuestIntentResponse> completion)
		{
			_Confirm (this, guestIntent, completion);
		}
		/// <param name="guestIntent">To be added.</param><param name="completion">To be added.</param><summary>Developers may override this method to customize the confirmation of a guest for a restaurant reservation.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Confirm (IINGetRestaurantGuestIntentHandling This, INGetRestaurantGuestIntent guestIntent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V127))]global::System.Action<INGetRestaurantGuestIntentResponse> completion)
		{
			var guestIntent__handle__ = guestIntent!.GetNonNullHandle (nameof (guestIntent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V127.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmGetRestaurantGuest:completion:"), guestIntent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (guestIntent);
		}
		[DynamicDependencyAttribute ("Confirm(Intents.INGetRestaurantGuestIntent,System.Action{Intents.INGetRestaurantGuestIntentResponse})")]
		[DynamicDependencyAttribute ("HandleRestaurantGuest(Intents.INGetRestaurantGuestIntent,System.Action{Intents.INGetRestaurantGuestIntentResponse})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INGetRestaurantGuestIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINGetRestaurantGuestIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINGetRestaurantGuestIntentHandling" /> interface to support all the methods from the INGetRestaurantGuestIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINGetRestaurantGuestIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INGetRestaurantGuestIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INGetRestaurantGuestIntentHandling_Extensions {
		/// <param name="guestIntent">To be added.</param><param name="completion">To be added.</param><summary>Developers may override this method to customize the confirmation of a guest for a restaurant reservation.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Confirm (this IINGetRestaurantGuestIntentHandling This, INGetRestaurantGuestIntent guestIntent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V127))]global::System.Action<INGetRestaurantGuestIntentResponse> completion)
		{
			var guestIntent__handle__ = guestIntent!.GetNonNullHandle (nameof (guestIntent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V127.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmGetRestaurantGuest:completion:"), guestIntent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (guestIntent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INGetRestaurantGuestIntentHandlingWrapper : BaseWrapper, IINGetRestaurantGuestIntentHandling {
		public INGetRestaurantGuestIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INGetRestaurantGuestIntentHandlingWrapper))]
		static INGetRestaurantGuestIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INGetRestaurantGuestIntentResponse" /> appropriate to the <see cref="T:Intents.INGetRestaurantGuestIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleGetRestaurantGuest:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleRestaurantGuest (INGetRestaurantGuestIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V127))]global::System.Action<INGetRestaurantGuestIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V127.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleGetRestaurantGuest:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
