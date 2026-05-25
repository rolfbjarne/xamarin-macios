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
namespace CoreData {
	[Register("NSPersistentHistoryChangeRequest", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class NSPersistentHistoryChangeRequest : NSPersistentStoreRequest {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteHistoryBeforeDate_X = "deleteHistoryBeforeDate:";
		static readonly NativeHandle selDeleteHistoryBeforeDate_XHandle = Selector.GetHandle ("deleteHistoryBeforeDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteHistoryBeforeToken_X = "deleteHistoryBeforeToken:";
		static readonly NativeHandle selDeleteHistoryBeforeToken_XHandle = Selector.GetHandle ("deleteHistoryBeforeToken:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDeleteHistoryBeforeTransaction_X = "deleteHistoryBeforeTransaction:";
		static readonly NativeHandle selDeleteHistoryBeforeTransaction_XHandle = Selector.GetHandle ("deleteHistoryBeforeTransaction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchHistoryAfterDate_X = "fetchHistoryAfterDate:";
		static readonly NativeHandle selFetchHistoryAfterDate_XHandle = Selector.GetHandle ("fetchHistoryAfterDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchHistoryAfterToken_X = "fetchHistoryAfterToken:";
		static readonly NativeHandle selFetchHistoryAfterToken_XHandle = Selector.GetHandle ("fetchHistoryAfterToken:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchHistoryAfterTransaction_X = "fetchHistoryAfterTransaction:";
		static readonly NativeHandle selFetchHistoryAfterTransaction_XHandle = Selector.GetHandle ("fetchHistoryAfterTransaction:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchHistoryWithFetchRequest_X = "fetchHistoryWithFetchRequest:";
		static readonly NativeHandle selFetchHistoryWithFetchRequest_XHandle = Selector.GetHandle ("fetchHistoryWithFetchRequest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFetchRequestX = "fetchRequest";
		static readonly NativeHandle selFetchRequestXHandle = Selector.GetHandle ("fetchRequest");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResultTypeX = "resultType";
		static readonly NativeHandle selResultTypeXHandle = Selector.GetHandle ("resultType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFetchRequest_X = "setFetchRequest:";
		static readonly NativeHandle selSetFetchRequest_XHandle = Selector.GetHandle ("setFetchRequest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetResultType_X = "setResultType:";
		static readonly NativeHandle selSetResultType_XHandle = Selector.GetHandle ("setResultType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTokenX = "token";
		static readonly NativeHandle selTokenXHandle = Selector.GetHandle ("token");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSPersistentHistoryChangeRequest");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected NSPersistentHistoryChangeRequest (NSObjectFlag t) : base (t)
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
		protected internal NSPersistentHistoryChangeRequest (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="date">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("deleteHistoryBeforeDate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPersistentHistoryChangeRequest DeleteHistoryBefore (NSDate date)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			NSPersistentHistoryChangeRequest? ret;
			ret =  Runtime.GetNSObject<NSPersistentHistoryChangeRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selDeleteHistoryBeforeDate_XHandle, date__handle__), false)!;
			GC.KeepAlive (date);
			return ret!;
		}
		/// <param name="token"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("deleteHistoryBeforeToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPersistentHistoryChangeRequest DeleteHistoryBefore (NSPersistentHistoryToken? token)
		{
			var token__handle__ = token.GetHandle ();
			NSPersistentHistoryChangeRequest? ret;
			ret =  Runtime.GetNSObject<NSPersistentHistoryChangeRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selDeleteHistoryBeforeToken_XHandle, token__handle__), false)!;
			GC.KeepAlive (token);
			return ret!;
		}
		/// <param name="transaction"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("deleteHistoryBeforeTransaction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPersistentHistoryChangeRequest DeleteHistoryBefore (NSPersistentHistoryTransaction? transaction)
		{
			var transaction__handle__ = transaction.GetHandle ();
			NSPersistentHistoryChangeRequest? ret;
			ret =  Runtime.GetNSObject<NSPersistentHistoryChangeRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selDeleteHistoryBeforeTransaction_XHandle, transaction__handle__), false)!;
			GC.KeepAlive (transaction);
			return ret!;
		}
		[Export ("fetchHistoryWithFetchRequest:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPersistentHistoryChangeRequest FetchHistory (NSFetchRequest fetchRequest)
		{
			var fetchRequest__handle__ = fetchRequest!.GetNonNullHandle (nameof (fetchRequest));
			NSPersistentHistoryChangeRequest? ret;
			ret =  Runtime.GetNSObject<NSPersistentHistoryChangeRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selFetchHistoryWithFetchRequest_XHandle, fetchRequest__handle__), false)!;
			GC.KeepAlive (fetchRequest);
			return ret!;
		}
		/// <param name="date">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fetchHistoryAfterDate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPersistentHistoryChangeRequest FetchHistoryAfter (NSDate date)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			NSPersistentHistoryChangeRequest? ret;
			ret =  Runtime.GetNSObject<NSPersistentHistoryChangeRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selFetchHistoryAfterDate_XHandle, date__handle__), false)!;
			GC.KeepAlive (date);
			return ret!;
		}
		/// <param name="token"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fetchHistoryAfterToken:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPersistentHistoryChangeRequest FetchHistoryAfter (NSPersistentHistoryToken? token)
		{
			var token__handle__ = token.GetHandle ();
			NSPersistentHistoryChangeRequest? ret;
			ret =  Runtime.GetNSObject<NSPersistentHistoryChangeRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selFetchHistoryAfterToken_XHandle, token__handle__), false)!;
			GC.KeepAlive (token);
			return ret!;
		}
		/// <param name="transaction"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fetchHistoryAfterTransaction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPersistentHistoryChangeRequest FetchHistoryAfter (NSPersistentHistoryTransaction? transaction)
		{
			var transaction__handle__ = transaction.GetHandle ();
			NSPersistentHistoryChangeRequest? ret;
			ret =  Runtime.GetNSObject<NSPersistentHistoryChangeRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selFetchHistoryAfterTransaction_XHandle, transaction__handle__), false)!;
			GC.KeepAlive (transaction);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual NSFetchRequest? FetchRequest {
			[Export ("fetchRequest", ArgumentSemantic.Retain)]
			get {
				NSFetchRequest? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSFetchRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFetchRequestXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSFetchRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFetchRequestXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFetchRequest:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFetchRequest_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFetchRequest_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPersistentHistoryResultType ResultType {
			[Export ("resultType", ArgumentSemantic.Assign)]
			get {
				NSPersistentHistoryResultType ret;
				if (IsDirectBinding) {
					ret = (CoreData.NSPersistentHistoryResultType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selResultTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (CoreData.NSPersistentHistoryResultType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selResultTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setResultType:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetResultType_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetResultType_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPersistentHistoryToken? Token {
			[Export ("token", ArgumentSemantic.Retain)]
			get {
				NSPersistentHistoryToken? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSPersistentHistoryToken> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTokenXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSPersistentHistoryToken> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTokenXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class NSPersistentHistoryChangeRequest */
}
