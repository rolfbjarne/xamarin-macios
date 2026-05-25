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
	[Register("NSPredicateEditorRowTemplate", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSPredicateEditorRowTemplate : NSObject, INSCoding, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompoundTypesX = "compoundTypes";
		static readonly NativeHandle selCompoundTypesXHandle = Selector.GetHandle ("compoundTypes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDisplayableSubpredicatesOfPredicate_X = "displayableSubpredicatesOfPredicate:";
		static readonly NativeHandle selDisplayableSubpredicatesOfPredicate_XHandle = Selector.GetHandle ("displayableSubpredicatesOfPredicate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCompoundTypes_X = "initWithCompoundTypes:";
		static readonly NativeHandle selInitWithCompoundTypes_XHandle = Selector.GetHandle ("initWithCompoundTypes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithLeftExpressions_RightExpressionAttributeType_Modifier_Operators_Options_X = "initWithLeftExpressions:rightExpressionAttributeType:modifier:operators:options:";
		static readonly NativeHandle selInitWithLeftExpressions_RightExpressionAttributeType_Modifier_Operators_Options_XHandle = Selector.GetHandle ("initWithLeftExpressions:rightExpressionAttributeType:modifier:operators:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithLeftExpressions_RightExpressions_Modifier_Operators_Options_X = "initWithLeftExpressions:rightExpressions:modifier:operators:options:";
		static readonly NativeHandle selInitWithLeftExpressions_RightExpressions_Modifier_Operators_Options_XHandle = Selector.GetHandle ("initWithLeftExpressions:rightExpressions:modifier:operators:options:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLeftExpressionsX = "leftExpressions";
		static readonly NativeHandle selLeftExpressionsXHandle = Selector.GetHandle ("leftExpressions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatchForPredicate_X = "matchForPredicate:";
		static readonly NativeHandle selMatchForPredicate_XHandle = Selector.GetHandle ("matchForPredicate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selModifierX = "modifier";
		static readonly NativeHandle selModifierXHandle = Selector.GetHandle ("modifier");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOperatorsX = "operators";
		static readonly NativeHandle selOperatorsXHandle = Selector.GetHandle ("operators");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOptionsX = "options";
		static readonly NativeHandle selOptionsXHandle = Selector.GetHandle ("options");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPredicateWithSubpredicates_X = "predicateWithSubpredicates:";
		static readonly NativeHandle selPredicateWithSubpredicates_XHandle = Selector.GetHandle ("predicateWithSubpredicates:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRightExpressionAttributeTypeX = "rightExpressionAttributeType";
		static readonly NativeHandle selRightExpressionAttributeTypeXHandle = Selector.GetHandle ("rightExpressionAttributeType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRightExpressionsX = "rightExpressions";
		static readonly NativeHandle selRightExpressionsXHandle = Selector.GetHandle ("rightExpressions");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPredicate_X = "setPredicate:";
		static readonly NativeHandle selSetPredicate_XHandle = Selector.GetHandle ("setPredicate:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemplateViewsX = "templateViews";
		static readonly NativeHandle selTemplateViewsXHandle = Selector.GetHandle ("templateViews");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemplatesWithAttributeKeyPaths_InEntityDescription_X = "templatesWithAttributeKeyPaths:inEntityDescription:";
		static readonly NativeHandle selTemplatesWithAttributeKeyPaths_InEntityDescription_XHandle = Selector.GetHandle ("templatesWithAttributeKeyPaths:inEntityDescription:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSPredicateEditorRowTemplate");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSPredicateEditorRowTemplate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSPredicateEditorRowTemplate () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		public NSPredicateEditorRowTemplate (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSPredicateEditorRowTemplate (NSObjectFlag t) : base (t)
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
		protected internal NSPredicateEditorRowTemplate (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithLeftExpressions:rightExpressions:modifier:operators:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSPredicateEditorRowTemplate (NSExpression[] leftExpressions, NSExpression[] rightExpressions, NSComparisonPredicateModifier modifier, NSObject[] operators, NSComparisonPredicateOptions options)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (leftExpressions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (leftExpressions));
			if (rightExpressions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (rightExpressions));
			if (operators is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (operators));
			using var nsa_leftExpressions = NSArray.FromNSObjects (leftExpressions);
			using var nsa_rightExpressions = NSArray.FromNSObjects (rightExpressions);
			using var nsa_operators = NSArray.FromNSObjects (operators);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_NativeHandle_UIntPtr (this.Handle, selInitWithLeftExpressions_RightExpressions_Modifier_Operators_Options_XHandle, nsa_leftExpressions.Handle, nsa_rightExpressions.Handle, (UIntPtr) (ulong) modifier, nsa_operators.Handle, (UIntPtr) (ulong) options), "initWithLeftExpressions:rightExpressions:modifier:operators:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_NativeHandle_UIntPtr (&__objc_super__, selInitWithLeftExpressions_RightExpressions_Modifier_Operators_Options_XHandle, nsa_leftExpressions.Handle, nsa_rightExpressions.Handle, (UIntPtr) (ulong) modifier, nsa_operators.Handle, (UIntPtr) (ulong) options), "initWithLeftExpressions:rightExpressions:modifier:operators:options:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithLeftExpressions:rightExpressionAttributeType:modifier:operators:options:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSPredicateEditorRowTemplate (NSExpression[] leftExpressions, global::CoreData.NSAttributeType attributeType, NSComparisonPredicateModifier modifier, NSObject[] operators, NSComparisonPredicateOptions options)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (leftExpressions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (leftExpressions));
			if (operators is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (operators));
			using var nsa_leftExpressions = NSArray.FromNSObjects (leftExpressions);
			using var nsa_operators = NSArray.FromNSObjects (operators);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_NativeHandle_UIntPtr (this.Handle, selInitWithLeftExpressions_RightExpressionAttributeType_Modifier_Operators_Options_XHandle, nsa_leftExpressions.Handle, (UIntPtr) (ulong) attributeType, (UIntPtr) (ulong) modifier, nsa_operators.Handle, (UIntPtr) (ulong) options), "initWithLeftExpressions:rightExpressionAttributeType:modifier:operators:options:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_UIntPtr_NativeHandle_UIntPtr (&__objc_super__, selInitWithLeftExpressions_RightExpressionAttributeType_Modifier_Operators_Options_XHandle, nsa_leftExpressions.Handle, (UIntPtr) (ulong) attributeType, (UIntPtr) (ulong) modifier, nsa_operators.Handle, (UIntPtr) (ulong) options), "initWithLeftExpressions:rightExpressionAttributeType:modifier:operators:options:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithCompoundTypes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSPredicateEditorRowTemplate (NSNumber[] compoundTypes)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (compoundTypes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (compoundTypes));
			using var nsa_compoundTypes = NSArray.FromNSObjects (compoundTypes);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithCompoundTypes_XHandle, nsa_compoundTypes.Handle), "initWithCompoundTypes:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithCompoundTypes_XHandle, nsa_compoundTypes.Handle), "initWithCompoundTypes:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		[Export ("displayableSubpredicatesOfPredicate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPredicate[] DisplayableSubpredicatesOfPredicate (NSPredicate predicate)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var predicate__handle__ = predicate!.GetNonNullHandle (nameof (predicate));
			NSPredicate[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<NSPredicate>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selDisplayableSubpredicatesOfPredicate_XHandle, predicate__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<NSPredicate>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selDisplayableSubpredicatesOfPredicate_XHandle, predicate__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (predicate);
			return ret!;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
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
		[Export ("templatesWithAttributeKeyPaths:inEntityDescription:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPredicateEditorRowTemplate[] GetTemplates (string[] keyPaths, global::CoreData.NSEntityDescription entityDescription)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (keyPaths is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (keyPaths));
			var entityDescription__handle__ = entityDescription!.GetNonNullHandle (nameof (entityDescription));
			using var nsa_keyPaths = NSArray.FromStrings (keyPaths);
			NSPredicateEditorRowTemplate[]? ret;
			ret = CFArray.ArrayFromHandle<NSPredicateEditorRowTemplate>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selTemplatesWithAttributeKeyPaths_InEntityDescription_XHandle, nsa_keyPaths.Handle, entityDescription__handle__), false)!;
			GC.KeepAlive (entityDescription);
			return ret!;
		}
		[Export ("matchForPredicate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double MatchForPredicate (NSPredicate predicate)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var predicate__handle__ = predicate!.GetNonNullHandle (nameof (predicate));
			double ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.Double_objc_msgSend_NativeHandle (this.Handle, selMatchForPredicate_XHandle, predicate__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper_NativeHandle (&__objc_super__, selMatchForPredicate_XHandle, predicate__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (predicate);
			return ret!;
		}
		[Export ("predicateWithSubpredicates:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPredicate PredicateWithSubpredicates (NSPredicate[] subpredicates)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (subpredicates is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (subpredicates));
			using var nsa_subpredicates = NSArray.FromNSObjects (subpredicates);
			NSPredicate ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selPredicateWithSubpredicates_XHandle, nsa_subpredicates.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSPredicate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selPredicateWithSubpredicates_XHandle, nsa_subpredicates.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("setPredicate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetPredicate (NSPredicate predicate)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var predicate__handle__ = predicate!.GetNonNullHandle (nameof (predicate));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPredicate_XHandle, predicate__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPredicate_XHandle, predicate__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (predicate);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber[] CompoundTypes {
			[Export ("compoundTypes")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSNumber[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCompoundTypesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCompoundTypesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression[] LeftExpressions {
			[Export ("leftExpressions")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSExpression[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSExpression>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLeftExpressionsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSExpression>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLeftExpressionsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSComparisonPredicateModifier Modifier {
			[Export ("modifier")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSComparisonPredicateModifier ret;
				if (IsDirectBinding) {
					ret = (NSComparisonPredicateModifier) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selModifierXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSComparisonPredicateModifier) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selModifierXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] Operators {
			[Export ("operators")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOperatorsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOperatorsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSComparisonPredicateOptions Options {
			[Export ("options")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSComparisonPredicateOptions ret;
				if (IsDirectBinding) {
					ret = (NSComparisonPredicateOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selOptionsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSComparisonPredicateOptions) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selOptionsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::CoreData.NSAttributeType RightExpressionAttributeType {
			[Export ("rightExpressionAttributeType")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				global::CoreData.NSAttributeType ret;
				if (IsDirectBinding) {
					ret = (CoreData.NSAttributeType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selRightExpressionAttributeTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (CoreData.NSAttributeType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selRightExpressionAttributeTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSExpression[] RightExpressions {
			[Export ("rightExpressions")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSExpression[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSExpression>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selRightExpressionsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSExpression>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selRightExpressionsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] TemplateViews {
			[Export ("templateViews")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTemplateViewsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTemplateViewsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class NSPredicateEditorRowTemplate */
}
