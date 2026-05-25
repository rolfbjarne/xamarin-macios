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
	[Register("MDLAnimatedMatrix4x4", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MDLAnimatedMatrix4x4 : MDLAnimatedValue {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDouble4x4AtTime_X = "double4x4AtTime:";
		static readonly NativeHandle selDouble4x4AtTime_XHandle = Selector.GetHandle ("double4x4AtTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFloat4x4AtTime_X = "float4x4AtTime:";
		static readonly NativeHandle selFloat4x4AtTime_XHandle = Selector.GetHandle ("float4x4AtTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetDouble4x4Array_MaxCount_X = "getDouble4x4Array:maxCount:";
		static readonly NativeHandle selGetDouble4x4Array_MaxCount_XHandle = Selector.GetHandle ("getDouble4x4Array:maxCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetFloat4x4Array_MaxCount_X = "getFloat4x4Array:maxCount:";
		static readonly NativeHandle selGetFloat4x4Array_MaxCount_XHandle = Selector.GetHandle ("getFloat4x4Array:maxCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResetWithDouble4x4Array_AtTimes_Count_X = "resetWithDouble4x4Array:atTimes:count:";
		static readonly NativeHandle selResetWithDouble4x4Array_AtTimes_Count_XHandle = Selector.GetHandle ("resetWithDouble4x4Array:atTimes:count:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResetWithFloat4x4Array_AtTimes_Count_X = "resetWithFloat4x4Array:atTimes:count:";
		static readonly NativeHandle selResetWithFloat4x4Array_AtTimes_Count_XHandle = Selector.GetHandle ("resetWithFloat4x4Array:atTimes:count:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDouble4x4_AtTime_X = "setDouble4x4:atTime:";
		static readonly NativeHandle selSetDouble4x4_AtTime_XHandle = Selector.GetHandle ("setDouble4x4:atTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFloat4x4_AtTime_X = "setFloat4x4:atTime:";
		static readonly NativeHandle selSetFloat4x4_AtTime_XHandle = Selector.GetHandle ("setFloat4x4:atTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MDLAnimatedMatrix4x4");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MDLAnimatedMatrix4x4" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MDLAnimatedMatrix4x4 () : base (NSObjectFlag.Empty)
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
		protected MDLAnimatedMatrix4x4 (NSObjectFlag t) : base (t)
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
		protected internal MDLAnimatedMatrix4x4 (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="time">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("float4x4AtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NMatrix4 GetNMatrix4Value (double time)
		{
			NMatrix4 ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_Double (this.Handle, selFloat4x4AtTime_XHandle, time);
				} else {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret_Double (this.Handle, selFloat4x4AtTime_XHandle, time);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper_Double (&__objc_super__, selFloat4x4AtTime_XHandle, time);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper_stret_Double (&__objc_super__, selFloat4x4AtTime_XHandle, time);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="time">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("double4x4AtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NMatrix4d GetNMatrix4dValue (double time)
		{
			NMatrix4d ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4d_objc_msgSend_Double (this.Handle, selDouble4x4AtTime_XHandle, time);
				} else {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4d_objc_msgSend_stret_Double (this.Handle, selDouble4x4AtTime_XHandle, time);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4d_objc_msgSendSuper_Double (&__objc_super__, selDouble4x4AtTime_XHandle, time);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4d_objc_msgSendSuper_stret_Double (&__objc_super__, selDouble4x4AtTime_XHandle, time);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		[Export ("setFloat4x4:atTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetValue (NMatrix4 value, double time)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NMatrix4_Double (this.Handle, selSetFloat4x4_AtTime_XHandle, value, time);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_NMatrix4_Double (&__objc_super__, selSetFloat4x4_AtTime_XHandle, value, time);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setDouble4x4:atTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetValue (NMatrix4d value, double time)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NMatrix4d_Double (this.Handle, selSetDouble4x4_AtTime_XHandle, value, time);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_NMatrix4d_Double (&__objc_super__, selSetDouble4x4_AtTime_XHandle, value, time);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("getDouble4x4Array:maxCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nuint _GetDouble4x4Array (nint valuesArray, nuint maxCount)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_IntPtr_UIntPtr (this.Handle, selGetDouble4x4Array_MaxCount_XHandle, valuesArray, maxCount);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_IntPtr_UIntPtr (&__objc_super__, selGetDouble4x4Array_MaxCount_XHandle, valuesArray, maxCount);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("getFloat4x4Array:maxCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nuint _GetFloat4x4Array (nint valuesArray, nuint maxCount)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_IntPtr_UIntPtr (this.Handle, selGetFloat4x4Array_MaxCount_XHandle, valuesArray, maxCount);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_IntPtr_UIntPtr (&__objc_super__, selGetFloat4x4Array_MaxCount_XHandle, valuesArray, maxCount);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("resetWithDouble4x4Array:atTimes:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _ResetWithDouble4x4Array (nint valuesArray, nint timesArray, nuint count)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_UIntPtr (this.Handle, selResetWithDouble4x4Array_AtTimes_Count_XHandle, valuesArray, timesArray, count);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UIntPtr (&__objc_super__, selResetWithDouble4x4Array_AtTimes_Count_XHandle, valuesArray, timesArray, count);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("resetWithFloat4x4Array:atTimes:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _ResetWithFloat4x4Array (nint valuesArray, nint timesArray, nuint count)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_UIntPtr (this.Handle, selResetWithFloat4x4Array_AtTimes_Count_XHandle, valuesArray, timesArray, count);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UIntPtr (&__objc_super__, selResetWithFloat4x4Array_AtTimes_Count_XHandle, valuesArray, timesArray, count);
					GC.KeepAlive (this);
				}
			}
		}
	} /* class MDLAnimatedMatrix4x4 */
}
