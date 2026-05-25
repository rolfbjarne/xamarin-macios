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
namespace Vision {
	#pragma warning disable CS1573
	/// <summary>Interface for <see cref="T:Vision.VNImageBasedRequest" /> objects that may detect faces (e.g., <see cref="T:Vision.VNDetectFaceLandmarksRequest" />).</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "VNFaceObservationAccepting", WrapperType = typeof (VNFaceObservationAcceptingWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputFaceObservations", Selector = "inputFaceObservations", PropertyType = typeof (Vision.VNFaceObservation[]), GetterSelector = "inputFaceObservations", SetterSelector = "setInputFaceObservations:", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface IVNFaceObservationAccepting : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("InputFaceObservations")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (VNFaceObservationAcceptingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IVNFaceObservationAccepting ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets or sets the <see cref="T:Vision.VNFaceObservation" /> objects in the request.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual VNFaceObservation[]? InputFaceObservations {
			[Export ("inputFaceObservations", ArgumentSemantic.Copy)]
			get {
				return _GetInputFaceObservations (this);
			}
			[Export ("setInputFaceObservations:", ArgumentSemantic.Copy)]
			set {
				_SetInputFaceObservations (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static VNFaceObservation[] _GetInputFaceObservations (IVNFaceObservationAccepting This)
		{
			VNFaceObservation[] ret;
			ret = CFArray.ArrayFromHandle<VNFaceObservation>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("inputFaceObservations")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetInputFaceObservations (IVNFaceObservationAccepting This, VNFaceObservation[]? value)
		{
			using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setInputFaceObservations:"), nsa_value.GetHandle ());
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class VNFaceObservationAcceptingWrapper : BaseWrapper, IVNFaceObservationAccepting {
		public VNFaceObservationAcceptingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (VNFaceObservationAcceptingWrapper))]
		static VNFaceObservationAcceptingWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets or sets the <see cref="T:Vision.VNFaceObservation" /> objects in the request.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public VNFaceObservation[]? InputFaceObservations {
			[Export ("inputFaceObservations", ArgumentSemantic.Copy)]
			get {
				VNFaceObservation[] ret;
				ret = CFArray.ArrayFromHandle<VNFaceObservation>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("inputFaceObservations")), false)!;
				return ret;
			}
			[Export ("setInputFaceObservations:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setInputFaceObservations:"), nsa_value.GetHandle ());
			}
		}
	}
}
