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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace GameplayKit {
	#pragma warning disable CS1573
	/// <summary>A valid game move. The minimal data necessary to transition a valid <see cref="T:GameplayKit.IGKGameModel" /> into a valid subsequent state.</summary><remarks><para>Developers should strive to make their implementations of this interface efficient. A large number of <see cref="T:GameplayKit.IGKGameModelUpdate" /> objects are likely to be produced by <see cref="GameplayKit.IGKGameModel.GetGameModelUpdates(GameplayKit.IGKGameModelPlayer)" /> which, in return, is likely to be called many times by <see cref="M:GameplayKit.GKMinMaxStrategist.GetBestMove(GameplayKit.IGKGameModelPlayer)" />.</para></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "GKGameModelUpdate", WrapperType = typeof (GKGameModelUpdateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Value", Selector = "value", PropertyType = typeof (IntPtr), GetterSelector = "value", SetterSelector = "setValue:", ArgumentSemantic = ArgumentSemantic.Assign)]
	public partial interface IGKGameModelUpdate : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("Value")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKGameModelUpdateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGKGameModelUpdate ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Equivalent to the value produced by <see cref="GameplayKit.GKGameModel_Extensions.GetScore(GameplayKit.IGKGameModel,GameplayKit.IGKGameModelPlayer)" />.</summary><value>To be added.</value><remarks><para>
		/// This property is determined by the <see cref="GameplayKit.GKGameModel_Extensions.GetScore(GameplayKit.IGKGameModel,GameplayKit.IGKGameModelPlayer)" /> when <c>this</c><see cref="T:GameplayKit.IGKGameModelUpdate" /> is applied to the game state of the <see cref="T:GameplayKit.IGKGameModel" />.
		/// Ultimately, the <see cref="M:GameplayKit.GKMinMaxStrategist.GetBestMove(GameplayKit.IGKGameModelPlayer)" /> method returns the <see cref="T:GameplayKit.IGKGameModelUpdate" /> with the highest <see cref="GameplayKit.IGKGameModelUpdate.Value" />.
		/// If multiple <see cref="T:GameplayKit.IGKGameModelUpdate" /> have the same <see cref="GameplayKit.IGKGameModelUpdate.Value" /> and <see cref="GameplayKit.GKMinMaxStrategist.RandomSource" /> is not <see langword="null" />,
		/// the returned <see cref="T:GameplayKit.IGKGameModelUpdate" /> is chosen randomly among those with the highest <see cref="GameplayKit.IGKGameModelUpdate.Value" />.
		/// </para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nint Value {
			[Export ("value", ArgumentSemantic.Assign)]
			get {
				return _GetValue (this);
			}
			[Export ("setValue:", ArgumentSemantic.Assign)]
			set {
				_SetValue (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetValue (IGKGameModelUpdate This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("value"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetValue (IGKGameModelUpdate This, nint value)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setValue:"), value);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GKGameModelUpdateWrapper : BaseWrapper, IGKGameModelUpdate {
		public GKGameModelUpdateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKGameModelUpdateWrapper))]
		static GKGameModelUpdateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Equivalent to the value produced by <see cref="GameplayKit.GKGameModel_Extensions.GetScore(GameplayKit.IGKGameModel,GameplayKit.IGKGameModelPlayer)" />.</summary><value>To be added.</value><remarks><para>
		/// This property is determined by the <see cref="GameplayKit.GKGameModel_Extensions.GetScore(GameplayKit.IGKGameModel,GameplayKit.IGKGameModelPlayer)" /> when <c>this</c><see cref="T:GameplayKit.IGKGameModelUpdate" /> is applied to the game state of the <see cref="T:GameplayKit.IGKGameModel" />.
		/// Ultimately, the <see cref="M:GameplayKit.GKMinMaxStrategist.GetBestMove(GameplayKit.IGKGameModelPlayer)" /> method returns the <see cref="T:GameplayKit.IGKGameModelUpdate" /> with the highest <see cref="GameplayKit.IGKGameModelUpdate.Value" />.
		/// If multiple <see cref="T:GameplayKit.IGKGameModelUpdate" /> have the same <see cref="GameplayKit.IGKGameModelUpdate.Value" /> and <see cref="GameplayKit.GKMinMaxStrategist.RandomSource" /> is not <see langword="null" />,
		/// the returned <see cref="T:GameplayKit.IGKGameModelUpdate" /> is chosen randomly among those with the highest <see cref="GameplayKit.IGKGameModelUpdate.Value" />.
		/// </para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint Value {
			[Export ("value", ArgumentSemantic.Assign)]
			get {
				nint ret;
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("value"));
				return ret;
			}
			[Export ("setValue:", ArgumentSemantic.Assign)]
			set {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setValue:"), value);
			}
		}
	}
}
