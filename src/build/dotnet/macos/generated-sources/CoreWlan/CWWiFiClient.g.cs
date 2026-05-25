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
namespace CoreWlan {
	[Register("CWWiFiClient", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class CWWiFiClient : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDelegateX = "delegate";
		static readonly NativeHandle selDelegateXHandle = Selector.GetHandle ("delegate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInterfaceX = "interface";
		static readonly NativeHandle selInterfaceXHandle = Selector.GetHandle ("interface");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInterfaceNamesX = "interfaceNames";
		static readonly NativeHandle selInterfaceNamesXHandle = Selector.GetHandle ("interfaceNames");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInterfaceWithName_X = "interfaceWithName:";
		static readonly NativeHandle selInterfaceWithName_XHandle = Selector.GetHandle ("interfaceWithName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInterfacesX = "interfaces";
		static readonly NativeHandle selInterfacesXHandle = Selector.GetHandle ("interfaces");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDelegate_X = "setDelegate:";
		static readonly NativeHandle selSetDelegate_XHandle = Selector.GetHandle ("setDelegate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedWiFiClientX = "sharedWiFiClient";
		static readonly NativeHandle selSharedWiFiClientXHandle = Selector.GetHandle ("sharedWiFiClient");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartMonitoringEventWithType_Error_X = "startMonitoringEventWithType:error:";
		static readonly NativeHandle selStartMonitoringEventWithType_Error_XHandle = Selector.GetHandle ("startMonitoringEventWithType:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopMonitoringAllEventsAndReturnError_X = "stopMonitoringAllEventsAndReturnError:";
		static readonly NativeHandle selStopMonitoringAllEventsAndReturnError_XHandle = Selector.GetHandle ("stopMonitoringAllEventsAndReturnError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStopMonitoringEventWithType_Error_X = "stopMonitoringEventWithType:error:";
		static readonly NativeHandle selStopMonitoringEventWithType_Error_XHandle = Selector.GetHandle ("stopMonitoringEventWithType:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CWWiFiClient");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="CWWiFiClient" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CWWiFiClient () : base (NSObjectFlag.Empty)
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
		protected CWWiFiClient (NSObjectFlag t) : base (t)
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
		protected internal CWWiFiClient (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="name">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("interfaceWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CWInterface? FromName (string? name)
		{
			var nsname = CFString.CreateNative (name);
			CWInterface? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<CWInterface> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInterfaceWithName_XHandle, nsname), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<CWInterface> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInterfaceWithName_XHandle, nsname), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("interfaceNames")]
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? GetInterfaceNames ()
		{
			string[] ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInterfaceNamesXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInterfaceNamesXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="type">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("startMonitoringEventWithType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool StartMonitoringEvent (CWEventType type, out NSError error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_ref_NativeHandle (this.Handle, selStartMonitoringEventWithType_Error_XHandle, (IntPtr) (long) type, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_ref_NativeHandle (&__objc_super__, selStartMonitoringEventWithType_Error_XHandle, (IntPtr) (long) type, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("stopMonitoringAllEventsAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool StopMonitoringAllEvents (out NSError error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (this.Handle, selStopMonitoringAllEventsAndReturnError_XHandle, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selStopMonitoringAllEventsAndReturnError_XHandle, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="type">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("stopMonitoringEventWithType:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool StopMonitoringEvent (CWEventType type, out NSError error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_ref_NativeHandle (this.Handle, selStopMonitoringEventWithType_Error_XHandle, (IntPtr) (long) type, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_ref_NativeHandle (&__objc_super__, selStopMonitoringEventWithType_Error_XHandle, (IntPtr) (long) type, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_Delegate_var;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ICWEventDelegate? Delegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				ICWEventDelegate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<ICWEventDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDelegateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<ICWEventDelegate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDelegateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDelegate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDelegate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("macos14.0", "Use the 'GetInterfaceNames' instance method instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public static string[]? InterfaceNames {
			[Export ("interfaceNames")]
			get {
				string[] ret;
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selInterfaceNamesXHandle), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CWInterface[]? Interfaces {
			[Export ("interfaces")]
			get {
				CWInterface[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<CWInterface>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInterfacesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<CWInterface>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInterfacesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CWInterface? MainInterface {
			[Export ("interface")]
			get {
				CWInterface? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CWInterface> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInterfaceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CWInterface> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInterfaceXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CWWiFiClient SharedWiFiClient {
			[Export ("sharedWiFiClient")]
			get {
				CWWiFiClient? ret;
				ret =  Runtime.GetNSObject<CWWiFiClient> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selSharedWiFiClientXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
			}
		}
	} /* class CWWiFiClient */
}
