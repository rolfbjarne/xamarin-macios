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
	[Register("MDLAnimatedQuaternionArray", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MDLAnimatedQuaternionArray : MDLAnimatedValue {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selElementCountX = "elementCount";
		static readonly NativeHandle selElementCountXHandle = Selector.GetHandle ("elementCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetDoubleQuaternionArray_MaxCount_X = "getDoubleQuaternionArray:maxCount:";
		static readonly NativeHandle selGetDoubleQuaternionArray_MaxCount_XHandle = Selector.GetHandle ("getDoubleQuaternionArray:maxCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetDoubleQuaternionArray_MaxCount_AtTime_X = "getDoubleQuaternionArray:maxCount:atTime:";
		static readonly NativeHandle selGetDoubleQuaternionArray_MaxCount_AtTime_XHandle = Selector.GetHandle ("getDoubleQuaternionArray:maxCount:atTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetFloatQuaternionArray_MaxCount_X = "getFloatQuaternionArray:maxCount:";
		static readonly NativeHandle selGetFloatQuaternionArray_MaxCount_XHandle = Selector.GetHandle ("getFloatQuaternionArray:maxCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetFloatQuaternionArray_MaxCount_AtTime_X = "getFloatQuaternionArray:maxCount:atTime:";
		static readonly NativeHandle selGetFloatQuaternionArray_MaxCount_AtTime_XHandle = Selector.GetHandle ("getFloatQuaternionArray:maxCount:atTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithElementCount_X = "initWithElementCount:";
		static readonly NativeHandle selInitWithElementCount_XHandle = Selector.GetHandle ("initWithElementCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResetWithDoubleQuaternionArray_Count_AtTimes_Count_X = "resetWithDoubleQuaternionArray:count:atTimes:count:";
		static readonly NativeHandle selResetWithDoubleQuaternionArray_Count_AtTimes_Count_XHandle = Selector.GetHandle ("resetWithDoubleQuaternionArray:count:atTimes:count:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResetWithFloatQuaternionArray_Count_AtTimes_Count_X = "resetWithFloatQuaternionArray:count:atTimes:count:";
		static readonly NativeHandle selResetWithFloatQuaternionArray_Count_AtTimes_Count_XHandle = Selector.GetHandle ("resetWithFloatQuaternionArray:count:atTimes:count:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDoubleQuaternionArray_Count_AtTime_X = "setDoubleQuaternionArray:count:atTime:";
		static readonly NativeHandle selSetDoubleQuaternionArray_Count_AtTime_XHandle = Selector.GetHandle ("setDoubleQuaternionArray:count:atTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFloatQuaternionArray_Count_AtTime_X = "setFloatQuaternionArray:count:atTime:";
		static readonly NativeHandle selSetFloatQuaternionArray_Count_AtTime_XHandle = Selector.GetHandle ("setFloatQuaternionArray:count:atTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MDLAnimatedQuaternionArray");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MDLAnimatedQuaternionArray" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MDLAnimatedQuaternionArray () : base (NSObjectFlag.Empty)
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
		protected MDLAnimatedQuaternionArray (NSObjectFlag t) : base (t)
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
		protected internal MDLAnimatedQuaternionArray (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithElementCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLAnimatedQuaternionArray (nuint arrayElementCount)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selInitWithElementCount_XHandle, arrayElementCount), "initWithElementCount:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selInitWithElementCount_XHandle, arrayElementCount), "initWithElementCount:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("getDoubleQuaternionArray:maxCount:atTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nuint _GetDoubleQuaternionArray (nint array, nuint maxCount, double time)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_IntPtr_UIntPtr_Double (this.Handle, selGetDoubleQuaternionArray_MaxCount_AtTime_XHandle, array, maxCount, time);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_IntPtr_UIntPtr_Double (&__objc_super__, selGetDoubleQuaternionArray_MaxCount_AtTime_XHandle, array, maxCount, time);
					GC.KeepAlive (this);
				}
			}
			return ret;
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
		[Export ("getFloatQuaternionArray:maxCount:atTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nuint _GetFloatQuaternionArray (nint array, nuint maxCount, double time)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_IntPtr_UIntPtr_Double (this.Handle, selGetFloatQuaternionArray_MaxCount_AtTime_XHandle, array, maxCount, time);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_IntPtr_UIntPtr_Double (&__objc_super__, selGetFloatQuaternionArray_MaxCount_AtTime_XHandle, array, maxCount, time);
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
		[Export ("resetWithDoubleQuaternionArray:count:atTimes:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _ResetWithDoubleQuaternionArray (nint valuesArray, nuint valuesCount, nint timesArray, nuint timesCount)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_IntPtr_UIntPtr (this.Handle, selResetWithDoubleQuaternionArray_Count_AtTimes_Count_XHandle, valuesArray, valuesCount, timesArray, timesCount);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UIntPtr_IntPtr_UIntPtr (&__objc_super__, selResetWithDoubleQuaternionArray_Count_AtTimes_Count_XHandle, valuesArray, valuesCount, timesArray, timesCount);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("resetWithFloatQuaternionArray:count:atTimes:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _ResetWithFloatQuaternionArray (nint valuesArray, nuint valuesCount, nint timesArray, nuint timesCount)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_IntPtr_UIntPtr (this.Handle, selResetWithFloatQuaternionArray_Count_AtTimes_Count_XHandle, valuesArray, valuesCount, timesArray, timesCount);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UIntPtr_IntPtr_UIntPtr (&__objc_super__, selResetWithFloatQuaternionArray_Count_AtTimes_Count_XHandle, valuesArray, valuesCount, timesArray, timesCount);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setDoubleQuaternionArray:count:atTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _SetDoubleQuaternionArray (nint array, nuint count, double time)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_Double (this.Handle, selSetDoubleQuaternionArray_Count_AtTime_XHandle, array, count, time);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UIntPtr_Double (&__objc_super__, selSetDoubleQuaternionArray_Count_AtTime_XHandle, array, count, time);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setFloatQuaternionArray:count:atTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _SetFloatQuaternionArray (nint array, nuint count, double time)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_UIntPtr_Double (this.Handle, selSetFloatQuaternionArray_Count_AtTime_XHandle, array, count, time);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_UIntPtr_Double (&__objc_super__, selSetFloatQuaternionArray_Count_AtTime_XHandle, array, count, time);
					GC.KeepAlive (this);
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint ElementCount {
			[Export ("elementCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selElementCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selElementCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class MDLAnimatedQuaternionArray */
}
