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
namespace Vision {
	[Register("VNRecognizeAnimalsRequest", true)]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class VNRecognizeAnimalsRequest : VNImageBasedRequest {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentRevisionX = "currentRevision";
		static readonly NativeHandle selCurrentRevisionXHandle = Selector.GetHandle ("currentRevision");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultRevisionX = "defaultRevision";
		static readonly NativeHandle selDefaultRevisionXHandle = Selector.GetHandle ("defaultRevision");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCompletionHandler_X = "initWithCompletionHandler:";
		static readonly NativeHandle selInitWithCompletionHandler_XHandle = Selector.GetHandle ("initWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKnownAnimalIdentifiersForRevision_Error_X = "knownAnimalIdentifiersForRevision:error:";
		static readonly NativeHandle selKnownAnimalIdentifiersForRevision_Error_XHandle = Selector.GetHandle ("knownAnimalIdentifiersForRevision:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultsX = "results";
		static readonly NativeHandle selResultsXHandle = Selector.GetHandle ("results");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRevisionX = "revision";
		static readonly NativeHandle selRevisionXHandle = Selector.GetHandle ("revision");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRevision_X = "setRevision:";
		static readonly NativeHandle selSetRevision_XHandle = Selector.GetHandle ("setRevision:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportedIdentifiersAndReturnError_X = "supportedIdentifiersAndReturnError:";
		static readonly NativeHandle selSupportedIdentifiersAndReturnError_XHandle = Selector.GetHandle ("supportedIdentifiersAndReturnError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportedRevisionsX = "supportedRevisions";
		static readonly NativeHandle selSupportedRevisionsXHandle = Selector.GetHandle ("supportedRevisions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("VNRecognizeAnimalsRequest");
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
		protected VNRecognizeAnimalsRequest (NSObjectFlag t) : base (t)
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
		protected internal VNRecognizeAnimalsRequest (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithCompletionHandler:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe VNRecognizeAnimalsRequest ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDVNRequestCompletionHandler))]VNRequestCompletionHandler? completionHandler)
			: base (NSObjectFlag.Empty)
		{
			using var block_completionHandler = Trampolines.SDVNRequestCompletionHandler.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler), "initWithCompletionHandler:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler), "initWithCompletionHandler:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("knownAnimalIdentifiersForRevision:error:")]
		[ObsoletedOSPlatform ("macos12.0", "Use 'GetSupportedIdentifiers' instead.")]
		[ObsoletedOSPlatform ("ios15.0", "Use 'GetSupportedIdentifiers' instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use 'GetSupportedIdentifiers' instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use 'GetSupportedIdentifiers' instead.")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[return: BindAs (typeof (VNAnimalIdentifier[]), OriginalType = typeof (NSString[]))]
		public unsafe static global::Vision.VNAnimalIdentifier[]? GetKnownAnimalIdentifiers (VNRecognizeAnimalsRequestRevision revision, out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			global::Vision.VNAnimalIdentifier[] ret;
			ret = NSArray.ArrayFromHandleFunc <global::Vision.VNAnimalIdentifier> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_ref_NativeHandle (class_ptr, selKnownAnimalIdentifiersForRevision_Error_XHandle, (UIntPtr) (ulong) revision, &errorValue), global::Vision.VNAnimalIdentifierExtensions.GetValue , false)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("supportedIdentifiersAndReturnError:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[return: BindAs (typeof (VNAnimalIdentifier[]), OriginalType = typeof (NSString[]))]
		public unsafe virtual global::Vision.VNAnimalIdentifier[]? GetSupportedIdentifiers (out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			global::Vision.VNAnimalIdentifier[] ret;
			if (IsDirectBinding) {
				ret = NSArray.ArrayFromHandleFunc <global::Vision.VNAnimalIdentifier> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (this.Handle, selSupportedIdentifiersAndReturnError_XHandle, &errorValue), global::Vision.VNAnimalIdentifierExtensions.GetValue , false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = NSArray.ArrayFromHandleFunc <global::Vision.VNAnimalIdentifier> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selSupportedIdentifiersAndReturnError_XHandle, &errorValue), global::Vision.VNAnimalIdentifierExtensions.GetValue , false)!;
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static VNRecognizeAnimalsRequestRevision CurrentRevision {
			[Export ("currentRevision")]
			get {
				VNRecognizeAnimalsRequestRevision ret;
				ret = (Vision.VNRecognizeAnimalsRequestRevision) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (class_ptr, selCurrentRevisionXHandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static VNRecognizeAnimalsRequestRevision DefaultRevision {
			[Export ("defaultRevision")]
			get {
				VNRecognizeAnimalsRequestRevision ret;
				ret = (Vision.VNRecognizeAnimalsRequestRevision) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (class_ptr, selDefaultRevisionXHandle);
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual VNRecognizedObjectObservation[]? Results {
			[Export ("results", ArgumentSemantic.Copy)]
			get {
				VNRecognizedObjectObservation[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<VNRecognizedObjectObservation>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selResultsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<VNRecognizedObjectObservation>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selResultsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual VNRecognizeAnimalsRequestRevision Revision {
			[Export ("revision")]
			get {
				VNRecognizeAnimalsRequestRevision ret;
				if (IsDirectBinding) {
					ret = (Vision.VNRecognizeAnimalsRequestRevision) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selRevisionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (Vision.VNRecognizeAnimalsRequestRevision) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selRevisionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setRevision:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetRevision_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetRevision_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static VNRecognizeAnimalsRequestRevision[] SupportedRevisions {
			get {
				return (GetSupportedVersions<VNRecognizeAnimalsRequestRevision> (WeakSupportedRevisions) as VNRecognizeAnimalsRequestRevision[])!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSIndexSet WeakSupportedRevisions {
			[Export ("supportedRevisions", ArgumentSemantic.Copy)]
			get {
				NSIndexSet? ret;
				ret =  Runtime.GetNSObject<NSIndexSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSupportedRevisionsXHandle), false)!;
				return ret!;
			}
		}
	} /* class VNRecognizeAnimalsRequest */
}
