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
namespace Foundation {
	[Register("NSBundle", true)]
	public unsafe partial class NSBundle : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLForAuxiliaryExecutable_X = "URLForAuxiliaryExecutable:";
		static readonly NativeHandle selURLForAuxiliaryExecutable_XHandle = Selector.GetHandle ("URLForAuxiliaryExecutable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLForImageResource_X = "URLForImageResource:";
		static readonly NativeHandle selURLForImageResource_XHandle = Selector.GetHandle ("URLForImageResource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLForResource_WithExtension_X = "URLForResource:withExtension:";
		static readonly NativeHandle selURLForResource_WithExtension_XHandle = Selector.GetHandle ("URLForResource:withExtension:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLForResource_WithExtension_Subdirectory_X = "URLForResource:withExtension:subdirectory:";
		static readonly NativeHandle selURLForResource_WithExtension_Subdirectory_XHandle = Selector.GetHandle ("URLForResource:withExtension:subdirectory:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLForResource_WithExtension_Subdirectory_InBundleWithURL_X = "URLForResource:withExtension:subdirectory:inBundleWithURL:";
		static readonly NativeHandle selURLForResource_WithExtension_Subdirectory_InBundleWithURL_XHandle = Selector.GetHandle ("URLForResource:withExtension:subdirectory:inBundleWithURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLForResource_WithExtension_Subdirectory_Localization_X = "URLForResource:withExtension:subdirectory:localization:";
		static readonly NativeHandle selURLForResource_WithExtension_Subdirectory_Localization_XHandle = Selector.GetHandle ("URLForResource:withExtension:subdirectory:localization:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLsForResourcesWithExtension_Subdirectory_X = "URLsForResourcesWithExtension:subdirectory:";
		static readonly NativeHandle selURLsForResourcesWithExtension_Subdirectory_XHandle = Selector.GetHandle ("URLsForResourcesWithExtension:subdirectory:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLsForResourcesWithExtension_Subdirectory_InBundleWithURL_X = "URLsForResourcesWithExtension:subdirectory:inBundleWithURL:";
		static readonly NativeHandle selURLsForResourcesWithExtension_Subdirectory_InBundleWithURL_XHandle = Selector.GetHandle ("URLsForResourcesWithExtension:subdirectory:inBundleWithURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLsForResourcesWithExtension_Subdirectory_Localization_X = "URLsForResourcesWithExtension:subdirectory:localization:";
		static readonly NativeHandle selURLsForResourcesWithExtension_Subdirectory_Localization_XHandle = Selector.GetHandle ("URLsForResourcesWithExtension:subdirectory:localization:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllBundlesX = "allBundles";
		static readonly NativeHandle selAllBundlesXHandle = Selector.GetHandle ("allBundles");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllFrameworksX = "allFrameworks";
		static readonly NativeHandle selAllFrameworksXHandle = Selector.GetHandle ("allFrameworks");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppStoreReceiptURLX = "appStoreReceiptURL";
		static readonly NativeHandle selAppStoreReceiptURLXHandle = Selector.GetHandle ("appStoreReceiptURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBuiltInPlugInsPathX = "builtInPlugInsPath";
		static readonly NativeHandle selBuiltInPlugInsPathXHandle = Selector.GetHandle ("builtInPlugInsPath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBuiltInPlugInsURLX = "builtInPlugInsURL";
		static readonly NativeHandle selBuiltInPlugInsURLXHandle = Selector.GetHandle ("builtInPlugInsURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBundleForClass_X = "bundleForClass:";
		static readonly NativeHandle selBundleForClass_XHandle = Selector.GetHandle ("bundleForClass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBundleIdentifierX = "bundleIdentifier";
		static readonly NativeHandle selBundleIdentifierXHandle = Selector.GetHandle ("bundleIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBundlePathX = "bundlePath";
		static readonly NativeHandle selBundlePathXHandle = Selector.GetHandle ("bundlePath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBundleURLX = "bundleURL";
		static readonly NativeHandle selBundleURLXHandle = Selector.GetHandle ("bundleURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBundleWithIdentifier_X = "bundleWithIdentifier:";
		static readonly NativeHandle selBundleWithIdentifier_XHandle = Selector.GetHandle ("bundleWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBundleWithPath_X = "bundleWithPath:";
		static readonly NativeHandle selBundleWithPath_XHandle = Selector.GetHandle ("bundleWithPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBundleWithURL_X = "bundleWithURL:";
		static readonly NativeHandle selBundleWithURL_XHandle = Selector.GetHandle ("bundleWithURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClassNamed_X = "classNamed:";
		static readonly NativeHandle selClassNamed_XHandle = Selector.GetHandle ("classNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContextHelpForKey_X = "contextHelpForKey:";
		static readonly NativeHandle selContextHelpForKey_XHandle = Selector.GetHandle ("contextHelpForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDevelopmentLocalizationX = "developmentLocalization";
		static readonly NativeHandle selDevelopmentLocalizationXHandle = Selector.GetHandle ("developmentLocalization");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExecutablePathX = "executablePath";
		static readonly NativeHandle selExecutablePathXHandle = Selector.GetHandle ("executablePath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExecutableURLX = "executableURL";
		static readonly NativeHandle selExecutableURLXHandle = Selector.GetHandle ("executableURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageForResource_X = "imageForResource:";
		static readonly NativeHandle selImageForResource_XHandle = Selector.GetHandle ("imageForResource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInfoDictionaryX = "infoDictionary";
		static readonly NativeHandle selInfoDictionaryXHandle = Selector.GetHandle ("infoDictionary");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithPath_X = "initWithPath:";
		static readonly NativeHandle selInitWithPath_XHandle = Selector.GetHandle ("initWithPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithURL_X = "initWithURL:";
		static readonly NativeHandle selInitWithURL_XHandle = Selector.GetHandle ("initWithURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsLoadedX = "isLoaded";
		static readonly NativeHandle selIsLoadedXHandle = Selector.GetHandle ("isLoaded");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadX = "load";
		static readonly NativeHandle selLoadXHandle = Selector.GetHandle ("load");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadNibNamed_Owner_X = "loadNibNamed:owner:";
		static readonly NativeHandle selLoadNibNamed_Owner_XHandle = Selector.GetHandle ("loadNibNamed:owner:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadNibNamed_Owner_TopLevelObjects_X = "loadNibNamed:owner:topLevelObjects:";
		static readonly NativeHandle selLoadNibNamed_Owner_TopLevelObjects_XHandle = Selector.GetHandle ("loadNibNamed:owner:topLevelObjects:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizationsX = "localizations";
		static readonly NativeHandle selLocalizationsXHandle = Selector.GetHandle ("localizations");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedAttributedStringForKey_Value_Table_X = "localizedAttributedStringForKey:value:table:";
		static readonly NativeHandle selLocalizedAttributedStringForKey_Value_Table_XHandle = Selector.GetHandle ("localizedAttributedStringForKey:value:table:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedStringForKey_Value_Table_X = "localizedStringForKey:value:table:";
		static readonly NativeHandle selLocalizedStringForKey_Value_Table_XHandle = Selector.GetHandle ("localizedStringForKey:value:table:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedStringForKey_Value_Table_Localizations_X = "localizedStringForKey:value:table:localizations:";
		static readonly NativeHandle selLocalizedStringForKey_Value_Table_Localizations_XHandle = Selector.GetHandle ("localizedStringForKey:value:table:localizations:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMainBundleX = "mainBundle";
		static readonly NativeHandle selMainBundleXHandle = Selector.GetHandle ("mainBundle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectForInfoDictionaryKey_X = "objectForInfoDictionaryKey:";
		static readonly NativeHandle selObjectForInfoDictionaryKey_XHandle = Selector.GetHandle ("objectForInfoDictionaryKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPathForAuxiliaryExecutable_X = "pathForAuxiliaryExecutable:";
		static readonly NativeHandle selPathForAuxiliaryExecutable_XHandle = Selector.GetHandle ("pathForAuxiliaryExecutable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPathForImageResource_X = "pathForImageResource:";
		static readonly NativeHandle selPathForImageResource_XHandle = Selector.GetHandle ("pathForImageResource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPathForResource_OfType_X = "pathForResource:ofType:";
		static readonly NativeHandle selPathForResource_OfType_XHandle = Selector.GetHandle ("pathForResource:ofType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPathForResource_OfType_InDirectory_X = "pathForResource:ofType:inDirectory:";
		static readonly NativeHandle selPathForResource_OfType_InDirectory_XHandle = Selector.GetHandle ("pathForResource:ofType:inDirectory:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPathForResource_OfType_InDirectory_ForLocalization_X = "pathForResource:ofType:inDirectory:forLocalization:";
		static readonly NativeHandle selPathForResource_OfType_InDirectory_ForLocalization_XHandle = Selector.GetHandle ("pathForResource:ofType:inDirectory:forLocalization:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPathForSoundResource_X = "pathForSoundResource:";
		static readonly NativeHandle selPathForSoundResource_XHandle = Selector.GetHandle ("pathForSoundResource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPathsForResourcesOfType_InDirectory_X = "pathsForResourcesOfType:inDirectory:";
		static readonly NativeHandle selPathsForResourcesOfType_InDirectory_XHandle = Selector.GetHandle ("pathsForResourcesOfType:inDirectory:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPathsForResourcesOfType_InDirectory_ForLocalization_X = "pathsForResourcesOfType:inDirectory:forLocalization:";
		static readonly NativeHandle selPathsForResourcesOfType_InDirectory_ForLocalization_XHandle = Selector.GetHandle ("pathsForResourcesOfType:inDirectory:forLocalization:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredLocalizationsX = "preferredLocalizations";
		static readonly NativeHandle selPreferredLocalizationsXHandle = Selector.GetHandle ("preferredLocalizations");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrincipalClassX = "principalClass";
		static readonly NativeHandle selPrincipalClassXHandle = Selector.GetHandle ("principalClass");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrivateFrameworksPathX = "privateFrameworksPath";
		static readonly NativeHandle selPrivateFrameworksPathXHandle = Selector.GetHandle ("privateFrameworksPath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrivateFrameworksURLX = "privateFrameworksURL";
		static readonly NativeHandle selPrivateFrameworksURLXHandle = Selector.GetHandle ("privateFrameworksURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResourcePathX = "resourcePath";
		static readonly NativeHandle selResourcePathXHandle = Selector.GetHandle ("resourcePath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResourceURLX = "resourceURL";
		static readonly NativeHandle selResourceURLXHandle = Selector.GetHandle ("resourceURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedFrameworksPathX = "sharedFrameworksPath";
		static readonly NativeHandle selSharedFrameworksPathXHandle = Selector.GetHandle ("sharedFrameworksPath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedFrameworksURLX = "sharedFrameworksURL";
		static readonly NativeHandle selSharedFrameworksURLXHandle = Selector.GetHandle ("sharedFrameworksURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedSupportPathX = "sharedSupportPath";
		static readonly NativeHandle selSharedSupportPathXHandle = Selector.GetHandle ("sharedSupportPath");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedSupportURLX = "sharedSupportURL";
		static readonly NativeHandle selSharedSupportURLXHandle = Selector.GetHandle ("sharedSupportURL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnloadX = "unload";
		static readonly NativeHandle selUnloadXHandle = Selector.GetHandle ("unload");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSBundle");
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
		protected NSBundle (NSObjectFlag t) : base (t)
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
		protected internal NSBundle (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithPath:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSBundle (string path)
			: base (NSObjectFlag.Empty)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithPath_XHandle, nspath), "initWithPath:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithPath_XHandle, nspath), "initWithPath:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
		}
		[Export ("initWithURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSBundle (NSUrl url)
			: base (NSObjectFlag.Empty)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithURL_XHandle, url__handle__), "initWithURL:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithURL_XHandle, url__handle__), "initWithURL:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
		}
		[Export ("classNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual Class? ClassNamed (string className)
		{
			if (className is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (className));
			var nsclassName = CFString.CreateNative (className);
			Class? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selClassNamed_XHandle, nsclassName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selClassNamed_XHandle, nsclassName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsclassName);
			return ret!;
		}
		[Export ("bundleForClass:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSBundle FromClass (Class c)
		{
			var c__handle__ = c!.GetNonNullHandle (nameof (c));
			NSBundle? ret;
			ret =  Runtime.GetNSObject<NSBundle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selBundleForClass_XHandle, c.Handle), false)!;
			GC.KeepAlive (c);
			return ret!;
		}
		[Export ("bundleWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSBundle? FromIdentifier (string str)
		{
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			var nsstr = CFString.CreateNative (str);
			NSBundle? ret;
			ret =  Runtime.GetNSObject<NSBundle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selBundleWithIdentifier_XHandle, nsstr), false)!;
			CFString.ReleaseNative (nsstr);
			return ret!;
		}
		[Export ("bundleWithPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSBundle? FromPath (string path)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			NSBundle? ret;
			ret =  Runtime.GetNSObject<NSBundle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selBundleWithPath_XHandle, nspath), false)!;
			CFString.ReleaseNative (nspath);
			return ret!;
		}
		[Export ("bundleWithURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSBundle? FromUrl (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NSBundle? ret;
			ret =  Runtime.GetNSObject<NSBundle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selBundleWithURL_XHandle, url__handle__), false)!;
			GC.KeepAlive (url);
			return ret!;
		}
		/// <param name="key">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("contextHelpForKey:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString? GetContextHelp (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			NSAttributedString? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selContextHelpForKey_XHandle, nskey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selContextHelpForKey_XHandle, nskey), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("localizedAttributedStringForKey:value:table:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAttributedString GetLocalizedAttributedString (string key, string? value, string? tableName)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			var nsvalue = CFString.CreateNative (value);
			var nstableName = CFString.CreateNative (tableName);
			NSAttributedString? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selLocalizedAttributedStringForKey_Value_Table_XHandle, nskey, nsvalue, nstableName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selLocalizedAttributedStringForKey_Value_Table_XHandle, nskey, nsvalue, nstableName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsvalue);
			CFString.ReleaseNative (nstableName);
			return ret!;
		}
		/// <summary>Get a localized version of the string for the specified key in the specified table.</summary><param name="key">The key to lookup</param><param name="value">The value to return if the key is null, or the key was not found on the localization table.</param><param name="table">The table to search, if the value is null, this uses the Localizable.strings table.</param><summary>A localized version of the string for the specified key in the specified table.</summary>
		[Export ("localizedStringForKey:value:table:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString GetLocalizedString (NSString? key, NSString? value, NSString? table)
		{
			var key__handle__ = key.GetHandle ();
			var value__handle__ = value.GetHandle ();
			var table__handle__ = table.GetHandle ();
			NSString? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selLocalizedStringForKey_Value_Table_XHandle, key__handle__, value__handle__, table__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selLocalizedStringForKey_Value_Table_XHandle, key__handle__, value__handle__, table__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
			GC.KeepAlive (value);
			GC.KeepAlive (table);
			return ret!;
		}
		[Export ("localizedStringForKey:value:table:localizations:")]
		[SupportedOSPlatform ("tvos18.4")]
		[SupportedOSPlatform ("ios18.4")]
		[SupportedOSPlatform ("maccatalyst18.4")]
		[SupportedOSPlatform ("macos15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString GetLocalizedString (NSString key, NSString? value, NSString? tableName, NSString[] localizations)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			var value__handle__ = value.GetHandle ();
			var tableName__handle__ = tableName.GetHandle ();
			if (localizations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localizations));
			using var nsa_localizations = NSArray.FromNSObjects (localizations);
			NSString? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selLocalizedStringForKey_Value_Table_Localizations_XHandle, key__handle__, value__handle__, tableName__handle__, nsa_localizations.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selLocalizedStringForKey_Value_Table_Localizations_XHandle, key__handle__, value__handle__, tableName__handle__, nsa_localizations.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
			GC.KeepAlive (value);
			GC.KeepAlive (tableName);
			return ret!;
		}
		[Export ("pathsForResourcesOfType:inDirectory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] GetPathsForResources (string? fileExtension, string bundlePath)
		{
			if (bundlePath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (bundlePath));
			var nsfileExtension = CFString.CreateNative (fileExtension);
			var nsbundlePath = CFString.CreateNative (bundlePath);
			string[]? ret;
			ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selPathsForResourcesOfType_InDirectory_XHandle, nsfileExtension, nsbundlePath), false)!;
			CFString.ReleaseNative (nsfileExtension);
			CFString.ReleaseNative (nsbundlePath);
			return ret!;
		}
		/// <param name="resource">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("URLForImageResource:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? GetUrlForImageResource (string resource)
		{
			if (resource is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resource));
			var nsresource = CFString.CreateNative (resource);
			NSUrl? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selURLForImageResource_XHandle, nsresource), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selURLForImageResource_XHandle, nsresource), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsresource);
			return ret!;
		}
		[Export ("URLForResource:withExtension:subdirectory:inBundleWithURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl? GetUrlForResource (string? name, string? fileExtension, string? subdirectory, NSUrl bundleURL)
		{
			var bundleURL__handle__ = bundleURL!.GetNonNullHandle (nameof (bundleURL));
			var nsname = CFString.CreateNative (name);
			var nsfileExtension = CFString.CreateNative (fileExtension);
			var nssubdirectory = CFString.CreateNative (subdirectory);
			NSUrl? ret;
			ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (class_ptr, selURLForResource_WithExtension_Subdirectory_InBundleWithURL_XHandle, nsname, nsfileExtension, nssubdirectory, bundleURL__handle__), false)!;
			GC.KeepAlive (bundleURL);
			CFString.ReleaseNative (nsname);
			CFString.ReleaseNative (nsfileExtension);
			CFString.ReleaseNative (nssubdirectory);
			return ret!;
		}
		[Export ("URLForResource:withExtension:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? GetUrlForResource (string? name, string? fileExtension)
		{
			var nsname = CFString.CreateNative (name);
			var nsfileExtension = CFString.CreateNative (fileExtension);
			NSUrl? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selURLForResource_WithExtension_XHandle, nsname, nsfileExtension), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selURLForResource_WithExtension_XHandle, nsname, nsfileExtension), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			CFString.ReleaseNative (nsfileExtension);
			return ret!;
		}
		[Export ("URLForResource:withExtension:subdirectory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? GetUrlForResource (string? name, string? fileExtension, string? subdirectory)
		{
			var nsname = CFString.CreateNative (name);
			var nsfileExtension = CFString.CreateNative (fileExtension);
			var nssubdirectory = CFString.CreateNative (subdirectory);
			NSUrl? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selURLForResource_WithExtension_Subdirectory_XHandle, nsname, nsfileExtension, nssubdirectory), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selURLForResource_WithExtension_Subdirectory_XHandle, nsname, nsfileExtension, nssubdirectory), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			CFString.ReleaseNative (nsfileExtension);
			CFString.ReleaseNative (nssubdirectory);
			return ret!;
		}
		[Export ("URLForResource:withExtension:subdirectory:localization:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? GetUrlForResource (string? name, string? fileExtension, string? subdirectory, string? localizationName)
		{
			var nsname = CFString.CreateNative (name);
			var nsfileExtension = CFString.CreateNative (fileExtension);
			var nssubdirectory = CFString.CreateNative (subdirectory);
			var nslocalizationName = CFString.CreateNative (localizationName);
			NSUrl? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selURLForResource_WithExtension_Subdirectory_Localization_XHandle, nsname, nsfileExtension, nssubdirectory, nslocalizationName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selURLForResource_WithExtension_Subdirectory_Localization_XHandle, nsname, nsfileExtension, nssubdirectory, nslocalizationName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			CFString.ReleaseNative (nsfileExtension);
			CFString.ReleaseNative (nssubdirectory);
			CFString.ReleaseNative (nslocalizationName);
			return ret!;
		}
		[Export ("URLsForResourcesWithExtension:subdirectory:inBundleWithURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrl[]? GetUrlsForResourcesWithExtension (string? fileExtension, string? subdirectory, NSUrl bundleURL)
		{
			var bundleURL__handle__ = bundleURL!.GetNonNullHandle (nameof (bundleURL));
			var nsfileExtension = CFString.CreateNative (fileExtension);
			var nssubdirectory = CFString.CreateNative (subdirectory);
			NSUrl[]? ret;
			ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selURLsForResourcesWithExtension_Subdirectory_InBundleWithURL_XHandle, nsfileExtension, nssubdirectory, bundleURL__handle__), false)!;
			GC.KeepAlive (bundleURL);
			CFString.ReleaseNative (nsfileExtension);
			CFString.ReleaseNative (nssubdirectory);
			return ret!;
		}
		[Export ("URLsForResourcesWithExtension:subdirectory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl[]? GetUrlsForResourcesWithExtension (string? fileExtension, string? subdirectory)
		{
			var nsfileExtension = CFString.CreateNative (fileExtension);
			var nssubdirectory = CFString.CreateNative (subdirectory);
			NSUrl[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selURLsForResourcesWithExtension_Subdirectory_XHandle, nsfileExtension, nssubdirectory), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selURLsForResourcesWithExtension_Subdirectory_XHandle, nsfileExtension, nssubdirectory), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfileExtension);
			CFString.ReleaseNative (nssubdirectory);
			return ret!;
		}
		[Export ("URLsForResourcesWithExtension:subdirectory:localization:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl[]? GetUrlsForResourcesWithExtension (string? fileExtension, string? subdirectory, string? localizationName)
		{
			var nsfileExtension = CFString.CreateNative (fileExtension);
			var nssubdirectory = CFString.CreateNative (subdirectory);
			var nslocalizationName = CFString.CreateNative (localizationName);
			NSUrl[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selURLsForResourcesWithExtension_Subdirectory_Localization_XHandle, nsfileExtension, nssubdirectory, nslocalizationName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSUrl>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selURLsForResourcesWithExtension_Subdirectory_Localization_XHandle, nsfileExtension, nssubdirectory, nslocalizationName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfileExtension);
			CFString.ReleaseNative (nssubdirectory);
			CFString.ReleaseNative (nslocalizationName);
			return ret!;
		}
		/// <param name="name">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageForResource:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSImage? ImageForResource (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			global::AppKit.NSImage? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::AppKit.NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selImageForResource_XHandle, nsname), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::AppKit.NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selImageForResource_XHandle, nsname), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("load")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Load ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selLoadXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selLoadXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <param name="nibName">To be added.</param><param name="owner">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("loadNibNamed:owner:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos10.8")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool LoadNib (string nibName, NSObject owner)
		{
			if (nibName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nibName));
			var owner__handle__ = owner!.GetNonNullHandle (nameof (owner));
			var nsnibName = CFString.CreateNative (nibName);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selLoadNibNamed_Owner_XHandle, nsnibName, owner__handle__);
			GC.KeepAlive (owner);
			CFString.ReleaseNative (nsnibName);
			return ret != 0;
		}
		/// <param name="nibName">To be added.</param><param name="owner">To be added.</param><param name="topLevelObjects">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("loadNibNamed:owner:topLevelObjects:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool LoadNibNamed (string nibName, NSObject? owner, out NSArray topLevelObjects)
		{
			if (nibName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nibName));
			var owner__handle__ = owner.GetHandle ();
			NativeHandle topLevelObjectsValue = IntPtr.Zero;
			var nsnibName = CFString.CreateNative (nibName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selLoadNibNamed_Owner_TopLevelObjects_XHandle, nsnibName, owner__handle__, &topLevelObjectsValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selLoadNibNamed_Owner_TopLevelObjects_XHandle, nsnibName, owner__handle__, &topLevelObjectsValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (owner);
			CFString.ReleaseNative (nsnibName);
			topLevelObjects = Runtime.GetNSObject<NSArray> (topLevelObjectsValue)!;
			return ret != 0;
		}
		[Export ("objectForInfoDictionaryKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? ObjectForInfoDictionary (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selObjectForInfoDictionaryKey_XHandle, nskey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selObjectForInfoDictionaryKey_XHandle, nskey), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("pathForAuxiliaryExecutable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? PathForAuxiliaryExecutable (string s)
		{
			if (s is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (s));
			var nss = CFString.CreateNative (s);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPathForAuxiliaryExecutable_XHandle, nss), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPathForAuxiliaryExecutable_XHandle, nss), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nss);
			return ret!;
		}
		/// <param name="resource">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pathForImageResource:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? PathForImageResource (string resource)
		{
			if (resource is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resource));
			var nsresource = CFString.CreateNative (resource);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPathForImageResource_XHandle, nsresource), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPathForImageResource_XHandle, nsresource), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsresource);
			return ret!;
		}
		[Export ("pathForResource:ofType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? PathForResource (string? name, string? ofType)
		{
			var nsname = CFString.CreateNative (name);
			var nsofType = CFString.CreateNative (ofType);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selPathForResource_OfType_XHandle, nsname, nsofType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selPathForResource_OfType_XHandle, nsname, nsofType), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			CFString.ReleaseNative (nsofType);
			return ret!;
		}
		[Export ("pathForResource:ofType:inDirectory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? PathForResource (string? name, string? ofType, string? subpath)
		{
			var nsname = CFString.CreateNative (name);
			var nsofType = CFString.CreateNative (ofType);
			var nssubpath = CFString.CreateNative (subpath);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selPathForResource_OfType_InDirectory_XHandle, nsname, nsofType, nssubpath), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selPathForResource_OfType_InDirectory_XHandle, nsname, nsofType, nssubpath), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			CFString.ReleaseNative (nsofType);
			CFString.ReleaseNative (nssubpath);
			return ret!;
		}
		[Export ("pathForResource:ofType:inDirectory:forLocalization:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? PathForResource (string? name, string? ofType, string? subpath, string? localizationName)
		{
			var nsname = CFString.CreateNative (name);
			var nsofType = CFString.CreateNative (ofType);
			var nssubpath = CFString.CreateNative (subpath);
			var nslocalizationName = CFString.CreateNative (localizationName);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selPathForResource_OfType_InDirectory_ForLocalization_XHandle, nsname, nsofType, nssubpath, nslocalizationName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selPathForResource_OfType_InDirectory_ForLocalization_XHandle, nsname, nsofType, nssubpath, nslocalizationName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			CFString.ReleaseNative (nsofType);
			CFString.ReleaseNative (nssubpath);
			CFString.ReleaseNative (nslocalizationName);
			return ret!;
		}
		[Export ("pathForResource:ofType:inDirectory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? PathForResourceAbsolute (string? name, string? ofType, string bundleDirectory)
		{
			if (bundleDirectory is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (bundleDirectory));
			var nsname = CFString.CreateNative (name);
			var nsofType = CFString.CreateNative (ofType);
			var nsbundleDirectory = CFString.CreateNative (bundleDirectory);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selPathForResource_OfType_InDirectory_XHandle, nsname, nsofType, nsbundleDirectory), false)!;
			CFString.ReleaseNative (nsname);
			CFString.ReleaseNative (nsofType);
			CFString.ReleaseNative (nsbundleDirectory);
			return ret!;
		}
		/// <param name="resource">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("pathForSoundResource:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? PathForSoundResource (string resource)
		{
			if (resource is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (resource));
			var nsresource = CFString.CreateNative (resource);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPathForSoundResource_XHandle, nsresource), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPathForSoundResource_XHandle, nsresource), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsresource);
			return ret!;
		}
		[Export ("pathsForResourcesOfType:inDirectory:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] PathsForResources (string? fileExtension, string? subDirectory)
		{
			var nsfileExtension = CFString.CreateNative (fileExtension);
			var nssubDirectory = CFString.CreateNative (subDirectory);
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selPathsForResourcesOfType_InDirectory_XHandle, nsfileExtension, nssubDirectory), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selPathsForResourcesOfType_InDirectory_XHandle, nsfileExtension, nssubDirectory), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfileExtension);
			CFString.ReleaseNative (nssubDirectory);
			return ret!;
		}
		[Export ("pathsForResourcesOfType:inDirectory:forLocalization:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] PathsForResources (string? fileExtension, string? subDirectory, string? localizationName)
		{
			var nsfileExtension = CFString.CreateNative (fileExtension);
			var nssubDirectory = CFString.CreateNative (subDirectory);
			var nslocalizationName = CFString.CreateNative (localizationName);
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selPathsForResourcesOfType_InDirectory_ForLocalization_XHandle, nsfileExtension, nssubDirectory, nslocalizationName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selPathsForResourcesOfType_InDirectory_ForLocalization_XHandle, nsfileExtension, nssubDirectory, nslocalizationName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfileExtension);
			CFString.ReleaseNative (nssubDirectory);
			CFString.ReleaseNative (nslocalizationName);
			return ret!;
		}
		[Export ("unload")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Unload ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUnloadXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUnloadXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("URLForAuxiliaryExecutable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? UrlForAuxiliaryExecutable (string executable)
		{
			if (executable is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (executable));
			var nsexecutable = CFString.CreateNative (executable);
			NSUrl? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selURLForAuxiliaryExecutable_XHandle, nsexecutable), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selURLForAuxiliaryExecutable_XHandle, nsexecutable), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsexecutable);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSBundle[] AllBundles {
			get {
				return NSArray.FromArray<NSBundle>(_InternalAllBundles as NSArray)!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSBundle[] AllFrameworks {
			[Export ("allFrameworks")]
			get {
				NSBundle[]? ret;
				ret = CFArray.ArrayFromHandle<NSBundle>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selAllFrameworksXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? AppStoreReceiptUrl {
			[Export ("appStoreReceiptURL")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAppStoreReceiptURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAppStoreReceiptURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? BuiltInPluginsUrl {
			[Export ("builtInPlugInsURL")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBuiltInPlugInsURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBuiltInPlugInsURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? BuiltinPluginsPath {
			[Export ("builtInPlugInsPath")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBuiltInPlugInsPathXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBuiltInPlugInsPathXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? BundleIdentifier {
			[Export ("bundleIdentifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBundleIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBundleIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string BundlePath {
			[Export ("bundlePath")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBundlePathXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBundlePathXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl BundleUrl {
			[Export ("bundleURL")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBundleURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBundleURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? DevelopmentLocalization {
			[Export ("developmentLocalization")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDevelopmentLocalizationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDevelopmentLocalizationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? ExecutablePath {
			[Export ("executablePath")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selExecutablePathXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selExecutablePathXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? ExecutableUrl {
			[Export ("executableURL")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selExecutableURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selExecutableURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? InfoDictionary {
			[Export ("infoDictionary")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInfoDictionaryXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInfoDictionaryXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Whether this bundle is currently loaded.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsLoaded {
			[Export ("isLoaded")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsLoadedXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsLoadedXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] Localizations {
			[Export ("localizations")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizationsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizationsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSBundle MainBundle {
			[Export ("mainBundle")]
			get {
				NSBundle? ret;
				ret =  Runtime.GetNSObject<NSBundle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selMainBundleXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] PreferredLocalizations {
			[Export ("preferredLocalizations")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreferredLocalizationsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreferredLocalizationsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual Class? PrincipalClass {
			[Export ("principalClass")]
			get {
				Class ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPrincipalClassXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPrincipalClassXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? PrivateFrameworksPath {
			[Export ("privateFrameworksPath")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPrivateFrameworksPathXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPrivateFrameworksPathXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? PrivateFrameworksUrl {
			[Export ("privateFrameworksURL")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPrivateFrameworksURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPrivateFrameworksURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? ResourcePath {
			[Export ("resourcePath")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selResourcePathXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selResourcePathXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? ResourceUrl {
			[Export ("resourceURL")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selResourceURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selResourceURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? SharedFrameworksPath {
			[Export ("sharedFrameworksPath")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSharedFrameworksPathXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSharedFrameworksPathXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? SharedFrameworksUrl {
			[Export ("sharedFrameworksURL")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSharedFrameworksURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSharedFrameworksURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? SharedSupportPath {
			[Export ("sharedSupportPath")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSharedSupportPathXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSharedSupportPathXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? SharedSupportUrl {
			[Export ("sharedSupportURL")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSharedSupportURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSharedSupportURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>An array of all the application's non-framework bundles.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Obsolete ("Use the 'AllBundles' property instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public static NSBundle[] _AllBundles {
			get {
				return NSArray.FromArray<NSBundle>(_InternalAllBundles as NSArray)!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSArray _InternalAllBundles {
			[Export ("allBundles")]
			get {
				NSArray? ret;
				ret =  Runtime.GetNSObject<NSArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selAllBundlesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BundleDidLoadNotification;
		/// <summary>Notification constant for BundleDidLoad</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveBundleDidLoad(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveBundleDidLoad(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSBundle.Notifications.ObserveBundleDidLoad ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSBundle.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSBundle.Notifications.ObserveBundleDidLoad (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSBundle.BundleDidLoadNotification, (notification) => { Console.WriteLine ("Received the notification BundleDidLoad", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification BundleDidLoad", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSBundle.BundleDidLoadNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSBundleDidLoadNotification",  "Foundation")]
		[Advice ("Use NSBundle.Notifications.ObserveBundleDidLoad helper method instead.")]
		public static NSString BundleDidLoadNotification {
			get {
				if (_BundleDidLoadNotification is null)
					_BundleDidLoadNotification = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSBundleDidLoadNotification")!;
				return _BundleDidLoadNotification;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::Foundation.NSBundle" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::Foundation.NSBundle.BundleDidLoadNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Foundation.NSBundle.BundleDidLoadNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSBundle.Notifications.ObserveBundleDidLoad ((notification) => {
			///   Console.WriteLine ("Observed BundleDidLoadNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveBundleDidLoad (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (BundleDidLoadNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::Foundation.NSBundle.BundleDidLoadNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Foundation.NSBundle.BundleDidLoadNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSBundle.Notifications.ObserveBundleDidLoad (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed BundleDidLoadNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveBundleDidLoad (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (BundleDidLoadNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSBundle */
}
