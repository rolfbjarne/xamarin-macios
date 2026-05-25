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
namespace CloudKit {
	[Register("CKRecord", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class CKRecord : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllKeysX = "allKeys";
		static readonly NativeHandle selAllKeysXHandle = Selector.GetHandle ("allKeys");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllTokensX = "allTokens";
		static readonly NativeHandle selAllTokensXHandle = Selector.GetHandle ("allTokens");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChangedKeysX = "changedKeys";
		static readonly NativeHandle selChangedKeysXHandle = Selector.GetHandle ("changedKeys");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreationDateX = "creationDate";
		static readonly NativeHandle selCreationDateXHandle = Selector.GetHandle ("creationDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreatorUserRecordIDX = "creatorUserRecordID";
		static readonly NativeHandle selCreatorUserRecordIDXHandle = Selector.GetHandle ("creatorUserRecordID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeSystemFieldsWithCoder_X = "encodeSystemFieldsWithCoder:";
		static readonly NativeHandle selEncodeSystemFieldsWithCoder_XHandle = Selector.GetHandle ("encodeSystemFieldsWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithRecordType_X = "initWithRecordType:";
		static readonly NativeHandle selInitWithRecordType_XHandle = Selector.GetHandle ("initWithRecordType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithRecordType_RecordID_X = "initWithRecordType:recordID:";
		static readonly NativeHandle selInitWithRecordType_RecordID_XHandle = Selector.GetHandle ("initWithRecordType:recordID:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithRecordType_ZoneID_X = "initWithRecordType:zoneID:";
		static readonly NativeHandle selInitWithRecordType_ZoneID_XHandle = Selector.GetHandle ("initWithRecordType:zoneID:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLastModifiedUserRecordIDX = "lastModifiedUserRecordID";
		static readonly NativeHandle selLastModifiedUserRecordIDXHandle = Selector.GetHandle ("lastModifiedUserRecordID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selModificationDateX = "modificationDate";
		static readonly NativeHandle selModificationDateXHandle = Selector.GetHandle ("modificationDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectForKey_X = "objectForKey:";
		static readonly NativeHandle selObjectForKey_XHandle = Selector.GetHandle ("objectForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParentX = "parent";
		static readonly NativeHandle selParentXHandle = Selector.GetHandle ("parent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecordChangeTagX = "recordChangeTag";
		static readonly NativeHandle selRecordChangeTagXHandle = Selector.GetHandle ("recordChangeTag");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecordIDX = "recordID";
		static readonly NativeHandle selRecordIDXHandle = Selector.GetHandle ("recordID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecordTypeX = "recordType";
		static readonly NativeHandle selRecordTypeXHandle = Selector.GetHandle ("recordType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetObject_ForKey_X = "setObject:forKey:";
		static readonly NativeHandle selSetObject_ForKey_XHandle = Selector.GetHandle ("setObject:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetParent_X = "setParent:";
		static readonly NativeHandle selSetParent_XHandle = Selector.GetHandle ("setParent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetParentReferenceFromRecord_X = "setParentReferenceFromRecord:";
		static readonly NativeHandle selSetParentReferenceFromRecord_XHandle = Selector.GetHandle ("setParentReferenceFromRecord:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetParentReferenceFromRecordID_X = "setParentReferenceFromRecordID:";
		static readonly NativeHandle selSetParentReferenceFromRecordID_XHandle = Selector.GetHandle ("setParentReferenceFromRecordID:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShareX = "share";
		static readonly NativeHandle selShareXHandle = Selector.GetHandle ("share");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CKRecord");
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
		public CKRecord (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected CKRecord (NSObjectFlag t) : base (t)
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
		protected internal CKRecord (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithRecordType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CKRecord (string recordType)
			: base (NSObjectFlag.Empty)
		{
			if (recordType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (recordType));
			var nsrecordType = CFString.CreateNative (recordType);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithRecordType_XHandle, nsrecordType), "initWithRecordType:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithRecordType_XHandle, nsrecordType), "initWithRecordType:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsrecordType);
		}
		[Export ("initWithRecordType:recordID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CKRecord (string recordType, CKRecordID recordId)
			: base (NSObjectFlag.Empty)
		{
			if (recordType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (recordType));
			var recordId__handle__ = recordId!.GetNonNullHandle (nameof (recordId));
			var nsrecordType = CFString.CreateNative (recordType);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithRecordType_RecordID_XHandle, nsrecordType, recordId__handle__), "initWithRecordType:recordID:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithRecordType_RecordID_XHandle, nsrecordType, recordId__handle__), "initWithRecordType:recordID:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (recordId);
			CFString.ReleaseNative (nsrecordType);
		}
		[Export ("initWithRecordType:zoneID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public CKRecord (string recordType, CKRecordZoneID zoneId)
			: base (NSObjectFlag.Empty)
		{
			if (recordType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (recordType));
			var zoneId__handle__ = zoneId!.GetNonNullHandle (nameof (zoneId));
			var nsrecordType = CFString.CreateNative (recordType);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithRecordType_ZoneID_XHandle, nsrecordType, zoneId__handle__), "initWithRecordType:zoneID:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithRecordType_ZoneID_XHandle, nsrecordType, zoneId__handle__), "initWithRecordType:zoneID:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zoneId);
			CFString.ReleaseNative (nsrecordType);
		}
		[Export ("allKeys")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] AllKeys ()
		{
			string[] ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAllKeysXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAllKeysXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("allTokens")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] AllTokens ()
		{
			string[] ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAllTokensXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAllTokensXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("changedKeys")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] ChangedKeys ()
		{
			string[] ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selChangedKeysXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selChangedKeysXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
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
		[Export ("encodeSystemFieldsWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeSystemFields (NSCoder coder)
		{
			var coder__handle__ = coder!.GetNonNullHandle (nameof (coder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeSystemFieldsWithCoder_XHandle, coder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeSystemFieldsWithCoder_XHandle, coder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
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
		[Export ("setParentReferenceFromRecord:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetParent (CKRecord? parentRecord)
		{
			var parentRecord__handle__ = parentRecord.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetParentReferenceFromRecord_XHandle, parentRecord__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetParentReferenceFromRecord_XHandle, parentRecord__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (parentRecord);
		}
		[Export ("setParentReferenceFromRecordID:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetParent (CKRecordID? parentRecordID)
		{
			var parentRecordID__handle__ = parentRecordID.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetParentReferenceFromRecordID_XHandle, parentRecordID__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetParentReferenceFromRecordID_XHandle, parentRecordID__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (parentRecordID);
		}
		[Export ("objectForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NSObject? _ObjectForKey (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selObjectForKey_XHandle, nskey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selObjectForKey_XHandle, nskey), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("setObject:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _SetObject (nint obj, string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, selSetObject_ForKey_XHandle, obj, nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selSetObject_ForKey_XHandle, obj, nskey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate? CreationDate {
			[Export ("creationDate", ArgumentSemantic.Copy)]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCreationDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCreationDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKRecordID? CreatorUserRecordId {
			[Export ("creatorUserRecordID", ArgumentSemantic.Copy)]
			get {
				CKRecordID? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKRecordID> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCreatorUserRecordIDXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKRecordID> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCreatorUserRecordIDXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKRecordID Id {
			[Export ("recordID", ArgumentSemantic.Copy)]
			get {
				CKRecordID? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKRecordID> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRecordIDXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKRecordID> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRecordIDXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CKRecordID? LastModifiedUserRecordId {
			[Export ("lastModifiedUserRecordID", ArgumentSemantic.Copy)]
			get {
				CKRecordID? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKRecordID> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLastModifiedUserRecordIDXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKRecordID> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLastModifiedUserRecordIDXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate? ModificationDate {
			[Export ("modificationDate", ArgumentSemantic.Copy)]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selModificationDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selModificationDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CKReference? Parent {
			[Export ("parent", ArgumentSemantic.Copy)]
			get {
				CKReference? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKReference> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selParentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKReference> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selParentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setParent:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetParent_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetParent_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? RecordChangeTag {
			[Export ("recordChangeTag")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRecordChangeTagXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRecordChangeTagXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string RecordType {
			[Export ("recordType")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRecordTypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRecordTypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual CKReference? Share {
			[Export ("share", ArgumentSemantic.Copy)]
			get {
				CKReference? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CKReference> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selShareXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CKReference> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selShareXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CreationDateKey;
		/// <summary>Represents the value associated with the constant 'CKRecordCreationDateKey'.</summary>
		[Field ("CKRecordCreationDateKey",  "CloudKit")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString CreationDateKey {
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_CreationDateKey is null)
					_CreationDateKey = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKRecordCreationDateKey")!;
				return _CreationDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CreatorUserRecordIdKey;
		/// <summary>Represents the value associated with the constant 'CKRecordCreatorUserRecordIDKey'.</summary>
		[Field ("CKRecordCreatorUserRecordIDKey",  "CloudKit")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString CreatorUserRecordIdKey {
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_CreatorUserRecordIdKey is null)
					_CreatorUserRecordIdKey = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKRecordCreatorUserRecordIDKey")!;
				return _CreatorUserRecordIdKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _LastModifiedUserRecordIdKey;
		/// <summary>Represents the value associated with the constant 'CKRecordLastModifiedUserRecordIDKey'.</summary>
		[Field ("CKRecordLastModifiedUserRecordIDKey",  "CloudKit")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString LastModifiedUserRecordIdKey {
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_LastModifiedUserRecordIdKey is null)
					_LastModifiedUserRecordIdKey = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKRecordLastModifiedUserRecordIDKey")!;
				return _LastModifiedUserRecordIdKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ModificationDateKey;
		/// <summary>Represents the value associated with the constant 'CKRecordModificationDateKey'.</summary>
		[Field ("CKRecordModificationDateKey",  "CloudKit")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString ModificationDateKey {
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_ModificationDateKey is null)
					_ModificationDateKey = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKRecordModificationDateKey")!;
				return _ModificationDateKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NameZoneWideShare;
		/// <summary>Represents the value associated with the constant 'CKRecordNameZoneWideShare'.</summary>
		[Field ("CKRecordNameZoneWideShare",  "CloudKit")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static NSString NameZoneWideShare {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_NameZoneWideShare is null)
					_NameZoneWideShare = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKRecordNameZoneWideShare")!;
				return _NameZoneWideShare;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ParentKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CKRecordParentKey",  "CloudKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ParentKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ParentKey is null)
					_ParentKey = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKRecordParentKey")!;
				return _ParentKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RecordIdKey;
		/// <summary>Represents the value associated with the constant 'CKRecordRecordIDKey'.</summary>
		[Field ("CKRecordRecordIDKey",  "CloudKit")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString RecordIdKey {
			[SupportedOSPlatform ("tvos17.0")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_RecordIdKey is null)
					_RecordIdKey = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKRecordRecordIDKey")!;
				return _RecordIdKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShareKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CKRecordShareKey",  "CloudKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString ShareKey {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_ShareKey is null)
					_ShareKey = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKRecordShareKey")!;
				return _ShareKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeShare;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CKRecordTypeShare",  "CloudKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static NSString TypeShare {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_TypeShare is null)
					_TypeShare = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKRecordTypeShare")!;
				return _TypeShare;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TypeUserRecord;
		/// <summary>Represents the value associated with the constant CKRecordTypeUserRecord</summary><value></value><remarks>To be added.</remarks>
		[Field ("CKRecordTypeUserRecord",  "CloudKit")]
		public static NSString TypeUserRecord {
			get {
				if (_TypeUserRecord is null)
					_TypeUserRecord = Dlfcn.GetStringConstant (Libraries.CloudKit.Handle, "CKRecordTypeUserRecord")!;
				return _TypeUserRecord;
			}
		}
	} /* class CKRecord */
}
