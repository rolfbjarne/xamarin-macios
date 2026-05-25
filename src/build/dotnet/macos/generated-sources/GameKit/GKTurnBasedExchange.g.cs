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
namespace GameKit {
	[Register("GKTurnBasedExchange", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GKTurnBasedExchange : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelWithLocalizableMessageKey_Arguments_CompletionHandler_X = "cancelWithLocalizableMessageKey:arguments:completionHandler:";
		static readonly NativeHandle selCancelWithLocalizableMessageKey_Arguments_CompletionHandler_XHandle = Selector.GetHandle ("cancelWithLocalizableMessageKey:arguments:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompletionDateX = "completionDate";
		static readonly NativeHandle selCompletionDateXHandle = Selector.GetHandle ("completionDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataX = "data";
		static readonly NativeHandle selDataXHandle = Selector.GetHandle ("data");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExchangeIDX = "exchangeID";
		static readonly NativeHandle selExchangeIDXHandle = Selector.GetHandle ("exchangeID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMessageX = "message";
		static readonly NativeHandle selMessageXHandle = Selector.GetHandle ("message");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecipientsX = "recipients";
		static readonly NativeHandle selRecipientsXHandle = Selector.GetHandle ("recipients");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRepliesX = "replies";
		static readonly NativeHandle selRepliesXHandle = Selector.GetHandle ("replies");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplyWithLocalizableMessageKey_Arguments_Data_CompletionHandler_X = "replyWithLocalizableMessageKey:arguments:data:completionHandler:";
		static readonly NativeHandle selReplyWithLocalizableMessageKey_Arguments_Data_CompletionHandler_XHandle = Selector.GetHandle ("replyWithLocalizableMessageKey:arguments:data:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendDateX = "sendDate";
		static readonly NativeHandle selSendDateXHandle = Selector.GetHandle ("sendDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSenderX = "sender";
		static readonly NativeHandle selSenderXHandle = Selector.GetHandle ("sender");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStatusX = "status";
		static readonly NativeHandle selStatusXHandle = Selector.GetHandle ("status");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimeoutDateX = "timeoutDate";
		static readonly NativeHandle selTimeoutDateXHandle = Selector.GetHandle ("timeoutDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GKTurnBasedExchange");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="GKTurnBasedExchange" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public GKTurnBasedExchange () : base (NSObjectFlag.Empty)
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
		protected GKTurnBasedExchange (NSObjectFlag t) : base (t)
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
		protected internal GKTurnBasedExchange (NativeHandle handle) : base (handle)
		{
		}

		[Export ("cancelWithLocalizableMessageKey:arguments:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Cancel (string localizableMessage, NSObject[] arguments, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			if (localizableMessage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localizableMessage));
			if (arguments is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (arguments));
			var nslocalizableMessage = CFString.CreateNative (localizableMessage);
			using var nsa_arguments = NSArray.FromNSObjects (arguments);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selCancelWithLocalizableMessageKey_Arguments_CompletionHandler_XHandle, nslocalizableMessage, nsa_arguments.Handle, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selCancelWithLocalizableMessageKey_Arguments_CompletionHandler_XHandle, nslocalizableMessage, nsa_arguments.Handle, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nslocalizableMessage);
		}
		/// <param name="localizableMessage">To be added.</param>
		/// <param name="arguments">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>A task that represents the asynchronous Cancel operation</returns>
		/// <remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task CancelAsync (string localizableMessage, NSObject[] arguments)
		{
			var tcs = new TaskCompletionSource<bool> ();
			Cancel(localizableMessage, arguments, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[Export ("replyWithLocalizableMessageKey:arguments:data:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Reply (string localizableMessage, NSObject[] arguments, NSData data, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError>? completionHandler)
		{
			if (localizableMessage is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localizableMessage));
			if (arguments is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (arguments));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var nslocalizableMessage = CFString.CreateNative (localizableMessage);
			using var nsa_arguments = NSArray.FromNSObjects (arguments);
			using var block_completionHandler = Trampolines.SDActionArity1V16.CreateNullableBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = null;
			if (completionHandler is not null)
				block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selReplyWithLocalizableMessageKey_Arguments_Data_CompletionHandler_XHandle, nslocalizableMessage, nsa_arguments.Handle, data__handle__, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selReplyWithLocalizableMessageKey_Arguments_Data_CompletionHandler_XHandle, nslocalizableMessage, nsa_arguments.Handle, data__handle__, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			CFString.ReleaseNative (nslocalizableMessage);
		}
		/// <param name="localizableMessage">To be added.</param>
		/// <param name="arguments">To be added.</param>
		/// <param name="data">To be added.</param>
		/// <summary>To be added.</summary>
		/// <returns>A task that represents the asynchronous Reply operation</returns>
		/// <remarks>
		///           <para copied="true">The ReplyAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
		///           <para copied="true">To be added.</para>
		///         </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task ReplyAsync (string localizableMessage, NSObject[] arguments, NSData data)
		{
			var tcs = new TaskCompletionSource<bool> ();
			Reply(localizableMessage, arguments, data, (obj_) => {
				if (obj_ is not null)
					tcs.SetException (new NSErrorException(obj_));
				else
					tcs.SetResult (true);
			});
			return tcs.Task;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate? CompletionDate {
			[Export ("completionDate")]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCompletionDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCompletionDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? Data {
			[Export ("data")]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDataXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDataXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? ExchangeID {
			[Export ("exchangeID")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selExchangeIDXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selExchangeIDXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Message {
			[Export ("message")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMessageXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMessageXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GKTurnBasedParticipant[]? Recipients {
			[Export ("recipients")]
			get {
				GKTurnBasedParticipant[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<GKTurnBasedParticipant>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRecipientsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<GKTurnBasedParticipant>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRecipientsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GKTurnBasedExchangeReply[]? Replies {
			[Export ("replies")]
			get {
				GKTurnBasedExchangeReply[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<GKTurnBasedExchangeReply>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRepliesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<GKTurnBasedExchangeReply>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRepliesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate? SendDate {
			[Export ("sendDate")]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSendDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSendDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GKTurnBasedParticipant? Sender {
			[Export ("sender")]
			get {
				GKTurnBasedParticipant? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<GKTurnBasedParticipant> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSenderXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<GKTurnBasedParticipant> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSenderXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GKTurnBasedExchangeStatus Status {
			[Export ("status", ArgumentSemantic.Assign)]
			get {
				GKTurnBasedExchangeStatus ret;
				if (IsDirectBinding) {
					ret = (GKTurnBasedExchangeStatus) global::ObjCRuntime.Messaging.SByte_objc_msgSend (this.Handle, selStatusXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (GKTurnBasedExchangeStatus) global::ObjCRuntime.Messaging.SByte_objc_msgSendSuper (&__objc_super__, selStatusXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate? TimeoutDate {
			[Export ("timeoutDate")]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTimeoutDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTimeoutDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Represents the value associated with the constant GKExchangeTimeoutDefault</summary><value></value><remarks>To be added.</remarks>
		[Field ("GKExchangeTimeoutDefault",  "GameKit")]
		public static double TimeoutDefault {
			get {
				return Dlfcn.GetDouble (Libraries.GameKit.Handle, "GKExchangeTimeoutDefault");
			}
		}
		/// <summary>Represents the value associated with the constant GKExchangeTimeoutNone</summary><value></value><remarks>To be added.</remarks>
		[Field ("GKExchangeTimeoutNone",  "GameKit")]
		public static double TimeoutNone {
			get {
				return Dlfcn.GetDouble (Libraries.GameKit.Handle, "GKExchangeTimeoutNone");
			}
		}
	} /* class GKTurnBasedExchange */
}
