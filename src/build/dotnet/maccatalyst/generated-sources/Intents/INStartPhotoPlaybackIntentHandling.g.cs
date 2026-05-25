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
	[ObsoletedOSPlatform ("ios15.0")]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst15.0")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "INStartPhotoPlaybackIntentHandling", WrapperType = typeof (INStartPhotoPlaybackIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleStartPhotoPlayback", Selector = "handleStartPhotoPlayback:completion:", ParameterType = new Type [] { typeof (Intents.INStartPhotoPlaybackIntent), typeof (global::System.Action<global::Intents.INStartPhotoPlaybackIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V140) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Confirm", Selector = "confirmStartPhotoPlayback:completion:", ParameterType = new Type [] { typeof (Intents.INStartPhotoPlaybackIntent), typeof (global::System.Action<global::Intents.INStartPhotoPlaybackIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V140) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveDateCreated", Selector = "resolveDateCreatedForStartPhotoPlayback:withCompletion:", ParameterType = new Type [] { typeof (Intents.INStartPhotoPlaybackIntent), typeof (global::System.Action<global::Intents.INDateComponentsRangeResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V132) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveLocationCreated", Selector = "resolveLocationCreatedForStartPhotoPlayback:withCompletion:", ParameterType = new Type [] { typeof (Intents.INStartPhotoPlaybackIntent), typeof (global::System.Action<global::Intents.INPlacemarkResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V121) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveAlbumName", Selector = "resolveAlbumNameForStartPhotoPlayback:withCompletion:", ParameterType = new Type [] { typeof (Intents.INStartPhotoPlaybackIntent), typeof (global::System.Action<global::Intents.INStringResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V88) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolvePeopleInPhoto", Selector = "resolvePeopleInPhotoForStartPhotoPlayback:withCompletion:", ParameterType = new Type [] { typeof (Intents.INStartPhotoPlaybackIntent), typeof (global::System.Action<global::Intents.INPersonResolutionResult[]>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V163) })]
	public partial interface IINStartPhotoPlaybackIntentHandling : INativeObject, IDisposable
	{
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INStartPhotoPlaybackIntentResponse" /> appropriate to the <see cref="T:Intents.INStartPhotoPlaybackIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("handleStartPhotoPlayback:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleStartPhotoPlayback (INStartPhotoPlaybackIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V140))]global::System.Action<INStartPhotoPlaybackIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INStartPhotoPlaybackIntentResponse" /> appropriate to the <see cref="T:Intents.INStartPhotoPlaybackIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleStartPhotoPlayback (IINStartPhotoPlaybackIntentHandling This, INStartPhotoPlaybackIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V140))]global::System.Action<INStartPhotoPlaybackIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V140.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleStartPhotoPlayback:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the behavior of confirming that a photo playback session may start.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("confirmStartPhotoPlayback:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Confirm (INStartPhotoPlaybackIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V140))]global::System.Action<INStartPhotoPlaybackIntentResponse> completion)
		{
			_Confirm (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the behavior of confirming that a photo playback session may start.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Confirm (IINStartPhotoPlaybackIntentHandling This, INStartPhotoPlaybackIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V140))]global::System.Action<INStartPhotoPlaybackIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V140.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmStartPhotoPlayback:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this in order to customize the behavior of resolving the dates when the photos were taken.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveDateCreatedForStartPhotoPlayback:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveDateCreated (INStartPhotoPlaybackIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V132))]global::System.Action<INDateComponentsRangeResolutionResult> completion)
		{
			_ResolveDateCreated (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this in order to customize the behavior of resolving the dates when the photos were taken.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveDateCreated (IINStartPhotoPlaybackIntentHandling This, INStartPhotoPlaybackIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V132))]global::System.Action<INDateComponentsRangeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V132.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveDateCreatedForStartPhotoPlayback:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this in order to customize the behavior of resolving the location where the photos were taken.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveLocationCreatedForStartPhotoPlayback:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveLocationCreated (INStartPhotoPlaybackIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V121))]global::System.Action<INPlacemarkResolutionResult> completion)
		{
			_ResolveLocationCreated (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this in order to customize the behavior of resolving the location where the photos were taken.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveLocationCreated (IINStartPhotoPlaybackIntentHandling This, INStartPhotoPlaybackIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V121))]global::System.Action<INPlacemarkResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V121.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveLocationCreatedForStartPhotoPlayback:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to confirm that they can resolve the photo album name.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolveAlbumNameForStartPhotoPlayback:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveAlbumName (INStartPhotoPlaybackIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V88))]global::System.Action<INStringResolutionResult> completion)
		{
			_ResolveAlbumName (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to confirm that they can resolve the photo album name.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveAlbumName (IINStartPhotoPlaybackIntentHandling This, INStartPhotoPlaybackIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V88))]global::System.Action<INStringResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V88.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveAlbumNameForStartPhotoPlayback:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this in order to customize the behavior of resolving the people in the photo.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("resolvePeopleInPhotoForStartPhotoPlayback:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolvePeopleInPhoto (INStartPhotoPlaybackIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V163))]global::System.Action<INPersonResolutionResult[]> completion)
		{
			_ResolvePeopleInPhoto (this, intent, completion);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this in order to customize the behavior of resolving the people in the photo.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolvePeopleInPhoto (IINStartPhotoPlaybackIntentHandling This, INStartPhotoPlaybackIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V163))]global::System.Action<INPersonResolutionResult[]> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V163.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolvePeopleInPhotoForStartPhotoPlayback:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[DynamicDependencyAttribute ("Confirm(Intents.INStartPhotoPlaybackIntent,System.Action{Intents.INStartPhotoPlaybackIntentResponse})")]
		[DynamicDependencyAttribute ("HandleStartPhotoPlayback(Intents.INStartPhotoPlaybackIntent,System.Action{Intents.INStartPhotoPlaybackIntentResponse})")]
		[DynamicDependencyAttribute ("ResolveAlbumName(Intents.INStartPhotoPlaybackIntent,System.Action{Intents.INStringResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveDateCreated(Intents.INStartPhotoPlaybackIntent,System.Action{Intents.INDateComponentsRangeResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveLocationCreated(Intents.INStartPhotoPlaybackIntent,System.Action{Intents.INPlacemarkResolutionResult})")]
		[DynamicDependencyAttribute ("ResolvePeopleInPhoto(Intents.INStartPhotoPlaybackIntent,System.Action{Intents.INPersonResolutionResult[]})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INStartPhotoPlaybackIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINStartPhotoPlaybackIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINStartPhotoPlaybackIntentHandling" /> interface to support all the methods from the INStartPhotoPlaybackIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINStartPhotoPlaybackIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INStartPhotoPlaybackIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INStartPhotoPlaybackIntentHandling_Extensions {
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to customize the behavior of confirming that a photo playback session may start.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Confirm (this IINStartPhotoPlaybackIntentHandling This, INStartPhotoPlaybackIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V140))]global::System.Action<INStartPhotoPlaybackIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V140.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmStartPhotoPlayback:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this in order to customize the behavior of resolving the dates when the photos were taken.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveDateCreated (this IINStartPhotoPlaybackIntentHandling This, INStartPhotoPlaybackIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V132))]global::System.Action<INDateComponentsRangeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V132.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveDateCreatedForStartPhotoPlayback:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this in order to customize the behavior of resolving the location where the photos were taken.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveLocationCreated (this IINStartPhotoPlaybackIntentHandling This, INStartPhotoPlaybackIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V121))]global::System.Action<INPlacemarkResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V121.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveLocationCreatedForStartPhotoPlayback:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this method to confirm that they can resolve the photo album name.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveAlbumName (this IINStartPhotoPlaybackIntentHandling This, INStartPhotoPlaybackIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V88))]global::System.Action<INStringResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V88.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveAlbumNameForStartPhotoPlayback:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers may implement this in order to customize the behavior of resolving the people in the photo.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolvePeopleInPhoto (this IINStartPhotoPlaybackIntentHandling This, INStartPhotoPlaybackIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V163))]global::System.Action<INPersonResolutionResult[]> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V163.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolvePeopleInPhotoForStartPhotoPlayback:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INStartPhotoPlaybackIntentHandlingWrapper : BaseWrapper, IINStartPhotoPlaybackIntentHandling {
		public INStartPhotoPlaybackIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INStartPhotoPlaybackIntentHandlingWrapper))]
		static INStartPhotoPlaybackIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="intent">Specifies the user's intention.</param><param name="completion">Completion method that must be called by the override.</param><summary>Developers must override this method and invoke the <see cref="T:System.Action`1" /> with an <see cref="T:Intents.INStartPhotoPlaybackIntentResponse" /> appropriate to the <see cref="T:Intents.INStartPhotoPlaybackIntent" /> <paramref name="intent" />.</summary><remarks>To be added.</remarks>
		[Export ("handleStartPhotoPlayback:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleStartPhotoPlayback (INStartPhotoPlaybackIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V140))]global::System.Action<INStartPhotoPlaybackIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V140.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleStartPhotoPlayback:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
