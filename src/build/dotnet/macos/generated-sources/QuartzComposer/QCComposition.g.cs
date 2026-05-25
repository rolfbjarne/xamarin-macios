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
namespace QuartzComposer {
	[Register("QCComposition", true)]
	[ObsoletedOSPlatform ("macos10.15")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class QCComposition : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributesX = "attributes";
		static readonly NativeHandle selAttributesXHandle = Selector.GetHandle ("attributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompositionWithData_X = "compositionWithData:";
		static readonly NativeHandle selCompositionWithData_XHandle = Selector.GetHandle ("compositionWithData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompositionWithFile_X = "compositionWithFile:";
		static readonly NativeHandle selCompositionWithFile_XHandle = Selector.GetHandle ("compositionWithFile:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIdentifierX = "identifier";
		static readonly NativeHandle selIdentifierXHandle = Selector.GetHandle ("identifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInputKeysX = "inputKeys";
		static readonly NativeHandle selInputKeysXHandle = Selector.GetHandle ("inputKeys");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOutputKeysX = "outputKeys";
		static readonly NativeHandle selOutputKeysXHandle = Selector.GetHandle ("outputKeys");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selProtocolsX = "protocols";
		static readonly NativeHandle selProtocolsXHandle = Selector.GetHandle ("protocols");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("QCComposition");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="QCComposition" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QCComposition () : base (NSObjectFlag.Empty)
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
		protected QCComposition (NSObjectFlag t) : base (t)
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
		protected internal QCComposition (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[ObsoletedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
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
		/// <param name="path">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("compositionWithFile:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static QCComposition GetComposition (string path)
		{
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			QCComposition? ret;
			ret =  Runtime.GetNSObject<QCComposition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selCompositionWithFile_XHandle, nspath), false)!;
			CFString.ReleaseNative (nspath);
			return ret!;
		}
		/// <param name="data">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("compositionWithData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static QCComposition GetComposition (NSData data)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			QCComposition? ret;
			ret =  Runtime.GetNSObject<QCComposition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selCompositionWithData_XHandle, data__handle__), false)!;
			GC.KeepAlive (data);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary Attributes {
			[Export ("attributes")]
			get {
				NSDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAttributesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAttributesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Identifier {
			[Export ("identifier")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selIdentifierXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selIdentifierXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] InputKeys {
			[Export ("inputKeys")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInputKeysXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInputKeysXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] OutputKeys {
			[Export ("outputKeys")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOutputKeysXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOutputKeysXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] Protocols {
			[Export ("protocols")]
			get {
				string[] ret;
				if (IsDirectBinding) {
					ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selProtocolsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.StringArrayFromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selProtocolsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AttributeBuiltInKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionAttributeBuiltInKey",  "QuartzComposer")]
		public static NSString AttributeBuiltInKey {
			get {
				if (_AttributeBuiltInKey is null)
					_AttributeBuiltInKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionAttributeBuiltInKey")!;
				return _AttributeBuiltInKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AttributeCategoryKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionAttributeCategoryKey",  "QuartzComposer")]
		public static NSString AttributeCategoryKey {
			get {
				if (_AttributeCategoryKey is null)
					_AttributeCategoryKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionAttributeCategoryKey")!;
				return _AttributeCategoryKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AttributeCopyrightKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionAttributeCopyrightKey",  "QuartzComposer")]
		public static NSString AttributeCopyrightKey {
			get {
				if (_AttributeCopyrightKey is null)
					_AttributeCopyrightKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionAttributeCopyrightKey")!;
				return _AttributeCopyrightKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AttributeDescriptionKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionAttributeDescriptionKey",  "QuartzComposer")]
		public static NSString AttributeDescriptionKey {
			get {
				if (_AttributeDescriptionKey is null)
					_AttributeDescriptionKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionAttributeDescriptionKey")!;
				return _AttributeDescriptionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AttributeHasConsumersKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionAttributeHasConsumersKey",  "QuartzComposer")]
		public static NSString AttributeHasConsumersKey {
			get {
				if (_AttributeHasConsumersKey is null)
					_AttributeHasConsumersKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionAttributeHasConsumersKey")!;
				return _AttributeHasConsumersKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AttributeIsTimeDependentKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionAttributeIsTimeDependentKey",  "QuartzComposer")]
		public static NSString AttributeIsTimeDependentKey {
			get {
				if (_AttributeIsTimeDependentKey is null)
					_AttributeIsTimeDependentKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionAttributeIsTimeDependentKey")!;
				return _AttributeIsTimeDependentKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AttributeNameKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionAttributeNameKey",  "QuartzComposer")]
		public static NSString AttributeNameKey {
			get {
				if (_AttributeNameKey is null)
					_AttributeNameKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionAttributeNameKey")!;
				return _AttributeNameKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CategoryDistortion;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionCategoryDistortion",  "QuartzComposer")]
		public static NSString CategoryDistortion {
			get {
				if (_CategoryDistortion is null)
					_CategoryDistortion = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionCategoryDistortion")!;
				return _CategoryDistortion;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CategoryStylize;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionCategoryStylize",  "QuartzComposer")]
		public static NSString CategoryStylize {
			get {
				if (_CategoryStylize is null)
					_CategoryStylize = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionCategoryStylize")!;
				return _CategoryStylize;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CategoryUtility;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionCategoryUtility",  "QuartzComposer")]
		public static NSString CategoryUtility {
			get {
				if (_CategoryUtility is null)
					_CategoryUtility = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionCategoryUtility")!;
				return _CategoryUtility;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InputAudioPeakKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionInputAudioPeakKey",  "QuartzComposer")]
		public static NSString InputAudioPeakKey {
			get {
				if (_InputAudioPeakKey is null)
					_InputAudioPeakKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionInputAudioPeakKey")!;
				return _InputAudioPeakKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InputAudioSpectrumKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionInputAudioSpectrumKey",  "QuartzComposer")]
		public static NSString InputAudioSpectrumKey {
			get {
				if (_InputAudioSpectrumKey is null)
					_InputAudioSpectrumKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionInputAudioSpectrumKey")!;
				return _InputAudioSpectrumKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InputDestinationImageKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionInputDestinationImageKey",  "QuartzComposer")]
		public static NSString InputDestinationImageKey {
			get {
				if (_InputDestinationImageKey is null)
					_InputDestinationImageKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionInputDestinationImageKey")!;
				return _InputDestinationImageKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InputImageKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionInputImageKey",  "QuartzComposer")]
		public static NSString InputImageKey {
			get {
				if (_InputImageKey is null)
					_InputImageKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionInputImageKey")!;
				return _InputImageKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InputPaceKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionInputPaceKey",  "QuartzComposer")]
		public static NSString InputPaceKey {
			get {
				if (_InputPaceKey is null)
					_InputPaceKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionInputPaceKey")!;
				return _InputPaceKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InputPreviewModeKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionInputPreviewModeKey",  "QuartzComposer")]
		public static NSString InputPreviewModeKey {
			get {
				if (_InputPreviewModeKey is null)
					_InputPreviewModeKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionInputPreviewModeKey")!;
				return _InputPreviewModeKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InputPrimaryColorKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionInputPrimaryColorKey",  "QuartzComposer")]
		public static NSString InputPrimaryColorKey {
			get {
				if (_InputPrimaryColorKey is null)
					_InputPrimaryColorKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionInputPrimaryColorKey")!;
				return _InputPrimaryColorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InputScreenImageKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionInputScreenImageKey",  "QuartzComposer")]
		public static NSString InputScreenImageKey {
			get {
				if (_InputScreenImageKey is null)
					_InputScreenImageKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionInputScreenImageKey")!;
				return _InputScreenImageKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InputSecondaryColorKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionInputSecondaryColorKey",  "QuartzComposer")]
		public static NSString InputSecondaryColorKey {
			get {
				if (_InputSecondaryColorKey is null)
					_InputSecondaryColorKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionInputSecondaryColorKey")!;
				return _InputSecondaryColorKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InputSourceImageKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionInputSourceImageKey",  "QuartzComposer")]
		public static NSString InputSourceImageKey {
			get {
				if (_InputSourceImageKey is null)
					_InputSourceImageKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionInputSourceImageKey")!;
				return _InputSourceImageKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InputTrackInfoKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionInputTrackInfoKey",  "QuartzComposer")]
		public static NSString InputTrackInfoKey {
			get {
				if (_InputTrackInfoKey is null)
					_InputTrackInfoKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionInputTrackInfoKey")!;
				return _InputTrackInfoKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InputTrackPositionKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionInputTrackPositionKey",  "QuartzComposer")]
		public static NSString InputTrackPositionKey {
			get {
				if (_InputTrackPositionKey is null)
					_InputTrackPositionKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionInputTrackPositionKey")!;
				return _InputTrackPositionKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InputTrackSignalKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionInputTrackSignalKey",  "QuartzComposer")]
		public static NSString InputTrackSignalKey {
			get {
				if (_InputTrackSignalKey is null)
					_InputTrackSignalKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionInputTrackSignalKey")!;
				return _InputTrackSignalKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InputXKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionInputXKey",  "QuartzComposer")]
		public static NSString InputXKey {
			get {
				if (_InputXKey is null)
					_InputXKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionInputXKey")!;
				return _InputXKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InputYKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionInputYKey",  "QuartzComposer")]
		public static NSString InputYKey {
			get {
				if (_InputYKey is null)
					_InputYKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionInputYKey")!;
				return _InputYKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OutputImageKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionOutputImageKey",  "QuartzComposer")]
		public static NSString OutputImageKey {
			get {
				if (_OutputImageKey is null)
					_OutputImageKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionOutputImageKey")!;
				return _OutputImageKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OutputWebPageURLKey;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionOutputWebPageURLKey",  "QuartzComposer")]
		public static NSString OutputWebPageURLKey {
			get {
				if (_OutputWebPageURLKey is null)
					_OutputWebPageURLKey = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionOutputWebPageURLKey")!;
				return _OutputWebPageURLKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProtocolGraphicAnimation;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionProtocolGraphicAnimation",  "QuartzComposer")]
		public static NSString ProtocolGraphicAnimation {
			get {
				if (_ProtocolGraphicAnimation is null)
					_ProtocolGraphicAnimation = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionProtocolGraphicAnimation")!;
				return _ProtocolGraphicAnimation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProtocolGraphicTransition;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionProtocolGraphicTransition",  "QuartzComposer")]
		public static NSString ProtocolGraphicTransition {
			get {
				if (_ProtocolGraphicTransition is null)
					_ProtocolGraphicTransition = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionProtocolGraphicTransition")!;
				return _ProtocolGraphicTransition;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProtocolImageFilter;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionProtocolImageFilter",  "QuartzComposer")]
		public static NSString ProtocolImageFilter {
			get {
				if (_ProtocolImageFilter is null)
					_ProtocolImageFilter = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionProtocolImageFilter")!;
				return _ProtocolImageFilter;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProtocolMusicVisualizer;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionProtocolMusicVisualizer",  "QuartzComposer")]
		public static NSString ProtocolMusicVisualizer {
			get {
				if (_ProtocolMusicVisualizer is null)
					_ProtocolMusicVisualizer = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionProtocolMusicVisualizer")!;
				return _ProtocolMusicVisualizer;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ProtocolScreenSaver;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("QCCompositionProtocolScreenSaver",  "QuartzComposer")]
		public static NSString ProtocolScreenSaver {
			get {
				if (_ProtocolScreenSaver is null)
					_ProtocolScreenSaver = Dlfcn.GetStringConstant (Libraries.QuartzComposer.Handle, "QCCompositionProtocolScreenSaver")!;
				return _ProtocolScreenSaver;
			}
		}
	} /* class QCComposition */
}
