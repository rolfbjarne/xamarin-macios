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
	[Register("NSAppleEventDescriptor", true)]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSAppleEventDescriptor : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributeDescriptorForKeyword_X = "attributeDescriptorForKeyword:";
		static readonly NativeHandle selAttributeDescriptorForKeyword_XHandle = Selector.GetHandle ("attributeDescriptorForKeyword:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBooleanValueX = "booleanValue";
		static readonly NativeHandle selBooleanValueXHandle = Selector.GetHandle ("booleanValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCurrentProcessDescriptorX = "currentProcessDescriptor";
		static readonly NativeHandle selCurrentProcessDescriptorXHandle = Selector.GetHandle ("currentProcessDescriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDataX = "data";
		static readonly NativeHandle selDataXHandle = Selector.GetHandle ("data");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDateValueX = "dateValue";
		static readonly NativeHandle selDateValueXHandle = Selector.GetHandle ("dateValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorAtIndex_X = "descriptorAtIndex:";
		static readonly NativeHandle selDescriptorAtIndex_XHandle = Selector.GetHandle ("descriptorAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorForKeyword_X = "descriptorForKeyword:";
		static readonly NativeHandle selDescriptorForKeyword_XHandle = Selector.GetHandle ("descriptorForKeyword:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithApplicationURL_X = "descriptorWithApplicationURL:";
		static readonly NativeHandle selDescriptorWithApplicationURL_XHandle = Selector.GetHandle ("descriptorWithApplicationURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithBoolean_X = "descriptorWithBoolean:";
		static readonly NativeHandle selDescriptorWithBoolean_XHandle = Selector.GetHandle ("descriptorWithBoolean:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithBundleIdentifier_X = "descriptorWithBundleIdentifier:";
		static readonly NativeHandle selDescriptorWithBundleIdentifier_XHandle = Selector.GetHandle ("descriptorWithBundleIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithDate_X = "descriptorWithDate:";
		static readonly NativeHandle selDescriptorWithDate_XHandle = Selector.GetHandle ("descriptorWithDate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithDouble_X = "descriptorWithDouble:";
		static readonly NativeHandle selDescriptorWithDouble_XHandle = Selector.GetHandle ("descriptorWithDouble:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithEnumCode_X = "descriptorWithEnumCode:";
		static readonly NativeHandle selDescriptorWithEnumCode_XHandle = Selector.GetHandle ("descriptorWithEnumCode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithFileURL_X = "descriptorWithFileURL:";
		static readonly NativeHandle selDescriptorWithFileURL_XHandle = Selector.GetHandle ("descriptorWithFileURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithInt32_X = "descriptorWithInt32:";
		static readonly NativeHandle selDescriptorWithInt32_XHandle = Selector.GetHandle ("descriptorWithInt32:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithProcessIdentifier_X = "descriptorWithProcessIdentifier:";
		static readonly NativeHandle selDescriptorWithProcessIdentifier_XHandle = Selector.GetHandle ("descriptorWithProcessIdentifier:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithString_X = "descriptorWithString:";
		static readonly NativeHandle selDescriptorWithString_XHandle = Selector.GetHandle ("descriptorWithString:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDescriptorWithTypeCode_X = "descriptorWithTypeCode:";
		static readonly NativeHandle selDescriptorWithTypeCode_XHandle = Selector.GetHandle ("descriptorWithTypeCode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDoubleValueX = "doubleValue";
		static readonly NativeHandle selDoubleValueXHandle = Selector.GetHandle ("doubleValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnumCodeValueX = "enumCodeValue";
		static readonly NativeHandle selEnumCodeValueXHandle = Selector.GetHandle ("enumCodeValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEventClassX = "eventClass";
		static readonly NativeHandle selEventClassXHandle = Selector.GetHandle ("eventClass");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEventIDX = "eventID";
		static readonly NativeHandle selEventIDXHandle = Selector.GetHandle ("eventID");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFileURLValueX = "fileURLValue";
		static readonly NativeHandle selFileURLValueXHandle = Selector.GetHandle ("fileURLValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitListDescriptorX = "initListDescriptor";
		static readonly NativeHandle selInitListDescriptorXHandle = Selector.GetHandle ("initListDescriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitRecordDescriptorX = "initRecordDescriptor";
		static readonly NativeHandle selInitRecordDescriptorXHandle = Selector.GetHandle ("initRecordDescriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertDescriptor_AtIndex_X = "insertDescriptor:atIndex:";
		static readonly NativeHandle selInsertDescriptor_AtIndex_XHandle = Selector.GetHandle ("insertDescriptor:atIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInt32ValueX = "int32Value";
		static readonly NativeHandle selInt32ValueXHandle = Selector.GetHandle ("int32Value");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsRecordDescriptorX = "isRecordDescriptor";
		static readonly NativeHandle selIsRecordDescriptorXHandle = Selector.GetHandle ("isRecordDescriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selKeywordForDescriptorAtIndex_X = "keywordForDescriptorAtIndex:";
		static readonly NativeHandle selKeywordForDescriptorAtIndex_XHandle = Selector.GetHandle ("keywordForDescriptorAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selListDescriptorX = "listDescriptor";
		static readonly NativeHandle selListDescriptorXHandle = Selector.GetHandle ("listDescriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNullDescriptorX = "nullDescriptor";
		static readonly NativeHandle selNullDescriptorXHandle = Selector.GetHandle ("nullDescriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfItemsX = "numberOfItems";
		static readonly NativeHandle selNumberOfItemsXHandle = Selector.GetHandle ("numberOfItems");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParamDescriptorForKeyword_X = "paramDescriptorForKeyword:";
		static readonly NativeHandle selParamDescriptorForKeyword_XHandle = Selector.GetHandle ("paramDescriptorForKeyword:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRecordDescriptorX = "recordDescriptor";
		static readonly NativeHandle selRecordDescriptorXHandle = Selector.GetHandle ("recordDescriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveDescriptorAtIndex_X = "removeDescriptorAtIndex:";
		static readonly NativeHandle selRemoveDescriptorAtIndex_XHandle = Selector.GetHandle ("removeDescriptorAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveDescriptorWithKeyword_X = "removeDescriptorWithKeyword:";
		static readonly NativeHandle selRemoveDescriptorWithKeyword_XHandle = Selector.GetHandle ("removeDescriptorWithKeyword:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveParamDescriptorWithKeyword_X = "removeParamDescriptorWithKeyword:";
		static readonly NativeHandle selRemoveParamDescriptorWithKeyword_XHandle = Selector.GetHandle ("removeParamDescriptorWithKeyword:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSendEventWithOptions_Timeout_Error_X = "sendEventWithOptions:timeout:error:";
		static readonly NativeHandle selSendEventWithOptions_Timeout_Error_XHandle = Selector.GetHandle ("sendEventWithOptions:timeout:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAttributeDescriptor_ForKeyword_X = "setAttributeDescriptor:forKeyword:";
		static readonly NativeHandle selSetAttributeDescriptor_ForKeyword_XHandle = Selector.GetHandle ("setAttributeDescriptor:forKeyword:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDescriptor_ForKeyword_X = "setDescriptor:forKeyword:";
		static readonly NativeHandle selSetDescriptor_ForKeyword_XHandle = Selector.GetHandle ("setDescriptor:forKeyword:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetParamDescriptor_ForKeyword_X = "setParamDescriptor:forKeyword:";
		static readonly NativeHandle selSetParamDescriptor_ForKeyword_XHandle = Selector.GetHandle ("setParamDescriptor:forKeyword:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStringValueX = "stringValue";
		static readonly NativeHandle selStringValueXHandle = Selector.GetHandle ("stringValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTypeCodeValueX = "typeCodeValue";
		static readonly NativeHandle selTypeCodeValueXHandle = Selector.GetHandle ("typeCodeValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSAppleEventDescriptor");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSAppleEventDescriptor" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSAppleEventDescriptor () : base (NSObjectFlag.Empty)
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
		public NSAppleEventDescriptor (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSAppleEventDescriptor (NSObjectFlag t) : base (t)
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
		protected internal NSAppleEventDescriptor (NativeHandle handle) : base (handle)
		{
		}

		[Export ("attributeDescriptorForKeyword:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAppleEventDescriptor? AttributeDescriptorForKeyword (uint keyword)
		{
			NSAppleEventDescriptor ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt32 (this.Handle, selAttributeDescriptorForKeyword_XHandle, keyword), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UInt32 (&__objc_super__, selAttributeDescriptorForKeyword_XHandle, keyword), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
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
		/// <param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("descriptorAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAppleEventDescriptor? DescriptorAtIndex (nint index)
		{
			NSAppleEventDescriptor ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selDescriptorAtIndex_XHandle, index), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selDescriptorAtIndex_XHandle, index), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("descriptorForKeyword:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAppleEventDescriptor? DescriptorForKeyword (uint keyword)
		{
			NSAppleEventDescriptor ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt32 (this.Handle, selDescriptorForKeyword_XHandle, keyword), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UInt32 (&__objc_super__, selDescriptorForKeyword_XHandle, keyword), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("descriptorWithBoolean:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAppleEventDescriptor DescriptorWithBoolean (bool boolean)
		{
			NSAppleEventDescriptor ret;
			ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool (class_ptr, selDescriptorWithBoolean_XHandle, boolean ? (byte) 1 : (byte) 0), false)!;
			return ret;
		}
		[Export ("descriptorWithEnumCode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAppleEventDescriptor DescriptorWithEnumCode (uint enumerator)
		{
			NSAppleEventDescriptor ret;
			ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt32 (class_ptr, selDescriptorWithEnumCode_XHandle, enumerator), false)!;
			return ret;
		}
		[Export ("descriptorWithInt32:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAppleEventDescriptor DescriptorWithInt32 (int signedInt)
		{
			NSAppleEventDescriptor ret;
			ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int (class_ptr, selDescriptorWithInt32_XHandle, signedInt), false)!;
			return ret;
		}
		[Export ("descriptorWithString:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAppleEventDescriptor DescriptorWithString (string str)
		{
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			var nsstr = CFString.CreateNative (str);
			NSAppleEventDescriptor? ret;
			ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selDescriptorWithString_XHandle, nsstr), false)!;
			CFString.ReleaseNative (nsstr);
			return ret!;
		}
		[Export ("descriptorWithTypeCode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAppleEventDescriptor DescriptorWithTypeCode (uint typeCode)
		{
			NSAppleEventDescriptor ret;
			ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt32 (class_ptr, selDescriptorWithTypeCode_XHandle, typeCode), false)!;
			return ret;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
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
		[Export ("enumCodeValue")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint EnumCodeValue ()
		{
			uint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selEnumCodeValueXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selEnumCodeValueXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("descriptorWithApplicationURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAppleEventDescriptor FromApplicationURL (NSUrl applicationURL)
		{
			var applicationURL__handle__ = applicationURL!.GetNonNullHandle (nameof (applicationURL));
			NSAppleEventDescriptor? ret;
			ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selDescriptorWithApplicationURL_XHandle, applicationURL__handle__), false)!;
			GC.KeepAlive (applicationURL);
			return ret!;
		}
		[Export ("descriptorWithBundleIdentifier:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAppleEventDescriptor FromBundleIdentifier (string bundleIdentifier)
		{
			if (bundleIdentifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (bundleIdentifier));
			var nsbundleIdentifier = CFString.CreateNative (bundleIdentifier);
			NSAppleEventDescriptor? ret;
			ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selDescriptorWithBundleIdentifier_XHandle, nsbundleIdentifier), false)!;
			CFString.ReleaseNative (nsbundleIdentifier);
			return ret!;
		}
		[Export ("descriptorWithDate:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAppleEventDescriptor FromDate (NSDate date)
		{
			var date__handle__ = date!.GetNonNullHandle (nameof (date));
			NSAppleEventDescriptor? ret;
			ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selDescriptorWithDate_XHandle, date__handle__), false)!;
			GC.KeepAlive (date);
			return ret!;
		}
		[Export ("descriptorWithDouble:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAppleEventDescriptor FromDouble (double doubleValue)
		{
			NSAppleEventDescriptor ret;
			ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_Double (class_ptr, selDescriptorWithDouble_XHandle, doubleValue), false)!;
			return ret;
		}
		[Export ("descriptorWithFileURL:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAppleEventDescriptor FromFileURL (NSUrl fileURL)
		{
			var fileURL__handle__ = fileURL!.GetNonNullHandle (nameof (fileURL));
			NSAppleEventDescriptor? ret;
			ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selDescriptorWithFileURL_XHandle, fileURL__handle__), false)!;
			GC.KeepAlive (fileURL);
			return ret!;
		}
		[Export ("descriptorWithProcessIdentifier:")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAppleEventDescriptor FromProcessIdentifier (int processIdentifier)
		{
			NSAppleEventDescriptor ret;
			ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int (class_ptr, selDescriptorWithProcessIdentifier_XHandle, processIdentifier), false)!;
			return ret;
		}
		/// <param name="descriptor">To be added.</param><param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("insertDescriptor:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertDescriptoratIndex (NSAppleEventDescriptor descriptor, nint index)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selInsertDescriptor_AtIndex_XHandle, descriptor__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selInsertDescriptor_AtIndex_XHandle, descriptor__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (descriptor);
		}
		/// <param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("keywordForDescriptorAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint KeywordForDescriptorAtIndex (nint index)
		{
			uint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend_IntPtr (this.Handle, selKeywordForDescriptorAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper_IntPtr (&__objc_super__, selKeywordForDescriptorAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("paramDescriptorForKeyword:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSAppleEventDescriptor? ParamDescriptorForKeyword (uint keyword)
		{
			NSAppleEventDescriptor ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt32 (this.Handle, selParamDescriptorForKeyword_XHandle, keyword), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UInt32 (&__objc_super__, selParamDescriptorForKeyword_XHandle, keyword), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="index">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeDescriptorAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveDescriptorAtIndex (nint index)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selRemoveDescriptorAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selRemoveDescriptorAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeDescriptorWithKeyword:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveDescriptorWithKeyword (uint keyword)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selRemoveDescriptorWithKeyword_XHandle, keyword);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (&__objc_super__, selRemoveDescriptorWithKeyword_XHandle, keyword);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeParamDescriptorWithKeyword:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveParamDescriptorWithKeyword (uint keyword)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selRemoveParamDescriptorWithKeyword_XHandle, keyword);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (&__objc_super__, selRemoveParamDescriptorWithKeyword_XHandle, keyword);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("sendEventWithOptions:timeout:error:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSAppleEventDescriptor? SendEvent (NSAppleEventSendOptions sendOptions, double timeoutInSeconds, out NSError? error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			NSAppleEventDescriptor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_Double_ref_NativeHandle (this.Handle, selSendEventWithOptions_Timeout_Error_XHandle, (UIntPtr) (ulong) sendOptions, timeoutInSeconds, &errorValue), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_Double_ref_NativeHandle (&__objc_super__, selSendEventWithOptions_Timeout_Error_XHandle, (UIntPtr) (ulong) sendOptions, timeoutInSeconds, &errorValue), false)!;
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("setAttributeDescriptor:forKeyword:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAttributeDescriptorforKeyword (NSAppleEventDescriptor descriptor, uint keyword)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt32 (this.Handle, selSetAttributeDescriptor_ForKeyword_XHandle, descriptor__handle__, keyword);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UInt32 (&__objc_super__, selSetAttributeDescriptor_ForKeyword_XHandle, descriptor__handle__, keyword);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (descriptor);
		}
		[Export ("setDescriptor:forKeyword:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDescriptorforKeyword (NSAppleEventDescriptor descriptor, uint keyword)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt32 (this.Handle, selSetDescriptor_ForKeyword_XHandle, descriptor__handle__, keyword);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UInt32 (&__objc_super__, selSetDescriptor_ForKeyword_XHandle, descriptor__handle__, keyword);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (descriptor);
		}
		[Export ("setParamDescriptor:forKeyword:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetParamDescriptorforKeyword (NSAppleEventDescriptor descriptor, uint keyword)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UInt32 (this.Handle, selSetParamDescriptor_ForKeyword_XHandle, descriptor__handle__, keyword);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UInt32 (&__objc_super__, selSetParamDescriptor_ForKeyword_XHandle, descriptor__handle__, keyword);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (descriptor);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal nint _InitListDescriptor ()
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selInitListDescriptorXHandle);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal nint _InitRecordDescriptor ()
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selInitRecordDescriptorXHandle);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool BooleanValue {
			[Export ("booleanValue")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selBooleanValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selBooleanValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public static NSAppleEventDescriptor CurrentProcessDescriptor {
			[Export ("currentProcessDescriptor")]
			get {
				NSAppleEventDescriptor? ret;
				ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selCurrentProcessDescriptorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData Data {
			[Export ("data")]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDataXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDataXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSDate? DateValue {
			[Export ("dateValue", ArgumentSemantic.Copy)]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDateValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDateValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual double DoubleValue {
			[Export ("doubleValue")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selDoubleValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selDoubleValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AEEventClass EventClass {
			[Export ("eventClass")]
			get {
				AEEventClass ret;
				if (IsDirectBinding) {
					ret = (AEEventClass) global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selEventClassXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AEEventClass) global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selEventClassXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AEEventID EventID {
			[Export ("eventID")]
			get {
				AEEventID ret;
				if (IsDirectBinding) {
					ret = (AEEventID) global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selEventIDXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (AEEventID) global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selEventIDXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual NSUrl? FileURLValue {
			[Export ("fileURLValue", ArgumentSemantic.Copy)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFileURLValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFileURLValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int Int32Value {
			[Export ("int32Value")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selInt32ValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selInt32ValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		public virtual bool IsRecordDescriptor {
			[Export ("isRecordDescriptor")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsRecordDescriptorXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsRecordDescriptorXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAppleEventDescriptor ListDescriptor {
			[Export ("listDescriptor")]
			get {
				NSAppleEventDescriptor? ret;
				ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selListDescriptorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAppleEventDescriptor NullDescriptor {
			[Export ("nullDescriptor")]
			get {
				NSAppleEventDescriptor? ret;
				ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selNullDescriptorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfItems {
			[Export ("numberOfItems")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selNumberOfItemsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfItemsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSAppleEventDescriptor RecordDescriptor {
			[Export ("recordDescriptor")]
			get {
				NSAppleEventDescriptor? ret;
				ret =  Runtime.GetNSObject<NSAppleEventDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (class_ptr, selRecordDescriptorXHandle), false)!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? StringValue {
			[Export ("stringValue")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStringValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStringValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint TypeCodeValue {
			[Export ("typeCodeValue")]
			get {
				uint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selTypeCodeValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selTypeCodeValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class NSAppleEventDescriptor */
}
