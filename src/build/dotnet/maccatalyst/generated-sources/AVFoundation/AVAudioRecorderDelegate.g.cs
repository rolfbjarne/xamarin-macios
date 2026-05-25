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
	/// <summary>Delegate for the AVAudioRecorder class.</summary><related type="externalDocumentation" href="https://developer.apple.com/documentation/avfaudio/avaudiorecorderdelegate">Apple documentation for <c>AVAudioRecorderDelegate</c></related>
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "AVAudioRecorderDelegate", WrapperType = typeof (AVAudioRecorderDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FinishedRecording", Selector = "audioRecorderDidFinishRecording:successfully:", ParameterType = new Type [] { typeof (AVAudioRecorder), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EncoderError", Selector = "audioRecorderEncodeErrorDidOccur:error:", ParameterType = new Type [] { typeof (AVAudioRecorder), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "BeginInterruption", Selector = "audioRecorderBeginInterruption:", ParameterType = new Type [] { typeof (AVAudioRecorder) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EndInterruption", Selector = "audioRecorderEndInterruption:", ParameterType = new Type [] { typeof (AVAudioRecorder) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EndInterruption", Selector = "audioRecorderEndInterruption:withOptions:", ParameterType = new Type [] { typeof (AVAudioRecorder), typeof (AVAudioSessionInterruptionOptions) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IAVAudioRecorderDelegate : INativeObject, IDisposable
	{
		/// <param name="recorder">To be added.</param><param name="flag">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("audioRecorderDidFinishRecording:successfully:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishedRecording (AVAudioRecorder recorder, bool flag)
		{
			_FinishedRecording (this, recorder, flag);
		}
		/// <param name="recorder">To be added.</param><param name="flag">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FinishedRecording (IAVAudioRecorderDelegate This, AVAudioRecorder recorder, bool flag)
		{
			var recorder__handle__ = recorder!.GetNonNullHandle (nameof (recorder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("audioRecorderDidFinishRecording:successfully:"), recorder__handle__, flag ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (recorder);
		}
		/// <param name="recorder">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("audioRecorderEncodeErrorDidOccur:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncoderError (AVAudioRecorder recorder, NSError? error)
		{
			_EncoderError (this, recorder, error);
		}
		/// <param name="recorder">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EncoderError (IAVAudioRecorderDelegate This, AVAudioRecorder recorder, NSError? error)
		{
			var recorder__handle__ = recorder!.GetNonNullHandle (nameof (recorder));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("audioRecorderEncodeErrorDidOccur:error:"), recorder__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (recorder);
			GC.KeepAlive (error);
		}
		/// <param name="recorder">To be added.</param><summary>Developers should not use this deprecated method. </summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("audioRecorderBeginInterruption:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios8.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginInterruption (AVAudioRecorder recorder)
		{
			_BeginInterruption (this, recorder);
		}
		/// <param name="recorder">To be added.</param><summary>Developers should not use this deprecated method. </summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios8.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _BeginInterruption (IAVAudioRecorderDelegate This, AVAudioRecorder recorder)
		{
			var recorder__handle__ = recorder!.GetNonNullHandle (nameof (recorder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("audioRecorderBeginInterruption:"), recorder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (recorder);
		}
		/// <param name="recorder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("audioRecorderEndInterruption:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios6.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndInterruption (AVAudioRecorder recorder)
		{
			_EndInterruption (this, recorder);
		}
		/// <param name="recorder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios6.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EndInterruption (IAVAudioRecorderDelegate This, AVAudioRecorder recorder)
		{
			var recorder__handle__ = recorder!.GetNonNullHandle (nameof (recorder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("audioRecorderEndInterruption:"), recorder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (recorder);
		}
		[global::Foundation.OptionalMember]
		[Export ("audioRecorderEndInterruption:withOptions:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndInterruption (AVAudioRecorder recorder, AVAudioSessionInterruptionOptions flags)
		{
			_EndInterruption (this, recorder, flags);
		}
		[ObsoletedOSPlatform ("ios8.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _EndInterruption (IAVAudioRecorderDelegate This, AVAudioRecorder recorder, AVAudioSessionInterruptionOptions flags)
		{
			var recorder__handle__ = recorder!.GetNonNullHandle (nameof (recorder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("audioRecorderEndInterruption:withOptions:"), recorder__handle__, (UIntPtr) (ulong) flags);
			GC.KeepAlive (This);
			GC.KeepAlive (recorder);
		}
		[DynamicDependencyAttribute ("BeginInterruption(AVFoundation.AVAudioRecorder)")]
		[DynamicDependencyAttribute ("EncoderError(AVFoundation.AVAudioRecorder,Foundation.NSError)")]
		[DynamicDependencyAttribute ("EndInterruption(AVFoundation.AVAudioRecorder,AVFoundation.AVAudioSessionInterruptionOptions)")]
		[DynamicDependencyAttribute ("EndInterruption(AVFoundation.AVAudioRecorder)")]
		[DynamicDependencyAttribute ("FinishedRecording(AVFoundation.AVAudioRecorder,System.Boolean)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVAudioRecorderDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVAudioRecorderDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAVAudioRecorderDelegate" /> interface to support all the methods from the AVAudioRecorderDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAVAudioRecorderDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AVAudioRecorderDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AVAudioRecorderDelegate_Extensions {
		/// <param name="recorder">To be added.</param><param name="flag">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FinishedRecording (this IAVAudioRecorderDelegate This, AVAudioRecorder recorder, bool flag)
		{
			var recorder__handle__ = recorder!.GetNonNullHandle (nameof (recorder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("audioRecorderDidFinishRecording:successfully:"), recorder__handle__, flag ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (recorder);
		}
		/// <param name="recorder">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EncoderError (this IAVAudioRecorderDelegate This, AVAudioRecorder recorder, NSError? error)
		{
			var recorder__handle__ = recorder!.GetNonNullHandle (nameof (recorder));
			var error__handle__ = error.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("audioRecorderEncodeErrorDidOccur:error:"), recorder__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (recorder);
			GC.KeepAlive (error);
		}
		/// <param name="recorder">To be added.</param><summary>Developers should not use this deprecated method. </summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios8.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void BeginInterruption (this IAVAudioRecorderDelegate This, AVAudioRecorder recorder)
		{
			var recorder__handle__ = recorder!.GetNonNullHandle (nameof (recorder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("audioRecorderBeginInterruption:"), recorder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (recorder);
		}
		/// <param name="recorder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios6.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EndInterruption (this IAVAudioRecorderDelegate This, AVAudioRecorder recorder)
		{
			var recorder__handle__ = recorder!.GetNonNullHandle (nameof (recorder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("audioRecorderEndInterruption:"), recorder__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (recorder);
		}
		[ObsoletedOSPlatform ("ios8.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void EndInterruption (this IAVAudioRecorderDelegate This, AVAudioRecorder recorder, AVAudioSessionInterruptionOptions flags)
		{
			var recorder__handle__ = recorder!.GetNonNullHandle (nameof (recorder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("audioRecorderEndInterruption:withOptions:"), recorder__handle__, (UIntPtr) (ulong) flags);
			GC.KeepAlive (This);
			GC.KeepAlive (recorder);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVAudioRecorderDelegateWrapper : BaseWrapper, IAVAudioRecorderDelegate {
		public AVAudioRecorderDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVAudioRecorderDelegateWrapper))]
		static AVAudioRecorderDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AVFoundation {
	/// <summary>Delegate for the AVAudioRecorder class.</summary><related type="externalDocumentation" href="https://developer.apple.com/documentation/avfaudio/avaudiorecorderdelegate">Apple documentation for <c>AVAudioRecorderDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__AVFoundation_AVAudioRecorderDelegate", false)]
	[Model]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class AVAudioRecorderDelegate : NSObject, IAVAudioRecorderDelegate {
		/// <summary>Creates a new <see cref="AVAudioRecorderDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVAudioRecorderDelegate () : base (NSObjectFlag.Empty)
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
		protected AVAudioRecorderDelegate (NSObjectFlag t) : base (t)
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
		protected internal AVAudioRecorderDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="recorder">To be added.</param><summary>Developers should not use this deprecated method. </summary><remarks>To be added.</remarks>
		[Export ("audioRecorderBeginInterruption:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios8.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginInterruption (AVAudioRecorder recorder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="recorder">To be added.</param><param name="error"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("audioRecorderEncodeErrorDidOccur:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncoderError (AVAudioRecorder recorder, NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="recorder">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("audioRecorderEndInterruption:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios6.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndInterruption (AVAudioRecorder recorder)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("audioRecorderEndInterruption:withOptions:")]
		[ObsoletedOSPlatform ("ios8.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndInterruption (AVAudioRecorder recorder, AVAudioSessionInterruptionOptions flags)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="recorder">To be added.</param><param name="flag">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("audioRecorderDidFinishRecording:successfully:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishedRecording (AVAudioRecorder recorder, bool flag)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVAudioRecorderDelegate */
}
