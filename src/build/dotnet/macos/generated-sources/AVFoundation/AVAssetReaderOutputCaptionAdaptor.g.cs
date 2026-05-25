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
namespace AVFoundation {
	[Register("AVAssetReaderOutputCaptionAdaptor", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios18.0")]
	public unsafe partial class AVAssetReaderOutputCaptionAdaptor : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAssetReaderOutputCaptionAdaptorWithAssetReaderTrackOutput_X = "assetReaderOutputCaptionAdaptorWithAssetReaderTrackOutput:";
		static readonly NativeHandle selAssetReaderOutputCaptionAdaptorWithAssetReaderTrackOutput_XHandle = Selector.GetHandle ("assetReaderOutputCaptionAdaptorWithAssetReaderTrackOutput:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAssetReaderTrackOutputX = "assetReaderTrackOutput";
		static readonly NativeHandle selAssetReaderTrackOutputXHandle = Selector.GetHandle ("assetReaderTrackOutput");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCaptionsNotPresentInPreviousGroupsInCaptionGroup_X = "captionsNotPresentInPreviousGroupsInCaptionGroup:";
		static readonly NativeHandle selCaptionsNotPresentInPreviousGroupsInCaptionGroup_XHandle = Selector.GetHandle ("captionsNotPresentInPreviousGroupsInCaptionGroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithAssetReaderTrackOutput_X = "initWithAssetReaderTrackOutput:";
		static readonly NativeHandle selInitWithAssetReaderTrackOutput_XHandle = Selector.GetHandle ("initWithAssetReaderTrackOutput:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNextCaptionGroupX = "nextCaptionGroup";
		static readonly NativeHandle selNextCaptionGroupXHandle = Selector.GetHandle ("nextCaptionGroup");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetValidationDelegate_X = "setValidationDelegate:";
		static readonly NativeHandle selSetValidationDelegate_XHandle = Selector.GetHandle ("setValidationDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidationDelegateX = "validationDelegate";
		static readonly NativeHandle selValidationDelegateXHandle = Selector.GetHandle ("validationDelegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVAssetReaderOutputCaptionAdaptor");
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
		protected AVAssetReaderOutputCaptionAdaptor (NSObjectFlag t) : base (t)
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
		protected internal AVAssetReaderOutputCaptionAdaptor (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithAssetReaderTrackOutput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVAssetReaderOutputCaptionAdaptor (AVAssetReaderTrackOutput trackOutput)
			: base (NSObjectFlag.Empty)
		{
			var trackOutput__handle__ = trackOutput!.GetNonNullHandle (nameof (trackOutput));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithAssetReaderTrackOutput_XHandle, trackOutput__handle__), "initWithAssetReaderTrackOutput:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithAssetReaderTrackOutput_XHandle, trackOutput__handle__), "initWithAssetReaderTrackOutput:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (trackOutput);
		}
		[Export ("assetReaderOutputCaptionAdaptorWithAssetReaderTrackOutput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVAssetReaderOutputCaptionAdaptor Create (AVAssetReaderTrackOutput trackOutput)
		{
			var trackOutput__handle__ = trackOutput!.GetNonNullHandle (nameof (trackOutput));
			AVAssetReaderOutputCaptionAdaptor? ret;
			ret =  Runtime.GetNSObject<AVAssetReaderOutputCaptionAdaptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selAssetReaderOutputCaptionAdaptorWithAssetReaderTrackOutput_XHandle, trackOutput__handle__), false)!;
			GC.KeepAlive (trackOutput);
			return ret!;
		}
		[Export ("captionsNotPresentInPreviousGroupsInCaptionGroup:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVCaption[] GetCaptionsNotPresentInPreviousGroups (AVCaptionGroup captionGroup)
		{
			var captionGroup__handle__ = captionGroup!.GetNonNullHandle (nameof (captionGroup));
			AVCaption[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<AVCaption>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCaptionsNotPresentInPreviousGroupsInCaptionGroup_XHandle, captionGroup__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<AVCaption>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCaptionsNotPresentInPreviousGroupsInCaptionGroup_XHandle, captionGroup__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (captionGroup);
			return ret!;
		}
		[Export ("nextCaptionGroup")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVCaptionGroup? GetNextCaptionGroup ()
		{
			AVCaptionGroup ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AVCaptionGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNextCaptionGroupXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<AVCaptionGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNextCaptionGroupXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AVAssetReaderTrackOutput AssetReaderTrackOutput {
			[Export ("assetReaderTrackOutput")]
			get {
				AVAssetReaderTrackOutput? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<AVAssetReaderTrackOutput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAssetReaderTrackOutputXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<AVAssetReaderTrackOutput> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAssetReaderTrackOutputXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IAVAssetReaderCaptionValidationHandling? ValidationDelegate {
			get {
				return (WeakValidationDelegate as IAVAssetReaderCaptionValidationHandling)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakValidationDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakValidationDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakValidationDelegate {
			[Export ("validationDelegate", ArgumentSemantic.Weak)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selValidationDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selValidationDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_WeakValidationDelegate_var = ret;
				return ret!;
			}
			[Export ("setValidationDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetValidationDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetValidationDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_WeakValidationDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakValidationDelegate_var = null;
			}
		}
	} /* class AVAssetReaderOutputCaptionAdaptor */
}
