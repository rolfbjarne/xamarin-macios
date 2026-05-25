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
namespace BackgroundAssets {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>BAManagedAssetPackDownloadDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	[Protocol (Name = "BAManagedAssetPackDownloadDelegate", WrapperType = typeof (BAManagedAssetPackDownloadDelegateWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DownloadBegan", Selector = "downloadOfAssetPackBegan:", ParameterType = new Type [] { typeof (BackgroundAssets.BAAssetPack) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DownloadProgress", Selector = "downloadOfAssetPack:hasProgress:", ParameterType = new Type [] { typeof (BackgroundAssets.BAAssetPack), typeof (NSProgress) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DownloadPaused", Selector = "downloadOfAssetPackPaused:", ParameterType = new Type [] { typeof (BackgroundAssets.BAAssetPack) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DownloadFinished", Selector = "downloadOfAssetPackFinished:", ParameterType = new Type [] { typeof (BackgroundAssets.BAAssetPack) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DownloadFailed", Selector = "downloadOfAssetPack:failedWithError:", ParameterType = new Type [] { typeof (BackgroundAssets.BAAssetPack), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IBAManagedAssetPackDownloadDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("downloadOfAssetPackBegan:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DownloadBegan (BAAssetPack assetPack)
		{
			_DownloadBegan (this, assetPack);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DownloadBegan (IBAManagedAssetPackDownloadDelegate This, BAAssetPack assetPack)
		{
			var assetPack__handle__ = assetPack!.GetNonNullHandle (nameof (assetPack));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("downloadOfAssetPackBegan:"), assetPack__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (assetPack);
		}
		[global::Foundation.OptionalMember]
		[Export ("downloadOfAssetPack:hasProgress:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DownloadProgress (BAAssetPack assetPack, NSProgress progress)
		{
			_DownloadProgress (this, assetPack, progress);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DownloadProgress (IBAManagedAssetPackDownloadDelegate This, BAAssetPack assetPack, NSProgress progress)
		{
			var assetPack__handle__ = assetPack!.GetNonNullHandle (nameof (assetPack));
			var progress__handle__ = progress!.GetNonNullHandle (nameof (progress));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("downloadOfAssetPack:hasProgress:"), assetPack__handle__, progress__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (assetPack);
			GC.KeepAlive (progress);
		}
		[global::Foundation.OptionalMember]
		[Export ("downloadOfAssetPackPaused:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DownloadPaused (BAAssetPack assetPack)
		{
			_DownloadPaused (this, assetPack);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DownloadPaused (IBAManagedAssetPackDownloadDelegate This, BAAssetPack assetPack)
		{
			var assetPack__handle__ = assetPack!.GetNonNullHandle (nameof (assetPack));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("downloadOfAssetPackPaused:"), assetPack__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (assetPack);
		}
		[global::Foundation.OptionalMember]
		[Export ("downloadOfAssetPackFinished:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DownloadFinished (BAAssetPack assetPack)
		{
			_DownloadFinished (this, assetPack);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DownloadFinished (IBAManagedAssetPackDownloadDelegate This, BAAssetPack assetPack)
		{
			var assetPack__handle__ = assetPack!.GetNonNullHandle (nameof (assetPack));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("downloadOfAssetPackFinished:"), assetPack__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (assetPack);
		}
		[global::Foundation.OptionalMember]
		[Export ("downloadOfAssetPack:failedWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DownloadFailed (BAAssetPack assetPack, NSError error)
		{
			_DownloadFailed (this, assetPack, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DownloadFailed (IBAManagedAssetPackDownloadDelegate This, BAAssetPack assetPack, NSError error)
		{
			var assetPack__handle__ = assetPack!.GetNonNullHandle (nameof (assetPack));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("downloadOfAssetPack:failedWithError:"), assetPack__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (assetPack);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("DownloadBegan(BackgroundAssets.BAAssetPack)")]
		[DynamicDependencyAttribute ("DownloadFailed(BackgroundAssets.BAAssetPack,Foundation.NSError)")]
		[DynamicDependencyAttribute ("DownloadFinished(BackgroundAssets.BAAssetPack)")]
		[DynamicDependencyAttribute ("DownloadPaused(BackgroundAssets.BAAssetPack)")]
		[DynamicDependencyAttribute ("DownloadProgress(BackgroundAssets.BAAssetPack,Foundation.NSProgress)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (BAManagedAssetPackDownloadDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IBAManagedAssetPackDownloadDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class BAManagedAssetPackDownloadDelegateWrapper : BaseWrapper, IBAManagedAssetPackDownloadDelegate {
		public BAManagedAssetPackDownloadDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (BAManagedAssetPackDownloadDelegateWrapper))]
		static BAManagedAssetPackDownloadDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace BackgroundAssets {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IBAManagedAssetPackDownloadDelegate" /> (for the protocol <c>BAManagedAssetPackDownloadDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IBAManagedAssetPackDownloadDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__BackgroundAssets_BAManagedAssetPackDownloadDelegate", false)]
	[Model]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[SupportedOSPlatform ("macos26.0")]
	public unsafe partial class BAManagedAssetPackDownloadDelegate : NSObject, IBAManagedAssetPackDownloadDelegate {
		/// <summary>Creates a new <see cref="BAManagedAssetPackDownloadDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public BAManagedAssetPackDownloadDelegate () : base (NSObjectFlag.Empty)
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
		protected BAManagedAssetPackDownloadDelegate (NSObjectFlag t) : base (t)
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
		protected internal BAManagedAssetPackDownloadDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("downloadOfAssetPackBegan:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DownloadBegan (BAAssetPack assetPack)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("downloadOfAssetPack:failedWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DownloadFailed (BAAssetPack assetPack, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("downloadOfAssetPackFinished:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DownloadFinished (BAAssetPack assetPack)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("downloadOfAssetPackPaused:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DownloadPaused (BAAssetPack assetPack)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("downloadOfAssetPack:hasProgress:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DownloadProgress (BAAssetPack assetPack, NSProgress progress)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class BAManagedAssetPackDownloadDelegate */
}
