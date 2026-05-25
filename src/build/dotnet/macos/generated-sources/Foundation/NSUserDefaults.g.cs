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
	[Register("NSUserDefaults", true)]
	public unsafe partial class NSUserDefaults : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLForKey_X = "URLForKey:";
		static readonly NativeHandle selURLForKey_XHandle = Selector.GetHandle ("URLForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddSuiteNamed_X = "addSuiteNamed:";
		static readonly NativeHandle selAddSuiteNamed_XHandle = Selector.GetHandle ("addSuiteNamed:");
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
		const string selDictionaryForKey_X = "dictionaryForKey:";
		static readonly NativeHandle selDictionaryForKey_XHandle = Selector.GetHandle ("dictionaryForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDictionaryRepresentationX = "dictionaryRepresentation";
		static readonly NativeHandle selDictionaryRepresentationXHandle = Selector.GetHandle ("dictionaryRepresentation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDoubleForKey_X = "doubleForKey:";
		static readonly NativeHandle selDoubleForKey_XHandle = Selector.GetHandle ("doubleForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFloatForKey_X = "floatForKey:";
		static readonly NativeHandle selFloatForKey_XHandle = Selector.GetHandle ("floatForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithSuiteName_X = "initWithSuiteName:";
		static readonly NativeHandle selInitWithSuiteName_XHandle = Selector.GetHandle ("initWithSuiteName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithUser_X = "initWithUser:";
		static readonly NativeHandle selInitWithUser_XHandle = Selector.GetHandle ("initWithUser:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIntegerForKey_X = "integerForKey:";
		static readonly NativeHandle selIntegerForKey_XHandle = Selector.GetHandle ("integerForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectForKey_X = "objectForKey:";
		static readonly NativeHandle selObjectForKey_XHandle = Selector.GetHandle ("objectForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectIsForcedForKey_X = "objectIsForcedForKey:";
		static readonly NativeHandle selObjectIsForcedForKey_XHandle = Selector.GetHandle ("objectIsForcedForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectIsForcedForKey_InDomain_X = "objectIsForcedForKey:inDomain:";
		static readonly NativeHandle selObjectIsForcedForKey_InDomain_XHandle = Selector.GetHandle ("objectIsForcedForKey:inDomain:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPersistentDomainForName_X = "persistentDomainForName:";
		static readonly NativeHandle selPersistentDomainForName_XHandle = Selector.GetHandle ("persistentDomainForName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPersistentDomainNamesX = "persistentDomainNames";
		static readonly NativeHandle selPersistentDomainNamesXHandle = Selector.GetHandle ("persistentDomainNames");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRegisterDefaults_X = "registerDefaults:";
		static readonly NativeHandle selRegisterDefaults_XHandle = Selector.GetHandle ("registerDefaults:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveObjectForKey_X = "removeObjectForKey:";
		static readonly NativeHandle selRemoveObjectForKey_XHandle = Selector.GetHandle ("removeObjectForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemovePersistentDomainForName_X = "removePersistentDomainForName:";
		static readonly NativeHandle selRemovePersistentDomainForName_XHandle = Selector.GetHandle ("removePersistentDomainForName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveSuiteNamed_X = "removeSuiteNamed:";
		static readonly NativeHandle selRemoveSuiteNamed_XHandle = Selector.GetHandle ("removeSuiteNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveVolatileDomainForName_X = "removeVolatileDomainForName:";
		static readonly NativeHandle selRemoveVolatileDomainForName_XHandle = Selector.GetHandle ("removeVolatileDomainForName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResetStandardUserDefaultsX = "resetStandardUserDefaults";
		static readonly NativeHandle selResetStandardUserDefaultsXHandle = Selector.GetHandle ("resetStandardUserDefaults");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBool_ForKey_X = "setBool:forKey:";
		static readonly NativeHandle selSetBool_ForKey_XHandle = Selector.GetHandle ("setBool:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDouble_ForKey_X = "setDouble:forKey:";
		static readonly NativeHandle selSetDouble_ForKey_XHandle = Selector.GetHandle ("setDouble:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFloat_ForKey_X = "setFloat:forKey:";
		static readonly NativeHandle selSetFloat_ForKey_XHandle = Selector.GetHandle ("setFloat:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetInteger_ForKey_X = "setInteger:forKey:";
		static readonly NativeHandle selSetInteger_ForKey_XHandle = Selector.GetHandle ("setInteger:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetObject_ForKey_X = "setObject:forKey:";
		static readonly NativeHandle selSetObject_ForKey_XHandle = Selector.GetHandle ("setObject:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPersistentDomain_ForName_X = "setPersistentDomain:forName:";
		static readonly NativeHandle selSetPersistentDomain_ForName_XHandle = Selector.GetHandle ("setPersistentDomain:forName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetURL_ForKey_X = "setURL:forKey:";
		static readonly NativeHandle selSetURL_ForKey_XHandle = Selector.GetHandle ("setURL:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVolatileDomain_ForName_X = "setVolatileDomain:forName:";
		static readonly NativeHandle selSetVolatileDomain_ForName_XHandle = Selector.GetHandle ("setVolatileDomain:forName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStandardUserDefaultsX = "standardUserDefaults";
		static readonly NativeHandle selStandardUserDefaultsXHandle = Selector.GetHandle ("standardUserDefaults");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringArrayForKey_X = "stringArrayForKey:";
		static readonly NativeHandle selStringArrayForKey_XHandle = Selector.GetHandle ("stringArrayForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringForKey_X = "stringForKey:";
		static readonly NativeHandle selStringForKey_XHandle = Selector.GetHandle ("stringForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSynchronizeX = "synchronize";
		static readonly NativeHandle selSynchronizeXHandle = Selector.GetHandle ("synchronize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVolatileDomainForName_X = "volatileDomainForName:";
		static readonly NativeHandle selVolatileDomainForName_XHandle = Selector.GetHandle ("volatileDomainForName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVolatileDomainNamesX = "volatileDomainNames";
		static readonly NativeHandle selVolatileDomainNamesXHandle = Selector.GetHandle ("volatileDomainNames");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSUserDefaults");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSUserDefaults" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSUserDefaults () : base (NSObjectFlag.Empty)
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
		protected NSUserDefaults (NSObjectFlag t) : base (t)
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
		protected internal NSUserDefaults (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addSuiteNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddSuite (string suiteName)
		{
			if (suiteName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suiteName));
			var nssuiteName = CFString.CreateNative (suiteName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddSuiteNamed_XHandle, nssuiteName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddSuiteNamed_XHandle, nssuiteName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nssuiteName);
		}
		[Export ("arrayForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[]? ArrayForKey (string defaultName)
		{
			if (defaultName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultName));
			var nsdefaultName = CFString.CreateNative (defaultName);
			NSObject[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selArrayForKey_XHandle, nsdefaultName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selArrayForKey_XHandle, nsdefaultName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdefaultName);
			return ret!;
		}
		[Export ("boolForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool BoolForKey (string defaultName)
		{
			if (defaultName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultName));
			var nsdefaultName = CFString.CreateNative (defaultName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selBoolForKey_XHandle, nsdefaultName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selBoolForKey_XHandle, nsdefaultName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdefaultName);
			return ret != 0;
		}
		[Export ("dataForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? DataForKey (string defaultName)
		{
			if (defaultName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultName));
			var nsdefaultName = CFString.CreateNative (defaultName);
			NSData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDataForKey_XHandle, nsdefaultName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDataForKey_XHandle, nsdefaultName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdefaultName);
			return ret!;
		}
		[Export ("dictionaryForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? DictionaryForKey (string defaultName)
		{
			if (defaultName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultName));
			var nsdefaultName = CFString.CreateNative (defaultName);
			NSDictionary? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDictionaryForKey_XHandle, nsdefaultName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDictionaryForKey_XHandle, nsdefaultName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdefaultName);
			return ret!;
		}
		[Export ("doubleForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double DoubleForKey (string defaultName)
		{
			if (defaultName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultName));
			var nsdefaultName = CFString.CreateNative (defaultName);
			double ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend_NativeHandle (this.Handle, selDoubleForKey_XHandle, nsdefaultName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper_NativeHandle (&__objc_super__, selDoubleForKey_XHandle, nsdefaultName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdefaultName);
			return ret!;
		}
		[Export ("floatForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float FloatForKey (string defaultName)
		{
			if (defaultName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultName));
			var nsdefaultName = CFString.CreateNative (defaultName);
			float ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend_NativeHandle (this.Handle, selFloatForKey_XHandle, nsdefaultName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper_NativeHandle (&__objc_super__, selFloatForKey_XHandle, nsdefaultName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdefaultName);
			return ret!;
		}
		[Export ("volatileDomainForName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary GetVolatileDomain (string domainName)
		{
			if (domainName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (domainName));
			var nsdomainName = CFString.CreateNative (domainName);
			NSDictionary? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selVolatileDomainForName_XHandle, nsdomainName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selVolatileDomainForName_XHandle, nsdomainName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdomainName);
			return ret!;
		}
		[Export ("integerForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint IntForKey (string defaultName)
		{
			if (defaultName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultName));
			var nsdefaultName = CFString.CreateNative (defaultName);
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selIntegerForKey_XHandle, nsdefaultName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selIntegerForKey_XHandle, nsdefaultName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdefaultName);
			return ret!;
		}
		[Export ("objectForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual NSObject? ObjectForKey (string defaultName)
		{
			if (defaultName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultName));
			var nsdefaultName = CFString.CreateNative (defaultName);
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selObjectForKey_XHandle, nsdefaultName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selObjectForKey_XHandle, nsdefaultName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdefaultName);
			return ret!;
		}
		[Export ("objectIsForcedForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ObjectIsForced (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selObjectIsForcedForKey_XHandle, nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selObjectIsForcedForKey_XHandle, nskey);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
			return ret != 0;
		}
		[Export ("objectIsForcedForKey:inDomain:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ObjectIsForced (string key, string domain)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (domain is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (domain));
			var nskey = CFString.CreateNative (key);
			var nsdomain = CFString.CreateNative (domain);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selObjectIsForcedForKey_InDomain_XHandle, nskey, nsdomain);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selObjectIsForcedForKey_InDomain_XHandle, nskey, nsdomain);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsdomain);
			return ret != 0;
		}
		[Export ("persistentDomainForName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? PersistentDomainForName (string domainName)
		{
			if (domainName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (domainName));
			var nsdomainName = CFString.CreateNative (domainName);
			NSDictionary? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPersistentDomainForName_XHandle, nsdomainName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPersistentDomainForName_XHandle, nsdomainName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdomainName);
			return ret!;
		}
		[Export ("persistentDomainNames")]
		[ObsoletedOSPlatform ("ios7.0")]
		[ObsoletedOSPlatform ("tvos9.0")]
		[ObsoletedOSPlatform ("macos10.9")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] PersistentDomainNames ()
		{
			string[] ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPersistentDomainNamesXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPersistentDomainNamesXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("registerDefaults:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisterDefaults (NSDictionary registrationDictionary)
		{
			var registrationDictionary__handle__ = registrationDictionary!.GetNonNullHandle (nameof (registrationDictionary));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRegisterDefaults_XHandle, registrationDictionary__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRegisterDefaults_XHandle, registrationDictionary__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (registrationDictionary);
		}
		[Export ("removeObjectForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveObject (string defaultName)
		{
			if (defaultName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultName));
			var nsdefaultName = CFString.CreateNative (defaultName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveObjectForKey_XHandle, nsdefaultName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveObjectForKey_XHandle, nsdefaultName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdefaultName);
		}
		[Export ("removePersistentDomainForName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemovePersistentDomain (string domainName)
		{
			if (domainName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (domainName));
			var nsdomainName = CFString.CreateNative (domainName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemovePersistentDomainForName_XHandle, nsdomainName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemovePersistentDomainForName_XHandle, nsdomainName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdomainName);
		}
		[Export ("removeSuiteNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveSuite (string suiteName)
		{
			if (suiteName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (suiteName));
			var nssuiteName = CFString.CreateNative (suiteName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveSuiteNamed_XHandle, nssuiteName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveSuiteNamed_XHandle, nssuiteName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nssuiteName);
		}
		[Export ("removeVolatileDomainForName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveVolatileDomain (string domainName)
		{
			if (domainName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (domainName));
			var nsdomainName = CFString.CreateNative (domainName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveVolatileDomainForName_XHandle, nsdomainName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveVolatileDomainForName_XHandle, nsdomainName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdomainName);
		}
		[Export ("resetStandardUserDefaults")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ResetStandardUserDefaults ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (class_ptr, selResetStandardUserDefaultsXHandle);
		}
		[Export ("setBool:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetBool (bool value, string defaultName)
		{
			if (defaultName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultName));
			var nsdefaultName = CFString.CreateNative (defaultName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_NativeHandle (this.Handle, selSetBool_ForKey_XHandle, value ? (byte) 1 : (byte) 0, nsdefaultName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_NativeHandle (&__objc_super__, selSetBool_ForKey_XHandle, value ? (byte) 1 : (byte) 0, nsdefaultName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdefaultName);
		}
		[Export ("setDouble:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDouble (double value, string defaultName)
		{
			if (defaultName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultName));
			var nsdefaultName = CFString.CreateNative (defaultName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_Double_NativeHandle (this.Handle, selSetDouble_ForKey_XHandle, value, nsdefaultName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double_NativeHandle (&__objc_super__, selSetDouble_ForKey_XHandle, value, nsdefaultName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdefaultName);
		}
		[Export ("setFloat:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFloat (float value, string defaultName)
		{
			if (defaultName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultName));
			var nsdefaultName = CFString.CreateNative (defaultName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_float_NativeHandle (this.Handle, selSetFloat_ForKey_XHandle, value, nsdefaultName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float_NativeHandle (&__objc_super__, selSetFloat_ForKey_XHandle, value, nsdefaultName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdefaultName);
		}
		/// <param name="value">To be added.</param><param name="defaultName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setInteger:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetInt (nint value, string defaultName)
		{
			if (defaultName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultName));
			var nsdefaultName = CFString.CreateNative (defaultName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, selSetInteger_ForKey_XHandle, value, nsdefaultName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, selSetInteger_ForKey_XHandle, value, nsdefaultName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdefaultName);
		}
		[Export ("setObject:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void SetObjectForKey (NSObject? value, string defaultName)
		{
			var value__handle__ = value.GetHandle ();
			if (defaultName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultName));
			var nsdefaultName = CFString.CreateNative (defaultName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetObject_ForKey_XHandle, value__handle__, nsdefaultName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetObject_ForKey_XHandle, value__handle__, nsdefaultName);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
			CFString.ReleaseNative (nsdefaultName);
		}
		[Export ("setPersistentDomain:forName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPersistentDomain (NSDictionary domain, string domainName)
		{
			var domain__handle__ = domain!.GetNonNullHandle (nameof (domain));
			if (domainName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (domainName));
			var nsdomainName = CFString.CreateNative (domainName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetPersistentDomain_ForName_XHandle, domain__handle__, nsdomainName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetPersistentDomain_ForName_XHandle, domain__handle__, nsdomainName);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (domain);
			CFString.ReleaseNative (nsdomainName);
		}
		[Export ("setURL:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetURL (NSUrl? url, string defaultName)
		{
			var url__handle__ = url.GetHandle ();
			if (defaultName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultName));
			var nsdefaultName = CFString.CreateNative (defaultName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetURL_ForKey_XHandle, url__handle__, nsdefaultName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetURL_ForKey_XHandle, url__handle__, nsdefaultName);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			CFString.ReleaseNative (nsdefaultName);
		}
		[Export ("setVolatileDomain:forName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVolatileDomain (NSDictionary domain, string domainName)
		{
			var domain__handle__ = domain!.GetNonNullHandle (nameof (domain));
			if (domainName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (domainName));
			var nsdomainName = CFString.CreateNative (domainName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetVolatileDomain_ForName_XHandle, domain__handle__, nsdomainName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetVolatileDomain_ForName_XHandle, domain__handle__, nsdomainName);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (domain);
			CFString.ReleaseNative (nsdomainName);
		}
		[Export ("stringArrayForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? StringArrayForKey (string defaultName)
		{
			if (defaultName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultName));
			var nsdefaultName = CFString.CreateNative (defaultName);
			string[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selStringArrayForKey_XHandle, nsdefaultName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selStringArrayForKey_XHandle, nsdefaultName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdefaultName);
			return ret!;
		}
		[Export ("stringForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? StringForKey (string defaultName)
		{
			if (defaultName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultName));
			var nsdefaultName = CFString.CreateNative (defaultName);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selStringForKey_XHandle, nsdefaultName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selStringForKey_XHandle, nsdefaultName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdefaultName);
			return ret!;
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
		[Export ("URLForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? URLForKey (string defaultName)
		{
			if (defaultName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (defaultName));
			var nsdefaultName = CFString.CreateNative (defaultName);
			NSUrl? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selURLForKey_XHandle, nsdefaultName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selURLForKey_XHandle, nsdefaultName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdefaultName);
			return ret!;
		}
		[Export ("volatileDomainNames")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] VolatileDomainNames ()
		{
			string[] ret;
			if (IsDirectBinding) {
				ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVolatileDomainNamesXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVolatileDomainNamesXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("initWithSuiteName:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint _InitWithSuiteName (string? suiteName)
		{
			var nssuiteName = CFString.CreateNative (suiteName);
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selInitWithSuiteName_XHandle, nssuiteName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithSuiteName_XHandle, nssuiteName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nssuiteName);
			return ret!;
		}
		[Export ("initWithUser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint _InitWithUserName (string username)
		{
			if (username is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (username));
			var nsusername = CFString.CreateNative (username);
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle (this.Handle, selInitWithUser_XHandle, nsusername);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithUser_XHandle, nsusername);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsusername);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUserDefaults StandardUserDefaults {
			[Export ("standardUserDefaults", ArgumentSemantic.Retain)]
			get {
				NSUserDefaults? ret;
				ret =  Runtime.GetNSObject<NSUserDefaults> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selStandardUserDefaultsXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ArgumentDomain;
		/// <summary>This is the key used to retrieve the domain associated with the command line arguments passed at startup.</summary><value></value><remarks><para>
		/// 	    This domain contains the command line arguments that were
		/// 	    parsed at application startup.
		/// 
		/// 	  </para><para>
		/// 	    For each command line argument of the form -NAME VALUE
		/// 	    that is passed at startup to your application, the "NAME"
		/// 	    is used as the key, with the value set to VALUE.  
		/// 
		/// 	  </para><example><code lang="c#">
		/// // Retrieve the global NSButtonDelay setting on macOS:
		/// var global = new NSUserDefaults (NSUserDefaults.GlobalDomain);
		/// Console.WriteLine ("Delay: " + j.FloatForKey ("NSButtonDelay"));
		/// 	    </code></example></remarks>
		[Field ("NSArgumentDomain",  "Foundation")]
		public static NSString ArgumentDomain {
			get {
				if (_ArgumentDomain is null)
					_ArgumentDomain = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSArgumentDomain")!;
				return _ArgumentDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DidChangeNotification;
		/// <summary>Notification constant for DidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
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
		/// notification = NSUserDefaults.Notifications.ObserveDidChange ((sender, args) => {
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
		/// void Callback (object sender, NSUserDefaults.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = NSUserDefaults.Notifications.ObserveDidChange (Callback);
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
		///     NSUserDefaults.DidChangeNotification, (notification) => { Console.WriteLine ("Received the notification DidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification DidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (NSUserDefaults.DidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("NSUserDefaultsDidChangeNotification",  "Foundation")]
		[Advice ("Use NSUserDefaults.Notifications.ObserveDidChange helper method instead.")]
		public static NSString DidChangeNotification {
			get {
				if (_DidChangeNotification is null)
					_DidChangeNotification = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSUserDefaultsDidChangeNotification")!;
				return _DidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GlobalDomain;
		/// <summary>This is the key used to retrieve the global user defaults domain.</summary><value></value><remarks><para>
		/// 	    This key is used to retrieve the global user defaults.
		/// 	  </para><example><code lang="c#">
		/// // Retrieve the global NSButtonDelay setting on macOS:
		/// var global = new NSUserDefaults (NSUserDefaults.GlobalDomain);
		/// Console.WriteLine ("Delay: " + j.FloatForKey ("NSButtonDelay"));
		/// 	    </code></example></remarks>
		[Field ("NSGlobalDomain",  "Foundation")]
		public static NSString GlobalDomain {
			get {
				if (_GlobalDomain is null)
					_GlobalDomain = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSGlobalDomain")!;
				return _GlobalDomain;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RegistrationDomain;
		/// <summary>Represents the value associated with the constant NSRegistrationDomain</summary><value></value><remarks>To be added.</remarks>
		[Field ("NSRegistrationDomain",  "Foundation")]
		public static NSString RegistrationDomain {
			get {
				if (_RegistrationDomain is null)
					_RegistrationDomain = Dlfcn.GetStringConstant (Libraries.Foundation.Handle, "NSRegistrationDomain")!;
				return _RegistrationDomain;
			}
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::Foundation.NSUserDefaults" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::Foundation.NSUserDefaults.DidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Foundation.NSUserDefaults.DidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = NSUserDefaults.Notifications.ObserveDidChange ((notification) => {
			///   Console.WriteLine ("Observed DidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::Foundation.NSUserDefaults.DidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::Foundation.NSUserDefaults.DidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = NSUserDefaults.Notifications.ObserveDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed DidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class NSUserDefaults */
}
