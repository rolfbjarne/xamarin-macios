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
	/// <summary>This interface represents the Objective-C protocol <c>INUpdateMediaAffinityIntentHandling</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos14.0")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "INUpdateMediaAffinityIntentHandling", WrapperType = typeof (INUpdateMediaAffinityIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleUpdateMediaAffinity", Selector = "handleUpdateMediaAffinity:completion:", ParameterType = new Type [] { typeof (Intents.INUpdateMediaAffinityIntent), typeof (global::System.Action<global::Intents.INUpdateMediaAffinityIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V214) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Confirm", Selector = "confirmUpdateMediaAffinity:completion:", ParameterType = new Type [] { typeof (Intents.INUpdateMediaAffinityIntent), typeof (global::System.Action<global::Intents.INUpdateMediaAffinityIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V214) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveMediaItems", Selector = "resolveMediaItemsForUpdateMediaAffinity:withCompletion:", ParameterType = new Type [] { typeof (Intents.INUpdateMediaAffinityIntent), typeof (global::System.Action<NSArray<global::Intents.INUpdateMediaAffinityMediaItemResolutionResult>>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V215) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveAffinityType", Selector = "resolveAffinityTypeForUpdateMediaAffinity:withCompletion:", ParameterType = new Type [] { typeof (Intents.INUpdateMediaAffinityIntent), typeof (global::System.Action<global::Intents.INMediaAffinityTypeResolutionResult>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V216) })]
	public partial interface IINUpdateMediaAffinityIntentHandling : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("handleUpdateMediaAffinity:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleUpdateMediaAffinity (INUpdateMediaAffinityIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V214))]global::System.Action<INUpdateMediaAffinityIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleUpdateMediaAffinity (IINUpdateMediaAffinityIntentHandling This, INUpdateMediaAffinityIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V214))]global::System.Action<INUpdateMediaAffinityIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V214.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleUpdateMediaAffinity:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[global::Foundation.OptionalMember]
		[Export ("confirmUpdateMediaAffinity:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Confirm (INUpdateMediaAffinityIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V214))]global::System.Action<INUpdateMediaAffinityIntentResponse> completion)
		{
			_Confirm (this, intent, completion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Confirm (IINUpdateMediaAffinityIntentHandling This, INUpdateMediaAffinityIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V214))]global::System.Action<INUpdateMediaAffinityIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V214.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmUpdateMediaAffinity:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[global::Foundation.OptionalMember]
		[Export ("resolveMediaItemsForUpdateMediaAffinity:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveMediaItems (INUpdateMediaAffinityIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V215))]global::System.Action<NSArray<INUpdateMediaAffinityMediaItemResolutionResult>> completion)
		{
			_ResolveMediaItems (this, intent, completion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveMediaItems (IINUpdateMediaAffinityIntentHandling This, INUpdateMediaAffinityIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V215))]global::System.Action<NSArray<INUpdateMediaAffinityMediaItemResolutionResult>> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V215.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveMediaItemsForUpdateMediaAffinity:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[global::Foundation.OptionalMember]
		[Export ("resolveAffinityTypeForUpdateMediaAffinity:withCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResolveAffinityType (INUpdateMediaAffinityIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V216))]global::System.Action<INMediaAffinityTypeResolutionResult> completion)
		{
			_ResolveAffinityType (this, intent, completion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResolveAffinityType (IINUpdateMediaAffinityIntentHandling This, INUpdateMediaAffinityIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V216))]global::System.Action<INMediaAffinityTypeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V216.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveAffinityTypeForUpdateMediaAffinity:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[DynamicDependencyAttribute ("Confirm(Intents.INUpdateMediaAffinityIntent,System.Action{Intents.INUpdateMediaAffinityIntentResponse})")]
		[DynamicDependencyAttribute ("HandleUpdateMediaAffinity(Intents.INUpdateMediaAffinityIntent,System.Action{Intents.INUpdateMediaAffinityIntentResponse})")]
		[DynamicDependencyAttribute ("ResolveAffinityType(Intents.INUpdateMediaAffinityIntent,System.Action{Intents.INMediaAffinityTypeResolutionResult})")]
		[DynamicDependencyAttribute ("ResolveMediaItems(Intents.INUpdateMediaAffinityIntent,System.Action{Foundation.NSArray{Intents.INUpdateMediaAffinityMediaItemResolutionResult}})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INUpdateMediaAffinityIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINUpdateMediaAffinityIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINUpdateMediaAffinityIntentHandling" /> interface to support all the methods from the INUpdateMediaAffinityIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINUpdateMediaAffinityIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INUpdateMediaAffinityIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INUpdateMediaAffinityIntentHandling_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void Confirm (this IINUpdateMediaAffinityIntentHandling This, INUpdateMediaAffinityIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V214))]global::System.Action<INUpdateMediaAffinityIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V214.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmUpdateMediaAffinity:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveMediaItems (this IINUpdateMediaAffinityIntentHandling This, INUpdateMediaAffinityIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V215))]global::System.Action<NSArray<INUpdateMediaAffinityMediaItemResolutionResult>> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V215.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveMediaItemsForUpdateMediaAffinity:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ResolveAffinityType (this IINUpdateMediaAffinityIntentHandling This, INUpdateMediaAffinityIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V216))]global::System.Action<INMediaAffinityTypeResolutionResult> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V216.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resolveAffinityTypeForUpdateMediaAffinity:withCompletion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INUpdateMediaAffinityIntentHandlingWrapper : BaseWrapper, IINUpdateMediaAffinityIntentHandling {
		public INUpdateMediaAffinityIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INUpdateMediaAffinityIntentHandlingWrapper))]
		static INUpdateMediaAffinityIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("handleUpdateMediaAffinity:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleUpdateMediaAffinity (INUpdateMediaAffinityIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V214))]global::System.Action<INUpdateMediaAffinityIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V214.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleUpdateMediaAffinity:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
