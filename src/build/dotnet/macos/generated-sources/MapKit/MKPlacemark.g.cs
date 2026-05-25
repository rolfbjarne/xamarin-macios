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
namespace MapKit {
	[Register("MKPlacemark", true)]
	[UnsupportedOSPlatform ("ios26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
	[UnsupportedOSPlatform ("tvos26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
	[UnsupportedOSPlatform ("macos26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
	[UnsupportedOSPlatform ("maccatalyst26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MKPlacemark : global::CoreLocation.CLPlacemark, IMKAnnotation, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCoordinateX = "coordinate";
		static readonly NativeHandle selCoordinateXHandle = Selector.GetHandle ("coordinate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCountryCodeX = "countryCode";
		static readonly NativeHandle selCountryCodeXHandle = Selector.GetHandle ("countryCode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoordinate_X = "initWithCoordinate:";
		static readonly NativeHandle selInitWithCoordinate_XHandle = Selector.GetHandle ("initWithCoordinate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoordinate_AddressDictionary_X = "initWithCoordinate:addressDictionary:";
		static readonly NativeHandle selInitWithCoordinate_AddressDictionary_XHandle = Selector.GetHandle ("initWithCoordinate:addressDictionary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoordinate_PostalAddress_X = "initWithCoordinate:postalAddress:";
		static readonly NativeHandle selInitWithCoordinate_PostalAddress_XHandle = Selector.GetHandle ("initWithCoordinate:postalAddress:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCoordinate_X = "setCoordinate:";
		static readonly NativeHandle selSetCoordinate_XHandle = Selector.GetHandle ("setCoordinate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubtitleX = "subtitle";
		static readonly NativeHandle selSubtitleXHandle = Selector.GetHandle ("subtitle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTitleX = "title";
		static readonly NativeHandle selTitleXHandle = Selector.GetHandle ("title");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MKPlacemark");
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
		public MKPlacemark (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MKPlacemark (NSObjectFlag t) : base (t)
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
		protected internal MKPlacemark (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithCoordinate:addressDictionary:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MKPlacemark (global::CoreLocation.CLLocationCoordinate2D coordinate, NSDictionary? addressDictionary)
			: base (NSObjectFlag.Empty)
		{
			var addressDictionary__handle__ = addressDictionary.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CLLocationCoordinate2D_NativeHandle (this.Handle, selInitWithCoordinate_AddressDictionary_XHandle, coordinate, addressDictionary__handle__), "initWithCoordinate:addressDictionary:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CLLocationCoordinate2D_NativeHandle (&__objc_super__, selInitWithCoordinate_AddressDictionary_XHandle, coordinate, addressDictionary__handle__), "initWithCoordinate:addressDictionary:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (addressDictionary);
		}
		[Export ("initWithCoordinate:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[UnsupportedOSPlatform ("tvos26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[UnsupportedOSPlatform ("macos26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[UnsupportedOSPlatform ("maccatalyst26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MKPlacemark (global::CoreLocation.CLLocationCoordinate2D coordinate)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CLLocationCoordinate2D (this.Handle, selInitWithCoordinate_XHandle, coordinate), "initWithCoordinate:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CLLocationCoordinate2D (&__objc_super__, selInitWithCoordinate_XHandle, coordinate), "initWithCoordinate:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithCoordinate:postalAddress:")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[UnsupportedOSPlatform ("tvos26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[UnsupportedOSPlatform ("macos26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[UnsupportedOSPlatform ("maccatalyst26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MKPlacemark (global::CoreLocation.CLLocationCoordinate2D coordinate, global::Contacts.CNPostalAddress postalAddress)
			: base (NSObjectFlag.Empty)
		{
			var postalAddress__handle__ = postalAddress!.GetNonNullHandle (nameof (postalAddress));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CLLocationCoordinate2D_NativeHandle (this.Handle, selInitWithCoordinate_PostalAddress_XHandle, coordinate, postalAddress__handle__), "initWithCoordinate:postalAddress:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CLLocationCoordinate2D_NativeHandle (&__objc_super__, selInitWithCoordinate_PostalAddress_XHandle, coordinate, postalAddress__handle__), "initWithCoordinate:postalAddress:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (postalAddress);
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[UnsupportedOSPlatform ("ios26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[UnsupportedOSPlatform ("tvos26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[UnsupportedOSPlatform ("macos26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[UnsupportedOSPlatform ("maccatalyst26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual NSObject Copy (NSZone? zone)
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
		/// <param name="value">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setCoordinate:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[UnsupportedOSPlatform ("tvos26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[UnsupportedOSPlatform ("macos26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[UnsupportedOSPlatform ("maccatalyst26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCoordinate (global::CoreLocation.CLLocationCoordinate2D value)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_CLLocationCoordinate2D (this.Handle, selSetCoordinate_XHandle, value);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CLLocationCoordinate2D (&__objc_super__, selSetCoordinate_XHandle, value);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[UnsupportedOSPlatform ("tvos26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[UnsupportedOSPlatform ("macos26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[UnsupportedOSPlatform ("maccatalyst26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual global::CoreLocation.CLLocationCoordinate2D Coordinate {
			[Export ("coordinate")]
			[UnsupportedOSPlatform ("ios26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
			[UnsupportedOSPlatform ("tvos26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
			[UnsupportedOSPlatform ("macos26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
			[UnsupportedOSPlatform ("maccatalyst26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				global::CoreLocation.CLLocationCoordinate2D ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CLLocationCoordinate2D_objc_msgSend (this.Handle, selCoordinateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CLLocationCoordinate2D_objc_msgSendSuper (&__objc_super__, selCoordinateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? CountryCode {
			[Export ("countryCode")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCountryCodeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCountryCodeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[UnsupportedOSPlatform ("tvos26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[UnsupportedOSPlatform ("macos26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[UnsupportedOSPlatform ("maccatalyst26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string? Subtitle {
			[Export ("subtitle", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("ios26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
			[UnsupportedOSPlatform ("tvos26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
			[UnsupportedOSPlatform ("macos26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
			[UnsupportedOSPlatform ("maccatalyst26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSubtitleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSubtitleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[UnsupportedOSPlatform ("tvos26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[UnsupportedOSPlatform ("macos26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[UnsupportedOSPlatform ("maccatalyst26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string? Title {
			[Export ("title", ArgumentSemantic.Copy)]
			[UnsupportedOSPlatform ("ios26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
			[UnsupportedOSPlatform ("tvos26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
			[UnsupportedOSPlatform ("macos26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
			[UnsupportedOSPlatform ("maccatalyst26.0", "Use 'MKMapItem.Location', 'MKMapItem.Address' and 'MKMapItem.AddressRepresentations' instead, and MKAddressRepresentations for formatted address strings.")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
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
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CalloutInfoDidChangeNotification;
		/// <summary>Notification constant for CalloutInfoDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveCalloutInfoDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveCalloutInfoDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = MKPlacemark.Notifications.ObserveCalloutInfoDidChange ((sender, args) => {
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
		/// void Callback (object sender, MKPlacemark.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = MKPlacemark.Notifications.ObserveCalloutInfoDidChange (Callback);
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
		///     MKPlacemark.CalloutInfoDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification CalloutInfoDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification CalloutInfoDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (MKPlacemark.CalloutInfoDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("MKAnnotationCalloutInfoDidChangeNotification",  "MapKit")]
		[Advice ("Use MKPlacemark.Notifications.ObserveCalloutInfoDidChange helper method instead.")]
		public static NSString CalloutInfoDidChangeNotification {
			get {
				if (_CalloutInfoDidChangeNotification is null)
					_CalloutInfoDidChangeNotification = Dlfcn.GetStringConstant (Libraries.MapKit.Handle, "MKAnnotationCalloutInfoDidChangeNotification")!;
				return _CalloutInfoDidChangeNotification;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::MapKit.MKPlacemark" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::MapKit.MKPlacemark.CalloutInfoDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::MapKit.MKPlacemark.CalloutInfoDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = MKPlacemark.Notifications.ObserveCalloutInfoDidChange ((notification) => {
			///   Console.WriteLine ("Observed CalloutInfoDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveCalloutInfoDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (CalloutInfoDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::MapKit.MKPlacemark.CalloutInfoDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::MapKit.MKPlacemark.CalloutInfoDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = MKPlacemark.Notifications.ObserveCalloutInfoDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed CalloutInfoDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveCalloutInfoDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (CalloutInfoDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class MKPlacemark */
}
