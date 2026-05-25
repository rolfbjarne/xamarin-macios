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
namespace Speech {
	#pragma warning disable CS1573
	/// <summary>Delegate object whose members are called in reaction to speech-recognition events.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/Speech/SFSpeechRecognitionTaskDelegate">Apple documentation for <c>SFSpeechRecognitionTaskDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[Protocol (Name = "SFSpeechRecognitionTaskDelegate", WrapperType = typeof (SFSpeechRecognitionTaskDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDetectSpeech", Selector = "speechRecognitionDidDetectSpeech:", ParameterType = new Type [] { typeof (Speech.SFSpeechRecognitionTask) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidHypothesizeTranscription", Selector = "speechRecognitionTask:didHypothesizeTranscription:", ParameterType = new Type [] { typeof (Speech.SFSpeechRecognitionTask), typeof (Speech.SFTranscription) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishRecognition", Selector = "speechRecognitionTask:didFinishRecognition:", ParameterType = new Type [] { typeof (Speech.SFSpeechRecognitionTask), typeof (Speech.SFSpeechRecognitionResult) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FinishedReadingAudio", Selector = "speechRecognitionTaskFinishedReadingAudio:", ParameterType = new Type [] { typeof (Speech.SFSpeechRecognitionTask) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WasCancelled", Selector = "speechRecognitionTaskWasCancelled:", ParameterType = new Type [] { typeof (Speech.SFSpeechRecognitionTask) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishSuccessfully", Selector = "speechRecognitionTask:didFinishSuccessfully:", ParameterType = new Type [] { typeof (Speech.SFSpeechRecognitionTask), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidProcessAudioDuration", Selector = "speechRecognitionTask:didProcessAudioDuration:", ParameterType = new Type [] { typeof (Speech.SFSpeechRecognitionTask), typeof (double) }, ParameterByRef = new bool [] { false, false })]
	public partial interface ISFSpeechRecognitionTaskDelegate : INativeObject, IDisposable
	{
		/// <param name="task">The <see cref="T:Speech.SFSpeechRecognitionTask" /> for which this is the delegate object.</param><summary>The system calls this method periodically as speech is detected.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("speechRecognitionDidDetectSpeech:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDetectSpeech (SFSpeechRecognitionTask task)
		{
			_DidDetectSpeech (this, task);
		}
		/// <param name="task">The <see cref="T:Speech.SFSpeechRecognitionTask" /> for which this is the delegate object.</param><summary>The system calls this method periodically as speech is detected.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidDetectSpeech (ISFSpeechRecognitionTaskDelegate This, SFSpeechRecognitionTask task)
		{
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("speechRecognitionDidDetectSpeech:"), task__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (task);
		}
		/// <param name="task">The <see cref="T:Speech.SFSpeechRecognitionTask" /> for which this is the delegate object.</param><param name="transcription">To be added.</param><summary>The system calls this method periodically, as the speech recognition attempts to refine the results.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("speechRecognitionTask:didHypothesizeTranscription:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidHypothesizeTranscription (SFSpeechRecognitionTask task, SFTranscription transcription)
		{
			_DidHypothesizeTranscription (this, task, transcription);
		}
		/// <param name="task">The <see cref="T:Speech.SFSpeechRecognitionTask" /> for which this is the delegate object.</param><param name="transcription">To be added.</param><summary>The system calls this method periodically, as the speech recognition attempts to refine the results.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidHypothesizeTranscription (ISFSpeechRecognitionTaskDelegate This, SFSpeechRecognitionTask task, SFTranscription transcription)
		{
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			var transcription__handle__ = transcription!.GetNonNullHandle (nameof (transcription));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("speechRecognitionTask:didHypothesizeTranscription:"), task__handle__, transcription__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (task);
			GC.KeepAlive (transcription);
		}
		/// <param name="task">The <see cref="T:Speech.SFSpeechRecognitionTask" /> for which this is the delegate object.</param><param name="recognitionResult">To be added.</param><summary>The system calls this method  after it has completed recognition.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("speechRecognitionTask:didFinishRecognition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishRecognition (SFSpeechRecognitionTask task, SFSpeechRecognitionResult recognitionResult)
		{
			_DidFinishRecognition (this, task, recognitionResult);
		}
		/// <param name="task">The <see cref="T:Speech.SFSpeechRecognitionTask" /> for which this is the delegate object.</param><param name="recognitionResult">To be added.</param><summary>The system calls this method  after it has completed recognition.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishRecognition (ISFSpeechRecognitionTaskDelegate This, SFSpeechRecognitionTask task, SFSpeechRecognitionResult recognitionResult)
		{
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			var recognitionResult__handle__ = recognitionResult!.GetNonNullHandle (nameof (recognitionResult));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("speechRecognitionTask:didFinishRecognition:"), task__handle__, recognitionResult__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (task);
			GC.KeepAlive (recognitionResult);
		}
		/// <param name="task">The <see cref="T:Speech.SFSpeechRecognitionTask" /> for which this is the delegate object.</param><summary>Called by the system after the audio input has finished.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("speechRecognitionTaskFinishedReadingAudio:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishedReadingAudio (SFSpeechRecognitionTask task)
		{
			_FinishedReadingAudio (this, task);
		}
		/// <param name="task">The <see cref="T:Speech.SFSpeechRecognitionTask" /> for which this is the delegate object.</param><summary>Called by the system after the audio input has finished.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FinishedReadingAudio (ISFSpeechRecognitionTaskDelegate This, SFSpeechRecognitionTask task)
		{
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("speechRecognitionTaskFinishedReadingAudio:"), task__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (task);
		}
		/// <param name="task">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("speechRecognitionTaskWasCancelled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WasCancelled (SFSpeechRecognitionTask task)
		{
			_WasCancelled (this, task);
		}
		/// <param name="task">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WasCancelled (ISFSpeechRecognitionTaskDelegate This, SFSpeechRecognitionTask task)
		{
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("speechRecognitionTaskWasCancelled:"), task__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (task);
		}
		/// <param name="task">The <see cref="T:Speech.SFSpeechRecognitionTask" /> for which this is the delegate object.</param><param name="successfully"><see langword="true" /> if the speech recognition ended without error or cancellation.</param><summary>The system calls this method after the <paramref name="task" /> has finished.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("speechRecognitionTask:didFinishSuccessfully:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishSuccessfully (SFSpeechRecognitionTask task, bool successfully)
		{
			_DidFinishSuccessfully (this, task, successfully);
		}
		/// <param name="task">The <see cref="T:Speech.SFSpeechRecognitionTask" /> for which this is the delegate object.</param><param name="successfully"><see langword="true" /> if the speech recognition ended without error or cancellation.</param><summary>The system calls this method after the <paramref name="task" /> has finished.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishSuccessfully (ISFSpeechRecognitionTaskDelegate This, SFSpeechRecognitionTask task, bool successfully)
		{
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("speechRecognitionTask:didFinishSuccessfully:"), task__handle__, successfully ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (task);
		}
		[global::Foundation.OptionalMember]
		[Export ("speechRecognitionTask:didProcessAudioDuration:")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidProcessAudioDuration (SFSpeechRecognitionTask task, double duration)
		{
			_DidProcessAudioDuration (this, task, duration);
		}
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidProcessAudioDuration (ISFSpeechRecognitionTaskDelegate This, SFSpeechRecognitionTask task, double duration)
		{
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double (This.Handle, Selector.GetHandle ("speechRecognitionTask:didProcessAudioDuration:"), task__handle__, duration);
			GC.KeepAlive (This);
			GC.KeepAlive (task);
		}
		[DynamicDependencyAttribute ("DidDetectSpeech(Speech.SFSpeechRecognitionTask)")]
		[DynamicDependencyAttribute ("DidFinishRecognition(Speech.SFSpeechRecognitionTask,Speech.SFSpeechRecognitionResult)")]
		[DynamicDependencyAttribute ("DidFinishSuccessfully(Speech.SFSpeechRecognitionTask,System.Boolean)")]
		[DynamicDependencyAttribute ("DidHypothesizeTranscription(Speech.SFSpeechRecognitionTask,Speech.SFTranscription)")]
		[DynamicDependencyAttribute ("DidProcessAudioDuration(Speech.SFSpeechRecognitionTask,System.Double)")]
		[DynamicDependencyAttribute ("FinishedReadingAudio(Speech.SFSpeechRecognitionTask)")]
		[DynamicDependencyAttribute ("WasCancelled(Speech.SFSpeechRecognitionTask)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SFSpeechRecognitionTaskDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISFSpeechRecognitionTaskDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ISFSpeechRecognitionTaskDelegate" /> interface to support all the methods from the SFSpeechRecognitionTaskDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ISFSpeechRecognitionTaskDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original SFSpeechRecognitionTaskDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class SFSpeechRecognitionTaskDelegate_Extensions {
		/// <param name="task">The <see cref="T:Speech.SFSpeechRecognitionTask" /> for which this is the delegate object.</param><summary>The system calls this method periodically as speech is detected.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidDetectSpeech (this ISFSpeechRecognitionTaskDelegate This, SFSpeechRecognitionTask task)
		{
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("speechRecognitionDidDetectSpeech:"), task__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (task);
		}
		/// <param name="task">The <see cref="T:Speech.SFSpeechRecognitionTask" /> for which this is the delegate object.</param><param name="transcription">To be added.</param><summary>The system calls this method periodically, as the speech recognition attempts to refine the results.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidHypothesizeTranscription (this ISFSpeechRecognitionTaskDelegate This, SFSpeechRecognitionTask task, SFTranscription transcription)
		{
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			var transcription__handle__ = transcription!.GetNonNullHandle (nameof (transcription));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("speechRecognitionTask:didHypothesizeTranscription:"), task__handle__, transcription__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (task);
			GC.KeepAlive (transcription);
		}
		/// <param name="task">The <see cref="T:Speech.SFSpeechRecognitionTask" /> for which this is the delegate object.</param><param name="recognitionResult">To be added.</param><summary>The system calls this method  after it has completed recognition.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishRecognition (this ISFSpeechRecognitionTaskDelegate This, SFSpeechRecognitionTask task, SFSpeechRecognitionResult recognitionResult)
		{
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			var recognitionResult__handle__ = recognitionResult!.GetNonNullHandle (nameof (recognitionResult));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("speechRecognitionTask:didFinishRecognition:"), task__handle__, recognitionResult__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (task);
			GC.KeepAlive (recognitionResult);
		}
		/// <param name="task">The <see cref="T:Speech.SFSpeechRecognitionTask" /> for which this is the delegate object.</param><summary>Called by the system after the audio input has finished.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FinishedReadingAudio (this ISFSpeechRecognitionTaskDelegate This, SFSpeechRecognitionTask task)
		{
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("speechRecognitionTaskFinishedReadingAudio:"), task__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (task);
		}
		/// <param name="task">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WasCancelled (this ISFSpeechRecognitionTaskDelegate This, SFSpeechRecognitionTask task)
		{
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("speechRecognitionTaskWasCancelled:"), task__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (task);
		}
		/// <param name="task">The <see cref="T:Speech.SFSpeechRecognitionTask" /> for which this is the delegate object.</param><param name="successfully"><see langword="true" /> if the speech recognition ended without error or cancellation.</param><summary>The system calls this method after the <paramref name="task" /> has finished.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishSuccessfully (this ISFSpeechRecognitionTaskDelegate This, SFSpeechRecognitionTask task, bool successfully)
		{
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("speechRecognitionTask:didFinishSuccessfully:"), task__handle__, successfully ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (task);
		}
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidProcessAudioDuration (this ISFSpeechRecognitionTaskDelegate This, SFSpeechRecognitionTask task, double duration)
		{
			var task__handle__ = task!.GetNonNullHandle (nameof (task));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Double (This.Handle, Selector.GetHandle ("speechRecognitionTask:didProcessAudioDuration:"), task__handle__, duration);
			GC.KeepAlive (This);
			GC.KeepAlive (task);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SFSpeechRecognitionTaskDelegateWrapper : BaseWrapper, ISFSpeechRecognitionTaskDelegate {
		public SFSpeechRecognitionTaskDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SFSpeechRecognitionTaskDelegateWrapper))]
		static SFSpeechRecognitionTaskDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace Speech {
	/// <summary>Delegate object whose members are called in reaction to speech-recognition events.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/Speech/SFSpeechRecognitionTaskDelegate">Apple documentation for <c>SFSpeechRecognitionTaskDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__Speech_SFSpeechRecognitionTaskDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	public unsafe partial class SFSpeechRecognitionTaskDelegate : NSObject, ISFSpeechRecognitionTaskDelegate {
		/// <summary>Creates a new <see cref="SFSpeechRecognitionTaskDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SFSpeechRecognitionTaskDelegate () : base (NSObjectFlag.Empty)
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
		protected SFSpeechRecognitionTaskDelegate (NSObjectFlag t) : base (t)
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
		protected internal SFSpeechRecognitionTaskDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="task">The <see cref="T:Speech.SFSpeechRecognitionTask" /> for which this is the delegate object.</param><summary>The system calls this method periodically as speech is detected.</summary><remarks>To be added.</remarks>
		[Export ("speechRecognitionDidDetectSpeech:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidDetectSpeech (SFSpeechRecognitionTask task)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="task">The <see cref="T:Speech.SFSpeechRecognitionTask" /> for which this is the delegate object.</param><param name="recognitionResult">To be added.</param><summary>The system calls this method  after it has completed recognition.</summary><remarks>To be added.</remarks>
		[Export ("speechRecognitionTask:didFinishRecognition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishRecognition (SFSpeechRecognitionTask task, SFSpeechRecognitionResult recognitionResult)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="task">The <see cref="T:Speech.SFSpeechRecognitionTask" /> for which this is the delegate object.</param><param name="successfully"><see langword="true" /> if the speech recognition ended without error or cancellation.</param><summary>The system calls this method after the <paramref name="task" /> has finished.</summary><remarks>To be added.</remarks>
		[Export ("speechRecognitionTask:didFinishSuccessfully:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishSuccessfully (SFSpeechRecognitionTask task, bool successfully)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="task">The <see cref="T:Speech.SFSpeechRecognitionTask" /> for which this is the delegate object.</param><param name="transcription">To be added.</param><summary>The system calls this method periodically, as the speech recognition attempts to refine the results.</summary><remarks>To be added.</remarks>
		[Export ("speechRecognitionTask:didHypothesizeTranscription:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidHypothesizeTranscription (SFSpeechRecognitionTask task, SFTranscription transcription)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("speechRecognitionTask:didProcessAudioDuration:")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidProcessAudioDuration (SFSpeechRecognitionTask task, double duration)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="task">The <see cref="T:Speech.SFSpeechRecognitionTask" /> for which this is the delegate object.</param><summary>Called by the system after the audio input has finished.</summary><remarks>To be added.</remarks>
		[Export ("speechRecognitionTaskFinishedReadingAudio:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishedReadingAudio (SFSpeechRecognitionTask task)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="task">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("speechRecognitionTaskWasCancelled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WasCancelled (SFSpeechRecognitionTask task)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class SFSpeechRecognitionTaskDelegate */
}
