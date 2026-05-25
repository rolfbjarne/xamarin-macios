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
namespace Foundation {
	[Register("NSTimer", true)]
	public unsafe partial class NSTimer : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFireX = "fire";
		static readonly NativeHandle selFireXHandle = Selector.GetHandle ("fire");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFireDateX = "fireDate";
		static readonly NativeHandle selFireDateXHandle = Selector.GetHandle ("fireDate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFireDate_Interval_Repeats_Block_X = "initWithFireDate:interval:repeats:block:";
		static readonly NativeHandle selInitWithFireDate_Interval_Repeats_Block_XHandle = Selector.GetHandle ("initWithFireDate:interval:repeats:block:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithFireDate_Interval_Target_Selector_UserInfo_Repeats_X = "initWithFireDate:interval:target:selector:userInfo:repeats:";
		static readonly NativeHandle selInitWithFireDate_Interval_Target_Selector_UserInfo_Repeats_XHandle = Selector.GetHandle ("initWithFireDate:interval:target:selector:userInfo:repeats:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInvalidateX = "invalidate";
		static readonly NativeHandle selInvalidateXHandle = Selector.GetHandle ("invalidate");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsValidX = "isValid";
		static readonly NativeHandle selIsValidXHandle = Selector.GetHandle ("isValid");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScheduledTimerWithTimeInterval_Repeats_Block_X = "scheduledTimerWithTimeInterval:repeats:block:";
		static readonly NativeHandle selScheduledTimerWithTimeInterval_Repeats_Block_XHandle = Selector.GetHandle ("scheduledTimerWithTimeInterval:repeats:block:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScheduledTimerWithTimeInterval_Target_Selector_UserInfo_Repeats_X = "scheduledTimerWithTimeInterval:target:selector:userInfo:repeats:";
		static readonly NativeHandle selScheduledTimerWithTimeInterval_Target_Selector_UserInfo_Repeats_XHandle = Selector.GetHandle ("scheduledTimerWithTimeInterval:target:selector:userInfo:repeats:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFireDate_X = "setFireDate:";
		static readonly NativeHandle selSetFireDate_XHandle = Selector.GetHandle ("setFireDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTolerance_X = "setTolerance:";
		static readonly NativeHandle selSetTolerance_XHandle = Selector.GetHandle ("setTolerance:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimeIntervalX = "timeInterval";
		static readonly NativeHandle selTimeIntervalXHandle = Selector.GetHandle ("timeInterval");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimerWithTimeInterval_Repeats_Block_X = "timerWithTimeInterval:repeats:block:";
		static readonly NativeHandle selTimerWithTimeInterval_Repeats_Block_XHandle = Selector.GetHandle ("timerWithTimeInterval:repeats:block:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTimerWithTimeInterval_Target_Selector_UserInfo_Repeats_X = "timerWithTimeInterval:target:selector:userInfo:repeats:";
		static readonly NativeHandle selTimerWithTimeInterval_Target_Selector_UserInfo_Repeats_XHandle = Selector.GetHandle ("timerWithTimeInterval:target:selector:userInfo:repeats:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToleranceX = "tolerance";
		static readonly NativeHandle selToleranceXHandle = Selector.GetHandle ("tolerance");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUserInfoX = "userInfo";
		static readonly NativeHandle selUserInfoXHandle = Selector.GetHandle ("userInfo");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSTimer");
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
		protected NSTimer (NSObjectFlag t) : base (t)
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
		protected internal NSTimer (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithFireDate:interval:target:selector:userInfo:repeats:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSTimer (NSDate date, double seconds, NSObject target, Selector selector, NSObject? userInfo, bool repeats)
			: base (NSObjectFlag.Empty)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			var target__handle__ = target!.GetNonNullHandle (nameof (target));
			var selector__handle__ = selector!.GetNonNullHandle (nameof (selector));
			var userInfo__handle__ = userInfo.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double_NativeHandle_NativeHandle_NativeHandle_bool (this.Handle, selInitWithFireDate_Interval_Target_Selector_UserInfo_Repeats_XHandle, date__handle__, seconds, target__handle__, selector.Handle, userInfo__handle__, repeats ? (byte) 1 : (byte) 0), "initWithFireDate:interval:target:selector:userInfo:repeats:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_Double_NativeHandle_NativeHandle_NativeHandle_bool (&__objc_super__, selInitWithFireDate_Interval_Target_Selector_UserInfo_Repeats_XHandle, date__handle__, seconds, target__handle__, selector.Handle, userInfo__handle__, repeats ? (byte) 1 : (byte) 0), "initWithFireDate:interval:target:selector:userInfo:repeats:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
			GC.KeepAlive (target);
			GC.KeepAlive (selector);
			GC.KeepAlive (userInfo);
		}
		[Export ("initWithFireDate:interval:repeats:block:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSTimer (NSDate date, double seconds, bool repeats, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V55))]global::System.Action<NSTimer> block)
			: base (NSObjectFlag.Empty)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			using var block_block = Trampolines.SDActionArity1V55.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_Double_bool_NativeHandle (this.Handle, selInitWithFireDate_Interval_Repeats_Block_XHandle, date__handle__, seconds, repeats ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_block), "initWithFireDate:interval:repeats:block:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_Double_bool_NativeHandle (&__objc_super__, selInitWithFireDate_Interval_Repeats_Block_XHandle, date__handle__, seconds, repeats ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_block), "initWithFireDate:interval:repeats:block:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (date);
		}
		[Export ("scheduledTimerWithTimeInterval:target:selector:userInfo:repeats:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTimer CreateScheduledTimer (double seconds, NSObject target, Selector selector, NSObject? userInfo, bool repeats)
		{
			var target__handle__ = target!.GetNonNullHandle (nameof (target));
			var selector__handle__ = selector!.GetNonNullHandle (nameof (selector));
			var userInfo__handle__ = userInfo.GetHandle ();
			NSTimer? ret;
			ret =  Runtime.GetNSObject<NSTimer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double_NativeHandle_NativeHandle_NativeHandle_bool (class_ptr, selScheduledTimerWithTimeInterval_Target_Selector_UserInfo_Repeats_XHandle, seconds, target__handle__, selector.Handle, userInfo__handle__, repeats ? (byte) 1 : (byte) 0), false)!;
			GC.KeepAlive (target);
			GC.KeepAlive (selector);
			GC.KeepAlive (userInfo);
			return ret!;
		}
		[Export ("scheduledTimerWithTimeInterval:repeats:block:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSTimer CreateScheduledTimer (double interval, bool repeats, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V55))]global::System.Action<NSTimer> block)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			using var block_block = Trampolines.SDActionArity1V55.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			NSTimer ret;
			ret =  Runtime.GetNSObject<NSTimer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double_bool_NativeHandle (class_ptr, selScheduledTimerWithTimeInterval_Repeats_Block_XHandle, interval, repeats ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_block), false)!;
			return ret;
		}
		[Export ("timerWithTimeInterval:target:selector:userInfo:repeats:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSTimer CreateTimer (double seconds, NSObject target, Selector selector, NSObject? userInfo, bool repeats)
		{
			var target__handle__ = target!.GetNonNullHandle (nameof (target));
			var selector__handle__ = selector!.GetNonNullHandle (nameof (selector));
			var userInfo__handle__ = userInfo.GetHandle ();
			NSTimer? ret;
			ret =  Runtime.GetNSObject<NSTimer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double_NativeHandle_NativeHandle_NativeHandle_bool (class_ptr, selTimerWithTimeInterval_Target_Selector_UserInfo_Repeats_XHandle, seconds, target__handle__, selector.Handle, userInfo__handle__, repeats ? (byte) 1 : (byte) 0), false)!;
			GC.KeepAlive (target);
			GC.KeepAlive (selector);
			GC.KeepAlive (userInfo);
			return ret!;
		}
		[Export ("timerWithTimeInterval:repeats:block:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSTimer CreateTimer (double interval, bool repeats, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V55))]global::System.Action<NSTimer> block)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			using var block_block = Trampolines.SDActionArity1V55.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			NSTimer ret;
			ret =  Runtime.GetNSObject<NSTimer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double_bool_NativeHandle (class_ptr, selTimerWithTimeInterval_Repeats_Block_XHandle, interval, repeats ? (byte) 1 : (byte) 0, (IntPtr) block_ptr_block), false)!;
			return ret;
		}
		[Export ("fire")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Fire ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFireXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selFireXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("invalidate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Invalidate ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selInvalidateXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selInvalidateXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate? FireDate {
			[Export ("fireDate", ArgumentSemantic.Copy)]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFireDateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFireDateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFireDate:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFireDate_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFireDate_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Returns <see langword="true" /> if the the timer will still fire at some point in the future.</summary><value></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsValid {
			[Export ("isValid")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsValidXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsValidXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double TimeInterval {
			[Export ("timeInterval")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selTimeIntervalXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selTimeIntervalXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual double Tolerance {
			[Export ("tolerance")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selToleranceXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selToleranceXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTolerance:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetTolerance_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetTolerance_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject UserInfo {
			[Export ("userInfo")]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selUserInfoXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selUserInfoXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			if (disposing) { Invalidate (); } 
			base.Dispose (disposing);
		}
	} /* class NSTimer */
}
