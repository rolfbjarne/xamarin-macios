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
	[Register("NSLocale", true)]
	public unsafe partial class NSLocale : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selISOCountryCodesX = "ISOCountryCodes";
		static readonly NativeHandle selISOCountryCodesXHandle = Selector.GetHandle ("ISOCountryCodes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selISOCurrencyCodesX = "ISOCurrencyCodes";
		static readonly NativeHandle selISOCurrencyCodesXHandle = Selector.GetHandle ("ISOCurrencyCodes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selISOLanguageCodesX = "ISOLanguageCodes";
		static readonly NativeHandle selISOLanguageCodesXHandle = Selector.GetHandle ("ISOLanguageCodes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutoupdatingCurrentLocaleX = "autoupdatingCurrentLocale";
		static readonly NativeHandle selAutoupdatingCurrentLocaleXHandle = Selector.GetHandle ("autoupdatingCurrentLocale");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableLocaleIdentifiersX = "availableLocaleIdentifiers";
		static readonly NativeHandle selAvailableLocaleIdentifiersXHandle = Selector.GetHandle ("availableLocaleIdentifiers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCalendarIdentifierX = "calendarIdentifier";
		static readonly NativeHandle selCalendarIdentifierXHandle = Selector.GetHandle ("calendarIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanonicalLanguageIdentifierFromString_X = "canonicalLanguageIdentifierFromString:";
		static readonly NativeHandle selCanonicalLanguageIdentifierFromString_XHandle = Selector.GetHandle ("canonicalLanguageIdentifierFromString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanonicalLocaleIdentifierFromString_X = "canonicalLocaleIdentifierFromString:";
		static readonly NativeHandle selCanonicalLocaleIdentifierFromString_XHandle = Selector.GetHandle ("canonicalLocaleIdentifierFromString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCharacterDirectionForLanguage_X = "characterDirectionForLanguage:";
		static readonly NativeHandle selCharacterDirectionForLanguage_XHandle = Selector.GetHandle ("characterDirectionForLanguage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommonISOCurrencyCodesX = "commonISOCurrencyCodes";
		static readonly NativeHandle selCommonISOCurrencyCodesXHandle = Selector.GetHandle ("commonISOCurrencyCodes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComponentsFromLocaleIdentifier_X = "componentsFromLocaleIdentifier:";
		static readonly NativeHandle selComponentsFromLocaleIdentifier_XHandle = Selector.GetHandle ("componentsFromLocaleIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentLocaleX = "currentLocale";
		static readonly NativeHandle selCurrentLocaleXHandle = Selector.GetHandle ("currentLocale");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplayNameForKey_Value_X = "displayNameForKey:value:";
		static readonly NativeHandle selDisplayNameForKey_Value_XHandle = Selector.GetHandle ("displayNameForKey:value:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithLocaleIdentifier_X = "initWithLocaleIdentifier:";
		static readonly NativeHandle selInitWithLocaleIdentifier_XHandle = Selector.GetHandle ("initWithLocaleIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLanguageIdentifierX = "languageIdentifier";
		static readonly NativeHandle selLanguageIdentifierXHandle = Selector.GetHandle ("languageIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLineDirectionForLanguage_X = "lineDirectionForLanguage:";
		static readonly NativeHandle selLineDirectionForLanguage_XHandle = Selector.GetHandle ("lineDirectionForLanguage:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocaleIdentifierX = "localeIdentifier";
		static readonly NativeHandle selLocaleIdentifierXHandle = Selector.GetHandle ("localeIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocaleIdentifierFromComponents_X = "localeIdentifierFromComponents:";
		static readonly NativeHandle selLocaleIdentifierFromComponents_XHandle = Selector.GetHandle ("localeIdentifierFromComponents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocaleWithLocaleIdentifier_X = "localeWithLocaleIdentifier:";
		static readonly NativeHandle selLocaleWithLocaleIdentifier_XHandle = Selector.GetHandle ("localeWithLocaleIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedStringForCalendarIdentifier_X = "localizedStringForCalendarIdentifier:";
		static readonly NativeHandle selLocalizedStringForCalendarIdentifier_XHandle = Selector.GetHandle ("localizedStringForCalendarIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectForKey_X = "objectForKey:";
		static readonly NativeHandle selObjectForKey_XHandle = Selector.GetHandle ("objectForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredLanguagesX = "preferredLanguages";
		static readonly NativeHandle selPreferredLanguagesXHandle = Selector.GetHandle ("preferredLanguages");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegionCodeX = "regionCode";
		static readonly NativeHandle selRegionCodeXHandle = Selector.GetHandle ("regionCode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSystemLocaleX = "systemLocale";
		static readonly NativeHandle selSystemLocaleXHandle = Selector.GetHandle ("systemLocale");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSLocale");
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
		public NSLocale (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSLocale (NSObjectFlag t) : base (t)
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
		protected internal NSLocale (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithLocaleIdentifier:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSLocale (string identifier)
			: base (NSObjectFlag.Empty)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithLocaleIdentifier_XHandle, nsidentifier), "initWithLocaleIdentifier:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithLocaleIdentifier_XHandle, nsidentifier), "initWithLocaleIdentifier:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsidentifier);
		}
		[Export ("canonicalLanguageIdentifierFromString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string CanonicalLanguageIdentifierFromString (string str)
		{
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			var nsstr = CFString.CreateNative (str);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selCanonicalLanguageIdentifierFromString_XHandle, nsstr), false)!;
			CFString.ReleaseNative (nsstr);
			return ret!;
		}
		[Export ("canonicalLocaleIdentifierFromString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string CanonicalLocaleIdentifierFromString (string str)
		{
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			var nsstr = CFString.CreateNative (str);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selCanonicalLocaleIdentifierFromString_XHandle, nsstr), false)!;
			CFString.ReleaseNative (nsstr);
			return ret!;
		}
		[Export ("componentsFromLocaleIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary ComponentsFromLocaleIdentifier (string identifier)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			var nsidentifier = CFString.CreateNative (identifier);
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selComponentsFromLocaleIdentifier_XHandle, nsidentifier), false)!;
			CFString.ReleaseNative (nsidentifier);
			return ret!;
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("displayNameForKey:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NSString? DisplayNameForKey (NSString key, string value)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsvalue = CFString.CreateNative (value);
			NSString? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selDisplayNameForKey_Value_XHandle, key__handle__, nsvalue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selDisplayNameForKey_Value_XHandle, key__handle__, nsvalue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
			CFString.ReleaseNative (nsvalue);
			return ret!;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
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
		[Export ("localeWithLocaleIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSLocale FromLocaleIdentifier (string ident)
		{
			if (ident is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ident));
			var nsident = CFString.CreateNative (ident);
			NSLocale? ret;
			ret =  Runtime.GetNSObject<NSLocale> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selLocaleWithLocaleIdentifier_XHandle, nsident), false)!;
			CFString.ReleaseNative (nsident);
			return ret!;
		}
		[Export ("characterDirectionForLanguage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSLocaleLanguageDirection GetCharacterDirection (string isoLanguageCode)
		{
			if (isoLanguageCode is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (isoLanguageCode));
			var nsisoLanguageCode = CFString.CreateNative (isoLanguageCode);
			NSLocaleLanguageDirection ret;
			ret = (NSLocaleLanguageDirection) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (class_ptr, selCharacterDirectionForLanguage_XHandle, nsisoLanguageCode);
			CFString.ReleaseNative (nsisoLanguageCode);
			return ret!;
		}
		[Export ("lineDirectionForLanguage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSLocaleLanguageDirection GetLineDirection (string isoLanguageCode)
		{
			if (isoLanguageCode is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (isoLanguageCode));
			var nsisoLanguageCode = CFString.CreateNative (isoLanguageCode);
			NSLocaleLanguageDirection ret;
			ret = (NSLocaleLanguageDirection) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_NativeHandle (class_ptr, selLineDirectionForLanguage_XHandle, nsisoLanguageCode);
			CFString.ReleaseNative (nsisoLanguageCode);
			return ret!;
		}
		[Export ("localizedStringForCalendarIdentifier:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetLocalizedCalendarIdentifier (string calendarIdentifier)
		{
			if (calendarIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (calendarIdentifier));
			var nscalendarIdentifier = CFString.CreateNative (calendarIdentifier);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selLocalizedStringForCalendarIdentifier_XHandle, nscalendarIdentifier), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selLocalizedStringForCalendarIdentifier_XHandle, nscalendarIdentifier), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscalendarIdentifier);
			return ret!;
		}
		[Export ("localeIdentifierFromComponents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string LocaleIdentifierFromComponents (NSDictionary dict)
		{
			var dict__handle__ = dict!.GetNonNullHandle (nameof (dict));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selLocaleIdentifierFromComponents_XHandle, dict__handle__), false)!;
			GC.KeepAlive (dict);
			return ret!;
		}
		[Export ("objectForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NSObject? ObjectForKey (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selObjectForKey_XHandle, key__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selObjectForKey_XHandle, key__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSLocale AutoUpdatingCurrentLocale {
			[Export ("autoupdatingCurrentLocale", ArgumentSemantic.Retain)]
			get {
				NSLocale? ret;
				ret =  Runtime.GetNSObject<NSLocale> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selAutoupdatingCurrentLocaleXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] AvailableLocaleIdentifiers {
			[Export ("availableLocaleIdentifiers", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selAvailableLocaleIdentifiersXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual string CalendarIdentifier {
			[Export ("calendarIdentifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCalendarIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCalendarIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] CommonISOCurrencyCodes {
			[Export ("commonISOCurrencyCodes", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCommonISOCurrencyCodesXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSLocale CurrentLocale {
			[Export ("currentLocale", ArgumentSemantic.Copy)]
			get {
				NSLocale? ret;
				ret =  Runtime.GetNSObject<NSLocale> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCurrentLocaleXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] ISOCountryCodes {
			[Export ("ISOCountryCodes", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selISOCountryCodesXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] ISOCurrencyCodes {
			[Export ("ISOCurrencyCodes", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selISOCurrencyCodesXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] ISOLanguageCodes {
			[Export ("ISOLanguageCodes", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selISOLanguageCodesXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public virtual string LanguageIdentifier {
			[Export ("languageIdentifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLanguageIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLanguageIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string LocaleIdentifier {
			[Export ("localeIdentifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocaleIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocaleIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] PreferredLanguages {
			[Export ("preferredLanguages", ArgumentSemantic.Copy)]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selPreferredLanguagesXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public virtual string? RegionCode {
			[Export ("regionCode")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRegionCodeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRegionCodeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSLocale SystemLocale {
			[Export ("systemLocale", ArgumentSemantic.Copy)]
			get {
				NSLocale? ret;
				ret =  Runtime.GetNSObject<NSLocale> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSystemLocaleXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CurrentLocaleDidChangeNotification;
		/// <summary>Notification constant for CurrentLocaleDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveCurrentLocaleDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveCurrentLocaleDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSLocale.Notifications.ObserveCurrentLocaleDidChange ((sender, args) => {
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
		/// void Callback (object sender, NSLocale.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSLocale.Notifications.ObserveCurrentLocaleDidChange (Callback);
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
		///     NSLocale.CurrentLocaleDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification CurrentLocaleDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification CurrentLocaleDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSLocale.CurrentLocaleDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSCurrentLocaleDidChangeNotification",  "Foundation")]
		[Advice ("Use NSLocale.Notifications.ObserveCurrentLocaleDidChange helper method instead.")]
		public static NSString CurrentLocaleDidChangeNotification {
			get {
				if (_CurrentLocaleDidChangeNotification is null)
					_CurrentLocaleDidChangeNotification = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSCurrentLocaleDidChangeNotification")!;
				return _CurrentLocaleDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __AlternateQuotationBeginDelimiterKey;
		/// <summary>Represents the value associated with the constant 'NSLocaleAlternateQuotationBeginDelimiterKey'.</summary>
		[Field ("NSLocaleAlternateQuotationBeginDelimiterKey",  "Foundation")]
		internal static NSString _AlternateQuotationBeginDelimiterKey {
			get {
				if (__AlternateQuotationBeginDelimiterKey is null)
					__AlternateQuotationBeginDelimiterKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocaleAlternateQuotationBeginDelimiterKey")!;
				return __AlternateQuotationBeginDelimiterKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __AlternateQuotationEndDelimiterKey;
		/// <summary>Represents the value associated with the constant 'NSLocaleAlternateQuotationEndDelimiterKey'.</summary>
		[Field ("NSLocaleAlternateQuotationEndDelimiterKey",  "Foundation")]
		internal static NSString _AlternateQuotationEndDelimiterKey {
			get {
				if (__AlternateQuotationEndDelimiterKey is null)
					__AlternateQuotationEndDelimiterKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocaleAlternateQuotationEndDelimiterKey")!;
				return __AlternateQuotationEndDelimiterKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __Calendar;
		/// <summary>Represents the value associated with the constant 'NSLocaleCalendar'.</summary>
		[Field ("NSLocaleCalendar",  "Foundation")]
		internal static NSString _Calendar {
			get {
				if (__Calendar is null)
					__Calendar = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocaleCalendar")!;
				return __Calendar;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __CollationIdentifier;
		/// <summary>Represents the value associated with the constant 'NSLocaleCollationIdentifier'.</summary>
		[Field ("NSLocaleCollationIdentifier",  "Foundation")]
		internal static NSString _CollationIdentifier {
			get {
				if (__CollationIdentifier is null)
					__CollationIdentifier = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocaleCollationIdentifier")!;
				return __CollationIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __CollatorIdentifier;
		/// <summary>Represents the value associated with the constant 'NSLocaleCollatorIdentifier'.</summary>
		[Field ("NSLocaleCollatorIdentifier",  "Foundation")]
		internal static NSString _CollatorIdentifier {
			get {
				if (__CollatorIdentifier is null)
					__CollatorIdentifier = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocaleCollatorIdentifier")!;
				return __CollatorIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __CountryCode;
		/// <summary>Represents the value associated with the constant 'NSLocaleCountryCode'.</summary>
		[Field ("NSLocaleCountryCode",  "Foundation")]
		internal static NSString _CountryCode {
			get {
				if (__CountryCode is null)
					__CountryCode = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocaleCountryCode")!;
				return __CountryCode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __CurrencyCode;
		/// <summary>Represents the value associated with the constant 'NSLocaleCurrencyCode'.</summary>
		[Field ("NSLocaleCurrencyCode",  "Foundation")]
		internal static NSString _CurrencyCode {
			get {
				if (__CurrencyCode is null)
					__CurrencyCode = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocaleCurrencyCode")!;
				return __CurrencyCode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __CurrencySymbol;
		/// <summary>Represents the value associated with the constant 'NSLocaleCurrencySymbol'.</summary>
		[Field ("NSLocaleCurrencySymbol",  "Foundation")]
		internal static NSString _CurrencySymbol {
			get {
				if (__CurrencySymbol is null)
					__CurrencySymbol = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocaleCurrencySymbol")!;
				return __CurrencySymbol;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __DecimalSeparator;
		/// <summary>Represents the value associated with the constant 'NSLocaleDecimalSeparator'.</summary>
		[Field ("NSLocaleDecimalSeparator",  "Foundation")]
		internal static NSString _DecimalSeparator {
			get {
				if (__DecimalSeparator is null)
					__DecimalSeparator = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocaleDecimalSeparator")!;
				return __DecimalSeparator;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __ExemplarCharacterSet;
		/// <summary>Represents the value associated with the constant 'NSLocaleExemplarCharacterSet'.</summary>
		[Field ("NSLocaleExemplarCharacterSet",  "Foundation")]
		internal static NSString _ExemplarCharacterSet {
			get {
				if (__ExemplarCharacterSet is null)
					__ExemplarCharacterSet = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocaleExemplarCharacterSet")!;
				return __ExemplarCharacterSet;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __GroupingSeparator;
		/// <summary>Represents the value associated with the constant 'NSLocaleGroupingSeparator'.</summary>
		[Field ("NSLocaleGroupingSeparator",  "Foundation")]
		internal static NSString _GroupingSeparator {
			get {
				if (__GroupingSeparator is null)
					__GroupingSeparator = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocaleGroupingSeparator")!;
				return __GroupingSeparator;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __Identifier;
		/// <summary>Represents the value associated with the constant 'NSLocaleIdentifier'.</summary>
		[Field ("NSLocaleIdentifier",  "Foundation")]
		internal static NSString _Identifier {
			get {
				if (__Identifier is null)
					__Identifier = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocaleIdentifier")!;
				return __Identifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __LanguageCode;
		/// <summary>Represents the value associated with the constant 'NSLocaleLanguageCode'.</summary>
		[Field ("NSLocaleLanguageCode",  "Foundation")]
		internal static NSString _LanguageCode {
			get {
				if (__LanguageCode is null)
					__LanguageCode = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocaleLanguageCode")!;
				return __LanguageCode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __MeasurementSystem;
		/// <summary>Represents the value associated with the constant 'NSLocaleMeasurementSystem'.</summary>
		[Field ("NSLocaleMeasurementSystem",  "Foundation")]
		internal static NSString _MeasurementSystem {
			get {
				if (__MeasurementSystem is null)
					__MeasurementSystem = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocaleMeasurementSystem")!;
				return __MeasurementSystem;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __QuotationBeginDelimiterKey;
		/// <summary>Represents the value associated with the constant 'NSLocaleQuotationBeginDelimiterKey'.</summary>
		[Field ("NSLocaleQuotationBeginDelimiterKey",  "Foundation")]
		internal static NSString _QuotationBeginDelimiterKey {
			get {
				if (__QuotationBeginDelimiterKey is null)
					__QuotationBeginDelimiterKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocaleQuotationBeginDelimiterKey")!;
				return __QuotationBeginDelimiterKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __QuotationEndDelimiterKey;
		/// <summary>Represents the value associated with the constant 'NSLocaleQuotationEndDelimiterKey'.</summary>
		[Field ("NSLocaleQuotationEndDelimiterKey",  "Foundation")]
		internal static NSString _QuotationEndDelimiterKey {
			get {
				if (__QuotationEndDelimiterKey is null)
					__QuotationEndDelimiterKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocaleQuotationEndDelimiterKey")!;
				return __QuotationEndDelimiterKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __ScriptCode;
		/// <summary>Represents the value associated with the constant 'NSLocaleScriptCode'.</summary>
		[Field ("NSLocaleScriptCode",  "Foundation")]
		internal static NSString _ScriptCode {
			get {
				if (__ScriptCode is null)
					__ScriptCode = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocaleScriptCode")!;
				return __ScriptCode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __UsesMetricSystem;
		/// <summary>Represents the value associated with the constant 'NSLocaleUsesMetricSystem'.</summary>
		[Field ("NSLocaleUsesMetricSystem",  "Foundation")]
		internal static NSString _UsesMetricSystem {
			get {
				if (__UsesMetricSystem is null)
					__UsesMetricSystem = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocaleUsesMetricSystem")!;
				return __UsesMetricSystem;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? __VariantCode;
		/// <summary>Represents the value associated with the constant 'NSLocaleVariantCode'.</summary>
		[Field ("NSLocaleVariantCode",  "Foundation")]
		internal static NSString _VariantCode {
			get {
				if (__VariantCode is null)
					__VariantCode = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocaleVariantCode")!;
				return __VariantCode;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::Foundation.NSLocale" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::Foundation.NSLocale.CurrentLocaleDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Foundation.NSLocale.CurrentLocaleDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSLocale.Notifications.ObserveCurrentLocaleDidChange ((notification) => {
			///   Console.WriteLine ("Observed CurrentLocaleDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveCurrentLocaleDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (CurrentLocaleDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::Foundation.NSLocale.CurrentLocaleDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Foundation.NSLocale.CurrentLocaleDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSLocale.Notifications.ObserveCurrentLocaleDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed CurrentLocaleDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveCurrentLocaleDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (CurrentLocaleDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSLocale */
}
