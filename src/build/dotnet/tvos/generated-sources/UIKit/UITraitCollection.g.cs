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
using UIKit;
using GLKit;
using Metal;
using CoreML;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	[Register("UITraitCollection", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class UITraitCollection : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("UITraitCollection");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="UITraitCollection" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public UITraitCollection () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
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
		public UITraitCollection (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
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
		protected UITraitCollection (NSObjectFlag t) : base (t)
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
		protected internal UITraitCollection (NativeHandle handle) : base (handle)
		{
		}

		[Export ("containsTraitsInCollection:")]
		[ObsoletedOSPlatform ("ios17.0", "Compare the values for the specific items instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Compare the values for the specific items instead.")]
		[ObsoletedOSPlatform ("tvos17.0", "Compare the values for the specific items instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Contains (UITraitCollection trait)
		{
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("containsTraitsInCollection:"), trait__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("containsTraitsInCollection:"), trait__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (trait);
			return ret != 0;
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
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
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[Export ("traitCollectionWithAccessibilityContrast:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITraitCollection FromAccessibilityContrast (UIAccessibilityContrast accessibilityContrast)
		{
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("traitCollectionWithAccessibilityContrast:"), (IntPtr) (long) accessibilityContrast), false)!;
			return ret;
		}
		[Export ("traitCollectionWithActiveAppearance:")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITraitCollection FromActiveAppearance (global::UIKit.UIUserInterfaceActiveAppearance userInterfaceActiveAppearance)
		{
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("traitCollectionWithActiveAppearance:"), (IntPtr) (long) userInterfaceActiveAppearance), false)!;
			return ret;
		}
		[Export ("traitCollectionWithDisplayGamut:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITraitCollection FromDisplayGamut (UIDisplayGamut displayGamut)
		{
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("traitCollectionWithDisplayGamut:"), (IntPtr) (long) displayGamut), false)!;
			return ret;
		}
		/// <param name="scale">Display scale to set.</param><summary>Creates a new UITraitCollection object where only the display scale has been specified.</summary><returns>New instance of UITraitCollection with a single element specified.</returns><remarks></remarks>
		[Export ("traitCollectionWithDisplayScale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITraitCollection FromDisplayScale (nfloat scale)
		{
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat (class_ptr, Selector.GetHandle ("traitCollectionWithDisplayScale:"), scale), false)!;
			return ret;
		}
		[Export ("traitCollectionWithForceTouchCapability:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITraitCollection FromForceTouchCapability (UIForceTouchCapability capability)
		{
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("traitCollectionWithForceTouchCapability:"), (IntPtr) (long) capability), false)!;
			return ret;
		}
		[Export ("traitCollectionWithHorizontalSizeClass:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITraitCollection FromHorizontalSizeClass (UIUserInterfaceSizeClass horizontalSizeClass)
		{
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("traitCollectionWithHorizontalSizeClass:"), (IntPtr) (long) horizontalSizeClass), false)!;
			return ret;
		}
		[Export ("traitCollectionWithLayoutDirection:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITraitCollection FromLayoutDirection (UITraitEnvironmentLayoutDirection layoutDirection)
		{
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("traitCollectionWithLayoutDirection:"), (IntPtr) (long) layoutDirection), false)!;
			return ret;
		}
		[Export ("traitCollectionWithLegibilityWeight:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITraitCollection FromLegibilityWeight (UILegibilityWeight legibilityWeight)
		{
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("traitCollectionWithLegibilityWeight:"), (IntPtr) (long) legibilityWeight), false)!;
			return ret;
		}
		[Export ("traitCollectionWithPreferredContentSizeCategory:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITraitCollection FromPreferredContentSizeCategory (NSString preferredContentSizeCategory)
		{
			var preferredContentSizeCategory__handle__ = preferredContentSizeCategory!.GetNonNullHandle (nameof (preferredContentSizeCategory));
			UITraitCollection? ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("traitCollectionWithPreferredContentSizeCategory:"), preferredContentSizeCategory__handle__), false)!;
			GC.KeepAlive (preferredContentSizeCategory);
			return ret!;
		}
		[Export ("traitCollectionWithSceneCaptureState:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITraitCollection FromSceneCaptureState (UISceneCaptureState sceneCaptureState)
		{
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("traitCollectionWithSceneCaptureState:"), (IntPtr) (long) sceneCaptureState), false)!;
			return ret;
		}
		[Export ("traitCollectionWithTraitsFromCollections:")]
		[ObsoletedOSPlatform ("ios17.0", "Use 'GetTraitCollectionWithTraits(UITraitMutations)' and 'GetTraitCollectionByModifyingTraits(UITraitMutations)' instead.")]
		[ObsoletedOSPlatform ("maccatalyst17.0", "Use 'GetTraitCollectionWithTraits(UITraitMutations)' and 'GetTraitCollectionByModifyingTraits(UITraitMutations)' instead.")]
		[ObsoletedOSPlatform ("tvos17.0", "Use 'GetTraitCollectionWithTraits(UITraitMutations)' and 'GetTraitCollectionByModifyingTraits(UITraitMutations)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITraitCollection FromTraitsFromCollections (UITraitCollection[] traitCollections)
		{
			if (traitCollections is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (traitCollections));
			using var nsa_traitCollections = NSArray.FromNSObjects (traitCollections);
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("traitCollectionWithTraitsFromCollections:"), nsa_traitCollections.Handle), false)!;
			return ret;
		}
		[Export ("traitCollectionWithUserInterfaceIdiom:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITraitCollection FromUserInterfaceIdiom (UIUserInterfaceIdiom idiom)
		{
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("traitCollectionWithUserInterfaceIdiom:"), (IntPtr) (long) idiom), false)!;
			return ret;
		}
		[Export ("traitCollectionWithUserInterfaceStyle:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITraitCollection FromUserInterfaceStyle (UIUserInterfaceStyle userInterfaceStyle)
		{
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("traitCollectionWithUserInterfaceStyle:"), (IntPtr) (long) userInterfaceStyle), false)!;
			return ret;
		}
		[Export ("traitCollectionWithVerticalSizeClass:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITraitCollection FromVerticalSizeClass (UIUserInterfaceSizeClass verticalSizeClass)
		{
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("traitCollectionWithVerticalSizeClass:"), (IntPtr) (long) verticalSizeClass), false)!;
			return ret;
		}
		[Export ("changedTraitsFromTraitCollection:")]
		[Obsolete ("Use 'GetChangedTraits2' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSet<IUITraitDefinition> GetChangedTraits (UITraitCollection? traitCollection)
		{
			var traitCollection__handle__ = traitCollection.GetHandle ();
			NSSet<IUITraitDefinition>? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSSet<IUITraitDefinition>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("changedTraitsFromTraitCollection:"), traitCollection__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSSet<IUITraitDefinition>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("changedTraitsFromTraitCollection:"), traitCollection__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (traitCollection);
			return ret!;
		}
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSSet<Class> GetChangedTraits2 (UITraitCollection? traitCollection)
		{
			var traitCollection__handle__ = traitCollection.GetHandle ();
			NSSet<Class>? ret;
			ret =  Runtime.GetNSObject<NSSet<Class>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("changedTraitsFromTraitCollection:"), traitCollection__handle__), false)!;
			GC.KeepAlive (traitCollection);
			return ret!;
		}
		[Export ("objectForTrait:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetObject (IUIObjectTraitDefinition trait)
		{
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("objectForTrait:"), trait__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("objectForTrait:"), trait__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (trait);
			return ret!;
		}
		[Export ("traitCollectionWithToolbarItemPresentationSize:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITraitCollection GetTraitCollection (UINSToolbarItemPresentationSize toolbarItemPresentationSize)
		{
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("traitCollectionWithToolbarItemPresentationSize:"), (IntPtr) (long) toolbarItemPresentationSize), false)!;
			return ret;
		}
		[Export ("traitCollectionWithTypesettingLanguage:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITraitCollection GetTraitCollection (string language)
		{
			if (language is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (language));
			var nslanguage = CFString.CreateNative (language);
			UITraitCollection? ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("traitCollectionWithTypesettingLanguage:"), nslanguage), false)!;
			CFString.ReleaseNative (nslanguage);
			return ret!;
		}
		[Export ("traitCollectionWithImageDynamicRange:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITraitCollection GetTraitCollection (UIImageDynamicRange imageDynamicRange)
		{
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("traitCollectionWithImageDynamicRange:"), (IntPtr) (long) imageDynamicRange), false)!;
			return ret;
		}
		[Export ("traitCollectionWithListEnvironment:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITraitCollection GetTraitCollection (UIListEnvironment listEnvironment)
		{
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("traitCollectionWithListEnvironment:"), (IntPtr) (long) listEnvironment), false)!;
			return ret;
		}
		[Export ("traitCollectionWithHDRHeadroomUsageLimit:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITraitCollection GetTraitCollection (UIHdrHeadroomUsageLimit hdrHeadroomUsageLimit)
		{
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("traitCollectionWithHDRHeadroomUsageLimit:"), (IntPtr) (long) hdrHeadroomUsageLimit), false)!;
			return ret;
		}
		[Export ("traitCollectionWithResolvesNaturalAlignmentWithBaseWritingDirection:")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITraitCollection GetTraitCollection (bool resolvesNaturalAlignmentWithBaseWritingDirection)
		{
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool (class_ptr, Selector.GetHandle ("traitCollectionWithResolvesNaturalAlignmentWithBaseWritingDirection:"), resolvesNaturalAlignmentWithBaseWritingDirection ? (byte) 1 : (byte) 0), false)!;
			return ret;
		}
		[Export ("traitCollectionByModifyingTraits:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual UITraitCollection GetTraitCollectionByModifyingTraits ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUITraitMutations))]UITraitMutations mutations)
		{
			if (mutations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mutations));
			using var block_mutations = Trampolines.SDUITraitMutations.CreateBlock (mutations);
			BlockLiteral *block_ptr_mutations = &block_mutations;
			UITraitCollection ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("traitCollectionByModifyingTraits:"), (IntPtr) block_ptr_mutations), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("traitCollectionByModifyingTraits:"), (IntPtr) block_ptr_mutations), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("traitCollectionByReplacingObject:forTrait:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITraitCollection GetTraitCollectionByReplacingObject (NSObject? @object, IUIObjectTraitDefinition trait)
		{
			var @object__handle__ = @object.GetHandle ();
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			UITraitCollection? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("traitCollectionByReplacingObject:forTrait:"), @object__handle__, trait__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("traitCollectionByReplacingObject:forTrait:"), @object__handle__, trait__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (@object);
			GC.KeepAlive (trait);
			return ret!;
		}
		[Export ("traitCollectionByReplacingCGFloatValue:forTrait:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITraitCollection GetTraitCollectionByReplacingValue (nfloat value, IUICGFloatTraitDefinition trait)
		{
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			UITraitCollection? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_NativeHandle (this.Handle, Selector.GetHandle ("traitCollectionByReplacingCGFloatValue:forTrait:"), value, trait__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_nfloat_NativeHandle (&__objc_super__, Selector.GetHandle ("traitCollectionByReplacingCGFloatValue:forTrait:"), value, trait__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (trait);
			return ret!;
		}
		[Export ("traitCollectionWithObject:forTrait:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITraitCollection GetTraitCollectionWithObject (NSObject? @object, IUIObjectTraitDefinition trait)
		{
			var @object__handle__ = @object.GetHandle ();
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			UITraitCollection? ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("traitCollectionWithObject:forTrait:"), @object__handle__, trait__handle__), false)!;
			GC.KeepAlive (@object);
			GC.KeepAlive (trait);
			return ret!;
		}
		[Export ("traitCollectionWithTraits:")]
		[Obsolete ("Use the overload that takes a 'UITraitMutations' parameter instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static UITraitCollection GetTraitCollectionWithTraits ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity1V5))]global::System.Func<IUIMutableTraits> mutations)
		{
			if (mutations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mutations));
			using var block_mutations = Trampolines.SDFuncArity1V5.CreateBlock (mutations);
			BlockLiteral *block_ptr_mutations = &block_mutations;
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("traitCollectionWithTraits:"), (IntPtr) block_ptr_mutations), false)!;
			return ret;
		}
		[Export ("traitCollectionWithTraits:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static UITraitCollection GetTraitCollectionWithTraits ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDUITraitMutations))]UITraitMutations mutations)
		{
			if (mutations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (mutations));
			using var block_mutations = Trampolines.SDUITraitMutations.CreateBlock (mutations);
			BlockLiteral *block_ptr_mutations = &block_mutations;
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("traitCollectionWithTraits:"), (IntPtr) block_ptr_mutations), false)!;
			return ret;
		}
		[Export ("traitCollectionWithCGFloatValue:forTrait:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITraitCollection GetTraitCollectionWithValue (nfloat value, IUICGFloatTraitDefinition trait)
		{
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			UITraitCollection? ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_nfloat_NativeHandle (class_ptr, Selector.GetHandle ("traitCollectionWithCGFloatValue:forTrait:"), value, trait__handle__), false)!;
			GC.KeepAlive (trait);
			return ret!;
		}
		[Export ("traitCollectionWithNSIntegerValue:forTrait:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static UITraitCollection GetTraitCollectionWithValue (nint value, IUINSIntegerTraitDefinition trait)
		{
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			UITraitCollection? ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (class_ptr, Selector.GetHandle ("traitCollectionWithNSIntegerValue:forTrait:"), value, trait__handle__), false)!;
			GC.KeepAlive (trait);
			return ret!;
		}
		[Export ("valueForCGFloatTrait:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetValueForTrait (IUICGFloatTraitDefinition trait)
		{
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("valueForCGFloatTrait:"), trait__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("valueForCGFloatTrait:"), trait__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (trait);
			return ret!;
		}
		[Export ("valueForNSIntegerTrait:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetValueForTrait (IUINSIntegerTraitDefinition trait)
		{
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("valueForNSIntegerTrait:"), trait__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("valueForNSIntegerTrait:"), trait__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (trait);
			return ret!;
		}
		[Export ("hasDifferentColorAppearanceComparedToTraitCollection:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasDifferentColorAppearanceComparedTo (UITraitCollection? traitCollection)
		{
			var traitCollection__handle__ = traitCollection.GetHandle ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("hasDifferentColorAppearanceComparedToTraitCollection:"), traitCollection__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("hasDifferentColorAppearanceComparedToTraitCollection:"), traitCollection__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (traitCollection);
			return ret != 0;
		}
		[Export ("performAsCurrentTraitCollection:")]
		[ThreadSafe]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void PerformAsCurrentTraitCollection ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action actions)
		{
			if (actions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (actions));
			using var block_actions = Trampolines.SDAction.CreateBlock (actions);
			BlockLiteral *block_ptr_actions = &block_actions;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("performAsCurrentTraitCollection:"), (IntPtr) block_ptr_actions);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("performAsCurrentTraitCollection:"), (IntPtr) block_ptr_actions);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("traitCollectionByReplacingNSIntegerValue:forTrait:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UITraitCollection TraitCollectionByReplacingValue (nint value, IUINSIntegerTraitDefinition trait)
		{
			var trait__handle__ = trait!.GetNonNullHandle (nameof (trait));
			UITraitCollection? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("traitCollectionByReplacingNSIntegerValue:forTrait:"), value, trait__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("traitCollectionByReplacingNSIntegerValue:forTrait:"), value, trait__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (trait);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIAccessibilityContrast AccessibilityContrast {
			[Export ("accessibilityContrast")]
			get {
				UIAccessibilityContrast ret;
				if (IsDirectBinding) {
					ret = (UIAccessibilityContrast) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityContrast"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIAccessibilityContrast) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityContrast"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual global::UIKit.UIUserInterfaceActiveAppearance ActiveAppearance {
			[Export ("activeAppearance")]
			get {
				global::UIKit.UIUserInterfaceActiveAppearance ret;
				if (IsDirectBinding) {
					ret = (UIUserInterfaceActiveAppearance) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("activeAppearance"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIUserInterfaceActiveAppearance) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("activeAppearance"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static UITraitCollection CurrentTraitCollection {
			[Export ("currentTraitCollection", ArgumentSemantic.Retain)]
			get {
				UITraitCollection? ret;
				ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("currentTraitCollection")), false)!;
				return ret!;
			}
			[Export ("setCurrentTraitCollection:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("setCurrentTraitCollection:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIDisplayGamut DisplayGamut {
			[Export ("displayGamut")]
			get {
				UIDisplayGamut ret;
				if (IsDirectBinding) {
					ret = (UIDisplayGamut) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("displayGamut"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIDisplayGamut) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("displayGamut"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat DisplayScale {
			[Export ("displayScale")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("displayScale"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("displayScale"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIForceTouchCapability ForceTouchCapability {
			[Export ("forceTouchCapability")]
			get {
				UIForceTouchCapability ret;
				if (IsDirectBinding) {
					ret = (UIForceTouchCapability) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("forceTouchCapability"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIForceTouchCapability) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("forceTouchCapability"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual UIHdrHeadroomUsageLimit HdrHeadroomUsageLimit {
			[Export ("hdrHeadroomUsageLimit")]
			get {
				UIHdrHeadroomUsageLimit ret;
				if (IsDirectBinding) {
					ret = (UIHdrHeadroomUsageLimit) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("hdrHeadroomUsageLimit"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIHdrHeadroomUsageLimit) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("hdrHeadroomUsageLimit"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIUserInterfaceSizeClass HorizontalSizeClass {
			[Export ("horizontalSizeClass")]
			get {
				UIUserInterfaceSizeClass ret;
				if (IsDirectBinding) {
					ret = (UIUserInterfaceSizeClass) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("horizontalSizeClass"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIUserInterfaceSizeClass) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("horizontalSizeClass"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UIImageConfiguration ImageConfiguration {
			[Export ("imageConfiguration", ArgumentSemantic.Retain)]
			get {
				UIImageConfiguration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIImageConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("imageConfiguration")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<UIImageConfiguration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("imageConfiguration")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public virtual UIImageDynamicRange ImageDynamicRange {
			[Export ("imageDynamicRange")]
			get {
				UIImageDynamicRange ret;
				if (IsDirectBinding) {
					ret = (UIImageDynamicRange) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("imageDynamicRange"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIImageDynamicRange) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("imageDynamicRange"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UITraitEnvironmentLayoutDirection LayoutDirection {
			[Export ("layoutDirection")]
			get {
				UITraitEnvironmentLayoutDirection ret;
				if (IsDirectBinding) {
					ret = (UITraitEnvironmentLayoutDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("layoutDirection"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UITraitEnvironmentLayoutDirection) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("layoutDirection"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual UILegibilityWeight LegibilityWeight {
			[Export ("legibilityWeight")]
			get {
				UILegibilityWeight ret;
				if (IsDirectBinding) {
					ret = (UILegibilityWeight) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("legibilityWeight"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UILegibilityWeight) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("legibilityWeight"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public virtual UIListEnvironment ListEnvironment {
			[Export ("listEnvironment")]
			get {
				UIListEnvironment ret;
				if (IsDirectBinding) {
					ret = (UIListEnvironment) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("listEnvironment"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIListEnvironment) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("listEnvironment"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual string PreferredContentSizeCategory {
			[Export ("preferredContentSizeCategory")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("preferredContentSizeCategory")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("preferredContentSizeCategory")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual bool ResolvesNaturalAlignmentWithBaseWritingDirection {
			[Export ("resolvesNaturalAlignmentWithBaseWritingDirection")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("resolvesNaturalAlignmentWithBaseWritingDirection"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("resolvesNaturalAlignmentWithBaseWritingDirection"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public virtual UISceneCaptureState SceneCaptureState {
			[Export ("sceneCaptureState")]
			get {
				UISceneCaptureState ret;
				if (IsDirectBinding) {
					ret = (UISceneCaptureState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("sceneCaptureState"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UISceneCaptureState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("sceneCaptureState"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public virtual UISplitViewControllerLayoutEnvironment SplitViewControllerLayoutEnvironment {
			[Export ("splitViewControllerLayoutEnvironment")]
			get {
				UISplitViewControllerLayoutEnvironment ret;
				if (IsDirectBinding) {
					ret = (UISplitViewControllerLayoutEnvironment) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("splitViewControllerLayoutEnvironment"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UISplitViewControllerLayoutEnvironment) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("splitViewControllerLayoutEnvironment"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Obsolete ("Use 'SystemTraitsAffectingColorAppearance2' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static IUITraitDefinition[] SystemTraitsAffectingColorAppearance {
			[Export ("systemTraitsAffectingColorAppearance")]
			get {
				IUITraitDefinition[]? ret;
				ret = CFArray.ArrayFromHandle<IUITraitDefinition>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("systemTraitsAffectingColorAppearance")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public Class[] SystemTraitsAffectingColorAppearance2 {
			get {
				Class[] ret;
				ret = CFArray.ArrayFromHandle<Class>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("systemTraitsAffectingColorAppearance")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Obsolete ("Use 'SystemTraitsAffectingImageLookup2' instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public static IUITraitDefinition[] SystemTraitsAffectingImageLookup {
			[Export ("systemTraitsAffectingImageLookup")]
			get {
				IUITraitDefinition[]? ret;
				ret = CFArray.ArrayFromHandle<IUITraitDefinition>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("systemTraitsAffectingImageLookup")), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public Class[] SystemTraitsAffectingImageLookup2 {
			get {
				Class[] ret;
				ret = CFArray.ArrayFromHandle<Class>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, Selector.GetHandle ("systemTraitsAffectingImageLookup")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public virtual UINSToolbarItemPresentationSize ToolbarItemPresentationSize {
			[Export ("toolbarItemPresentationSize")]
			get {
				UINSToolbarItemPresentationSize ret;
				if (IsDirectBinding) {
					ret = (UINSToolbarItemPresentationSize) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("toolbarItemPresentationSize"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UINSToolbarItemPresentationSize) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("toolbarItemPresentationSize"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		public virtual string TypesettingLanguage {
			[Export ("typesettingLanguage")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("typesettingLanguage")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("typesettingLanguage")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIUserInterfaceIdiom UserInterfaceIdiom {
			[Export ("userInterfaceIdiom")]
			get {
				UIUserInterfaceIdiom ret;
				if (IsDirectBinding) {
					ret = (UIUserInterfaceIdiom) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userInterfaceIdiom"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIUserInterfaceIdiom) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("userInterfaceIdiom"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public virtual UIUserInterfaceStyle UserInterfaceStyle {
			[Export ("userInterfaceStyle")]
			get {
				UIUserInterfaceStyle ret;
				if (IsDirectBinding) {
					ret = (UIUserInterfaceStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userInterfaceStyle"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIUserInterfaceStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("userInterfaceStyle"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIUserInterfaceSizeClass VerticalSizeClass {
			[Export ("verticalSizeClass")]
			get {
				UIUserInterfaceSizeClass ret;
				if (IsDirectBinding) {
					ret = (UIUserInterfaceSizeClass) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("verticalSizeClass"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (UIUserInterfaceSizeClass) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("verticalSizeClass"));
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class UITraitCollection */
}
