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
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AVFoundation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>AVVideoCompositionValidationHandling</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "AVVideoCompositionValidationHandling", WrapperType = typeof (AVVideoCompositionValidationHandlingWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldContinueValidatingAfterFindingInvalidValueForKey", Selector = "videoComposition:shouldContinueValidatingAfterFindingInvalidValueForKey:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (AVVideoComposition), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldContinueValidatingAfterFindingEmptyTimeRange", Selector = "videoComposition:shouldContinueValidatingAfterFindingEmptyTimeRange:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (AVVideoComposition), typeof (CMTimeRange) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldContinueValidatingAfterFindingInvalidTimeRangeInInstruction", Selector = "videoComposition:shouldContinueValidatingAfterFindingInvalidTimeRangeInInstruction:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (AVVideoComposition), typeof (AVVideoCompositionInstruction) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldContinueValidatingAfterFindingInvalidTrackIDInInstruction", Selector = "videoComposition:shouldContinueValidatingAfterFindingInvalidTrackIDInInstruction:layerInstruction:asset:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (AVVideoComposition), typeof (AVVideoCompositionInstruction), typeof (AVVideoCompositionLayerInstruction), typeof (AVAsset) }, ParameterByRef = new bool [] { false, false, false, false })]
	public partial interface IAVVideoCompositionValidationHandling : INativeObject, IDisposable
	{
		/// <param name="videoComposition">To be added.</param><param name="key">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("videoComposition:shouldContinueValidatingAfterFindingInvalidValueForKey:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldContinueValidatingAfterFindingInvalidValueForKey (AVVideoComposition videoComposition, string key)
		{
			return _ShouldContinueValidatingAfterFindingInvalidValueForKey (this, videoComposition, key);
		}
		/// <param name="videoComposition">To be added.</param><param name="key">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldContinueValidatingAfterFindingInvalidValueForKey (IAVVideoCompositionValidationHandling This, AVVideoComposition videoComposition, string key)
		{
			var videoComposition__handle__ = videoComposition!.GetNonNullHandle (nameof (videoComposition));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("videoComposition:shouldContinueValidatingAfterFindingInvalidValueForKey:"), videoComposition__handle__, nskey);
			GC.KeepAlive (This);
			GC.KeepAlive (videoComposition);
			CFString.ReleaseNative (nskey);
			return ret != 0;
		}
		/// <param name="videoComposition">To be added.</param><param name="timeRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("videoComposition:shouldContinueValidatingAfterFindingEmptyTimeRange:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldContinueValidatingAfterFindingEmptyTimeRange (AVVideoComposition videoComposition, global::CoreMedia.CMTimeRange timeRange)
		{
			return _ShouldContinueValidatingAfterFindingEmptyTimeRange (this, videoComposition, timeRange);
		}
		/// <param name="videoComposition">To be added.</param><param name="timeRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldContinueValidatingAfterFindingEmptyTimeRange (IAVVideoCompositionValidationHandling This, AVVideoComposition videoComposition, global::CoreMedia.CMTimeRange timeRange)
		{
			var videoComposition__handle__ = videoComposition!.GetNonNullHandle (nameof (videoComposition));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_CMTimeRange (This.Handle, Selector.GetHandle ("videoComposition:shouldContinueValidatingAfterFindingEmptyTimeRange:"), videoComposition__handle__, timeRange);
			GC.KeepAlive (This);
			GC.KeepAlive (videoComposition);
			return ret != 0;
		}
		/// <param name="videoComposition">To be added.</param><param name="videoCompositionInstruction">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("videoComposition:shouldContinueValidatingAfterFindingInvalidTimeRangeInInstruction:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldContinueValidatingAfterFindingInvalidTimeRangeInInstruction (AVVideoComposition videoComposition, AVVideoCompositionInstruction videoCompositionInstruction)
		{
			return _ShouldContinueValidatingAfterFindingInvalidTimeRangeInInstruction (this, videoComposition, videoCompositionInstruction);
		}
		/// <param name="videoComposition">To be added.</param><param name="videoCompositionInstruction">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldContinueValidatingAfterFindingInvalidTimeRangeInInstruction (IAVVideoCompositionValidationHandling This, AVVideoComposition videoComposition, AVVideoCompositionInstruction videoCompositionInstruction)
		{
			var videoComposition__handle__ = videoComposition!.GetNonNullHandle (nameof (videoComposition));
			var videoCompositionInstruction__handle__ = videoCompositionInstruction!.GetNonNullHandle (nameof (videoCompositionInstruction));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("videoComposition:shouldContinueValidatingAfterFindingInvalidTimeRangeInInstruction:"), videoComposition__handle__, videoCompositionInstruction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (videoComposition);
			GC.KeepAlive (videoCompositionInstruction);
			return ret != 0;
		}
		/// <param name="videoComposition">To be added.</param><param name="videoCompositionInstruction">To be added.</param><param name="layerInstruction">To be added.</param><param name="asset">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("videoComposition:shouldContinueValidatingAfterFindingInvalidTrackIDInInstruction:layerInstruction:asset:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldContinueValidatingAfterFindingInvalidTrackIDInInstruction (AVVideoComposition videoComposition, AVVideoCompositionInstruction videoCompositionInstruction, AVVideoCompositionLayerInstruction layerInstruction, AVAsset asset)
		{
			return _ShouldContinueValidatingAfterFindingInvalidTrackIDInInstruction (this, videoComposition, videoCompositionInstruction, layerInstruction, asset);
		}
		/// <param name="videoComposition">To be added.</param><param name="videoCompositionInstruction">To be added.</param><param name="layerInstruction">To be added.</param><param name="asset">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldContinueValidatingAfterFindingInvalidTrackIDInInstruction (IAVVideoCompositionValidationHandling This, AVVideoComposition videoComposition, AVVideoCompositionInstruction videoCompositionInstruction, AVVideoCompositionLayerInstruction layerInstruction, AVAsset asset)
		{
			var videoComposition__handle__ = videoComposition!.GetNonNullHandle (nameof (videoComposition));
			var videoCompositionInstruction__handle__ = videoCompositionInstruction!.GetNonNullHandle (nameof (videoCompositionInstruction));
			var layerInstruction__handle__ = layerInstruction!.GetNonNullHandle (nameof (layerInstruction));
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("videoComposition:shouldContinueValidatingAfterFindingInvalidTrackIDInInstruction:layerInstruction:asset:"), videoComposition__handle__, videoCompositionInstruction__handle__, layerInstruction__handle__, asset__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (videoComposition);
			GC.KeepAlive (videoCompositionInstruction);
			GC.KeepAlive (layerInstruction);
			GC.KeepAlive (asset);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("ShouldContinueValidatingAfterFindingEmptyTimeRange(AVFoundation.AVVideoComposition,CoreMedia.CMTimeRange)")]
		[DynamicDependencyAttribute ("ShouldContinueValidatingAfterFindingInvalidTimeRangeInInstruction(AVFoundation.AVVideoComposition,AVFoundation.AVVideoCompositionInstruction)")]
		[DynamicDependencyAttribute ("ShouldContinueValidatingAfterFindingInvalidTrackIDInInstruction(AVFoundation.AVVideoComposition,AVFoundation.AVVideoCompositionInstruction,AVFoundation.AVVideoCompositionLayerInstruction,AVFoundation.AVAsset)")]
		[DynamicDependencyAttribute ("ShouldContinueValidatingAfterFindingInvalidValueForKey(AVFoundation.AVVideoComposition,System.String)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVVideoCompositionValidationHandlingWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVVideoCompositionValidationHandling ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAVVideoCompositionValidationHandling" /> interface to support all the methods from the AVVideoCompositionValidationHandling protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAVVideoCompositionValidationHandling" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AVVideoCompositionValidationHandling protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AVVideoCompositionValidationHandling_Extensions {
		/// <param name="videoComposition">To be added.</param><param name="key">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldContinueValidatingAfterFindingInvalidValueForKey (this IAVVideoCompositionValidationHandling This, AVVideoComposition videoComposition, string key)
		{
			var videoComposition__handle__ = videoComposition!.GetNonNullHandle (nameof (videoComposition));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("videoComposition:shouldContinueValidatingAfterFindingInvalidValueForKey:"), videoComposition__handle__, nskey);
			GC.KeepAlive (This);
			GC.KeepAlive (videoComposition);
			CFString.ReleaseNative (nskey);
			return ret != 0;
		}
		/// <param name="videoComposition">To be added.</param><param name="timeRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldContinueValidatingAfterFindingEmptyTimeRange (this IAVVideoCompositionValidationHandling This, AVVideoComposition videoComposition, global::CoreMedia.CMTimeRange timeRange)
		{
			var videoComposition__handle__ = videoComposition!.GetNonNullHandle (nameof (videoComposition));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_CMTimeRange (This.Handle, Selector.GetHandle ("videoComposition:shouldContinueValidatingAfterFindingEmptyTimeRange:"), videoComposition__handle__, timeRange);
			GC.KeepAlive (This);
			GC.KeepAlive (videoComposition);
			return ret != 0;
		}
		/// <param name="videoComposition">To be added.</param><param name="videoCompositionInstruction">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldContinueValidatingAfterFindingInvalidTimeRangeInInstruction (this IAVVideoCompositionValidationHandling This, AVVideoComposition videoComposition, AVVideoCompositionInstruction videoCompositionInstruction)
		{
			var videoComposition__handle__ = videoComposition!.GetNonNullHandle (nameof (videoComposition));
			var videoCompositionInstruction__handle__ = videoCompositionInstruction!.GetNonNullHandle (nameof (videoCompositionInstruction));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("videoComposition:shouldContinueValidatingAfterFindingInvalidTimeRangeInInstruction:"), videoComposition__handle__, videoCompositionInstruction__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (videoComposition);
			GC.KeepAlive (videoCompositionInstruction);
			return ret != 0;
		}
		/// <param name="videoComposition">To be added.</param><param name="videoCompositionInstruction">To be added.</param><param name="layerInstruction">To be added.</param><param name="asset">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldContinueValidatingAfterFindingInvalidTrackIDInInstruction (this IAVVideoCompositionValidationHandling This, AVVideoComposition videoComposition, AVVideoCompositionInstruction videoCompositionInstruction, AVVideoCompositionLayerInstruction layerInstruction, AVAsset asset)
		{
			var videoComposition__handle__ = videoComposition!.GetNonNullHandle (nameof (videoComposition));
			var videoCompositionInstruction__handle__ = videoCompositionInstruction!.GetNonNullHandle (nameof (videoCompositionInstruction));
			var layerInstruction__handle__ = layerInstruction!.GetNonNullHandle (nameof (layerInstruction));
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("videoComposition:shouldContinueValidatingAfterFindingInvalidTrackIDInInstruction:layerInstruction:asset:"), videoComposition__handle__, videoCompositionInstruction__handle__, layerInstruction__handle__, asset__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (videoComposition);
			GC.KeepAlive (videoCompositionInstruction);
			GC.KeepAlive (layerInstruction);
			GC.KeepAlive (asset);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVVideoCompositionValidationHandlingWrapper : BaseWrapper, IAVVideoCompositionValidationHandling {
		public AVVideoCompositionValidationHandlingWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVVideoCompositionValidationHandlingWrapper))]
		static AVVideoCompositionValidationHandlingWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AVFoundation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IAVVideoCompositionValidationHandling" /> (for the protocol <c>AVVideoCompositionValidationHandling</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IAVVideoCompositionValidationHandling" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__AVFoundation_AVVideoCompositionValidationHandling", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVVideoCompositionValidationHandling : NSObject, IAVVideoCompositionValidationHandling {
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
		protected AVVideoCompositionValidationHandling (NSObjectFlag t) : base (t)
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
		protected internal AVVideoCompositionValidationHandling (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="videoComposition">To be added.</param><param name="timeRange">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("videoComposition:shouldContinueValidatingAfterFindingEmptyTimeRange:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldContinueValidatingAfterFindingEmptyTimeRange (AVVideoComposition videoComposition, global::CoreMedia.CMTimeRange timeRange)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="videoComposition">To be added.</param><param name="videoCompositionInstruction">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("videoComposition:shouldContinueValidatingAfterFindingInvalidTimeRangeInInstruction:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldContinueValidatingAfterFindingInvalidTimeRangeInInstruction (AVVideoComposition videoComposition, AVVideoCompositionInstruction videoCompositionInstruction)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="videoComposition">To be added.</param><param name="videoCompositionInstruction">To be added.</param><param name="layerInstruction">To be added.</param><param name="asset">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("videoComposition:shouldContinueValidatingAfterFindingInvalidTrackIDInInstruction:layerInstruction:asset:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldContinueValidatingAfterFindingInvalidTrackIDInInstruction (AVVideoComposition videoComposition, AVVideoCompositionInstruction videoCompositionInstruction, AVVideoCompositionLayerInstruction layerInstruction, AVAsset asset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="videoComposition">To be added.</param><param name="key">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("videoComposition:shouldContinueValidatingAfterFindingInvalidValueForKey:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldContinueValidatingAfterFindingInvalidValueForKey (AVVideoComposition videoComposition, string key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVVideoCompositionValidationHandling */
}
