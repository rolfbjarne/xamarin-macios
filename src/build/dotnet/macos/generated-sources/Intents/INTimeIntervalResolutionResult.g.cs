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
	[Register("INTimeIntervalResolutionResult", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class INTimeIntervalResolutionResult : INIntentResolutionResult {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConfirmationRequiredWithItemToConfirm_ForReason_X = "confirmationRequiredWithItemToConfirm:forReason:";
		static readonly NativeHandle selConfirmationRequiredWithItemToConfirm_ForReason_XHandle = Selector.GetHandle ("confirmationRequiredWithItemToConfirm:forReason:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConfirmationRequiredWithTimeIntervalToConfirm_X = "confirmationRequiredWithTimeIntervalToConfirm:";
		static readonly NativeHandle selConfirmationRequiredWithTimeIntervalToConfirm_XHandle = Selector.GetHandle ("confirmationRequiredWithTimeIntervalToConfirm:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNeedsValueX = "needsValue";
		static readonly NativeHandle selNeedsValueXHandle = Selector.GetHandle ("needsValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNotRequiredX = "notRequired";
		static readonly NativeHandle selNotRequiredXHandle = Selector.GetHandle ("notRequired");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSuccessWithResolvedTimeInterval_X = "successWithResolvedTimeInterval:";
		static readonly NativeHandle selSuccessWithResolvedTimeInterval_XHandle = Selector.GetHandle ("successWithResolvedTimeInterval:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnsupportedX = "unsupported";
		static readonly NativeHandle selUnsupportedXHandle = Selector.GetHandle ("unsupported");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnsupportedWithReason_X = "unsupportedWithReason:";
		static readonly NativeHandle selUnsupportedWithReason_XHandle = Selector.GetHandle ("unsupportedWithReason:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("INTimeIntervalResolutionResult");
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
		protected INTimeIntervalResolutionResult (NSObjectFlag t) : base (t)
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
		protected internal INTimeIntervalResolutionResult (NativeHandle handle) : base (handle)
		{
		}

		[Export ("confirmationRequiredWithTimeIntervalToConfirm:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static INTimeIntervalResolutionResult ConfirmationRequired (double timeIntervalToConfirm)
		{
			INTimeIntervalResolutionResult ret;
			ret =  Runtime.GetNSObject<INTimeIntervalResolutionResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, selConfirmationRequiredWithTimeIntervalToConfirm_XHandle, timeIntervalToConfirm), false)!;
			return ret;
		}
		[Export ("confirmationRequiredWithItemToConfirm:forReason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new static INTimeIntervalResolutionResult GetConfirmationRequired (NSObject itemToConfirm, nint reason)
		{
			var itemToConfirm__handle__ = itemToConfirm!.GetNonNullHandle (nameof (itemToConfirm));
			INTimeIntervalResolutionResult? ret;
			ret =  Runtime.GetNSObject<INTimeIntervalResolutionResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr (class_ptr, selConfirmationRequiredWithItemToConfirm_ForReason_XHandle, itemToConfirm__handle__, reason), false)!;
			GC.KeepAlive (itemToConfirm);
			return ret!;
		}
		[Export ("successWithResolvedTimeInterval:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static INTimeIntervalResolutionResult GetSuccess (double resolvedTimeInterval)
		{
			INTimeIntervalResolutionResult ret;
			ret =  Runtime.GetNSObject<INTimeIntervalResolutionResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, selSuccessWithResolvedTimeInterval_XHandle, resolvedTimeInterval), false)!;
			return ret;
		}
		[Export ("unsupportedWithReason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new static INTimeIntervalResolutionResult GetUnsupported (nint reason)
		{
			INTimeIntervalResolutionResult ret;
			ret =  Runtime.GetNSObject<INTimeIntervalResolutionResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, selUnsupportedWithReason_XHandle, reason), false)!;
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new static INTimeIntervalResolutionResult NeedsValue {
			[Export ("needsValue")]
			get {
				INTimeIntervalResolutionResult? ret;
				ret =  Runtime.GetNSObject<INTimeIntervalResolutionResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selNeedsValueXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new static INTimeIntervalResolutionResult NotRequired {
			[Export ("notRequired")]
			get {
				INTimeIntervalResolutionResult? ret;
				ret =  Runtime.GetNSObject<INTimeIntervalResolutionResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selNotRequiredXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new static INTimeIntervalResolutionResult Unsupported {
			[Export ("unsupported")]
			get {
				INTimeIntervalResolutionResult? ret;
				ret =  Runtime.GetNSObject<INTimeIntervalResolutionResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selUnsupportedXHandle), false)!;
				return ret!;
			}
		}
	} /* class INTimeIntervalResolutionResult */
}
