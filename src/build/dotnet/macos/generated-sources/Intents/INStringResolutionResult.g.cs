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
namespace Intents {
	/// <summary><see cref="T:Intents.INIntentResolutionResult" /> for resolving parameters in interactions involving arbitrary strings.</summary><related type="externalDocumentation" href="https://developer.apple.com/reference/Intents/INStringResolutionResult">Apple documentation for <c>INStringResolutionResult</c></related>
	[Register("INStringResolutionResult", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class INStringResolutionResult : INIntentResolutionResult {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConfirmationRequiredWithStringToConfirm_X = "confirmationRequiredWithStringToConfirm:";
		static readonly NativeHandle selConfirmationRequiredWithStringToConfirm_XHandle = Selector.GetHandle ("confirmationRequiredWithStringToConfirm:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisambiguationWithStringsToDisambiguate_X = "disambiguationWithStringsToDisambiguate:";
		static readonly NativeHandle selDisambiguationWithStringsToDisambiguate_XHandle = Selector.GetHandle ("disambiguationWithStringsToDisambiguate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNeedsValueX = "needsValue";
		static readonly NativeHandle selNeedsValueXHandle = Selector.GetHandle ("needsValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNotRequiredX = "notRequired";
		static readonly NativeHandle selNotRequiredXHandle = Selector.GetHandle ("notRequired");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSuccessWithResolvedString_X = "successWithResolvedString:";
		static readonly NativeHandle selSuccessWithResolvedString_XHandle = Selector.GetHandle ("successWithResolvedString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnsupportedX = "unsupported";
		static readonly NativeHandle selUnsupportedXHandle = Selector.GetHandle ("unsupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("INStringResolutionResult");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected INStringResolutionResult (NSObjectFlag t) : base (t)
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
		protected internal INStringResolutionResult (NativeHandle handle) : base (handle)
		{
		}

		[Export ("confirmationRequiredWithStringToConfirm:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static INStringResolutionResult GetConfirmationRequired (string? stringToConfirm)
		{
			var nsstringToConfirm = CFString.CreateNative (stringToConfirm);
			INStringResolutionResult? ret;
			ret =  Runtime.GetNSObject<INStringResolutionResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selConfirmationRequiredWithStringToConfirm_XHandle, nsstringToConfirm), false)!;
			CFString.ReleaseNative (nsstringToConfirm);
			return ret!;
		}
		[Export ("disambiguationWithStringsToDisambiguate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static INStringResolutionResult GetDisambiguation (string[] stringsToDisambiguate)
		{
			if (stringsToDisambiguate is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (stringsToDisambiguate));
			using var nsa_stringsToDisambiguate = NSArray.FromStrings (stringsToDisambiguate);
			INStringResolutionResult ret;
			ret =  Runtime.GetNSObject<INStringResolutionResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selDisambiguationWithStringsToDisambiguate_XHandle, nsa_stringsToDisambiguate.Handle), false)!;
			return ret;
		}
		[Export ("successWithResolvedString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static INStringResolutionResult GetSuccess (string resolvedString)
		{
			if (resolvedString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resolvedString));
			var nsresolvedString = CFString.CreateNative (resolvedString);
			INStringResolutionResult? ret;
			ret =  Runtime.GetNSObject<INStringResolutionResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selSuccessWithResolvedString_XHandle, nsresolvedString), false)!;
			CFString.ReleaseNative (nsresolvedString);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new static INStringResolutionResult NeedsValue {
			[Export ("needsValue")]
			get {
				INStringResolutionResult? ret;
				ret =  Runtime.GetNSObject<INStringResolutionResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selNeedsValueXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new static INStringResolutionResult NotRequired {
			[Export ("notRequired")]
			get {
				INStringResolutionResult? ret;
				ret =  Runtime.GetNSObject<INStringResolutionResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selNotRequiredXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new static INStringResolutionResult Unsupported {
			[Export ("unsupported")]
			get {
				INStringResolutionResult? ret;
				ret =  Runtime.GetNSObject<INStringResolutionResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selUnsupportedXHandle), false)!;
				return ret!;
			}
		}
	} /* class INStringResolutionResult */
}
