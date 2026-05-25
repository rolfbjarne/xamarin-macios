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
	/// <summary>Influences the movement of one or more <see cref="T:GameplayKit.GKAgent" /> objects.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GameplayKit/Reference/GKGoal_Class/index.html">Apple documentation for <c>GKGoal</c></related>
	[Register("GKGoal", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GKGoal : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoalToAlignWithAgents_MaxDistance_MaxAngle_X = "goalToAlignWithAgents:maxDistance:maxAngle:";
		static readonly NativeHandle selGoalToAlignWithAgents_MaxDistance_MaxAngle_XHandle = Selector.GetHandle ("goalToAlignWithAgents:maxDistance:maxAngle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoalToAvoidAgents_MaxPredictionTime_X = "goalToAvoidAgents:maxPredictionTime:";
		static readonly NativeHandle selGoalToAvoidAgents_MaxPredictionTime_XHandle = Selector.GetHandle ("goalToAvoidAgents:maxPredictionTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoalToAvoidObstacles_MaxPredictionTime_X = "goalToAvoidObstacles:maxPredictionTime:";
		static readonly NativeHandle selGoalToAvoidObstacles_MaxPredictionTime_XHandle = Selector.GetHandle ("goalToAvoidObstacles:maxPredictionTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoalToCohereWithAgents_MaxDistance_MaxAngle_X = "goalToCohereWithAgents:maxDistance:maxAngle:";
		static readonly NativeHandle selGoalToCohereWithAgents_MaxDistance_MaxAngle_XHandle = Selector.GetHandle ("goalToCohereWithAgents:maxDistance:maxAngle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoalToFleeAgent_X = "goalToFleeAgent:";
		static readonly NativeHandle selGoalToFleeAgent_XHandle = Selector.GetHandle ("goalToFleeAgent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoalToFollowPath_MaxPredictionTime_Forward_X = "goalToFollowPath:maxPredictionTime:forward:";
		static readonly NativeHandle selGoalToFollowPath_MaxPredictionTime_Forward_XHandle = Selector.GetHandle ("goalToFollowPath:maxPredictionTime:forward:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoalToInterceptAgent_MaxPredictionTime_X = "goalToInterceptAgent:maxPredictionTime:";
		static readonly NativeHandle selGoalToInterceptAgent_MaxPredictionTime_XHandle = Selector.GetHandle ("goalToInterceptAgent:maxPredictionTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoalToReachTargetSpeed_X = "goalToReachTargetSpeed:";
		static readonly NativeHandle selGoalToReachTargetSpeed_XHandle = Selector.GetHandle ("goalToReachTargetSpeed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoalToSeekAgent_X = "goalToSeekAgent:";
		static readonly NativeHandle selGoalToSeekAgent_XHandle = Selector.GetHandle ("goalToSeekAgent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoalToSeparateFromAgents_MaxDistance_MaxAngle_X = "goalToSeparateFromAgents:maxDistance:maxAngle:";
		static readonly NativeHandle selGoalToSeparateFromAgents_MaxDistance_MaxAngle_XHandle = Selector.GetHandle ("goalToSeparateFromAgents:maxDistance:maxAngle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoalToStayOnPath_MaxPredictionTime_X = "goalToStayOnPath:maxPredictionTime:";
		static readonly NativeHandle selGoalToStayOnPath_MaxPredictionTime_XHandle = Selector.GetHandle ("goalToStayOnPath:maxPredictionTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoalToWander_X = "goalToWander:";
		static readonly NativeHandle selGoalToWander_XHandle = Selector.GetHandle ("goalToWander:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GKGoal");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="GKGoal" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GKGoal () : base (NSObjectFlag.Empty)
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
		protected GKGoal (NSObjectFlag t) : base (t)
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
		protected internal GKGoal (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("goalToAlignWithAgents:maxDistance:maxAngle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKGoal GetGoalToAlign (GKAgent[] agents, float maxDistance, float maxAngle)
		{
			if (agents is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (agents));
			using var nsa_agents = NSArray.FromNSObjects (agents);
			GKGoal ret;
			ret =  Runtime.GetNSObject<GKGoal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_float_float (class_ptr, selGoalToAlignWithAgents_MaxDistance_MaxAngle_XHandle, nsa_agents.Handle, maxDistance, maxAngle), false)!;
			return ret;
		}
		[Export ("goalToAvoidAgents:maxPredictionTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKGoal GetGoalToAvoidAgents (GKAgent[] agents, double maxPredictionTime)
		{
			if (agents is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (agents));
			using var nsa_agents = NSArray.FromNSObjects (agents);
			GKGoal ret;
			ret =  Runtime.GetNSObject<GKGoal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double (class_ptr, selGoalToAvoidAgents_MaxPredictionTime_XHandle, nsa_agents.Handle, maxPredictionTime), false)!;
			return ret;
		}
		[Export ("goalToAvoidObstacles:maxPredictionTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKGoal GetGoalToAvoidObstacles (GKObstacle[] obstacles, double maxPredictionTime)
		{
			if (obstacles is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (obstacles));
			using var nsa_obstacles = NSArray.FromNSObjects (obstacles);
			GKGoal ret;
			ret =  Runtime.GetNSObject<GKGoal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double (class_ptr, selGoalToAvoidObstacles_MaxPredictionTime_XHandle, nsa_obstacles.Handle, maxPredictionTime), false)!;
			return ret;
		}
		[Export ("goalToCohereWithAgents:maxDistance:maxAngle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKGoal GetGoalToCohere (GKAgent[] agents, float maxDistance, float maxAngle)
		{
			if (agents is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (agents));
			using var nsa_agents = NSArray.FromNSObjects (agents);
			GKGoal ret;
			ret =  Runtime.GetNSObject<GKGoal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_float_float (class_ptr, selGoalToCohereWithAgents_MaxDistance_MaxAngle_XHandle, nsa_agents.Handle, maxDistance, maxAngle), false)!;
			return ret;
		}
		[Export ("goalToFleeAgent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKGoal GetGoalToFleeAgent (GKAgent agent)
		{
			var agent__handle__ = agent!.GetNonNullHandle (nameof (agent));
			GKGoal? ret;
			ret =  Runtime.GetNSObject<GKGoal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selGoalToFleeAgent_XHandle, agent__handle__), false)!;
			GC.KeepAlive (agent);
			return ret!;
		}
		[Export ("goalToFollowPath:maxPredictionTime:forward:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKGoal GetGoalToFollowPath (GKPath path, double maxPredictionTime, bool forward)
		{
			var path__handle__ = path!.GetNonNullHandle (nameof (path));
			GKGoal? ret;
			ret =  Runtime.GetNSObject<GKGoal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double_bool (class_ptr, selGoalToFollowPath_MaxPredictionTime_Forward_XHandle, path__handle__, maxPredictionTime, forward ? (byte) 1 : (byte) 0), false)!;
			GC.KeepAlive (path);
			return ret!;
		}
		[Export ("goalToInterceptAgent:maxPredictionTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKGoal GetGoalToInterceptAgent (GKAgent target, double maxPredictionTime)
		{
			var target__handle__ = target!.GetNonNullHandle (nameof (target));
			GKGoal? ret;
			ret =  Runtime.GetNSObject<GKGoal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double (class_ptr, selGoalToInterceptAgent_MaxPredictionTime_XHandle, target__handle__, maxPredictionTime), false)!;
			GC.KeepAlive (target);
			return ret!;
		}
		[Export ("goalToReachTargetSpeed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKGoal GetGoalToReachTargetSpeed (float targetSpeed)
		{
			GKGoal ret;
			ret =  Runtime.GetNSObject<GKGoal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float (class_ptr, selGoalToReachTargetSpeed_XHandle, targetSpeed), false)!;
			return ret;
		}
		[Export ("goalToSeekAgent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKGoal GetGoalToSeekAgent (GKAgent agent)
		{
			var agent__handle__ = agent!.GetNonNullHandle (nameof (agent));
			GKGoal? ret;
			ret =  Runtime.GetNSObject<GKGoal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selGoalToSeekAgent_XHandle, agent__handle__), false)!;
			GC.KeepAlive (agent);
			return ret!;
		}
		[Export ("goalToSeparateFromAgents:maxDistance:maxAngle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKGoal GetGoalToSeparate (GKAgent[] agents, float maxDistance, float maxAngle)
		{
			if (agents is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (agents));
			using var nsa_agents = NSArray.FromNSObjects (agents);
			GKGoal ret;
			ret =  Runtime.GetNSObject<GKGoal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_float_float (class_ptr, selGoalToSeparateFromAgents_MaxDistance_MaxAngle_XHandle, nsa_agents.Handle, maxDistance, maxAngle), false)!;
			return ret;
		}
		[Export ("goalToStayOnPath:maxPredictionTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKGoal GetGoalToStayOnPath (GKPath path, double maxPredictionTime)
		{
			var path__handle__ = path!.GetNonNullHandle (nameof (path));
			GKGoal? ret;
			ret =  Runtime.GetNSObject<GKGoal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double (class_ptr, selGoalToStayOnPath_MaxPredictionTime_XHandle, path__handle__, maxPredictionTime), false)!;
			GC.KeepAlive (path);
			return ret!;
		}
		[Export ("goalToWander:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static GKGoal GetGoalToWander (float speed)
		{
			GKGoal ret;
			ret =  Runtime.GetNSObject<GKGoal> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float (class_ptr, selGoalToWander_XHandle, speed), false)!;
			return ret;
		}
	} /* class GKGoal */
}
