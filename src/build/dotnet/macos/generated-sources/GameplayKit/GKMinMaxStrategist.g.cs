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
	/// <summary>Game AI that evaluates potential game states, scores them, and attempts to maximize it's own score while minimizing it's opponents.</summary><remarks><para>The <see cref="T:GameplayKit.GKMinMaxStrategist" /> class is an implementation of the minimax algorithm, optimized for space efficiency. Developers do not subclass <see cref="T:GameplayKit.GKMinMaxStrategist" />, but instead create game-specific implementations of <see cref="T:GameplayKit.IGKGameModelPlayer" />, <see cref="T:GameplayKit.IGKGameModel" />, and <see cref="T:GameplayKit.IGKGameModelUpdate" />. This is discussed in detail in the "AI Opponent" section of the remarks section of the <see cref="N:GameplayKit" /> namespace documentation.</para><para>Perhaps because <see cref="T:GameplayKit.GKMinMaxStrategist" /> is a highly-optimized implementation, it's failure modes are difficult to debug. Typically, a mistake in the configuration of <see cref="T:GameplayKit.GKMinMaxStrategist" /> or in the implementation of the related game classes results in an <see langword="null" /> returned by <see cref="M:GameplayKit.GKMinMaxStrategist.GetBestMove(GameplayKit.IGKGameModelPlayer)" /> with no error message in the console or system log. The following sequence diagram may be of some help in placing breakpoints:</para><para><img href="~/xml/GameplayKit/_images/GKMinMaxStrategist.GetBestMoveMove_Sequence.png" alt="Sequence diagram showing the get best move algorithm." /></para><para>Because <see cref="M:GameplayKit.GKMinMaxStrategist.GetBestMove(GameplayKit.IGKGameModelPlayer)" /> is very expensive, developers should typically call it from a background <see cref="T:System.Threading.Tasks.Task" />.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GameplayKit/Reference/GKMinmaxStrategist_Class/index.html">Apple documentation for <c>GKMinmaxStrategist</c></related>
	[Register("GKMinmaxStrategist", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GKMinMaxStrategist : NSObject, IGKStrategist {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBestMoveForActivePlayerX = "bestMoveForActivePlayer";
		static readonly NativeHandle selBestMoveForActivePlayerXHandle = Selector.GetHandle ("bestMoveForActivePlayer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBestMoveForPlayer_X = "bestMoveForPlayer:";
		static readonly NativeHandle selBestMoveForPlayer_XHandle = Selector.GetHandle ("bestMoveForPlayer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGameModelX = "gameModel";
		static readonly NativeHandle selGameModelXHandle = Selector.GetHandle ("gameModel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxLookAheadDepthX = "maxLookAheadDepth";
		static readonly NativeHandle selMaxLookAheadDepthXHandle = Selector.GetHandle ("maxLookAheadDepth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRandomMoveForPlayer_FromNumberOfBestMoves_X = "randomMoveForPlayer:fromNumberOfBestMoves:";
		static readonly NativeHandle selRandomMoveForPlayer_FromNumberOfBestMoves_XHandle = Selector.GetHandle ("randomMoveForPlayer:fromNumberOfBestMoves:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRandomSourceX = "randomSource";
		static readonly NativeHandle selRandomSourceXHandle = Selector.GetHandle ("randomSource");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetGameModel_X = "setGameModel:";
		static readonly NativeHandle selSetGameModel_XHandle = Selector.GetHandle ("setGameModel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaxLookAheadDepth_X = "setMaxLookAheadDepth:";
		static readonly NativeHandle selSetMaxLookAheadDepth_XHandle = Selector.GetHandle ("setMaxLookAheadDepth:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRandomSource_X = "setRandomSource:";
		static readonly NativeHandle selSetRandomSource_XHandle = Selector.GetHandle ("setRandomSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GKMinmaxStrategist");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="GKMinMaxStrategist" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GKMinMaxStrategist () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
				GC.KeepAlive (this);
				}
			}
		}

		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected GKMinMaxStrategist (NSObjectFlag t) : base (t)
		{
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal GKMinMaxStrategist (NativeHandle handle) : base (handle)
		{
		}

		[Export ("bestMoveForPlayer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IGKGameModelUpdate? GetBestMove (IGKGameModelPlayer player)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			IGKGameModelUpdate? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<IGKGameModelUpdate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selBestMoveForPlayer_XHandle, player__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<IGKGameModelUpdate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selBestMoveForPlayer_XHandle, player__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (player);
			return ret!;
		}
		/// <summary>Returns what the strategist indicates is the best move for the active player.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("bestMoveForActivePlayer")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IGKGameModelUpdate GetBestMoveForActivePlayer ()
		{
			IGKGameModelUpdate ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<IGKGameModelUpdate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBestMoveForActivePlayerXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<IGKGameModelUpdate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBestMoveForActivePlayerXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="player">To be added.</param><param name="numMovesToConsider">To be added.</param><summary>Returns a random move among the <paramref name="numMovesToConsider" /> best moves.</summary><returns>To be added.</returns><remarks><para>If <see cref="GameplayKit.GKMinMaxStrategist.RandomSource" /> is <see langword="null" />, this method returns the same move as <see cref="M:GameplayKit.GKMinMaxStrategist.GetBestMove(GameplayKit.IGKGameModelPlayer)" />.</para></remarks>
		[Export ("randomMoveForPlayer:fromNumberOfBestMoves:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IGKGameModelUpdate? GetRandomMove (IGKGameModelPlayer player, nint numMovesToConsider)
		{
			var player__handle__ = player!.GetNonNullHandle (nameof (player));
			IGKGameModelUpdate? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<IGKGameModelUpdate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (this.Handle, selRandomMoveForPlayer_FromNumberOfBestMoves_XHandle, player__handle__, numMovesToConsider), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<IGKGameModelUpdate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selRandomMoveForPlayer_FromNumberOfBestMoves_XHandle, player__handle__, numMovesToConsider), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (player);
			return ret!;
		}
		/// <summary>Gets or sets the current game state.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual IGKGameModel? GameModel {
			[Export ("gameModel", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				IGKGameModel? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IGKGameModel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selGameModelXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IGKGameModel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selGameModelXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setGameModel:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetGameModel_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetGameModel_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint MaxLookAheadDepth {
			[Export ("maxLookAheadDepth", ArgumentSemantic.Assign)]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMaxLookAheadDepthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selMaxLookAheadDepthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaxLookAheadDepth:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMaxLookAheadDepth_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetMaxLookAheadDepth_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the source of randomness for the strategist.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual IGKRandom? RandomSource {
			[Export ("randomSource", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				IGKRandom? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IGKRandom> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRandomSourceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IGKRandom> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRandomSourceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setRandomSource:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetRandomSource_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetRandomSource_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
	} /* class GKMinMaxStrategist */
}
