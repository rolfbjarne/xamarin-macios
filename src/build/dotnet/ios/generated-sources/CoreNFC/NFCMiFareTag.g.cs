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
	/// <summary>This interface represents the Objective-C protocol <c>NFCMiFareTag</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "NFCMiFareTag", WrapperType = typeof (NFCMiFareTagWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SendMiFareCommand", Selector = "sendMiFareCommand:completionHandler:", ParameterType = new Type [] { typeof (NSData), typeof (global::System.Action<NSData, NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V19) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SendMiFareIso7816Command", Selector = "sendMiFareISO7816Command:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso7816Apdu), typeof (CoreNFC.NFCIso7816SendCompletionHandler) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDNFCIso7816SendCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MifareFamily", Selector = "mifareFamily", PropertyType = typeof (CoreNFC.NFCMiFareFamily), GetterSelector = "mifareFamily", ArgumentSemantic = ArgumentSemantic.Assign)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Identifier", Selector = "identifier", PropertyType = typeof (NSData), GetterSelector = "identifier", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "HistoricalBytes", Selector = "historicalBytes", PropertyType = typeof (NSData), GetterSelector = "historicalBytes", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface INFCMiFareTag : INativeObject, IDisposable, 
		CoreNFC.INFCNdefTag
		, CoreNFC.INFCTag
		, Foundation.INSCoding
		, Foundation.INSCopying
		, Foundation.INSSecureCoding
	{
		[global::Foundation.RequiredMember]
		[Export ("sendMiFareCommand:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SendMiFareCommand (NSData command, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V19))]global::System.Action<NSData, NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SendMiFareCommand (INFCMiFareTag This, NSData command, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V19))]global::System.Action<NSData, NSError> completionHandler)
		{
			var command__handle__ = command!.GetNonNullHandle (nameof (command));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V19.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sendMiFareCommand:completionHandler:"), command__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (command);
		}
		[global::Foundation.RequiredMember]
		[Export ("sendMiFareISO7816Command:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SendMiFareIso7816Command (NFCIso7816Apdu apdu, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso7816SendCompletionHandler))]NFCIso7816SendCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SendMiFareIso7816Command (INFCMiFareTag This, NFCIso7816Apdu apdu, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso7816SendCompletionHandler))]NFCIso7816SendCompletionHandler completionHandler)
		{
			var apdu__handle__ = apdu!.GetNonNullHandle (nameof (apdu));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCIso7816SendCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sendMiFareISO7816Command:completionHandler:"), apdu__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (apdu);
		}
		[DynamicDependencyAttribute ("HistoricalBytes")]
		[DynamicDependencyAttribute ("Identifier")]
		[DynamicDependencyAttribute ("MifareFamily")]
		[DynamicDependencyAttribute ("SendMiFareCommand(Foundation.NSData,System.Action{Foundation.NSData,Foundation.NSError})")]
		[DynamicDependencyAttribute ("SendMiFareIso7816Command(CoreNFC.NFCIso7816Apdu,CoreNFC.NFCIso7816SendCompletionHandler)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NFCMiFareTagWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INFCMiFareTag ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NFCMiFareFamily MifareFamily {
			[Export ("mifareFamily", ArgumentSemantic.Assign)]
			get {
				return _GetMifareFamily (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NFCMiFareFamily _GetMifareFamily (INFCMiFareTag This)
		{
			NFCMiFareFamily ret;
			ret = (CoreNFC.NFCMiFareFamily) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("mifareFamily"));
			GC.KeepAlive (This);
			return ret!;
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
		internal static NSData _GetIdentifier (INFCMiFareTag This)
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
		internal static NSData _GetHistoricalBytes (INFCMiFareTag This)
		{
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("historicalBytes")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NFCMiFareTagWrapper : BaseWrapper, INFCMiFareTag {
		public NFCMiFareTagWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NFCMiFareTagWrapper))]
		static NFCMiFareTagWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("sendMiFareCommand:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void SendMiFareCommand (NSData command, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V19))]global::System.Action<NSData, NSError> completionHandler)
		{
			var command__handle__ = command!.GetNonNullHandle (nameof (command));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V19.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("sendMiFareCommand:completionHandler:"), command__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (command);
		}
		[Export ("sendMiFareISO7816Command:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void SendMiFareIso7816Command (NFCIso7816Apdu apdu, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso7816SendCompletionHandler))]NFCIso7816SendCompletionHandler completionHandler)
		{
			var apdu__handle__ = apdu!.GetNonNullHandle (nameof (apdu));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCIso7816SendCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("sendMiFareISO7816Command:completionHandler:"), apdu__handle__, (IntPtr) block_ptr_completionHandler);
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
		public NFCMiFareFamily MifareFamily {
			[Export ("mifareFamily", ArgumentSemantic.Assign)]
			get {
				NFCMiFareFamily ret;
				ret = (CoreNFC.NFCMiFareFamily) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mifareFamily"));
				return ret!;
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
