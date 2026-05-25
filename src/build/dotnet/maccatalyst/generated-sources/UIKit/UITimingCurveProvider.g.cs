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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	#pragma warning disable CS1573
	/// <remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "UITimingCurveProvider", WrapperType = typeof (UITimingCurveProviderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "TimingCurveType", Selector = "timingCurveType", PropertyType = typeof (UITimingCurveType), GetterSelector = "timingCurveType", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CubicTimingParameters", Selector = "cubicTimingParameters", PropertyType = typeof (UICubicTimingParameters), GetterSelector = "cubicTimingParameters", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SpringTimingParameters", Selector = "springTimingParameters", PropertyType = typeof (UISpringTimingParameters), GetterSelector = "springTimingParameters", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IUITimingCurveProvider : INativeObject, IDisposable, 
		Foundation.INSCoding
		, Foundation.INSCopying
	{
		[DynamicDependencyAttribute ("CubicTimingParameters")]
		[DynamicDependencyAttribute ("SpringTimingParameters")]
		[DynamicDependencyAttribute ("TimingCurveType")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITimingCurveProviderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IUITimingCurveProvider ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>The kind of timing curve this is (see <see cref="T:UIKit.UITimingCurveType" />).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UITimingCurveType TimingCurveType {
			[Export ("timingCurveType")]
			get {
				return _GetTimingCurveType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UITimingCurveType _GetTimingCurveType (IUITimingCurveProvider This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UITimingCurveType ret;
			ret = (UITimingCurveType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("timingCurveType"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>For <see cref="T:UIKit.UICubicTimingParameters" /> objects, the timing parameters. Otherwise, <see langword="null" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UICubicTimingParameters? CubicTimingParameters {
			[Export ("cubicTimingParameters")]
			get {
				return _GetCubicTimingParameters (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UICubicTimingParameters _GetCubicTimingParameters (IUITimingCurveProvider This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UICubicTimingParameters ret;
			ret =  Runtime.GetNSObject<UICubicTimingParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("cubicTimingParameters")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>For <see cref="T:UIKit.UISpringTimingParameters" /> objects, the timing parameters. Otherwise, <see langword="null" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual UISpringTimingParameters? SpringTimingParameters {
			[Export ("springTimingParameters")]
			get {
				return _GetSpringTimingParameters (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static UISpringTimingParameters _GetSpringTimingParameters (IUITimingCurveProvider This)
		{
			global::UIKit.UIApplication.EnsureUIThread ();
			UISpringTimingParameters ret;
			ret =  Runtime.GetNSObject<UISpringTimingParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("springTimingParameters")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class UITimingCurveProviderWrapper : BaseWrapper, IUITimingCurveProvider {
		public UITimingCurveProviderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (UITimingCurveProviderWrapper))]
		static UITimingCurveProviderWrapper ()
		{
			GC.KeepAlive (null);
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
		/// <summary>The kind of timing curve this is (see <see cref="T:UIKit.UITimingCurveType" />).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UITimingCurveType TimingCurveType {
			[Export ("timingCurveType")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UITimingCurveType ret;
				ret = (UITimingCurveType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("timingCurveType"));
				return ret!;
			}
		}
		/// <summary>For <see cref="T:UIKit.UICubicTimingParameters" /> objects, the timing parameters. Otherwise, <see langword="null" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UICubicTimingParameters? CubicTimingParameters {
			[Export ("cubicTimingParameters")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UICubicTimingParameters ret;
				ret =  Runtime.GetNSObject<UICubicTimingParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("cubicTimingParameters")), false)!;
				return ret;
			}
		}
		/// <summary>For <see cref="T:UIKit.UISpringTimingParameters" /> objects, the timing parameters. Otherwise, <see langword="null" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public UISpringTimingParameters? SpringTimingParameters {
			[Export ("springTimingParameters")]
			get {
				global::UIKit.UIApplication.EnsureUIThread ();
				UISpringTimingParameters ret;
				ret =  Runtime.GetNSObject<UISpringTimingParameters> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("springTimingParameters")), false)!;
				return ret;
			}
		}
	}
}
