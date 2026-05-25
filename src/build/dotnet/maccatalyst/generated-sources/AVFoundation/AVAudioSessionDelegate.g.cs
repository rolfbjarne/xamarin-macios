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
namespace AVFoundation {
	#pragma warning disable CS1573
	/// <summary>Delegate for the AVAudioSession class.</summary><related type="externalDocumentation" href="https://developer.apple.com/documentation/avfaudio/avaudiosessiondelegate">Apple documentation for <c>AVAudioSessionDelegate</c></related>
	[UnsupportedOSPlatform ("macos")]
	[ObsoletedOSPlatform ("ios6.0")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "AVAudioSessionDelegate", WrapperType = typeof (AVAudioSessionDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "BeginInterruption", Selector = "beginInterruption")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EndInterruption", Selector = "endInterruption")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InputIsAvailableChanged", Selector = "inputIsAvailableChanged:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EndInterruption", Selector = "endInterruptionWithFlags:", ParameterType = new Type [] { typeof (AVAudioSessionInterruptionOptions) }, ParameterByRef = new bool [] { false })]
	public partial interface IAVAudioSessionDelegate : INativeObject, IDisposable
	{
		/// <summary>Developers can override this method to react to interruptions of an audio session.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("beginInterruption")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginInterruption ()
		{
			_BeginInterruption (this);
		}
		/// <summary>Developers can override this method to react to interruptions of an audio session.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _BeginInterruption (IAVAudioSessionDelegate This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("beginInterruption"));
			GC.KeepAlive (This);
		}
		/// <summary>Developers can override this method to react to the end of an interruption of an audio session.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("endInterruption")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndInterruption ()
		{
			_EndInterruption (this);
		}
		/// <summary>Developers can override this method to react to the end of an interruption of an audio session.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EndInterruption (IAVAudioSessionDelegate This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("endInterruption"));
			GC.KeepAlive (This);
		}
		/// <param name="isInputAvailable">To be added.</param><summary>Developers can override this method to react to a change in availability of audio inputs.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("inputIsAvailableChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InputIsAvailableChanged (bool isInputAvailable)
		{
			_InputIsAvailableChanged (this, isInputAvailable);
		}
		/// <param name="isInputAvailable">To be added.</param><summary>Developers can override this method to react to a change in availability of audio inputs.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InputIsAvailableChanged (IAVAudioSessionDelegate This, bool isInputAvailable)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("inputIsAvailableChanged:"), isInputAvailable ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <param name="flags">To be added.</param><summary>Developers can override this method to react to the end of an interruption of an audio session.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("endInterruptionWithFlags:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndInterruption (AVAudioSessionInterruptionOptions flags)
		{
			_EndInterruption (this, flags);
		}
		/// <param name="flags">To be added.</param><summary>Developers can override this method to react to the end of an interruption of an audio session.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EndInterruption (IAVAudioSessionDelegate This, AVAudioSessionInterruptionOptions flags)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("endInterruptionWithFlags:"), (UIntPtr) (ulong) flags);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("BeginInterruption()")]
		[DynamicDependencyAttribute ("EndInterruption()")]
		[DynamicDependencyAttribute ("EndInterruption(AVFoundation.AVAudioSessionInterruptionOptions)")]
		[DynamicDependencyAttribute ("InputIsAvailableChanged(System.Boolean)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVAudioSessionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVAudioSessionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAVAudioSessionDelegate" /> interface to support all the methods from the AVAudioSessionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAVAudioSessionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AVAudioSessionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AVAudioSessionDelegate_Extensions {
		/// <summary>Developers can override this method to react to interruptions of an audio session.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void BeginInterruption (this IAVAudioSessionDelegate This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("beginInterruption"));
			GC.KeepAlive (This);
		}
		/// <summary>Developers can override this method to react to the end of an interruption of an audio session.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EndInterruption (this IAVAudioSessionDelegate This)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("endInterruption"));
			GC.KeepAlive (This);
		}
		/// <param name="isInputAvailable">To be added.</param><summary>Developers can override this method to react to a change in availability of audio inputs.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void InputIsAvailableChanged (this IAVAudioSessionDelegate This, bool isInputAvailable)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("inputIsAvailableChanged:"), isInputAvailable ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
		}
		/// <param name="flags">To be added.</param><summary>Developers can override this method to react to the end of an interruption of an audio session.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EndInterruption (this IAVAudioSessionDelegate This, AVAudioSessionInterruptionOptions flags)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("endInterruptionWithFlags:"), (UIntPtr) (ulong) flags);
			GC.KeepAlive (This);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVAudioSessionDelegateWrapper : BaseWrapper, IAVAudioSessionDelegate {
		public AVAudioSessionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVAudioSessionDelegateWrapper))]
		static AVAudioSessionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AVFoundation {
	/// <summary>Delegate for the AVAudioSession class.</summary><related type="externalDocumentation" href="https://developer.apple.com/documentation/avfaudio/avaudiosessiondelegate">Apple documentation for <c>AVAudioSessionDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__AVFoundation_AVAudioSessionDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("macos")]
	[ObsoletedOSPlatform ("ios6.0")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("maccatalyst13.1")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class AVAudioSessionDelegate : NSObject, IAVAudioSessionDelegate {
		/// <summary>Creates a new <see cref="AVAudioSessionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVAudioSessionDelegate () : base (NSObjectFlag.Empty)
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
		protected AVAudioSessionDelegate (NSObjectFlag t) : base (t)
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
		protected internal AVAudioSessionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <summary>Developers can override this method to react to interruptions of an audio session.</summary><remarks>To be added.</remarks>
		[Export ("beginInterruption")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginInterruption ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>Developers can override this method to react to the end of an interruption of an audio session.</summary><remarks>To be added.</remarks>
		[Export ("endInterruption")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndInterruption ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="flags">To be added.</param><summary>Developers can override this method to react to the end of an interruption of an audio session.</summary><remarks>To be added.</remarks>
		[Export ("endInterruptionWithFlags:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndInterruption (AVAudioSessionInterruptionOptions flags)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="isInputAvailable">To be added.</param><summary>Developers can override this method to react to a change in availability of audio inputs.</summary><remarks>To be added.</remarks>
		[Export ("inputIsAvailableChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InputIsAvailableChanged (bool isInputAvailable)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVAudioSessionDelegate */
}
