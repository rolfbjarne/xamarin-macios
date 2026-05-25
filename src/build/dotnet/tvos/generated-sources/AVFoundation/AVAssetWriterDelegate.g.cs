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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AVFoundation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>AVAssetWriterDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "AVAssetWriterDelegate", WrapperType = typeof (AVAssetWriterDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidOutputSegmentData", Selector = "assetWriter:didOutputSegmentData:segmentType:segmentReport:", ParameterType = new Type [] { typeof (AVAssetWriter), typeof (NSData), typeof (AVAssetSegmentType), typeof (AVAssetSegmentReport) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidOutputSegmentData", Selector = "assetWriter:didOutputSegmentData:segmentType:", ParameterType = new Type [] { typeof (AVAssetWriter), typeof (NSData), typeof (AVAssetSegmentType) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IAVAssetWriterDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("assetWriter:didOutputSegmentData:segmentType:segmentReport:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOutputSegmentData (AVAssetWriter writer, NSData segmentData, AVAssetSegmentType segmentType, AVAssetSegmentReport? segmentReport)
		{
			_DidOutputSegmentData (this, writer, segmentData, segmentType, segmentReport);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidOutputSegmentData (IAVAssetWriterDelegate This, AVAssetWriter writer, NSData segmentData, AVAssetSegmentType segmentType, AVAssetSegmentReport? segmentReport)
		{
			var writer__handle__ = writer!.GetNonNullHandle (nameof (writer));
			var segmentData__handle__ = segmentData!.GetNonNullHandle (nameof (segmentData));
			var segmentReport__handle__ = segmentReport.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("assetWriter:didOutputSegmentData:segmentType:segmentReport:"), writer__handle__, segmentData__handle__, (IntPtr) (long) segmentType, segmentReport__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (writer);
			GC.KeepAlive (segmentData);
			GC.KeepAlive (segmentReport);
		}
		[global::Foundation.OptionalMember]
		[Export ("assetWriter:didOutputSegmentData:segmentType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOutputSegmentData (AVAssetWriter writer, NSData segmentData, AVAssetSegmentType segmentType)
		{
			_DidOutputSegmentData (this, writer, segmentData, segmentType);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidOutputSegmentData (IAVAssetWriterDelegate This, AVAssetWriter writer, NSData segmentData, AVAssetSegmentType segmentType)
		{
			var writer__handle__ = writer!.GetNonNullHandle (nameof (writer));
			var segmentData__handle__ = segmentData!.GetNonNullHandle (nameof (segmentData));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("assetWriter:didOutputSegmentData:segmentType:"), writer__handle__, segmentData__handle__, (IntPtr) (long) segmentType);
			GC.KeepAlive (This);
			GC.KeepAlive (writer);
			GC.KeepAlive (segmentData);
		}
		[DynamicDependencyAttribute ("DidOutputSegmentData(AVFoundation.AVAssetWriter,Foundation.NSData,AVFoundation.AVAssetSegmentType,AVFoundation.AVAssetSegmentReport)")]
		[DynamicDependencyAttribute ("DidOutputSegmentData(AVFoundation.AVAssetWriter,Foundation.NSData,AVFoundation.AVAssetSegmentType)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVAssetWriterDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAVAssetWriterDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAVAssetWriterDelegate" /> interface to support all the methods from the AVAssetWriterDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAVAssetWriterDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AVAssetWriterDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AVAssetWriterDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidOutputSegmentData (this IAVAssetWriterDelegate This, AVAssetWriter writer, NSData segmentData, AVAssetSegmentType segmentType, AVAssetSegmentReport? segmentReport)
		{
			var writer__handle__ = writer!.GetNonNullHandle (nameof (writer));
			var segmentData__handle__ = segmentData!.GetNonNullHandle (nameof (segmentData));
			var segmentReport__handle__ = segmentReport.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("assetWriter:didOutputSegmentData:segmentType:segmentReport:"), writer__handle__, segmentData__handle__, (IntPtr) (long) segmentType, segmentReport__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (writer);
			GC.KeepAlive (segmentData);
			GC.KeepAlive (segmentReport);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidOutputSegmentData (this IAVAssetWriterDelegate This, AVAssetWriter writer, NSData segmentData, AVAssetSegmentType segmentType)
		{
			var writer__handle__ = writer!.GetNonNullHandle (nameof (writer));
			var segmentData__handle__ = segmentData!.GetNonNullHandle (nameof (segmentData));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (This.Handle, Selector.GetHandle ("assetWriter:didOutputSegmentData:segmentType:"), writer__handle__, segmentData__handle__, (IntPtr) (long) segmentType);
			GC.KeepAlive (This);
			GC.KeepAlive (writer);
			GC.KeepAlive (segmentData);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AVAssetWriterDelegateWrapper : BaseWrapper, IAVAssetWriterDelegate {
		public AVAssetWriterDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AVAssetWriterDelegateWrapper))]
		static AVAssetWriterDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AVFoundation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IAVAssetWriterDelegate" /> (for the protocol <c>AVAssetWriterDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IAVAssetWriterDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__AVFoundation_AVAssetWriterDelegate", false)]
	[Model]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class AVAssetWriterDelegate : NSObject, IAVAssetWriterDelegate {
		/// <summary>Creates a new <see cref="AVAssetWriterDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVAssetWriterDelegate () : base (NSObjectFlag.Empty)
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
		protected AVAssetWriterDelegate (NSObjectFlag t) : base (t)
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
		protected internal AVAssetWriterDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("assetWriter:didOutputSegmentData:segmentType:segmentReport:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOutputSegmentData (AVAssetWriter writer, NSData segmentData, AVAssetSegmentType segmentType, AVAssetSegmentReport? segmentReport)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("assetWriter:didOutputSegmentData:segmentType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidOutputSegmentData (AVAssetWriter writer, NSData segmentData, AVAssetSegmentType segmentType)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AVAssetWriterDelegate */
}
