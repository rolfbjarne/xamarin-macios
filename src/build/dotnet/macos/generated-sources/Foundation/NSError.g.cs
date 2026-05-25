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
	[Register("NSError", true)]
	public unsafe partial class NSError : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCodeX = "code";
		static readonly NativeHandle selCodeXHandle = Selector.GetHandle ("code");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDomainX = "domain";
		static readonly NativeHandle selDomainXHandle = Selector.GetHandle ("domain");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selErrorWithDomain_Code_UserInfo_X = "errorWithDomain:code:userInfo:";
		static readonly NativeHandle selErrorWithDomain_Code_UserInfo_XHandle = Selector.GetHandle ("errorWithDomain:code:userInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileProviderErrorForCollisionWithItem_X = "fileProviderErrorForCollisionWithItem:";
		static readonly NativeHandle selFileProviderErrorForCollisionWithItem_XHandle = Selector.GetHandle ("fileProviderErrorForCollisionWithItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileProviderErrorForNonExistentItemWithIdentifier_X = "fileProviderErrorForNonExistentItemWithIdentifier:";
		static readonly NativeHandle selFileProviderErrorForNonExistentItemWithIdentifier_XHandle = Selector.GetHandle ("fileProviderErrorForNonExistentItemWithIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileProviderErrorForRejectedDeletionOfItem_X = "fileProviderErrorForRejectedDeletionOfItem:";
		static readonly NativeHandle selFileProviderErrorForRejectedDeletionOfItem_XHandle = Selector.GetHandle ("fileProviderErrorForRejectedDeletionOfItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHelpAnchorX = "helpAnchor";
		static readonly NativeHandle selHelpAnchorXHandle = Selector.GetHandle ("helpAnchor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDomain_Code_UserInfo_X = "initWithDomain:code:userInfo:";
		static readonly NativeHandle selInitWithDomain_Code_UserInfo_XHandle = Selector.GetHandle ("initWithDomain:code:userInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedDescriptionX = "localizedDescription";
		static readonly NativeHandle selLocalizedDescriptionXHandle = Selector.GetHandle ("localizedDescription");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedFailureReasonX = "localizedFailureReason";
		static readonly NativeHandle selLocalizedFailureReasonXHandle = Selector.GetHandle ("localizedFailureReason");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedRecoveryOptionsX = "localizedRecoveryOptions";
		static readonly NativeHandle selLocalizedRecoveryOptionsXHandle = Selector.GetHandle ("localizedRecoveryOptions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalizedRecoverySuggestionX = "localizedRecoverySuggestion";
		static readonly NativeHandle selLocalizedRecoverySuggestionXHandle = Selector.GetHandle ("localizedRecoverySuggestion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUserInfoValueProviderForDomain_Provider_X = "setUserInfoValueProviderForDomain:provider:";
		static readonly NativeHandle selSetUserInfoValueProviderForDomain_Provider_XHandle = Selector.GetHandle ("setUserInfoValueProviderForDomain:provider:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnderlyingErrorsX = "underlyingErrors";
		static readonly NativeHandle selUnderlyingErrorsXHandle = Selector.GetHandle ("underlyingErrors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserInfoX = "userInfo";
		static readonly NativeHandle selUserInfoXHandle = Selector.GetHandle ("userInfo");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserInfoValueProviderForDomain_X = "userInfoValueProviderForDomain:";
		static readonly NativeHandle selUserInfoValueProviderForDomain_XHandle = Selector.GetHandle ("userInfoValueProviderForDomain:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSError");
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
		public NSError (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSError (NSObjectFlag t) : base (t)
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
		protected internal NSError (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="domain">To be added.</param><param name="code">To be added.</param><param name="userInfo"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithDomain:code:userInfo:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSError (NSString domain, nint code, NSDictionary? userInfo)
			: base (NSObjectFlag.Empty)
		{
			var domain__handle__ = domain!.GetNonNullHandle (nameof (domain));
			var userInfo__handle__ = userInfo.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (this.Handle, selInitWithDomain_Code_UserInfo_XHandle, domain__handle__, code, userInfo__handle__), "initWithDomain:code:userInfo:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_IntPtr_NativeHandle (&__objc_super__, selInitWithDomain_Code_UserInfo_XHandle, domain__handle__, code, userInfo__handle__), "initWithDomain:code:userInfo:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (domain);
			GC.KeepAlive (userInfo);
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
		/// <param name="domain">To be added.</param><param name="code">To be added.</param><param name="userInfo"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("errorWithDomain:code:userInfo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSError FromDomain (NSString domain, nint code, NSDictionary? userInfo)
		{
			var domain__handle__ = domain!.GetNonNullHandle (nameof (domain));
			var userInfo__handle__ = userInfo.GetHandle ();
			NSError? ret;
			ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (class_ptr, selErrorWithDomain_Code_UserInfo_XHandle, domain__handle__, code, userInfo__handle__), false)!;
			GC.KeepAlive (domain);
			GC.KeepAlive (userInfo);
			return ret!;
		}
		/// <param name="existingItem">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fileProviderErrorForCollisionWithItem:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSError GetFileProviderError (global::FileProvider.INSFileProviderItem existingItem)
		{
			var existingItem__handle__ = existingItem!.GetNonNullHandle (nameof (existingItem));
			NSError? ret;
			ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selFileProviderErrorForCollisionWithItem_XHandle, existingItem__handle__), false)!;
			GC.KeepAlive (existingItem);
			return ret!;
		}
		/// <param name="nonExistentItemIdentifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fileProviderErrorForNonExistentItemWithIdentifier:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSError GetFileProviderError (string nonExistentItemIdentifier)
		{
			if (nonExistentItemIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nonExistentItemIdentifier));
			var nsnonExistentItemIdentifier = CFString.CreateNative (nonExistentItemIdentifier);
			NSError? ret;
			ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selFileProviderErrorForNonExistentItemWithIdentifier_XHandle, nsnonExistentItemIdentifier), false)!;
			CFString.ReleaseNative (nsnonExistentItemIdentifier);
			return ret!;
		}
		[Export ("fileProviderErrorForRejectedDeletionOfItem:")]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSError GetFileProviderErrorForRejectedDeletion (global::FileProvider.INSFileProviderItem updatedVersion)
		{
			var updatedVersion__handle__ = updatedVersion!.GetNonNullHandle (nameof (updatedVersion));
			NSError? ret;
			ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selFileProviderErrorForRejectedDeletionOfItem_XHandle, updatedVersion__handle__), false)!;
			GC.KeepAlive (updatedVersion);
			return ret!;
		}
		[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDNSErrorUserInfoValueProvider))]
		[Export ("userInfoValueProviderForDomain:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSErrorUserInfoValueProvider? GetUserInfoValueProvider (string errorDomain)
		{
			if (errorDomain is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (errorDomain));
			var nserrorDomain = CFString.CreateNative (errorDomain);
			NativeHandle ret;
			ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selUserInfoValueProviderForDomain_XHandle, nserrorDomain);
			CFString.ReleaseNative (nserrorDomain);
			return global::ObjCRuntime.Trampolines.NIDNSErrorUserInfoValueProvider.Create (ret)!;
		}
		[Export ("setUserInfoValueProviderForDomain:provider:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetUserInfoValueProvider (string errorDomain, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSErrorUserInfoValueProvider))]NSErrorUserInfoValueProvider? provider)
		{
			if (errorDomain is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (errorDomain));
			var nserrorDomain = CFString.CreateNative (errorDomain);
			using var block_provider = Trampolines.SDNSErrorUserInfoValueProvider.CreateNullableBlock (provider);
			BlockLiteral *block_ptr_provider = null;
			if (provider is not null)
				block_ptr_provider = &block_provider;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selSetUserInfoValueProviderForDomain_Provider_XHandle, nserrorDomain, (IntPtr) block_ptr_provider);
			CFString.ReleaseNative (nserrorDomain);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Code {
			[Export ("code")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCodeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selCodeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Domain {
			[Export ("domain")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDomainXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDomainXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string HelpAnchor {
			[Export ("helpAnchor")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selHelpAnchorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selHelpAnchorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string LocalizedDescription {
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
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string LocalizedFailureReason {
			[Export ("localizedFailureReason")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizedFailureReasonXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizedFailureReasonXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] LocalizedRecoveryOptions {
			[Export ("localizedRecoveryOptions")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizedRecoveryOptionsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizedRecoveryOptionsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string LocalizedRecoverySuggestion {
			[Export ("localizedRecoverySuggestion")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalizedRecoverySuggestionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalizedRecoverySuggestionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSError[] UnderlyingErrors {
			[Export ("underlyingErrors", ArgumentSemantic.Copy)]
			get {
				NSError[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSError>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUnderlyingErrorsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSError>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUnderlyingErrorsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary UserInfo {
			[Export ("userInfo")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUserInfoXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUserInfoXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CFNetworkErrorDomain;
		/// <summary>The CFNetwork error domain.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("kCFErrorDomainCFNetwork",  "CFNetwork")]
		public static NSString CFNetworkErrorDomain {
			get {
				if (_CFNetworkErrorDomain is null)
					_CFNetworkErrorDomain = Dlfcn.GetStringConstant (Libraries.CFNetwork.Handle, "kCFErrorDomainCFNetwork")!;
				return _CFNetworkErrorDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CocoaErrorDomain;
		/// <summary>The Cocoa error domain.</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSCocoaErrorDomain",  "Foundation")]
		public static NSString CocoaErrorDomain {
			get {
				if (_CocoaErrorDomain is null)
					_CocoaErrorDomain = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSCocoaErrorDomain")!;
				return _CocoaErrorDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CoreLocationErrorDomain;
		/// <summary>The CoreLocation error domain.</summary><value></value><remarks>To be added.</remarks>
		[Field ("kCLErrorDomain",  "CoreLocation")]
		public static NSString CoreLocationErrorDomain {
			get {
				if (_CoreLocationErrorDomain is null)
					_CoreLocationErrorDomain = Dlfcn.GetStringConstant (Libraries.CoreLocation.Handle, "kCLErrorDomain")!;
				return _CoreLocationErrorDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DebugDescriptionErrorKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSDebugDescriptionErrorKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString DebugDescriptionErrorKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_DebugDescriptionErrorKey is null)
					_DebugDescriptionErrorKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSDebugDescriptionErrorKey")!;
				return _DebugDescriptionErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FilePathErrorKey;
		/// <summary>Standard key to use in the userInfo payload for associating a file path with the error.</summary><value /><remarks>To be added.</remarks>
		[Field ("NSFilePathErrorKey",  "Foundation")]
		public static NSString FilePathErrorKey {
			get {
				if (_FilePathErrorKey is null)
					_FilePathErrorKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSFilePathErrorKey")!;
				return _FilePathErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _HelpAnchorErrorKey;
		/// <summary>Standard key to use in the userInfo payload for associating a hint to provide to the user.</summary><value /><remarks>To be added.</remarks>
		[Field ("NSHelpAnchorErrorKey",  "Foundation")]
		public static NSString HelpAnchorErrorKey {
			get {
				if (_HelpAnchorErrorKey is null)
					_HelpAnchorErrorKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSHelpAnchorErrorKey")!;
				return _HelpAnchorErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LocalizedDescriptionKey;
		/// <summary>Standard key to use in the userInfo payload for associating a localized description of the problem to provide to the user.</summary><value /><remarks>To be added.</remarks>
		[Field ("NSLocalizedDescriptionKey",  "Foundation")]
		public static NSString LocalizedDescriptionKey {
			get {
				if (_LocalizedDescriptionKey is null)
					_LocalizedDescriptionKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocalizedDescriptionKey")!;
				return _LocalizedDescriptionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LocalizedFailureErrorKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("NSLocalizedFailureErrorKey",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString LocalizedFailureErrorKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_LocalizedFailureErrorKey is null)
					_LocalizedFailureErrorKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocalizedFailureErrorKey")!;
				return _LocalizedFailureErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LocalizedFailureReasonErrorKey;
		/// <summary>Represents the value associated with the constant NSLocalizedFailureReasonErrorKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSLocalizedFailureReasonErrorKey",  "Foundation")]
		public static NSString LocalizedFailureReasonErrorKey {
			get {
				if (_LocalizedFailureReasonErrorKey is null)
					_LocalizedFailureReasonErrorKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocalizedFailureReasonErrorKey")!;
				return _LocalizedFailureReasonErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LocalizedRecoveryOptionsErrorKey;
		/// <summary>Represents the value associated with the constant NSLocalizedRecoveryOptionsErrorKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSLocalizedRecoveryOptionsErrorKey",  "Foundation")]
		public static NSString LocalizedRecoveryOptionsErrorKey {
			get {
				if (_LocalizedRecoveryOptionsErrorKey is null)
					_LocalizedRecoveryOptionsErrorKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocalizedRecoveryOptionsErrorKey")!;
				return _LocalizedRecoveryOptionsErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LocalizedRecoverySuggestionErrorKey;
		/// <summary>Represents the value associated with the constant NSLocalizedRecoverySuggestionErrorKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSLocalizedRecoverySuggestionErrorKey",  "Foundation")]
		public static NSString LocalizedRecoverySuggestionErrorKey {
			get {
				if (_LocalizedRecoverySuggestionErrorKey is null)
					_LocalizedRecoverySuggestionErrorKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSLocalizedRecoverySuggestionErrorKey")!;
				return _LocalizedRecoverySuggestionErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MachErrorDomain;
		/// <summary>Represents the value associated with the constant NSMachErrorDomain</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSMachErrorDomain",  "Foundation")]
		public static NSString MachErrorDomain {
			get {
				if (_MachErrorDomain is null)
					_MachErrorDomain = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMachErrorDomain")!;
				return _MachErrorDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MultipleUnderlyingErrorsKey;
		/// <summary>Represents the value associated with the constant 'NSMultipleUnderlyingErrorsKey'.</summary>
		[Field ("NSMultipleUnderlyingErrorsKey",  "Foundation")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("ios14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString MultipleUnderlyingErrorsKey {
			[SupportedOSPlatform ("tvos14.5")]
			[SupportedOSPlatform ("ios14.5")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_MultipleUnderlyingErrorsKey is null)
					_MultipleUnderlyingErrorsKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSMultipleUnderlyingErrorsKey")!;
				return _MultipleUnderlyingErrorsKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSNetServicesErrorCode;
		/// <summary>Represents the value associated with the constant 'NSNetServicesErrorCode'.</summary>
		[Field ("NSNetServicesErrorCode",  "Foundation")]
		public static NSString NSNetServicesErrorCode {
			get {
				if (_NSNetServicesErrorCode is null)
					_NSNetServicesErrorCode = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSNetServicesErrorCode")!;
				return _NSNetServicesErrorCode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSNetServicesErrorDomain;
		/// <summary>Represents the value associated with the constant NSNetServicesErrorDomain</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSNetServicesErrorDomain",  "Foundation")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString NSNetServicesErrorDomain {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_NSNetServicesErrorDomain is null)
					_NSNetServicesErrorDomain = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSNetServicesErrorDomain")!;
				return _NSNetServicesErrorDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSStreamSOCKSErrorDomain;
		/// <summary>Represents the value associated with the constant NSStreamSOCKSErrorDomain</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamSOCKSErrorDomain",  "Foundation")]
		public static NSString NSStreamSOCKSErrorDomain {
			get {
				if (_NSStreamSOCKSErrorDomain is null)
					_NSStreamSOCKSErrorDomain = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamSOCKSErrorDomain")!;
				return _NSStreamSOCKSErrorDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSStreamSocketSSLErrorDomain;
		/// <summary>Represents the value associated with the constant NSStreamSocketSSLErrorDomain</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStreamSocketSSLErrorDomain",  "Foundation")]
		public static NSString NSStreamSocketSSLErrorDomain {
			get {
				if (_NSStreamSocketSSLErrorDomain is null)
					_NSStreamSocketSSLErrorDomain = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStreamSocketSSLErrorDomain")!;
				return _NSStreamSocketSSLErrorDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSUrlErrorDomain;
		/// <summary>Represents the value associated with the constant NSURLErrorDomain</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLErrorDomain",  "Foundation")]
		public static NSString NSUrlErrorDomain {
			get {
				if (_NSUrlErrorDomain is null)
					_NSUrlErrorDomain = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLErrorDomain")!;
				return _NSUrlErrorDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OsStatusErrorDomain;
		/// <summary>Represents the value associated with the constant NSOSStatusErrorDomain</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSOSStatusErrorDomain",  "Foundation")]
		public static NSString OsStatusErrorDomain {
			get {
				if (_OsStatusErrorDomain is null)
					_OsStatusErrorDomain = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSOSStatusErrorDomain")!;
				return _OsStatusErrorDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PosixErrorDomain;
		/// <summary>Represents the value associated with the constant NSPOSIXErrorDomain</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSPOSIXErrorDomain",  "Foundation")]
		public static NSString PosixErrorDomain {
			get {
				if (_PosixErrorDomain is null)
					_PosixErrorDomain = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSPOSIXErrorDomain")!;
				return _PosixErrorDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RecoveryAttempterErrorKey;
		/// <summary>Represents the value associated with the constant NSRecoveryAttempterErrorKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSRecoveryAttempterErrorKey",  "Foundation")]
		public static NSString RecoveryAttempterErrorKey {
			get {
				if (_RecoveryAttempterErrorKey is null)
					_RecoveryAttempterErrorKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSRecoveryAttempterErrorKey")!;
				return _RecoveryAttempterErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StringEncodingErrorKey;
		/// <summary>Represents the value associated with the constant NSStringEncodingErrorKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSStringEncodingErrorKey",  "Foundation")]
		public static NSString StringEncodingErrorKey {
			get {
				if (_StringEncodingErrorKey is null)
					_StringEncodingErrorKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSStringEncodingErrorKey")!;
				return _StringEncodingErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UnderlyingErrorKey;
		/// <summary>Represents the value associated with the constant NSUnderlyingErrorKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSUnderlyingErrorKey",  "Foundation")]
		public static NSString UnderlyingErrorKey {
			get {
				if (_UnderlyingErrorKey is null)
					_UnderlyingErrorKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSUnderlyingErrorKey")!;
				return _UnderlyingErrorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UrlErrorKey;
		/// <summary>Represents the value associated with the constant NSURLErrorKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSURLErrorKey",  "Foundation")]
		public static NSString UrlErrorKey {
			get {
				if (_UrlErrorKey is null)
					_UrlErrorKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSURLErrorKey")!;
				return _UrlErrorKey;
			}
		}
	} /* class NSError */
}
