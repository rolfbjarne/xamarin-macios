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
	[Register("NSPresentationIntent", true)]
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSPresentationIntent : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBlockQuoteIntentWithIdentity_NestedInsideIntent_X = "blockQuoteIntentWithIdentity:nestedInsideIntent:";
		static readonly NativeHandle selBlockQuoteIntentWithIdentity_NestedInsideIntent_XHandle = Selector.GetHandle ("blockQuoteIntentWithIdentity:nestedInsideIntent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCodeBlockIntentWithIdentity_LanguageHint_NestedInsideIntent_X = "codeBlockIntentWithIdentity:languageHint:nestedInsideIntent:";
		static readonly NativeHandle selCodeBlockIntentWithIdentity_LanguageHint_NestedInsideIntent_XHandle = Selector.GetHandle ("codeBlockIntentWithIdentity:languageHint:nestedInsideIntent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColumnX = "column";
		static readonly NativeHandle selColumnXHandle = Selector.GetHandle ("column");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColumnAlignmentsX = "columnAlignments";
		static readonly NativeHandle selColumnAlignmentsXHandle = Selector.GetHandle ("columnAlignments");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColumnCountX = "columnCount";
		static readonly NativeHandle selColumnCountXHandle = Selector.GetHandle ("columnCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHeaderIntentWithIdentity_Level_NestedInsideIntent_X = "headerIntentWithIdentity:level:nestedInsideIntent:";
		static readonly NativeHandle selHeaderIntentWithIdentity_Level_NestedInsideIntent_XHandle = Selector.GetHandle ("headerIntentWithIdentity:level:nestedInsideIntent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHeaderLevelX = "headerLevel";
		static readonly NativeHandle selHeaderLevelXHandle = Selector.GetHandle ("headerLevel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIdentityX = "identity";
		static readonly NativeHandle selIdentityXHandle = Selector.GetHandle ("identity");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndentationLevelX = "indentationLevel";
		static readonly NativeHandle selIndentationLevelXHandle = Selector.GetHandle ("indentationLevel");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIntentKindX = "intentKind";
		static readonly NativeHandle selIntentKindXHandle = Selector.GetHandle ("intentKind");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEquivalentToPresentationIntent_X = "isEquivalentToPresentationIntent:";
		static readonly NativeHandle selIsEquivalentToPresentationIntent_XHandle = Selector.GetHandle ("isEquivalentToPresentationIntent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLanguageHintX = "languageHint";
		static readonly NativeHandle selLanguageHintXHandle = Selector.GetHandle ("languageHint");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selListItemIntentWithIdentity_Ordinal_NestedInsideIntent_X = "listItemIntentWithIdentity:ordinal:nestedInsideIntent:";
		static readonly NativeHandle selListItemIntentWithIdentity_Ordinal_NestedInsideIntent_XHandle = Selector.GetHandle ("listItemIntentWithIdentity:ordinal:nestedInsideIntent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOrderedListIntentWithIdentity_NestedInsideIntent_X = "orderedListIntentWithIdentity:nestedInsideIntent:";
		static readonly NativeHandle selOrderedListIntentWithIdentity_NestedInsideIntent_XHandle = Selector.GetHandle ("orderedListIntentWithIdentity:nestedInsideIntent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOrdinalX = "ordinal";
		static readonly NativeHandle selOrdinalXHandle = Selector.GetHandle ("ordinal");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParagraphIntentWithIdentity_NestedInsideIntent_X = "paragraphIntentWithIdentity:nestedInsideIntent:";
		static readonly NativeHandle selParagraphIntentWithIdentity_NestedInsideIntent_XHandle = Selector.GetHandle ("paragraphIntentWithIdentity:nestedInsideIntent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParentIntentX = "parentIntent";
		static readonly NativeHandle selParentIntentXHandle = Selector.GetHandle ("parentIntent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRowX = "row";
		static readonly NativeHandle selRowXHandle = Selector.GetHandle ("row");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTableCellIntentWithIdentity_Column_NestedInsideIntent_X = "tableCellIntentWithIdentity:column:nestedInsideIntent:";
		static readonly NativeHandle selTableCellIntentWithIdentity_Column_NestedInsideIntent_XHandle = Selector.GetHandle ("tableCellIntentWithIdentity:column:nestedInsideIntent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTableHeaderRowIntentWithIdentity_NestedInsideIntent_X = "tableHeaderRowIntentWithIdentity:nestedInsideIntent:";
		static readonly NativeHandle selTableHeaderRowIntentWithIdentity_NestedInsideIntent_XHandle = Selector.GetHandle ("tableHeaderRowIntentWithIdentity:nestedInsideIntent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTableIntentWithIdentity_ColumnCount_Alignments_NestedInsideIntent_X = "tableIntentWithIdentity:columnCount:alignments:nestedInsideIntent:";
		static readonly NativeHandle selTableIntentWithIdentity_ColumnCount_Alignments_NestedInsideIntent_XHandle = Selector.GetHandle ("tableIntentWithIdentity:columnCount:alignments:nestedInsideIntent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTableRowIntentWithIdentity_Row_NestedInsideIntent_X = "tableRowIntentWithIdentity:row:nestedInsideIntent:";
		static readonly NativeHandle selTableRowIntentWithIdentity_Row_NestedInsideIntent_XHandle = Selector.GetHandle ("tableRowIntentWithIdentity:row:nestedInsideIntent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selThematicBreakIntentWithIdentity_NestedInsideIntent_X = "thematicBreakIntentWithIdentity:nestedInsideIntent:";
		static readonly NativeHandle selThematicBreakIntentWithIdentity_NestedInsideIntent_XHandle = Selector.GetHandle ("thematicBreakIntentWithIdentity:nestedInsideIntent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnorderedListIntentWithIdentity_NestedInsideIntent_X = "unorderedListIntentWithIdentity:nestedInsideIntent:";
		static readonly NativeHandle selUnorderedListIntentWithIdentity_NestedInsideIntent_XHandle = Selector.GetHandle ("unorderedListIntentWithIdentity:nestedInsideIntent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSPresentationIntent");
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
		public NSPresentationIntent (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSPresentationIntent (NSObjectFlag t) : base (t)
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
		protected internal NSPresentationIntent (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
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
		[Export ("blockQuoteIntentWithIdentity:nestedInsideIntent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPresentationIntent CreateBlockQuoteIntent (nint identity, NSPresentationIntent? parent)
		{
			var parent__handle__ = parent.GetHandle ();
			NSPresentationIntent? ret;
			ret =  Runtime.GetNSObject<NSPresentationIntent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (class_ptr, selBlockQuoteIntentWithIdentity_NestedInsideIntent_XHandle, identity, parent__handle__), false)!;
			GC.KeepAlive (parent);
			return ret!;
		}
		[Export ("codeBlockIntentWithIdentity:languageHint:nestedInsideIntent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPresentationIntent CreateCodeBlockIntent (nint identity, string? languageHint, NSPresentationIntent? parent)
		{
			var parent__handle__ = parent.GetHandle ();
			var nslanguageHint = CFString.CreateNative (languageHint);
			NSPresentationIntent? ret;
			ret =  Runtime.GetNSObject<NSPresentationIntent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle_NativeHandle (class_ptr, selCodeBlockIntentWithIdentity_LanguageHint_NestedInsideIntent_XHandle, identity, nslanguageHint, parent__handle__), false)!;
			GC.KeepAlive (parent);
			CFString.ReleaseNative (nslanguageHint);
			return ret!;
		}
		[Export ("headerIntentWithIdentity:level:nestedInsideIntent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPresentationIntent CreateHeaderIntent (nint identity, nint level, NSPresentationIntent? parent)
		{
			var parent__handle__ = parent.GetHandle ();
			NSPresentationIntent? ret;
			ret =  Runtime.GetNSObject<NSPresentationIntent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr_NativeHandle (class_ptr, selHeaderIntentWithIdentity_Level_NestedInsideIntent_XHandle, identity, level, parent__handle__), false)!;
			GC.KeepAlive (parent);
			return ret!;
		}
		[Export ("listItemIntentWithIdentity:ordinal:nestedInsideIntent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPresentationIntent CreateListItemIntent (nint identity, nint ordinal, NSPresentationIntent? parent)
		{
			var parent__handle__ = parent.GetHandle ();
			NSPresentationIntent? ret;
			ret =  Runtime.GetNSObject<NSPresentationIntent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr_NativeHandle (class_ptr, selListItemIntentWithIdentity_Ordinal_NestedInsideIntent_XHandle, identity, ordinal, parent__handle__), false)!;
			GC.KeepAlive (parent);
			return ret!;
		}
		[Export ("orderedListIntentWithIdentity:nestedInsideIntent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPresentationIntent CreateOrderedListIntent (nint identity, NSPresentationIntent? parent)
		{
			var parent__handle__ = parent.GetHandle ();
			NSPresentationIntent? ret;
			ret =  Runtime.GetNSObject<NSPresentationIntent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (class_ptr, selOrderedListIntentWithIdentity_NestedInsideIntent_XHandle, identity, parent__handle__), false)!;
			GC.KeepAlive (parent);
			return ret!;
		}
		[Export ("paragraphIntentWithIdentity:nestedInsideIntent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPresentationIntent CreateParagraphIntent (nint identity, NSPresentationIntent? parent)
		{
			var parent__handle__ = parent.GetHandle ();
			NSPresentationIntent? ret;
			ret =  Runtime.GetNSObject<NSPresentationIntent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (class_ptr, selParagraphIntentWithIdentity_NestedInsideIntent_XHandle, identity, parent__handle__), false)!;
			GC.KeepAlive (parent);
			return ret!;
		}
		[Export ("tableCellIntentWithIdentity:column:nestedInsideIntent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPresentationIntent CreateTableCellIntent (nint identity, nint column, NSPresentationIntent? parent)
		{
			var parent__handle__ = parent.GetHandle ();
			NSPresentationIntent? ret;
			ret =  Runtime.GetNSObject<NSPresentationIntent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr_NativeHandle (class_ptr, selTableCellIntentWithIdentity_Column_NestedInsideIntent_XHandle, identity, column, parent__handle__), false)!;
			GC.KeepAlive (parent);
			return ret!;
		}
		[Export ("tableHeaderRowIntentWithIdentity:nestedInsideIntent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPresentationIntent CreateTableHeaderRowIntent (nint identity, NSPresentationIntent? parent)
		{
			var parent__handle__ = parent.GetHandle ();
			NSPresentationIntent? ret;
			ret =  Runtime.GetNSObject<NSPresentationIntent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (class_ptr, selTableHeaderRowIntentWithIdentity_NestedInsideIntent_XHandle, identity, parent__handle__), false)!;
			GC.KeepAlive (parent);
			return ret!;
		}
		[Export ("tableIntentWithIdentity:columnCount:alignments:nestedInsideIntent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPresentationIntent CreateTableIntent (nint identity, nint columnCount, NSNumber[] alignments, NSPresentationIntent? parent)
		{
			if (alignments is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (alignments));
			var parent__handle__ = parent.GetHandle ();
			using var nsa_alignments = NSArray.FromNSObjects (alignments);
			NSPresentationIntent? ret;
			ret =  Runtime.GetNSObject<NSPresentationIntent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr_NativeHandle_NativeHandle (class_ptr, selTableIntentWithIdentity_ColumnCount_Alignments_NestedInsideIntent_XHandle, identity, columnCount, nsa_alignments.Handle, parent__handle__), false)!;
			GC.KeepAlive (parent);
			return ret!;
		}
		[Export ("tableRowIntentWithIdentity:row:nestedInsideIntent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPresentationIntent CreateTableRowIntent (nint identity, nint row, NSPresentationIntent? parent)
		{
			var parent__handle__ = parent.GetHandle ();
			NSPresentationIntent? ret;
			ret =  Runtime.GetNSObject<NSPresentationIntent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr_NativeHandle (class_ptr, selTableRowIntentWithIdentity_Row_NestedInsideIntent_XHandle, identity, row, parent__handle__), false)!;
			GC.KeepAlive (parent);
			return ret!;
		}
		[Export ("thematicBreakIntentWithIdentity:nestedInsideIntent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPresentationIntent CreateThematicBreakIntent (nint identity, NSPresentationIntent? parent)
		{
			var parent__handle__ = parent.GetHandle ();
			NSPresentationIntent? ret;
			ret =  Runtime.GetNSObject<NSPresentationIntent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (class_ptr, selThematicBreakIntentWithIdentity_NestedInsideIntent_XHandle, identity, parent__handle__), false)!;
			GC.KeepAlive (parent);
			return ret!;
		}
		[Export ("unorderedListIntentWithIdentity:nestedInsideIntent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPresentationIntent CreateUnorderedListIntent (nint identity, NSPresentationIntent? parent)
		{
			var parent__handle__ = parent.GetHandle ();
			NSPresentationIntent? ret;
			ret =  Runtime.GetNSObject<NSPresentationIntent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle (class_ptr, selUnorderedListIntentWithIdentity_NestedInsideIntent_XHandle, identity, parent__handle__), false)!;
			GC.KeepAlive (parent);
			return ret!;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos15.0")]
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
		[Export ("isEquivalentToPresentationIntent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEquivalent (NSPresentationIntent other)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsEquivalentToPresentationIntent_XHandle, other__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsEquivalentToPresentationIntent_XHandle, other__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Column {
			[Export ("column")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selColumnXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selColumnXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber[]? ColumnAlignments {
			[Export ("columnAlignments")]
			get {
				NSNumber[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selColumnAlignmentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSNumber>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selColumnAlignmentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ColumnCount {
			[Export ("columnCount")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selColumnCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selColumnCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint HeaderLevel {
			[Export ("headerLevel")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selHeaderLevelXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selHeaderLevelXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Identity {
			[Export ("identity")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIdentityXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selIdentityXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint IndentationLevel {
			[Export ("indentationLevel")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIndentationLevelXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selIndentationLevelXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPresentationIntentKind IntentKind {
			[Export ("intentKind")]
			get {
				NSPresentationIntentKind ret;
				if (IsDirectBinding) {
					ret = (NSPresentationIntentKind) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selIntentKindXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSPresentationIntentKind) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selIntentKindXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? LanguageHint {
			[Export ("languageHint")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLanguageHintXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLanguageHintXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Ordinal {
			[Export ("ordinal")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOrdinalXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selOrdinalXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPresentationIntent? ParentIntent {
			[Export ("parentIntent", ArgumentSemantic.Retain)]
			get {
				NSPresentationIntent? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSPresentationIntent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selParentIntentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSPresentationIntent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selParentIntentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint Row {
			[Export ("row")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRowXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selRowXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class NSPresentationIntent */
}
