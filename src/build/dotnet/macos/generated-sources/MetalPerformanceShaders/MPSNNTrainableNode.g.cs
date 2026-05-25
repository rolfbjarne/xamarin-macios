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
namespace MetalPerformanceShaders {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MPSNNTrainableNode</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MPSNNTrainableNode", WrapperType = typeof (MPSNNTrainableNodeWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TrainingStyle", Selector = "trainingStyle", PropertyType = typeof (MetalPerformanceShaders.MPSNNTrainingStyle), GetterSelector = "trainingStyle", SetterSelector = "setTrainingStyle:", ArgumentSemantic = ArgumentSemantic.Assign)]
	public partial interface IMPSNNTrainableNode : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("TrainingStyle")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSNNTrainableNodeWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMPSNNTrainableNode ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MPSNNTrainingStyle TrainingStyle {
			[Export ("trainingStyle", ArgumentSemantic.Assign)]
			get {
				return _GetTrainingStyle (this);
			}
			[Export ("setTrainingStyle:", ArgumentSemantic.Assign)]
			set {
				_SetTrainingStyle (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MPSNNTrainingStyle _GetTrainingStyle (IMPSNNTrainableNode This)
		{
			MPSNNTrainingStyle ret;
			ret = (MetalPerformanceShaders.MPSNNTrainingStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("trainingStyle"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTrainingStyle (IMPSNNTrainableNode This, MPSNNTrainingStyle value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("setTrainingStyle:"), (UIntPtr) (ulong) value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MPSNNTrainableNodeWrapper : BaseWrapper, IMPSNNTrainableNode {
		public MPSNNTrainableNodeWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSNNTrainableNodeWrapper))]
		static MPSNNTrainableNodeWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSNNTrainingStyle TrainingStyle {
			[Export ("trainingStyle", ArgumentSemantic.Assign)]
			get {
				MPSNNTrainingStyle ret;
				ret = (MetalPerformanceShaders.MPSNNTrainingStyle) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("trainingStyle"));
				return ret!;
			}
			[Export ("setTrainingStyle:", ArgumentSemantic.Assign)]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setTrainingStyle:"), (UIntPtr) (ulong) value);
			}
		}
	}
}
