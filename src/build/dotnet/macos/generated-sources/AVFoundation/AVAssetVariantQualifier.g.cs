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
	[Register("AVAssetVariantQualifier", true)]
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class AVAssetVariantQualifier : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAssetVariantQualifierWithPredicate_X = "assetVariantQualifierWithPredicate:";
		static readonly NativeHandle selAssetVariantQualifierWithPredicate_XHandle = Selector.GetHandle ("assetVariantQualifierWithPredicate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAssetVariantQualifierWithVariant_X = "assetVariantQualifierWithVariant:";
		static readonly NativeHandle selAssetVariantQualifierWithVariant_XHandle = Selector.GetHandle ("assetVariantQualifierWithVariant:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForAudioSampleRate_MediaSelectionOption_OperatorType_X = "predicateForAudioSampleRate:mediaSelectionOption:operatorType:";
		static readonly NativeHandle selPredicateForAudioSampleRate_MediaSelectionOption_OperatorType_XHandle = Selector.GetHandle ("predicateForAudioSampleRate:mediaSelectionOption:operatorType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForAudioSampleRate_OperatorType_X = "predicateForAudioSampleRate:operatorType:";
		static readonly NativeHandle selPredicateForAudioSampleRate_OperatorType_XHandle = Selector.GetHandle ("predicateForAudioSampleRate:operatorType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForBinauralAudio_X = "predicateForBinauralAudio:";
		static readonly NativeHandle selPredicateForBinauralAudio_XHandle = Selector.GetHandle ("predicateForBinauralAudio:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForBinauralAudio_MediaSelectionOption_X = "predicateForBinauralAudio:mediaSelectionOption:";
		static readonly NativeHandle selPredicateForBinauralAudio_MediaSelectionOption_XHandle = Selector.GetHandle ("predicateForBinauralAudio:mediaSelectionOption:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForChannelCount_MediaSelectionOption_OperatorType_X = "predicateForChannelCount:mediaSelectionOption:operatorType:";
		static readonly NativeHandle selPredicateForChannelCount_MediaSelectionOption_OperatorType_XHandle = Selector.GetHandle ("predicateForChannelCount:mediaSelectionOption:operatorType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForChannelCount_OperatorType_X = "predicateForChannelCount:operatorType:";
		static readonly NativeHandle selPredicateForChannelCount_OperatorType_XHandle = Selector.GetHandle ("predicateForChannelCount:operatorType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForDownmixAudio_X = "predicateForDownmixAudio:";
		static readonly NativeHandle selPredicateForDownmixAudio_XHandle = Selector.GetHandle ("predicateForDownmixAudio:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForDownmixAudio_MediaSelectionOption_X = "predicateForDownmixAudio:mediaSelectionOption:";
		static readonly NativeHandle selPredicateForDownmixAudio_MediaSelectionOption_XHandle = Selector.GetHandle ("predicateForDownmixAudio:mediaSelectionOption:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForImmersiveAudio_X = "predicateForImmersiveAudio:";
		static readonly NativeHandle selPredicateForImmersiveAudio_XHandle = Selector.GetHandle ("predicateForImmersiveAudio:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForImmersiveAudio_MediaSelectionOption_X = "predicateForImmersiveAudio:mediaSelectionOption:";
		static readonly NativeHandle selPredicateForImmersiveAudio_MediaSelectionOption_XHandle = Selector.GetHandle ("predicateForImmersiveAudio:mediaSelectionOption:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForPresentationHeight_OperatorType_X = "predicateForPresentationHeight:operatorType:";
		static readonly NativeHandle selPredicateForPresentationHeight_OperatorType_XHandle = Selector.GetHandle ("predicateForPresentationHeight:operatorType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateForPresentationWidth_OperatorType_X = "predicateForPresentationWidth:operatorType:";
		static readonly NativeHandle selPredicateForPresentationWidth_OperatorType_XHandle = Selector.GetHandle ("predicateForPresentationWidth:operatorType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVAssetVariantQualifier");
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
		protected AVAssetVariantQualifier (NSObjectFlag t) : base (t)
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
		protected internal AVAssetVariantQualifier (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("assetVariantQualifierWithPredicate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVAssetVariantQualifier Create (NSPredicate predicate)
		{
			var predicate__handle__ = predicate!.GetNonNullHandle (nameof (predicate));
			AVAssetVariantQualifier? ret;
			ret =  Runtime.GetNSObject<AVAssetVariantQualifier> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selAssetVariantQualifierWithPredicate_XHandle, predicate__handle__), false)!;
			GC.KeepAlive (predicate);
			return ret!;
		}
		[Export ("assetVariantQualifierWithVariant:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AVAssetVariantQualifier Create (AVAssetVariant variant)
		{
			var variant__handle__ = variant!.GetNonNullHandle (nameof (variant));
			AVAssetVariantQualifier? ret;
			ret =  Runtime.GetNSObject<AVAssetVariantQualifier> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selAssetVariantQualifierWithVariant_XHandle, variant__handle__), false)!;
			GC.KeepAlive (variant);
			return ret!;
		}
		[Export ("predicateForChannelCount:mediaSelectionOption:operatorType:")]
		[Obsolete ("Use 'GetPredicateForChannelCount' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicate (nint channelCount, AVMediaSelectionOption? mediaSelectionOption, NSPredicateOperatorType operatorType)
		{
			var mediaSelectionOption__handle__ = mediaSelectionOption.GetHandle ();
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle_UIntPtr (class_ptr, selPredicateForChannelCount_MediaSelectionOption_OperatorType_XHandle, channelCount, mediaSelectionOption__handle__, (UIntPtr) (ulong) operatorType), false)!;
			GC.KeepAlive (mediaSelectionOption);
			return ret!;
		}
		[Export ("predicateForAudioSampleRate:mediaSelectionOption:operatorType:")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForAudioSampleRate (double sampleRate, AVMediaSelectionOption? mediaSelectionOption, NSPredicateOperatorType operatorType)
		{
			var mediaSelectionOption__handle__ = mediaSelectionOption.GetHandle ();
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double_NativeHandle_UIntPtr (class_ptr, selPredicateForAudioSampleRate_MediaSelectionOption_OperatorType_XHandle, sampleRate, mediaSelectionOption__handle__, (UIntPtr) (ulong) operatorType), false)!;
			GC.KeepAlive (mediaSelectionOption);
			return ret!;
		}
		[Export ("predicateForAudioSampleRate:operatorType:")]
		[SupportedOSPlatform ("maccatalyst18.5")]
		[SupportedOSPlatform ("tvos18.5")]
		[SupportedOSPlatform ("macos15.5")]
		[SupportedOSPlatform ("ios18.5")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForAudioSampleRate (double sampleRate, NSPredicateOperatorType operatorType)
		{
			NSPredicate ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double_UIntPtr (class_ptr, selPredicateForAudioSampleRate_OperatorType_XHandle, sampleRate, (UIntPtr) (ulong) operatorType), false)!;
			return ret;
		}
		[Export ("predicateForBinauralAudio:mediaSelectionOption:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForBinauralAudio (bool isBinauralAudio, AVMediaSelectionOption? mediaSelectionOption)
		{
			var mediaSelectionOption__handle__ = mediaSelectionOption.GetHandle ();
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool_NativeHandle (class_ptr, selPredicateForBinauralAudio_MediaSelectionOption_XHandle, isBinauralAudio ? (byte) 1 : (byte) 0, mediaSelectionOption__handle__), false)!;
			GC.KeepAlive (mediaSelectionOption);
			return ret!;
		}
		[Export ("predicateForBinauralAudio:")]
		[SupportedOSPlatform ("maccatalyst18.5")]
		[SupportedOSPlatform ("tvos18.5")]
		[SupportedOSPlatform ("macos15.5")]
		[SupportedOSPlatform ("ios18.5")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForBinauralAudio (bool isBinauralAudio)
		{
			NSPredicate ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool (class_ptr, selPredicateForBinauralAudio_XHandle, isBinauralAudio ? (byte) 1 : (byte) 0), false)!;
			return ret;
		}
		[Export ("predicateForChannelCount:mediaSelectionOption:operatorType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForChannelCount (nint channelCount, AVMediaSelectionOption? mediaSelectionOption, NSPredicateOperatorType operatorType)
		{
			var mediaSelectionOption__handle__ = mediaSelectionOption.GetHandle ();
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle_UIntPtr (class_ptr, selPredicateForChannelCount_MediaSelectionOption_OperatorType_XHandle, channelCount, mediaSelectionOption__handle__, (UIntPtr) (ulong) operatorType), false)!;
			GC.KeepAlive (mediaSelectionOption);
			return ret!;
		}
		[Export ("predicateForChannelCount:operatorType:")]
		[SupportedOSPlatform ("maccatalyst18.5")]
		[SupportedOSPlatform ("tvos18.5")]
		[SupportedOSPlatform ("macos15.5")]
		[SupportedOSPlatform ("ios18.5")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForChannelCount (nint channelCount, NSPredicateOperatorType operatorType)
		{
			NSPredicate ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_UIntPtr (class_ptr, selPredicateForChannelCount_OperatorType_XHandle, channelCount, (UIntPtr) (ulong) operatorType), false)!;
			return ret;
		}
		[Export ("predicateForDownmixAudio:mediaSelectionOption:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForDownmixAudio (bool isDownmixAudio, AVMediaSelectionOption? mediaSelectionOption)
		{
			var mediaSelectionOption__handle__ = mediaSelectionOption.GetHandle ();
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool_NativeHandle (class_ptr, selPredicateForDownmixAudio_MediaSelectionOption_XHandle, isDownmixAudio ? (byte) 1 : (byte) 0, mediaSelectionOption__handle__), false)!;
			GC.KeepAlive (mediaSelectionOption);
			return ret!;
		}
		[Export ("predicateForDownmixAudio:")]
		[SupportedOSPlatform ("maccatalyst18.5")]
		[SupportedOSPlatform ("tvos18.5")]
		[SupportedOSPlatform ("macos15.5")]
		[SupportedOSPlatform ("ios18.5")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForDownmixAudio (bool isDownmixAudio)
		{
			NSPredicate ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool (class_ptr, selPredicateForDownmixAudio_XHandle, isDownmixAudio ? (byte) 1 : (byte) 0), false)!;
			return ret;
		}
		[Export ("predicateForImmersiveAudio:mediaSelectionOption:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForImmersiveAudio (bool isImmersiveAudio, AVMediaSelectionOption? mediaSelectionOption)
		{
			var mediaSelectionOption__handle__ = mediaSelectionOption.GetHandle ();
			NSPredicate? ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool_NativeHandle (class_ptr, selPredicateForImmersiveAudio_MediaSelectionOption_XHandle, isImmersiveAudio ? (byte) 1 : (byte) 0, mediaSelectionOption__handle__), false)!;
			GC.KeepAlive (mediaSelectionOption);
			return ret!;
		}
		[Export ("predicateForImmersiveAudio:")]
		[SupportedOSPlatform ("maccatalyst18.5")]
		[SupportedOSPlatform ("tvos18.5")]
		[SupportedOSPlatform ("macos15.5")]
		[SupportedOSPlatform ("ios18.5")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicate GetPredicateForImmersiveAudio (bool isImmersiveAudio)
		{
			NSPredicate ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool (class_ptr, selPredicateForImmersiveAudio_XHandle, isImmersiveAudio ? (byte) 1 : (byte) 0), false)!;
			return ret;
		}
		[Export ("predicateForPresentationHeight:operatorType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSPredicate GetPredicateForPresentationHeight (nfloat height, NSPredicateOperatorType operatorType)
		{
			NSPredicate ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_UIntPtr (class_ptr, selPredicateForPresentationHeight_OperatorType_XHandle, height, (UIntPtr) (ulong) operatorType), false)!;
			return ret;
		}
		[Export ("predicateForPresentationWidth:operatorType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSPredicate GetPredicateForPresentationWidth (nfloat width, NSPredicateOperatorType operatorType)
		{
			NSPredicate ret;
			ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_UIntPtr (class_ptr, selPredicateForPresentationWidth_OperatorType_XHandle, width, (UIntPtr) (ulong) operatorType), false)!;
			return ret;
		}
	} /* class AVAssetVariantQualifier */
}
