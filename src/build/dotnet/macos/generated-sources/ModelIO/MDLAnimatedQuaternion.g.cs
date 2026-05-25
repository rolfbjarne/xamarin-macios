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
namespace ModelIO {
	[Register("MDLAnimatedQuaternion", true)]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class MDLAnimatedQuaternion : MDLAnimatedValue {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDoubleQuaternionAtTime_X = "doubleQuaternionAtTime:";
		static readonly NativeHandle selDoubleQuaternionAtTime_XHandle = Selector.GetHandle ("doubleQuaternionAtTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFloatQuaternionAtTime_X = "floatQuaternionAtTime:";
		static readonly NativeHandle selFloatQuaternionAtTime_XHandle = Selector.GetHandle ("floatQuaternionAtTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetDoubleQuaternionArray_MaxCount_X = "getDoubleQuaternionArray:maxCount:";
		static readonly NativeHandle selGetDoubleQuaternionArray_MaxCount_XHandle = Selector.GetHandle ("getDoubleQuaternionArray:maxCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetFloatQuaternionArray_MaxCount_X = "getFloatQuaternionArray:maxCount:";
		static readonly NativeHandle selGetFloatQuaternionArray_MaxCount_XHandle = Selector.GetHandle ("getFloatQuaternionArray:maxCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResetWithDoubleQuaternionArray_AtTimes_Count_X = "resetWithDoubleQuaternionArray:atTimes:count:";
		static readonly NativeHandle selResetWithDoubleQuaternionArray_AtTimes_Count_XHandle = Selector.GetHandle ("resetWithDoubleQuaternionArray:atTimes:count:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResetWithFloatQuaternionArray_AtTimes_Count_X = "resetWithFloatQuaternionArray:atTimes:count:";
		static readonly NativeHandle selResetWithFloatQuaternionArray_AtTimes_Count_XHandle = Selector.GetHandle ("resetWithFloatQuaternionArray:atTimes:count:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDoubleQuaternion_AtTime_X = "setDoubleQuaternion:atTime:";
		static readonly NativeHandle selSetDoubleQuaternion_AtTime_XHandle = Selector.GetHandle ("setDoubleQuaternion:atTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFloatQuaternion_AtTime_X = "setFloatQuaternion:atTime:";
		static readonly NativeHandle selSetFloatQuaternion_AtTime_XHandle = Selector.GetHandle ("setFloatQuaternion:atTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MDLAnimatedQuaternion");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MDLAnimatedQuaternion" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MDLAnimatedQuaternion () : base (NSObjectFlag.Empty)
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
		protected MDLAnimatedQuaternion (NSObjectFlag t) : base (t)
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
		protected internal MDLAnimatedQuaternion (NativeHandle handle) : base (handle)
		{
		}

		[Export ("doubleQuaternionAtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NQuaterniond GetDoubleQuaternion (double atTime)
		{
			NQuaterniond ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NQuaterniond_objc_msgSend_Double (this.Handle, selDoubleQuaternionAtTime_XHandle, atTime);
				} else {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NQuaterniond_objc_msgSend_stret_Double (this.Handle, selDoubleQuaternionAtTime_XHandle, atTime);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NQuaterniond_objc_msgSendSuper_Double (&__objc_super__, selDoubleQuaternionAtTime_XHandle, atTime);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NQuaterniond_objc_msgSendSuper_stret_Double (&__objc_super__, selDoubleQuaternionAtTime_XHandle, atTime);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("floatQuaternionAtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Quaternion GetFloatQuaternion (double atTime)
		{
			global::System.Numerics.Quaternion ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__Quaternion_objc_msgSend_Double (this.Handle, selFloatQuaternionAtTime_XHandle, atTime);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__Quaternion_objc_msgSendSuper_Double (&__objc_super__, selFloatQuaternionAtTime_XHandle, atTime);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("setFloatQuaternion:atTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetQuaternion (global::System.Numerics.Quaternion value, double atTime)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_Quaternion_Double (this.Handle, selSetFloatQuaternion_AtTime_XHandle, value, atTime);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_Quaternion_Double (&__objc_super__, selSetFloatQuaternion_AtTime_XHandle, value, atTime);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setDoubleQuaternion:atTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetQuaternion (NQuaterniond value, double atTime)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NQuaterniond_Double (this.Handle, selSetDoubleQuaternion_AtTime_XHandle, value, atTime);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_NQuaterniond_Double (&__objc_super__, selSetDoubleQuaternion_AtTime_XHandle, value, atTime);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("getDoubleQuaternionArray:maxCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nuint _GetDoubleQuaternionArray (nint valuesArray, nuint maxCount)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_IntPtr_UIntPtr (this.Handle, selGetDoubleQuaternionArray_MaxCount_XHandle, valuesArray, maxCount);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_IntPtr_UIntPtr (&__objc_super__, selGetDoubleQuaternionArray_MaxCount_XHandle, valuesArray, maxCount);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("getFloatQuaternionArray:maxCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nuint _GetFloatQuaternionArray (nint valuesArray, nuint maxCount)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_IntPtr_UIntPtr (this.Handle, selGetFloatQuaternionArray_MaxCount_XHandle, valuesArray, maxCount);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_IntPtr_UIntPtr (&__objc_super__, selGetFloatQuaternionArray_MaxCount_XHandle, valuesArray, maxCount);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("resetWithDoubleQuaternionArray:atTimes:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _ResetWithDoubleQuaternionArray (nint valuesArray, nint timesArray, nuint times)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_UIntPtr (this.Handle, selResetWithDoubleQuaternionArray_AtTimes_Count_XHandle, valuesArray, timesArray, times);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UIntPtr (&__objc_super__, selResetWithDoubleQuaternionArray_AtTimes_Count_XHandle, valuesArray, timesArray, times);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("resetWithFloatQuaternionArray:atTimes:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _ResetWithFloatQuaternionArray (nint valuesArray, nint timesArray, nuint times)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_UIntPtr (this.Handle, selResetWithFloatQuaternionArray_AtTimes_Count_XHandle, valuesArray, timesArray, times);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UIntPtr (&__objc_super__, selResetWithFloatQuaternionArray_AtTimes_Count_XHandle, valuesArray, timesArray, times);
					GC.KeepAlive (this);
				}
			}
		}
	} /* class MDLAnimatedQuaternion */
}
