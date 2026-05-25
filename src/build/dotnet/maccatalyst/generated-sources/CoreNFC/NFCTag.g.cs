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
namespace CoreNFC {
	#pragma warning disable CS1573
	/// <summary>Interface defining the common features of all NFC tags.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "NFCTag", WrapperType = typeof (NFCTagWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Type", Selector = "type", PropertyType = typeof (CoreNFC.NFCTagType), GetterSelector = "type", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Session", Selector = "session", PropertyType = typeof (CoreNFC.NFCReaderSession), GetterSelector = "session", ArgumentSemantic = ArgumentSemantic.Weak)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Available", Selector = "available", PropertyType = typeof (bool), GetterSelector = "isAvailable", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AsNFCIso15693Tag", Selector = "asNFCISO15693Tag", PropertyType = typeof (CoreNFC.INFCIso15693Tag), GetterSelector = "asNFCISO15693Tag", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AsNFCIso7816Tag", Selector = "asNFCISO7816Tag", PropertyType = typeof (CoreNFC.INFCIso7816Tag), GetterSelector = "asNFCISO7816Tag", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AsNFCFeliCaTag", Selector = "asNFCFeliCaTag", PropertyType = typeof (CoreNFC.INFCFeliCaTag), GetterSelector = "asNFCFeliCaTag", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "AsNFCMiFareTag", Selector = "asNFCMiFareTag", PropertyType = typeof (CoreNFC.INFCMiFareTag), GetterSelector = "asNFCMiFareTag", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INFCTag : INativeObject, IDisposable, 
		Foundation.INSCoding
		, Foundation.INSCopying
		, Foundation.INSSecureCoding
	{
		[DynamicDependencyAttribute ("AsNFCFeliCaTag")]
		[DynamicDependencyAttribute ("AsNFCIso15693Tag")]
		[DynamicDependencyAttribute ("AsNFCIso7816Tag")]
		[DynamicDependencyAttribute ("AsNFCMiFareTag")]
		[DynamicDependencyAttribute ("Available")]
		[DynamicDependencyAttribute ("Session")]
		[DynamicDependencyAttribute ("Type")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NFCTagWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INFCTag ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the kind of NFC tag.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NFCTagType Type {
			[Export ("type", ArgumentSemantic.Assign)]
			get {
				return _GetType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NFCTagType _GetType (INFCTag This)
		{
			NFCTagType ret;
			ret = (CoreNFC.NFCTagType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("type"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>Gets the <see cref="T:CoreNFC.NFCReaderSession" /> that provided the tag.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NFCReaderSession? Session {
			[Export ("session", ArgumentSemantic.Weak)]
			get {
				return _GetSession (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NFCReaderSession _GetSession (INFCTag This)
		{
			NFCReaderSession ret;
			ret =  Runtime.GetNSObject<NFCReaderSession> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("session")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets whether the tag is available for reading.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool Available {
			[Export ("isAvailable")]
			get {
				return _GetAvailable (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetAvailable (INFCTag This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAvailable"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[global::Foundation.RequiredMember]
		public virtual INFCIso15693Tag? AsNFCIso15693Tag {
			[Export ("asNFCISO15693Tag")]
			get {
				return _GetAsNFCIso15693Tag (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INFCIso15693Tag _GetAsNFCIso15693Tag (INFCTag This)
		{
			INFCIso15693Tag ret;
			ret =  Runtime.GetINativeObject<INFCIso15693Tag> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("asNFCISO15693Tag")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[global::Foundation.RequiredMember]
		public virtual INFCIso7816Tag? AsNFCIso7816Tag {
			[Export ("asNFCISO7816Tag")]
			get {
				return _GetAsNFCIso7816Tag (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INFCIso7816Tag _GetAsNFCIso7816Tag (INFCTag This)
		{
			INFCIso7816Tag ret;
			ret =  Runtime.GetINativeObject<INFCIso7816Tag> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("asNFCISO7816Tag")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[global::Foundation.RequiredMember]
		public virtual INFCFeliCaTag? AsNFCFeliCaTag {
			[Export ("asNFCFeliCaTag")]
			get {
				return _GetAsNFCFeliCaTag (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INFCFeliCaTag _GetAsNFCFeliCaTag (INFCTag This)
		{
			INFCFeliCaTag ret;
			ret =  Runtime.GetINativeObject<INFCFeliCaTag> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("asNFCFeliCaTag")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[global::Foundation.RequiredMember]
		public virtual INFCMiFareTag? AsNFCMiFareTag {
			[Export ("asNFCMiFareTag")]
			get {
				return _GetAsNFCMiFareTag (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static INFCMiFareTag _GetAsNFCMiFareTag (INFCTag This)
		{
			INFCMiFareTag ret;
			ret =  Runtime.GetINativeObject<INFCMiFareTag> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("asNFCMiFareTag")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NFCTagWrapper : BaseWrapper, INFCTag {
		public NFCTagWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NFCTagWrapper))]
		static NFCTagWrapper ()
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
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
			GC.KeepAlive (zone);
			return ret!;
		}
		/// <summary>Gets the kind of NFC tag.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NFCTagType Type {
			[Export ("type", ArgumentSemantic.Assign)]
			get {
				NFCTagType ret;
				ret = (CoreNFC.NFCTagType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
				return ret!;
			}
		}
		/// <summary>Gets the <see cref="T:CoreNFC.NFCReaderSession" /> that provided the tag.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NFCReaderSession? Session {
			[Export ("session", ArgumentSemantic.Weak)]
			get {
				NFCReaderSession ret;
				ret =  Runtime.GetNSObject<NFCReaderSession> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("session")), false)!;
				return ret;
			}
		}
		/// <summary>Gets whether the tag is available for reading.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool Available {
			[Export ("isAvailable")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAvailable"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public INFCIso15693Tag? AsNFCIso15693Tag {
			[Export ("asNFCISO15693Tag")]
			get {
				INFCIso15693Tag ret;
				ret =  Runtime.GetINativeObject<INFCIso15693Tag> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("asNFCISO15693Tag")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public INFCIso7816Tag? AsNFCIso7816Tag {
			[Export ("asNFCISO7816Tag")]
			get {
				INFCIso7816Tag ret;
				ret =  Runtime.GetINativeObject<INFCIso7816Tag> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("asNFCISO7816Tag")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public INFCFeliCaTag? AsNFCFeliCaTag {
			[Export ("asNFCFeliCaTag")]
			get {
				INFCFeliCaTag ret;
				ret =  Runtime.GetINativeObject<INFCFeliCaTag> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("asNFCFeliCaTag")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public INFCMiFareTag? AsNFCMiFareTag {
			[Export ("asNFCMiFareTag")]
			get {
				INFCMiFareTag ret;
				ret =  Runtime.GetINativeObject<INFCMiFareTag> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("asNFCMiFareTag")), false)!;
				return ret;
			}
		}
	}
}
