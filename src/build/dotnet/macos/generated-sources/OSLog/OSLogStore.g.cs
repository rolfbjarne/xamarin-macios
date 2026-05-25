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
	[Register("OSLogStore", true)]
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class OSLogStore : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEntriesEnumeratorAndReturnError_X = "entriesEnumeratorAndReturnError:";
		static readonly NativeHandle selEntriesEnumeratorAndReturnError_XHandle = Selector.GetHandle ("entriesEnumeratorAndReturnError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEntriesEnumeratorWithOptions_Position_Predicate_Error_X = "entriesEnumeratorWithOptions:position:predicate:error:";
		static readonly NativeHandle selEntriesEnumeratorWithOptions_Position_Predicate_Error_XHandle = Selector.GetHandle ("entriesEnumeratorWithOptions:position:predicate:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitX = "init";
		static readonly NativeHandle selInitXHandle = Selector.GetHandle ("init");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalStoreAndReturnError_X = "localStoreAndReturnError:";
		static readonly NativeHandle selLocalStoreAndReturnError_XHandle = Selector.GetHandle ("localStoreAndReturnError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPositionWithDate_X = "positionWithDate:";
		static readonly NativeHandle selPositionWithDate_XHandle = Selector.GetHandle ("positionWithDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPositionWithTimeIntervalSinceEnd_X = "positionWithTimeIntervalSinceEnd:";
		static readonly NativeHandle selPositionWithTimeIntervalSinceEnd_XHandle = Selector.GetHandle ("positionWithTimeIntervalSinceEnd:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPositionWithTimeIntervalSinceLatestBoot_X = "positionWithTimeIntervalSinceLatestBoot:";
		static readonly NativeHandle selPositionWithTimeIntervalSinceLatestBoot_XHandle = Selector.GetHandle ("positionWithTimeIntervalSinceLatestBoot:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStoreWithScope_Error_X = "storeWithScope:error:";
		static readonly NativeHandle selStoreWithScope_Error_XHandle = Selector.GetHandle ("storeWithScope:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStoreWithURL_Error_X = "storeWithURL:error:";
		static readonly NativeHandle selStoreWithURL_Error_XHandle = Selector.GetHandle ("storeWithURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("OSLogStore");
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
		protected OSLogStore (NSObjectFlag t) : base (t)
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
		protected internal OSLogStore (NativeHandle handle) : base (handle)
		{
		}

		[Export ("init")]
		[ObsoletedOSPlatform ("macos12.0", "Use one of the factory methods instead.")]
		[ObsoletedOSPlatform ("maccatalyst12.0", "Use one of the factory methods instead.")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public OSLogStore ()
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInitXHandle), "init");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInitXHandle), "init");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("localStoreAndReturnError:")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static OSLogStore? CreateLocalStore (out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			OSLogStore? ret;
			ret =  Runtime.GetNSObject<OSLogStore> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (class_ptr, selLocalStoreAndReturnError_XHandle, &errorValue), false)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("storeWithURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static OSLogStore? CreateStore (NSUrl url, out NSError? error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			OSLogStore? ret;
			ret =  Runtime.GetNSObject<OSLogStore> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (class_ptr, selStoreWithURL_Error_XHandle, url__handle__, &errorValue), false)!;
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("storeWithScope:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static OSLogStore? CreateStore (OSLogStoreScope scope, out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			OSLogStore? ret;
			ret =  Runtime.GetNSObject<OSLogStore> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_ref_NativeHandle (class_ptr, selStoreWithScope_Error_XHandle, (IntPtr) (long) scope, &errorValue), false)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("entriesEnumeratorWithOptions:position:predicate:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual OSLogEnumerator? GetEntriesEnumerator (OSLogEnumeratorOptions options, OSLogPosition? position, NSPredicate? predicate, out NSError? error)
		{
			var position__handle__ = position.GetHandle ();
			var predicate__handle__ = predicate.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			OSLogEnumerator? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<OSLogEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, selEntriesEnumeratorWithOptions_Position_Predicate_Error_XHandle, (UIntPtr) (ulong) options, position__handle__, predicate__handle__, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<OSLogEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_NativeHandle_NativeHandle_ref_NativeHandle (&__objc_super__, selEntriesEnumeratorWithOptions_Position_Predicate_Error_XHandle, (UIntPtr) (ulong) options, position__handle__, predicate__handle__, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (position);
			GC.KeepAlive (predicate);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("entriesEnumeratorAndReturnError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual OSLogEnumerator? GetEntriesEnumerator (out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			OSLogEnumerator? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<OSLogEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_ref_NativeHandle (this.Handle, selEntriesEnumeratorAndReturnError_XHandle, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<OSLogEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selEntriesEnumeratorAndReturnError_XHandle, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("positionWithDate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual OSLogPosition GetPosition (NSDate date)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			OSLogPosition? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<OSLogPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPositionWithDate_XHandle, date__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<OSLogPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPositionWithDate_XHandle, date__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
			return ret!;
		}
		[Export ("positionWithTimeIntervalSinceEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual OSLogPosition GetPositionWithTimeIntervalSinceEnd (double seconds)
		{
			OSLogPosition ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<OSLogPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (this.Handle, selPositionWithTimeIntervalSinceEnd_XHandle, seconds), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<OSLogPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_Double (&__objc_super__, selPositionWithTimeIntervalSinceEnd_XHandle, seconds), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("positionWithTimeIntervalSinceLatestBoot:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual OSLogPosition GetPositionWithTimeIntervalSinceLatestBoot (double seconds)
		{
			OSLogPosition ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<OSLogPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (this.Handle, selPositionWithTimeIntervalSinceLatestBoot_XHandle, seconds), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<OSLogPosition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_Double (&__objc_super__, selPositionWithTimeIntervalSinceLatestBoot_XHandle, seconds), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
	} /* class OSLogStore */
}
