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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreLocation {
	/// <summary>Provides support for converting between an address in
	/// text form and a location described using latitude and longitude or
	/// to convert from a latitue and longitude to a user-friendly
	/// location (street, city, state, country/region).</summary><remarks><para>Converting a latitude and longitude into a human-readable address is generally straightforward:</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// async void GeocodeToConsoleAsync (string address) {
	/// var geoCoder = new CLGeocoder();
	/// var placemarks = await geoCoder.GeocodeAddressAsync(address);
	/// foreach (var placemark in placemarks) {
	/// 	      Console.WriteLine(placemark);
	/// }   
	/// ]]></code></example><para>As is reverse-geocoding:</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// async void ReverseGeocodeToConsoleAsync (CLLocation location) {
	/// var geoCoder = new CLGeocoder();
	/// var placemarks = await geoCoder.ReverseGeocodeLocationAsync(location);
	/// foreach (var placemark in placemarks) {
	/// 	      Console.WriteLine(placemark);
	/// }          
	/// }
	/// ]]></code></example></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreLocation/Reference/CLGeocoder_class/index.html">Apple documentation for <c>CLGeocoder</c></related>
	[Register("CLGeocoder", true)]
	[ObsoletedOSPlatform ("ios26.0", "Use MapKit instead.")]
	[ObsoletedOSPlatform ("maccatalyst26.0", "Use MapKit instead.")]
	[ObsoletedOSPlatform ("tvos26.0", "Use MapKit instead.")]
	[ObsoletedOSPlatform ("macos26.0", "Use MapKit instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	public unsafe partial class CLGeocoder : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CLGeocoder");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="CLGeocoder" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CLGeocoder () : base (NSObjectFlag.Empty)
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
		protected CLGeocoder (NSObjectFlag t) : base (t)
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
		protected internal CLGeocoder (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>Cancels the geocoding attempt.</summary><remarks>To be added.</remarks>
		[Export ("cancelGeocode")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use 'MKGeocodingRequest' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CancelGeocode ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("cancelGeocode"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("cancelGeocode"));
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="addressDictionary">Addressbook dictionary to submit</param><param name="completionHandler">Method to invoke when the request completes.</param><summary>Developers should not use this deprecated method. Developers should use 'GeocodeAddress (string, CLRegion, NSLocale, CLGeocodeCompletionHandler)' instead.</summary><remarks></remarks>
		[Export ("geocodeAddressDictionary:completionHandler:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use 'MKGeocodingRequest' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GeocodeAddress (NSDictionary addressDictionary, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCLGeocodeCompletionHandler))]CLGeocodeCompletionHandler completionHandler)
		{
			var addressDictionary__handle__ = addressDictionary!.GetNonNullHandle (nameof (addressDictionary));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDCLGeocodeCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("geocodeAddressDictionary:completionHandler:"), addressDictionary__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("geocodeAddressDictionary:completionHandler:"), addressDictionary__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (addressDictionary);
		}
		/// <param name="addressDictionary">Addressbook dictionary to submit</param>
		/// <summary>Developers should not use this deprecated method. Developers should use 'GeocodeAddress (string, CLRegion, NSLocale, CLGeocodeCompletionHandler)' instead.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous GeocodeAddress operation.   The value of the TResult parameter is a <see cref="CoreLocation.CLGeocodeCompletionHandler" />.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use 'MKGeocodingRequest' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CLPlacemark[]> GeocodeAddressAsync (NSDictionary addressDictionary)
		{
			var tcs = new TaskCompletionSource<CLPlacemark[]> ();
			GeocodeAddress(addressDictionary, (placemarks_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (placemarks_!);
			});
			return tcs.Task;
		}
		/// <param name="addressString">Address that you want to submit.</param><param name="completionHandler">Method to invoke when the request completes.</param><summary>Request a latitude/longitude location from a human readable address.</summary><remarks></remarks>
		[Export ("geocodeAddressString:completionHandler:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use 'MKGeocodingRequest' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GeocodeAddress (string addressString, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCLGeocodeCompletionHandler))]CLGeocodeCompletionHandler completionHandler)
		{
			if (addressString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (addressString));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsaddressString = CFString.CreateNative (addressString);
			using var block_completionHandler = Trampolines.SDCLGeocodeCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("geocodeAddressString:completionHandler:"), nsaddressString, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("geocodeAddressString:completionHandler:"), nsaddressString, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsaddressString);
		}
		/// <param name="addressString">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous GeocodeAddress operation.   The value of the TResult parameter is a <see cref="CoreLocation.CLGeocodeCompletionHandler" />.</para>
		///         </returns>
		/// <remarks>
		///           <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		///   var addressString = "2 Park Plaza, Boston, MA, USA 02116";
		///   var geocoder = new CLGeocoder();
		///   var taskCoding = geocoder.GeocodeAddressAsync(addressString);
		///   taskCoding.ContinueWith((addresses) => {
		///   	foreach(var address in addresses.Result)
		///   	{
		///   		Console.WriteLine(address);
		///   	}
		///   });              
		///                 ]]></code>
		///           </example>
		///         </remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use 'MKGeocodingRequest' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CLPlacemark[]> GeocodeAddressAsync (string addressString)
		{
			var tcs = new TaskCompletionSource<CLPlacemark[]> ();
			GeocodeAddress(addressString, (placemarks_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (placemarks_!);
			});
			return tcs.Task;
		}
		/// <param name="addressString">Address that you want to submit.</param><param name="region">Region to limit the lookup for.</param><param name="completionHandler">Method to invoke when the request completes.</param><summary>Request a latitude/longitude location from a human readable address and region.</summary><remarks>To be added.</remarks>
		[Export ("geocodeAddressString:inRegion:completionHandler:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use 'MKGeocodingRequest' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GeocodeAddress (string addressString, CLRegion? region, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCLGeocodeCompletionHandler))]CLGeocodeCompletionHandler completionHandler)
		{
			if (addressString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (addressString));
			var region__handle__ = region.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsaddressString = CFString.CreateNative (addressString);
			using var block_completionHandler = Trampolines.SDCLGeocodeCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("geocodeAddressString:inRegion:completionHandler:"), nsaddressString, region__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("geocodeAddressString:inRegion:completionHandler:"), nsaddressString, region__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (region);
			CFString.ReleaseNative (nsaddressString);
		}
		/// <param name="addressString">To be added.</param>
		/// <param name="region">To be added.</param>
		/// <summary>Request a latitude/longitude location from a human readable address and region.</summary>
		/// <returns>A Task that represents the asynchronous geocoding operation.</returns>
		/// <remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use 'MKGeocodingRequest' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CLPlacemark[]> GeocodeAddressAsync (string addressString, CLRegion? region)
		{
			var tcs = new TaskCompletionSource<CLPlacemark[]> ();
			GeocodeAddress(addressString, region, (placemarks_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (placemarks_!);
			});
			return tcs.Task;
		}
		/// <param name="addressString">To be added.</param><param name="region"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="locale"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("geocodeAddressString:inRegion:preferredLocale:completionHandler:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use 'MKGeocodingRequest' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GeocodeAddress (string addressString, CLRegion? region, NSLocale? locale, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCLGeocodeCompletionHandler))]CLGeocodeCompletionHandler completionHandler)
		{
			if (addressString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (addressString));
			var region__handle__ = region.GetHandle ();
			var locale__handle__ = locale.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			var nsaddressString = CFString.CreateNative (addressString);
			using var block_completionHandler = Trampolines.SDCLGeocodeCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("geocodeAddressString:inRegion:preferredLocale:completionHandler:"), nsaddressString, region__handle__, locale__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("geocodeAddressString:inRegion:preferredLocale:completionHandler:"), nsaddressString, region__handle__, locale__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (region);
			GC.KeepAlive (locale);
			CFString.ReleaseNative (nsaddressString);
		}
		/// <param name="addressString">To be added.</param>
		/// <param name="region">To be added.</param>
		/// <param name="locale">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'MKGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use 'MKGeocodingRequest' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CLPlacemark[]> GeocodeAddressAsync (string addressString, CLRegion? region, NSLocale? locale)
		{
			var tcs = new TaskCompletionSource<CLPlacemark[]> ();
			GeocodeAddress(addressString, region, locale, (placemarks_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (placemarks_!);
			});
			return tcs.Task;
		}
		/// <param name="postalAddress">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("geocodePostalAddress:completionHandler:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GeocodePostalAddress (global::Contacts.CNPostalAddress postalAddress, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCLGeocodeCompletionHandler))]CLGeocodeCompletionHandler completionHandler)
		{
			var postalAddress__handle__ = postalAddress!.GetNonNullHandle (nameof (postalAddress));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDCLGeocodeCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("geocodePostalAddress:completionHandler:"), postalAddress__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("geocodePostalAddress:completionHandler:"), postalAddress__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (postalAddress);
		}
		/// <param name="postalAddress">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous GeocodePostalAddress operation.   The value of the TResult parameter is a CoreLocation.CLGeocodeCompletionHandler.</para>
		///         </returns>
		/// <remarks>
		///           <para copied="true">The GeocodePostalAddressAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CLPlacemark[]> GeocodePostalAddressAsync (global::Contacts.CNPostalAddress postalAddress)
		{
			var tcs = new TaskCompletionSource<CLPlacemark[]> ();
			GeocodePostalAddress(postalAddress, (placemarks_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (placemarks_!);
			});
			return tcs.Task;
		}
		/// <param name="postalAddress">To be added.</param><param name="locale"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("geocodePostalAddress:preferredLocale:completionHandler:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GeocodePostalAddress (global::Contacts.CNPostalAddress postalAddress, NSLocale? locale, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCLGeocodeCompletionHandler))]CLGeocodeCompletionHandler completionHandler)
		{
			var postalAddress__handle__ = postalAddress!.GetNonNullHandle (nameof (postalAddress));
			var locale__handle__ = locale.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDCLGeocodeCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("geocodePostalAddress:preferredLocale:completionHandler:"), postalAddress__handle__, locale__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("geocodePostalAddress:preferredLocale:completionHandler:"), postalAddress__handle__, locale__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (postalAddress);
			GC.KeepAlive (locale);
		}
		/// <param name="postalAddress">To be added.</param>
		/// <param name="locale">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CLPlacemark[]> GeocodePostalAddressAsync (global::Contacts.CNPostalAddress postalAddress, NSLocale? locale)
		{
			var tcs = new TaskCompletionSource<CLPlacemark[]> ();
			GeocodePostalAddress(postalAddress, locale, (placemarks_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (placemarks_!);
			});
			return tcs.Task;
		}
		/// <param name="location">Location to look up.</param><param name="completionHandler">Method to invoke when the reverse lookup has completed.</param><summary>Requests a longitude/latitude to a human address.</summary><remarks></remarks>
		[Export ("reverseGeocodeLocation:completionHandler:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReverseGeocodeLocation (CLLocation location, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCLGeocodeCompletionHandler))]CLGeocodeCompletionHandler completionHandler)
		{
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDCLGeocodeCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("reverseGeocodeLocation:completionHandler:"), location__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("reverseGeocodeLocation:completionHandler:"), location__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (location);
		}
		/// <param name="location">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>
		///           <para>A task that represents the asynchronous ReverseGeocodeLocation operation.   The value of the TResult parameter is a <see cref="CoreLocation.CLGeocodeCompletionHandler" />.</para>
		///         </returns>
		/// <remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CLPlacemark[]> ReverseGeocodeLocationAsync (CLLocation location)
		{
			var tcs = new TaskCompletionSource<CLPlacemark[]> ();
			ReverseGeocodeLocation(location, (placemarks_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (placemarks_!);
			});
			return tcs.Task;
		}
		/// <param name="location">To be added.</param><param name="locale"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("reverseGeocodeLocation:preferredLocale:completionHandler:")]
		[ObsoletedOSPlatform ("ios26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReverseGeocodeLocation (CLLocation location, NSLocale? locale, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDCLGeocodeCompletionHandler))]CLGeocodeCompletionHandler completionHandler)
		{
			var location__handle__ = location!.GetNonNullHandle (nameof (location));
			var locale__handle__ = locale.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDCLGeocodeCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("reverseGeocodeLocation:preferredLocale:completionHandler:"), location__handle__, locale__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("reverseGeocodeLocation:preferredLocale:completionHandler:"), location__handle__, locale__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (location);
			GC.KeepAlive (locale);
		}
		/// <param name="location">To be added.</param>
		/// <param name="locale">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>To be added.</returns>
		/// <remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("ios26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("maccatalyst26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("tvos26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[ObsoletedOSPlatform ("macos26.0", "Use 'MKReverseGeocodingRequest' instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<CLPlacemark[]> ReverseGeocodeLocationAsync (CLLocation location, NSLocale? locale)
		{
			var tcs = new TaskCompletionSource<CLPlacemark[]> ();
			ReverseGeocodeLocation(location, locale, (placemarks_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (placemarks_!);
			});
			return tcs.Task;
		}
		/// <summary>Whether a geocoding request is currently being processed.</summary><value><see langword="true" /> if the <see cref="T:CoreLocation.CLGeocoder" /> is in the process of geocoding.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Geocoding {
			[Export ("isGeocoding")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isGeocoding"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isGeocoding"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
	} /* class CLGeocoder */
}
