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
namespace FSKit {
	[Register("FSBlockDeviceResource", true)]
	[SupportedOSPlatform ("macos15.4")]
	[Experimental ("APL0002")]
	public unsafe partial class FSBlockDeviceResource : FSResource {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBSDNameX = "BSDName";
		static readonly NativeHandle selBSDNameXHandle = Selector.GetHandle ("BSDName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAsynchronousMetadataFlushWithError_X = "asynchronousMetadataFlushWithError:";
		static readonly NativeHandle selAsynchronousMetadataFlushWithError_XHandle = Selector.GetHandle ("asynchronousMetadataFlushWithError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBlockCountX = "blockCount";
		static readonly NativeHandle selBlockCountXHandle = Selector.GetHandle ("blockCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBlockSizeX = "blockSize";
		static readonly NativeHandle selBlockSizeXHandle = Selector.GetHandle ("blockSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelayedMetadataWriteFrom_StartingAt_Length_Error_X = "delayedMetadataWriteFrom:startingAt:length:error:";
		static readonly NativeHandle selDelayedMetadataWriteFrom_StartingAt_Length_Error_XHandle = Selector.GetHandle ("delayedMetadataWriteFrom:startingAt:length:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsWritableX = "isWritable";
		static readonly NativeHandle selIsWritableXHandle = Selector.GetHandle ("isWritable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetadataClear_WithDelayedWrites_Error_X = "metadataClear:withDelayedWrites:error:";
		static readonly NativeHandle selMetadataClear_WithDelayedWrites_Error_XHandle = Selector.GetHandle ("metadataClear:withDelayedWrites:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetadataFlushWithError_X = "metadataFlushWithError:";
		static readonly NativeHandle selMetadataFlushWithError_XHandle = Selector.GetHandle ("metadataFlushWithError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetadataPurge_Error_X = "metadataPurge:error:";
		static readonly NativeHandle selMetadataPurge_Error_XHandle = Selector.GetHandle ("metadataPurge:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetadataReadInto_StartingAt_Length_Error_X = "metadataReadInto:startingAt:length:error:";
		static readonly NativeHandle selMetadataReadInto_StartingAt_Length_Error_XHandle = Selector.GetHandle ("metadataReadInto:startingAt:length:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMetadataWriteFrom_StartingAt_Length_Error_X = "metadataWriteFrom:startingAt:length:error:";
		static readonly NativeHandle selMetadataWriteFrom_StartingAt_Length_Error_XHandle = Selector.GetHandle ("metadataWriteFrom:startingAt:length:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPhysicalBlockSizeX = "physicalBlockSize";
		static readonly NativeHandle selPhysicalBlockSizeXHandle = Selector.GetHandle ("physicalBlockSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProxyResourceForBSDName_X = "proxyResourceForBSDName:";
		static readonly NativeHandle selProxyResourceForBSDName_XHandle = Selector.GetHandle ("proxyResourceForBSDName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProxyResourceForBSDName_IsWritable_X = "proxyResourceForBSDName:isWritable:";
		static readonly NativeHandle selProxyResourceForBSDName_IsWritable_XHandle = Selector.GetHandle ("proxyResourceForBSDName:isWritable:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadInto_StartingAt_Length_CompletionHandler_X = "readInto:startingAt:length:completionHandler:";
		static readonly NativeHandle selReadInto_StartingAt_Length_CompletionHandler_XHandle = Selector.GetHandle ("readInto:startingAt:length:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadInto_StartingAt_Length_Error_X = "readInto:startingAt:length:error:";
		static readonly NativeHandle selReadInto_StartingAt_Length_Error_XHandle = Selector.GetHandle ("readInto:startingAt:length:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteFrom_StartingAt_Length_CompletionHandler_X = "writeFrom:startingAt:length:completionHandler:";
		static readonly NativeHandle selWriteFrom_StartingAt_Length_CompletionHandler_XHandle = Selector.GetHandle ("writeFrom:startingAt:length:completionHandler:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteFrom_StartingAt_Length_Error_X = "writeFrom:startingAt:length:error:";
		static readonly NativeHandle selWriteFrom_StartingAt_Length_Error_XHandle = Selector.GetHandle ("writeFrom:startingAt:length:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("FSBlockDeviceResource");
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
		protected FSBlockDeviceResource (NSObjectFlag t) : base (t)
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
		protected internal FSBlockDeviceResource (NativeHandle handle) : base (handle)
		{
		}

		[Export ("asynchronousMetadataFlushWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool AsynchronousMetadataFlush (out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (this.Handle, selAsynchronousMetadataFlushWithError_XHandle, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selAsynchronousMetadataFlushWithError_XHandle, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("proxyResourceForBSDName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static FSBlockDeviceResource? CreateProxyResource (string bsdName)
		{
			if (bsdName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (bsdName));
			var nsbsdName = CFString.CreateNative (bsdName);
			FSBlockDeviceResource? ret;
			ret =  Runtime.GetNSObject<FSBlockDeviceResource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selProxyResourceForBSDName_XHandle, nsbsdName), false)!;
			CFString.ReleaseNative (nsbsdName);
			return ret!;
		}
		[Export ("proxyResourceForBSDName:isWritable:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static FSBlockDeviceResource? CreateProxyResource (string bsdName, bool isWritable)
		{
			if (bsdName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (bsdName));
			var nsbsdName = CFString.CreateNative (bsdName);
			FSBlockDeviceResource? ret;
			ret =  Runtime.GetNSObject<FSBlockDeviceResource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (class_ptr, selProxyResourceForBSDName_IsWritable_XHandle, nsbsdName, isWritable ? (byte) 1 : (byte) 0), false)!;
			CFString.ReleaseNative (nsbsdName);
			return ret!;
		}
		[Export ("delayedMetadataWriteFrom:startingAt:length:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool DelayedMetadataWrite (nint buffer, long offset, nuint length, out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_Int64_UIntPtr_ref_NativeHandle (this.Handle, selDelayedMetadataWriteFrom_StartingAt_Length_Error_XHandle, buffer, offset, length, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_Int64_UIntPtr_ref_NativeHandle (&__objc_super__, selDelayedMetadataWriteFrom_StartingAt_Length_Error_XHandle, buffer, offset, length, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("metadataClear:withDelayedWrites:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool MetadataClear (FSMetadataRange[] rangesToClear, bool withDelayedWrites, out NSError? error)
		{
			if (rangesToClear is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (rangesToClear));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_rangesToClear = NSArray.FromNSObjects (rangesToClear);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_bool_ref_NativeHandle (this.Handle, selMetadataClear_WithDelayedWrites_Error_XHandle, nsa_rangesToClear.Handle, withDelayedWrites ? (byte) 1 : (byte) 0, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_bool_ref_NativeHandle (&__objc_super__, selMetadataClear_WithDelayedWrites_Error_XHandle, nsa_rangesToClear.Handle, withDelayedWrites ? (byte) 1 : (byte) 0, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("metadataFlushWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool MetadataFlush (out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (this.Handle, selMetadataFlushWithError_XHandle, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selMetadataFlushWithError_XHandle, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("metadataPurge:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool MetadataPurge (FSMetadataRange[] rangesToPurge, out NSError? error)
		{
			if (rangesToPurge is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (rangesToPurge));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_rangesToPurge = NSArray.FromNSObjects (rangesToPurge);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selMetadataPurge_Error_XHandle, nsa_rangesToPurge.Handle, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selMetadataPurge_Error_XHandle, nsa_rangesToPurge.Handle, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("metadataReadInto:startingAt:length:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool MetadataRead (nint buffer, long offset, nuint length, out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_Int64_UIntPtr_ref_NativeHandle (this.Handle, selMetadataReadInto_StartingAt_Length_Error_XHandle, buffer, offset, length, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_Int64_UIntPtr_ref_NativeHandle (&__objc_super__, selMetadataReadInto_StartingAt_Length_Error_XHandle, buffer, offset, length, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("metadataWriteFrom:startingAt:length:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool MetadataWrite (nint buffer, long offset, nuint length, out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_Int64_UIntPtr_ref_NativeHandle (this.Handle, selMetadataWriteFrom_StartingAt_Length_Error_XHandle, buffer, offset, length, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_Int64_UIntPtr_ref_NativeHandle (&__objc_super__, selMetadataWriteFrom_StartingAt_Length_Error_XHandle, buffer, offset, length, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("readInto:startingAt:length:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Read (nint buffer, long offset, nuint length, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSBlockDeviceResourceReadReplyHandler))]FSBlockDeviceResourceReadReplyHandler completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDFSBlockDeviceResourceReadReplyHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_Int64_UIntPtr_NativeHandle (this.Handle, selReadInto_StartingAt_Length_CompletionHandler_XHandle, buffer, offset, length, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_Int64_UIntPtr_NativeHandle (&__objc_super__, selReadInto_StartingAt_Length_CompletionHandler_XHandle, buffer, offset, length, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<nuint> ReadAsync (nint buffer, long offset, nuint length)
		{
			var tcs = new TaskCompletionSource<nuint> ();
			Read(buffer, offset, length, (actuallyRead_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (actuallyRead_!);
			});
			return tcs.Task;
		}
		[Export ("readInto:startingAt:length:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual nuint Read (nint buffer, long offset, nuint length, out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_IntPtr_Int64_UIntPtr_ref_NativeHandle (this.Handle, selReadInto_StartingAt_Length_Error_XHandle, buffer, offset, length, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_IntPtr_Int64_UIntPtr_ref_NativeHandle (&__objc_super__, selReadInto_StartingAt_Length_Error_XHandle, buffer, offset, length, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("writeFrom:startingAt:length:completionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Write (nint buffer, long offset, nuint length, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFSBlockDeviceResourceWriteReplyHandler))]FSBlockDeviceResourceWriteReplyHandler completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDFSBlockDeviceResourceWriteReplyHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_Int64_UIntPtr_NativeHandle (this.Handle, selWriteFrom_StartingAt_Length_CompletionHandler_XHandle, buffer, offset, length, (IntPtr) block_ptr_completionHandler);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_Int64_UIntPtr_NativeHandle (&__objc_super__, selWriteFrom_StartingAt_Length_CompletionHandler_XHandle, buffer, offset, length, (IntPtr) block_ptr_completionHandler);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual Task<nuint> WriteAsync (nint buffer, long offset, nuint length)
		{
			var tcs = new TaskCompletionSource<nuint> ();
			Write(buffer, offset, length, (actuallyWritten_, error_) => {
				if (error_ is not null)
					tcs.SetException (new NSErrorException(error_));
				else
					tcs.SetResult (actuallyWritten_!);
			});
			return tcs.Task;
		}
		[Export ("writeFrom:startingAt:length:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual nuint Write (nint buffer, long offset, nuint length, out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_IntPtr_Int64_UIntPtr_ref_NativeHandle (this.Handle, selWriteFrom_StartingAt_Length_Error_XHandle, buffer, offset, length, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_IntPtr_Int64_UIntPtr_ref_NativeHandle (&__objc_super__, selWriteFrom_StartingAt_Length_Error_XHandle, buffer, offset, length, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong BlockCount {
			[Export ("blockCount")]
			get {
				ulong ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selBlockCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selBlockCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong BlockSize {
			[Export ("blockSize")]
			get {
				ulong ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selBlockSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selBlockSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string BsdName {
			[Export ("BSDName", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBSDNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBSDNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong PhysicalBlockSize {
			[Export ("physicalBlockSize")]
			get {
				ulong ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selPhysicalBlockSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selPhysicalBlockSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Writable {
			[Export ("isWritable")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsWritableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsWritableXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
	} /* class FSBlockDeviceResource */
}
