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
namespace AppKit {
	[Register("NSMutableFontCollection", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSMutableFontCollection : NSFontCollection {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddQueryForDescriptors_X = "addQueryForDescriptors:";
		static readonly NativeHandle selAddQueryForDescriptors_XHandle = Selector.GetHandle ("addQueryForDescriptors:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontCollectionWithAllAvailableDescriptorsX = "fontCollectionWithAllAvailableDescriptors";
		static readonly NativeHandle selFontCollectionWithAllAvailableDescriptorsXHandle = Selector.GetHandle ("fontCollectionWithAllAvailableDescriptors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontCollectionWithDescriptors_X = "fontCollectionWithDescriptors:";
		static readonly NativeHandle selFontCollectionWithDescriptors_XHandle = Selector.GetHandle ("fontCollectionWithDescriptors:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontCollectionWithLocale_X = "fontCollectionWithLocale:";
		static readonly NativeHandle selFontCollectionWithLocale_XHandle = Selector.GetHandle ("fontCollectionWithLocale:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontCollectionWithName_X = "fontCollectionWithName:";
		static readonly NativeHandle selFontCollectionWithName_XHandle = Selector.GetHandle ("fontCollectionWithName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFontCollectionWithName_Visibility_X = "fontCollectionWithName:visibility:";
		static readonly NativeHandle selFontCollectionWithName_Visibility_XHandle = Selector.GetHandle ("fontCollectionWithName:visibility:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveQueryForDescriptors_X = "removeQueryForDescriptors:";
		static readonly NativeHandle selRemoveQueryForDescriptors_XHandle = Selector.GetHandle ("removeQueryForDescriptors:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetExclusionDescriptors_X = "setExclusionDescriptors:";
		static readonly NativeHandle selSetExclusionDescriptors_XHandle = Selector.GetHandle ("setExclusionDescriptors:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetQueryDescriptors_X = "setQueryDescriptors:";
		static readonly NativeHandle selSetQueryDescriptors_XHandle = Selector.GetHandle ("setQueryDescriptors:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSMutableFontCollection");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		public NSMutableFontCollection (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		protected NSMutableFontCollection (NSObjectFlag t) : base (t)
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
		protected internal NSMutableFontCollection (NativeHandle handle) : base (handle)
		{
		}

		[Export ("addQueryForDescriptors:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddQueryForDescriptors (NSFontDescriptor[] descriptors)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (descriptors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (descriptors));
			using var nsa_descriptors = NSArray.FromNSObjects (descriptors);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddQueryForDescriptors_XHandle, nsa_descriptors.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddQueryForDescriptors_XHandle, nsa_descriptors.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("fontCollectionWithDescriptors:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSMutableFontCollection FromDescriptors (NSFontDescriptor[] queryDescriptors)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (queryDescriptors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (queryDescriptors));
			using var nsa_queryDescriptors = NSArray.FromNSObjects (queryDescriptors);
			NSMutableFontCollection ret;
			ret =  Runtime.GetNSObject<NSMutableFontCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selFontCollectionWithDescriptors_XHandle, nsa_queryDescriptors.Handle), false)!;
			return ret;
		}
		[Export ("fontCollectionWithLocale:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSMutableFontCollection FromLocale (NSLocale locale)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var locale__handle__ = locale!.GetNonNullHandle (nameof (locale));
			NSMutableFontCollection? ret;
			ret =  Runtime.GetNSObject<NSMutableFontCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selFontCollectionWithLocale_XHandle, locale__handle__), false)!;
			GC.KeepAlive (locale);
			return ret!;
		}
		[Export ("fontCollectionWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSMutableFontCollection FromName (string name)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			NSMutableFontCollection? ret;
			ret =  Runtime.GetNSObject<NSMutableFontCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selFontCollectionWithName_XHandle, nsname), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("fontCollectionWithName:visibility:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSMutableFontCollection FromName (string name, NSFontCollectionVisibility visibility)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			NSMutableFontCollection? ret;
			ret =  Runtime.GetNSObject<NSMutableFontCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (class_ptr, selFontCollectionWithName_Visibility_XHandle, nsname, (UIntPtr) (ulong) visibility), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("fontCollectionWithAllAvailableDescriptors")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSMutableFontCollection GetAllAvailableFonts ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSMutableFontCollection ret;
			ret =  Runtime.GetNSObject<NSMutableFontCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selFontCollectionWithAllAvailableDescriptorsXHandle), false)!;
			return ret;
		}
		[Export ("removeQueryForDescriptors:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveQueryForDescriptors (NSFontDescriptor[] descriptors)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (descriptors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (descriptors));
			using var nsa_descriptors = NSArray.FromNSObjects (descriptors);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveQueryForDescriptors_XHandle, nsa_descriptors.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveQueryForDescriptors_XHandle, nsa_descriptors.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="descriptors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setExclusionDescriptors:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetExclusionDescriptors (NSFontDescriptor[] descriptors)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (descriptors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (descriptors));
			using var nsa_descriptors = NSArray.FromNSObjects (descriptors);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetExclusionDescriptors_XHandle, nsa_descriptors.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetExclusionDescriptors_XHandle, nsa_descriptors.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="descriptors">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setQueryDescriptors:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetQueryDescriptors (NSFontDescriptor[] descriptors)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (descriptors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (descriptors));
			using var nsa_descriptors = NSArray.FromNSObjects (descriptors);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetQueryDescriptors_XHandle, nsa_descriptors.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetQueryDescriptors_XHandle, nsa_descriptors.Handle);
					GC.KeepAlive (this);
				}
			}
		}
	} /* class NSMutableFontCollection */
}
