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
namespace WebKit {
	[Register("WebPreferences", true)]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos10.14", "No longer supported.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class WebPreferences : NSObject, INSCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsAnimatedImageLoopingX = "allowsAnimatedImageLooping";
		static readonly NativeHandle selAllowsAnimatedImageLoopingXHandle = Selector.GetHandle ("allowsAnimatedImageLooping");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowsAnimatedImagesX = "allowsAnimatedImages";
		static readonly NativeHandle selAllowsAnimatedImagesXHandle = Selector.GetHandle ("allowsAnimatedImages");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selArePlugInsEnabledX = "arePlugInsEnabled";
		static readonly NativeHandle selArePlugInsEnabledXHandle = Selector.GetHandle ("arePlugInsEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutosavesX = "autosaves";
		static readonly NativeHandle selAutosavesXHandle = Selector.GetHandle ("autosaves");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCacheModelX = "cacheModel";
		static readonly NativeHandle selCacheModelXHandle = Selector.GetHandle ("cacheModel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCursiveFontFamilyX = "cursiveFontFamily";
		static readonly NativeHandle selCursiveFontFamilyXHandle = Selector.GetHandle ("cursiveFontFamily");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultFixedFontSizeX = "defaultFixedFontSize";
		static readonly NativeHandle selDefaultFixedFontSizeXHandle = Selector.GetHandle ("defaultFixedFontSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultFontSizeX = "defaultFontSize";
		static readonly NativeHandle selDefaultFontSizeXHandle = Selector.GetHandle ("defaultFontSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultTextEncodingNameX = "defaultTextEncodingName";
		static readonly NativeHandle selDefaultTextEncodingNameXHandle = Selector.GetHandle ("defaultTextEncodingName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFantasyFontFamilyX = "fantasyFontFamily";
		static readonly NativeHandle selFantasyFontFamilyXHandle = Selector.GetHandle ("fantasyFontFamily");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFixedFontFamilyX = "fixedFontFamily";
		static readonly NativeHandle selFixedFontFamilyXHandle = Selector.GetHandle ("fixedFontFamily");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIdentifierX = "identifier";
		static readonly NativeHandle selIdentifierXHandle = Selector.GetHandle ("identifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithIdentifier_X = "initWithIdentifier:";
		static readonly NativeHandle selInitWithIdentifier_XHandle = Selector.GetHandle ("initWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsJavaEnabledX = "isJavaEnabled";
		static readonly NativeHandle selIsJavaEnabledXHandle = Selector.GetHandle ("isJavaEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsJavaScriptEnabledX = "isJavaScriptEnabled";
		static readonly NativeHandle selIsJavaScriptEnabledXHandle = Selector.GetHandle ("isJavaScriptEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selJavaScriptCanOpenWindowsAutomaticallyX = "javaScriptCanOpenWindowsAutomatically";
		static readonly NativeHandle selJavaScriptCanOpenWindowsAutomaticallyXHandle = Selector.GetHandle ("javaScriptCanOpenWindowsAutomatically");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadsImagesAutomaticallyX = "loadsImagesAutomatically";
		static readonly NativeHandle selLoadsImagesAutomaticallyXHandle = Selector.GetHandle ("loadsImagesAutomatically");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumFontSizeX = "minimumFontSize";
		static readonly NativeHandle selMinimumFontSizeXHandle = Selector.GetHandle ("minimumFontSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumLogicalFontSizeX = "minimumLogicalFontSize";
		static readonly NativeHandle selMinimumLogicalFontSizeXHandle = Selector.GetHandle ("minimumLogicalFontSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrivateBrowsingEnabledX = "privateBrowsingEnabled";
		static readonly NativeHandle selPrivateBrowsingEnabledXHandle = Selector.GetHandle ("privateBrowsingEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSansSerifFontFamilyX = "sansSerifFontFamily";
		static readonly NativeHandle selSansSerifFontFamilyXHandle = Selector.GetHandle ("sansSerifFontFamily");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSerifFontFamilyX = "serifFontFamily";
		static readonly NativeHandle selSerifFontFamilyXHandle = Selector.GetHandle ("serifFontFamily");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsAnimatedImageLooping_X = "setAllowsAnimatedImageLooping:";
		static readonly NativeHandle selSetAllowsAnimatedImageLooping_XHandle = Selector.GetHandle ("setAllowsAnimatedImageLooping:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowsAnimatedImages_X = "setAllowsAnimatedImages:";
		static readonly NativeHandle selSetAllowsAnimatedImages_XHandle = Selector.GetHandle ("setAllowsAnimatedImages:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAutosaves_X = "setAutosaves:";
		static readonly NativeHandle selSetAutosaves_XHandle = Selector.GetHandle ("setAutosaves:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCacheModel_X = "setCacheModel:";
		static readonly NativeHandle selSetCacheModel_XHandle = Selector.GetHandle ("setCacheModel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCursiveFontFamily_X = "setCursiveFontFamily:";
		static readonly NativeHandle selSetCursiveFontFamily_XHandle = Selector.GetHandle ("setCursiveFontFamily:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultFixedFontSize_X = "setDefaultFixedFontSize:";
		static readonly NativeHandle selSetDefaultFixedFontSize_XHandle = Selector.GetHandle ("setDefaultFixedFontSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultFontSize_X = "setDefaultFontSize:";
		static readonly NativeHandle selSetDefaultFontSize_XHandle = Selector.GetHandle ("setDefaultFontSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultTextEncodingName_X = "setDefaultTextEncodingName:";
		static readonly NativeHandle selSetDefaultTextEncodingName_XHandle = Selector.GetHandle ("setDefaultTextEncodingName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFantasyFontFamily_X = "setFantasyFontFamily:";
		static readonly NativeHandle selSetFantasyFontFamily_XHandle = Selector.GetHandle ("setFantasyFontFamily:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFixedFontFamily_X = "setFixedFontFamily:";
		static readonly NativeHandle selSetFixedFontFamily_XHandle = Selector.GetHandle ("setFixedFontFamily:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetJavaEnabled_X = "setJavaEnabled:";
		static readonly NativeHandle selSetJavaEnabled_XHandle = Selector.GetHandle ("setJavaEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetJavaScriptCanOpenWindowsAutomatically_X = "setJavaScriptCanOpenWindowsAutomatically:";
		static readonly NativeHandle selSetJavaScriptCanOpenWindowsAutomatically_XHandle = Selector.GetHandle ("setJavaScriptCanOpenWindowsAutomatically:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetJavaScriptEnabled_X = "setJavaScriptEnabled:";
		static readonly NativeHandle selSetJavaScriptEnabled_XHandle = Selector.GetHandle ("setJavaScriptEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLoadsImagesAutomatically_X = "setLoadsImagesAutomatically:";
		static readonly NativeHandle selSetLoadsImagesAutomatically_XHandle = Selector.GetHandle ("setLoadsImagesAutomatically:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMinimumFontSize_X = "setMinimumFontSize:";
		static readonly NativeHandle selSetMinimumFontSize_XHandle = Selector.GetHandle ("setMinimumFontSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMinimumLogicalFontSize_X = "setMinimumLogicalFontSize:";
		static readonly NativeHandle selSetMinimumLogicalFontSize_XHandle = Selector.GetHandle ("setMinimumLogicalFontSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPlugInsEnabled_X = "setPlugInsEnabled:";
		static readonly NativeHandle selSetPlugInsEnabled_XHandle = Selector.GetHandle ("setPlugInsEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPrivateBrowsingEnabled_X = "setPrivateBrowsingEnabled:";
		static readonly NativeHandle selSetPrivateBrowsingEnabled_XHandle = Selector.GetHandle ("setPrivateBrowsingEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSansSerifFontFamily_X = "setSansSerifFontFamily:";
		static readonly NativeHandle selSetSansSerifFontFamily_XHandle = Selector.GetHandle ("setSansSerifFontFamily:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSerifFontFamily_X = "setSerifFontFamily:";
		static readonly NativeHandle selSetSerifFontFamily_XHandle = Selector.GetHandle ("setSerifFontFamily:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShouldPrintBackgrounds_X = "setShouldPrintBackgrounds:";
		static readonly NativeHandle selSetShouldPrintBackgrounds_XHandle = Selector.GetHandle ("setShouldPrintBackgrounds:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStandardFontFamily_X = "setStandardFontFamily:";
		static readonly NativeHandle selSetStandardFontFamily_XHandle = Selector.GetHandle ("setStandardFontFamily:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTabsToLinks_X = "setTabsToLinks:";
		static readonly NativeHandle selSetTabsToLinks_XHandle = Selector.GetHandle ("setTabsToLinks:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUserStyleSheetEnabled_X = "setUserStyleSheetEnabled:";
		static readonly NativeHandle selSetUserStyleSheetEnabled_XHandle = Selector.GetHandle ("setUserStyleSheetEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUserStyleSheetLocation_X = "setUserStyleSheetLocation:";
		static readonly NativeHandle selSetUserStyleSheetLocation_XHandle = Selector.GetHandle ("setUserStyleSheetLocation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsesPageCache_X = "setUsesPageCache:";
		static readonly NativeHandle selSetUsesPageCache_XHandle = Selector.GetHandle ("setUsesPageCache:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShouldPrintBackgroundsX = "shouldPrintBackgrounds";
		static readonly NativeHandle selShouldPrintBackgroundsXHandle = Selector.GetHandle ("shouldPrintBackgrounds");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStandardFontFamilyX = "standardFontFamily";
		static readonly NativeHandle selStandardFontFamilyXHandle = Selector.GetHandle ("standardFontFamily");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStandardPreferencesX = "standardPreferences";
		static readonly NativeHandle selStandardPreferencesXHandle = Selector.GetHandle ("standardPreferences");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTabsToLinksX = "tabsToLinks";
		static readonly NativeHandle selTabsToLinksXHandle = Selector.GetHandle ("tabsToLinks");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserStyleSheetEnabledX = "userStyleSheetEnabled";
		static readonly NativeHandle selUserStyleSheetEnabledXHandle = Selector.GetHandle ("userStyleSheetEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserStyleSheetLocationX = "userStyleSheetLocation";
		static readonly NativeHandle selUserStyleSheetLocationXHandle = Selector.GetHandle ("userStyleSheetLocation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsesPageCacheX = "usesPageCache";
		static readonly NativeHandle selUsesPageCacheXHandle = Selector.GetHandle ("usesPageCache");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("WebPreferences");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="WebPreferences" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WebPreferences () : base (NSObjectFlag.Empty)
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
		public WebPreferences (NSCoder coder) : base (NSObjectFlag.Empty)
		{
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
		protected WebPreferences (NSObjectFlag t) : base (t)
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
		protected internal WebPreferences (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public WebPreferences (string identifier)
			: base (NSObjectFlag.Empty)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithIdentifier_XHandle, nsidentifier), "initWithIdentifier:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithIdentifier_XHandle, nsidentifier), "initWithIdentifier:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsidentifier);
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "No longer supported.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeWithCoder_XHandle, encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeWithCoder_XHandle, encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsAnimatedImageLooping {
			[Export ("allowsAnimatedImageLooping")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsAnimatedImageLoopingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsAnimatedImageLoopingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsAnimatedImageLooping:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsAnimatedImageLooping_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsAnimatedImageLooping_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowsAnimatedImages {
			[Export ("allowsAnimatedImages")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAllowsAnimatedImagesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAllowsAnimatedImagesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAllowsAnimatedImages:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAllowsAnimatedImages_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAllowsAnimatedImages_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Autosaves {
			[Export ("autosaves")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selAutosavesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selAutosavesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAutosaves:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetAutosaves_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetAutosaves_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebCacheModel CacheModel {
			[Export ("cacheModel")]
			get {
				WebCacheModel ret;
				if (IsDirectBinding) {
					ret = (WebKit.WebCacheModel) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selCacheModelXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (WebKit.WebCacheModel) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selCacheModelXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setCacheModel:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetCacheModel_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetCacheModel_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string CursiveFontFamily {
			[Export ("cursiveFontFamily")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCursiveFontFamilyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCursiveFontFamilyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCursiveFontFamily:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCursiveFontFamily_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCursiveFontFamily_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int DefaultFixedFontSize {
			[Export ("defaultFixedFontSize")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selDefaultFixedFontSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selDefaultFixedFontSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDefaultFixedFontSize:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetDefaultFixedFontSize_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int (&__objc_super__, selSetDefaultFixedFontSize_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int DefaultFontSize {
			[Export ("defaultFontSize")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selDefaultFontSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selDefaultFontSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDefaultFontSize:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetDefaultFontSize_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int (&__objc_super__, selSetDefaultFontSize_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DefaultTextEncodingName {
			[Export ("defaultTextEncodingName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDefaultTextEncodingNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDefaultTextEncodingNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDefaultTextEncodingName:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDefaultTextEncodingName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDefaultTextEncodingName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string FantasyFontFamily {
			[Export ("fantasyFontFamily")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFantasyFontFamilyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFantasyFontFamilyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFantasyFontFamily:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFantasyFontFamily_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFantasyFontFamily_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string FixedFontFamily {
			[Export ("fixedFontFamily")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFixedFontFamilyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFixedFontFamilyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFixedFontFamily:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFixedFontFamily_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFixedFontFamily_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Identifier {
			[Export ("identifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool JavaEnabled {
			[Export ("isJavaEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsJavaEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsJavaEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setJavaEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetJavaEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetJavaEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool JavaScriptCanOpenWindowsAutomatically {
			[Export ("javaScriptCanOpenWindowsAutomatically")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selJavaScriptCanOpenWindowsAutomaticallyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selJavaScriptCanOpenWindowsAutomaticallyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setJavaScriptCanOpenWindowsAutomatically:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetJavaScriptCanOpenWindowsAutomatically_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetJavaScriptCanOpenWindowsAutomatically_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool JavaScriptEnabled {
			[Export ("isJavaScriptEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsJavaScriptEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsJavaScriptEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setJavaScriptEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetJavaScriptEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetJavaScriptEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool LoadsImagesAutomatically {
			[Export ("loadsImagesAutomatically")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selLoadsImagesAutomaticallyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selLoadsImagesAutomaticallyXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setLoadsImagesAutomatically:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetLoadsImagesAutomatically_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetLoadsImagesAutomatically_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int MinimumFontSize {
			[Export ("minimumFontSize")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selMinimumFontSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selMinimumFontSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinimumFontSize:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetMinimumFontSize_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int (&__objc_super__, selSetMinimumFontSize_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int MinimumLogicalFontSize {
			[Export ("minimumLogicalFontSize")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selMinimumLogicalFontSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selMinimumLogicalFontSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMinimumLogicalFontSize:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetMinimumLogicalFontSize_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int (&__objc_super__, selSetMinimumLogicalFontSize_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PlugInsEnabled {
			[Export ("arePlugInsEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selArePlugInsEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selArePlugInsEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPlugInsEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPlugInsEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetPlugInsEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PrivateBrowsingEnabled {
			[Export ("privateBrowsingEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selPrivateBrowsingEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selPrivateBrowsingEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setPrivateBrowsingEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPrivateBrowsingEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetPrivateBrowsingEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string SansSerifFontFamily {
			[Export ("sansSerifFontFamily")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSansSerifFontFamilyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSansSerifFontFamilyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSansSerifFontFamily:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSansSerifFontFamily_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSansSerifFontFamily_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string SerifFontFamily {
			[Export ("serifFontFamily")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSerifFontFamilyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSerifFontFamilyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSerifFontFamily:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSerifFontFamily_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSerifFontFamily_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldPrintBackgrounds {
			[Export ("shouldPrintBackgrounds")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldPrintBackgroundsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selShouldPrintBackgroundsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShouldPrintBackgrounds:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldPrintBackgrounds_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetShouldPrintBackgrounds_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string StandardFontFamily {
			[Export ("standardFontFamily")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStandardFontFamilyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStandardFontFamilyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setStandardFontFamily:")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetStandardFontFamily_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetStandardFontFamily_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static WebPreferences StandardPreferences {
			[Export ("standardPreferences")]
			get {
				WebPreferences? ret;
				ret =  Runtime.GetNSObject<WebPreferences> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selStandardPreferencesXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TabsToLinks {
			[Export ("tabsToLinks")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selTabsToLinksXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selTabsToLinksXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setTabsToLinks:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetTabsToLinks_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetTabsToLinks_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UserStyleSheetEnabled {
			[Export ("userStyleSheetEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUserStyleSheetEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUserStyleSheetEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUserStyleSheetEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUserStyleSheetEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUserStyleSheetEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl UserStyleSheetLocation {
			[Export ("userStyleSheetLocation", ArgumentSemantic.Retain)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUserStyleSheetLocationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUserStyleSheetLocationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setUserStyleSheetLocation:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetUserStyleSheetLocation_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetUserStyleSheetLocation_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UsesPageCache {
			[Export ("usesPageCache")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUsesPageCacheXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUsesPageCacheXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUsesPageCache:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUsesPageCache_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUsesPageCache_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class WebPreferences */
}
