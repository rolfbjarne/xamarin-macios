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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
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
	/// <summary>This interface represents the Objective-C protocol <c>INIntentHandlerProviding</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "INIntentHandlerProviding", WrapperType = typeof (INIntentHandlerProvidingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetHandler", Selector = "handlerForIntent:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (Intents.INIntent) }, ParameterByRef = new bool [] { false })]
	public partial interface IINIntentHandlerProviding : INativeObject, IDisposable
	{
		/// <param name="intent">The <see cref="T:Intents.INIntent" /> received by the system.</param><summary>Developers override this method to return the handler object if <paramref name="intent" /> is one their extension can respond to.</summary><returns>The developer's handler object or <see langword="null" /> if <paramref name="intent" /> is not handled by the extension.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("handlerForIntent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetHandler (INIntent intent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="intent">The <see cref="T:Intents.INIntent" /> received by the system.</param><summary>Developers override this method to return the handler object if <paramref name="intent" /> is one their extension can respond to.</summary><returns>The developer's handler object or <see langword="null" /> if <paramref name="intent" /> is not handled by the extension.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject? _GetHandler (IINIntentHandlerProviding This, INIntent intent)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("handlerForIntent:"), intent__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (intent);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetHandler(Intents.INIntent)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INIntentHandlerProvidingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IINIntentHandlerProviding ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class INIntentHandlerProvidingWrapper : BaseWrapper, IINIntentHandlerProviding {
		public INIntentHandlerProvidingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (INIntentHandlerProvidingWrapper))]
		static INIntentHandlerProvidingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="intent">The <see cref="T:Intents.INIntent" /> received by the system.</param><summary>Developers override this method to return the handler object if <paramref name="intent" /> is one their extension can respond to.</summary><returns>The developer's handler object or <see langword="null" /> if <paramref name="intent" /> is not handled by the extension.</returns><remarks>To be added.</remarks>
		[Export ("handlerForIntent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? GetHandler (INIntent intent)
		{
			var intent__handle__ = intent!.GetNonNullHandle (nameof (intent));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("handlerForIntent:"), intent__handle__), false)!;
			GC.KeepAlive (intent);
			return ret!;
		}
	}
}
