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
namespace OSLog {
	[Register("OSLogEntrySignpost", true)]
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class OSLogEntrySignpost : OSLogEntry, IOSLogEntryFromProcess, IOSLogEntryWithPayload {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selActivityIdentifierX = "activityIdentifier";
		static readonly NativeHandle selActivityIdentifierXHandle = Selector.GetHandle ("activityIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCategoryX = "category";
		static readonly NativeHandle selCategoryXHandle = Selector.GetHandle ("category");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComponentsX = "components";
		static readonly NativeHandle selComponentsXHandle = Selector.GetHandle ("components");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFormatStringX = "formatString";
		static readonly NativeHandle selFormatStringXHandle = Selector.GetHandle ("formatString");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProcessX = "process";
		static readonly NativeHandle selProcessXHandle = Selector.GetHandle ("process");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProcessIdentifierX = "processIdentifier";
		static readonly NativeHandle selProcessIdentifierXHandle = Selector.GetHandle ("processIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSenderX = "sender";
		static readonly NativeHandle selSenderXHandle = Selector.GetHandle ("sender");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSignpostIdentifierX = "signpostIdentifier";
		static readonly NativeHandle selSignpostIdentifierXHandle = Selector.GetHandle ("signpostIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSignpostNameX = "signpostName";
		static readonly NativeHandle selSignpostNameXHandle = Selector.GetHandle ("signpostName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSignpostTypeX = "signpostType";
		static readonly NativeHandle selSignpostTypeXHandle = Selector.GetHandle ("signpostType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubsystemX = "subsystem";
		static readonly NativeHandle selSubsystemXHandle = Selector.GetHandle ("subsystem");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selThreadIdentifierX = "threadIdentifier";
		static readonly NativeHandle selThreadIdentifierXHandle = Selector.GetHandle ("threadIdentifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("OSLogEntrySignpost");
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
		protected OSLogEntrySignpost (NSObjectFlag t) : base (t)
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
		protected internal OSLogEntrySignpost (NativeHandle handle) : base (handle)
		{
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual ulong ActivityIdentifier {
			[Export ("activityIdentifier")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				ulong ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selActivityIdentifierXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selActivityIdentifierXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string Category {
			[Export ("category")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCategoryXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCategoryXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual OSLogMessageComponent[] Components {
			[Export ("components")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				OSLogMessageComponent[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<OSLogMessageComponent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selComponentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<OSLogMessageComponent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selComponentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string FormatString {
			[Export ("formatString")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFormatStringXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFormatStringXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string Process {
			[Export ("process")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selProcessXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selProcessXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual int ProcessIdentifier {
			[Export ("processIdentifier")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selProcessIdentifierXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selProcessIdentifierXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string Sender {
			[Export ("sender")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSenderXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSenderXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong SignpostIdentifier {
			[Export ("signpostIdentifier")]
			get {
				ulong ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selSignpostIdentifierXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selSignpostIdentifierXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string SignpostName {
			[Export ("signpostName")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSignpostNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSignpostNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual OSLogEntrySignpostType SignpostType {
			[Export ("signpostType")]
			get {
				OSLogEntrySignpostType ret;
				if (IsDirectBinding) {
					ret = (OSLog.OSLogEntrySignpostType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSignpostTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (OSLog.OSLogEntrySignpostType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selSignpostTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string Subsystem {
			[Export ("subsystem")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSubsystemXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSubsystemXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual ulong ThreadIdentifier {
			[Export ("threadIdentifier")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				ulong ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSend (this.Handle, selThreadIdentifierXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt64_objc_msgSendSuper (&__objc_super__, selThreadIdentifierXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class OSLogEntrySignpost */
}
