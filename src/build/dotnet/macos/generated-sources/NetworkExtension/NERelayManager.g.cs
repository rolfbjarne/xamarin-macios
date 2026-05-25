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
namespace NetworkExtension {
	[Register("NERelayManager", true)]
	[SupportedOSPlatform ("tvos17.0")]
	[SupportedOSPlatform ("macos14.0")]
	[SupportedOSPlatform ("ios17.0")]
	[SupportedOSPlatform ("maccatalyst17.0")]
	public unsafe partial class NERelayManager : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExcludedDomainsX = "excludedDomains";
		static readonly NativeHandle selExcludedDomainsXHandle = Selector.GetHandle ("excludedDomains");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExcludedFQDNsX = "excludedFQDNs";
		static readonly NativeHandle selExcludedFQDNsXHandle = Selector.GetHandle ("excludedFQDNs");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetLastClientErrors_CompletionHandler_X = "getLastClientErrors:completionHandler:";
		static readonly NativeHandle selGetLastClientErrors_CompletionHandler_XHandle = Selector.GetHandle ("getLastClientErrors:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDNSFailoverAllowedX = "isDNSFailoverAllowed";
		static readonly NativeHandle selIsDNSFailoverAllowedXHandle = Selector.GetHandle ("isDNSFailoverAllowed");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEnabledX = "isEnabled";
		static readonly NativeHandle selIsEnabledXHandle = Selector.GetHandle ("isEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsUIToggleEnabledX = "isUIToggleEnabled";
		static readonly NativeHandle selIsUIToggleEnabledXHandle = Selector.GetHandle ("isUIToggleEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadAllManagersFromPreferencesWithCompletionHandler_X = "loadAllManagersFromPreferencesWithCompletionHandler:";
		static readonly NativeHandle selLoadAllManagersFromPreferencesWithCompletionHandler_XHandle = Selector.GetHandle ("loadAllManagersFromPreferencesWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadFromPreferencesWithCompletionHandler_X = "loadFromPreferencesWithCompletionHandler:";
		static readonly NativeHandle selLoadFromPreferencesWithCompletionHandler_XHandle = Selector.GetHandle ("loadFromPreferencesWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedDescriptionX = "localizedDescription";
		static readonly NativeHandle selLocalizedDescriptionXHandle = Selector.GetHandle ("localizedDescription");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatchDomainsX = "matchDomains";
		static readonly NativeHandle selMatchDomainsXHandle = Selector.GetHandle ("matchDomains");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatchFQDNsX = "matchFQDNs";
		static readonly NativeHandle selMatchFQDNsXHandle = Selector.GetHandle ("matchFQDNs");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOnDemandRulesX = "onDemandRules";
		static readonly NativeHandle selOnDemandRulesXHandle = Selector.GetHandle ("onDemandRules");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRelaysX = "relays";
		static readonly NativeHandle selRelaysXHandle = Selector.GetHandle ("relays");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveFromPreferencesWithCompletionHandler_X = "removeFromPreferencesWithCompletionHandler:";
		static readonly NativeHandle selRemoveFromPreferencesWithCompletionHandler_XHandle = Selector.GetHandle ("removeFromPreferencesWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSaveToPreferencesWithCompletionHandler_X = "saveToPreferencesWithCompletionHandler:";
		static readonly NativeHandle selSaveToPreferencesWithCompletionHandler_XHandle = Selector.GetHandle ("saveToPreferencesWithCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowDNSFailover_X = "setAllowDNSFailover:";
		static readonly NativeHandle selSetAllowDNSFailover_XHandle = Selector.GetHandle ("setAllowDNSFailover:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEnabled_X = "setEnabled:";
		static readonly NativeHandle selSetEnabled_XHandle = Selector.GetHandle ("setEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetExcludedDomains_X = "setExcludedDomains:";
		static readonly NativeHandle selSetExcludedDomains_XHandle = Selector.GetHandle ("setExcludedDomains:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetExcludedFQDNs_X = "setExcludedFQDNs:";
		static readonly NativeHandle selSetExcludedFQDNs_XHandle = Selector.GetHandle ("setExcludedFQDNs:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLocalizedDescription_X = "setLocalizedDescription:";
		static readonly NativeHandle selSetLocalizedDescription_XHandle = Selector.GetHandle ("setLocalizedDescription:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMatchDomains_X = "setMatchDomains:";
		static readonly NativeHandle selSetMatchDomains_XHandle = Selector.GetHandle ("setMatchDomains:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMatchFQDNs_X = "setMatchFQDNs:";
		static readonly NativeHandle selSetMatchFQDNs_XHandle = Selector.GetHandle ("setMatchFQDNs:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOnDemandRules_X = "setOnDemandRules:";
		static readonly NativeHandle selSetOnDemandRules_XHandle = Selector.GetHandle ("setOnDemandRules:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRelays_X = "setRelays:";
		static readonly NativeHandle selSetRelays_XHandle = Selector.GetHandle ("setRelays:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUIToggleEnabled_X = "setUIToggleEnabled:";
		static readonly NativeHandle selSetUIToggleEnabled_XHandle = Selector.GetHandle ("setUIToggleEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedManagerX = "sharedManager";
		static readonly NativeHandle selSharedManagerXHandle = Selector.GetHandle ("sharedManager");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NERelayManager");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NERelayManager" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NERelayManager () : base (NSObjectFlag.Empty)
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
		protected NERelayManager (NSObjectFlag t) : base (t)
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
		protected internal NERelayManager (NativeHandle handle) : base (handle)
		{
		}

		[Export ("getLastClientErrors:completionHandler:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetLastClientErrors (double seconds, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNERelayManagerGetLastClientErrorsCallback))]NERelayManagerGetLastClientErrorsCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNERelayManagerGetLastClientErrorsCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_Double_NativeHandle (this.Handle, selGetLastClientErrors_CompletionHandler_XHandle, seconds, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double_NativeHandle (&__objc_super__, selGetLastClientErrors_CompletionHandler_XHandle, seconds, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSError[]> GetLastClientErrorsAsync (double seconds)
		{
			var tcs = new TaskCompletionSource<NSError[]> ();
			GetLastClientErrors(seconds, (errors_) => {
				tcs.SetResult (errors_!);
			});
			return tcs.Task;
		}
		[Export ("loadAllManagersFromPreferencesWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void LoadAllManagersFromPreferences ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V121))]global::System.Action<NSArray<NERelayManager>, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V121.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selLoadAllManagersFromPreferencesWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static Task<NSArray<NERelayManager>> LoadAllManagersFromPreferencesAsync ()
		{
			var tcs = new TaskCompletionSource<NSArray<NERelayManager>> ();
			LoadAllManagersFromPreferences((arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[Export ("loadFromPreferencesWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadFromPreferences ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selLoadFromPreferencesWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selLoadFromPreferencesWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task LoadFromPreferencesAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			LoadFromPreferences((obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("removeFromPreferencesWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RemoveFromPreferences ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveFromPreferencesWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveFromPreferencesWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task RemoveFromPreferencesAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			RemoveFromPreferences((obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("saveToPreferencesWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SaveToPreferences ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSaveToPreferencesWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSaveToPreferencesWithCompletionHandler_XHandle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task SaveToPreferencesAsync ()
		{
			var tcs = new TaskCompletionSource<bool> ();
			SaveToPreferences((obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		public virtual bool AllowDNSFailover {
			[Export ("isDNSFailoverAllowed")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsDNSFailoverAllowedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsDNSFailoverAllowedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowDNSFailover:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowDNSFailover_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowDNSFailover_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Enabled {
			[Export ("isEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? ExcludedDomains {
			[Export ("excludedDomains", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selExcludedDomainsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selExcludedDomainsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setExcludedDomains:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = NSArray.FromNullableStrings (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetExcludedDomains_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetExcludedDomains_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.4")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		public virtual string[]? ExcludedFqdns {
			[Export ("excludedFQDNs", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selExcludedFQDNsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selExcludedFQDNsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setExcludedFQDNs:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = NSArray.FromNullableStrings (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetExcludedFQDNs_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetExcludedFQDNs_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? LocalizedDescription {
			[Export ("localizedDescription")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizedDescriptionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizedDescriptionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLocalizedDescription:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLocalizedDescription_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLocalizedDescription_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? MatchDomains {
			[Export ("matchDomains", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMatchDomainsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMatchDomainsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMatchDomains:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = NSArray.FromNullableStrings (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMatchDomains_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMatchDomains_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.4")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		public virtual string[]? MatchFqdns {
			[Export ("matchFQDNs", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMatchFQDNsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMatchFQDNsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMatchFQDNs:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = NSArray.FromNullableStrings (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMatchFQDNs_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMatchFQDNs_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NEOnDemandRule[]? OnDemandRules {
			[Export ("onDemandRules", ArgumentSemantic.Copy)]
			get {
				NEOnDemandRule[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NEOnDemandRule>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOnDemandRulesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NEOnDemandRule>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOnDemandRulesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setOnDemandRules:", ArgumentSemantic.Copy)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetOnDemandRules_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetOnDemandRules_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NERelay[]? Relays {
			[Export ("relays", ArgumentSemantic.Retain)]
			get {
				NERelay[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NERelay>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRelaysXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NERelay>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRelaysXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setRelays:", ArgumentSemantic.Retain)]
			set {
				using var nsa_value = value is null ? null : NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetRelays_XHandle, nsa_value.GetHandle ());
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetRelays_XHandle, nsa_value.GetHandle ());
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NERelayManager Shared {
			[Export ("sharedManager")]
			get {
				NERelayManager? ret;
				ret =  Runtime.GetNSObject<NERelayManager> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSharedManagerXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.4")]
		[SupportedOSPlatform ("macos15.4")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		public virtual bool UIToggleEnabled {
			[Export ("isUIToggleEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsUIToggleEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsUIToggleEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUIToggleEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUIToggleEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUIToggleEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class NERelayManager */
}
