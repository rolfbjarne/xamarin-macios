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
namespace CoreNFC {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NFCISO7816Tag</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "NFCISO7816Tag", WrapperType = typeof (NFCIso7816TagWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SendCommand", Selector = "sendCommandAPDU:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso7816Apdu), typeof (CoreNFC.NFCIso7816SendCompletionHandler) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDNFCIso7816SendCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "InitialSelectedAid", Selector = "initialSelectedAID", PropertyType = typeof (string), GetterSelector = "initialSelectedAID", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Identifier", Selector = "identifier", PropertyType = typeof (NSData), GetterSelector = "identifier", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "HistoricalBytes", Selector = "historicalBytes", PropertyType = typeof (NSData), GetterSelector = "historicalBytes", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ApplicationData", Selector = "applicationData", PropertyType = typeof (NSData), GetterSelector = "applicationData", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ProprietaryApplicationDataCoding", Selector = "proprietaryApplicationDataCoding", PropertyType = typeof (bool), GetterSelector = "proprietaryApplicationDataCoding", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportsPace", Selector = "supportsPACE", PropertyType = typeof (bool), GetterSelector = "supportsPACE", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INFCIso7816Tag : INativeObject, IDisposable, 
		CoreNFC.INFCNdefTag
		, CoreNFC.INFCTag
		, Foundation.INSCoding
		, Foundation.INSCopying
		, Foundation.INSSecureCoding
	{
		[global::Foundation.RequiredMember]
		[Export ("sendCommandAPDU:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SendCommand (NFCIso7816Apdu apdu, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso7816SendCompletionHandler))]NFCIso7816SendCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SendCommand (INFCIso7816Tag This, NFCIso7816Apdu apdu, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso7816SendCompletionHandler))]NFCIso7816SendCompletionHandler completionHandler)
		{
			var apdu__handle__ = apdu!.GetNonNullHandle (nameof (apdu));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCIso7816SendCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sendCommandAPDU:completionHandler:"), apdu__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (apdu);
		}
		[DynamicDependencyAttribute ("ApplicationData")]
		[DynamicDependencyAttribute ("HistoricalBytes")]
		[DynamicDependencyAttribute ("Identifier")]
		[DynamicDependencyAttribute ("InitialSelectedAid")]
		[DynamicDependencyAttribute ("ProprietaryApplicationDataCoding")]
		[DynamicDependencyAttribute ("SendCommand(CoreNFC.NFCIso7816Apdu,CoreNFC.NFCIso7816SendCompletionHandler)")]
		[DynamicDependencyAttribute ("SupportsPace")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NFCIso7816TagWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INFCIso7816Tag ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string InitialSelectedAid {
			[Export ("initialSelectedAID", ArgumentSemantic.Retain)]
			get {
				return _GetInitialSelectedAid (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetInitialSelectedAid (INFCIso7816Tag This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("initialSelectedAID")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSData Identifier {
			[Export ("identifier", ArgumentSemantic.Copy)]
			get {
				return _GetIdentifier (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSData _GetIdentifier (INFCIso7816Tag This)
		{
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("identifier")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSData? HistoricalBytes {
			[Export ("historicalBytes", ArgumentSemantic.Copy)]
			get {
				return _GetHistoricalBytes (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSData _GetHistoricalBytes (INFCIso7816Tag This)
		{
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("historicalBytes")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSData? ApplicationData {
			[Export ("applicationData", ArgumentSemantic.Copy)]
			get {
				return _GetApplicationData (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSData _GetApplicationData (INFCIso7816Tag This)
		{
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("applicationData")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool ProprietaryApplicationDataCoding {
			[Export ("proprietaryApplicationDataCoding")]
			get {
				return _GetProprietaryApplicationDataCoding (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetProprietaryApplicationDataCoding (INFCIso7816Tag This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("proprietaryApplicationDataCoding"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>Gets a value indicating whether the tag supports the PACE (Password Authenticated Connection Establishment) protocol.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		[global::Foundation.RequiredMember]
		public virtual bool SupportsPace {
			[Export ("supportsPACE")]
			get {
				return _GetSupportsPace (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportsPace (INFCIso7816Tag This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportsPACE"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NFCIso7816TagWrapper : BaseWrapper, INFCIso7816Tag {
		public NFCIso7816TagWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NFCIso7816TagWrapper))]
		static NFCIso7816TagWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("sendCommandAPDU:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void SendCommand (NFCIso7816Apdu apdu, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso7816SendCompletionHandler))]NFCIso7816SendCompletionHandler completionHandler)
		{
			var apdu__handle__ = apdu!.GetNonNullHandle (nameof (apdu));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCIso7816SendCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("sendCommandAPDU:completionHandler:"), apdu__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (apdu);
		}
		[Export ("queryNDEFStatusWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void QueryNdefStatus ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCQueryNdefStatusCompletionHandler))]NFCQueryNdefStatusCompletionHandler completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCQueryNdefStatusCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("queryNDEFStatusWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
		}
		[Export ("readNDEFWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ReadNdef ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V75))]global::System.Action<NFCNdefMessage, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V75.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("readNDEFWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
		}
		[Export ("writeNDEF:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void WriteNdef (NFCNdefMessage ndefMessage, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			var ndefMessage__handle__ = ndefMessage!.GetNonNullHandle (nameof (ndefMessage));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("writeNDEF:completionHandler:"), ndefMessage__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (ndefMessage);
		}
		[Export ("writeLockWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void WriteLock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("writeLockWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string InitialSelectedAid {
			[Export ("initialSelectedAID", ArgumentSemantic.Retain)]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("initialSelectedAID")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSData Identifier {
			[Export ("identifier", ArgumentSemantic.Copy)]
			get {
				NSData ret;
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("identifier")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSData? HistoricalBytes {
			[Export ("historicalBytes", ArgumentSemantic.Copy)]
			get {
				NSData ret;
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("historicalBytes")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSData? ApplicationData {
			[Export ("applicationData", ArgumentSemantic.Copy)]
			get {
				NSData ret;
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("applicationData")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ProprietaryApplicationDataCoding {
			[Export ("proprietaryApplicationDataCoding")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("proprietaryApplicationDataCoding"));
				return ret != 0;
			}
		}
		/// <summary>Gets a value indicating whether the tag supports the PACE (Password Authenticated Connection Establishment) protocol.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios26.4")]
		[SupportedOSPlatform ("maccatalyst26.4")]
		public bool SupportsPace {
			[Export ("supportsPACE")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportsPACE"));
				return ret != 0;
			}
		}
		/// <summary>Gets the kind of NFC tag.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public NFCTagType Type {
			[Export ("type", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				NFCTagType ret;
				ret = (CoreNFC.NFCTagType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
				return ret!;
			}
		}
		/// <summary>Gets the <see cref="T:CoreNFC.NFCReaderSession" /> that provided the tag.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public NFCReaderSession? Session {
			[Export ("session", ArgumentSemantic.Weak)]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				NFCReaderSession ret;
				ret =  Runtime.GetNSObject<NFCReaderSession> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("session")), false)!;
				return ret;
			}
		}
		/// <summary>Gets whether the tag is available for reading.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public bool Available {
			[Export ("isAvailable")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
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
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
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
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
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
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
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
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				INFCMiFareTag ret;
				ret =  Runtime.GetINativeObject<INFCMiFareTag> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("asNFCMiFareTag")), false)!;
				return ret;
			}
		}
	}
}
