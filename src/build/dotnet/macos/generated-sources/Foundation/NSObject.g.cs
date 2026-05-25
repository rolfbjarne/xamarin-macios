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
	[Register("NSObject", true)]
	public unsafe partial class NSObject : INSObjectProtocol {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddObserver_ForKeyPath_Options_Context_X = "addObserver:forKeyPath:options:context:";
		static readonly NativeHandle selAddObserver_ForKeyPath_Options_Context_XHandle = Selector.GetHandle ("addObserver:forKeyPath:options:context:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutomaticallyNotifiesObserversForKey_X = "automaticallyNotifiesObserversForKey:";
		static readonly NativeHandle selAutomaticallyNotifiesObserversForKey_XHandle = Selector.GetHandle ("automaticallyNotifiesObserversForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAutoreleaseX = "autorelease";
		static readonly NativeHandle selAutoreleaseXHandle = Selector.GetHandle ("autorelease");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAwakeFromNibX = "awakeFromNib";
		static readonly NativeHandle selAwakeFromNibXHandle = Selector.GetHandle ("awakeFromNib");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBind_ToObject_WithKeyPath_Options_X = "bind:toObject:withKeyPath:options:";
		static readonly NativeHandle selBind_ToObject_WithKeyPath_Options_XHandle = Selector.GetHandle ("bind:toObject:withKeyPath:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelPreviousPerformRequestsWithTarget_X = "cancelPreviousPerformRequestsWithTarget:";
		static readonly NativeHandle selCancelPreviousPerformRequestsWithTarget_XHandle = Selector.GetHandle ("cancelPreviousPerformRequestsWithTarget:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCancelPreviousPerformRequestsWithTarget_Selector_Object_X = "cancelPreviousPerformRequestsWithTarget:selector:object:";
		static readonly NativeHandle selCancelPreviousPerformRequestsWithTarget_Selector_Object_XHandle = Selector.GetHandle ("cancelPreviousPerformRequestsWithTarget:selector:object:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClassX = "class";
		static readonly NativeHandle selClassXHandle = Selector.GetHandle ("class");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommitEditingX = "commitEditing";
		static readonly NativeHandle selCommitEditingXHandle = Selector.GetHandle ("commitEditing");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCommitEditingWithDelegate_DidCommitSelector_ContextInfo_X = "commitEditingWithDelegate:didCommitSelector:contextInfo:";
		static readonly NativeHandle selCommitEditingWithDelegate_DidCommitSelector_ContextInfo_XHandle = Selector.GetHandle ("commitEditingWithDelegate:didCommitSelector:contextInfo:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConformsToProtocol_X = "conformsToProtocol:";
		static readonly NativeHandle selConformsToProtocol_XHandle = Selector.GetHandle ("conformsToProtocol:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyX = "copy";
		static readonly NativeHandle selCopyXHandle = Selector.GetHandle ("copy");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDebugDescriptionX = "debugDescription";
		static readonly NativeHandle selDebugDescriptionXHandle = Selector.GetHandle ("debugDescription");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultPlaceholderForMarker_WithBinding_X = "defaultPlaceholderForMarker:withBinding:";
		static readonly NativeHandle selDefaultPlaceholderForMarker_WithBinding_XHandle = Selector.GetHandle ("defaultPlaceholderForMarker:withBinding:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptionX = "description";
		static readonly NativeHandle selDescriptionXHandle = Selector.GetHandle ("description");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDictionaryWithValuesForKeys_X = "dictionaryWithValuesForKeys:";
		static readonly NativeHandle selDictionaryWithValuesForKeys_XHandle = Selector.GetHandle ("dictionaryWithValuesForKeys:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidChange_ValuesAtIndexes_ForKey_X = "didChange:valuesAtIndexes:forKey:";
		static readonly NativeHandle selDidChange_ValuesAtIndexes_ForKey_XHandle = Selector.GetHandle ("didChange:valuesAtIndexes:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidChangeValueForKey_X = "didChangeValueForKey:";
		static readonly NativeHandle selDidChangeValueForKey_XHandle = Selector.GetHandle ("didChangeValueForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDidChangeValueForKey_WithSetMutation_UsingObjects_X = "didChangeValueForKey:withSetMutation:usingObjects:";
		static readonly NativeHandle selDidChangeValueForKey_WithSetMutation_UsingObjects_XHandle = Selector.GetHandle ("didChangeValueForKey:withSetMutation:usingObjects:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDoesNotRecognizeSelector_X = "doesNotRecognizeSelector:";
		static readonly NativeHandle selDoesNotRecognizeSelector_XHandle = Selector.GetHandle ("doesNotRecognizeSelector:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExposedBindingsX = "exposedBindings";
		static readonly NativeHandle selExposedBindingsXHandle = Selector.GetHandle ("exposedBindings");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHashX = "hash";
		static readonly NativeHandle selHashXHandle = Selector.GetHandle ("hash");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInfoForBinding_X = "infoForBinding:";
		static readonly NativeHandle selInfoForBinding_XHandle = Selector.GetHandle ("infoForBinding:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEqual_X = "isEqual:";
		static readonly NativeHandle selIsEqual_XHandle = Selector.GetHandle ("isEqual:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsKindOfClass_X = "isKindOfClass:";
		static readonly NativeHandle selIsKindOfClass_XHandle = Selector.GetHandle ("isKindOfClass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsMemberOfClass_X = "isMemberOfClass:";
		static readonly NativeHandle selIsMemberOfClass_XHandle = Selector.GetHandle ("isMemberOfClass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsProxyX = "isProxy";
		static readonly NativeHandle selIsProxyXHandle = Selector.GetHandle ("isProxy");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeyPathsForValuesAffectingValueForKey_X = "keyPathsForValuesAffectingValueForKey:";
		static readonly NativeHandle selKeyPathsForValuesAffectingValueForKey_XHandle = Selector.GetHandle ("keyPathsForValuesAffectingValueForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMethodForSelector_X = "methodForSelector:";
		static readonly NativeHandle selMethodForSelector_XHandle = Selector.GetHandle ("methodForSelector:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMutableCopyX = "mutableCopy";
		static readonly NativeHandle selMutableCopyXHandle = Selector.GetHandle ("mutableCopy");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectDidEndEditing_X = "objectDidEndEditing:";
		static readonly NativeHandle selObjectDidEndEditing_XHandle = Selector.GetHandle ("objectDidEndEditing:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObserveValueForKeyPath_OfObject_Change_Context_X = "observeValueForKeyPath:ofObject:change:context:";
		static readonly NativeHandle selObserveValueForKeyPath_OfObject_Change_Context_XHandle = Selector.GetHandle ("observeValueForKeyPath:ofObject:change:context:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOptionDescriptionsForBinding_X = "optionDescriptionsForBinding:";
		static readonly NativeHandle selOptionDescriptionsForBinding_XHandle = Selector.GetHandle ("optionDescriptionsForBinding:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformSelector_X = "performSelector:";
		static readonly NativeHandle selPerformSelector_XHandle = Selector.GetHandle ("performSelector:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformSelector_OnThread_WithObject_WaitUntilDone_X = "performSelector:onThread:withObject:waitUntilDone:";
		static readonly NativeHandle selPerformSelector_OnThread_WithObject_WaitUntilDone_XHandle = Selector.GetHandle ("performSelector:onThread:withObject:waitUntilDone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformSelector_OnThread_WithObject_WaitUntilDone_Modes_X = "performSelector:onThread:withObject:waitUntilDone:modes:";
		static readonly NativeHandle selPerformSelector_OnThread_WithObject_WaitUntilDone_Modes_XHandle = Selector.GetHandle ("performSelector:onThread:withObject:waitUntilDone:modes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformSelector_WithObject_X = "performSelector:withObject:";
		static readonly NativeHandle selPerformSelector_WithObject_XHandle = Selector.GetHandle ("performSelector:withObject:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformSelector_WithObject_AfterDelay_X = "performSelector:withObject:afterDelay:";
		static readonly NativeHandle selPerformSelector_WithObject_AfterDelay_XHandle = Selector.GetHandle ("performSelector:withObject:afterDelay:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformSelector_WithObject_AfterDelay_InModes_X = "performSelector:withObject:afterDelay:inModes:";
		static readonly NativeHandle selPerformSelector_WithObject_AfterDelay_InModes_XHandle = Selector.GetHandle ("performSelector:withObject:afterDelay:inModes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPerformSelector_WithObject_WithObject_X = "performSelector:withObject:withObject:";
		static readonly NativeHandle selPerformSelector_WithObject_WithObject_XHandle = Selector.GetHandle ("performSelector:withObject:withObject:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrepareForInterfaceBuilderX = "prepareForInterfaceBuilder";
		static readonly NativeHandle selPrepareForInterfaceBuilderXHandle = Selector.GetHandle ("prepareForInterfaceBuilder");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReleaseX = "release";
		static readonly NativeHandle selReleaseXHandle = Selector.GetHandle ("release");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveObserver_ForKeyPath_X = "removeObserver:forKeyPath:";
		static readonly NativeHandle selRemoveObserver_ForKeyPath_XHandle = Selector.GetHandle ("removeObserver:forKeyPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveObserver_ForKeyPath_Context_X = "removeObserver:forKeyPath:context:";
		static readonly NativeHandle selRemoveObserver_ForKeyPath_Context_XHandle = Selector.GetHandle ("removeObserver:forKeyPath:context:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRespondsToSelector_X = "respondsToSelector:";
		static readonly NativeHandle selRespondsToSelector_XHandle = Selector.GetHandle ("respondsToSelector:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRetainX = "retain";
		static readonly NativeHandle selRetainXHandle = Selector.GetHandle ("retain");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRetainCountX = "retainCount";
		static readonly NativeHandle selRetainCountXHandle = Selector.GetHandle ("retainCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelfX = "self";
		static readonly NativeHandle selSelfXHandle = Selector.GetHandle ("self");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDefaultPlaceholder_ForMarker_WithBinding_X = "setDefaultPlaceholder:forMarker:withBinding:";
		static readonly NativeHandle selSetDefaultPlaceholder_ForMarker_WithBinding_XHandle = Selector.GetHandle ("setDefaultPlaceholder:forMarker:withBinding:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNilValueForKey_X = "setNilValueForKey:";
		static readonly NativeHandle selSetNilValueForKey_XHandle = Selector.GetHandle ("setNilValueForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetValue_ForKey_X = "setValue:forKey:";
		static readonly NativeHandle selSetValue_ForKey_XHandle = Selector.GetHandle ("setValue:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetValue_ForKeyPath_X = "setValue:forKeyPath:";
		static readonly NativeHandle selSetValue_ForKeyPath_XHandle = Selector.GetHandle ("setValue:forKeyPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetValue_ForUndefinedKey_X = "setValue:forUndefinedKey:";
		static readonly NativeHandle selSetValue_ForUndefinedKey_XHandle = Selector.GetHandle ("setValue:forUndefinedKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetValuesForKeysWithDictionary_X = "setValuesForKeysWithDictionary:";
		static readonly NativeHandle selSetValuesForKeysWithDictionary_XHandle = Selector.GetHandle ("setValuesForKeysWithDictionary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSuperclassX = "superclass";
		static readonly NativeHandle selSuperclassXHandle = Selector.GetHandle ("superclass");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnbind_X = "unbind:";
		static readonly NativeHandle selUnbind_XHandle = Selector.GetHandle ("unbind:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueClassForBinding_X = "valueClassForBinding:";
		static readonly NativeHandle selValueClassForBinding_XHandle = Selector.GetHandle ("valueClassForBinding:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueForKey_X = "valueForKey:";
		static readonly NativeHandle selValueForKey_XHandle = Selector.GetHandle ("valueForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueForKeyPath_X = "valueForKeyPath:";
		static readonly NativeHandle selValueForKeyPath_XHandle = Selector.GetHandle ("valueForKeyPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueForUndefinedKey_X = "valueForUndefinedKey:";
		static readonly NativeHandle selValueForUndefinedKey_XHandle = Selector.GetHandle ("valueForUndefinedKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWillChange_ValuesAtIndexes_ForKey_X = "willChange:valuesAtIndexes:forKey:";
		static readonly NativeHandle selWillChange_ValuesAtIndexes_ForKey_XHandle = Selector.GetHandle ("willChange:valuesAtIndexes:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWillChangeValueForKey_X = "willChangeValueForKey:";
		static readonly NativeHandle selWillChangeValueForKey_XHandle = Selector.GetHandle ("willChangeValueForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWillChangeValueForKey_WithSetMutation_UsingObjects_X = "willChangeValueForKey:withSetMutation:usingObjects:";
		static readonly NativeHandle selWillChangeValueForKey_WithSetMutation_UsingObjects_XHandle = Selector.GetHandle ("willChangeValueForKey:withSetMutation:usingObjects:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selZoneX = "zone";
		static readonly NativeHandle selZoneXHandle = Selector.GetHandle ("zone");
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_IntPtr (this.Handle, selAddObserver_ForKeyPath_Options_Context_XHandle, observer__handle__, keyPath__handle__, (UIntPtr) (ulong) options, context);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_IntPtr (&__objc_super__, selAddObserver_ForKeyPath_Options_Context_XHandle, observer__handle__, keyPath__handle__, (UIntPtr) (ulong) options, context);
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
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, selAutomaticallyNotifiesObserversForKey_XHandle, nskey);
			CFString.ReleaseNative (nskey);
			return ret != 0;
		}
		[Export ("awakeFromNib")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AwakeFromNib ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selAwakeFromNibXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selAwakeFromNibXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("bind:toObject:withKeyPath:options:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Bind (NSString binding, NSObject observable, string keyPath, NSDictionary? options)
		{
			var binding__handle__ = binding!.GetNonNullHandle (nameof (binding));
			var observable__handle__ = observable!.GetNonNullHandle (nameof (observable));
			if (keyPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keyPath));
			var options__handle__ = options.GetHandle ();
			var nskeyPath = CFString.CreateNative (keyPath);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selBind_ToObject_WithKeyPath_Options_XHandle, binding__handle__, observable__handle__, nskeyPath, options__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selBind_ToObject_WithKeyPath_Options_XHandle, binding__handle__, observable__handle__, nskeyPath, options__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (binding);
			GC.KeepAlive (observable);
			GC.KeepAlive (options);
			CFString.ReleaseNative (nskeyPath);
		}
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Bind (NSString binding, NSObject observable, string keyPath, global::AppKit.NSBindingOptions? options)
		{
			Bind (binding, observable, keyPath, options.GetDictionary ());
		}
		[Export ("cancelPreviousPerformRequestsWithTarget:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CancelPreviousPerformRequest (NSObject aTarget)
		{
			var aTarget__handle__ = aTarget!.GetNonNullHandle (nameof (aTarget));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (class_ptr, selCancelPreviousPerformRequestsWithTarget_XHandle, aTarget__handle__);
			GC.KeepAlive (aTarget);
		}
		[Export ("cancelPreviousPerformRequestsWithTarget:selector:object:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CancelPreviousPerformRequest (NSObject aTarget, Selector selector, NSObject? argument)
		{
			var aTarget__handle__ = aTarget!.GetNonNullHandle (nameof (aTarget));
			var selector__handle__ = selector!.GetNonNullHandle (nameof (selector));
			var argument__handle__ = argument.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selCancelPreviousPerformRequestsWithTarget_Selector_Object_XHandle, aTarget__handle__, selector.Handle, argument__handle__);
			GC.KeepAlive (aTarget);
			GC.KeepAlive (selector);
			GC.KeepAlive (argument);
		}
		[Export ("commitEditing")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos", "Now on 'NSEditor' protocol.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CommitEditing ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selCommitEditingXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selCommitEditingXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("commitEditingWithDelegate:didCommitSelector:contextInfo:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos", "Now on 'NSEditor' protocol.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void CommitEditing (NSObject objDelegate, Selector didCommitSelector, nint contextInfo)
		{
			var objDelegate__handle__ = objDelegate!.GetNonNullHandle (nameof (objDelegate));
			var didCommitSelector__handle__ = didCommitSelector!.GetNonNullHandle (nameof (didCommitSelector));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, selCommitEditingWithDelegate_DidCommitSelector_ContextInfo_XHandle, objDelegate__handle__, didCommitSelector.Handle, contextInfo);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selCommitEditingWithDelegate_DidCommitSelector_ContextInfo_XHandle, objDelegate__handle__, didCommitSelector.Handle, contextInfo);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (objDelegate);
			GC.KeepAlive (didCommitSelector);
		}
		[Export ("copy")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy ()
		{
			if (!(this is INSCopying)) throw new InvalidOperationException ("Type does not conform to NSCopying");
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCopyXHandle), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCopyXHandle), true)!;
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle_NativeHandle (this.Handle, selDidChange_ValuesAtIndexes_ForKey_XHandle, (UIntPtr) (ulong) changeKind, indexes__handle__, forKey__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_NativeHandle_NativeHandle (&__objc_super__, selDidChange_ValuesAtIndexes_ForKey_XHandle, (UIntPtr) (ulong) changeKind, indexes__handle__, forKey__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, selDidChangeValueForKey_WithSetMutation_UsingObjects_XHandle, forKey__handle__, (UIntPtr) (ulong) mutationKind, objects__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selDidChangeValueForKey_WithSetMutation_UsingObjects_XHandle, forKey__handle__, (UIntPtr) (ulong) mutationKind, objects__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDidChangeValueForKey_XHandle, nsforKey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDidChangeValueForKey_XHandle, nsforKey);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDoesNotRecognizeSelector_XHandle, sel.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDoesNotRecognizeSelector_XHandle, sel.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sel);
		}
		[Export ("infoForBinding:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary GetBindingInfo (NSString binding)
		{
			var binding__handle__ = binding!.GetNonNullHandle (nameof (binding));
			NSDictionary? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInfoForBinding_XHandle, binding__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInfoForBinding_XHandle, binding__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (binding);
			return ret!;
		}
		[Export ("optionDescriptionsForBinding:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] GetBindingOptionDescriptions (NSString aBinding)
		{
			var aBinding__handle__ = aBinding!.GetNonNullHandle (nameof (aBinding));
			NSObject[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selOptionDescriptionsForBinding_XHandle, aBinding__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selOptionDescriptionsForBinding_XHandle, aBinding__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (aBinding);
			return ret!;
		}
		[Export ("valueClassForBinding:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual Class GetBindingValueClass (NSString binding)
		{
			var binding__handle__ = binding!.GetNonNullHandle (nameof (binding));
			Class? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selValueClassForBinding_XHandle, binding__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selValueClassForBinding_XHandle, binding__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (binding);
			return ret!;
		}
		[Export ("defaultPlaceholderForMarker:withBinding:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos10.15")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject GetDefaultPlaceholder (NSObject marker, NSString binding)
		{
			var marker__handle__ = marker!.GetNonNullHandle (nameof (marker));
			var binding__handle__ = binding!.GetNonNullHandle (nameof (binding));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selDefaultPlaceholderForMarker_WithBinding_XHandle, marker__handle__, binding__handle__), false)!;
			GC.KeepAlive (marker);
			GC.KeepAlive (binding);
			return ret!;
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
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDictionaryWithValuesForKeys_XHandle, nsa_keys.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDictionaryWithValuesForKeys_XHandle, nsa_keys.Handle), false)!;
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
			ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selKeyPathsForValuesAffectingValueForKey_XHandle, key__handle__), false)!;
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
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selMethodForSelector_XHandle, sel.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selMethodForSelector_XHandle, sel.Handle);
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
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selHashXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selHashXHandle);
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
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsEqual_XHandle, anObject__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsEqual_XHandle, anObject__handle__);
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
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsKindOfClass_XHandle, aClass__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsKindOfClass_XHandle, aClass__handle__);
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
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsMemberOfClass_XHandle, aClass__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsMemberOfClass_XHandle, aClass__handle__);
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
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMutableCopyXHandle), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMutableCopyXHandle), true)!;
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		[Export ("objectDidEndEditing:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos", "Now on 'NSEditor' protocol.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ObjectDidEndEditing (NSObject editor)
		{
			var editor__handle__ = editor!.GetNonNullHandle (nameof (editor));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selObjectDidEndEditing_XHandle, editor__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selObjectDidEndEditing_XHandle, editor__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (editor);
		}
		[Export ("observeValueForKeyPath:ofObject:change:context:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ObserveValue (NSString keyPath, NSObject ofObject, NSDictionary change, nint context)
		{
			var keyPath__handle__ = keyPath!.GetNonNullHandle (nameof (keyPath));
			var ofObject__handle__ = ofObject!.GetNonNullHandle (nameof (ofObject));
			var change__handle__ = change!.GetNonNullHandle (nameof (change));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_IntPtr (this.Handle, selObserveValueForKeyPath_OfObject_Change_Context_XHandle, keyPath__handle__, ofObject__handle__, change__handle__, context);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selObserveValueForKeyPath_OfObject_Change_Context_XHandle, keyPath__handle__, ofObject__handle__, change__handle__, context);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Double_NativeHandle (this.Handle, selPerformSelector_WithObject_AfterDelay_InModes_XHandle, selector.Handle, withObject__handle__, afterDelay, nsa_nsRunLoopModes.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_Double_NativeHandle (&__objc_super__, selPerformSelector_WithObject_AfterDelay_InModes_XHandle, selector.Handle, withObject__handle__, afterDelay, nsa_nsRunLoopModes.Handle);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_Double (this.Handle, selPerformSelector_WithObject_AfterDelay_XHandle, selector.Handle, withObject__handle__, delay);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_Double (&__objc_super__, selPerformSelector_WithObject_AfterDelay_XHandle, selector.Handle, withObject__handle__, delay);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_bool (this.Handle, selPerformSelector_OnThread_WithObject_WaitUntilDone_XHandle, selector.Handle, onThread__handle__, withObject__handle__, waitUntilDone ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_bool (&__objc_super__, selPerformSelector_OnThread_WithObject_WaitUntilDone_XHandle, selector.Handle, onThread__handle__, withObject__handle__, waitUntilDone ? (byte) 1 : (byte) 0);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_bool_NativeHandle (this.Handle, selPerformSelector_OnThread_WithObject_WaitUntilDone_Modes_XHandle, selector.Handle, onThread__handle__, withObject__handle__, waitUntilDone ? (byte) 1 : (byte) 0, nsa_nsRunLoopModes.GetHandle ());
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_bool_NativeHandle (&__objc_super__, selPerformSelector_OnThread_WithObject_WaitUntilDone_Modes_XHandle, selector.Handle, onThread__handle__, withObject__handle__, waitUntilDone ? (byte) 1 : (byte) 0, nsa_nsRunLoopModes.GetHandle ());
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
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPerformSelector_XHandle, aSelector.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPerformSelector_XHandle, aSelector.Handle), false)!;
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
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selPerformSelector_WithObject_XHandle, aSelector.Handle, anObject__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selPerformSelector_WithObject_XHandle, aSelector.Handle, anObject__handle__), false)!;
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
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selPerformSelector_WithObject_WithObject_XHandle, aSelector.Handle, object1__handle__, object2__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selPerformSelector_WithObject_WithObject_XHandle, aSelector.Handle, object1__handle__, object2__handle__), false)!;
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
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPrepareForInterfaceBuilderXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selPrepareForInterfaceBuilderXHandle);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_IntPtr (this.Handle, selRemoveObserver_ForKeyPath_Context_XHandle, observer__handle__, keyPath__handle__, context);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selRemoveObserver_ForKeyPath_Context_XHandle, observer__handle__, keyPath__handle__, context);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRemoveObserver_ForKeyPath_XHandle, observer__handle__, keyPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRemoveObserver_ForKeyPath_XHandle, observer__handle__, keyPath__handle__);
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
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selRespondsToSelector_XHandle, sel__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selRespondsToSelector_XHandle, sel__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sel);
			return ret != 0;
		}
		[Export ("setDefaultPlaceholder:forMarker:withBinding:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos10.15")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetDefaultPlaceholder (NSObject placeholder, NSObject marker, NSString binding)
		{
			var placeholder__handle__ = placeholder!.GetNonNullHandle (nameof (placeholder));
			var marker__handle__ = marker!.GetNonNullHandle (nameof (marker));
			var binding__handle__ = binding!.GetNonNullHandle (nameof (binding));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, selSetDefaultPlaceholder_ForMarker_WithBinding_XHandle, placeholder__handle__, marker__handle__, binding__handle__);
			GC.KeepAlive (placeholder);
			GC.KeepAlive (marker);
			GC.KeepAlive (binding);
		}
		[Export ("setNilValueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNilValueForKey (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetNilValueForKey_XHandle, key__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetNilValueForKey_XHandle, key__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetValue_ForKey_XHandle, value__handle__, key__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetValue_ForKey_XHandle, value__handle__, key__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetValue_ForKeyPath_XHandle, value__handle__, keyPath__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetValue_ForKeyPath_XHandle, value__handle__, keyPath__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetValue_ForUndefinedKey_XHandle, value__handle__, undefinedKey__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetValue_ForUndefinedKey_XHandle, value__handle__, undefinedKey__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetValuesForKeysWithDictionary_XHandle, keyedValues__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetValuesForKeysWithDictionary_XHandle, keyedValues__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (keyedValues);
		}
		[Export ("unbind:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Unbind (NSString binding)
		{
			var binding__handle__ = binding!.GetNonNullHandle (nameof (binding));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUnbind_XHandle, binding__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUnbind_XHandle, binding__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (binding);
		}
		[Export ("valueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ValueForKey (NSString key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			IntPtr exception_gchandle = IntPtr.Zero;
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.xamarin_NativeHandle_objc_msgSend_NativeHandle_exception (this.Handle, selValueForKey_XHandle, key__handle__, &exception_gchandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.xamarin_NativeHandle_objc_msgSendSuper_NativeHandle_exception (&__objc_super__, selValueForKey_XHandle, key__handle__, &exception_gchandle), false)!;
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
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selValueForKeyPath_XHandle, keyPath__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selValueForKeyPath_XHandle, keyPath__handle__), false)!;
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
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selValueForUndefinedKey_XHandle, key__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selValueForUndefinedKey_XHandle, key__handle__), false)!;
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle_NativeHandle (this.Handle, selWillChange_ValuesAtIndexes_ForKey_XHandle, (UIntPtr) (ulong) changeKind, indexes__handle__, forKey__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_NativeHandle_NativeHandle (&__objc_super__, selWillChange_ValuesAtIndexes_ForKey_XHandle, (UIntPtr) (ulong) changeKind, indexes__handle__, forKey__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle (this.Handle, selWillChangeValueForKey_WithSetMutation_UsingObjects_XHandle, forKey__handle__, (UIntPtr) (ulong) mutationKind, objects__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle (&__objc_super__, selWillChangeValueForKey_WithSetMutation_UsingObjects_XHandle, forKey__handle__, (UIntPtr) (ulong) mutationKind, objects__handle__);
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selWillChangeValueForKey_XHandle, nsforKey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selWillChangeValueForKey_XHandle, nsforKey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsforKey);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public virtual Class Class {
			[Export ("class")]
			get {
				Class ret;
				if (IsDirectBinding) {
					ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selClassXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selClassXHandle), false)!;
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
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDebugDescriptionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDebugDescriptionXHandle), false)!;
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
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDescriptionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDescriptionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSString[] ExposedBindings {
			[Export ("exposedBindings")]
			get {
				NSString[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selExposedBindingsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selExposedBindingsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
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
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsProxyXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsProxyXHandle);
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
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selRetainCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selRetainCountXHandle);
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
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelfXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelfXHandle), false)!;
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
					ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSuperclassXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::ObjCRuntime.Class> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSuperclassXHandle), false)!;
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
					ret = Runtime.GetINativeObject<global::Foundation.NSZone> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selZoneXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = Runtime.GetINativeObject<global::Foundation.NSZone> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selZoneXHandle), false)!;
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
