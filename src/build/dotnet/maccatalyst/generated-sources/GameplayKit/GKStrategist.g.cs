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
namespace GameplayKit {
	#pragma warning disable CS1573
	/// <summary>Interface for a game strategist (AI).</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "GKStrategist", WrapperType = typeof (GKStrategistWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetBestMoveForActivePlayer", Selector = "bestMoveForActivePlayer", ReturnType = typeof (IGKGameModelUpdate))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "GameModel", Selector = "gameModel", PropertyType = typeof (IGKGameModel), GetterSelector = "gameModel", SetterSelector = "setGameModel:", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RandomSource", Selector = "randomSource", PropertyType = typeof (IGKRandom), GetterSelector = "randomSource", SetterSelector = "setRandomSource:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface IGKStrategist : INativeObject, IDisposable
	{
		/// <summary>Returns what the strategist indicates is the best move for the active player.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("bestMoveForActivePlayer")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IGKGameModelUpdate GetBestMoveForActivePlayer ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Returns what the strategist indicates is the best move for the active player.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IGKGameModelUpdate _GetBestMoveForActivePlayer (IGKStrategist This)
		{
			IGKGameModelUpdate ret;
			ret =  Runtime.GetINativeObject<IGKGameModelUpdate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("bestMoveForActivePlayer")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[DynamicDependencyAttribute ("GameModel")]
		[DynamicDependencyAttribute ("GetBestMoveForActivePlayer()")]
		[DynamicDependencyAttribute ("RandomSource")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKStrategistWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGKStrategist ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets or sets the current game state.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IGKGameModel? GameModel {
			[Export ("gameModel", ArgumentSemantic.Retain)]
			get {
				return _GetGameModel (this);
			}
			[Export ("setGameModel:", ArgumentSemantic.Retain)]
			set {
				_SetGameModel (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IGKGameModel _GetGameModel (IGKStrategist This)
		{
			IGKGameModel ret;
			ret =  Runtime.GetINativeObject<IGKGameModel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("gameModel")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetGameModel (IGKStrategist This, IGKGameModel? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setGameModel:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
		/// <summary>Gets or sets the source of randomness for the strategist.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IGKRandom? RandomSource {
			[Export ("randomSource", ArgumentSemantic.Retain)]
			get {
				return _GetRandomSource (this);
			}
			[Export ("setRandomSource:", ArgumentSemantic.Retain)]
			set {
				_SetRandomSource (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IGKRandom _GetRandomSource (IGKStrategist This)
		{
			IGKRandom ret;
			ret =  Runtime.GetINativeObject<IGKRandom> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("randomSource")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetRandomSource (IGKStrategist This, IGKRandom? value)
		{
			var value__handle__ = value.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setRandomSource:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GKStrategistWrapper : BaseWrapper, IGKStrategist {
		public GKStrategistWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKStrategistWrapper))]
		static GKStrategistWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Returns what the strategist indicates is the best move for the active player.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("bestMoveForActivePlayer")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IGKGameModelUpdate GetBestMoveForActivePlayer ()
		{
			IGKGameModelUpdate ret;
			ret =  Runtime.GetINativeObject<IGKGameModelUpdate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("bestMoveForActivePlayer")), false)!;
			return ret;
		}
		/// <summary>Gets or sets the current game state.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IGKGameModel? GameModel {
			[Export ("gameModel", ArgumentSemantic.Retain)]
			get {
				IGKGameModel ret;
				ret =  Runtime.GetINativeObject<IGKGameModel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("gameModel")), false)!;
				return ret;
			}
			[Export ("setGameModel:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setGameModel:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets the source of randomness for the strategist.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IGKRandom? RandomSource {
			[Export ("randomSource", ArgumentSemantic.Retain)]
			get {
				IGKRandom ret;
				ret =  Runtime.GetINativeObject<IGKRandom> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("randomSource")), false)!;
				return ret;
			}
			[Export ("setRandomSource:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setRandomSource:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
	}
}
