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
namespace AVFoundation {
	[Register("AVPlayerMediaSelectionCriteria", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AVPlayerMediaSelectionCriteria : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithPreferredLanguages_PreferredMediaCharacteristics_X = "initWithPreferredLanguages:preferredMediaCharacteristics:";
		static readonly NativeHandle selInitWithPreferredLanguages_PreferredMediaCharacteristics_XHandle = Selector.GetHandle ("initWithPreferredLanguages:preferredMediaCharacteristics:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithPrincipalMediaCharacteristics_PreferredLanguages_PreferredMediaCharacteristics_X = "initWithPrincipalMediaCharacteristics:preferredLanguages:preferredMediaCharacteristics:";
		static readonly NativeHandle selInitWithPrincipalMediaCharacteristics_PreferredLanguages_PreferredMediaCharacteristics_XHandle = Selector.GetHandle ("initWithPrincipalMediaCharacteristics:preferredLanguages:preferredMediaCharacteristics:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredLanguagesX = "preferredLanguages";
		static readonly NativeHandle selPreferredLanguagesXHandle = Selector.GetHandle ("preferredLanguages");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredMediaCharacteristicsX = "preferredMediaCharacteristics";
		static readonly NativeHandle selPreferredMediaCharacteristicsXHandle = Selector.GetHandle ("preferredMediaCharacteristics");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrincipalMediaCharacteristicsX = "principalMediaCharacteristics";
		static readonly NativeHandle selPrincipalMediaCharacteristicsXHandle = Selector.GetHandle ("principalMediaCharacteristics");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AVPlayerMediaSelectionCriteria");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="AVPlayerMediaSelectionCriteria" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AVPlayerMediaSelectionCriteria () : base (NSObjectFlag.Empty)
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
		protected AVPlayerMediaSelectionCriteria (NSObjectFlag t) : base (t)
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
		protected internal AVPlayerMediaSelectionCriteria (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithPreferredLanguages:preferredMediaCharacteristics:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVPlayerMediaSelectionCriteria (string[]? preferredLanguages, NSString[]? preferredMediaCharacteristics)
			: base (NSObjectFlag.Empty)
		{
			using var nsa_preferredLanguages = NSArray.FromNullableStrings (preferredLanguages);
			using var nsa_preferredMediaCharacteristics = preferredMediaCharacteristics is null ? null : NSArray.FromNSObjects (preferredMediaCharacteristics);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithPreferredLanguages_PreferredMediaCharacteristics_XHandle, nsa_preferredLanguages.GetHandle (), nsa_preferredMediaCharacteristics.GetHandle ()), "initWithPreferredLanguages:preferredMediaCharacteristics:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithPreferredLanguages_PreferredMediaCharacteristics_XHandle, nsa_preferredLanguages.GetHandle (), nsa_preferredMediaCharacteristics.GetHandle ()), "initWithPreferredLanguages:preferredMediaCharacteristics:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithPrincipalMediaCharacteristics:preferredLanguages:preferredMediaCharacteristics:")]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public AVPlayerMediaSelectionCriteria ([BindAs (typeof (AVMediaCharacteristics[]), OriginalType = typeof (NSString[]))] global::AVFoundation.AVMediaCharacteristics[]? principalMediaCharacteristics, [BindAs (typeof (AVMediaCharacteristics[]), OriginalType = typeof (NSString[]))] global::AVFoundation.AVMediaCharacteristics[]? preferredLanguages, string[]? preferredMediaCharacteristics)
			: base (NSObjectFlag.Empty)
		{
			using var nsb_principalMediaCharacteristics = NSArray.FromNSObjects (o => global::AVFoundation.AVMediaCharacteristicsExtensions.GetConstant (o), principalMediaCharacteristics);
			using var nsb_preferredLanguages = NSArray.FromNSObjects (o => global::AVFoundation.AVMediaCharacteristicsExtensions.GetConstant (o), preferredLanguages);
			using var nsa_preferredMediaCharacteristics = NSArray.FromNullableStrings (preferredMediaCharacteristics);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithPrincipalMediaCharacteristics_PreferredLanguages_PreferredMediaCharacteristics_XHandle, nsb_principalMediaCharacteristics.GetHandle (), nsb_preferredLanguages.GetHandle (), nsa_preferredMediaCharacteristics.GetHandle ()), "initWithPrincipalMediaCharacteristics:preferredLanguages:preferredMediaCharacteristics:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithPrincipalMediaCharacteristics_PreferredLanguages_PreferredMediaCharacteristics_XHandle, nsb_principalMediaCharacteristics.GetHandle (), nsb_preferredLanguages.GetHandle (), nsa_preferredMediaCharacteristics.GetHandle ()), "initWithPrincipalMediaCharacteristics:preferredLanguages:preferredMediaCharacteristics:");
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[]? PreferredLanguages {
			[Export ("preferredLanguages")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreferredLanguagesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreferredLanguagesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString[]? PreferredMediaCharacteristics {
			[Export ("preferredMediaCharacteristics")]
			get {
				NSString[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreferredMediaCharacteristicsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSString>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreferredMediaCharacteristicsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindAs (typeof (AVMediaCharacteristics[]), OriginalType = typeof (NSString[]))]
		public virtual global::AVFoundation.AVMediaCharacteristics[]? PrincipalMediaCharacteristics {
			[Export ("principalMediaCharacteristics")]
			get {
				global::AVFoundation.AVMediaCharacteristics[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandleFunc <global::AVFoundation.AVMediaCharacteristics> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPrincipalMediaCharacteristicsXHandle), global::AVFoundation.AVMediaCharacteristicsExtensions.GetValue , false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = NSArray.ArrayFromHandleFunc <global::AVFoundation.AVMediaCharacteristics> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPrincipalMediaCharacteristicsXHandle), global::AVFoundation.AVMediaCharacteristicsExtensions.GetValue , false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class AVPlayerMediaSelectionCriteria */
}
