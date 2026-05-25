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
	[Register("NSTextCheckingResult", true)]
	public unsafe partial class NSTextCheckingResult : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLX = "URL";
		static readonly NativeHandle selURLXHandle = Selector.GetHandle ("URL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddressCheckingResultWithRange_Components_X = "addressCheckingResultWithRange:components:";
		static readonly NativeHandle selAddressCheckingResultWithRange_Components_XHandle = Selector.GetHandle ("addressCheckingResultWithRange:components:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddressComponentsX = "addressComponents";
		static readonly NativeHandle selAddressComponentsXHandle = Selector.GetHandle ("addressComponents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlternativeStringsX = "alternativeStrings";
		static readonly NativeHandle selAlternativeStringsXHandle = Selector.GetHandle ("alternativeStrings");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComponentsX = "components";
		static readonly NativeHandle selComponentsXHandle = Selector.GetHandle ("components");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCorrectionCheckingResultWithRange_ReplacementString_X = "correctionCheckingResultWithRange:replacementString:";
		static readonly NativeHandle selCorrectionCheckingResultWithRange_ReplacementString_XHandle = Selector.GetHandle ("correctionCheckingResultWithRange:replacementString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCorrectionCheckingResultWithRange_ReplacementString_AlternativeStrings_X = "correctionCheckingResultWithRange:replacementString:alternativeStrings:";
		static readonly NativeHandle selCorrectionCheckingResultWithRange_ReplacementString_AlternativeStrings_XHandle = Selector.GetHandle ("correctionCheckingResultWithRange:replacementString:alternativeStrings:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDashCheckingResultWithRange_ReplacementString_X = "dashCheckingResultWithRange:replacementString:";
		static readonly NativeHandle selDashCheckingResultWithRange_ReplacementString_XHandle = Selector.GetHandle ("dashCheckingResultWithRange:replacementString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDateX = "date";
		static readonly NativeHandle selDateXHandle = Selector.GetHandle ("date");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDateCheckingResultWithRange_Date_X = "dateCheckingResultWithRange:date:";
		static readonly NativeHandle selDateCheckingResultWithRange_Date_XHandle = Selector.GetHandle ("dateCheckingResultWithRange:date:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDateCheckingResultWithRange_Date_TimeZone_Duration_X = "dateCheckingResultWithRange:date:timeZone:duration:";
		static readonly NativeHandle selDateCheckingResultWithRange_Date_TimeZone_Duration_XHandle = Selector.GetHandle ("dateCheckingResultWithRange:date:timeZone:duration:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDurationX = "duration";
		static readonly NativeHandle selDurationXHandle = Selector.GetHandle ("duration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGrammarCheckingResultWithRange_Details_X = "grammarCheckingResultWithRange:details:";
		static readonly NativeHandle selGrammarCheckingResultWithRange_Details_XHandle = Selector.GetHandle ("grammarCheckingResultWithRange:details:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGrammarDetailsX = "grammarDetails";
		static readonly NativeHandle selGrammarDetailsXHandle = Selector.GetHandle ("grammarDetails");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLinkCheckingResultWithRange_URL_X = "linkCheckingResultWithRange:URL:";
		static readonly NativeHandle selLinkCheckingResultWithRange_URL_XHandle = Selector.GetHandle ("linkCheckingResultWithRange:URL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfRangesX = "numberOfRanges";
		static readonly NativeHandle selNumberOfRangesXHandle = Selector.GetHandle ("numberOfRanges");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOrthographyX = "orthography";
		static readonly NativeHandle selOrthographyXHandle = Selector.GetHandle ("orthography");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOrthographyCheckingResultWithRange_Orthography_X = "orthographyCheckingResultWithRange:orthography:";
		static readonly NativeHandle selOrthographyCheckingResultWithRange_Orthography_XHandle = Selector.GetHandle ("orthographyCheckingResultWithRange:orthography:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPhoneNumberX = "phoneNumber";
		static readonly NativeHandle selPhoneNumberXHandle = Selector.GetHandle ("phoneNumber");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPhoneNumberCheckingResultWithRange_PhoneNumber_X = "phoneNumberCheckingResultWithRange:phoneNumber:";
		static readonly NativeHandle selPhoneNumberCheckingResultWithRange_PhoneNumber_XHandle = Selector.GetHandle ("phoneNumberCheckingResultWithRange:phoneNumber:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQuoteCheckingResultWithRange_ReplacementString_X = "quoteCheckingResultWithRange:replacementString:";
		static readonly NativeHandle selQuoteCheckingResultWithRange_ReplacementString_XHandle = Selector.GetHandle ("quoteCheckingResultWithRange:replacementString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangeX = "range";
		static readonly NativeHandle selRangeXHandle = Selector.GetHandle ("range");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangeAtIndex_X = "rangeAtIndex:";
		static readonly NativeHandle selRangeAtIndex_XHandle = Selector.GetHandle ("rangeAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRangeWithName_X = "rangeWithName:";
		static readonly NativeHandle selRangeWithName_XHandle = Selector.GetHandle ("rangeWithName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplacementCheckingResultWithRange_ReplacementString_X = "replacementCheckingResultWithRange:replacementString:";
		static readonly NativeHandle selReplacementCheckingResultWithRange_ReplacementString_XHandle = Selector.GetHandle ("replacementCheckingResultWithRange:replacementString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplacementStringX = "replacementString";
		static readonly NativeHandle selReplacementStringXHandle = Selector.GetHandle ("replacementString");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultByAdjustingRangesWithOffset_X = "resultByAdjustingRangesWithOffset:";
		static readonly NativeHandle selResultByAdjustingRangesWithOffset_XHandle = Selector.GetHandle ("resultByAdjustingRangesWithOffset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultTypeX = "resultType";
		static readonly NativeHandle selResultTypeXHandle = Selector.GetHandle ("resultType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpellCheckingResultWithRange_X = "spellCheckingResultWithRange:";
		static readonly NativeHandle selSpellCheckingResultWithRange_XHandle = Selector.GetHandle ("spellCheckingResultWithRange:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimeZoneX = "timeZone";
		static readonly NativeHandle selTimeZoneXHandle = Selector.GetHandle ("timeZone");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransitInformationCheckingResultWithRange_Components_X = "transitInformationCheckingResultWithRange:components:";
		static readonly NativeHandle selTransitInformationCheckingResultWithRange_Components_XHandle = Selector.GetHandle ("transitInformationCheckingResultWithRange:components:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSTextCheckingResult");
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
		public NSTextCheckingResult (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSTextCheckingResult (NSObjectFlag t) : base (t)
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
		protected internal NSTextCheckingResult (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addressCheckingResultWithRange:components:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextCheckingResult AddressCheckingResult (NSRange range, NSDictionary components)
		{
			var components__handle__ = components!.GetNonNullHandle (nameof (components));
			NSTextCheckingResult? ret;
			ret =  Runtime.GetNSObject<NSTextCheckingResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle (class_ptr, selAddressCheckingResultWithRange_Components_XHandle, range, components__handle__), false)!;
			GC.KeepAlive (components);
			return ret!;
		}
		/// <param name="range">To be added.</param><param name="components">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextCheckingResult AddressCheckingResult (NSRange range, NSTextCheckingAddressComponents components)
		{
			return AddressCheckingResult (range, components.GetDictionary ()!);
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
		[Export ("correctionCheckingResultWithRange:replacementString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextCheckingResult CorrectionCheckingResult (NSRange range, string replacementString)
		{
			if (replacementString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementString));
			var nsreplacementString = CFString.CreateNative (replacementString);
			NSTextCheckingResult? ret;
			ret =  Runtime.GetNSObject<NSTextCheckingResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle (class_ptr, selCorrectionCheckingResultWithRange_ReplacementString_XHandle, range, nsreplacementString), false)!;
			CFString.ReleaseNative (nsreplacementString);
			return ret!;
		}
		[Export ("correctionCheckingResultWithRange:replacementString:alternativeStrings:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextCheckingResult CorrectionCheckingResult (NSRange range, string replacementString, string[] alternativeStrings)
		{
			if (replacementString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementString));
			if (alternativeStrings is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (alternativeStrings));
			var nsreplacementString = CFString.CreateNative (replacementString);
			using var nsa_alternativeStrings = NSArray.FromStrings (alternativeStrings);
			NSTextCheckingResult? ret;
			ret =  Runtime.GetNSObject<NSTextCheckingResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle_NativeHandle (class_ptr, selCorrectionCheckingResultWithRange_ReplacementString_AlternativeStrings_XHandle, range, nsreplacementString, nsa_alternativeStrings.Handle), false)!;
			CFString.ReleaseNative (nsreplacementString);
			return ret!;
		}
		[Export ("dashCheckingResultWithRange:replacementString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextCheckingResult DashCheckingResult (NSRange range, string replacementString)
		{
			if (replacementString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementString));
			var nsreplacementString = CFString.CreateNative (replacementString);
			NSTextCheckingResult? ret;
			ret =  Runtime.GetNSObject<NSTextCheckingResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle (class_ptr, selDashCheckingResultWithRange_ReplacementString_XHandle, range, nsreplacementString), false)!;
			CFString.ReleaseNative (nsreplacementString);
			return ret!;
		}
		[Export ("dateCheckingResultWithRange:date:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextCheckingResult DateCheckingResult (NSRange range, NSDate date)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			NSTextCheckingResult? ret;
			ret =  Runtime.GetNSObject<NSTextCheckingResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle (class_ptr, selDateCheckingResultWithRange_Date_XHandle, range, date__handle__), false)!;
			GC.KeepAlive (date);
			return ret!;
		}
		[Export ("dateCheckingResultWithRange:date:timeZone:duration:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextCheckingResult DateCheckingResult (NSRange range, NSDate date, NSTimeZone timezone, double duration)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			var timezone__handle__ = timezone!.GetNonNullHandle (nameof (timezone));
			NSTextCheckingResult? ret;
			ret =  Runtime.GetNSObject<NSTextCheckingResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle_NativeHandle_Double (class_ptr, selDateCheckingResultWithRange_Date_TimeZone_Duration_XHandle, range, date__handle__, timezone__handle__, duration), false)!;
			GC.KeepAlive (date);
			GC.KeepAlive (timezone);
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
		[Export ("rangeWithName:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange GetRange (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_NativeHandle (this.Handle, selRangeWithName_XHandle, nsname);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_NativeHandle (&__objc_super__, selRangeWithName_XHandle, nsname);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("grammarCheckingResultWithRange:details:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextCheckingResult GrammarCheckingResult (NSRange range, string[] details)
		{
			if (details is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (details));
			using var nsa_details = NSArray.FromStrings (details);
			NSTextCheckingResult ret;
			ret =  Runtime.GetNSObject<NSTextCheckingResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle (class_ptr, selGrammarCheckingResultWithRange_Details_XHandle, range, nsa_details.Handle), false)!;
			return ret;
		}
		[Export ("linkCheckingResultWithRange:URL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextCheckingResult LinkCheckingResult (NSRange range, NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NSTextCheckingResult? ret;
			ret =  Runtime.GetNSObject<NSTextCheckingResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle (class_ptr, selLinkCheckingResultWithRange_URL_XHandle, range, url__handle__), false)!;
			GC.KeepAlive (url);
			return ret!;
		}
		[Export ("orthographyCheckingResultWithRange:orthography:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextCheckingResult OrthographyCheckingResult (NSRange range, NSOrthography ortography)
		{
			var ortography__handle__ = ortography!.GetNonNullHandle (nameof (ortography));
			NSTextCheckingResult? ret;
			ret =  Runtime.GetNSObject<NSTextCheckingResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle (class_ptr, selOrthographyCheckingResultWithRange_Orthography_XHandle, range, ortography__handle__), false)!;
			GC.KeepAlive (ortography);
			return ret!;
		}
		[Export ("phoneNumberCheckingResultWithRange:phoneNumber:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextCheckingResult PhoneNumberCheckingResult (NSRange range, string phoneNumber)
		{
			if (phoneNumber is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (phoneNumber));
			var nsphoneNumber = CFString.CreateNative (phoneNumber);
			NSTextCheckingResult? ret;
			ret =  Runtime.GetNSObject<NSTextCheckingResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle (class_ptr, selPhoneNumberCheckingResultWithRange_PhoneNumber_XHandle, range, nsphoneNumber), false)!;
			CFString.ReleaseNative (nsphoneNumber);
			return ret!;
		}
		[Export ("quoteCheckingResultWithRange:replacementString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextCheckingResult QuoteCheckingResult (NSRange range, NSString replacementString)
		{
			var replacementString__handle__ = replacementString!.GetNonNullHandle (nameof (replacementString));
			NSTextCheckingResult? ret;
			ret =  Runtime.GetNSObject<NSTextCheckingResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle (class_ptr, selQuoteCheckingResultWithRange_ReplacementString_XHandle, range, replacementString__handle__), false)!;
			GC.KeepAlive (replacementString);
			return ret!;
		}
		/// <param name="idx">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("rangeAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange RangeAtIndex (nuint idx)
		{
			NSRange ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend_UIntPtr (this.Handle, selRangeAtIndex_XHandle, idx);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper_UIntPtr (&__objc_super__, selRangeAtIndex_XHandle, idx);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("replacementCheckingResultWithRange:replacementString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextCheckingResult ReplacementCheckingResult (NSRange range, string replacementString)
		{
			if (replacementString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementString));
			var nsreplacementString = CFString.CreateNative (replacementString);
			NSTextCheckingResult? ret;
			ret =  Runtime.GetNSObject<NSTextCheckingResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle (class_ptr, selReplacementCheckingResultWithRange_ReplacementString_XHandle, range, nsreplacementString), false)!;
			CFString.ReleaseNative (nsreplacementString);
			return ret!;
		}
		/// <param name="offset">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resultByAdjustingRangesWithOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextCheckingResult ResultByAdjustingRanges (nint offset)
		{
			NSTextCheckingResult ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSTextCheckingResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selResultByAdjustingRangesWithOffset_XHandle, offset), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSTextCheckingResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selResultByAdjustingRangesWithOffset_XHandle, offset), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("spellCheckingResultWithRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextCheckingResult SpellCheckingResult (NSRange range)
		{
			NSTextCheckingResult ret;
			ret =  Runtime.GetNSObject<NSTextCheckingResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange (class_ptr, selSpellCheckingResultWithRange_XHandle, range), false)!;
			return ret;
		}
		[Export ("transitInformationCheckingResultWithRange:components:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextCheckingResult TransitInformationCheckingResult (NSRange range, NSDictionary components)
		{
			var components__handle__ = components!.GetNonNullHandle (nameof (components));
			NSTextCheckingResult? ret;
			ret =  Runtime.GetNSObject<NSTextCheckingResult> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NSRange_NativeHandle (class_ptr, selTransitInformationCheckingResultWithRange_Components_XHandle, range, components__handle__), false)!;
			GC.KeepAlive (components);
			return ret!;
		}
		/// <param name="range">To be added.</param><param name="components">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTextCheckingResult TransitInformationCheckingResult (NSRange range, NSTextCheckingTransitComponents components)
		{
			return TransitInformationCheckingResult (range, components.GetDictionary ()!);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextCheckingAddressComponents AddressComponents {
			get {
				var src = WeakAddressComponents is not null ? new NSMutableDictionary (WeakAddressComponents) : null;
				return src is null ? null! : new NSTextCheckingAddressComponents(src);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual string[] AlternativeStrings {
			[Export ("alternativeStrings")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAlternativeStringsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAlternativeStringsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTextCheckingTransitComponents Components {
			get {
				var src = WeakComponents is not null ? new NSMutableDictionary (WeakComponents) : null;
				return src is null ? null! : new NSTextCheckingTransitComponents(src);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate Date {
			[Export ("date")]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] GrammarDetails {
			[Export ("grammarDetails")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selGrammarDetailsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selGrammarDetailsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint NumberOfRanges {
			[Export ("numberOfRanges")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selNumberOfRangesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfRangesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSOrthography Orthography {
			[Export ("orthography")]
			get {
				NSOrthography? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSOrthography> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOrthographyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSOrthography> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOrthographyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string PhoneNumber {
			[Export ("phoneNumber")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPhoneNumberXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPhoneNumberXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSRange Range {
			[Export ("range")]
			get {
				NSRange ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSend (this.Handle, selRangeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.NSRange_objc_msgSendSuper (&__objc_super__, selRangeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ReplacementString {
			[Export ("replacementString")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selReplacementStringXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selReplacementStringXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTextCheckingType ResultType {
			[Export ("resultType")]
			get {
				NSTextCheckingType ret;
				if (IsDirectBinding) {
					ret = (NSTextCheckingType) global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selResultTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSTextCheckingType) global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selResultTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double TimeInterval {
			[Export ("duration")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selDurationXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selDurationXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSTimeZone TimeZone {
			[Export ("timeZone")]
			get {
				NSTimeZone? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSTimeZone> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTimeZoneXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSTimeZone> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTimeZoneXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl Url {
			[Export ("URL")]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public virtual NSDictionary WeakAddressComponents {
			[Export ("addressComponents")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAddressComponentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAddressComponentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public virtual NSDictionary WeakComponents {
			[Export ("components")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selComponentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selComponentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class NSTextCheckingResult */
}
