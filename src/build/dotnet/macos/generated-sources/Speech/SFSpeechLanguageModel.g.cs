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
namespace Speech {
	[Register("SFSpeechLanguageModel", true)]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	[UnsupportedOSPlatform ("tvos")]
	public unsafe partial class SFSpeechLanguageModel : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareCustomLanguageModelForUrl_ClientIdentifier_Configuration_Completion_X = "prepareCustomLanguageModelForUrl:clientIdentifier:configuration:completion:";
		static readonly NativeHandle selPrepareCustomLanguageModelForUrl_ClientIdentifier_Configuration_Completion_XHandle = Selector.GetHandle ("prepareCustomLanguageModelForUrl:clientIdentifier:configuration:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareCustomLanguageModelForUrl_ClientIdentifier_Configuration_IgnoresCache_Completion_X = "prepareCustomLanguageModelForUrl:clientIdentifier:configuration:ignoresCache:completion:";
		static readonly NativeHandle selPrepareCustomLanguageModelForUrl_ClientIdentifier_Configuration_IgnoresCache_Completion_XHandle = Selector.GetHandle ("prepareCustomLanguageModelForUrl:clientIdentifier:configuration:ignoresCache:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareCustomLanguageModelForUrl_Configuration_Completion_X = "prepareCustomLanguageModelForUrl:configuration:completion:";
		static readonly NativeHandle selPrepareCustomLanguageModelForUrl_Configuration_Completion_XHandle = Selector.GetHandle ("prepareCustomLanguageModelForUrl:configuration:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareCustomLanguageModelForUrl_Configuration_IgnoresCache_Completion_X = "prepareCustomLanguageModelForUrl:configuration:ignoresCache:completion:";
		static readonly NativeHandle selPrepareCustomLanguageModelForUrl_Configuration_IgnoresCache_Completion_XHandle = Selector.GetHandle ("prepareCustomLanguageModelForUrl:configuration:ignoresCache:completion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SFSpeechLanguageModel");
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
		protected SFSpeechLanguageModel (NSObjectFlag t) : base (t)
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
		protected internal SFSpeechLanguageModel (NativeHandle handle) : base (handle)
		{
		}

		[Export ("prepareCustomLanguageModelForUrl:clientIdentifier:configuration:completion:")]
		[ObsoletedOSPlatform ("ios26.0", "Use the 'PrepareCustomModel' overload that takes a 'SFSpeechLanguageModelConfiguration' instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use the 'PrepareCustomModel' overload that takes a 'SFSpeechLanguageModelConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use the 'PrepareCustomModel' overload that takes a 'SFSpeechLanguageModelConfiguration' instead.")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PrepareCustomModel (NSUrl asset, string clientIdentifier, SFSpeechLanguageModelConfiguration configuration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completion)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			if (clientIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (clientIdentifier));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var nsclientIdentifier = CFString.CreateNative (clientIdentifier);
			using var block_completion = Trampolines.SDActionArity1V16.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, selPrepareCustomLanguageModelForUrl_ClientIdentifier_Configuration_Completion_XHandle, asset__handle__, nsclientIdentifier, configuration__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (asset);
			GC.KeepAlive (configuration);
			CFString.ReleaseNative (nsclientIdentifier);
		}
		[ObsoletedOSPlatform ("ios26.0", "Use the 'PrepareCustomModel' overload that takes a 'SFSpeechLanguageModelConfiguration' instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use the 'PrepareCustomModel' overload that takes a 'SFSpeechLanguageModelConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use the 'PrepareCustomModel' overload that takes a 'SFSpeechLanguageModelConfiguration' instead.")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task PrepareCustomModelAsync (NSUrl asset, string clientIdentifier, SFSpeechLanguageModelConfiguration configuration)
		{
			var tcs = new TaskCompletionSource<bool> ();
			PrepareCustomModel(asset, clientIdentifier, configuration, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("prepareCustomLanguageModelForUrl:clientIdentifier:configuration:ignoresCache:completion:")]
		[ObsoletedOSPlatform ("ios26.0", "Use the 'PrepareCustomModel' overload that takes a 'SFSpeechLanguageModelConfiguration' instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use the 'PrepareCustomModel' overload that takes a 'SFSpeechLanguageModelConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use the 'PrepareCustomModel' overload that takes a 'SFSpeechLanguageModelConfiguration' instead.")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PrepareCustomModel (NSUrl asset, string clientIdentifier, SFSpeechLanguageModelConfiguration configuration, bool ignoresCache, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completion)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			if (clientIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (clientIdentifier));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var nsclientIdentifier = CFString.CreateNative (clientIdentifier);
			using var block_completion = Trampolines.SDActionArity1V16.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_bool_NativeHandle (class_ptr, selPrepareCustomLanguageModelForUrl_ClientIdentifier_Configuration_IgnoresCache_Completion_XHandle, asset__handle__, nsclientIdentifier, configuration__handle__, ignoresCache ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completion);
			GC.KeepAlive (asset);
			GC.KeepAlive (configuration);
			CFString.ReleaseNative (nsclientIdentifier);
		}
		[ObsoletedOSPlatform ("ios26.0", "Use the 'PrepareCustomModel' overload that takes a 'SFSpeechLanguageModelConfiguration' instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use the 'PrepareCustomModel' overload that takes a 'SFSpeechLanguageModelConfiguration' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use the 'PrepareCustomModel' overload that takes a 'SFSpeechLanguageModelConfiguration' instead.")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task PrepareCustomModelAsync (NSUrl asset, string clientIdentifier, SFSpeechLanguageModelConfiguration configuration, bool ignoresCache)
		{
			var tcs = new TaskCompletionSource<bool> ();
			PrepareCustomModel(asset, clientIdentifier, configuration, ignoresCache, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("prepareCustomLanguageModelForUrl:configuration:completion:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PrepareCustomModel (NSUrl asset, SFSpeechLanguageModelConfiguration configuration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSFSpeechLanguageModelPrepareCustomModelHandler))]SFSpeechLanguageModelPrepareCustomModelHandler completion)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDSFSpeechLanguageModelPrepareCustomModelHandler.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selPrepareCustomLanguageModelForUrl_Configuration_Completion_XHandle, asset__handle__, configuration__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (asset);
			GC.KeepAlive (configuration);
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task PrepareCustomModelAsync (NSUrl asset, SFSpeechLanguageModelConfiguration configuration)
		{
			var tcs = new TaskCompletionSource<bool> ();
			PrepareCustomModel(asset, configuration, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("prepareCustomLanguageModelForUrl:configuration:ignoresCache:completion:")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void PrepareCustomModel (NSUrl asset, SFSpeechLanguageModelConfiguration configuration, bool ignoresCache, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDSFSpeechLanguageModelPrepareCustomModelHandler))]SFSpeechLanguageModelPrepareCustomModelHandler completion)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDSFSpeechLanguageModelPrepareCustomModelHandler.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool_NativeHandle (class_ptr, selPrepareCustomLanguageModelForUrl_Configuration_IgnoresCache_Completion_XHandle, asset__handle__, configuration__handle__, ignoresCache ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_completion);
			GC.KeepAlive (asset);
			GC.KeepAlive (configuration);
		}
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task PrepareCustomModelAsync (NSUrl asset, SFSpeechLanguageModelConfiguration configuration, bool ignoresCache)
		{
			var tcs = new TaskCompletionSource<bool> ();
			PrepareCustomModel(asset, configuration, ignoresCache, (error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
	} /* class SFSpeechLanguageModel */
}
