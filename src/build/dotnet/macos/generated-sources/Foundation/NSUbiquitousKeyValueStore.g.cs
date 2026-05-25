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
	[Register("NSUbiquitousKeyValueStore", true)]
	public unsafe partial class NSUbiquitousKeyValueStore : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selArrayForKey_X = "arrayForKey:";
		static readonly NativeHandle selArrayForKey_XHandle = Selector.GetHandle ("arrayForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoolForKey_X = "boolForKey:";
		static readonly NativeHandle selBoolForKey_XHandle = Selector.GetHandle ("boolForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataForKey_X = "dataForKey:";
		static readonly NativeHandle selDataForKey_XHandle = Selector.GetHandle ("dataForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultStoreX = "defaultStore";
		static readonly NativeHandle selDefaultStoreXHandle = Selector.GetHandle ("defaultStore");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDictionaryForKey_X = "dictionaryForKey:";
		static readonly NativeHandle selDictionaryForKey_XHandle = Selector.GetHandle ("dictionaryForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDictionaryRepresentationX = "dictionaryRepresentation";
		static readonly NativeHandle selDictionaryRepresentationXHandle = Selector.GetHandle ("dictionaryRepresentation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDoubleForKey_X = "doubleForKey:";
		static readonly NativeHandle selDoubleForKey_XHandle = Selector.GetHandle ("doubleForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLongLongForKey_X = "longLongForKey:";
		static readonly NativeHandle selLongLongForKey_XHandle = Selector.GetHandle ("longLongForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectForKey_X = "objectForKey:";
		static readonly NativeHandle selObjectForKey_XHandle = Selector.GetHandle ("objectForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveObjectForKey_X = "removeObjectForKey:";
		static readonly NativeHandle selRemoveObjectForKey_XHandle = Selector.GetHandle ("removeObjectForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetArray_ForKey_X = "setArray:forKey:";
		static readonly NativeHandle selSetArray_ForKey_XHandle = Selector.GetHandle ("setArray:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBool_ForKey_X = "setBool:forKey:";
		static readonly NativeHandle selSetBool_ForKey_XHandle = Selector.GetHandle ("setBool:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetData_ForKey_X = "setData:forKey:";
		static readonly NativeHandle selSetData_ForKey_XHandle = Selector.GetHandle ("setData:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDictionary_ForKey_X = "setDictionary:forKey:";
		static readonly NativeHandle selSetDictionary_ForKey_XHandle = Selector.GetHandle ("setDictionary:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDouble_ForKey_X = "setDouble:forKey:";
		static readonly NativeHandle selSetDouble_ForKey_XHandle = Selector.GetHandle ("setDouble:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLongLong_ForKey_X = "setLongLong:forKey:";
		static readonly NativeHandle selSetLongLong_ForKey_XHandle = Selector.GetHandle ("setLongLong:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetObject_ForKey_X = "setObject:forKey:";
		static readonly NativeHandle selSetObject_ForKey_XHandle = Selector.GetHandle ("setObject:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetString_ForKey_X = "setString:forKey:";
		static readonly NativeHandle selSetString_ForKey_XHandle = Selector.GetHandle ("setString:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringForKey_X = "stringForKey:";
		static readonly NativeHandle selStringForKey_XHandle = Selector.GetHandle ("stringForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSynchronizeX = "synchronize";
		static readonly NativeHandle selSynchronizeXHandle = Selector.GetHandle ("synchronize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSUbiquitousKeyValueStore");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSUbiquitousKeyValueStore" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSUbiquitousKeyValueStore () : base (NSObjectFlag.Empty)
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
		protected NSUbiquitousKeyValueStore (NSObjectFlag t) : base (t)
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
		protected internal NSUbiquitousKeyValueStore (NativeHandle handle) : base (handle)
		{
		}

		[Export ("arrayForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[]? GetArray (string aKey)
		{
			if (aKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aKey));
			var nsaKey = CFString.CreateNative (aKey);
			NSObject[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selArrayForKey_XHandle, nsaKey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selArrayForKey_XHandle, nsaKey), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsaKey);
			return ret!;
		}
		[Export ("boolForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GetBool (string aKey)
		{
			if (aKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aKey));
			var nsaKey = CFString.CreateNative (aKey);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selBoolForKey_XHandle, nsaKey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selBoolForKey_XHandle, nsaKey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsaKey);
			return ret != 0;
		}
		[Export ("dataForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? GetData (string aKey)
		{
			if (aKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aKey));
			var nsaKey = CFString.CreateNative (aKey);
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDataForKey_XHandle, nsaKey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDataForKey_XHandle, nsaKey), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsaKey);
			return ret!;
		}
		[Export ("dictionaryForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? GetDictionary (string aKey)
		{
			if (aKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aKey));
			var nsaKey = CFString.CreateNative (aKey);
			NSDictionary? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDictionaryForKey_XHandle, nsaKey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDictionaryForKey_XHandle, nsaKey), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsaKey);
			return ret!;
		}
		[Export ("doubleForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double GetDouble (string aKey)
		{
			if (aKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aKey));
			var nsaKey = CFString.CreateNative (aKey);
			double ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend_NativeHandle (this.Handle, selDoubleForKey_XHandle, nsaKey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper_NativeHandle (&__objc_super__, selDoubleForKey_XHandle, nsaKey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsaKey);
			return ret!;
		}
		[Export ("longLongForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual long GetLong (string aKey)
		{
			if (aKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aKey));
			var nsaKey = CFString.CreateNative (aKey);
			long ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.Int64_objc_msgSend_NativeHandle (this.Handle, selLongLongForKey_XHandle, nsaKey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper_NativeHandle (&__objc_super__, selLongLongForKey_XHandle, nsaKey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsaKey);
			return ret!;
		}
		[Export ("stringForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetString (string aKey)
		{
			if (aKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aKey));
			var nsaKey = CFString.CreateNative (aKey);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selStringForKey_XHandle, nsaKey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selStringForKey_XHandle, nsaKey), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsaKey);
			return ret!;
		}
		[Export ("objectForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NSObject? ObjectForKey (string aKey)
		{
			if (aKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aKey));
			var nsaKey = CFString.CreateNative (aKey);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selObjectForKey_XHandle, nsaKey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selObjectForKey_XHandle, nsaKey), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsaKey);
			return ret!;
		}
		[Export ("removeObjectForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Remove (string aKey)
		{
			if (aKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aKey));
			var nsaKey = CFString.CreateNative (aKey);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveObjectForKey_XHandle, nsaKey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveObjectForKey_XHandle, nsaKey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsaKey);
		}
		[Export ("setObject:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void SetObjectForKey (NSObject? anObject, string aKey)
		{
			var anObject__handle__ = anObject.GetHandle ();
			if (aKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aKey));
			var nsaKey = CFString.CreateNative (aKey);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetObject_ForKey_XHandle, anObject__handle__, nsaKey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetObject_ForKey_XHandle, anObject__handle__, nsaKey);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anObject);
			CFString.ReleaseNative (nsaKey);
		}
		[Export ("synchronize")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Synchronize ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSynchronizeXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selSynchronizeXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("dictionaryRepresentation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary ToDictionary ()
		{
			NSDictionary ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDictionaryRepresentationXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDictionaryRepresentationXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("setArray:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _SetArray (NSObject[]? array, string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			using var nsa_array = array is null ? null : NSArray.FromNSObjects (array);
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetArray_ForKey_XHandle, nsa_array.GetHandle (), nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetArray_ForKey_XHandle, nsa_array.GetHandle (), nskey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
		}
		[Export ("setBool:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _SetBool (bool value, string aKey)
		{
			if (aKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aKey));
			var nsaKey = CFString.CreateNative (aKey);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_NativeHandle (this.Handle, selSetBool_ForKey_XHandle, value ? (byte) 1 : (byte) 0, nsaKey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_NativeHandle (&__objc_super__, selSetBool_ForKey_XHandle, value ? (byte) 1 : (byte) 0, nsaKey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsaKey);
		}
		[Export ("setData:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _SetData (NSData? data, string key)
		{
			var data__handle__ = data.GetHandle ();
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetData_ForKey_XHandle, data__handle__, nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetData_ForKey_XHandle, data__handle__, nskey);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			CFString.ReleaseNative (nskey);
		}
		[Export ("setDictionary:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _SetDictionary (NSDictionary? aDictionary, string aKey)
		{
			var aDictionary__handle__ = aDictionary.GetHandle ();
			if (aKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aKey));
			var nsaKey = CFString.CreateNative (aKey);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetDictionary_ForKey_XHandle, aDictionary__handle__, nsaKey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetDictionary_ForKey_XHandle, aDictionary__handle__, nsaKey);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aDictionary);
			CFString.ReleaseNative (nsaKey);
		}
		[Export ("setDouble:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _SetDouble (double value, string aKey)
		{
			if (aKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aKey));
			var nsaKey = CFString.CreateNative (aKey);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_Double_NativeHandle (this.Handle, selSetDouble_ForKey_XHandle, value, nsaKey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double_NativeHandle (&__objc_super__, selSetDouble_ForKey_XHandle, value, nsaKey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsaKey);
		}
		[Export ("setLongLong:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _SetLong (long value, string aKey)
		{
			if (aKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aKey));
			var nsaKey = CFString.CreateNative (aKey);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_Int64_NativeHandle (this.Handle, selSetLongLong_ForKey_XHandle, value, nsaKey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Int64_NativeHandle (&__objc_super__, selSetLongLong_ForKey_XHandle, value, nsaKey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsaKey);
		}
		[Export ("setString:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void _SetString (string? aString, string aKey)
		{
			if (aKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aKey));
			var nsaString = CFString.CreateNative (aString);
			var nsaKey = CFString.CreateNative (aKey);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetString_ForKey_XHandle, nsaString, nsaKey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetString_ForKey_XHandle, nsaString, nsaKey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsaString);
			CFString.ReleaseNative (nsaKey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUbiquitousKeyValueStore DefaultStore {
			[Export ("defaultStore")]
			get {
				NSUbiquitousKeyValueStore? ret;
				ret =  Runtime.GetNSObject<NSUbiquitousKeyValueStore> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selDefaultStoreXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChangeReasonKey;
		/// <summary>Represents the value associated with the constant NSUbiquitousKeyValueStoreChangeReasonKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSUbiquitousKeyValueStoreChangeReasonKey",  "Foundation")]
		public static NSString ChangeReasonKey {
			get {
				if (_ChangeReasonKey is null)
					_ChangeReasonKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSUbiquitousKeyValueStoreChangeReasonKey")!;
				return _ChangeReasonKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChangedKeysKey;
		/// <summary>Represents the value associated with the constant NSUbiquitousKeyValueStoreChangedKeysKey</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSUbiquitousKeyValueStoreChangedKeysKey",  "Foundation")]
		public static NSString ChangedKeysKey {
			get {
				if (_ChangedKeysKey is null)
					_ChangedKeysKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSUbiquitousKeyValueStoreChangedKeysKey")!;
				return _ChangedKeysKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidChangeExternallyNotification;
		/// <summary>Notification constant for DidChangeExternally</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidChangeExternally(NSObject,EventHandler{NSUbiquitousKeyValueStoreChangeEventArgs})" />
		///     or <see cref="Notifications.ObserveDidChangeExternally(EventHandler{NSUbiquitousKeyValueStoreChangeEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = NSUbiquitousKeyValueStore.Notifications.ObserveDidChangeExternally ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, NSUbiquitousKeyValueStore.NSUbiquitousKeyValueStoreChangeEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSUbiquitousKeyValueStore.Notifications.ObserveDidChangeExternally (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     NSUbiquitousKeyValueStore.DidChangeExternallyNotification, (notification) => { Console.WriteLine ("Received the notification DidChangeExternally", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidChangeExternally", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSUbiquitousKeyValueStore.DidChangeExternallyNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSUbiquitousKeyValueStoreDidChangeExternallyNotification",  "Foundation")]
		[Advice ("Use NSUbiquitousKeyValueStore.Notifications.ObserveDidChangeExternally helper method instead.")]
		public static NSString DidChangeExternallyNotification {
			get {
				if (_DidChangeExternallyNotification is null)
					_DidChangeExternallyNotification = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSUbiquitousKeyValueStoreDidChangeExternallyNotification")!;
				return _DidChangeExternallyNotification;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::Foundation.NSUbiquitousKeyValueStore" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::Foundation.NSUbiquitousKeyValueStore.DidChangeExternallyNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Foundation.NSUbiquitousKeyValueStore.DidChangeExternallyNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSUbiquitousKeyValueStore.Notifications.ObserveDidChangeExternally ((notification) => {
			///   Console.WriteLine ("Observed DidChangeExternallyNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChangeExternally (EventHandler<Foundation.NSUbiquitousKeyValueStoreChangeEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeExternallyNotification, notification => handler (null, new Foundation.NSUbiquitousKeyValueStoreChangeEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::Foundation.NSUbiquitousKeyValueStore.DidChangeExternallyNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Foundation.NSUbiquitousKeyValueStore.DidChangeExternallyNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSUbiquitousKeyValueStore.Notifications.ObserveDidChangeExternally (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidChangeExternallyNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChangeExternally (NSObject objectToObserve, EventHandler<Foundation.NSUbiquitousKeyValueStoreChangeEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeExternallyNotification, notification => handler (null, new Foundation.NSUbiquitousKeyValueStoreChangeEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSUbiquitousKeyValueStore */
}
