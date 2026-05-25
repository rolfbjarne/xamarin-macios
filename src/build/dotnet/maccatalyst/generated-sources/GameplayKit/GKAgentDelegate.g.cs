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
	/// <summary>Delegate object that provides methods relating to synchronizing the state of a <see cref="T:GameplayKit.GKAgent" /> with external constraints, goals, and representations.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GameplayKit/Reference/GKAgentDelegate_Protocol/index.html">Apple documentation for <c>GKAgentDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "GKAgentDelegate", WrapperType = typeof (GKAgentDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AgentWillUpdate", Selector = "agentWillUpdate:", ParameterType = new Type [] { typeof (GKAgent) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AgentDidUpdate", Selector = "agentDidUpdate:", ParameterType = new Type [] { typeof (GKAgent) }, ParameterByRef = new bool [] { false })]
	public partial interface IGKAgentDelegate : INativeObject, IDisposable
	{
		/// <param name="agent">To be added.</param><summary>Method that is called before <paramref name="agent" /> performs a simulation step.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("agentWillUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AgentWillUpdate (GKAgent agent)
		{
			_AgentWillUpdate (this, agent);
		}
		/// <param name="agent">To be added.</param><summary>Method that is called before <paramref name="agent" /> performs a simulation step.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AgentWillUpdate (IGKAgentDelegate This, GKAgent agent)
		{
			var agent__handle__ = agent!.GetNonNullHandle (nameof (agent));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("agentWillUpdate:"), agent__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (agent);
		}
		/// <param name="agent">To be added.</param><summary>Method that is called after <paramref name="agent" /> has performed a simulation step.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("agentDidUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AgentDidUpdate (GKAgent agent)
		{
			_AgentDidUpdate (this, agent);
		}
		/// <param name="agent">To be added.</param><summary>Method that is called after <paramref name="agent" /> has performed a simulation step.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AgentDidUpdate (IGKAgentDelegate This, GKAgent agent)
		{
			var agent__handle__ = agent!.GetNonNullHandle (nameof (agent));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("agentDidUpdate:"), agent__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (agent);
		}
		[DynamicDependencyAttribute ("AgentDidUpdate(GameplayKit.GKAgent)")]
		[DynamicDependencyAttribute ("AgentWillUpdate(GameplayKit.GKAgent)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKAgentDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IGKAgentDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IGKAgentDelegate" /> interface to support all the methods from the GKAgentDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IGKAgentDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original GKAgentDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class GKAgentDelegate_Extensions {
		/// <param name="agent">To be added.</param><summary>Method that is called before <paramref name="agent" /> performs a simulation step.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AgentWillUpdate (this IGKAgentDelegate This, GKAgent agent)
		{
			var agent__handle__ = agent!.GetNonNullHandle (nameof (agent));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("agentWillUpdate:"), agent__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (agent);
		}
		/// <param name="agent">To be added.</param><summary>Method that is called after <paramref name="agent" /> has performed a simulation step.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AgentDidUpdate (this IGKAgentDelegate This, GKAgent agent)
		{
			var agent__handle__ = agent!.GetNonNullHandle (nameof (agent));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("agentDidUpdate:"), agent__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (agent);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class GKAgentDelegateWrapper : BaseWrapper, IGKAgentDelegate {
		public GKAgentDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (GKAgentDelegateWrapper))]
		static GKAgentDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace GameplayKit {
	/// <summary>Delegate object that provides methods relating to synchronizing the state of a <see cref="T:GameplayKit.GKAgent" /> with external constraints, goals, and representations.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GameplayKit/Reference/GKAgentDelegate_Protocol/index.html">Apple documentation for <c>GKAgentDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__GameplayKit_GKAgentDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GKAgentDelegate : NSObject, IGKAgentDelegate {
		/// <summary>Creates a new <see cref="GKAgentDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GKAgentDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
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
		protected GKAgentDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
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
		protected internal GKAgentDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="agent">To be added.</param><summary>Method that is called after <paramref name="agent" /> has performed a simulation step.</summary><remarks>To be added.</remarks>
		[Export ("agentDidUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AgentDidUpdate (GKAgent agent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="agent">To be added.</param><summary>Method that is called before <paramref name="agent" /> performs a simulation step.</summary><remarks>To be added.</remarks>
		[Export ("agentWillUpdate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AgentWillUpdate (GKAgent agent)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class GKAgentDelegate */
}
