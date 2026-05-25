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
namespace CoreSpotlight {
	/// <summary>A search index used by Spotlight.</summary><remarks><para>Typically, developers should use <see cref="P:CoreSpotlight.CSSearchableIndex.DefaultSearchableIndex" /> to index their application data.</para></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreSpotlight/Reference/CSSearchableIndex_Class/index.html">Apple documentation for <c>CSSearchableIndex</c></related>
	[Register("CSSearchableIndex", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class CSSearchableIndex : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultSearchableIndexX = "defaultSearchableIndex";
		static readonly NativeHandle selDefaultSearchableIndexXHandle = Selector.GetHandle ("defaultSearchableIndex");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteAllSearchableItemsWithCompletionHandler_X = "deleteAllSearchableItemsWithCompletionHandler:";
		static readonly NativeHandle selDeleteAllSearchableItemsWithCompletionHandler_XHandle = Selector.GetHandle ("deleteAllSearchableItemsWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteSearchableItemsWithDomainIdentifiers_CompletionHandler_X = "deleteSearchableItemsWithDomainIdentifiers:completionHandler:";
		static readonly NativeHandle selDeleteSearchableItemsWithDomainIdentifiers_CompletionHandler_XHandle = Selector.GetHandle ("deleteSearchableItemsWithDomainIdentifiers:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteSearchableItemsWithIdentifiers_CompletionHandler_X = "deleteSearchableItemsWithIdentifiers:completionHandler:";
		static readonly NativeHandle selDeleteSearchableItemsWithIdentifiers_CompletionHandler_XHandle = Selector.GetHandle ("deleteSearchableItemsWithIdentifiers:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchDataForBundleIdentifier_ItemIdentifier_ContentType_CompletionHandler_X = "fetchDataForBundleIdentifier:itemIdentifier:contentType:completionHandler:";
		static readonly NativeHandle selFetchDataForBundleIdentifier_ItemIdentifier_ContentType_CompletionHandler_XHandle = Selector.GetHandle ("fetchDataForBundleIdentifier:itemIdentifier:contentType:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexDelegateX = "indexDelegate";
		static readonly NativeHandle selIndexDelegateXHandle = Selector.GetHandle ("indexDelegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexSearchableItems_CompletionHandler_X = "indexSearchableItems:completionHandler:";
		static readonly NativeHandle selIndexSearchableItems_CompletionHandler_XHandle = Selector.GetHandle ("indexSearchableItems:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_X = "initWithName:";
		static readonly NativeHandle selInitWithName_XHandle = Selector.GetHandle ("initWithName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_ProtectionClass_X = "initWithName:protectionClass:";
		static readonly NativeHandle selInitWithName_ProtectionClass_XHandle = Selector.GetHandle ("initWithName:protectionClass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_ProtectionClass_BundleIdentifier_Options_X = "initWithName:protectionClass:bundleIdentifier:options:";
		static readonly NativeHandle selInitWithName_ProtectionClass_BundleIdentifier_Options_XHandle = Selector.GetHandle ("initWithName:protectionClass:bundleIdentifier:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsIndexingAvailableX = "isIndexingAvailable";
		static readonly NativeHandle selIsIndexingAvailableXHandle = Selector.GetHandle ("isIndexingAvailable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProvideDataForBundle_Identifier_Type_CompletionHandler_X = "provideDataForBundle:identifier:type:completionHandler:";
		static readonly NativeHandle selProvideDataForBundle_Identifier_Type_CompletionHandler_XHandle = Selector.GetHandle ("provideDataForBundle:identifier:type:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIndexDelegate_X = "setIndexDelegate:";
		static readonly NativeHandle selSetIndexDelegate_XHandle = Selector.GetHandle ("setIndexDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CSSearchableIndex");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="CSSearchableIndex" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CSSearchableIndex () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
				GC.KeepAlive (this);
				}
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
		protected CSSearchableIndex (NSObjectFlag t) : base (t)
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
		protected internal CSSearchableIndex (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="name">To be added.</param><summary>Creates a new index on the device with the specified name.</summary><remarks>To be added.</remarks>
		[Export ("initWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CSSearchableIndex (string name)
			: base (NSObjectFlag.Empty)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithName_XHandle, nsname), "initWithName:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithName_XHandle, nsname), "initWithName:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
		}
		/// <param name="name">To be added.</param><param name="protectionClass"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a new index on the device with the specified name and protection class.</summary><remarks>To be added.</remarks>
		[Export ("initWithName:protectionClass:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CSSearchableIndex (string name, NSString? protectionClass)
			: base (NSObjectFlag.Empty)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var protectionClass__handle__ = protectionClass.GetHandle ();
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithName_ProtectionClass_XHandle, nsname, protectionClass__handle__), "initWithName:protectionClass:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithName_ProtectionClass_XHandle, nsname, protectionClass__handle__), "initWithName:protectionClass:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (protectionClass);
			CFString.ReleaseNative (nsname);
		}
		[Export ("initWithName:protectionClass:bundleIdentifier:options:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CSSearchableIndex (string name, NSString? protectionClass, string bundleIdentifier, nint options)
			: base (NSObjectFlag.Empty)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var protectionClass__handle__ = protectionClass.GetHandle ();
			if (bundleIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (bundleIdentifier));
			var nsname = CFString.CreateNative (name);
			var nsbundleIdentifier = CFString.CreateNative (bundleIdentifier);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, selInitWithName_ProtectionClass_BundleIdentifier_Options_XHandle, nsname, protectionClass__handle__, nsbundleIdentifier, options), "initWithName:protectionClass:bundleIdentifier:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selInitWithName_ProtectionClass_BundleIdentifier_Options_XHandle, nsname, protectionClass__handle__, nsbundleIdentifier, options), "initWithName:protectionClass:bundleIdentifier:options:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (protectionClass);
			CFString.ReleaseNative (nsname);
			CFString.ReleaseNative (nsbundleIdentifier);
		}
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CSSearchableIndex (string name, NSFileProtectionType protectionClass, string bundleIdentifier, nint options)
			: this (name, protectionClass.GetConstant (), bundleIdentifier, options)
		{
		}
		/// <param name="identifiers">To be added.</param><param name="completionHandler"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Removes the identified items and runs <paramref name="completionHandler" /> when finished.</summary><remarks>To be added.</remarks>
		[Export ("deleteSearchableItemsWithIdentifiers:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Delete (string[] identifiers, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			if (identifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifiers));
			using var nsa_identifiers = NSArray.FromStrings (identifiers);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDeleteSearchableItemsWithIdentifiers_CompletionHandler_XHandle, nsa_identifiers.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDeleteSearchableItemsWithIdentifiers_CompletionHandler_XHandle, nsa_identifiers.Handle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="identifiers">To be added.</param>
		/// <summary>Asynchronously removes the identified items.</summary>
		/// <returns>A task that represents the asynchronous Delete operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task DeleteAsync (string[] identifiers)
		{
			var tcs = new TaskCompletionSource<bool> ();
			Delete(identifiers, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		/// <param name="completionHandler"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Removes all items and runs <paramref name="completionHandler" /> when finished.</summary><remarks>To be added.</remarks>
		[Export ("deleteAllSearchableItemsWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DeleteAll ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDeleteAllSearchableItemsWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDeleteAllSearchableItemsWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>Asynchronously removes all items.</summary>
		/// <returns>A task that represents the asynchronous DeleteAll operation</returns>
		/// <remarks>
		///           <para copied="true">The DeleteAllAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task DeleteAllAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			DeleteAll((obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		/// <param name="domainIdentifiers">The domain identifier for the items to delete.</param><param name="completionHandler">Handler that is called after the index change is journaled. may be <see langword="null" />.
		/// <para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Removes all items from the specified domains and runs <paramref name="completionHandler" /> after the index change is journaled.</summary><remarks>To be added.</remarks>
		[Export ("deleteSearchableItemsWithDomainIdentifiers:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void DeleteWithDomain (string[] domainIdentifiers, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			if (domainIdentifiers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (domainIdentifiers));
			using var nsa_domainIdentifiers = NSArray.FromStrings (domainIdentifiers);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDeleteSearchableItemsWithDomainIdentifiers_CompletionHandler_XHandle, nsa_domainIdentifiers.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDeleteSearchableItemsWithDomainIdentifiers_CompletionHandler_XHandle, nsa_domainIdentifiers.Handle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="domainIdentifiers">The domain identifier for the items to delete.</param>
		/// <summary>Asynchronously removes all items from the specified domains.</summary>
		/// <returns>A task that represents the asynchronous DeleteWithDomain operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task DeleteWithDomainAsync (string[] domainIdentifiers)
		{
			var tcs = new TaskCompletionSource<bool> ();
			DeleteWithDomain(domainIdentifiers, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("fetchDataForBundleIdentifier:itemIdentifier:contentType:completionHandler:")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FetchData (string bundleIdentifier, string itemIdentifier, global::UniformTypeIdentifiers.UTType contentType, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V16))]global::System.Action<NSData, NSError> completionHandler)
		{
			if (bundleIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (bundleIdentifier));
			if (itemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (itemIdentifier));
			var contentType__handle__ = contentType!.GetNonNullHandle (nameof (contentType));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsbundleIdentifier = CFString.CreateNative (bundleIdentifier);
			var nsitemIdentifier = CFString.CreateNative (itemIdentifier);
			using var block_completionHandler = Trampolines.SDActionArity2V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selFetchDataForBundleIdentifier_ItemIdentifier_ContentType_CompletionHandler_XHandle, nsbundleIdentifier, nsitemIdentifier, contentType__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selFetchDataForBundleIdentifier_ItemIdentifier_ContentType_CompletionHandler_XHandle, nsbundleIdentifier, nsitemIdentifier, contentType__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (contentType);
			CFString.ReleaseNative (nsbundleIdentifier);
			CFString.ReleaseNative (nsitemIdentifier);
		}
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> FetchDataAsync (string bundleIdentifier, string itemIdentifier, global::UniformTypeIdentifiers.UTType contentType)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			FetchData(bundleIdentifier, itemIdentifier, contentType, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		/// <param name="items">The items to index.</param><param name="completionHandler"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Indexes the specified searchable items and runs <paramref name="completionHandler" /> when finished.</summary><remarks>To be added.</remarks>
		[Export ("indexSearchableItems:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Index (CSSearchableItem[] items, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			if (items is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (items));
			using var nsa_items = NSArray.FromNSObjects (items);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selIndexSearchableItems_CompletionHandler_XHandle, nsa_items.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selIndexSearchableItems_CompletionHandler_XHandle, nsa_items.Handle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="items">The items to index.</param>
		/// <summary>Asynchronously indexes the specified searchable items.</summary>
		/// <returns>A task that represents the asynchronous Index operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task IndexAsync (CSSearchableItem[] items)
		{
			var tcs = new TaskCompletionSource<bool> ();
			Index(items, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("provideDataForBundle:identifier:type:completionHandler:")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ProvideData (string bundle, string identifier, string type, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V16))]global::System.Action<NSData, NSError> completionHandler)
		{
			if (bundle is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (bundle));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsbundle = CFString.CreateNative (bundle);
			var nsidentifier = CFString.CreateNative (identifier);
			var nstype = CFString.CreateNative (type);
			using var block_completionHandler = Trampolines.SDActionArity2V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selProvideDataForBundle_Identifier_Type_CompletionHandler_XHandle, nsbundle, nsidentifier, nstype, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selProvideDataForBundle_Identifier_Type_CompletionHandler_XHandle, nsbundle, nsidentifier, nstype, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsbundle);
			CFString.ReleaseNative (nsidentifier);
			CFString.ReleaseNative (nstype);
		}
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> ProvideDataAsync (string bundle, string identifier, string type)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			ProvideData(bundle, identifier, type, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		/// <summary>Gets the default search index for the device.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CSSearchableIndex DefaultSearchableIndex {
			[Export ("defaultSearchableIndex")]
			get {
				CSSearchableIndex? ret;
				ret =  Runtime.GetNSObject<CSSearchableIndex> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDefaultSearchableIndexXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_IndexDelegate_var;
		/// <summary>Gets or sets the delegate that responds to requests for index-related tasks.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ICSSearchableIndexDelegate? IndexDelegate {
			[Export ("indexDelegate", ArgumentSemantic.Weak)]
			get {
				ICSSearchableIndexDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<ICSSearchableIndexDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selIndexDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<ICSSearchableIndexDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selIndexDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_IndexDelegate_var = ret;
				return ret!;
			}
			[Export ("setIndexDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetIndexDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetIndexDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_IndexDelegate_var = value;
			}
		}
		/// <summary>Gets a Boolean value that tells whether indexing is available.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsIndexingAvailable {
			[Export ("isIndexingAvailable")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsIndexingAvailableXHandle);
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_IndexDelegate_var = null;
			}
		}
	} /* class CSSearchableIndex */
	//
	// Async result classes
	//
	/// <summary>This class holds the return values for an asynchronous operation.</summary>
	public partial class CSSearchableIndexBundleDataResult {
		/// <summary>The result value from the asynchronous operation.</summary>
		public NSData Arg1 { get; set; }
		partial void Initialize ();
		/// <summary>Creates a new instance of this class.</summary>
		/// <param name="arg1">Result value from an asynchronous operation.</param>
		public CSSearchableIndexBundleDataResult (NSData arg1) {
			this.Arg1 = arg1;
			Initialize ();
		}
	}
}
