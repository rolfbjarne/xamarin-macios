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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace MediaPlayer {
	#pragma warning disable CS1573
	/// <summary>Delegate object providing methods for external media players to send playback commands to the app.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPPlayableContentDelegate_Ref/index.html">Apple documentation for <c>MPPlayableContentDelegate</c></related>
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "MPPlayableContentDelegate", WrapperType = typeof (MPPlayableContentDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InitiatePlaybackOfContentItem", Selector = "playableContentManager:initiatePlaybackOfContentItemAtIndexPath:completionHandler:", ParameterType = new Type [] { typeof (MPPlayableContentManager), typeof (NSIndexPath), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V20) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ContextUpdated", Selector = "playableContentManager:didUpdateContext:", ParameterType = new Type [] { typeof (MPPlayableContentManager), typeof (MPPlayableContentManagerContext) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InitializePlaybackQueue", Selector = "playableContentManager:initializePlaybackQueueWithCompletionHandler:", ParameterType = new Type [] { typeof (MPPlayableContentManager), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V20) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InitializePlaybackQueue", Selector = "playableContentManager:initializePlaybackQueueWithContentItems:completionHandler:", ParameterType = new Type [] { typeof (MPPlayableContentManager), typeof (MPContentItem[]), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V20) })]
	public partial interface IMPPlayableContentDelegate : INativeObject, IDisposable
	{
		/// <param name="contentManager">To be added.</param><param name="indexPath">To be added.</param><param name="completionHandler">To be added.</param><summary>Method that is called to request item playback.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("playableContentManager:initiatePlaybackOfContentItemAtIndexPath:completionHandler:")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'CarPlay' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'CarPlay' API instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void InitiatePlaybackOfContentItem (MPPlayableContentManager contentManager, NSIndexPath indexPath, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError> completionHandler)
		{
			_InitiatePlaybackOfContentItem (this, contentManager, indexPath, completionHandler);
		}
		/// <param name="contentManager">To be added.</param><param name="indexPath">To be added.</param><param name="completionHandler">To be added.</param><summary>Method that is called to request item playback.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios14.0", "Use 'CarPlay' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'CarPlay' API instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _InitiatePlaybackOfContentItem (IMPPlayableContentDelegate This, MPPlayableContentManager contentManager, NSIndexPath indexPath, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError> completionHandler)
		{
			var contentManager__handle__ = contentManager!.GetNonNullHandle (nameof (contentManager));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V20.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playableContentManager:initiatePlaybackOfContentItemAtIndexPath:completionHandler:"), contentManager__handle__, indexPath__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (contentManager);
			GC.KeepAlive (indexPath);
		}
		/// <param name="contentManager">To be added.</param><param name="context">To be added.</param><summary>Method that is called after the context changes.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("playableContentManager:didUpdateContext:")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'CarPlay' API instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'CarPlay' API instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContextUpdated (MPPlayableContentManager contentManager, MPPlayableContentManagerContext context)
		{
			_ContextUpdated (this, contentManager, context);
		}
		/// <param name="contentManager">To be added.</param><param name="context">To be added.</param><summary>Method that is called after the context changes.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios14.0", "Use 'CarPlay' API instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'CarPlay' API instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ContextUpdated (IMPPlayableContentDelegate This, MPPlayableContentManager contentManager, MPPlayableContentManagerContext context)
		{
			var contentManager__handle__ = contentManager!.GetNonNullHandle (nameof (contentManager));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playableContentManager:didUpdateContext:"), contentManager__handle__, context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (contentManager);
			GC.KeepAlive (context);
		}
		/// <param name="contentManager">To be added.</param><param name="completionHandler">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'InitializePlaybackQueue (MPPlayableContentManager, MPContentItem[], Action&lt;NSError&gt;)' instead.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("playableContentManager:initializePlaybackQueueWithCompletionHandler:")]
		[ObsoletedOSPlatform ("ios9.3", "Use 'InitializePlaybackQueue (MPPlayableContentManager, MPContentItem[], Action<NSError>)' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'InitializePlaybackQueue (MPPlayableContentManager, MPContentItem[], Action<NSError>)' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void InitializePlaybackQueue (MPPlayableContentManager contentManager, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError> completionHandler)
		{
			_InitializePlaybackQueue (this, contentManager, completionHandler);
		}
		/// <param name="contentManager">To be added.</param><param name="completionHandler">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'InitializePlaybackQueue (MPPlayableContentManager, MPContentItem[], Action&lt;NSError&gt;)' instead.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios9.3", "Use 'InitializePlaybackQueue (MPPlayableContentManager, MPContentItem[], Action<NSError>)' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'InitializePlaybackQueue (MPPlayableContentManager, MPContentItem[], Action<NSError>)' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _InitializePlaybackQueue (IMPPlayableContentDelegate This, MPPlayableContentManager contentManager, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError> completionHandler)
		{
			var contentManager__handle__ = contentManager!.GetNonNullHandle (nameof (contentManager));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V20.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playableContentManager:initializePlaybackQueueWithCompletionHandler:"), contentManager__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (contentManager);
		}
		/// <param name="contentManager">To be added.</param><param name="contentItems"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("playableContentManager:initializePlaybackQueueWithContentItems:completionHandler:")]
		[ObsoletedOSPlatform ("ios12.0", "Use the Intents framework API instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the Intents framework API instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void InitializePlaybackQueue (MPPlayableContentManager contentManager, MPContentItem[]? contentItems, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError> completionHandler)
		{
			_InitializePlaybackQueue (this, contentManager, contentItems, completionHandler);
		}
		/// <param name="contentManager">To be added.</param><param name="contentItems"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios12.0", "Use the Intents framework API instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the Intents framework API instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _InitializePlaybackQueue (IMPPlayableContentDelegate This, MPPlayableContentManager contentManager, MPContentItem[]? contentItems, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError> completionHandler)
		{
			var contentManager__handle__ = contentManager!.GetNonNullHandle (nameof (contentManager));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_contentItems = contentItems is null ? null : NSArray.FromNSObjects (contentItems);
			using var block_completionHandler = Trampolines.SDActionArity1V20.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playableContentManager:initializePlaybackQueueWithContentItems:completionHandler:"), contentManager__handle__, nsa_contentItems.GetHandle (), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (contentManager);
		}
		[DynamicDependencyAttribute ("ContextUpdated(MediaPlayer.MPPlayableContentManager,MediaPlayer.MPPlayableContentManagerContext)")]
		[DynamicDependencyAttribute ("InitializePlaybackQueue(MediaPlayer.MPPlayableContentManager,MediaPlayer.MPContentItem[],System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("InitializePlaybackQueue(MediaPlayer.MPPlayableContentManager,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("InitiatePlaybackOfContentItem(MediaPlayer.MPPlayableContentManager,Foundation.NSIndexPath,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPPlayableContentDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMPPlayableContentDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMPPlayableContentDelegate" /> interface to support all the methods from the MPPlayableContentDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMPPlayableContentDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MPPlayableContentDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MPPlayableContentDelegate_Extensions {
		/// <param name="contentManager">To be added.</param><param name="indexPath">To be added.</param><param name="completionHandler">To be added.</param><summary>Method that is called to request item playback.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios14.0", "Use 'CarPlay' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'CarPlay' API instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void InitiatePlaybackOfContentItem (this IMPPlayableContentDelegate This, MPPlayableContentManager contentManager, NSIndexPath indexPath, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError> completionHandler)
		{
			var contentManager__handle__ = contentManager!.GetNonNullHandle (nameof (contentManager));
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V20.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playableContentManager:initiatePlaybackOfContentItemAtIndexPath:completionHandler:"), contentManager__handle__, indexPath__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (contentManager);
			GC.KeepAlive (indexPath);
		}
		/// <param name="contentManager">To be added.</param><param name="context">To be added.</param><summary>Method that is called after the context changes.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios14.0", "Use 'CarPlay' API instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'CarPlay' API instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ContextUpdated (this IMPPlayableContentDelegate This, MPPlayableContentManager contentManager, MPPlayableContentManagerContext context)
		{
			var contentManager__handle__ = contentManager!.GetNonNullHandle (nameof (contentManager));
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playableContentManager:didUpdateContext:"), contentManager__handle__, context__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (contentManager);
			GC.KeepAlive (context);
		}
		/// <param name="contentManager">To be added.</param><param name="completionHandler">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'InitializePlaybackQueue (MPPlayableContentManager, MPContentItem[], Action&lt;NSError&gt;)' instead.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios9.3", "Use 'InitializePlaybackQueue (MPPlayableContentManager, MPContentItem[], Action<NSError>)' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'InitializePlaybackQueue (MPPlayableContentManager, MPContentItem[], Action<NSError>)' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void InitializePlaybackQueue (this IMPPlayableContentDelegate This, MPPlayableContentManager contentManager, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError> completionHandler)
		{
			var contentManager__handle__ = contentManager!.GetNonNullHandle (nameof (contentManager));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V20.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playableContentManager:initializePlaybackQueueWithCompletionHandler:"), contentManager__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (contentManager);
		}
		/// <param name="contentManager">To be added.</param><param name="contentItems"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios12.0", "Use the Intents framework API instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the Intents framework API instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void InitializePlaybackQueue (this IMPPlayableContentDelegate This, MPPlayableContentManager contentManager, MPContentItem[]? contentItems, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError> completionHandler)
		{
			var contentManager__handle__ = contentManager!.GetNonNullHandle (nameof (contentManager));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_contentItems = contentItems is null ? null : NSArray.FromNSObjects (contentItems);
			using var block_completionHandler = Trampolines.SDActionArity1V20.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("playableContentManager:initializePlaybackQueueWithContentItems:completionHandler:"), contentManager__handle__, nsa_contentItems.GetHandle (), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (contentManager);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MPPlayableContentDelegateWrapper : BaseWrapper, IMPPlayableContentDelegate {
		public MPPlayableContentDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPPlayableContentDelegateWrapper))]
		static MPPlayableContentDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace MediaPlayer {
	/// <summary>Delegate object providing methods for external media players to send playback commands to the app.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPPlayableContentDelegate_Ref/index.html">Apple documentation for <c>MPPlayableContentDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__MediaPlayer_MPPlayableContentDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class MPPlayableContentDelegate : NSObject, IMPPlayableContentDelegate {
		/// <summary>Creates a new <see cref="MPPlayableContentDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPPlayableContentDelegate () : base (NSObjectFlag.Empty)
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
		protected MPPlayableContentDelegate (NSObjectFlag t) : base (t)
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
		protected internal MPPlayableContentDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="contentManager">To be added.</param><param name="context">To be added.</param><summary>Method that is called after the context changes.</summary><remarks>To be added.</remarks>
		[Export ("playableContentManager:didUpdateContext:")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'CarPlay' API instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'CarPlay' API instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ContextUpdated (MPPlayableContentManager contentManager, MPPlayableContentManagerContext context)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="contentManager">To be added.</param><param name="completionHandler">To be added.</param><summary>Developers should not use this deprecated method. Developers should use 'InitializePlaybackQueue (MPPlayableContentManager, MPContentItem[], Action&lt;NSError&gt;)' instead.</summary><remarks>To be added.</remarks>
		[Export ("playableContentManager:initializePlaybackQueueWithCompletionHandler:")]
		[ObsoletedOSPlatform ("ios9.3", "Use 'InitializePlaybackQueue (MPPlayableContentManager, MPContentItem[], Action<NSError>)' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'InitializePlaybackQueue (MPPlayableContentManager, MPContentItem[], Action<NSError>)' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void InitializePlaybackQueue (MPPlayableContentManager contentManager, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="contentManager">To be added.</param><param name="contentItems"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("playableContentManager:initializePlaybackQueueWithContentItems:completionHandler:")]
		[ObsoletedOSPlatform ("ios12.0", "Use the Intents framework API instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the Intents framework API instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void InitializePlaybackQueue (MPPlayableContentManager contentManager, MPContentItem[]? contentItems, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="contentManager">To be added.</param><param name="indexPath">To be added.</param><param name="completionHandler">To be added.</param><summary>Method that is called to request item playback.</summary><remarks>To be added.</remarks>
		[Export ("playableContentManager:initiatePlaybackOfContentItemAtIndexPath:completionHandler:")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'CarPlay' API instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'CarPlay' API instead.")]
		[UnsupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void InitiatePlaybackOfContentItem (MPPlayableContentManager contentManager, NSIndexPath indexPath, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MPPlayableContentDelegate */
}
