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
using UIKit;
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
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
	[Register("NSObject", true)]
	public unsafe partial class NSObject : INSObjectProtocol {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSObject");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public virtual NativeHandle ClassHandle { get { return class_ptr; } }
		[Export ("addObserver:forKeyPath:options:context:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddObserver (NSObject observer, NSString keyPath, NSKeyValueObservingOptions options, nint context)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			var keyPath__handle__ = keyPath!.GetNonNullHandle (nameof (keyPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("addObserver:forKeyPath:options:context:"), observer__handle__, keyPath__handle__, (UIntPtr) (ulong) options, context);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("addObserver:forKeyPath:options:context:"), observer__handle__, keyPath__handle__, (UIntPtr) (ulong) options, context);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (observer);
			GC.KeepAlive (keyPath);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AddObserver (NSObject observer, string keyPath, NSKeyValueObservingOptions options, nint context)
		{
			AddObserver (observer, (NSString) keyPath, options, context);
		}
		[Export ("automaticallyNotifiesObserversForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AutomaticallyNotifiesObserversForKey (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("automaticallyNotifiesObserversForKey:"), nskey);
			CFString.ReleaseNative (nskey);
			return ret != 0;
		}
		[Export ("awakeFromNib")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Advice (@"Overriding this method requires a call to the overriden method.")]
		[RequiresSuper]
		public virtual void AwakeFromNib ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("awakeFromNib"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("awakeFromNib"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("cancelPreviousPerformRequestsWithTarget:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CancelPreviousPerformRequest (NSObject aTarget)
		{
			var aTarget__handle__ = aTarget!.GetNonNullHandle (nameof (aTarget));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("cancelPreviousPerformRequestsWithTarget:"), aTarget__handle__);
			GC.KeepAlive (aTarget);
		}
		[Export ("cancelPreviousPerformRequestsWithTarget:selector:object:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CancelPreviousPerformRequest (NSObject aTarget, Selector selector, NSObject? argument)
		{
			var aTarget__handle__ = aTarget!.GetNonNullHandle (nameof (aTarget));
			var selector__handle__ = selector!.GetNonNullHandle (nameof (selector));
			var argument__handle__ = argument.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("cancelPreviousPerformRequestsWithTarget:selector:object:"), aTarget__handle__, selector.Handle, argument__handle__);
			GC.KeepAlive (aTarget);
			GC.KeepAlive (selector);
			GC.KeepAlive (argument);
		}
		[Export ("copy")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy ()
		{
			if (!(this is INSCopying)) throw new InvalidOperationException ("Type does not conform to NSCopying");
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("copy")), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("copy")), true)!;
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		[Export ("didChange:valuesAtIndexes:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChange (NSKeyValueChange changeKind, NSIndexSet indexes, NSString forKey)
		{
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			var forKey__handle__ = forKey!.GetNonNullHandle (nameof (forKey));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("didChange:valuesAtIndexes:forKey:"), (UIntPtr) (ulong) changeKind, indexes__handle__, forKey__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("didChange:valuesAtIndexes:forKey:"), (UIntPtr) (ulong) changeKind, indexes__handle__, forKey__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexes);
			GC.KeepAlive (forKey);
		}
		[Export ("didChangeValueForKey:withSetMutation:usingObjects:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChange (NSString forKey, NSKeyValueSetMutationKind mutationKind, NSSet objects)
		{
			var forKey__handle__ = forKey!.GetNonNullHandle (nameof (forKey));
			var objects__handle__ = objects!.GetNonNullHandle (nameof (objects));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("didChangeValueForKey:withSetMutation:usingObjects:"), forKey__handle__, (UIntPtr) (ulong) mutationKind, objects__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("didChangeValueForKey:withSetMutation:usingObjects:"), forKey__handle__, (UIntPtr) (ulong) mutationKind, objects__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (forKey);
			GC.KeepAlive (objects);
		}
		[Export ("didChangeValueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeValue (string forKey)
		{
			if (forKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (forKey));
			var nsforKey = CFString.CreateNative (forKey);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("didChangeValueForKey:"), nsforKey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("didChangeValueForKey:"), nsforKey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsforKey);
		}
		[Export ("doesNotRecognizeSelector:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DoesNotRecognizeSelector (Selector sel)
		{
			var sel__handle__ = sel!.GetNonNullHandle (nameof (sel));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("doesNotRecognizeSelector:"), sel.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("doesNotRecognizeSelector:"), sel.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sel);
		}
		[Export ("dictionaryWithValuesForKeys:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary GetDictionaryOfValuesFromKeys (NSString[] keys)
		{
			if (keys is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keys));
			using var nsa_keys = NSArray.FromNSObjects (keys);
			NSDictionary ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("dictionaryWithValuesForKeys:"), nsa_keys.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("dictionaryWithValuesForKeys:"), nsa_keys.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("keyPathsForValuesAffectingValueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSSet GetKeyPathsForValuesAffecting (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			NSSet? ret;
			ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("keyPathsForValuesAffectingValueForKey:"), key__handle__), false)!;
			GC.KeepAlive (key);
			return ret!;
		}
		[Export ("methodForSelector:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetMethodForSelector (Selector sel)
		{
			var sel__handle__ = sel!.GetNonNullHandle (nameof (sel));
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("methodForSelector:"), sel.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("methodForSelector:"), sel.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sel);
			return ret!;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("hash")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetNativeHash ()
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("hash"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("hash"));
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="anObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("isEqual:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEqual (NSObject? anObject)
		{
			var anObject__handle__ = anObject.GetHandle ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("isEqual:"), anObject__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("isEqual:"), anObject__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (anObject);
			return ret != 0;
		}
		/// <param name="aClass">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("isKindOfClass:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsKindOfClass (Class? aClass)
		{
			var aClass__handle__ = aClass.GetHandle ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("isKindOfClass:"), aClass__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("isKindOfClass:"), aClass__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aClass);
			return ret != 0;
		}
		/// <param name="aClass">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("isMemberOfClass:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsMemberOfClass (Class? aClass)
		{
			var aClass__handle__ = aClass.GetHandle ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("isMemberOfClass:"), aClass__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("isMemberOfClass:"), aClass__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aClass);
			return ret != 0;
		}
		[Export ("mutableCopy")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject MutableCopy ()
		{
			if (!(this is INSMutableCopying)) throw new InvalidOperationException ("Type does not conform to NSMutableCopying");
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("mutableCopy")), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("mutableCopy")), true)!;
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		[Export ("observeValueForKeyPath:ofObject:change:context:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ObserveValue (NSString keyPath, NSObject ofObject, NSDictionary change, nint context)
		{
			var keyPath__handle__ = keyPath!.GetNonNullHandle (nameof (keyPath));
			var ofObject__handle__ = ofObject!.GetNonNullHandle (nameof (ofObject));
			var change__handle__ = change!.GetNonNullHandle (nameof (change));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("observeValueForKeyPath:ofObject:change:context:"), keyPath__handle__, ofObject__handle__, change__handle__, context);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("observeValueForKeyPath:ofObject:change:context:"), keyPath__handle__, ofObject__handle__, change__handle__, context);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (keyPath);
			GC.KeepAlive (ofObject);
			GC.KeepAlive (change);
		}
		[Export ("performSelector:withObject:afterDelay:inModes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformSelector (Selector selector, NSObject? withObject, double afterDelay, NSString[] nsRunLoopModes)
		{
			var selector__handle__ = selector!.GetNonNullHandle (nameof (selector));
			var withObject__handle__ = withObject.GetHandle ();
			if (nsRunLoopModes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (nsRunLoopModes));
			using var nsa_nsRunLoopModes = NSArray.FromNSObjects (nsRunLoopModes);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Double_NativeHandle (this.Handle, Selector.GetHandle ("performSelector:withObject:afterDelay:inModes:"), selector.Handle, withObject__handle__, afterDelay, nsa_nsRunLoopModes.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_Double_NativeHandle (&__objc_super__, Selector.GetHandle ("performSelector:withObject:afterDelay:inModes:"), selector.Handle, withObject__handle__, afterDelay, nsa_nsRunLoopModes.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (selector);
			GC.KeepAlive (withObject);
		}
		[Export ("performSelector:withObject:afterDelay:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformSelector (Selector selector, NSObject? withObject, double delay)
		{
			var selector__handle__ = selector!.GetNonNullHandle (nameof (selector));
			var withObject__handle__ = withObject.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Double (this.Handle, Selector.GetHandle ("performSelector:withObject:afterDelay:"), selector.Handle, withObject__handle__, delay);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_Double (&__objc_super__, Selector.GetHandle ("performSelector:withObject:afterDelay:"), selector.Handle, withObject__handle__, delay);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (selector);
			GC.KeepAlive (withObject);
		}
		[Export ("performSelector:onThread:withObject:waitUntilDone:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformSelector (Selector selector, NSThread onThread, NSObject? withObject, bool waitUntilDone)
		{
			var selector__handle__ = selector!.GetNonNullHandle (nameof (selector));
			var onThread__handle__ = onThread!.GetNonNullHandle (nameof (onThread));
			var withObject__handle__ = withObject.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_bool (this.Handle, Selector.GetHandle ("performSelector:onThread:withObject:waitUntilDone:"), selector.Handle, onThread__handle__, withObject__handle__, waitUntilDone ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_bool (&__objc_super__, Selector.GetHandle ("performSelector:onThread:withObject:waitUntilDone:"), selector.Handle, onThread__handle__, withObject__handle__, waitUntilDone ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (selector);
			GC.KeepAlive (onThread);
			GC.KeepAlive (withObject);
		}
		[Export ("performSelector:onThread:withObject:waitUntilDone:modes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PerformSelector (Selector selector, NSThread onThread, NSObject? withObject, bool waitUntilDone, NSString[]? nsRunLoopModes)
		{
			var selector__handle__ = selector!.GetNonNullHandle (nameof (selector));
			var onThread__handle__ = onThread!.GetNonNullHandle (nameof (onThread));
			var withObject__handle__ = withObject.GetHandle ();
			using var nsa_nsRunLoopModes = nsRunLoopModes is null ? null : NSArray.FromNSObjects (nsRunLoopModes);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_bool_NativeHandle (this.Handle, Selector.GetHandle ("performSelector:onThread:withObject:waitUntilDone:modes:"), selector.Handle, onThread__handle__, withObject__handle__, waitUntilDone ? (byte) 1 : (byte) 0, nsa_nsRunLoopModes.GetHandle ());
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_bool_NativeHandle (&__objc_super__, Selector.GetHandle ("performSelector:onThread:withObject:waitUntilDone:modes:"), selector.Handle, onThread__handle__, withObject__handle__, waitUntilDone ? (byte) 1 : (byte) 0, nsa_nsRunLoopModes.GetHandle ());
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (selector);
			GC.KeepAlive (onThread);
			GC.KeepAlive (withObject);
		}
		/// <param name="aSelector">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("performSelector:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject PerformSelector (Selector aSelector)
		{
			var aSelector__handle__ = aSelector!.GetNonNullHandle (nameof (aSelector));
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("performSelector:"), aSelector.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("performSelector:"), aSelector.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aSelector);
			return ret!;
		}
		/// <param name="aSelector">To be added.</param><param name="anObject">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("performSelector:withObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject PerformSelector (Selector aSelector, NSObject? anObject)
		{
			var aSelector__handle__ = aSelector!.GetNonNullHandle (nameof (aSelector));
			var anObject__handle__ = anObject.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("performSelector:withObject:"), aSelector.Handle, anObject__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("performSelector:withObject:"), aSelector.Handle, anObject__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aSelector);
			GC.KeepAlive (anObject);
			return ret!;
		}
		/// <param name="aSelector">To be added.</param><param name="object1">To be added.</param><param name="object2">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("performSelector:withObject:withObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject PerformSelector (Selector aSelector, NSObject? object1, NSObject? object2)
		{
			var aSelector__handle__ = aSelector!.GetNonNullHandle (nameof (aSelector));
			var object1__handle__ = object1.GetHandle ();
			var object2__handle__ = object2.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("performSelector:withObject:withObject:"), aSelector.Handle, object1__handle__, object2__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("performSelector:withObject:withObject:"), aSelector.Handle, object1__handle__, object2__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aSelector);
			GC.KeepAlive (object1);
			GC.KeepAlive (object2);
			return ret!;
		}
		[Export ("prepareForInterfaceBuilder")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrepareForInterfaceBuilder ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("prepareForInterfaceBuilder"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("prepareForInterfaceBuilder"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeObserver:forKeyPath:context:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveObserver (NSObject observer, NSString keyPath, nint context)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			var keyPath__handle__ = keyPath!.GetNonNullHandle (nameof (keyPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("removeObserver:forKeyPath:context:"), observer__handle__, keyPath__handle__, context);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("removeObserver:forKeyPath:context:"), observer__handle__, keyPath__handle__, context);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (observer);
			GC.KeepAlive (keyPath);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RemoveObserver (NSObject observer, string keyPath, nint context)
		{
			RemoveObserver (observer, (NSString) keyPath, context);
		}
		[Export ("removeObserver:forKeyPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveObserver (NSObject observer, NSString keyPath)
		{
			var observer__handle__ = observer!.GetNonNullHandle (nameof (observer));
			var keyPath__handle__ = keyPath!.GetNonNullHandle (nameof (keyPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("removeObserver:forKeyPath:"), observer__handle__, keyPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("removeObserver:forKeyPath:"), observer__handle__, keyPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (observer);
			GC.KeepAlive (keyPath);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RemoveObserver (NSObject observer, string keyPath)
		{
			RemoveObserver (observer, (NSString) keyPath);
		}
		/// <param name="sel">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("respondsToSelector:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RespondsToSelector (Selector? sel)
		{
			var sel__handle__ = sel.GetHandle ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("respondsToSelector:"), sel__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("respondsToSelector:"), sel__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sel);
			return ret != 0;
		}
		[Export ("setNilValueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNilValueForKey (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setNilValueForKey:"), key__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setNilValueForKey:"), key__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
		}
		[Export ("setValue:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetValueForKey (NSObject value, NSString key)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setValue:forKey:"), value__handle__, key__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("setValue:forKey:"), value__handle__, key__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
			GC.KeepAlive (key);
		}
		[Export ("setValue:forKeyPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetValueForKeyPath (NSObject value, NSString keyPath)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			var keyPath__handle__ = keyPath!.GetNonNullHandle (nameof (keyPath));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setValue:forKeyPath:"), value__handle__, keyPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("setValue:forKeyPath:"), value__handle__, keyPath__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
			GC.KeepAlive (keyPath);
		}
		[Export ("setValue:forUndefinedKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetValueForUndefinedKey (NSObject value, NSString undefinedKey)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			var undefinedKey__handle__ = undefinedKey!.GetNonNullHandle (nameof (undefinedKey));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("setValue:forUndefinedKey:"), value__handle__, undefinedKey__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("setValue:forUndefinedKey:"), value__handle__, undefinedKey__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
			GC.KeepAlive (undefinedKey);
		}
		[Export ("setValuesForKeysWithDictionary:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetValuesForKeysWithDictionary (NSDictionary keyedValues)
		{
			var keyedValues__handle__ = keyedValues!.GetNonNullHandle (nameof (keyedValues));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setValuesForKeysWithDictionary:"), keyedValues__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setValuesForKeysWithDictionary:"), keyedValues__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (keyedValues);
		}
		[Export ("valueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ValueForKey (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			IntPtr exception_gchandle = IntPtr.Zero;
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.xamarin_NativeHandle_objc_msgSend_NativeHandle_exception (this.Handle, Selector.GetHandle ("valueForKey:"), key__handle__, &exception_gchandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.xamarin_NativeHandle_objc_msgSendSuper_NativeHandle_exception (&__objc_super__, Selector.GetHandle ("valueForKey:"), key__handle__, &exception_gchandle), false)!;
					GC.KeepAlive (this);
				}
			}
			Runtime.ThrowException (exception_gchandle);
			GC.KeepAlive (key);
			return ret!;
		}
		[Export ("valueForKeyPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ValueForKeyPath (NSString keyPath)
		{
			var keyPath__handle__ = keyPath!.GetNonNullHandle (nameof (keyPath));
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("valueForKeyPath:"), keyPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("valueForKeyPath:"), keyPath__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (keyPath);
			return ret!;
		}
		[Export ("valueForUndefinedKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ValueForUndefinedKey (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("valueForUndefinedKey:"), key__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("valueForUndefinedKey:"), key__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
			return ret!;
		}
		[Export ("willChange:valuesAtIndexes:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillChange (NSKeyValueChange changeKind, NSIndexSet indexes, NSString forKey)
		{
			var indexes__handle__ = indexes!.GetNonNullHandle (nameof (indexes));
			var forKey__handle__ = forKey!.GetNonNullHandle (nameof (forKey));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("willChange:valuesAtIndexes:forKey:"), (UIntPtr) (ulong) changeKind, indexes__handle__, forKey__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("willChange:valuesAtIndexes:forKey:"), (UIntPtr) (ulong) changeKind, indexes__handle__, forKey__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexes);
			GC.KeepAlive (forKey);
		}
		[Export ("willChangeValueForKey:withSetMutation:usingObjects:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillChange (NSString forKey, NSKeyValueSetMutationKind mutationKind, NSSet objects)
		{
			var forKey__handle__ = forKey!.GetNonNullHandle (nameof (forKey));
			var objects__handle__ = objects!.GetNonNullHandle (nameof (objects));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("willChangeValueForKey:withSetMutation:usingObjects:"), forKey__handle__, (UIntPtr) (ulong) mutationKind, objects__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("willChangeValueForKey:withSetMutation:usingObjects:"), forKey__handle__, (UIntPtr) (ulong) mutationKind, objects__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (forKey);
			GC.KeepAlive (objects);
		}
		[Export ("willChangeValueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillChangeValue (string forKey)
		{
			if (forKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (forKey));
			var nsforKey = CFString.CreateNative (forKey);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("willChangeValueForKey:"), nsforKey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("willChangeValueForKey:"), nsforKey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsforKey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual NSAttributedString[] AccessibilityAttributedUserInputLabels {
			[Export ("accessibilityAttributedUserInputLabels", ArgumentSemantic.Copy)]
			get {
				NSAttributedString[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSAttributedString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityAttributedUserInputLabels")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSAttributedString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityAttributedUserInputLabels")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAccessibilityAttributedUserInputLabels:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityAttributedUserInputLabels:"), nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAccessibilityAttributedUserInputLabels:"), nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool AccessibilityRespondsToUserInteraction {
			[Export ("accessibilityRespondsToUserInteraction")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityRespondsToUserInteraction"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityRespondsToUserInteraction"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAccessibilityRespondsToUserInteraction:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilityRespondsToUserInteraction:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAccessibilityRespondsToUserInteraction:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string? AccessibilityTextualContext {
			[Export ("accessibilityTextualContext", ArgumentSemantic.Retain)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityTextualContext")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityTextualContext")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityTextualContext:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityTextualContext:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAccessibilityTextualContext:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string[] AccessibilityUserInputLabels {
			[Export ("accessibilityUserInputLabels", ArgumentSemantic.Retain)]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityUserInputLabels")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("accessibilityUserInputLabels")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAccessibilityUserInputLabels:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromStrings (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setAccessibilityUserInputLabels:"), nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setAccessibilityUserInputLabels:"), nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public virtual Class Class {
			[Export ("class")]
			get {
				Class ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("class")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("class")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DebugDescription {
			[Export ("debugDescription")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("debugDescription")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("debugDescription")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Description {
			[Export ("description")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("description")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("description")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public virtual bool IsProxy {
			[Export ("isProxy")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isProxy"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isProxy"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint RetainCount {
			[Export ("retainCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("retainCount"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("retainCount"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public virtual NSObject Self {
			[Export ("self")]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("self")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("self")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public virtual Class Superclass {
			[Export ("superclass")]
			get {
				Class ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("superclass")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("superclass")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public virtual NSZone Zone {
			[Export ("zone")]
			get {
				NSZone ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::Foundation.NSZone> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("zone")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::Foundation.NSZone> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("zone")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChangeIndexesKey;
		/// <summary>Represents the value associated with the constant 'NSKeyValueChangeIndexesKey'.</summary>
		[Field ("NSKeyValueChangeIndexesKey",  "Foundation")]
		public static NSString ChangeIndexesKey {
			get {
				if (_ChangeIndexesKey is null)
					_ChangeIndexesKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSKeyValueChangeIndexesKey")!;
				return _ChangeIndexesKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChangeKindKey;
		/// <summary>Represents the value associated with the constant 'NSKeyValueChangeKindKey'.</summary>
		[Field ("NSKeyValueChangeKindKey",  "Foundation")]
		public static NSString ChangeKindKey {
			get {
				if (_ChangeKindKey is null)
					_ChangeKindKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSKeyValueChangeKindKey")!;
				return _ChangeKindKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChangeNewKey;
		/// <summary>Represents the value associated with the constant 'NSKeyValueChangeNewKey'.</summary>
		[Field ("NSKeyValueChangeNewKey",  "Foundation")]
		public static NSString ChangeNewKey {
			get {
				if (_ChangeNewKey is null)
					_ChangeNewKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSKeyValueChangeNewKey")!;
				return _ChangeNewKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChangeNotificationIsPriorKey;
		/// <summary>Represents the value associated with the constant 'NSKeyValueChangeNotificationIsPriorKey'.</summary>
		[Field ("NSKeyValueChangeNotificationIsPriorKey",  "Foundation")]
		public static NSString ChangeNotificationIsPriorKey {
			get {
				if (_ChangeNotificationIsPriorKey is null)
					_ChangeNotificationIsPriorKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSKeyValueChangeNotificationIsPriorKey")!;
				return _ChangeNotificationIsPriorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ChangeOldKey;
		/// <summary>Represents the value associated with the constant 'NSKeyValueChangeOldKey'.</summary>
		[Field ("NSKeyValueChangeOldKey",  "Foundation")]
		public static NSString ChangeOldKey {
			get {
				if (_ChangeOldKey is null)
					_ChangeOldKey = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSKeyValueChangeOldKey")!;
				return _ChangeOldKey;
			}
		}
	} /* class NSObject */
}
