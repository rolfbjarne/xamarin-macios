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
namespace SharedWithYouCore {
	[Register("SWCollaborationMetadata", true)]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("ios16.0")]
	[SupportedOSPlatform ("maccatalyst16.0")]
	public unsafe partial class SWCollaborationMetadata : NSObject, INSCoding, INSCopying, INSItemProviderReading, INSItemProviderWriting, INSMutableCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCollaborationIdentifierX = "collaborationIdentifier";
		static readonly NativeHandle selCollaborationIdentifierXHandle = Selector.GetHandle ("collaborationIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultShareOptionsX = "defaultShareOptions";
		static readonly NativeHandle selDefaultShareOptionsXHandle = Selector.GetHandle ("defaultShareOptions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCollaborationIdentifier_X = "initWithCollaborationIdentifier:";
		static readonly NativeHandle selInitWithCollaborationIdentifier_XHandle = Selector.GetHandle ("initWithCollaborationIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithLocalIdentifier_X = "initWithLocalIdentifier:";
		static readonly NativeHandle selInitWithLocalIdentifier_XHandle = Selector.GetHandle ("initWithLocalIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitiatorHandleX = "initiatorHandle";
		static readonly NativeHandle selInitiatorHandleXHandle = Selector.GetHandle ("initiatorHandle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitiatorNameComponentsX = "initiatorNameComponents";
		static readonly NativeHandle selInitiatorNameComponentsXHandle = Selector.GetHandle ("initiatorNameComponents");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemProviderVisibilityForRepresentationWithTypeIdentifier_X = "itemProviderVisibilityForRepresentationWithTypeIdentifier:";
		static readonly NativeHandle selItemProviderVisibilityForRepresentationWithTypeIdentifier_XHandle = Selector.GetHandle ("itemProviderVisibilityForRepresentationWithTypeIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_X = "loadDataWithTypeIdentifier:forItemProviderCompletionHandler:";
		static readonly NativeHandle selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_XHandle = Selector.GetHandle ("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalIdentifierX = "localIdentifier";
		static readonly NativeHandle selLocalIdentifierXHandle = Selector.GetHandle ("localIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMutableCopyWithZone_X = "mutableCopyWithZone:";
		static readonly NativeHandle selMutableCopyWithZone_XHandle = Selector.GetHandle ("mutableCopyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectWithItemProviderData_TypeIdentifier_Error_X = "objectWithItemProviderData:typeIdentifier:error:";
		static readonly NativeHandle selObjectWithItemProviderData_TypeIdentifier_Error_XHandle = Selector.GetHandle ("objectWithItemProviderData:typeIdentifier:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadableTypeIdentifiersForItemProviderX = "readableTypeIdentifiersForItemProvider";
		static readonly NativeHandle selReadableTypeIdentifiersForItemProviderXHandle = Selector.GetHandle ("readableTypeIdentifiersForItemProvider");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultShareOptions_X = "setDefaultShareOptions:";
		static readonly NativeHandle selSetDefaultShareOptions_XHandle = Selector.GetHandle ("setDefaultShareOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInitiatorHandle_X = "setInitiatorHandle:";
		static readonly NativeHandle selSetInitiatorHandle_XHandle = Selector.GetHandle ("setInitiatorHandle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInitiatorNameComponents_X = "setInitiatorNameComponents:";
		static readonly NativeHandle selSetInitiatorNameComponents_XHandle = Selector.GetHandle ("setInitiatorNameComponents:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTitle_X = "setTitle:";
		static readonly NativeHandle selSetTitle_XHandle = Selector.GetHandle ("setTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUserSelectedShareOptions_X = "setUserSelectedShareOptions:";
		static readonly NativeHandle selSetUserSelectedShareOptions_XHandle = Selector.GetHandle ("setUserSelectedShareOptions:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTitleX = "title";
		static readonly NativeHandle selTitleXHandle = Selector.GetHandle ("title");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserSelectedShareOptionsX = "userSelectedShareOptions";
		static readonly NativeHandle selUserSelectedShareOptionsXHandle = Selector.GetHandle ("userSelectedShareOptions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWritableTypeIdentifiersForItemProviderX = "writableTypeIdentifiersForItemProvider";
		static readonly NativeHandle selWritableTypeIdentifiersForItemProviderXHandle = Selector.GetHandle ("writableTypeIdentifiersForItemProvider");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SWCollaborationMetadata");
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
		public SWCollaborationMetadata (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected SWCollaborationMetadata (NSObjectFlag t) : base (t)
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
		protected internal SWCollaborationMetadata (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
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
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
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
		/// <param name="typeIdentifier">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("itemProviderVisibilityForRepresentationWithTypeIdentifier:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSItemProviderRepresentationVisibility GetItemProviderVisibilityForTypeIdentifier (string typeIdentifier)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			NSItemProviderRepresentationVisibility ret;
			if (IsDirectBinding) {
				ret = (NSItemProviderRepresentationVisibility) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selItemProviderVisibilityForRepresentationWithTypeIdentifier_XHandle, nstypeIdentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSItemProviderRepresentationVisibility) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selItemProviderVisibilityForRepresentationWithTypeIdentifier_XHandle, nstypeIdentifier);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeIdentifier);
			return ret!;
		}
		/// <param name="data">To be added.</param><param name="typeIdentifier">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("objectWithItemProviderData:typeIdentifier:error:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static INSItemProviderReading? GetObject (NSData data, string typeIdentifier, out NSError? outError)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			NativeHandle outErrorValue = IntPtr.Zero;
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			INSItemProviderReading? ret;
			ret =  Runtime.GetINativeObject<INSItemProviderReading> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (class_ptr, selObjectWithItemProviderData_TypeIdentifier_Error_XHandle, data__handle__, nstypeIdentifier, &outErrorValue), false)!;
			GC.KeepAlive (data);
			CFString.ReleaseNative (nstypeIdentifier);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret!;
		}
		/// <param name="typeIdentifier">A Universal Type Identifier (UTI) indicating the type of data to load.</param><param name="completionHandler">The method called after the data is loaded.</param><summary>Implement this method to customize the loading of data by an <see cref="T:Foundation.NSItemProvider" />.</summary><returns>An <see cref="T:Foundation.NSProgress" /> object reflecting the data-loading operation.</returns><remarks><para>The <paramref name="typeIdentifier" /> must be in the set of values returned by <see cref="Foundation.NSItemProviderWriting_Extensions.GetWritableTypeIdentifiersForItemProvider(Foundation.INSItemProviderWriting)" />.</para></remarks>
		[Export ("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSProgress? LoadData (string typeIdentifier, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V16))]global::System.Action<NSData, NSError> completionHandler)
		{
			if (typeIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (typeIdentifier));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nstypeIdentifier = CFString.CreateNative (typeIdentifier);
			using var block_completionHandler = Trampolines.SDActionArity2V16.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			NSProgress? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_XHandle, nstypeIdentifier, (IntPtr) block_ptr_completionHandler), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSProgress> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_XHandle, nstypeIdentifier, (IntPtr) block_ptr_completionHandler), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstypeIdentifier);
			return ret!;
		}
		/// <param name="typeIdentifier">A Universal Type Identifier (UTI) indicating the type of data to load.</param>
		/// <summary>Asynchronously loads data for the identified type from an item provider, returning a task that contains the data.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> LoadDataAsync (string typeIdentifier)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			LoadData(typeIdentifier, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> LoadDataAsync (string typeIdentifier, out NSProgress result)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			result = LoadData(typeIdentifier, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			})!;
			return tcs.Task;
		}
		/// <param name="zone">Zone to use to allocate this object, or null to use the default zone.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("mutableCopyWithZone:")]
		[return: ReleaseAttribute ()]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject MutableCopy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMutableCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMutableCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("initWithCollaborationIdentifier:")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos13.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NativeHandle _InitWithCollaborationIdentifier (string collaborationIdentifier)
		{
			if (collaborationIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (collaborationIdentifier));
			var nscollaborationIdentifier = CFString.CreateNative (collaborationIdentifier);
			NativeHandle ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithCollaborationIdentifier_XHandle, nscollaborationIdentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithCollaborationIdentifier_XHandle, nscollaborationIdentifier);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscollaborationIdentifier);
			return ret!;
		}
		[Export ("initWithLocalIdentifier:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NativeHandle _InitWithLocalIdentifier (string localIdentifier)
		{
			if (localIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localIdentifier));
			var nslocalIdentifier = CFString.CreateNative (localIdentifier);
			NativeHandle ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithLocalIdentifier_XHandle, nslocalIdentifier);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithLocalIdentifier_XHandle, nslocalIdentifier);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nslocalIdentifier);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string CollaborationIdentifier {
			[Export ("collaborationIdentifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCollaborationIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCollaborationIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SWCollaborationShareOptions? DefaultShareOptions {
			[Export ("defaultShareOptions", ArgumentSemantic.Copy)]
			get {
				SWCollaborationShareOptions? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SWCollaborationShareOptions> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDefaultShareOptionsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SWCollaborationShareOptions> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDefaultShareOptionsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setDefaultShareOptions:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDefaultShareOptions_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDefaultShareOptions_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? InitiatorHandle {
			[Export ("initiatorHandle")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInitiatorHandleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInitiatorHandleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setInitiatorHandle:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetInitiatorHandle_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetInitiatorHandle_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPersonNameComponents? InitiatorNameComponents {
			[Export ("initiatorNameComponents", ArgumentSemantic.Retain)]
			get {
				NSPersonNameComponents? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSPersonNameComponents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInitiatorNameComponentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSPersonNameComponents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInitiatorNameComponentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setInitiatorNameComponents:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetInitiatorNameComponents_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetInitiatorNameComponents_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string LocalIdentifier {
			[Export ("localIdentifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public static string[] ReadableTypeIdentifiers {
			[Export ("readableTypeIdentifiersForItemProvider", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selReadableTypeIdentifiersForItemProviderXHandle), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Title {
			[Export ("title")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTitleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTitleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTitle:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTitle_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTitle_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SWCollaborationShareOptions? UserSelectedShareOptions {
			[Export ("userSelectedShareOptions", ArgumentSemantic.Copy)]
			get {
				SWCollaborationShareOptions? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SWCollaborationShareOptions> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUserSelectedShareOptionsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SWCollaborationShareOptions> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUserSelectedShareOptionsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setUserSelectedShareOptions:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetUserSelectedShareOptions_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetUserSelectedShareOptions_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public static string[] WritableTypeIdentifiers {
			[Export ("writableTypeIdentifiersForItemProvider", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selWritableTypeIdentifiersForItemProviderXHandle), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual string[] WritableTypeIdentifiersForItemProvider {
			[Export ("writableTypeIdentifiersForItemProvider", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("ios16.0")]
			[SupportedOSPlatform ("macos13.0")]
			[SupportedOSPlatform ("maccatalyst16.0")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selWritableTypeIdentifiersForItemProviderXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selWritableTypeIdentifiersForItemProviderXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class SWCollaborationMetadata */
}
