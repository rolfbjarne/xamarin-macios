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
namespace AudioUnit {
	#pragma warning disable CS1573
	/// <summary>Interface that version 3 Audio Unit extensions must implement.</summary><remarks><para>Developers who want to create a version 3 Audio Unit extension must implement this interface on a class that inherits from <see cref="T:Foundation.NSObject" /> or <see cref="T:CoreAudioKit.AUViewController" />.</para></remarks>
	[Protocol (Name = "AUAudioUnitFactory", WrapperType = typeof (AUAudioUnitFactoryWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateAudioUnit", Selector = "createAudioUnitWithComponentDescription:error:", ReturnType = typeof (AUAudioUnit), ParameterType = new Type [] { typeof (AudioComponentDescription), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	public partial interface IAUAudioUnitFactory : INativeObject, IDisposable, 
		Foundation.INSExtensionRequestHandling
	{
		/// <param name="desc">A description for the audio unit.</param><param name="error">An <see langword="out" /> parameter into which any errors that are encountered are written.</param><summary>Creates and returns an audio unit.</summary><returns>An audio unit.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("createAudioUnitWithComponentDescription:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual AUAudioUnit? CreateAudioUnit (AudioComponentDescription desc, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="desc">A description for the audio unit.</param><param name="error">An <see langword="out" /> parameter into which any errors that are encountered are written.</param><summary>Creates and returns an audio unit.</summary><returns>An audio unit.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static AUAudioUnit? _CreateAudioUnit (IAUAudioUnitFactory This, AudioComponentDescription desc, out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			AUAudioUnit? ret;
			ret =  Runtime.GetNSObject<AUAudioUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_AudioComponentDescription_ref_NativeHandle (This.Handle, Selector.GetHandle ("createAudioUnitWithComponentDescription:error:"), desc, &errorValue), false)!;
			GC.KeepAlive (This);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[DynamicDependencyAttribute ("CreateAudioUnit(AudioUnit.AudioComponentDescription,Foundation.NSError@)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AUAudioUnitFactoryWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAUAudioUnitFactory ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AUAudioUnitFactoryWrapper : BaseWrapper, IAUAudioUnitFactory {
		public AUAudioUnitFactoryWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AUAudioUnitFactoryWrapper))]
		static AUAudioUnitFactoryWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="desc">A description for the audio unit.</param><param name="error">An <see langword="out" /> parameter into which any errors that are encountered are written.</param><summary>Creates and returns an audio unit.</summary><returns>An audio unit.</returns><remarks>To be added.</remarks>
		[Export ("createAudioUnitWithComponentDescription:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe AUAudioUnit? CreateAudioUnit (AudioComponentDescription desc, out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			AUAudioUnit? ret;
			ret =  Runtime.GetNSObject<AUAudioUnit> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_AudioComponentDescription_ref_NativeHandle (this.Handle, Selector.GetHandle ("createAudioUnitWithComponentDescription:error:"), desc, &errorValue), false)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		/// <param name="context">The <see cref="T:Foundation.NSExtensionContext" /> containing extension-relevant data.</param><summary>Developers can implement this method to prepare their extension for the host application request.</summary><remarks><para>Developers who implement this method must call <c>base.BeginRequestWithExtensionContext(context)</c> within their implementation.</para></remarks>
		[Export ("beginRequestWithExtensionContext:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BeginRequestWithExtensionContext (NSExtensionContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("beginRequestWithExtensionContext:"), context__handle__);
			GC.KeepAlive (context);
		}
	}
}
