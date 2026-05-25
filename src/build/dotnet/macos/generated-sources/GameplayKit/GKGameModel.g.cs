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
namespace GameplayKit {
	#pragma warning disable CS1573
	/// <summary>The current game state. Particularly useful in conjunction with <see cref="T:GameplayKit.GKMinMaxStrategist" />.</summary><remarks><para>
	/// When <see cref="T:GameplayKit.GKMinMaxStrategist" /> is used as an AI opponent, it uses <see cref="T:GameplayKit.IGKGameModel" /> objects to describe the
	/// game's state and <see cref="T:GameplayKit.IGKGameModelUpdate" /> objects to describe potential moves.
	/// (See the "AI Opponent" section in the remarks at <see cref="N:GameplayKit" />)
	/// </para></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "GKGameModel", WrapperType = typeof (GKGameModelWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPlayers", Selector = "players", ReturnType = typeof (IGKGameModelPlayer[]))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetActivePlayer", Selector = "activePlayer", ReturnType = typeof (IGKGameModelPlayer))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetGameModel", Selector = "setGameModel:", ParameterType = new Type [] { typeof (IGKGameModel) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetGameModelUpdates", Selector = "gameModelUpdatesForPlayer:", ReturnType = typeof (IGKGameModelUpdate[]), ParameterType = new Type [] { typeof (IGKGameModelPlayer) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ApplyGameModelUpdate", Selector = "applyGameModelUpdate:", ParameterType = new Type [] { typeof (IGKGameModelUpdate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetScore", Selector = "scoreForPlayer:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (IGKGameModelPlayer) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsWin", Selector = "isWinForPlayer:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (IGKGameModelPlayer) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsLoss", Selector = "isLossForPlayer:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (IGKGameModelPlayer) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UnapplyGameModelUpdate", Selector = "unapplyGameModelUpdate:", ParameterType = new Type [] { typeof (IGKGameModelUpdate) }, ParameterByRef = new bool [] { false })]
	public partial interface IGKGameModel : INativeObject, IDisposable, 
		Foundation.INSCopying
	{
		/// <summary>The <see cref="T:GameplayKit.IGKGameModelPlayer" /> objects involved in the game.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("players")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IGKGameModelPlayer[]? GetPlayers ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>The <see cref="T:GameplayKit.IGKGameModelPlayer" /> objects involved in the game.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IGKGameModelPlayer[]? _GetPlayers (IGKGameModel This)
		{
			IGKGameModelPlayer[] ret;
			ret = CFArray.ArrayFromHandle<IGKGameModelPlayer>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("players")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>The current <see cref="T:GameplayKit.IGKGameModelPlayer" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("activePlayer")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IGKGameModelPlayer? GetActivePlayer ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>The current <see cref="T:GameplayKit.IGKGameModelPlayer" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IGKGameModelPlayer? _GetActivePlayer (IGKGameModel This)
		{
			IGKGameModelPlayer ret;
			ret =  Runtime.GetINativeObject<IGKGameModelPlayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("activePlayer")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="gameModel">To be added.</param><summary>Sets the internal state of the game to <paramref name="gameModel" />.</summary><remarks><para>This method is called many times during the evaluation of <see cref="M:GameplayKit.GKMinMaxStrategist.GetBestMove(GameplayKit.IGKGameModelPlayer)" />, as that method attempts to minimize the number of <see cref="T:GameplayKit.IGKGameModel" /> objects allocated and instead uses this method to "reuse" previously-allocated memory.</para></remarks>
		[global::Foundation.RequiredMember]
		[Export ("setGameModel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetGameModel (IGKGameModel gameModel)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="gameModel">To be added.</param><summary>Sets the internal state of the game to <paramref name="gameModel" />.</summary><remarks><para>This method is called many times during the evaluation of <see cref="M:GameplayKit.GKMinMaxStrategist.GetBestMove(GameplayKit.IGKGameModelPlayer)" />, as that method attempts to minimize the number of <see cref="T:GameplayKit.IGKGameModel" /> objects allocated and instead uses this method to "reuse" previously-allocated memory.</para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetGameModel (IGKGameModel This, IGKGameModel gameModel)
		{
			var gameModel__handle__ = gameModel!.GetNonNullHandle (nameof (gameModel));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setGameModel:"), gameModel__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gameModel);
		}
		/// <param name="player">To be added.</param><summary>The set of legal moves available to the player whose <see cref="IGKGameModelPlayer.PlayerId" /> value is the same as that of <paramref name="player" />.</summary><returns>To be added.</returns><remarks><para>
		/// The <see cref="T:GameplayKit.GKMinMaxStrategist" /> may allocate many <see cref="T:GameplayKit.IGKGameModelPlayer" /> objects with identical <see cref="IGKGameModelPlayer.PlayerId" /> values.
		/// When comparing <see cref="T:GameplayKit.IGKGameModelPlayer" /> instances, developers should rely on <see cref="IGKGameModelPlayer.PlayerId" /> values, not reference equality.
		/// </para></remarks>
		[global::Foundation.RequiredMember]
		[Export ("gameModelUpdatesForPlayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IGKGameModelUpdate[]? GetGameModelUpdates (IGKGameModelPlayer player)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="player">To be added.</param><summary>The set of legal moves available to the player whose <see cref="IGKGameModelPlayer.PlayerId" /> value is the same as that of <paramref name="player" />.</summary><returns>To be added.</returns><remarks><para>
		/// The <see cref="T:GameplayKit.GKMinMaxStrategist" /> may allocate many <see cref="T:GameplayKit.IGKGameModelPlayer" /> objects with identical <see cref="IGKGameModelPlayer.PlayerId" /> values.
		/// When comparing <see cref="T:GameplayKit.IGKGameModelPlayer" /> instances, developers should rely on <see cref="IGKGameModelPlayer.PlayerId" /> values, not reference equality.
		/// </para></remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IGKGameModelUpdate[]? _GetGameModelUpdates (IGKGameModel This, IGKGameModelPlayer player)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			IGKGameModelUpdate[]? ret;
			ret = CFArray.ArrayFromHandle<IGKGameModelUpdate>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("gameModelUpdatesForPlayer:"), player__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (player);
			return ret!;
		}
		/// <param name="gameModelUpdate">An object that describes a valid move from the current state of <c>this</c>.</param><summary>Modifies the internal state of this <see cref="T:GameplayKit.IGKGameModel" /> according to the move described in <paramref name="gameModelUpdate" />.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("applyGameModelUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ApplyGameModelUpdate (IGKGameModelUpdate gameModelUpdate)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="gameModelUpdate">An object that describes a valid move from the current state of <c>this</c>.</param><summary>Modifies the internal state of this <see cref="T:GameplayKit.IGKGameModel" /> according to the move described in <paramref name="gameModelUpdate" />.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ApplyGameModelUpdate (IGKGameModel This, IGKGameModelUpdate gameModelUpdate)
		{
			var gameModelUpdate__handle__ = gameModelUpdate!.GetNonNullHandle (nameof (gameModelUpdate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("applyGameModelUpdate:"), gameModelUpdate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gameModelUpdate);
		}
		/// <param name="player">To be added.</param><summary>Gets the score for the specified <paramref name="player" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("scoreForPlayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetScore (IGKGameModelPlayer player)
		{
			return _GetScore (this, player);
		}
		/// <param name="player">To be added.</param><summary>Gets the score for the specified <paramref name="player" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetScore (IGKGameModel This, IGKGameModelPlayer player)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scoreForPlayer:"), player__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
			return ret!;
		}
		/// <param name="player">To be added.</param><summary>Returns a Boolean value that tells whether the <paramref name="player" /> won.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("isWinForPlayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsWin (IGKGameModelPlayer player)
		{
			return _IsWin (this, player);
		}
		/// <param name="player">To be added.</param><summary>Returns a Boolean value that tells whether the <paramref name="player" /> won.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsWin (IGKGameModel This, IGKGameModelPlayer player)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("isWinForPlayer:"), player__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
			return ret != 0;
		}
		/// <param name="player">To be added.</param><summary>Returns a Boolean value that tells whether the <paramref name="player" /> lost.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("isLossForPlayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsLoss (IGKGameModelPlayer player)
		{
			return _IsLoss (this, player);
		}
		/// <param name="player">To be added.</param><summary>Returns a Boolean value that tells whether the <paramref name="player" /> lost.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsLoss (IGKGameModel This, IGKGameModelPlayer player)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("isLossForPlayer:"), player__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
			return ret != 0;
		}
		/// <param name="gameModelUpdate">To be added.</param><summary>Removes the specified changes from the game's state.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("unapplyGameModelUpdate:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnapplyGameModelUpdate (IGKGameModelUpdate gameModelUpdate)
		{
			_UnapplyGameModelUpdate (this, gameModelUpdate);
		}
		/// <param name="gameModelUpdate">To be added.</param><summary>Removes the specified changes from the game's state.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UnapplyGameModelUpdate (IGKGameModel This, IGKGameModelUpdate gameModelUpdate)
		{
			var gameModelUpdate__handle__ = gameModelUpdate!.GetNonNullHandle (nameof (gameModelUpdate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("unapplyGameModelUpdate:"), gameModelUpdate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gameModelUpdate);
		}
		[DynamicDependencyAttribute ("ApplyGameModelUpdate(GameplayKit.IGKGameModelUpdate)")]
		[DynamicDependencyAttribute ("GetActivePlayer()")]
		[DynamicDependencyAttribute ("GetGameModelUpdates(GameplayKit.IGKGameModelPlayer)")]
		[DynamicDependencyAttribute ("GetPlayers()")]
		[DynamicDependencyAttribute ("GetScore(GameplayKit.IGKGameModelPlayer)")]
		[DynamicDependencyAttribute ("IsLoss(GameplayKit.IGKGameModelPlayer)")]
		[DynamicDependencyAttribute ("IsWin(GameplayKit.IGKGameModelPlayer)")]
		[DynamicDependencyAttribute ("SetGameModel(GameplayKit.IGKGameModel)")]
		[DynamicDependencyAttribute ("UnapplyGameModelUpdate(GameplayKit.IGKGameModelUpdate)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKGameModelWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGKGameModel ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IGKGameModel" /> interface to support all the methods from the GKGameModel protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IGKGameModel" /> interface allow developers to treat instances of the interface as having all the optional methods of the original GKGameModel protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class GKGameModel_Extensions {
		/// <param name="player">To be added.</param><summary>Gets the score for the specified <paramref name="player" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetScore (this IGKGameModel This, IGKGameModelPlayer player)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("scoreForPlayer:"), player__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
			return ret!;
		}
		/// <param name="player">To be added.</param><summary>Returns a Boolean value that tells whether the <paramref name="player" /> won.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsWin (this IGKGameModel This, IGKGameModelPlayer player)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("isWinForPlayer:"), player__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
			return ret != 0;
		}
		/// <param name="player">To be added.</param><summary>Returns a Boolean value that tells whether the <paramref name="player" /> lost.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsLoss (this IGKGameModel This, IGKGameModelPlayer player)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("isLossForPlayer:"), player__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (player);
			return ret != 0;
		}
		/// <param name="gameModelUpdate">To be added.</param><summary>Removes the specified changes from the game's state.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UnapplyGameModelUpdate (this IGKGameModel This, IGKGameModelUpdate gameModelUpdate)
		{
			var gameModelUpdate__handle__ = gameModelUpdate!.GetNonNullHandle (nameof (gameModelUpdate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("unapplyGameModelUpdate:"), gameModelUpdate__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (gameModelUpdate);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GKGameModelWrapper : BaseWrapper, IGKGameModel {
		public GKGameModelWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKGameModelWrapper))]
		static GKGameModelWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>The <see cref="T:GameplayKit.IGKGameModelPlayer" /> objects involved in the game.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("players")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IGKGameModelPlayer[]? GetPlayers ()
		{
			IGKGameModelPlayer[] ret;
			ret = CFArray.ArrayFromHandle<IGKGameModelPlayer>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("players")), false)!;
			return ret;
		}
		/// <summary>The current <see cref="T:GameplayKit.IGKGameModelPlayer" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("activePlayer")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IGKGameModelPlayer? GetActivePlayer ()
		{
			IGKGameModelPlayer ret;
			ret =  Runtime.GetINativeObject<IGKGameModelPlayer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("activePlayer")), false)!;
			return ret;
		}
		/// <param name="gameModel">To be added.</param><summary>Sets the internal state of the game to <paramref name="gameModel" />.</summary><remarks><para>This method is called many times during the evaluation of <see cref="M:GameplayKit.GKMinMaxStrategist.GetBestMove(GameplayKit.IGKGameModelPlayer)" />, as that method attempts to minimize the number of <see cref="T:GameplayKit.IGKGameModel" /> objects allocated and instead uses this method to "reuse" previously-allocated memory.</para></remarks>
		[Export ("setGameModel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetGameModel (IGKGameModel gameModel)
		{
			var gameModel__handle__ = gameModel!.GetNonNullHandle (nameof (gameModel));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setGameModel:"), gameModel__handle__);
			GC.KeepAlive (gameModel);
		}
		/// <param name="player">To be added.</param><summary>The set of legal moves available to the player whose <see cref="IGKGameModelPlayer.PlayerId" /> value is the same as that of <paramref name="player" />.</summary><returns>To be added.</returns><remarks><para>
		/// The <see cref="T:GameplayKit.GKMinMaxStrategist" /> may allocate many <see cref="T:GameplayKit.IGKGameModelPlayer" /> objects with identical <see cref="IGKGameModelPlayer.PlayerId" /> values.
		/// When comparing <see cref="T:GameplayKit.IGKGameModelPlayer" /> instances, developers should rely on <see cref="IGKGameModelPlayer.PlayerId" /> values, not reference equality.
		/// </para></remarks>
		[Export ("gameModelUpdatesForPlayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IGKGameModelUpdate[]? GetGameModelUpdates (IGKGameModelPlayer player)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			IGKGameModelUpdate[]? ret;
			ret = CFArray.ArrayFromHandle<IGKGameModelUpdate>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("gameModelUpdatesForPlayer:"), player__handle__), false)!;
			GC.KeepAlive (player);
			return ret!;
		}
		/// <param name="gameModelUpdate">An object that describes a valid move from the current state of <c>this</c>.</param><summary>Modifies the internal state of this <see cref="T:GameplayKit.IGKGameModel" /> according to the move described in <paramref name="gameModelUpdate" />.</summary><remarks>To be added.</remarks>
		[Export ("applyGameModelUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ApplyGameModelUpdate (IGKGameModelUpdate gameModelUpdate)
		{
			var gameModelUpdate__handle__ = gameModelUpdate!.GetNonNullHandle (nameof (gameModelUpdate));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("applyGameModelUpdate:"), gameModelUpdate__handle__);
			GC.KeepAlive (gameModelUpdate);
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
			GC.KeepAlive (zone);
			return ret!;
		}
	}
}
