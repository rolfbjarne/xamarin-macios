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
	/// <summary>Implements <see cref="T:CoreNFC.INFCTag" /> with data associated with an ISO-15693 vicinity card.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Protocol (Name = "NFCISO15693Tag", WrapperType = typeof (NFCIso15693TagWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SendCustomCommand", Selector = "sendCustomCommandWithConfiguration:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693CustomCommandConfiguration), typeof (global::System.Action<NSData, NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V19) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReadMultipleBlocks", Selector = "readMultipleBlocksWithConfiguration:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693ReadMultipleBlocksConfiguration), typeof (global::System.Action<NSData, NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V19) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StayQuiet", Selector = "stayQuietWithCompletionHandler:", ParameterType = new Type [] { typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReadSingleBlock", Selector = "readSingleBlockWithRequestFlags:blockNumber:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (byte), typeof (global::System.Action<NSData, NSError>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V19) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WriteSingleBlock", Selector = "writeSingleBlockWithRequestFlags:blockNumber:dataBlock:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (byte), typeof (NSData), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LockBlock", Selector = "lockBlockWithRequestFlags:blockNumber:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (byte), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReadMultipleBlocks", Selector = "readMultipleBlocksWithRequestFlags:blockRange:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (NSRange), typeof (global::System.Action<NSData[], NSError>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V73) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WriteMultipleBlocks", Selector = "writeMultipleBlocksWithRequestFlags:blockRange:dataBlocks:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (NSRange), typeof (NSData[]), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Select", Selector = "selectWithRequestFlags:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ResetToReady", Selector = "resetToReadyWithRequestFlags:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WriteAfi", Selector = "writeAFIWithRequestFlag:afi:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (byte), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LockAfi", Selector = "lockAFIWithRequestFlag:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "WriteDsfi", Selector = "writeDSFIDWithRequestFlag:dsfid:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (byte), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LockDfsi", Selector = "lockDFSIDWithRequestFlag:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetSystemInfo", Selector = "getSystemInfoWithRequestFlag:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (CoreNFC.NFCGetSystemInfoCompletionHandler) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDNFCGetSystemInfoCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetMultipleBlockSecurityStatus", Selector = "getMultipleBlockSecurityStatusWithRequestFlag:blockRange:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (NSRange), typeof (global::System.Action<NSNumber[], NSError>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V76) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CustomCommand", Selector = "customCommandWithRequestFlag:customCommandCode:customRequestParameters:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (IntPtr), typeof (NSData), typeof (global::System.Action<NSData, NSError>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V19) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ExtendedReadSingleBlock", Selector = "extendedReadSingleBlockWithRequestFlags:blockNumber:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (IntPtr), typeof (global::System.Action<NSData, NSError>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V19) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ExtendedWriteSingleBlock", Selector = "extendedWriteSingleBlockWithRequestFlags:blockNumber:dataBlock:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (IntPtr), typeof (NSData), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ExtendedLockBlock", Selector = "extendedLockBlockWithRequestFlags:blockNumber:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (IntPtr), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ExtendedReadMultipleBlocks", Selector = "extendedReadMultipleBlocksWithRequestFlags:blockRange:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (NSRange), typeof (global::System.Action<NSData[], NSError>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity2V73) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ExtendedWriteMultipleBlocks", Selector = "extendedWriteMultipleBlocksWithRequestFlags:blockRange:dataBlocks:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (NSRange), typeof (NSData[]), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Authenticate", Selector = "authenticateWithRequestFlags:cryptoSuiteIdentifier:message:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (IntPtr), typeof (NSData), typeof (CoreNFC.NFCIso15693TagResponseCallback) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagResponseCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "KeyUpdate", Selector = "keyUpdateWithRequestFlags:keyIdentifier:message:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (IntPtr), typeof (NSData), typeof (CoreNFC.NFCIso15693TagResponseCallback) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagResponseCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Challenge", Selector = "challengeWithRequestFlags:cryptoSuiteIdentifier:message:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (IntPtr), typeof (NSData), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReadBuffer", Selector = "readBufferWithRequestFlags:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (CoreNFC.NFCIso15693TagResponseCallback) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagResponseCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ExtendedGetMultipleBlockSecurityStatus", Selector = "extendedGetMultipleBlockSecurityStatusWithRequestFlag:blockRange:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (NSRange), typeof (CoreNFC.NFCIso15693TagGetMultipleBlockSecurityStatusCallback) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagGetMultipleBlockSecurityStatusCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ExtendedFastReadMultipleBlocks", Selector = "extendedFastReadMultipleBlocksWithRequestFlag:blockRange:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (NSRange), typeof (CoreNFC.NFCIso15693TagReadMultipleBlocksCallback) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagReadMultipleBlocksCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SendRequest", Selector = "sendRequestWithFlag:commandCode:data:completionHandler:", ParameterType = new Type [] { typeof (IntPtr), typeof (IntPtr), typeof (NSData), typeof (CoreNFC.NFCIso15693TagResponseCallback) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagResponseCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetSystemInfoAndUid", Selector = "getSystemInfoAndUIDWithRequestFlag:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (CoreNFC.NFCIso15693TagGetSystemInfoAndUidCallback) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagGetSystemInfoAndUidCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FastReadMultipleBlocks", Selector = "fastReadMultipleBlocksWithRequestFlag:blockRange:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (NSRange), typeof (CoreNFC.NFCIso15693TagReadMultipleBlocksCallback) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagReadMultipleBlocksCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LockDsfId", Selector = "lockDSFIDWithRequestFlag:completionHandler:", ParameterType = new Type [] { typeof (CoreNFC.NFCIso15693RequestFlag), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Identifier", Selector = "identifier", PropertyType = typeof (NSData), GetterSelector = "identifier", ArgumentSemantic = ArgumentSemantic.Copy)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "IcManufacturerCode", Selector = "icManufacturerCode", PropertyType = typeof (UIntPtr), GetterSelector = "icManufacturerCode", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "IcSerialNumber", Selector = "icSerialNumber", PropertyType = typeof (NSData), GetterSelector = "icSerialNumber", ArgumentSemantic = ArgumentSemantic.Copy)]
	public partial interface INFCIso15693Tag : INativeObject, IDisposable, 
		CoreNFC.INFCNdefTag
		, CoreNFC.INFCTag
		, Foundation.INSCoding
		, Foundation.INSCopying
		, Foundation.INSSecureCoding
	{
		/// <param name="commandConfiguration">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("sendCustomCommandWithConfiguration:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SendCustomCommand (NFCIso15693CustomCommandConfiguration commandConfiguration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V19))]global::System.Action<NSData, NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="commandConfiguration">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SendCustomCommand (INFCIso15693Tag This, NFCIso15693CustomCommandConfiguration commandConfiguration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V19))]global::System.Action<NSData, NSError> completionHandler)
		{
			var commandConfiguration__handle__ = commandConfiguration!.GetNonNullHandle (nameof (commandConfiguration));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V19.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sendCustomCommandWithConfiguration:completionHandler:"), commandConfiguration__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (commandConfiguration);
		}
		/// <param name="readConfiguration">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("readMultipleBlocksWithConfiguration:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReadMultipleBlocks (NFCIso15693ReadMultipleBlocksConfiguration readConfiguration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V19))]global::System.Action<NSData, NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="readConfiguration">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ReadMultipleBlocks (INFCIso15693Tag This, NFCIso15693ReadMultipleBlocksConfiguration readConfiguration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V19))]global::System.Action<NSData, NSError> completionHandler)
		{
			var readConfiguration__handle__ = readConfiguration!.GetNonNullHandle (nameof (readConfiguration));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V19.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("readMultipleBlocksWithConfiguration:completionHandler:"), readConfiguration__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (readConfiguration);
		}
		[global::Foundation.RequiredMember]
		[Export ("stayQuietWithCompletionHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void StayQuiet ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _StayQuiet (INFCIso15693Tag This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("stayQuietWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("readSingleBlockWithRequestFlags:blockNumber:completionHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReadSingleBlock (NFCIso15693RequestFlag flags, byte blockNumber, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V19))]global::System.Action<NSData, NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ReadSingleBlock (INFCIso15693Tag This, NFCIso15693RequestFlag flags, byte blockNumber, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V19))]global::System.Action<NSData, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V19.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_byte_NativeHandle (This.Handle, Selector.GetHandle ("readSingleBlockWithRequestFlags:blockNumber:completionHandler:"), (byte)flags, blockNumber, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("writeSingleBlockWithRequestFlags:blockNumber:dataBlock:completionHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WriteSingleBlock (NFCIso15693RequestFlag flags, byte blockNumber, NSData dataBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _WriteSingleBlock (INFCIso15693Tag This, NFCIso15693RequestFlag flags, byte blockNumber, NSData dataBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			var dataBlock__handle__ = dataBlock!.GetNonNullHandle (nameof (dataBlock));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_byte_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("writeSingleBlockWithRequestFlags:blockNumber:dataBlock:completionHandler:"), (byte)flags, blockNumber, dataBlock__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (dataBlock);
		}
		[global::Foundation.RequiredMember]
		[Export ("lockBlockWithRequestFlags:blockNumber:completionHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LockBlock (NFCIso15693RequestFlag flags, byte blockNumber, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _LockBlock (INFCIso15693Tag This, NFCIso15693RequestFlag flags, byte blockNumber, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_byte_NativeHandle (This.Handle, Selector.GetHandle ("lockBlockWithRequestFlags:blockNumber:completionHandler:"), (byte)flags, blockNumber, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("readMultipleBlocksWithRequestFlags:blockRange:completionHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReadMultipleBlocks (NFCIso15693RequestFlag flags, NSRange blockRange, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V73))]global::System.Action<NSData[], NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ReadMultipleBlocks (INFCIso15693Tag This, NFCIso15693RequestFlag flags, NSRange blockRange, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V73))]global::System.Action<NSData[], NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V73.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("readMultipleBlocksWithRequestFlags:blockRange:completionHandler:"), (byte)flags, blockRange, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("writeMultipleBlocksWithRequestFlags:blockRange:dataBlocks:completionHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WriteMultipleBlocks (NFCIso15693RequestFlag flags, NSRange blockRange, NSData[] dataBlocks, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _WriteMultipleBlocks (INFCIso15693Tag This, NFCIso15693RequestFlag flags, NSRange blockRange, NSData[] dataBlocks, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (dataBlocks is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dataBlocks));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_dataBlocks = NSArray.FromNSObjects (dataBlocks);
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NSRange_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("writeMultipleBlocksWithRequestFlags:blockRange:dataBlocks:completionHandler:"), (byte)flags, blockRange, nsa_dataBlocks.Handle, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("selectWithRequestFlags:completionHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Select (NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Select (INFCIso15693Tag This, NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NativeHandle (This.Handle, Selector.GetHandle ("selectWithRequestFlags:completionHandler:"), (byte)flags, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("resetToReadyWithRequestFlags:completionHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResetToReady (NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResetToReady (INFCIso15693Tag This, NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NativeHandle (This.Handle, Selector.GetHandle ("resetToReadyWithRequestFlags:completionHandler:"), (byte)flags, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("writeAFIWithRequestFlag:afi:completionHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WriteAfi (NFCIso15693RequestFlag flags, byte afi, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _WriteAfi (INFCIso15693Tag This, NFCIso15693RequestFlag flags, byte afi, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_byte_NativeHandle (This.Handle, Selector.GetHandle ("writeAFIWithRequestFlag:afi:completionHandler:"), (byte)flags, afi, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("lockAFIWithRequestFlag:completionHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LockAfi (NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _LockAfi (INFCIso15693Tag This, NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NativeHandle (This.Handle, Selector.GetHandle ("lockAFIWithRequestFlag:completionHandler:"), (byte)flags, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("writeDSFIDWithRequestFlag:dsfid:completionHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void WriteDsfi (NFCIso15693RequestFlag flags, byte dsfid, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _WriteDsfi (INFCIso15693Tag This, NFCIso15693RequestFlag flags, byte dsfid, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_byte_NativeHandle (This.Handle, Selector.GetHandle ("writeDSFIDWithRequestFlag:dsfid:completionHandler:"), (byte)flags, dsfid, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("lockDFSIDWithRequestFlag:completionHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LockDfsi (NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _LockDfsi (INFCIso15693Tag This, NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NativeHandle (This.Handle, Selector.GetHandle ("lockDFSIDWithRequestFlag:completionHandler:"), (byte)flags, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("getSystemInfoWithRequestFlag:completionHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetSystemInfo (NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCGetSystemInfoCompletionHandler))]NFCGetSystemInfoCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _GetSystemInfo (INFCIso15693Tag This, NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCGetSystemInfoCompletionHandler))]NFCGetSystemInfoCompletionHandler completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCGetSystemInfoCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NativeHandle (This.Handle, Selector.GetHandle ("getSystemInfoWithRequestFlag:completionHandler:"), (byte)flags, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("getMultipleBlockSecurityStatusWithRequestFlag:blockRange:completionHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetMultipleBlockSecurityStatus (NFCIso15693RequestFlag flags, NSRange blockRange, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V76))]global::System.Action<NSNumber[], NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _GetMultipleBlockSecurityStatus (INFCIso15693Tag This, NFCIso15693RequestFlag flags, NSRange blockRange, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V76))]global::System.Action<NSNumber[], NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V76.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("getMultipleBlockSecurityStatusWithRequestFlag:blockRange:completionHandler:"), (byte)flags, blockRange, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("customCommandWithRequestFlag:customCommandCode:customRequestParameters:completionHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void CustomCommand (NFCIso15693RequestFlag flags, nint customCommandCode, NSData customRequestParameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V19))]global::System.Action<NSData, NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _CustomCommand (INFCIso15693Tag This, NFCIso15693RequestFlag flags, nint customCommandCode, NSData customRequestParameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V19))]global::System.Action<NSData, NSError> completionHandler)
		{
			var customRequestParameters__handle__ = customRequestParameters!.GetNonNullHandle (nameof (customRequestParameters));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V19.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_IntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("customCommandWithRequestFlag:customCommandCode:customRequestParameters:completionHandler:"), (byte)flags, customCommandCode, customRequestParameters__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (customRequestParameters);
		}
		[global::Foundation.RequiredMember]
		[Export ("extendedReadSingleBlockWithRequestFlags:blockNumber:completionHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ExtendedReadSingleBlock (NFCIso15693RequestFlag flags, nint blockNumber, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V19))]global::System.Action<NSData, NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ExtendedReadSingleBlock (INFCIso15693Tag This, NFCIso15693RequestFlag flags, nint blockNumber, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V19))]global::System.Action<NSData, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V19.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("extendedReadSingleBlockWithRequestFlags:blockNumber:completionHandler:"), (byte)flags, blockNumber, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("extendedWriteSingleBlockWithRequestFlags:blockNumber:dataBlock:completionHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ExtendedWriteSingleBlock (NFCIso15693RequestFlag flags, nint blockNumber, NSData dataBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ExtendedWriteSingleBlock (INFCIso15693Tag This, NFCIso15693RequestFlag flags, nint blockNumber, NSData dataBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			var dataBlock__handle__ = dataBlock!.GetNonNullHandle (nameof (dataBlock));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_IntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("extendedWriteSingleBlockWithRequestFlags:blockNumber:dataBlock:completionHandler:"), (byte)flags, blockNumber, dataBlock__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (dataBlock);
		}
		[global::Foundation.RequiredMember]
		[Export ("extendedLockBlockWithRequestFlags:blockNumber:completionHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ExtendedLockBlock (NFCIso15693RequestFlag flags, nint blockNumber, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ExtendedLockBlock (INFCIso15693Tag This, NFCIso15693RequestFlag flags, nint blockNumber, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_IntPtr_NativeHandle (This.Handle, Selector.GetHandle ("extendedLockBlockWithRequestFlags:blockNumber:completionHandler:"), (byte)flags, blockNumber, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("extendedReadMultipleBlocksWithRequestFlags:blockRange:completionHandler:")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ExtendedReadMultipleBlocks (NFCIso15693RequestFlag flags, NSRange blockRange, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V73))]global::System.Action<NSData[], NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ExtendedReadMultipleBlocks (INFCIso15693Tag This, NFCIso15693RequestFlag flags, NSRange blockRange, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V73))]global::System.Action<NSData[], NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V73.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("extendedReadMultipleBlocksWithRequestFlags:blockRange:completionHandler:"), (byte)flags, blockRange, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("extendedWriteMultipleBlocksWithRequestFlags:blockRange:dataBlocks:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ExtendedWriteMultipleBlocks (NFCIso15693RequestFlag flags, NSRange blockRange, NSData[] dataBlocks, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ExtendedWriteMultipleBlocks (INFCIso15693Tag This, NFCIso15693RequestFlag flags, NSRange blockRange, NSData[] dataBlocks, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (dataBlocks is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dataBlocks));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_dataBlocks = NSArray.FromNSObjects (dataBlocks);
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NSRange_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("extendedWriteMultipleBlocksWithRequestFlags:blockRange:dataBlocks:completionHandler:"), (byte)flags, blockRange, nsa_dataBlocks.Handle, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("authenticateWithRequestFlags:cryptoSuiteIdentifier:message:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Authenticate (NFCIso15693RequestFlag flags, nint cryptoSuiteIdentifier, NSData message, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagResponseCallback))]NFCIso15693TagResponseCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Authenticate (INFCIso15693Tag This, NFCIso15693RequestFlag flags, nint cryptoSuiteIdentifier, NSData message, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagResponseCallback))]NFCIso15693TagResponseCallback completionHandler)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCIso15693TagResponseCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_IntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("authenticateWithRequestFlags:cryptoSuiteIdentifier:message:completionHandler:"), (byte)flags, cryptoSuiteIdentifier, message__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (message);
		}
		[global::Foundation.RequiredMember]
		[Export ("keyUpdateWithRequestFlags:keyIdentifier:message:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void KeyUpdate (NFCIso15693RequestFlag flags, nint keyIdentifier, NSData message, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagResponseCallback))]NFCIso15693TagResponseCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _KeyUpdate (INFCIso15693Tag This, NFCIso15693RequestFlag flags, nint keyIdentifier, NSData message, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagResponseCallback))]NFCIso15693TagResponseCallback completionHandler)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCIso15693TagResponseCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_IntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("keyUpdateWithRequestFlags:keyIdentifier:message:completionHandler:"), (byte)flags, keyIdentifier, message__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (message);
		}
		[global::Foundation.RequiredMember]
		[Export ("challengeWithRequestFlags:cryptoSuiteIdentifier:message:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Challenge (NFCIso15693RequestFlag flags, nint cryptoSuiteIdentifier, NSData message, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _Challenge (INFCIso15693Tag This, NFCIso15693RequestFlag flags, nint cryptoSuiteIdentifier, NSData message, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_IntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("challengeWithRequestFlags:cryptoSuiteIdentifier:message:completionHandler:"), (byte)flags, cryptoSuiteIdentifier, message__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (message);
		}
		[global::Foundation.RequiredMember]
		[Export ("readBufferWithRequestFlags:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ReadBuffer (NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagResponseCallback))]NFCIso15693TagResponseCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ReadBuffer (INFCIso15693Tag This, NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagResponseCallback))]NFCIso15693TagResponseCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCIso15693TagResponseCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NativeHandle (This.Handle, Selector.GetHandle ("readBufferWithRequestFlags:completionHandler:"), (byte)flags, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("extendedGetMultipleBlockSecurityStatusWithRequestFlag:blockRange:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ExtendedGetMultipleBlockSecurityStatus (NFCIso15693RequestFlag flags, NSRange blockRange, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagGetMultipleBlockSecurityStatusCallback))]NFCIso15693TagGetMultipleBlockSecurityStatusCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ExtendedGetMultipleBlockSecurityStatus (INFCIso15693Tag This, NFCIso15693RequestFlag flags, NSRange blockRange, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagGetMultipleBlockSecurityStatusCallback))]NFCIso15693TagGetMultipleBlockSecurityStatusCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCIso15693TagGetMultipleBlockSecurityStatusCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("extendedGetMultipleBlockSecurityStatusWithRequestFlag:blockRange:completionHandler:"), (byte)flags, blockRange, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("extendedFastReadMultipleBlocksWithRequestFlag:blockRange:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ExtendedFastReadMultipleBlocks (NFCIso15693RequestFlag flags, NSRange blockRange, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagReadMultipleBlocksCallback))]NFCIso15693TagReadMultipleBlocksCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ExtendedFastReadMultipleBlocks (INFCIso15693Tag This, NFCIso15693RequestFlag flags, NSRange blockRange, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagReadMultipleBlocksCallback))]NFCIso15693TagReadMultipleBlocksCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCIso15693TagReadMultipleBlocksCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("extendedFastReadMultipleBlocksWithRequestFlag:blockRange:completionHandler:"), (byte)flags, blockRange, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("sendRequestWithFlag:commandCode:data:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SendRequest (nint flags, nint commandCode, NSData? data, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagResponseCallback))]NFCIso15693TagResponseCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _SendRequest (INFCIso15693Tag This, nint flags, nint commandCode, NSData? data, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagResponseCallback))]NFCIso15693TagResponseCallback completionHandler)
		{
			var data__handle__ = data.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCIso15693TagResponseCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("sendRequestWithFlag:commandCode:data:completionHandler:"), flags, commandCode, data__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
			GC.KeepAlive (data);
		}
		[global::Foundation.RequiredMember]
		[Export ("getSystemInfoAndUIDWithRequestFlag:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void GetSystemInfoAndUid (NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagGetSystemInfoAndUidCallback))]NFCIso15693TagGetSystemInfoAndUidCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _GetSystemInfoAndUid (INFCIso15693Tag This, NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagGetSystemInfoAndUidCallback))]NFCIso15693TagGetSystemInfoAndUidCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCIso15693TagGetSystemInfoAndUidCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NativeHandle (This.Handle, Selector.GetHandle ("getSystemInfoAndUIDWithRequestFlag:completionHandler:"), (byte)flags, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("fastReadMultipleBlocksWithRequestFlag:blockRange:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FastReadMultipleBlocks (NFCIso15693RequestFlag flags, NSRange blockRange, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagReadMultipleBlocksCallback))]NFCIso15693TagReadMultipleBlocksCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _FastReadMultipleBlocks (INFCIso15693Tag This, NFCIso15693RequestFlag flags, NSRange blockRange, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagReadMultipleBlocksCallback))]NFCIso15693TagReadMultipleBlocksCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCIso15693TagReadMultipleBlocksCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NSRange_NativeHandle (This.Handle, Selector.GetHandle ("fastReadMultipleBlocksWithRequestFlag:blockRange:completionHandler:"), (byte)flags, blockRange, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("lockDSFIDWithRequestFlag:completionHandler:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LockDsfId (NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _LockDsfId (INFCIso15693Tag This, NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NativeHandle (This.Handle, Selector.GetHandle ("lockDSFIDWithRequestFlag:completionHandler:"), (byte)flags, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("Authenticate(CoreNFC.NFCIso15693RequestFlag,System.IntPtr,Foundation.NSData,CoreNFC.NFCIso15693TagResponseCallback)")]
		[DynamicDependencyAttribute ("Challenge(CoreNFC.NFCIso15693RequestFlag,System.IntPtr,Foundation.NSData,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("CustomCommand(CoreNFC.NFCIso15693RequestFlag,System.IntPtr,Foundation.NSData,System.Action{Foundation.NSData,Foundation.NSError})")]
		[DynamicDependencyAttribute ("ExtendedFastReadMultipleBlocks(CoreNFC.NFCIso15693RequestFlag,Foundation.NSRange,CoreNFC.NFCIso15693TagReadMultipleBlocksCallback)")]
		[DynamicDependencyAttribute ("ExtendedGetMultipleBlockSecurityStatus(CoreNFC.NFCIso15693RequestFlag,Foundation.NSRange,CoreNFC.NFCIso15693TagGetMultipleBlockSecurityStatusCallback)")]
		[DynamicDependencyAttribute ("ExtendedLockBlock(CoreNFC.NFCIso15693RequestFlag,System.IntPtr,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("ExtendedReadMultipleBlocks(CoreNFC.NFCIso15693RequestFlag,Foundation.NSRange,System.Action{Foundation.NSData[],Foundation.NSError})")]
		[DynamicDependencyAttribute ("ExtendedReadSingleBlock(CoreNFC.NFCIso15693RequestFlag,System.IntPtr,System.Action{Foundation.NSData,Foundation.NSError})")]
		[DynamicDependencyAttribute ("ExtendedWriteMultipleBlocks(CoreNFC.NFCIso15693RequestFlag,Foundation.NSRange,Foundation.NSData[],System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("ExtendedWriteSingleBlock(CoreNFC.NFCIso15693RequestFlag,System.IntPtr,Foundation.NSData,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("FastReadMultipleBlocks(CoreNFC.NFCIso15693RequestFlag,Foundation.NSRange,CoreNFC.NFCIso15693TagReadMultipleBlocksCallback)")]
		[DynamicDependencyAttribute ("GetMultipleBlockSecurityStatus(CoreNFC.NFCIso15693RequestFlag,Foundation.NSRange,System.Action{Foundation.NSNumber[],Foundation.NSError})")]
		[DynamicDependencyAttribute ("GetSystemInfo(CoreNFC.NFCIso15693RequestFlag,CoreNFC.NFCGetSystemInfoCompletionHandler)")]
		[DynamicDependencyAttribute ("GetSystemInfoAndUid(CoreNFC.NFCIso15693RequestFlag,CoreNFC.NFCIso15693TagGetSystemInfoAndUidCallback)")]
		[DynamicDependencyAttribute ("IcManufacturerCode")]
		[DynamicDependencyAttribute ("IcSerialNumber")]
		[DynamicDependencyAttribute ("Identifier")]
		[DynamicDependencyAttribute ("KeyUpdate(CoreNFC.NFCIso15693RequestFlag,System.IntPtr,Foundation.NSData,CoreNFC.NFCIso15693TagResponseCallback)")]
		[DynamicDependencyAttribute ("LockAfi(CoreNFC.NFCIso15693RequestFlag,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("LockBlock(CoreNFC.NFCIso15693RequestFlag,System.Byte,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("LockDfsi(CoreNFC.NFCIso15693RequestFlag,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("LockDsfId(CoreNFC.NFCIso15693RequestFlag,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("ReadBuffer(CoreNFC.NFCIso15693RequestFlag,CoreNFC.NFCIso15693TagResponseCallback)")]
		[DynamicDependencyAttribute ("ReadMultipleBlocks(CoreNFC.NFCIso15693ReadMultipleBlocksConfiguration,System.Action{Foundation.NSData,Foundation.NSError})")]
		[DynamicDependencyAttribute ("ReadMultipleBlocks(CoreNFC.NFCIso15693RequestFlag,Foundation.NSRange,System.Action{Foundation.NSData[],Foundation.NSError})")]
		[DynamicDependencyAttribute ("ReadSingleBlock(CoreNFC.NFCIso15693RequestFlag,System.Byte,System.Action{Foundation.NSData,Foundation.NSError})")]
		[DynamicDependencyAttribute ("ResetToReady(CoreNFC.NFCIso15693RequestFlag,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("Select(CoreNFC.NFCIso15693RequestFlag,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("SendCustomCommand(CoreNFC.NFCIso15693CustomCommandConfiguration,System.Action{Foundation.NSData,Foundation.NSError})")]
		[DynamicDependencyAttribute ("SendRequest(System.IntPtr,System.IntPtr,Foundation.NSData,CoreNFC.NFCIso15693TagResponseCallback)")]
		[DynamicDependencyAttribute ("StayQuiet(System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("WriteAfi(CoreNFC.NFCIso15693RequestFlag,System.Byte,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("WriteDsfi(CoreNFC.NFCIso15693RequestFlag,System.Byte,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("WriteMultipleBlocks(CoreNFC.NFCIso15693RequestFlag,Foundation.NSRange,Foundation.NSData[],System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("WriteSingleBlock(CoreNFC.NFCIso15693RequestFlag,System.Byte,Foundation.NSData,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NFCIso15693TagWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INFCIso15693Tag ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the identifier of the tag, as <see cref="T:Foundation.NSData" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSData Identifier {
			[Export ("identifier", ArgumentSemantic.Copy)]
			get {
				return _GetIdentifier (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSData _GetIdentifier (INFCIso15693Tag This)
		{
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("identifier")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Manufacturer, as defined in ISO-7816-6.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint IcManufacturerCode {
			[Export ("icManufacturerCode")]
			get {
				return _GetIcManufacturerCode (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetIcManufacturerCode (INFCIso15693Tag This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("icManufacturerCode"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the serial number of the tag, as <see cref="T:Foundation.NSData" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSData IcSerialNumber {
			[Export ("icSerialNumber", ArgumentSemantic.Copy)]
			get {
				return _GetIcSerialNumber (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSData _GetIcSerialNumber (INFCIso15693Tag This)
		{
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("icSerialNumber")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NFCIso15693TagWrapper : BaseWrapper, INFCIso15693Tag {
		public NFCIso15693TagWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NFCIso15693TagWrapper))]
		static NFCIso15693TagWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="commandConfiguration">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("sendCustomCommandWithConfiguration:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void SendCustomCommand (NFCIso15693CustomCommandConfiguration commandConfiguration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V19))]global::System.Action<NSData, NSError> completionHandler)
		{
			var commandConfiguration__handle__ = commandConfiguration!.GetNonNullHandle (nameof (commandConfiguration));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V19.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("sendCustomCommandWithConfiguration:completionHandler:"), commandConfiguration__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (commandConfiguration);
		}
		/// <param name="readConfiguration">To be added.</param><param name="completionHandler">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("readMultipleBlocksWithConfiguration:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ReadMultipleBlocks (NFCIso15693ReadMultipleBlocksConfiguration readConfiguration, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V19))]global::System.Action<NSData, NSError> completionHandler)
		{
			var readConfiguration__handle__ = readConfiguration!.GetNonNullHandle (nameof (readConfiguration));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V19.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("readMultipleBlocksWithConfiguration:completionHandler:"), readConfiguration__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (readConfiguration);
		}
		[Export ("stayQuietWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void StayQuiet ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("stayQuietWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
		}
		[Export ("readSingleBlockWithRequestFlags:blockNumber:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ReadSingleBlock (NFCIso15693RequestFlag flags, byte blockNumber, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V19))]global::System.Action<NSData, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V19.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_byte_NativeHandle (this.Handle, Selector.GetHandle ("readSingleBlockWithRequestFlags:blockNumber:completionHandler:"), (byte)flags, blockNumber, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("writeSingleBlockWithRequestFlags:blockNumber:dataBlock:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void WriteSingleBlock (NFCIso15693RequestFlag flags, byte blockNumber, NSData dataBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			var dataBlock__handle__ = dataBlock!.GetNonNullHandle (nameof (dataBlock));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_byte_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("writeSingleBlockWithRequestFlags:blockNumber:dataBlock:completionHandler:"), (byte)flags, blockNumber, dataBlock__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (dataBlock);
		}
		[Export ("lockBlockWithRequestFlags:blockNumber:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void LockBlock (NFCIso15693RequestFlag flags, byte blockNumber, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_byte_NativeHandle (this.Handle, Selector.GetHandle ("lockBlockWithRequestFlags:blockNumber:completionHandler:"), (byte)flags, blockNumber, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("readMultipleBlocksWithRequestFlags:blockRange:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ReadMultipleBlocks (NFCIso15693RequestFlag flags, NSRange blockRange, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V73))]global::System.Action<NSData[], NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V73.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NSRange_NativeHandle (this.Handle, Selector.GetHandle ("readMultipleBlocksWithRequestFlags:blockRange:completionHandler:"), (byte)flags, blockRange, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("writeMultipleBlocksWithRequestFlags:blockRange:dataBlocks:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void WriteMultipleBlocks (NFCIso15693RequestFlag flags, NSRange blockRange, NSData[] dataBlocks, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (dataBlocks is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dataBlocks));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_dataBlocks = NSArray.FromNSObjects (dataBlocks);
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NSRange_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("writeMultipleBlocksWithRequestFlags:blockRange:dataBlocks:completionHandler:"), (byte)flags, blockRange, nsa_dataBlocks.Handle, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("selectWithRequestFlags:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void Select (NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NativeHandle (this.Handle, Selector.GetHandle ("selectWithRequestFlags:completionHandler:"), (byte)flags, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("resetToReadyWithRequestFlags:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ResetToReady (NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NativeHandle (this.Handle, Selector.GetHandle ("resetToReadyWithRequestFlags:completionHandler:"), (byte)flags, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("writeAFIWithRequestFlag:afi:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void WriteAfi (NFCIso15693RequestFlag flags, byte afi, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_byte_NativeHandle (this.Handle, Selector.GetHandle ("writeAFIWithRequestFlag:afi:completionHandler:"), (byte)flags, afi, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("lockAFIWithRequestFlag:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void LockAfi (NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NativeHandle (this.Handle, Selector.GetHandle ("lockAFIWithRequestFlag:completionHandler:"), (byte)flags, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("writeDSFIDWithRequestFlag:dsfid:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void WriteDsfi (NFCIso15693RequestFlag flags, byte dsfid, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_byte_NativeHandle (this.Handle, Selector.GetHandle ("writeDSFIDWithRequestFlag:dsfid:completionHandler:"), (byte)flags, dsfid, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("lockDFSIDWithRequestFlag:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void LockDfsi (NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NativeHandle (this.Handle, Selector.GetHandle ("lockDFSIDWithRequestFlag:completionHandler:"), (byte)flags, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("getSystemInfoWithRequestFlag:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void GetSystemInfo (NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCGetSystemInfoCompletionHandler))]NFCGetSystemInfoCompletionHandler completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCGetSystemInfoCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NativeHandle (this.Handle, Selector.GetHandle ("getSystemInfoWithRequestFlag:completionHandler:"), (byte)flags, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("getMultipleBlockSecurityStatusWithRequestFlag:blockRange:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void GetMultipleBlockSecurityStatus (NFCIso15693RequestFlag flags, NSRange blockRange, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V76))]global::System.Action<NSNumber[], NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V76.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NSRange_NativeHandle (this.Handle, Selector.GetHandle ("getMultipleBlockSecurityStatusWithRequestFlag:blockRange:completionHandler:"), (byte)flags, blockRange, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("customCommandWithRequestFlag:customCommandCode:customRequestParameters:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void CustomCommand (NFCIso15693RequestFlag flags, nint customCommandCode, NSData customRequestParameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V19))]global::System.Action<NSData, NSError> completionHandler)
		{
			var customRequestParameters__handle__ = customRequestParameters!.GetNonNullHandle (nameof (customRequestParameters));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V19.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_IntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("customCommandWithRequestFlag:customCommandCode:customRequestParameters:completionHandler:"), (byte)flags, customCommandCode, customRequestParameters__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (customRequestParameters);
		}
		[Export ("extendedReadSingleBlockWithRequestFlags:blockNumber:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ExtendedReadSingleBlock (NFCIso15693RequestFlag flags, nint blockNumber, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V19))]global::System.Action<NSData, NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V19.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("extendedReadSingleBlockWithRequestFlags:blockNumber:completionHandler:"), (byte)flags, blockNumber, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("extendedWriteSingleBlockWithRequestFlags:blockNumber:dataBlock:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ExtendedWriteSingleBlock (NFCIso15693RequestFlag flags, nint blockNumber, NSData dataBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			var dataBlock__handle__ = dataBlock!.GetNonNullHandle (nameof (dataBlock));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_IntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("extendedWriteSingleBlockWithRequestFlags:blockNumber:dataBlock:completionHandler:"), (byte)flags, blockNumber, dataBlock__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (dataBlock);
		}
		[Export ("extendedLockBlockWithRequestFlags:blockNumber:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ExtendedLockBlock (NFCIso15693RequestFlag flags, nint blockNumber, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("extendedLockBlockWithRequestFlags:blockNumber:completionHandler:"), (byte)flags, blockNumber, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("extendedReadMultipleBlocksWithRequestFlags:blockRange:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ExtendedReadMultipleBlocks (NFCIso15693RequestFlag flags, NSRange blockRange, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V73))]global::System.Action<NSData[], NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity2V73.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NSRange_NativeHandle (this.Handle, Selector.GetHandle ("extendedReadMultipleBlocksWithRequestFlags:blockRange:completionHandler:"), (byte)flags, blockRange, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("extendedWriteMultipleBlocksWithRequestFlags:blockRange:dataBlocks:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ExtendedWriteMultipleBlocks (NFCIso15693RequestFlag flags, NSRange blockRange, NSData[] dataBlocks, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (dataBlocks is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dataBlocks));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var nsa_dataBlocks = NSArray.FromNSObjects (dataBlocks);
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NSRange_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("extendedWriteMultipleBlocksWithRequestFlags:blockRange:dataBlocks:completionHandler:"), (byte)flags, blockRange, nsa_dataBlocks.Handle, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("authenticateWithRequestFlags:cryptoSuiteIdentifier:message:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void Authenticate (NFCIso15693RequestFlag flags, nint cryptoSuiteIdentifier, NSData message, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagResponseCallback))]NFCIso15693TagResponseCallback completionHandler)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCIso15693TagResponseCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_IntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("authenticateWithRequestFlags:cryptoSuiteIdentifier:message:completionHandler:"), (byte)flags, cryptoSuiteIdentifier, message__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (message);
		}
		[Export ("keyUpdateWithRequestFlags:keyIdentifier:message:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void KeyUpdate (NFCIso15693RequestFlag flags, nint keyIdentifier, NSData message, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagResponseCallback))]NFCIso15693TagResponseCallback completionHandler)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCIso15693TagResponseCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_IntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("keyUpdateWithRequestFlags:keyIdentifier:message:completionHandler:"), (byte)flags, keyIdentifier, message__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (message);
		}
		[Export ("challengeWithRequestFlags:cryptoSuiteIdentifier:message:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void Challenge (NFCIso15693RequestFlag flags, nint cryptoSuiteIdentifier, NSData message, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_IntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("challengeWithRequestFlags:cryptoSuiteIdentifier:message:completionHandler:"), (byte)flags, cryptoSuiteIdentifier, message__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (message);
		}
		[Export ("readBufferWithRequestFlags:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ReadBuffer (NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagResponseCallback))]NFCIso15693TagResponseCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCIso15693TagResponseCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NativeHandle (this.Handle, Selector.GetHandle ("readBufferWithRequestFlags:completionHandler:"), (byte)flags, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("extendedGetMultipleBlockSecurityStatusWithRequestFlag:blockRange:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ExtendedGetMultipleBlockSecurityStatus (NFCIso15693RequestFlag flags, NSRange blockRange, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagGetMultipleBlockSecurityStatusCallback))]NFCIso15693TagGetMultipleBlockSecurityStatusCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCIso15693TagGetMultipleBlockSecurityStatusCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NSRange_NativeHandle (this.Handle, Selector.GetHandle ("extendedGetMultipleBlockSecurityStatusWithRequestFlag:blockRange:completionHandler:"), (byte)flags, blockRange, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("extendedFastReadMultipleBlocksWithRequestFlag:blockRange:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ExtendedFastReadMultipleBlocks (NFCIso15693RequestFlag flags, NSRange blockRange, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagReadMultipleBlocksCallback))]NFCIso15693TagReadMultipleBlocksCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCIso15693TagReadMultipleBlocksCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NSRange_NativeHandle (this.Handle, Selector.GetHandle ("extendedFastReadMultipleBlocksWithRequestFlag:blockRange:completionHandler:"), (byte)flags, blockRange, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("sendRequestWithFlag:commandCode:data:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void SendRequest (nint flags, nint commandCode, NSData? data, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagResponseCallback))]NFCIso15693TagResponseCallback completionHandler)
		{
			var data__handle__ = data.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCIso15693TagResponseCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("sendRequestWithFlag:commandCode:data:completionHandler:"), flags, commandCode, data__handle__, (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (data);
		}
		[Export ("getSystemInfoAndUIDWithRequestFlag:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void GetSystemInfoAndUid (NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagGetSystemInfoAndUidCallback))]NFCIso15693TagGetSystemInfoAndUidCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCIso15693TagGetSystemInfoAndUidCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NativeHandle (this.Handle, Selector.GetHandle ("getSystemInfoAndUIDWithRequestFlag:completionHandler:"), (byte)flags, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("fastReadMultipleBlocksWithRequestFlag:blockRange:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void FastReadMultipleBlocks (NFCIso15693RequestFlag flags, NSRange blockRange, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNFCIso15693TagReadMultipleBlocksCallback))]NFCIso15693TagReadMultipleBlocksCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDNFCIso15693TagReadMultipleBlocksCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NSRange_NativeHandle (this.Handle, Selector.GetHandle ("fastReadMultipleBlocksWithRequestFlag:blockRange:completionHandler:"), (byte)flags, blockRange, (IntPtr) block_ptr_completionHandler);
		}
		[Export ("lockDSFIDWithRequestFlag:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void LockDsfId (NFCIso15693RequestFlag flags, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<NSError> completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDActionArity1V0.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_byte_NativeHandle (this.Handle, Selector.GetHandle ("lockDSFIDWithRequestFlag:completionHandler:"), (byte)flags, (IntPtr) block_ptr_completionHandler);
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
		/// <summary>Gets the identifier of the tag, as <see cref="T:Foundation.NSData" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSData Identifier {
			[Export ("identifier", ArgumentSemantic.Copy)]
			get {
				NSData ret;
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("identifier")), false)!;
				return ret;
			}
		}
		/// <summary>Manufacturer, as defined in ISO-7816-6.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint IcManufacturerCode {
			[Export ("icManufacturerCode")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("icManufacturerCode"));
				return ret;
			}
		}
		/// <summary>Gets the serial number of the tag, as <see cref="T:Foundation.NSData" />.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSData IcSerialNumber {
			[Export ("icSerialNumber", ArgumentSemantic.Copy)]
			get {
				NSData ret;
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("icSerialNumber")), false)!;
				return ret;
			}
		}
		/// <summary>Gets the kind of NFC tag.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public NFCTagType Type {
			[Export ("type", ArgumentSemantic.Assign)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				NFCTagType ret;
				ret = (CoreNFC.NFCTagType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
				return ret!;
			}
		}
		/// <summary>Gets the <see cref="T:CoreNFC.NFCReaderSession" /> that provided the tag.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public NFCReaderSession? Session {
			[Export ("session", ArgumentSemantic.Weak)]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				NFCReaderSession ret;
				ret =  Runtime.GetNSObject<NFCReaderSession> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("session")), false)!;
				return ret;
			}
		}
		/// <summary>Gets whether the tag is available for reading.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		public bool Available {
			[Export ("isAvailable")]
			[SupportedOSPlatform ("ios")]
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
