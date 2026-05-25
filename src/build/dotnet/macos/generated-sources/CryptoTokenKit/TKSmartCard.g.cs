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
namespace CryptoTokenKit {
	[Register("TKSmartCard", true)]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos13.0")]
	public unsafe partial class TKSmartCard : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllowedProtocolsX = "allowedProtocols";
		static readonly NativeHandle selAllowedProtocolsXHandle = Selector.GetHandle ("allowedProtocols");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBeginSessionWithReply_X = "beginSessionWithReply:";
		static readonly NativeHandle selBeginSessionWithReply_XHandle = Selector.GetHandle ("beginSessionWithReply:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClaX = "cla";
		static readonly NativeHandle selClaXHandle = Selector.GetHandle ("cla");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContextX = "context";
		static readonly NativeHandle selContextXHandle = Selector.GetHandle ("context");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentProtocolX = "currentProtocol";
		static readonly NativeHandle selCurrentProtocolXHandle = Selector.GetHandle ("currentProtocol");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndSessionX = "endSession";
		static readonly NativeHandle selEndSessionXHandle = Selector.GetHandle ("endSession");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInSessionWithError_ExecuteBlock_X = "inSessionWithError:executeBlock:";
		static readonly NativeHandle selInSessionWithError_ExecuteBlock_XHandle = Selector.GetHandle ("inSessionWithError:executeBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendIns_P1_P2_Data_Le_Reply_X = "sendIns:p1:p2:data:le:reply:";
		static readonly NativeHandle selSendIns_P1_P2_Data_Le_Reply_XHandle = Selector.GetHandle ("sendIns:p1:p2:data:le:reply:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendIns_P1_P2_Data_Le_Sw_Error_X = "sendIns:p1:p2:data:le:sw:error:";
		static readonly NativeHandle selSendIns_P1_P2_Data_Le_Sw_Error_XHandle = Selector.GetHandle ("sendIns:p1:p2:data:le:sw:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSensitiveX = "sensitive";
		static readonly NativeHandle selSensitiveXHandle = Selector.GetHandle ("sensitive");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAllowedProtocols_X = "setAllowedProtocols:";
		static readonly NativeHandle selSetAllowedProtocols_XHandle = Selector.GetHandle ("setAllowedProtocols:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCla_X = "setCla:";
		static readonly NativeHandle selSetCla_XHandle = Selector.GetHandle ("setCla:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetContext_X = "setContext:";
		static readonly NativeHandle selSetContext_XHandle = Selector.GetHandle ("setContext:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSensitive_X = "setSensitive:";
		static readonly NativeHandle selSetSensitive_XHandle = Selector.GetHandle ("setSensitive:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUseCommandChaining_X = "setUseCommandChaining:";
		static readonly NativeHandle selSetUseCommandChaining_XHandle = Selector.GetHandle ("setUseCommandChaining:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUseExtendedLength_X = "setUseExtendedLength:";
		static readonly NativeHandle selSetUseExtendedLength_XHandle = Selector.GetHandle ("setUseExtendedLength:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSlotX = "slot";
		static readonly NativeHandle selSlotXHandle = Selector.GetHandle ("slot");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransmitRequest_Reply_X = "transmitRequest:reply:";
		static readonly NativeHandle selTransmitRequest_Reply_XHandle = Selector.GetHandle ("transmitRequest:reply:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUseCommandChainingX = "useCommandChaining";
		static readonly NativeHandle selUseCommandChainingXHandle = Selector.GetHandle ("useCommandChaining");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUseExtendedLengthX = "useExtendedLength";
		static readonly NativeHandle selUseExtendedLengthXHandle = Selector.GetHandle ("useExtendedLength");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserInteractionForSecurePINChangeWithPINFormat_APDU_CurrentPINByteOffset_NewPINByteOffset_X = "userInteractionForSecurePINChangeWithPINFormat:APDU:currentPINByteOffset:newPINByteOffset:";
		static readonly NativeHandle selUserInteractionForSecurePINChangeWithPINFormat_APDU_CurrentPINByteOffset_NewPINByteOffset_XHandle = Selector.GetHandle ("userInteractionForSecurePINChangeWithPINFormat:APDU:currentPINByteOffset:newPINByteOffset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserInteractionForSecurePINVerificationWithPINFormat_APDU_PINByteOffset_X = "userInteractionForSecurePINVerificationWithPINFormat:APDU:PINByteOffset:";
		static readonly NativeHandle selUserInteractionForSecurePINVerificationWithPINFormat_APDU_PINByteOffset_XHandle = Selector.GetHandle ("userInteractionForSecurePINVerificationWithPINFormat:APDU:PINByteOffset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValidX = "valid";
		static readonly NativeHandle selValidXHandle = Selector.GetHandle ("valid");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("TKSmartCard");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="TKSmartCard" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TKSmartCard () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		protected TKSmartCard (NSObjectFlag t) : base (t)
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
		protected internal TKSmartCard (NativeHandle handle) : base (handle)
		{
		}

		[Export ("beginSessionWithReply:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void BeginSession ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V13))]global::System.Action<bool, NSError> reply)
		{
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDActionArity2V13.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selBeginSessionWithReply_XHandle, (IntPtr) block_ptr_reply);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selBeginSessionWithReply_XHandle, (IntPtr) block_ptr_reply);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<Tuple<bool,NSError>> BeginSessionAsync ()
		{
			var tcs = new TaskCompletionSource<Tuple<bool,NSError>> ();
			BeginSession((arg1_, arg2_) => {
				tcs.SetResult (new Tuple<bool,NSError> (arg1_, arg2_));
			});
			return tcs.Task;
		}
		[Export ("userInteractionForSecurePINChangeWithPINFormat:APDU:currentPINByteOffset:newPINByteOffset:")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual TKSmartCardUserInteractionForSecurePinChange? CreateUserInteractionForSecurePinChange (TKSmartCardPinFormat pinFormat, NSData apdu, nint currentPinByteOffset, nint newPinByteOffset)
		{
			var pinFormat__handle__ = pinFormat!.GetNonNullHandle (nameof (pinFormat));
			var apdu__handle__ = apdu!.GetNonNullHandle (nameof (apdu));
			TKSmartCardUserInteractionForSecurePinChange? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<TKSmartCardUserInteractionForSecurePinChange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_IntPtr (this.Handle, selUserInteractionForSecurePINChangeWithPINFormat_APDU_CurrentPINByteOffset_NewPINByteOffset_XHandle, pinFormat__handle__, apdu__handle__, currentPinByteOffset, newPinByteOffset), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<TKSmartCardUserInteractionForSecurePinChange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr_IntPtr (&__objc_super__, selUserInteractionForSecurePINChangeWithPINFormat_APDU_CurrentPINByteOffset_NewPINByteOffset_XHandle, pinFormat__handle__, apdu__handle__, currentPinByteOffset, newPinByteOffset), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pinFormat);
			GC.KeepAlive (apdu);
			return ret!;
		}
		[Export ("userInteractionForSecurePINVerificationWithPINFormat:APDU:PINByteOffset:")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual TKSmartCardUserInteractionForSecurePinVerification? CreateUserInteractionForSecurePinVerification (TKSmartCardPinFormat pinFormat, NSData apdu, nint pinByteOffset)
		{
			var pinFormat__handle__ = pinFormat!.GetNonNullHandle (nameof (pinFormat));
			var apdu__handle__ = apdu!.GetNonNullHandle (nameof (apdu));
			TKSmartCardUserInteractionForSecurePinVerification? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<TKSmartCardUserInteractionForSecurePinVerification> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, selUserInteractionForSecurePINVerificationWithPINFormat_APDU_PINByteOffset_XHandle, pinFormat__handle__, apdu__handle__, pinByteOffset), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<TKSmartCardUserInteractionForSecurePinVerification> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selUserInteractionForSecurePINVerificationWithPINFormat_APDU_PINByteOffset_XHandle, pinFormat__handle__, apdu__handle__, pinByteOffset), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (pinFormat);
			GC.KeepAlive (apdu);
			return ret!;
		}
		[Export ("endSession")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EndSession ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selEndSessionXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selEndSessionXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("inSessionWithError:executeBlock:")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ExecuteBlock (out NSError? error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDTKSmartCardExecuteCallback))]TKSmartCardExecuteCallback block)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			NativeHandle errorValue = IntPtr.Zero;
			using var block_block = Trampolines.SDTKSmartCardExecuteCallback.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle_NativeHandle (this.Handle, selInSessionWithError_ExecuteBlock_XHandle, &errorValue, (IntPtr) block_ptr_block);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle_NativeHandle (&__objc_super__, selInSessionWithError_ExecuteBlock_XHandle, &errorValue, (IntPtr) block_ptr_block);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("sendIns:p1:p2:data:le:reply:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Send (byte ins, byte p1, byte p2, NSData? requestData, NSNumber? le, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDTKSmartCardSendCallback))]TKSmartCardSendCallback reply)
		{
			var requestData__handle__ = requestData.GetHandle ();
			var le__handle__ = le.GetHandle ();
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDTKSmartCardSendCallback.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_byte_byte_byte_NativeHandle_NativeHandle_NativeHandle (this.Handle, selSendIns_P1_P2_Data_Le_Reply_XHandle, ins, p1, p2, requestData__handle__, le__handle__, (IntPtr) block_ptr_reply);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_byte_byte_byte_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selSendIns_P1_P2_Data_Le_Reply_XHandle, ins, p1, p2, requestData__handle__, le__handle__, (IntPtr) block_ptr_reply);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (requestData);
			GC.KeepAlive (le);
		}
		[Export ("sendIns:p1:p2:data:le:sw:error:")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSData? Send (byte ins, byte p1, byte p2, NSData? requestData, NSNumber? le, out ushort sw, out NSError? error)
		{
			var requestData__handle__ = requestData.GetHandle ();
			var le__handle__ = le.GetHandle ();
			fixed (ushort* sw__pointer = &sw) {
			NativeHandle errorValue = IntPtr.Zero;
			sw = default;
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_byte_byte_byte_NativeHandle_NativeHandle_out_UInt16_ref_NativeHandle (this.Handle, selSendIns_P1_P2_Data_Le_Sw_Error_XHandle, ins, p1, p2, requestData__handle__, le__handle__, sw__pointer, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_byte_byte_byte_NativeHandle_NativeHandle_out_UInt16_ref_NativeHandle (&__objc_super__, selSendIns_P1_P2_Data_Le_Sw_Error_XHandle, ins, p1, p2, requestData__handle__, le__handle__, sw__pointer, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (requestData);
			GC.KeepAlive (le);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
			}
		}
		[Export ("transmitRequest:reply:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void TransmitRequest (NSData request, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V16))]global::System.Action<NSData, NSError> reply)
		{
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			if (reply is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (reply));
			using var block_reply = Trampolines.SDActionArity2V16.CreateBlock (reply);
			BlockLiteral *block_ptr_reply = &block_reply;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selTransmitRequest_Reply_XHandle, request__handle__, (IntPtr) block_ptr_reply);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selTransmitRequest_Reply_XHandle, request__handle__, (IntPtr) block_ptr_reply);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (request);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<NSData> TransmitRequestAsync (NSData request)
		{
			var tcs = new TaskCompletionSource<NSData> ();
			TransmitRequest(request, (arg1_, arg2_) => {
				if (arg2_ is not null)
					tcs.SetException (new NSErrorException(arg2_));
				else
					tcs.SetResult (arg1_!);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual TKSmartCardProtocol AllowedProtocols {
			[Export ("allowedProtocols", ArgumentSemantic.Assign)]
			get {
				TKSmartCardProtocol ret;
				if (IsDirectBinding) {
					ret = (CryptoTokenKit.TKSmartCardProtocol) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selAllowedProtocolsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (CryptoTokenKit.TKSmartCardProtocol) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selAllowedProtocolsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAllowedProtocols:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetAllowedProtocols_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetAllowedProtocols_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual byte Cla {
			[Export ("cla")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.byte_objc_msgSend (this.Handle, selClaXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.byte_objc_msgSendSuper (&__objc_super__, selClaXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCla:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_byte (this.Handle, selSetCla_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_byte (&__objc_super__, selSetCla_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Context_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? Context {
			[Export ("context", ArgumentSemantic.Assign)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selContextXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selContextXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_Context_var = ret;
				return ret!;
			}
			[Export ("setContext:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetContext_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetContext_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_Context_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual TKSmartCardProtocol CurrentProtocol {
			[Export ("currentProtocol")]
			get {
				TKSmartCardProtocol ret;
				if (IsDirectBinding) {
					ret = (CryptoTokenKit.TKSmartCardProtocol) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selCurrentProtocolXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (CryptoTokenKit.TKSmartCardProtocol) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selCurrentProtocolXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Sensitive {
			[Export ("sensitive")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSensitiveXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selSensitiveXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSensitive:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSensitive_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetSensitive_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual TKSmartCardSlot Slot {
			[Export ("slot")]
			get {
				TKSmartCardSlot? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<TKSmartCardSlot> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSlotXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<TKSmartCardSlot> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSlotXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool UseCommandChaining {
			[Export ("useCommandChaining")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUseCommandChainingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUseCommandChainingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUseCommandChaining:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUseCommandChaining_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUseCommandChaining_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UseExtendedLength {
			[Export ("useExtendedLength")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selUseExtendedLengthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selUseExtendedLengthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setUseExtendedLength:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetUseExtendedLength_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetUseExtendedLength_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Valid {
			[Export ("valid")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selValidXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selValidXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Context_var = null;
			}
		}
	} /* class TKSmartCard */
}
