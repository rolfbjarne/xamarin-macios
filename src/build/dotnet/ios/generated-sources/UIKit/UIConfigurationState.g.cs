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
namespace UIKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>UIConfigurationState</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "UIConfigurationState", WrapperType = typeof (UIConfigurationStateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetCustomState", Selector = "customStateForKey:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetCustomState", Selector = "setCustomState:forKey:", ParameterType = new Type [] { typeof (NSObject), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetObject", Selector = "objectForKeyedSubscript:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetObject", Selector = "setObject:forKeyedSubscript:", ParameterType = new Type [] { typeof (NSObject), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TraitCollection", Selector = "traitCollection", PropertyType = typeof (UITraitCollection), GetterSelector = "traitCollection", SetterSelector = "setTraitCollection:", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface IUIConfigurationState : INativeObject, IDisposable, 
		Foundation.INSCoding
		, Foundation.INSCopying
		, Foundation.INSSecureCoding
	{
		[global::Foundation.RequiredMember]
		[Export ("customStateForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetCustomState (string key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject? _GetCustomState (IUIConfigurationState This, string key)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("customStateForKey:"), nskey), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("setCustomState:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCustomState (NSObject? customState, string key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetCustomState (IUIConfigurationState This, NSObject? customState, string key)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var customState__handle__ = customState.GetHandle ();
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("setCustomState:forKey:"), customState__handle__, nskey);
			GC.KeepAlive (This);
			GC.KeepAlive (customState);
			CFString.ReleaseNative (nskey);
		}
		[global::Foundation.RequiredMember]
		[Export ("objectForKeyedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? GetObject (string key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject? _GetObject (IUIConfigurationState This, string key)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("objectForKeyedSubscript:"), nskey), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("setObject:forKeyedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObject (NSObject? obj, string key)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetObject (IUIConfigurationState This, NSObject? obj, string key)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var obj__handle__ = obj.GetHandle ();
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("setObject:forKeyedSubscript:"), obj__handle__, nskey);
			GC.KeepAlive (This);
			GC.KeepAlive (obj);
			CFString.ReleaseNative (nskey);
		}
		[DynamicDependencyAttribute ("GetCustomState(System.String)")]
		[DynamicDependencyAttribute ("GetObject(System.String)")]
		[DynamicDependencyAttribute ("SetCustomState(Foundation.NSObject,System.String)")]
		[DynamicDependencyAttribute ("SetObject(Foundation.NSObject,System.String)")]
		[DynamicDependencyAttribute ("TraitCollection")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIConfigurationStateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUIConfigurationState ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UITraitCollection TraitCollection {
			[Export ("traitCollection", ArgumentSemantic.Retain)]
			get {
				return _GetTraitCollection (this);
			}
			[Export ("setTraitCollection:", ArgumentSemantic.Retain)]
			set {
				_SetTraitCollection (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITraitCollection _GetTraitCollection (IUIConfigurationState This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITraitCollection ret;
			ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("traitCollection")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetTraitCollection (IUIConfigurationState This, UITraitCollection value)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setTraitCollection:"), value__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (value);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UIConfigurationStateWrapper : BaseWrapper, IUIConfigurationState {
		public UIConfigurationStateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UIConfigurationStateWrapper))]
		static UIConfigurationStateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("customStateForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? GetCustomState (string key)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("customStateForKey:"), nskey), false)!;
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("setCustomState:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetCustomState (NSObject? customState, string key)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var customState__handle__ = customState.GetHandle ();
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setCustomState:forKey:"), customState__handle__, nskey);
			GC.KeepAlive (customState);
			CFString.ReleaseNative (nskey);
		}
		[Export ("objectForKeyedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject? GetObject (string key)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("objectForKeyedSubscript:"), nskey), false)!;
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		[Export ("setObject:forKeyedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetObject (NSObject? obj, string key)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var obj__handle__ = obj.GetHandle ();
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setObject:forKeyedSubscript:"), obj__handle__, nskey);
			GC.KeepAlive (obj);
			CFString.ReleaseNative (nskey);
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void EncodeTo (NSCoder encoder)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
			GC.KeepAlive (encoder);
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject Copy (NSZone? zone)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
			GC.KeepAlive (zone);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITraitCollection TraitCollection {
			[Export ("traitCollection", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITraitCollection ret;
				ret =  Runtime.GetNSObject<UITraitCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("traitCollection")), false)!;
				return ret;
			}
			[Export ("setTraitCollection:", ArgumentSemantic.Retain)]
			set {
				global::UIKit.UIApplication.EnsureUIThread ();
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setTraitCollection:"), value__handle__);
				GC.KeepAlive (value);
			}
		}
	}
}
