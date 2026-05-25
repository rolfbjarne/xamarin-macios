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
	/// <summary>This interface represents the Objective-C protocol <c>INAnswerCallIntentHandling</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos13.1")]
	[SupportedOSPlatform ("ios16.2")]
	[SupportedOSPlatform ("maccatalyst16.2")]
	[Protocol (Name = "INAnswerCallIntentHandling", WrapperType = typeof (INAnswerCallIntentHandlingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleAnswerCall", Selector = "handleAnswerCall:completion:", ParameterType = new Type [] { typeof (Intents.INAnswerCallIntent), typeof (global::System.Action<global::Intents.INAnswerCallIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V79) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConfirmAnswerCall", Selector = "confirmAnswerCall:completion:", ParameterType = new Type [] { typeof (Intents.INAnswerCallIntent), typeof (global::System.Action<global::Intents.INAnswerCallIntentResponse>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V79) })]
	public partial interface IINAnswerCallIntentHandling : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("handleAnswerCall:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void HandleAnswerCall (INAnswerCallIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V79))]global::System.Action<INAnswerCallIntentResponse> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _HandleAnswerCall (IINAnswerCallIntentHandling This, INAnswerCallIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V79))]global::System.Action<INAnswerCallIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V79.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("handleAnswerCall:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[global::Foundation.OptionalMember]
		[Export ("confirmAnswerCall:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ConfirmAnswerCall (INAnswerCallIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V79))]global::System.Action<INAnswerCallIntentResponse> completion)
		{
			_ConfirmAnswerCall (this, intent, completion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ConfirmAnswerCall (IINAnswerCallIntentHandling This, INAnswerCallIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V79))]global::System.Action<INAnswerCallIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V79.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmAnswerCall:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
		[DynamicDependencyAttribute ("ConfirmAnswerCall(Intents.INAnswerCallIntent,System.Action{Intents.INAnswerCallIntentResponse})")]
		[DynamicDependencyAttribute ("HandleAnswerCall(Intents.INAnswerCallIntent,System.Action{Intents.INAnswerCallIntentResponse})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INAnswerCallIntentHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINAnswerCallIntentHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IINAnswerCallIntentHandling" /> interface to support all the methods from the INAnswerCallIntentHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IINAnswerCallIntentHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original INAnswerCallIntentHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class INAnswerCallIntentHandling_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void ConfirmAnswerCall (this IINAnswerCallIntentHandling This, INAnswerCallIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V79))]global::System.Action<INAnswerCallIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V79.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("confirmAnswerCall:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INAnswerCallIntentHandlingWrapper : BaseWrapper, IINAnswerCallIntentHandling {
		public INAnswerCallIntentHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INAnswerCallIntentHandlingWrapper))]
		static INAnswerCallIntentHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("handleAnswerCall:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void HandleAnswerCall (INAnswerCallIntent intent, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V79))]global::System.Action<INAnswerCallIntentResponse> completion)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V79.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("handleAnswerCall:completion:"), intent__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (intent);
		}
	}
}
