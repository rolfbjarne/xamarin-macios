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
	[Register("FSStatFSResult", true)]
	[SupportedOSPlatform ("macos15.4")]
	[Experimental ("APL0002")]
	public unsafe partial class FSStatFSResult : NSObject, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableBlocksX = "availableBlocks";
		static readonly NativeHandle selAvailableBlocksXHandle = Selector.GetHandle ("availableBlocks");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAvailableBytesX = "availableBytes";
		static readonly NativeHandle selAvailableBytesXHandle = Selector.GetHandle ("availableBytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBlockSizeX = "blockSize";
		static readonly NativeHandle selBlockSizeXHandle = Selector.GetHandle ("blockSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileSystemSubTypeX = "fileSystemSubType";
		static readonly NativeHandle selFileSystemSubTypeXHandle = Selector.GetHandle ("fileSystemSubType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileSystemTypeNameX = "fileSystemTypeName";
		static readonly NativeHandle selFileSystemTypeNameXHandle = Selector.GetHandle ("fileSystemTypeName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFreeBlocksX = "freeBlocks";
		static readonly NativeHandle selFreeBlocksXHandle = Selector.GetHandle ("freeBlocks");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFreeBytesX = "freeBytes";
		static readonly NativeHandle selFreeBytesXHandle = Selector.GetHandle ("freeBytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFreeFilesX = "freeFiles";
		static readonly NativeHandle selFreeFilesXHandle = Selector.GetHandle ("freeFiles");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFileSystemTypeName_X = "initWithFileSystemTypeName:";
		static readonly NativeHandle selInitWithFileSystemTypeName_XHandle = Selector.GetHandle ("initWithFileSystemTypeName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIoSizeX = "ioSize";
		static readonly NativeHandle selIoSizeXHandle = Selector.GetHandle ("ioSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAvailableBlocks_X = "setAvailableBlocks:";
		static readonly NativeHandle selSetAvailableBlocks_XHandle = Selector.GetHandle ("setAvailableBlocks:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAvailableBytes_X = "setAvailableBytes:";
		static readonly NativeHandle selSetAvailableBytes_XHandle = Selector.GetHandle ("setAvailableBytes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBlockSize_X = "setBlockSize:";
		static readonly NativeHandle selSetBlockSize_XHandle = Selector.GetHandle ("setBlockSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFileSystemSubType_X = "setFileSystemSubType:";
		static readonly NativeHandle selSetFileSystemSubType_XHandle = Selector.GetHandle ("setFileSystemSubType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFreeBlocks_X = "setFreeBlocks:";
		static readonly NativeHandle selSetFreeBlocks_XHandle = Selector.GetHandle ("setFreeBlocks:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFreeBytes_X = "setFreeBytes:";
		static readonly NativeHandle selSetFreeBytes_XHandle = Selector.GetHandle ("setFreeBytes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFreeFiles_X = "setFreeFiles:";
		static readonly NativeHandle selSetFreeFiles_XHandle = Selector.GetHandle ("setFreeFiles:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetIoSize_X = "setIoSize:";
		static readonly NativeHandle selSetIoSize_XHandle = Selector.GetHandle ("setIoSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTotalBlocks_X = "setTotalBlocks:";
		static readonly NativeHandle selSetTotalBlocks_XHandle = Selector.GetHandle ("setTotalBlocks:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTotalBytes_X = "setTotalBytes:";
		static readonly NativeHandle selSetTotalBytes_XHandle = Selector.GetHandle ("setTotalBytes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTotalFiles_X = "setTotalFiles:";
		static readonly NativeHandle selSetTotalFiles_XHandle = Selector.GetHandle ("setTotalFiles:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsedBlocks_X = "setUsedBlocks:";
		static readonly NativeHandle selSetUsedBlocks_XHandle = Selector.GetHandle ("setUsedBlocks:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUsedBytes_X = "setUsedBytes:";
		static readonly NativeHandle selSetUsedBytes_XHandle = Selector.GetHandle ("setUsedBytes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTotalBlocksX = "totalBlocks";
		static readonly NativeHandle selTotalBlocksXHandle = Selector.GetHandle ("totalBlocks");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTotalBytesX = "totalBytes";
		static readonly NativeHandle selTotalBytesXHandle = Selector.GetHandle ("totalBytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTotalFilesX = "totalFiles";
		static readonly NativeHandle selTotalFilesXHandle = Selector.GetHandle ("totalFiles");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsedBlocksX = "usedBlocks";
		static readonly NativeHandle selUsedBlocksXHandle = Selector.GetHandle ("usedBlocks");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUsedBytesX = "usedBytes";
		static readonly NativeHandle selUsedBytesXHandle = Selector.GetHandle ("usedBytes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("FSStatFSResult");
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
		protected FSStatFSResult (NSObjectFlag t) : base (t)
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
		protected internal FSStatFSResult (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFileSystemTypeName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public FSStatFSResult (string fileSystemTypeName)
			: base (NSObjectFlag.Empty)
		{
			if (fileSystemTypeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fileSystemTypeName));
			var nsfileSystemTypeName = CFString.CreateNative (fileSystemTypeName);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithFileSystemTypeName_XHandle, nsfileSystemTypeName), "initWithFileSystemTypeName:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithFileSystemTypeName_XHandle, nsfileSystemTypeName), "initWithFileSystemTypeName:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfileSystemTypeName);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong AvailableBlocks {
			[Export ("availableBlocks")]
			get {
				ulong ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selAvailableBlocksXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selAvailableBlocksXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAvailableBlocks:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64 (this.Handle, selSetAvailableBlocks_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt64 (&__objc_super__, selSetAvailableBlocks_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong AvailableBytes {
			[Export ("availableBytes")]
			get {
				ulong ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selAvailableBytesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selAvailableBytesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAvailableBytes:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64 (this.Handle, selSetAvailableBytes_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt64 (&__objc_super__, selSetAvailableBytes_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint BlockSize {
			[Export ("blockSize")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBlockSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selBlockSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setBlockSize:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBlockSize_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetBlockSize_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint FileSystemSubType {
			[Export ("fileSystemSubType")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFileSystemSubTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selFileSystemSubTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFileSystemSubType:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFileSystemSubType_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetFileSystemSubType_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string FileSystemTypeName {
			[Export ("fileSystemTypeName", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFileSystemTypeNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFileSystemTypeNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong FreeBlocks {
			[Export ("freeBlocks")]
			get {
				ulong ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selFreeBlocksXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selFreeBlocksXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFreeBlocks:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64 (this.Handle, selSetFreeBlocks_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt64 (&__objc_super__, selSetFreeBlocks_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong FreeBytes {
			[Export ("freeBytes")]
			get {
				ulong ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selFreeBytesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selFreeBytesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFreeBytes:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64 (this.Handle, selSetFreeBytes_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt64 (&__objc_super__, selSetFreeBytes_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong FreeFiles {
			[Export ("freeFiles")]
			get {
				ulong ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selFreeFilesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selFreeFilesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFreeFiles:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64 (this.Handle, selSetFreeFiles_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt64 (&__objc_super__, selSetFreeFiles_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint IoSize {
			[Export ("ioSize")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIoSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selIoSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setIoSize:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetIoSize_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetIoSize_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong TotalBlocks {
			[Export ("totalBlocks")]
			get {
				ulong ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selTotalBlocksXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selTotalBlocksXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTotalBlocks:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64 (this.Handle, selSetTotalBlocks_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt64 (&__objc_super__, selSetTotalBlocks_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong TotalBytes {
			[Export ("totalBytes")]
			get {
				ulong ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selTotalBytesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selTotalBytesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTotalBytes:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64 (this.Handle, selSetTotalBytes_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt64 (&__objc_super__, selSetTotalBytes_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong TotalFiles {
			[Export ("totalFiles")]
			get {
				ulong ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selTotalFilesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selTotalFilesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTotalFiles:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64 (this.Handle, selSetTotalFiles_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt64 (&__objc_super__, selSetTotalFiles_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong UsedBlocks {
			[Export ("usedBlocks")]
			get {
				ulong ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selUsedBlocksXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selUsedBlocksXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setUsedBlocks:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64 (this.Handle, selSetUsedBlocks_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt64 (&__objc_super__, selSetUsedBlocks_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong UsedBytes {
			[Export ("usedBytes")]
			get {
				ulong ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selUsedBytesXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selUsedBytesXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setUsedBytes:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt64 (this.Handle, selSetUsedBytes_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt64 (&__objc_super__, selSetUsedBytes_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class FSStatFSResult */
}
