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
	/// <summary>Provides media metadata information to external media players.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPPlayableContentDataSource_Ref/index.html">Apple documentation for <c>MPPlayableContentDataSource</c></related>
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "MPPlayableContentDataSource", WrapperType = typeof (MPPlayableContentDataSourceWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetContentItem", Selector = "contentItemAtIndexPath:", ReturnType = typeof (MPContentItem), ParameterType = new Type [] { typeof (NSIndexPath) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "BeginLoadingChildItems", Selector = "beginLoadingChildItemsAtIndexPath:completionHandler:", ParameterType = new Type [] { typeof (NSIndexPath), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V20) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ChildItemsDisplayPlaybackProgress", Selector = "childItemsDisplayPlaybackProgressAtIndexPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSIndexPath) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NumberOfChildItems", Selector = "numberOfChildItemsAtIndexPath:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (NSIndexPath) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetContentItem", Selector = "contentItemForIdentifier:completionHandler:", ParameterType = new Type [] { typeof (string), typeof (global::System.Action<global::MediaPlayer.MPContentItem, NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V121) })]
	public partial interface IMPPlayableContentDataSource : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("contentItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPContentItem? GetContentItem (NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MPContentItem? _GetContentItem (IMPPlayableContentDataSource This, NSIndexPath indexPath)
		{
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			MPContentItem? ret;
			ret =  Runtime.GetNSObject<MPContentItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("contentItemAtIndexPath:"), indexPath__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="indexPath">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("beginLoadingChildItemsAtIndexPath:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void BeginLoadingChildItems (NSIndexPath indexPath, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError> completionHandler)
		{
			_BeginLoadingChildItems (this, indexPath, completionHandler);
		}
		/// <param name="indexPath">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _BeginLoadingChildItems (IMPPlayableContentDataSource This, NSIndexPath indexPath, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError> completionHandler)
		{
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V20.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("beginLoadingChildItemsAtIndexPath:completionHandler:"), indexPath__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (indexPath);
		}
		/// <param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("childItemsDisplayPlaybackProgressAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ChildItemsDisplayPlaybackProgress (NSIndexPath indexPath)
		{
			return _ChildItemsDisplayPlaybackProgress (this, indexPath);
		}
		/// <param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ChildItemsDisplayPlaybackProgress (IMPPlayableContentDataSource This, NSIndexPath indexPath)
		{
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("childItemsDisplayPlaybackProgressAtIndexPath:"), indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("numberOfChildItemsAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfChildItems (NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _NumberOfChildItems (IMPPlayableContentDataSource This, NSIndexPath indexPath)
		{
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("numberOfChildItemsAtIndexPath:"), indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="identifier">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("contentItemForIdentifier:completionHandler:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'CarPlay' API instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'CarPlay' API instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetContentItem (string identifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V121))]global::System.Action<MPContentItem, NSError> completionHandler)
		{
			_GetContentItem (this, identifier, completionHandler);
		}
		/// <param name="identifier">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous GetContentItem operation.  The value of the TResult parameter is of type System.Action&lt;MediaPlayer.MPContentItem,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The GetContentItemAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'CarPlay' API instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'CarPlay' API instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<MPContentItem> GetContentItemAsync (string identifier)
		{
			var tcs = new TaskCompletionSource<MPContentItem> ();
			GetContentItem(identifier, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		/// <param name="identifier">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'CarPlay' API instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'CarPlay' API instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _GetContentItem (IMPPlayableContentDataSource This, string identifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V121))]global::System.Action<MPContentItem, NSError> completionHandler)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsidentifier = CFString.CreateNative (identifier);
			using var block_completionHandler = Trampolines.SDActionArity2V121.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentItemForIdentifier:completionHandler:"), nsidentifier, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsidentifier);
		}
		[DynamicDependencyAttribute ("BeginLoadingChildItems(Foundation.NSIndexPath,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("ChildItemsDisplayPlaybackProgress(Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("GetContentItem(Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute ("GetContentItem(System.String,System.Action{MediaPlayer.MPContentItem,Foundation.NSError})")]
		[DynamicDependencyAttribute ("NumberOfChildItems(Foundation.NSIndexPath)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPPlayableContentDataSourceWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMPPlayableContentDataSource ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMPPlayableContentDataSource" /> interface to support all the methods from the MPPlayableContentDataSource protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMPPlayableContentDataSource" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MPPlayableContentDataSource protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MPPlayableContentDataSource_Extensions {
		/// <param name="indexPath">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void BeginLoadingChildItems (this IMPPlayableContentDataSource This, NSIndexPath indexPath, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError> completionHandler)
		{
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V20.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("beginLoadingChildItemsAtIndexPath:completionHandler:"), indexPath__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (indexPath);
		}
		/// <param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ChildItemsDisplayPlaybackProgress (this IMPPlayableContentDataSource This, NSIndexPath indexPath)
		{
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("childItemsDisplayPlaybackProgressAtIndexPath:"), indexPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (indexPath);
			return ret != 0;
		}
		/// <param name="identifier">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'CarPlay' API instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'CarPlay' API instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void GetContentItem (this IMPPlayableContentDataSource This, string identifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V121))]global::System.Action<MPContentItem, NSError> completionHandler)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsidentifier = CFString.CreateNative (identifier);
			using var block_completionHandler = Trampolines.SDActionArity2V121.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("contentItemForIdentifier:completionHandler:"), nsidentifier, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsidentifier);
		}
		/// <param name="identifier">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para class="improve-task-t-return-type-description">A task that represents the asynchronous GetContentItem operation.  The value of the TResult parameter is of type System.Action&lt;MediaPlayer.MPContentItem,Foundation.NSError&gt;.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The GetContentItemAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'CarPlay' API instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'CarPlay' API instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<MPContentItem> GetContentItemAsync (this IMPPlayableContentDataSource This, string identifier)
		{
			var tcs = new TaskCompletionSource<MPContentItem> ();
			This.GetContentItem(identifier, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MPPlayableContentDataSourceWrapper : BaseWrapper, IMPPlayableContentDataSource {
		public MPPlayableContentDataSourceWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPPlayableContentDataSourceWrapper))]
		static MPPlayableContentDataSourceWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("contentItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPContentItem? GetContentItem (NSIndexPath indexPath)
		{
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			MPContentItem? ret;
			ret =  Runtime.GetNSObject<MPContentItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("contentItemAtIndexPath:"), indexPath__handle__), false)!;
			GC.KeepAlive (indexPath);
			return ret!;
		}
		/// <param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfChildItemsAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nint NumberOfChildItems (NSIndexPath indexPath)
		{
			var indexPath__handle__ = indexPath!.GetNonNullHandle (nameof (indexPath));
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("numberOfChildItemsAtIndexPath:"), indexPath__handle__);
			GC.KeepAlive (indexPath);
			return ret!;
		}
	}
}
namespace MediaPlayer {
	/// <summary>Provides media metadata information to external media players.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPPlayableContentDataSource_Ref/index.html">Apple documentation for <c>MPPlayableContentDataSource</c></related>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__MediaPlayer_MPPlayableContentDataSource", false)]
	[Model]
	[UnsupportedOSPlatform ("macos")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe abstract partial class MPPlayableContentDataSource : NSObject, IMPPlayableContentDataSource {
		/// <summary>Creates a new <see cref="MPPlayableContentDataSource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MPPlayableContentDataSource () : base (NSObjectFlag.Empty)
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
		protected MPPlayableContentDataSource (NSObjectFlag t) : base (t)
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
		protected internal MPPlayableContentDataSource (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="indexPath">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("beginLoadingChildItemsAtIndexPath:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void BeginLoadingChildItems (NSIndexPath indexPath, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V20))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("childItemsDisplayPlaybackProgressAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ChildItemsDisplayPlaybackProgress (NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("contentItemAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPContentItem? GetContentItem (NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="identifier">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("contentItemForIdentifier:completionHandler:")]
		[UnsupportedOSPlatform ("macos")]
		[ObsoletedOSPlatform ("ios14.0", "Use 'CarPlay' API instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'CarPlay' API instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetContentItem (string identifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V121))]global::System.Action<MPContentItem, NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="indexPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("numberOfChildItemsAtIndexPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfChildItems (NSIndexPath indexPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MPPlayableContentDataSource */
}
