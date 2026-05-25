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
namespace AppKit {
	[Register("NSOpenPanel", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSOpenPanel : NSSavePanel {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLsX = "URLs";
		static readonly NativeHandle selURLsXHandle = Selector.GetHandle ("URLs");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsMultipleSelectionX = "allowsMultipleSelection";
		static readonly NativeHandle selAllowsMultipleSelectionXHandle = Selector.GetHandle ("allowsMultipleSelection");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginForDirectory_File_Types_ModelessDelegate_DidEndSelector_ContextInfo_X = "beginForDirectory:file:types:modelessDelegate:didEndSelector:contextInfo:";
		static readonly NativeHandle selBeginForDirectory_File_Types_ModelessDelegate_DidEndSelector_ContextInfo_XHandle = Selector.GetHandle ("beginForDirectory:file:types:modelessDelegate:didEndSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginSheetForDirectory_File_Types_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_X = "beginSheetForDirectory:file:types:modalForWindow:modalDelegate:didEndSelector:contextInfo:";
		static readonly NativeHandle selBeginSheetForDirectory_File_Types_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_XHandle = Selector.GetHandle ("beginSheetForDirectory:file:types:modalForWindow:modalDelegate:didEndSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanChooseDirectoriesX = "canChooseDirectories";
		static readonly NativeHandle selCanChooseDirectoriesXHandle = Selector.GetHandle ("canChooseDirectories");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanChooseFilesX = "canChooseFiles";
		static readonly NativeHandle selCanChooseFilesXHandle = Selector.GetHandle ("canChooseFiles");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFilenamesX = "filenames";
		static readonly NativeHandle selFilenamesXHandle = Selector.GetHandle ("filenames");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitX = "init";
		static readonly NativeHandle selInitXHandle = Selector.GetHandle ("init");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOpenPanelX = "openPanel";
		static readonly NativeHandle selOpenPanelXHandle = Selector.GetHandle ("openPanel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResolvesAliasesX = "resolvesAliases";
		static readonly NativeHandle selResolvesAliasesXHandle = Selector.GetHandle ("resolvesAliases");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunModalForDirectory_File_Types_X = "runModalForDirectory:file:types:";
		static readonly NativeHandle selRunModalForDirectory_File_Types_XHandle = Selector.GetHandle ("runModalForDirectory:file:types:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRunModalForTypes_X = "runModalForTypes:";
		static readonly NativeHandle selRunModalForTypes_XHandle = Selector.GetHandle ("runModalForTypes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsMultipleSelection_X = "setAllowsMultipleSelection:";
		static readonly NativeHandle selSetAllowsMultipleSelection_XHandle = Selector.GetHandle ("setAllowsMultipleSelection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCanChooseDirectories_X = "setCanChooseDirectories:";
		static readonly NativeHandle selSetCanChooseDirectories_XHandle = Selector.GetHandle ("setCanChooseDirectories:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCanChooseFiles_X = "setCanChooseFiles:";
		static readonly NativeHandle selSetCanChooseFiles_XHandle = Selector.GetHandle ("setCanChooseFiles:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetResolvesAliases_X = "setResolvesAliases:";
		static readonly NativeHandle selSetResolvesAliases_XHandle = Selector.GetHandle ("setResolvesAliases:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSOpenPanel");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public NSOpenPanel (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected NSOpenPanel (NSObjectFlag t) : base (t)
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
		protected internal NSOpenPanel (NativeHandle handle) : base (handle)
		{
		}

		[Export ("init")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[ObsoletedOSPlatform ("macos10.15", "All open panels now run out-of-process, use 'OpenPanel' method instead")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"You must use 'OpenPanel' method if the application is sandboxed.")]
		public NSOpenPanel ()
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInitXHandle), "init");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInitXHandle), "init");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("beginForDirectory:file:types:modelessDelegate:didEndSelector:contextInfo:")]
		[ObsoletedOSPlatform ("macos10.6")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Begin (string? directory, string? fileName, string[]? fileTypes, NSObject? modelessDelegate, Selector? didEndSelector, nint contextInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var modelessDelegate__handle__ = modelessDelegate.GetHandle ();
			var didEndSelector__handle__ = didEndSelector.GetHandle ();
			var nsdirectory = CFString.CreateNative (directory);
			var nsfileName = CFString.CreateNative (fileName);
			using var nsa_fileTypes = NSArray.FromNullableStrings (fileTypes);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, selBeginForDirectory_File_Types_ModelessDelegate_DidEndSelector_ContextInfo_XHandle, nsdirectory, nsfileName, nsa_fileTypes.GetHandle (), modelessDelegate__handle__, didEndSelector__handle__, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selBeginForDirectory_File_Types_ModelessDelegate_DidEndSelector_ContextInfo_XHandle, nsdirectory, nsfileName, nsa_fileTypes.GetHandle (), modelessDelegate__handle__, didEndSelector__handle__, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (modelessDelegate);
			GC.KeepAlive (didEndSelector);
			CFString.ReleaseNative (nsdirectory);
			CFString.ReleaseNative (nsfileName);
		}
		[Export ("beginSheetForDirectory:file:types:modalForWindow:modalDelegate:didEndSelector:contextInfo:")]
		[ObsoletedOSPlatform ("macos10.6", "Use NSApplication.RunModal instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void BeginSheet (string? directory, string? fileName, string[]? fileTypes, NSWindow? modalForWindow, NSObject? modalDelegate, Selector? didEndSelector, nint contextInfo)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var modalForWindow__handle__ = modalForWindow.GetHandle ();
			var modalDelegate__handle__ = modalDelegate.GetHandle ();
			var didEndSelector__handle__ = didEndSelector.GetHandle ();
			var nsdirectory = CFString.CreateNative (directory);
			var nsfileName = CFString.CreateNative (fileName);
			using var nsa_fileTypes = NSArray.FromNullableStrings (fileTypes);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, selBeginSheetForDirectory_File_Types_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_XHandle, nsdirectory, nsfileName, nsa_fileTypes.GetHandle (), modalForWindow__handle__, modalDelegate__handle__, didEndSelector__handle__, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selBeginSheetForDirectory_File_Types_ModalForWindow_ModalDelegate_DidEndSelector_ContextInfo_XHandle, nsdirectory, nsfileName, nsa_fileTypes.GetHandle (), modalForWindow__handle__, modalDelegate__handle__, didEndSelector__handle__, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (modalForWindow);
			GC.KeepAlive (modalDelegate);
			GC.KeepAlive (didEndSelector);
			CFString.ReleaseNative (nsdirectory);
			CFString.ReleaseNative (nsfileName);
		}
		[Export ("runModalForDirectory:file:types:")]
		[ObsoletedOSPlatform ("macos10.6", "Use NSApplication.RunModal instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint RunModal (string? directory, string? fileName, string[]? types)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nsdirectory = CFString.CreateNative (directory);
			var nsfileName = CFString.CreateNative (fileName);
			using var nsa_types = NSArray.FromNullableStrings (types);
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selRunModalForDirectory_File_Types_XHandle, nsdirectory, nsfileName, nsa_types.GetHandle ());
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selRunModalForDirectory_File_Types_XHandle, nsdirectory, nsfileName, nsa_types.GetHandle ());
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdirectory);
			CFString.ReleaseNative (nsfileName);
			return ret!;
		}
		[Export ("runModalForTypes:")]
		[ObsoletedOSPlatform ("macos10.6", "Use NSApplication.RunModal instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint RunModal (string[] types)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (types is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (types));
			using var nsa_types = NSArray.FromStrings (types);
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selRunModalForTypes_XHandle, nsa_types.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selRunModalForTypes_XHandle, nsa_types.Handle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsMultipleSelection {
			[Export ("allowsMultipleSelection")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsMultipleSelectionXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsMultipleSelectionXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsMultipleSelection:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsMultipleSelection_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsMultipleSelection_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanChooseDirectories {
			[Export ("canChooseDirectories")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanChooseDirectoriesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanChooseDirectoriesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setCanChooseDirectories:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetCanChooseDirectories_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetCanChooseDirectories_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanChooseFiles {
			[Export ("canChooseFiles")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCanChooseFilesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCanChooseFilesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setCanChooseFiles:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetCanChooseFiles_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetCanChooseFiles_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos10.6", "Use Urls instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual string[] Filenames {
			[Export ("filenames")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFilenamesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFilenamesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSOpenPanel OpenPanel {
			[Export ("openPanel")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSOpenPanel? ret;
				ret =  Runtime.GetINativeObject<NSOpenPanel> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selOpenPanelXHandle), true, false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ResolvesAliases {
			[Export ("resolvesAliases")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selResolvesAliasesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selResolvesAliasesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setResolvesAliases:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetResolvesAliases_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetResolvesAliases_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl[] Urls {
			[Export ("URLs")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSUrl[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selURLsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selURLsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class NSOpenPanel */
}
