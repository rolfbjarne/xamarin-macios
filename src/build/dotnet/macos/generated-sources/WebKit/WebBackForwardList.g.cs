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
namespace WebKit {
	[Register("WebBackForwardList", true)]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos10.14", "No longer supported.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class WebBackForwardList : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddItem_X = "addItem:";
		static readonly NativeHandle selAddItem_XHandle = Selector.GetHandle ("addItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBackItemX = "backItem";
		static readonly NativeHandle selBackItemXHandle = Selector.GetHandle ("backItem");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBackListCountX = "backListCount";
		static readonly NativeHandle selBackListCountXHandle = Selector.GetHandle ("backListCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBackListWithLimit_X = "backListWithLimit:";
		static readonly NativeHandle selBackListWithLimit_XHandle = Selector.GetHandle ("backListWithLimit:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCapacityX = "capacity";
		static readonly NativeHandle selCapacityXHandle = Selector.GetHandle ("capacity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContainsItem_X = "containsItem:";
		static readonly NativeHandle selContainsItem_XHandle = Selector.GetHandle ("containsItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentItemX = "currentItem";
		static readonly NativeHandle selCurrentItemXHandle = Selector.GetHandle ("currentItem");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selForwardItemX = "forwardItem";
		static readonly NativeHandle selForwardItemXHandle = Selector.GetHandle ("forwardItem");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selForwardListCountX = "forwardListCount";
		static readonly NativeHandle selForwardListCountXHandle = Selector.GetHandle ("forwardListCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selForwardListWithLimit_X = "forwardListWithLimit:";
		static readonly NativeHandle selForwardListWithLimit_XHandle = Selector.GetHandle ("forwardListWithLimit:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoBackX = "goBack";
		static readonly NativeHandle selGoBackXHandle = Selector.GetHandle ("goBack");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoForwardX = "goForward";
		static readonly NativeHandle selGoForwardXHandle = Selector.GetHandle ("goForward");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGoToItem_X = "goToItem:";
		static readonly NativeHandle selGoToItem_XHandle = Selector.GetHandle ("goToItem:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selItemAtIndex_X = "itemAtIndex:";
		static readonly NativeHandle selItemAtIndex_XHandle = Selector.GetHandle ("itemAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCapacity_X = "setCapacity:";
		static readonly NativeHandle selSetCapacity_XHandle = Selector.GetHandle ("setCapacity:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("WebBackForwardList");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="WebBackForwardList" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WebBackForwardList () : base (NSObjectFlag.Empty)
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
		protected WebBackForwardList (NSObjectFlag t) : base (t)
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
		protected internal WebBackForwardList (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddItem (WebHistoryItem item)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddItem_XHandle, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddItem_XHandle, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
		}
		[Export ("backItem")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebHistoryItem BackItem ()
		{
			WebHistoryItem ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WebHistoryItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBackItemXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WebHistoryItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBackItemXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("backListWithLimit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebHistoryItem[] BackListWithLimit (int limit)
		{
			WebHistoryItem[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<WebHistoryItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int (this.Handle, selBackListWithLimit_XHandle, limit), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<WebHistoryItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_int (&__objc_super__, selBackListWithLimit_XHandle, limit), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("containsItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ContainsItem (WebHistoryItem item)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selContainsItem_XHandle, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selContainsItem_XHandle, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
			return ret != 0;
		}
		[Export ("currentItem")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebHistoryItem CurrentItem ()
		{
			WebHistoryItem ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WebHistoryItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCurrentItemXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WebHistoryItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCurrentItemXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("forwardItem")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebHistoryItem ForwardItem ()
		{
			WebHistoryItem ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WebHistoryItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selForwardItemXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WebHistoryItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selForwardItemXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("forwardListWithLimit:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebHistoryItem[] ForwardListWithLimit (int limit)
		{
			WebHistoryItem[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<WebHistoryItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int (this.Handle, selForwardListWithLimit_XHandle, limit), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<WebHistoryItem>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_int (&__objc_super__, selForwardListWithLimit_XHandle, limit), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("goBack")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GoBack ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selGoBackXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selGoBackXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("goForward")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GoForward ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selGoForwardXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selGoForwardXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("goToItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void GoToItem (WebHistoryItem item)
		{
			var item__handle__ = item!.GetNonNullHandle (nameof (item));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selGoToItem_XHandle, item__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selGoToItem_XHandle, item__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (item);
		}
		[Export ("itemAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual WebHistoryItem ItemAtIndex (int index)
		{
			WebHistoryItem ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<WebHistoryItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int (this.Handle, selItemAtIndex_XHandle, index), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<WebHistoryItem> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_int (&__objc_super__, selItemAtIndex_XHandle, index), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int BackListCount {
			[Export ("backListCount")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selBackListCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selBackListCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int Capacity {
			[Export ("capacity")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selCapacityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selCapacityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCapacity:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetCapacity_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int (&__objc_super__, selSetCapacity_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int ForwardListCount {
			[Export ("forwardListCount")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selForwardListCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selForwardListCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class WebBackForwardList */
}
