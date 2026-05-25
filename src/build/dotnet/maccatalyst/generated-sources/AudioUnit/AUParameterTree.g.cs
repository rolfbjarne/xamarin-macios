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
namespace AudioUnit {
	/// <summary>A tree that contains all of the audio unit parameters for an audio unit.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/AudioUnit/Reference/AUParameterTree_ClassReference/index.html">Apple documentation for <c>AUParameterTree</c></related>
	[Register("AUParameterTree", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class AUParameterTree : AUParameterGroup, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("AUParameterTree");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="AUParameterTree" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AUParameterTree () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
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
		public AUParameterTree (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
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
		protected AUParameterTree (NSObjectFlag t) : base (t)
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
		protected internal AUParameterTree (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="identifier">A permanent non-localized name for the group.</param><param name="name">A localized display name.</param><param name="children">The array of parameter nodes that will become the group's children.</param><summary>Creates a parameter group with the specified <paramref name="identifier" />, <paramref name="name" />, and <paramref name="children" />.</summary><returns>A new parameter group.</returns><remarks>To be added.</remarks>
		[Export ("createGroupWithIdentifier:name:children:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AUParameterGroup CreateGroup (string identifier, string name, AUParameterNode[] children)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			if (children is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (children));
			var nsidentifier = CFString.CreateNative (identifier);
			var nsname = CFString.CreateNative (name);
			using var nsa_children = NSArray.FromNSObjects (children);
			AUParameterGroup? ret;
			ret =  Runtime.GetNSObject<AUParameterGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("createGroupWithIdentifier:name:children:"), nsidentifier, nsname, nsa_children.Handle), false)!;
			CFString.ReleaseNative (nsidentifier);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		/// <param name="templateGroup">The parameter group to copy.</param><param name="identifier">A permanent non-localized name for the new group.</param><param name="name">A localized display name for the new group.</param><param name="addressOffset">The offset, relative to the template group, of the new group's parameters.</param><summary>Copies a template parameter group and sets the <paramref name="identifier" />, <paramref name="name" />, and template-group-relative <paramref name="addressOffset" />.</summary><returns>The copied parameter group.</returns><remarks>To be added.</remarks>
		[Export ("createGroupFromTemplate:identifier:name:addressOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AUParameterGroup CreateGroup (AUParameterGroup templateGroup, string identifier, string name, ulong addressOffset)
		{
			var templateGroup__handle__ = templateGroup!.GetNonNullHandle (nameof (templateGroup));
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsidentifier = CFString.CreateNative (identifier);
			var nsname = CFString.CreateNative (name);
			AUParameterGroup? ret;
			ret =  Runtime.GetNSObject<AUParameterGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UInt64 (class_ptr, Selector.GetHandle ("createGroupFromTemplate:identifier:name:addressOffset:"), templateGroup__handle__, nsidentifier, nsname, addressOffset), false)!;
			GC.KeepAlive (templateGroup);
			CFString.ReleaseNative (nsidentifier);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		/// <param name="children">The template group's children.</param><summary>Creates a prototype parameter group for creating related classes of parameter groups.</summary><returns>A prototype parameter group for creating related classes of parameter groups.</returns><remarks>Template parameter groups can only appear in trees at the root.</remarks>
		[Export ("createGroupTemplate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AUParameterGroup CreateGroupTemplate (AUParameterNode[] children)
		{
			if (children is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (children));
			using var nsa_children = NSArray.FromNSObjects (children);
			AUParameterGroup ret;
			ret =  Runtime.GetNSObject<AUParameterGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("createGroupTemplate:"), nsa_children.Handle), false)!;
			return ret;
		}
		/// <param name="identifier">A permanent non-localized name for the parameter.</param><param name="name">A localized display name.</param><param name="address">The address of the parameter.</param><param name="min">The minimum allowed value of the parameter.</param><param name="max">The maximum allowed value of the parameter.</param><param name="unit">The unit of measurement in which the parameter is expressed.</param><param name="unitName"><para>The localized name of the parameter.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="flags">The parameter options for the parameter.</param><param name="valueStrings"><para>The localized value strings for the parameter.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="dependentParameters"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a new parameter with the specified values.</summary><returns>A new parameter that was created with the specified values.</returns><remarks>To be added.</remarks>
		[Export ("createParameterWithIdentifier:name:address:min:max:unit:unitName:flags:valueStrings:dependentParameters:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AUParameter CreateParameter (string identifier, string name, ulong address, float min, float max, AudioUnitParameterUnit unit, string? unitName, AudioUnitParameterOptions flags, string[]? valueStrings, NSNumber[]? dependentParameters)
		{
			if (identifier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (identifier));
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsidentifier = CFString.CreateNative (identifier);
			var nsname = CFString.CreateNative (name);
			var nsunitName = CFString.CreateNative (unitName);
			using var nsa_valueStrings = NSArray.FromNullableStrings (valueStrings);
			using var nsa_dependentParameters = dependentParameters is null ? null : NSArray.FromNSObjects (dependentParameters);
			AUParameter? ret;
			ret =  Runtime.GetNSObject<AUParameter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UInt64_float_float_int_NativeHandle_UInt32_NativeHandle_NativeHandle (class_ptr, Selector.GetHandle ("createParameterWithIdentifier:name:address:min:max:unit:unitName:flags:valueStrings:dependentParameters:"), nsidentifier, nsname, address, min, max, (int)unit, nsunitName, (UInt32)flags, nsa_valueStrings.GetHandle (), nsa_dependentParameters.GetHandle ()), false)!;
			CFString.ReleaseNative (nsidentifier);
			CFString.ReleaseNative (nsname);
			CFString.ReleaseNative (nsunitName);
			return ret!;
		}
		/// <param name="children">The children of the new tree.</param><summary>Creates a new parameter tree.</summary><returns>A new parameter tree.</returns><remarks>To be added.</remarks>
		[Export ("createTreeWithChildren:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static AUParameterTree CreateTree (AUParameterNode[] children)
		{
			if (children is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (children));
			using var nsa_children = NSArray.FromNSObjects (children);
			AUParameterTree ret;
			ret =  Runtime.GetNSObject<AUParameterTree> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("createTreeWithChildren:"), nsa_children.Handle), false)!;
			return ret;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		/// <param name="address">The address of the parameter to get.</param><summary>Gets the parameter at the specified address.</summary><returns>The parameter at the specified address.</returns><remarks>To be added.</remarks>
		[Export ("parameterWithAddress:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AUParameter? GetParameter (ulong address)
		{
			AUParameter ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AUParameter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("parameterWithAddress:"), address), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<AUParameter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UInt64 (&__objc_super__, Selector.GetHandle ("parameterWithAddress:"), address), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="paramID">The parameter ID search parameter.</param><param name="scope">The scope search parameter.</param><param name="element">The element search parameter..</param><summary>Gets the parameter at the specified <paramref name="paramID" />, in the specified <paramref name="scope" />, that corresponds to the specified <paramref name="element" />.</summary><returns>The matching parameter, or <see langword="null" /> if no such parameter exists.</returns><remarks>To be added.</remarks>
		[Export ("parameterWithID:scope:element:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual AUParameter? GetParameter (uint paramID, uint scope, uint element)
		{
			AUParameter ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<AUParameter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UInt32_UInt32_UInt32 (this.Handle, Selector.GetHandle ("parameterWithID:scope:element:"), paramID, scope, element), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<AUParameter> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UInt32_UInt32_UInt32 (&__objc_super__, Selector.GetHandle ("parameterWithID:scope:element:"), paramID, scope, element), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
	} /* class AUParameterTree */
}
