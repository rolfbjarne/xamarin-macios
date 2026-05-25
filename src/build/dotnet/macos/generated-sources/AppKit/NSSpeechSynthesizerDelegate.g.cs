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
namespace AppKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSSpeechSynthesizerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos14.0", "Use 'AVSpeechSynthesizer' in AVFoundation instead.")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSSpeechSynthesizerDelegate", WrapperType = typeof (NSSpeechSynthesizerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishSpeaking", Selector = "speechSynthesizer:didFinishSpeaking:", ParameterType = new Type [] { typeof (NSSpeechSynthesizer), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillSpeakWord", Selector = "speechSynthesizer:willSpeakWord:ofString:", ParameterType = new Type [] { typeof (NSSpeechSynthesizer), typeof (NSRange), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillSpeakPhoneme", Selector = "speechSynthesizer:willSpeakPhoneme:", ParameterType = new Type [] { typeof (NSSpeechSynthesizer), typeof (Int16) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEncounterError", Selector = "speechSynthesizer:didEncounterErrorAtIndex:ofString:message:", ParameterType = new Type [] { typeof (NSSpeechSynthesizer), typeof (UIntPtr), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEncounterSyncMessage", Selector = "speechSynthesizer:didEncounterSyncMessage:", ParameterType = new Type [] { typeof (NSSpeechSynthesizer), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSSpeechSynthesizerDelegate : INativeObject, IDisposable
	{
		/// <param name="sender">To be added.</param><param name="finishedSpeaking">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("speechSynthesizer:didFinishSpeaking:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishSpeaking (NSSpeechSynthesizer sender, bool finishedSpeaking)
		{
			_DidFinishSpeaking (this, sender, finishedSpeaking);
		}
		/// <param name="sender">To be added.</param><param name="finishedSpeaking">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidFinishSpeaking (INSSpeechSynthesizerDelegate This, NSSpeechSynthesizer sender, bool finishedSpeaking)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("speechSynthesizer:didFinishSpeaking:"), sender__handle__, finishedSpeaking ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="wordCharacterRange">To be added.</param><param name="ofString">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("speechSynthesizer:willSpeakWord:ofString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillSpeakWord (NSSpeechSynthesizer sender, NSRange wordCharacterRange, string ofString)
		{
			_WillSpeakWord (this, sender, wordCharacterRange, ofString);
		}
		/// <param name="sender">To be added.</param><param name="wordCharacterRange">To be added.</param><param name="ofString">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillSpeakWord (INSSpeechSynthesizerDelegate This, NSSpeechSynthesizer sender, NSRange wordCharacterRange, string ofString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (ofString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ofString));
			var nsofString = CFString.CreateNative (ofString);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("speechSynthesizer:willSpeakWord:ofString:"), sender__handle__, wordCharacterRange, nsofString);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsofString);
		}
		/// <param name="sender">To be added.</param><param name="phonemeOpcode">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("speechSynthesizer:willSpeakPhoneme:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillSpeakPhoneme (NSSpeechSynthesizer sender, short phonemeOpcode)
		{
			_WillSpeakPhoneme (this, sender, phonemeOpcode);
		}
		/// <param name="sender">To be added.</param><param name="phonemeOpcode">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillSpeakPhoneme (INSSpeechSynthesizerDelegate This, NSSpeechSynthesizer sender, short phonemeOpcode)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_short (This.Handle, Selector.GetHandle ("speechSynthesizer:willSpeakPhoneme:"), sender__handle__, phonemeOpcode);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="characterIndex">To be added.</param><param name="theString">To be added.</param><param name="message">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("speechSynthesizer:didEncounterErrorAtIndex:ofString:message:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEncounterError (NSSpeechSynthesizer sender, nuint characterIndex, string theString, string message)
		{
			_DidEncounterError (this, sender, characterIndex, theString, message);
		}
		/// <param name="sender">To be added.</param><param name="characterIndex">To be added.</param><param name="theString">To be added.</param><param name="message">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEncounterError (INSSpeechSynthesizerDelegate This, NSSpeechSynthesizer sender, nuint characterIndex, string theString, string message)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (theString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (theString));
			if (message is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var nstheString = CFString.CreateNative (theString);
			var nsmessage = CFString.CreateNative (message);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("speechSynthesizer:didEncounterErrorAtIndex:ofString:message:"), sender__handle__, characterIndex, nstheString, nsmessage);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nstheString);
			CFString.ReleaseNative (nsmessage);
		}
		/// <param name="sender">To be added.</param><param name="message">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("speechSynthesizer:didEncounterSyncMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEncounterSyncMessage (NSSpeechSynthesizer sender, string message)
		{
			_DidEncounterSyncMessage (this, sender, message);
		}
		/// <param name="sender">To be added.</param><param name="message">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEncounterSyncMessage (INSSpeechSynthesizerDelegate This, NSSpeechSynthesizer sender, string message)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (message is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var nsmessage = CFString.CreateNative (message);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("speechSynthesizer:didEncounterSyncMessage:"), sender__handle__, nsmessage);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsmessage);
		}
		[DynamicDependencyAttribute ("DidEncounterError(AppKit.NSSpeechSynthesizer,System.UIntPtr,System.String,System.String)")]
		[DynamicDependencyAttribute ("DidEncounterSyncMessage(AppKit.NSSpeechSynthesizer,System.String)")]
		[DynamicDependencyAttribute ("DidFinishSpeaking(AppKit.NSSpeechSynthesizer,System.Boolean)")]
		[DynamicDependencyAttribute ("WillSpeakPhoneme(AppKit.NSSpeechSynthesizer,System.Int16)")]
		[DynamicDependencyAttribute ("WillSpeakWord(AppKit.NSSpeechSynthesizer,Foundation.NSRange,System.String)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSSpeechSynthesizerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSSpeechSynthesizerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSSpeechSynthesizerDelegate" /> interface to support all the methods from the NSSpeechSynthesizerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSSpeechSynthesizerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSSpeechSynthesizerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSSpeechSynthesizerDelegate_Extensions {
		/// <param name="sender">To be added.</param><param name="finishedSpeaking">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidFinishSpeaking (this INSSpeechSynthesizerDelegate This, NSSpeechSynthesizer sender, bool finishedSpeaking)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("speechSynthesizer:didFinishSpeaking:"), sender__handle__, finishedSpeaking ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="wordCharacterRange">To be added.</param><param name="ofString">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillSpeakWord (this INSSpeechSynthesizerDelegate This, NSSpeechSynthesizer sender, NSRange wordCharacterRange, string ofString)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (ofString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ofString));
			var nsofString = CFString.CreateNative (ofString);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("speechSynthesizer:willSpeakWord:ofString:"), sender__handle__, wordCharacterRange, nsofString);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsofString);
		}
		/// <param name="sender">To be added.</param><param name="phonemeOpcode">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillSpeakPhoneme (this INSSpeechSynthesizerDelegate This, NSSpeechSynthesizer sender, short phonemeOpcode)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_short (This.Handle, Selector.GetHandle ("speechSynthesizer:willSpeakPhoneme:"), sender__handle__, phonemeOpcode);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
		}
		/// <param name="sender">To be added.</param><param name="characterIndex">To be added.</param><param name="theString">To be added.</param><param name="message">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEncounterError (this INSSpeechSynthesizerDelegate This, NSSpeechSynthesizer sender, nuint characterIndex, string theString, string message)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (theString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (theString));
			if (message is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var nstheString = CFString.CreateNative (theString);
			var nsmessage = CFString.CreateNative (message);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("speechSynthesizer:didEncounterErrorAtIndex:ofString:message:"), sender__handle__, characterIndex, nstheString, nsmessage);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nstheString);
			CFString.ReleaseNative (nsmessage);
		}
		/// <param name="sender">To be added.</param><param name="message">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEncounterSyncMessage (this INSSpeechSynthesizerDelegate This, NSSpeechSynthesizer sender, string message)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			if (message is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var nsmessage = CFString.CreateNative (message);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("speechSynthesizer:didEncounterSyncMessage:"), sender__handle__, nsmessage);
			GC.KeepAlive (This);
			GC.KeepAlive (sender);
			CFString.ReleaseNative (nsmessage);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSSpeechSynthesizerDelegateWrapper : BaseWrapper, INSSpeechSynthesizerDelegate {
		public NSSpeechSynthesizerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSSpeechSynthesizerDelegateWrapper))]
		static NSSpeechSynthesizerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSSpeechSynthesizerDelegate" /> (for the protocol <c>NSSpeechSynthesizerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSSpeechSynthesizerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSSpeechSynthesizerDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos14.0", "Use 'AVSpeechSynthesizer' in AVFoundation instead.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSSpeechSynthesizerDelegate : NSObject, INSSpeechSynthesizerDelegate {
		/// <summary>Creates a new <see cref="NSSpeechSynthesizerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSSpeechSynthesizerDelegate () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		protected NSSpeechSynthesizerDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSSpeechSynthesizerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="sender">To be added.</param><param name="characterIndex">To be added.</param><param name="theString">To be added.</param><param name="message">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("speechSynthesizer:didEncounterErrorAtIndex:ofString:message:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEncounterError (NSSpeechSynthesizer sender, nuint characterIndex, string theString, string message)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="message">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("speechSynthesizer:didEncounterSyncMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEncounterSyncMessage (NSSpeechSynthesizer sender, string message)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="finishedSpeaking">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("speechSynthesizer:didFinishSpeaking:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidFinishSpeaking (NSSpeechSynthesizer sender, bool finishedSpeaking)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="phonemeOpcode">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("speechSynthesizer:willSpeakPhoneme:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillSpeakPhoneme (NSSpeechSynthesizer sender, short phonemeOpcode)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="sender">To be added.</param><param name="wordCharacterRange">To be added.</param><param name="ofString">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("speechSynthesizer:willSpeakWord:ofString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillSpeakWord (NSSpeechSynthesizer sender, NSRange wordCharacterRange, string ofString)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSSpeechSynthesizerDelegate */
}
