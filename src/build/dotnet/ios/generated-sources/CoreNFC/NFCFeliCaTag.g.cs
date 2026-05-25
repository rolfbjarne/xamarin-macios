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
	/// <summary>This interface represents the Objective-C protocol <c>NFCFeliCaTag</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "NFCFeliCaTag", WrapperType = typeof (NFCFeliCaTagWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Polling", Selector = "pollingWithSystemCode:requestCode:timeSlot:completionHandler:", ParameterType = new Type [] { typeof (NSData), typeof (CoreNFC.NFCFeliCaPollingRequestCode), typeof (CoreNFC.NFCFeliCaPollingTimeSlot), typeof (CoreNFC.NFCFeliCaPollingCompletionHandler) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaPollingCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestService", Selector = "requestServiceWithNodeCodeList:completionHandler:", ParameterType = new Type [] { typeof (NSData[]), typeof (global::System.Action<NSData[], NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V73) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestResponse", Selector = "requestResponseWithCompletionHandler:", ParameterType = new Type [] { typeof (global::System.Action<nint, NSError>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity2V74) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReadWithoutEncryption", Selector = "readWithoutEncryptionWithServiceCodeList:blockList:completionHandler:", ParameterType = new Type [] { typeof (NSData[]), typeof (NSData[]), typeof (CoreNFC.NFCFeliCaReadWithoutEncryptionCompletionHandler) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaReadWithoutEncryptionCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WriteWithoutEncryption", Selector = "writeWithoutEncryptionWithServiceCodeList:blockList:blockData:completionHandler:", ParameterType = new Type [] { typeof (NSData[]), typeof (NSData[]), typeof (NSData[]), typeof (CoreNFC.NFCFeliCaStatus1Status2CompletionHandler) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaStatus1Status2CompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestSystemCode", Selector = "requestSystemCodeWithCompletionHandler:", ParameterType = new Type [] { typeof (global::System.Action<NSData[], NSError>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity2V73) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestServiceV2", Selector = "requestServiceV2WithNodeCodeList:completionHandler:", ParameterType = new Type [] { typeof (NSData[]), typeof (CoreNFC.NFCFeliCaRequestServiceV2CompletionHandler) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaRequestServiceV2CompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RequestSpecificationVersion", Selector = "requestSpecificationVersionWithCompletionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCFeliCaRequestSpecificationVersionCompletionHandler) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaRequestSpecificationVersionCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ResetMode", Selector = "resetModeWithCompletionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCFeliCaStatus1Status2CompletionHandler) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaStatus1Status2CompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Send", Selector = "sendFeliCaCommandPacket:completionHandler:", ParameterType = new Type [] { typeof (NSData), typeof (global::System.Action<NSData, NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V19) })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CurrentSystemCode", Selector = "currentSystemCode", PropertyType = typeof (NSData), GetterSelector = "currentSystemCode", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CurrentIdm", Selector = "currentIDm", PropertyType = typeof (NSData), GetterSelector = "currentIDm", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface INFCFeliCaTag : INativeObject, IDisposable, 
		CoreNFC.INFCNdefTag
		, CoreNFC.INFCTag
		, Foundation.INSCoding
		, Foundation.INSCopying
		, Foundation.INSSecureCoding
	{
		[global::Foundation.RequiredMember]
		[Export ("pollingWithSystemCode:requestCode:timeSlot:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Polling (NSData systemCode, NFCFeliCaPollingRequestCode requestCode, NFCFeliCaPollingTimeSlot timeSlot, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaPollingCompletionHandler))]NFCFeliCaPollingCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Polling (INFCFeliCaTag This, NSData systemCode, NFCFeliCaPollingRequestCode requestCode, NFCFeliCaPollingTimeSlot timeSlot, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaPollingCompletionHandler))]NFCFeliCaPollingCompletionHandler completionHandler)
		{
			var systemCode__handle__ = systemCode!.GetNonNullHandle (nameof (systemCode));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCFeliCaPollingCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("pollingWithSystemCode:requestCode:timeSlot:completionHandler:"), systemCode__handle__, (IntPtr) (long) requestCode, (IntPtr) (long) timeSlot, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (systemCode);
		}
		[global::Foundation.RequiredMember]
		[Export ("requestServiceWithNodeCodeList:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestService (NSData[] nodeCodeList, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V73))]global::System.Action<NSData[], NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestService (INFCFeliCaTag This, NSData[] nodeCodeList, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V73))]global::System.Action<NSData[], NSError> completionHandler)
		{
			if (nodeCodeList is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nodeCodeList));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_nodeCodeList = NSArray.FromNSObjects (nodeCodeList);
			using var block_completionHandler = Trampolines.SDActionArity2V73.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("requestServiceWithNodeCodeList:completionHandler:"), nsa_nodeCodeList.Handle, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("requestResponseWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestResponse ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V74))]global::System.Action<nint, NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestResponse (INFCFeliCaTag This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V74))]global::System.Action<nint, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V74.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("requestResponseWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("readWithoutEncryptionWithServiceCodeList:blockList:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReadWithoutEncryption (NSData[] serviceCodeList, NSData[] blockList, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaReadWithoutEncryptionCompletionHandler))]NFCFeliCaReadWithoutEncryptionCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ReadWithoutEncryption (INFCFeliCaTag This, NSData[] serviceCodeList, NSData[] blockList, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaReadWithoutEncryptionCompletionHandler))]NFCFeliCaReadWithoutEncryptionCompletionHandler completionHandler)
		{
			if (serviceCodeList is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (serviceCodeList));
			if (blockList is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (blockList));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_serviceCodeList = NSArray.FromNSObjects (serviceCodeList);
			using var nsa_blockList = NSArray.FromNSObjects (blockList);
			using var block_completionHandler = Trampolines.SDNFCFeliCaReadWithoutEncryptionCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("readWithoutEncryptionWithServiceCodeList:blockList:completionHandler:"), nsa_serviceCodeList.Handle, nsa_blockList.Handle, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("writeWithoutEncryptionWithServiceCodeList:blockList:blockData:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WriteWithoutEncryption (NSData[] serviceCodeList, NSData[] blockList, NSData[] blockData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaStatus1Status2CompletionHandler))]NFCFeliCaStatus1Status2CompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _WriteWithoutEncryption (INFCFeliCaTag This, NSData[] serviceCodeList, NSData[] blockList, NSData[] blockData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaStatus1Status2CompletionHandler))]NFCFeliCaStatus1Status2CompletionHandler completionHandler)
		{
			if (serviceCodeList is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (serviceCodeList));
			if (blockList is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (blockList));
			if (blockData is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (blockData));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_serviceCodeList = NSArray.FromNSObjects (serviceCodeList);
			using var nsa_blockList = NSArray.FromNSObjects (blockList);
			using var nsa_blockData = NSArray.FromNSObjects (blockData);
			using var block_completionHandler = Trampolines.SDNFCFeliCaStatus1Status2CompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("writeWithoutEncryptionWithServiceCodeList:blockList:blockData:completionHandler:"), nsa_serviceCodeList.Handle, nsa_blockList.Handle, nsa_blockData.Handle, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("requestSystemCodeWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestSystemCode ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V73))]global::System.Action<NSData[], NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestSystemCode (INFCFeliCaTag This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V73))]global::System.Action<NSData[], NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V73.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("requestSystemCodeWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("requestServiceV2WithNodeCodeList:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestServiceV2 (NSData[] nodeCodeList, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaRequestServiceV2CompletionHandler))]NFCFeliCaRequestServiceV2CompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestServiceV2 (INFCFeliCaTag This, NSData[] nodeCodeList, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaRequestServiceV2CompletionHandler))]NFCFeliCaRequestServiceV2CompletionHandler completionHandler)
		{
			if (nodeCodeList is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nodeCodeList));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_nodeCodeList = NSArray.FromNSObjects (nodeCodeList);
			using var block_completionHandler = Trampolines.SDNFCFeliCaRequestServiceV2CompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("requestServiceV2WithNodeCodeList:completionHandler:"), nsa_nodeCodeList.Handle, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("requestSpecificationVersionWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void RequestSpecificationVersion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaRequestSpecificationVersionCompletionHandler))]NFCFeliCaRequestSpecificationVersionCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _RequestSpecificationVersion (INFCFeliCaTag This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaRequestSpecificationVersionCompletionHandler))]NFCFeliCaRequestSpecificationVersionCompletionHandler completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCFeliCaRequestSpecificationVersionCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("requestSpecificationVersionWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("resetModeWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResetMode ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaStatus1Status2CompletionHandler))]NFCFeliCaStatus1Status2CompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResetMode (INFCFeliCaTag This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaStatus1Status2CompletionHandler))]NFCFeliCaStatus1Status2CompletionHandler completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCFeliCaStatus1Status2CompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("resetModeWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("sendFeliCaCommandPacket:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Send (NSData commandPacket, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V19))]global::System.Action<NSData, NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Send (INFCFeliCaTag This, NSData commandPacket, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V19))]global::System.Action<NSData, NSError> completionHandler)
		{
			var commandPacket__handle__ = commandPacket!.GetNonNullHandle (nameof (commandPacket));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V19.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sendFeliCaCommandPacket:completionHandler:"), commandPacket__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (commandPacket);
		}
		[DynamicDependencyAttribute ("CurrentIdm")]
		[DynamicDependencyAttribute ("CurrentSystemCode")]
		[DynamicDependencyAttribute ("Polling(Foundation.NSData,CoreNFC.NFCFeliCaPollingRequestCode,CoreNFC.NFCFeliCaPollingTimeSlot,CoreNFC.NFCFeliCaPollingCompletionHandler)")]
		[DynamicDependencyAttribute ("ReadWithoutEncryption(Foundation.NSData[],Foundation.NSData[],CoreNFC.NFCFeliCaReadWithoutEncryptionCompletionHandler)")]
		[DynamicDependencyAttribute ("RequestResponse(System.Action{System.IntPtr,Foundation.NSError})")]
		[DynamicDependencyAttribute ("RequestService(Foundation.NSData[],System.Action{Foundation.NSData[],Foundation.NSError})")]
		[DynamicDependencyAttribute ("RequestServiceV2(Foundation.NSData[],CoreNFC.NFCFeliCaRequestServiceV2CompletionHandler)")]
		[DynamicDependencyAttribute ("RequestSpecificationVersion(CoreNFC.NFCFeliCaRequestSpecificationVersionCompletionHandler)")]
		[DynamicDependencyAttribute ("RequestSystemCode(System.Action{Foundation.NSData[],Foundation.NSError})")]
		[DynamicDependencyAttribute ("ResetMode(CoreNFC.NFCFeliCaStatus1Status2CompletionHandler)")]
		[DynamicDependencyAttribute ("Send(Foundation.NSData,System.Action{Foundation.NSData,Foundation.NSError})")]
		[DynamicDependencyAttribute ("WriteWithoutEncryption(Foundation.NSData[],Foundation.NSData[],Foundation.NSData[],CoreNFC.NFCFeliCaStatus1Status2CompletionHandler)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NFCFeliCaTagWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INFCFeliCaTag ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSData CurrentSystemCode {
			[Export ("currentSystemCode", ArgumentSemantic.Retain)]
			get {
				return _GetCurrentSystemCode (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSData _GetCurrentSystemCode (INFCFeliCaTag This)
		{
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("currentSystemCode")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSData CurrentIdm {
			[Export ("currentIDm", ArgumentSemantic.Retain)]
			get {
				return _GetCurrentIdm (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSData _GetCurrentIdm (INFCFeliCaTag This)
		{
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("currentIDm")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NFCFeliCaTagWrapper : BaseWrapper, INFCFeliCaTag {
		public NFCFeliCaTagWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NFCFeliCaTagWrapper))]
		static NFCFeliCaTagWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("pollingWithSystemCode:requestCode:timeSlot:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void Polling (NSData systemCode, NFCFeliCaPollingRequestCode requestCode, NFCFeliCaPollingTimeSlot timeSlot, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaPollingCompletionHandler))]NFCFeliCaPollingCompletionHandler completionHandler)
		{
			var systemCode__handle__ = systemCode!.GetNonNullHandle (nameof (systemCode));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCFeliCaPollingCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("pollingWithSystemCode:requestCode:timeSlot:completionHandler:"), systemCode__handle__, (IntPtr) (long) requestCode, (IntPtr) (long) timeSlot, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (systemCode);
		}
		[Export ("requestServiceWithNodeCodeList:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RequestService (NSData[] nodeCodeList, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V73))]global::System.Action<NSData[], NSError> completionHandler)
		{
			if (nodeCodeList is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nodeCodeList));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_nodeCodeList = NSArray.FromNSObjects (nodeCodeList);
			using var block_completionHandler = Trampolines.SDActionArity2V73.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("requestServiceWithNodeCodeList:completionHandler:"), nsa_nodeCodeList.Handle, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("requestResponseWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RequestResponse ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V74))]global::System.Action<nint, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V74.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("requestResponseWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
		}
		[Export ("readWithoutEncryptionWithServiceCodeList:blockList:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ReadWithoutEncryption (NSData[] serviceCodeList, NSData[] blockList, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaReadWithoutEncryptionCompletionHandler))]NFCFeliCaReadWithoutEncryptionCompletionHandler completionHandler)
		{
			if (serviceCodeList is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (serviceCodeList));
			if (blockList is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (blockList));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_serviceCodeList = NSArray.FromNSObjects (serviceCodeList);
			using var nsa_blockList = NSArray.FromNSObjects (blockList);
			using var block_completionHandler = Trampolines.SDNFCFeliCaReadWithoutEncryptionCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("readWithoutEncryptionWithServiceCodeList:blockList:completionHandler:"), nsa_serviceCodeList.Handle, nsa_blockList.Handle, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("writeWithoutEncryptionWithServiceCodeList:blockList:blockData:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void WriteWithoutEncryption (NSData[] serviceCodeList, NSData[] blockList, NSData[] blockData, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaStatus1Status2CompletionHandler))]NFCFeliCaStatus1Status2CompletionHandler completionHandler)
		{
			if (serviceCodeList is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (serviceCodeList));
			if (blockList is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (blockList));
			if (blockData is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (blockData));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_serviceCodeList = NSArray.FromNSObjects (serviceCodeList);
			using var nsa_blockList = NSArray.FromNSObjects (blockList);
			using var nsa_blockData = NSArray.FromNSObjects (blockData);
			using var block_completionHandler = Trampolines.SDNFCFeliCaStatus1Status2CompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("writeWithoutEncryptionWithServiceCodeList:blockList:blockData:completionHandler:"), nsa_serviceCodeList.Handle, nsa_blockList.Handle, nsa_blockData.Handle, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("requestSystemCodeWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RequestSystemCode ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V73))]global::System.Action<NSData[], NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V73.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("requestSystemCodeWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
		}
		[Export ("requestServiceV2WithNodeCodeList:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RequestServiceV2 (NSData[] nodeCodeList, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaRequestServiceV2CompletionHandler))]NFCFeliCaRequestServiceV2CompletionHandler completionHandler)
		{
			if (nodeCodeList is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nodeCodeList));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_nodeCodeList = NSArray.FromNSObjects (nodeCodeList);
			using var block_completionHandler = Trampolines.SDNFCFeliCaRequestServiceV2CompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("requestServiceV2WithNodeCodeList:completionHandler:"), nsa_nodeCodeList.Handle, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("requestSpecificationVersionWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void RequestSpecificationVersion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaRequestSpecificationVersionCompletionHandler))]NFCFeliCaRequestSpecificationVersionCompletionHandler completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCFeliCaRequestSpecificationVersionCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("requestSpecificationVersionWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
		}
		[Export ("resetModeWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ResetMode ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCFeliCaStatus1Status2CompletionHandler))]NFCFeliCaStatus1Status2CompletionHandler completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCFeliCaStatus1Status2CompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("resetModeWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
		}
		[Export ("sendFeliCaCommandPacket:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void Send (NSData commandPacket, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V19))]global::System.Action<NSData, NSError> completionHandler)
		{
			var commandPacket__handle__ = commandPacket!.GetNonNullHandle (nameof (commandPacket));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V19.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("sendFeliCaCommandPacket:completionHandler:"), commandPacket__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (commandPacket);
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
		public NSData CurrentSystemCode {
			[Export ("currentSystemCode", ArgumentSemantic.Retain)]
			get {
				NSData ret;
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("currentSystemCode")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSData CurrentIdm {
			[Export ("currentIDm", ArgumentSemantic.Retain)]
			get {
				NSData ret;
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("currentIDm")), false)!;
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
