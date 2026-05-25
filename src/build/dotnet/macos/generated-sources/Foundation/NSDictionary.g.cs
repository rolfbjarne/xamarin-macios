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
	[Register("NSDictionary", true)]
	public unsafe partial class NSDictionary : NSObject, INSCoding, INSCopying, INSMutableCopying, INSSecureCoding, global::CoreData.INSFetchRequestResult {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllKeysX = "allKeys";
		static readonly NativeHandle selAllKeysXHandle = Selector.GetHandle ("allKeys");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllKeysForObject_X = "allKeysForObject:";
		static readonly NativeHandle selAllKeysForObject_XHandle = Selector.GetHandle ("allKeysForObject:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllValuesX = "allValues";
		static readonly NativeHandle selAllValuesXHandle = Selector.GetHandle ("allValues");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCountX = "count";
		static readonly NativeHandle selCountXHandle = Selector.GetHandle ("count");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptionInStringsFileFormatX = "descriptionInStringsFileFormat";
		static readonly NativeHandle selDescriptionInStringsFileFormatXHandle = Selector.GetHandle ("descriptionInStringsFileFormat");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptionWithLocale_X = "descriptionWithLocale:";
		static readonly NativeHandle selDescriptionWithLocale_XHandle = Selector.GetHandle ("descriptionWithLocale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptionWithLocale_Indent_X = "descriptionWithLocale:indent:";
		static readonly NativeHandle selDescriptionWithLocale_Indent_XHandle = Selector.GetHandle ("descriptionWithLocale:indent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDictionaryWithContentsOfFile_X = "dictionaryWithContentsOfFile:";
		static readonly NativeHandle selDictionaryWithContentsOfFile_XHandle = Selector.GetHandle ("dictionaryWithContentsOfFile:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDictionaryWithContentsOfURL_X = "dictionaryWithContentsOfURL:";
		static readonly NativeHandle selDictionaryWithContentsOfURL_XHandle = Selector.GetHandle ("dictionaryWithContentsOfURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDictionaryWithContentsOfURL_Error_X = "dictionaryWithContentsOfURL:error:";
		static readonly NativeHandle selDictionaryWithContentsOfURL_Error_XHandle = Selector.GetHandle ("dictionaryWithContentsOfURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDictionaryWithDictionary_X = "dictionaryWithDictionary:";
		static readonly NativeHandle selDictionaryWithDictionary_XHandle = Selector.GetHandle ("dictionaryWithDictionary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDictionaryWithObject_ForKey_X = "dictionaryWithObject:forKey:";
		static readonly NativeHandle selDictionaryWithObject_ForKey_XHandle = Selector.GetHandle ("dictionaryWithObject:forKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDictionaryWithObjects_ForKeys_X = "dictionaryWithObjects:forKeys:";
		static readonly NativeHandle selDictionaryWithObjects_ForKeys_XHandle = Selector.GetHandle ("dictionaryWithObjects:forKeys:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDictionaryWithObjects_ForKeys_Count_X = "dictionaryWithObjects:forKeys:count:";
		static readonly NativeHandle selDictionaryWithObjects_ForKeys_Count_XHandle = Selector.GetHandle ("dictionaryWithObjects:forKeys:count:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateKeysAndObjectsUsingBlock_X = "enumerateKeysAndObjectsUsingBlock:";
		static readonly NativeHandle selEnumerateKeysAndObjectsUsingBlock_XHandle = Selector.GetHandle ("enumerateKeysAndObjectsUsingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumerateKeysAndObjectsWithOptions_UsingBlock_X = "enumerateKeysAndObjectsWithOptions:usingBlock:";
		static readonly NativeHandle selEnumerateKeysAndObjectsWithOptions_UsingBlock_XHandle = Selector.GetHandle ("enumerateKeysAndObjectsWithOptions:usingBlock:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithContentsOfFile_X = "initWithContentsOfFile:";
		static readonly NativeHandle selInitWithContentsOfFile_XHandle = Selector.GetHandle ("initWithContentsOfFile:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithContentsOfURL_X = "initWithContentsOfURL:";
		static readonly NativeHandle selInitWithContentsOfURL_XHandle = Selector.GetHandle ("initWithContentsOfURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithContentsOfURL_Error_X = "initWithContentsOfURL:error:";
		static readonly NativeHandle selInitWithContentsOfURL_Error_XHandle = Selector.GetHandle ("initWithContentsOfURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDictionary_X = "initWithDictionary:";
		static readonly NativeHandle selInitWithDictionary_XHandle = Selector.GetHandle ("initWithDictionary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDictionary_CopyItems_X = "initWithDictionary:copyItems:";
		static readonly NativeHandle selInitWithDictionary_CopyItems_XHandle = Selector.GetHandle ("initWithDictionary:copyItems:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithObjects_ForKeys_X = "initWithObjects:forKeys:";
		static readonly NativeHandle selInitWithObjects_ForKeys_XHandle = Selector.GetHandle ("initWithObjects:forKeys:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEqualToDictionary_X = "isEqualToDictionary:";
		static readonly NativeHandle selIsEqualToDictionary_XHandle = Selector.GetHandle ("isEqualToDictionary:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeyEnumeratorX = "keyEnumerator";
		static readonly NativeHandle selKeyEnumeratorXHandle = Selector.GetHandle ("keyEnumerator");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeysOfEntriesPassingTest_X = "keysOfEntriesPassingTest:";
		static readonly NativeHandle selKeysOfEntriesPassingTest_XHandle = Selector.GetHandle ("keysOfEntriesPassingTest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeysOfEntriesWithOptions_PassingTest_X = "keysOfEntriesWithOptions:passingTest:";
		static readonly NativeHandle selKeysOfEntriesWithOptions_PassingTest_XHandle = Selector.GetHandle ("keysOfEntriesWithOptions:passingTest:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeysSortedByValueUsingComparator_X = "keysSortedByValueUsingComparator:";
		static readonly NativeHandle selKeysSortedByValueUsingComparator_XHandle = Selector.GetHandle ("keysSortedByValueUsingComparator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeysSortedByValueWithOptions_UsingComparator_X = "keysSortedByValueWithOptions:usingComparator:";
		static readonly NativeHandle selKeysSortedByValueWithOptions_UsingComparator_XHandle = Selector.GetHandle ("keysSortedByValueWithOptions:usingComparator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMutableCopyWithZone_X = "mutableCopyWithZone:";
		static readonly NativeHandle selMutableCopyWithZone_XHandle = Selector.GetHandle ("mutableCopyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectEnumeratorX = "objectEnumerator";
		static readonly NativeHandle selObjectEnumeratorXHandle = Selector.GetHandle ("objectEnumerator");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectForKey_X = "objectForKey:";
		static readonly NativeHandle selObjectForKey_XHandle = Selector.GetHandle ("objectForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectsForKeys_NotFoundMarker_X = "objectsForKeys:notFoundMarker:";
		static readonly NativeHandle selObjectsForKeys_NotFoundMarker_XHandle = Selector.GetHandle ("objectsForKeys:notFoundMarker:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSharedKeySetForKeys_X = "sharedKeySetForKeys:";
		static readonly NativeHandle selSharedKeySetForKeys_XHandle = Selector.GetHandle ("sharedKeySetForKeys:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueForKey_X = "valueForKey:";
		static readonly NativeHandle selValueForKey_XHandle = Selector.GetHandle ("valueForKey:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteToFile_Atomically_X = "writeToFile:atomically:";
		static readonly NativeHandle selWriteToFile_Atomically_XHandle = Selector.GetHandle ("writeToFile:atomically:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteToURL_Atomically_X = "writeToURL:atomically:";
		static readonly NativeHandle selWriteToURL_Atomically_XHandle = Selector.GetHandle ("writeToURL:atomically:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWriteToURL_Error_X = "writeToURL:error:";
		static readonly NativeHandle selWriteToURL_Error_XHandle = Selector.GetHandle ("writeToURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSDictionary");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSDictionary" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSDictionary () : base (NSObjectFlag.Empty)
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

		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public NSDictionary (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected NSDictionary (NSObjectFlag t) : base (t)
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
		protected internal NSDictionary (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithDictionary:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary (NSDictionary other)
			: base (NSObjectFlag.Empty)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithDictionary_XHandle, other__handle__), "initWithDictionary:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithDictionary_XHandle, other__handle__), "initWithDictionary:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
		}
		[Export ("initWithDictionary:copyItems:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary (NSDictionary other, bool copyItems)
			: base (NSObjectFlag.Empty)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (this.Handle, selInitWithDictionary_CopyItems_XHandle, other__handle__, copyItems ? (byte) 1 : (byte) 0), "initWithDictionary:copyItems:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selInitWithDictionary_CopyItems_XHandle, other__handle__, copyItems ? (byte) 1 : (byte) 0), "initWithDictionary:copyItems:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
		}
		[Export ("initWithContentsOfFile:")]
		[ObsoletedOSPlatform ("macos10.15", "Use 'NSMutableDictionary(string)' constructor instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'NSMutableDictionary(string)' constructor instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'NSMutableDictionary(string)' constructor instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSMutableDictionary(string)' constructor instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary (string fileName)
			: base (NSObjectFlag.Empty)
		{
			if (fileName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fileName));
			var nsfileName = CFString.CreateNative (fileName);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithContentsOfFile_XHandle, nsfileName), "initWithContentsOfFile:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithContentsOfFile_XHandle, nsfileName), "initWithContentsOfFile:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfileName);
		}
		[Export ("initWithObjects:forKeys:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal NSDictionary (NSArray objects, NSArray keys)
			: base (NSObjectFlag.Empty)
		{
			var objects__handle__ = objects!.GetNonNullHandle (nameof (objects));
			var keys__handle__ = keys!.GetNonNullHandle (nameof (keys));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithObjects_ForKeys_XHandle, objects__handle__, keys__handle__), "initWithObjects:forKeys:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithObjects_ForKeys_XHandle, objects__handle__, keys__handle__), "initWithObjects:forKeys:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (objects);
			GC.KeepAlive (keys);
		}
		[Export ("initWithContentsOfURL:")]
		[ObsoletedOSPlatform ("macos10.15", "Use 'NSMutableDictionary(NSUrl)' constructor instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'NSMutableDictionary(NSUrl)' constructor instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'NSMutableDictionary(NSUrl)' constructor instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSMutableDictionary(NSUrl)' constructor instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSDictionary (NSUrl url)
			: base (NSObjectFlag.Empty)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithContentsOfURL_XHandle, url__handle__), "initWithContentsOfURL:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithContentsOfURL_XHandle, url__handle__), "initWithContentsOfURL:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
		}
		[Export ("initWithContentsOfURL:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe NSDictionary (NSUrl url, out NSError error)
			: base (NSObjectFlag.Empty)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selInitWithContentsOfURL_Error_XHandle, url__handle__, &errorValue), "initWithContentsOfURL:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selInitWithContentsOfURL_Error_XHandle, url__handle__, &errorValue), "initWithContentsOfURL:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeWithCoder_XHandle, encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeWithCoder_XHandle, encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[Export ("enumerateKeysAndObjectsUsingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Enumerate ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDictionaryEnumerator))]NSDictionaryEnumerator block)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			using var block_block = Trampolines.SDNSDictionaryEnumerator.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEnumerateKeysAndObjectsUsingBlock_XHandle, (IntPtr) block_ptr_block);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEnumerateKeysAndObjectsUsingBlock_XHandle, (IntPtr) block_ptr_block);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("enumerateKeysAndObjectsWithOptions:usingBlock:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Enumerate (NSEnumerationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDictionaryEnumerator))]NSDictionaryEnumerator block)
		{
			if (block is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (block));
			using var block_block = Trampolines.SDNSDictionaryEnumerator.CreateBlock (block);
			BlockLiteral *block_ptr_block = &block_block;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle (this.Handle, selEnumerateKeysAndObjectsWithOptions_UsingBlock_XHandle, (UIntPtr) (ulong) options, (IntPtr) block_ptr_block);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, selEnumerateKeysAndObjectsWithOptions_UsingBlock_XHandle, (UIntPtr) (ulong) options, (IntPtr) block_ptr_block);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("dictionaryWithDictionary:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary FromDictionary (NSDictionary source)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selDictionaryWithDictionary_XHandle, source__handle__), false)!;
			GC.KeepAlive (source);
			return ret!;
		}
		[Export ("dictionaryWithContentsOfFile:")]
		[ObsoletedOSPlatform ("macos10.15", "Use 'NSMutableDictionary.FromFile' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'NSMutableDictionary.FromFile' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'NSMutableDictionary.FromFile' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSMutableDictionary.FromFile' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary FromFile (string path)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selDictionaryWithContentsOfFile_XHandle, nspath), false)!;
			CFString.ReleaseNative (nspath);
			return ret!;
		}
		[Export ("dictionaryWithObject:forKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary FromObjectAndKey (NSObject obj, NSObject key)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selDictionaryWithObject_ForKey_XHandle, obj__handle__, key__handle__), false)!;
			GC.KeepAlive (obj);
			GC.KeepAlive (key);
			return ret!;
		}
		[Export ("dictionaryWithObjects:forKeys:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary FromObjectsAndKeysInternal (NSArray? objects, NSArray? keys, nint count)
		{
			var objects__handle__ = objects.GetHandle ();
			var keys__handle__ = keys.GetHandle ();
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr (class_ptr, selDictionaryWithObjects_ForKeys_Count_XHandle, objects__handle__, keys__handle__, count), false)!;
			GC.KeepAlive (objects);
			GC.KeepAlive (keys);
			return ret!;
		}
		[Export ("dictionaryWithObjects:forKeys:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary FromObjectsAndKeysInternal (NSArray objects, NSArray keys)
		{
			var objects__handle__ = objects!.GetNonNullHandle (nameof (objects));
			var keys__handle__ = keys!.GetNonNullHandle (nameof (keys));
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selDictionaryWithObjects_ForKeys_XHandle, objects__handle__, keys__handle__), false)!;
			GC.KeepAlive (objects);
			GC.KeepAlive (keys);
			return ret!;
		}
		[Export ("dictionaryWithContentsOfURL:")]
		[ObsoletedOSPlatform ("macos10.15", "Use 'NSMutableDictionary.FromUrl' instead.")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'NSMutableDictionary.FromUrl' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'NSMutableDictionary.FromUrl' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'NSMutableDictionary.FromUrl' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary FromUrl (NSUrl url)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NSDictionary? ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selDictionaryWithContentsOfURL_XHandle, url__handle__), false)!;
			GC.KeepAlive (url);
			return ret!;
		}
		[Export ("dictionaryWithContentsOfURL:error:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSDictionary<NSString, NSObject>? FromUrl (NSUrl url, out NSError error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			NSDictionary<NSString, NSObject>? ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSObject>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (class_ptr, selDictionaryWithContentsOfURL_Error_XHandle, url__handle__, &errorValue), false)!;
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("descriptionWithLocale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetDescription (NSObject? locale)
		{
			var locale__handle__ = locale.GetHandle ();
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDescriptionWithLocale_XHandle, locale__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDescriptionWithLocale_XHandle, locale__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (locale);
			return ret!;
		}
		[Export ("descriptionWithLocale:indent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetDescription (NSObject? locale, nuint level)
		{
			var locale__handle__ = locale.GetHandle ();
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selDescriptionWithLocale_Indent_XHandle, locale__handle__, level), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selDescriptionWithLocale_Indent_XHandle, locale__handle__, level), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (locale);
			return ret!;
		}
		[Export ("keysOfEntriesPassingTest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSSet GetKeys ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDictionaryKeyFilter))]NSDictionaryKeyFilter predicate)
		{
			if (predicate is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (predicate));
			using var block_predicate = Trampolines.SDNSDictionaryKeyFilter.CreateBlock (predicate);
			BlockLiteral *block_ptr_predicate = &block_predicate;
			NSSet ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selKeysOfEntriesPassingTest_XHandle, (IntPtr) block_ptr_predicate), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selKeysOfEntriesPassingTest_XHandle, (IntPtr) block_ptr_predicate), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("keysOfEntriesWithOptions:passingTest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSSet GetKeys (NSEnumerationOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSDictionaryKeyFilter))]NSDictionaryKeyFilter predicate)
		{
			if (predicate is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (predicate));
			using var block_predicate = Trampolines.SDNSDictionaryKeyFilter.CreateBlock (predicate);
			BlockLiteral *block_ptr_predicate = &block_predicate;
			NSSet ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle (this.Handle, selKeysOfEntriesWithOptions_PassingTest_XHandle, (UIntPtr) (ulong) options, (IntPtr) block_ptr_predicate), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, selKeysOfEntriesWithOptions_PassingTest_XHandle, (UIntPtr) (ulong) options, (IntPtr) block_ptr_predicate), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("keysSortedByValueUsingComparator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSObject[] GetKeysSortedByValue ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSComparator))]NSComparator comparator)
		{
			if (comparator is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (comparator));
			using var block_comparator = Trampolines.SDNSComparator.CreateBlock (comparator);
			BlockLiteral *block_ptr_comparator = &block_comparator;
			NSObject[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selKeysSortedByValueUsingComparator_XHandle, (IntPtr) block_ptr_comparator), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selKeysSortedByValueUsingComparator_XHandle, (IntPtr) block_ptr_comparator), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("keysSortedByValueWithOptions:usingComparator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSObject[] GetKeysSortedByValue (NSSortOptions options, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSComparator))]NSComparator comparator)
		{
			if (comparator is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (comparator));
			using var block_comparator = Trampolines.SDNSComparator.CreateBlock (comparator);
			BlockLiteral *block_ptr_comparator = &block_comparator;
			NSObject[] ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_NativeHandle (this.Handle, selKeysSortedByValueWithOptions_UsingComparator_XHandle, (UIntPtr) (ulong) options, (IntPtr) block_ptr_comparator), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, selKeysSortedByValueWithOptions_UsingComparator_XHandle, (UIntPtr) (ulong) options, (IntPtr) block_ptr_comparator), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("sharedKeySetForKeys:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject GetSharedKeySetForKeys (NSObject[] keys)
		{
			if (keys is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keys));
			using var nsa_keys = NSArray.FromNSObjects (keys);
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selSharedKeySetForKeys_XHandle, nsa_keys.Handle), false)!;
			return ret;
		}
		[Export ("isEqualToDictionary:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEqualToDictionary (NSDictionary other)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsEqualToDictionary_XHandle, other__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsEqualToDictionary_XHandle, other__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
			return ret != 0;
		}
		[Export ("allKeysForObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] KeysForObject (NSObject obj)
		{
			using (var autorelease_pool = new NSAutoreleasePool ()) {
				var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selAllKeysForObject_XHandle, obj__handle__), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selAllKeysForObject_XHandle, obj__handle__), false)!;
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (obj);
				return ret!;
			}
		}
		/// <param name="zone">Zone to use to allocate this object, or null to use the default zone.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("mutableCopyWithZone:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject MutableCopy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMutableCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMutableCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("objectForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? ObjectForKey (NSObject key)
		{
			var key__handle__ = key!.GetNonNullHandle (nameof (key));
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selObjectForKey_XHandle, key__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selObjectForKey_XHandle, key__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (key);
			return ret!;
		}
		[Export ("objectsForKeys:notFoundMarker:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] ObjectsForKeys (NSArray keys, NSObject marker)
		{
			using (var autorelease_pool = new NSAutoreleasePool ()) {
				var keys__handle__ = keys!.GetNonNullHandle (nameof (keys));
				var marker__handle__ = marker!.GetNonNullHandle (nameof (marker));
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selObjectsForKeys_NotFoundMarker_XHandle, keys__handle__, marker__handle__), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selObjectsForKeys_NotFoundMarker_XHandle, keys__handle__, marker__handle__), false)!;
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (keys);
				GC.KeepAlive (marker);
				return ret!;
			}
		}
		[Export ("valueForKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? ValueForKey (NSString key)
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
		[Export ("writeToFile:atomically:")]
		[ObsoletedOSPlatform ("macos10.15")]
		[ObsoletedOSPlatform ("ios13.0")]
		[ObsoletedOSPlatform ("tvos13.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteToFile (string path, bool useAuxiliaryFile)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_bool (this.Handle, selWriteToFile_Atomically_XHandle, nspath, useAuxiliaryFile ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selWriteToFile_Atomically_XHandle, nspath, useAuxiliaryFile ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nspath);
			return ret != 0;
		}
		[Export ("writeToURL:atomically:")]
		[ObsoletedOSPlatform ("macos10.15")]
		[ObsoletedOSPlatform ("ios13.0")]
		[ObsoletedOSPlatform ("tvos13.0")]
		[ObsoletedOSPlatform ("maccatalyst13.1")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WriteToUrl (NSUrl url, bool atomically)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_bool (this.Handle, selWriteToURL_Atomically_XHandle, url__handle__, atomically ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selWriteToURL_Atomically_XHandle, url__handle__, atomically ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			return ret != 0;
		}
		[Export ("writeToURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool WriteToUrl (NSUrl url, out NSError? error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selWriteToURL_Error_XHandle, url__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selWriteToURL_Error_XHandle, url__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal nint _AllKeys ()
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAllKeysXHandle);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal nint _AllKeysForObject (nint obj)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selAllKeysForObject_XHandle, obj);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal nint _AllValues ()
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAllValuesXHandle);
			return ret;
		}
		[Export ("dictionaryWithObjects:forKeys:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _FromObjectsAndKeysInternal (nint objects, nint keys, nint count)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selDictionaryWithObjects_ForKeys_Count_XHandle, objects, keys, count);
			return ret;
		}
		[Export ("dictionaryWithObjects:forKeys:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _FromObjectsAndKeysInternal (nint objects, nint keys)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selDictionaryWithObjects_ForKeys_XHandle, objects, keys);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal nint _ObjectForKey (nint key)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selObjectForKey_XHandle, key);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal nint _ObjectsForKeys (nint keys, nint marker)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selObjectsForKeys_NotFoundMarker_XHandle, keys, marker);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint Count {
			[Export ("count")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DescriptionInStringsFileFormat {
			[Export ("descriptionInStringsFileFormat")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDescriptionInStringsFileFormatXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDescriptionInStringsFileFormatXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSEnumerator KeyEnumerator {
			[Export ("keyEnumerator")]
			get {
				NSEnumerator? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selKeyEnumeratorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selKeyEnumeratorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] Keys {
			[Export ("allKeys")]
			get {
				using (var autorelease_pool = new NSAutoreleasePool ()) {
					NSObject[]? ret;
					if (IsDirectBinding) {
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAllKeysXHandle), false)!;
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAllKeysXHandle), false)!;
							GC.KeepAlive (this);
						}
					}
					return ret!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSEnumerator ObjectEnumerator {
			[Export ("objectEnumerator")]
			get {
				NSEnumerator? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selObjectEnumeratorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSEnumerator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selObjectEnumeratorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] Values {
			[Export ("allValues")]
			get {
				using (var autorelease_pool = new NSAutoreleasePool ()) {
					NSObject[]? ret;
					if (IsDirectBinding) {
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAllValuesXHandle), false)!;
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAllValuesXHandle), false)!;
							GC.KeepAlive (this);
						}
					}
					return ret!;
				}
			}
		}
	} /* class NSDictionary */
}
