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
namespace WebKit {
	[Register("DOMDocument", true)]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos10.14", "No longer supported.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class DomDocument : DomNode {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLX = "URL";
		static readonly NativeHandle selURLXHandle = Selector.GetHandle ("URL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAdoptNode_X = "adoptNode:";
		static readonly NativeHandle selAdoptNode_XHandle = Selector.GetHandle ("adoptNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnchorsX = "anchors";
		static readonly NativeHandle selAnchorsXHandle = Selector.GetHandle ("anchors");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppletsX = "applets";
		static readonly NativeHandle selAppletsXHandle = Selector.GetHandle ("applets");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBodyX = "body";
		static readonly NativeHandle selBodyXHandle = Selector.GetHandle ("body");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCharacterSetX = "characterSet";
		static readonly NativeHandle selCharacterSetXHandle = Selector.GetHandle ("characterSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCharsetX = "charset";
		static readonly NativeHandle selCharsetXHandle = Selector.GetHandle ("charset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCookieX = "cookie";
		static readonly NativeHandle selCookieXHandle = Selector.GetHandle ("cookie");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateAttribute_X = "createAttribute:";
		static readonly NativeHandle selCreateAttribute_XHandle = Selector.GetHandle ("createAttribute:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateAttributeNS_QualifiedName_X = "createAttributeNS:qualifiedName:";
		static readonly NativeHandle selCreateAttributeNS_QualifiedName_XHandle = Selector.GetHandle ("createAttributeNS:qualifiedName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateCDATASection_X = "createCDATASection:";
		static readonly NativeHandle selCreateCDATASection_XHandle = Selector.GetHandle ("createCDATASection:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateCSSStyleDeclarationX = "createCSSStyleDeclaration";
		static readonly NativeHandle selCreateCSSStyleDeclarationXHandle = Selector.GetHandle ("createCSSStyleDeclaration");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateComment_X = "createComment:";
		static readonly NativeHandle selCreateComment_XHandle = Selector.GetHandle ("createComment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateDocumentFragmentX = "createDocumentFragment";
		static readonly NativeHandle selCreateDocumentFragmentXHandle = Selector.GetHandle ("createDocumentFragment");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateElement_X = "createElement:";
		static readonly NativeHandle selCreateElement_XHandle = Selector.GetHandle ("createElement:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateElementNS_QualifiedName_X = "createElementNS:qualifiedName:";
		static readonly NativeHandle selCreateElementNS_QualifiedName_XHandle = Selector.GetHandle ("createElementNS:qualifiedName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateEntityReference_X = "createEntityReference:";
		static readonly NativeHandle selCreateEntityReference_XHandle = Selector.GetHandle ("createEntityReference:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateEvent_X = "createEvent:";
		static readonly NativeHandle selCreateEvent_XHandle = Selector.GetHandle ("createEvent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateNodeIterator_WhatToShow_Filter_ExpandEntityReferences_X = "createNodeIterator:whatToShow:filter:expandEntityReferences:";
		static readonly NativeHandle selCreateNodeIterator_WhatToShow_Filter_ExpandEntityReferences_XHandle = Selector.GetHandle ("createNodeIterator:whatToShow:filter:expandEntityReferences:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateProcessingInstruction_Data_X = "createProcessingInstruction:data:";
		static readonly NativeHandle selCreateProcessingInstruction_Data_XHandle = Selector.GetHandle ("createProcessingInstruction:data:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateRangeX = "createRange";
		static readonly NativeHandle selCreateRangeXHandle = Selector.GetHandle ("createRange");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCreateTextNode_X = "createTextNode:";
		static readonly NativeHandle selCreateTextNode_XHandle = Selector.GetHandle ("createTextNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultCharsetX = "defaultCharset";
		static readonly NativeHandle selDefaultCharsetXHandle = Selector.GetHandle ("defaultCharset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDefaultViewX = "defaultView";
		static readonly NativeHandle selDefaultViewXHandle = Selector.GetHandle ("defaultView");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDoctypeX = "doctype";
		static readonly NativeHandle selDoctypeXHandle = Selector.GetHandle ("doctype");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDocumentElementX = "documentElement";
		static readonly NativeHandle selDocumentElementXHandle = Selector.GetHandle ("documentElement");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDocumentURIX = "documentURI";
		static readonly NativeHandle selDocumentURIXHandle = Selector.GetHandle ("documentURI");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDomainX = "domain";
		static readonly NativeHandle selDomainXHandle = Selector.GetHandle ("domain");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selElementFromPoint_Y_X = "elementFromPoint:y:";
		static readonly NativeHandle selElementFromPoint_Y_XHandle = Selector.GetHandle ("elementFromPoint:y:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExecCommand_X = "execCommand:";
		static readonly NativeHandle selExecCommand_XHandle = Selector.GetHandle ("execCommand:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExecCommand_UserInterface_X = "execCommand:userInterface:";
		static readonly NativeHandle selExecCommand_UserInterface_XHandle = Selector.GetHandle ("execCommand:userInterface:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExecCommand_UserInterface_Value_X = "execCommand:userInterface:value:";
		static readonly NativeHandle selExecCommand_UserInterface_Value_XHandle = Selector.GetHandle ("execCommand:userInterface:value:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFormsX = "forms";
		static readonly NativeHandle selFormsXHandle = Selector.GetHandle ("forms");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetComputedStyle_PseudoElement_X = "getComputedStyle:pseudoElement:";
		static readonly NativeHandle selGetComputedStyle_PseudoElement_XHandle = Selector.GetHandle ("getComputedStyle:pseudoElement:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetElementById_X = "getElementById:";
		static readonly NativeHandle selGetElementById_XHandle = Selector.GetHandle ("getElementById:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetElementsByClassName_X = "getElementsByClassName:";
		static readonly NativeHandle selGetElementsByClassName_XHandle = Selector.GetHandle ("getElementsByClassName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetElementsByName_X = "getElementsByName:";
		static readonly NativeHandle selGetElementsByName_XHandle = Selector.GetHandle ("getElementsByName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetElementsByTagName_X = "getElementsByTagName:";
		static readonly NativeHandle selGetElementsByTagName_XHandle = Selector.GetHandle ("getElementsByTagName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetElementsByTagNameNS_LocalName_X = "getElementsByTagNameNS:localName:";
		static readonly NativeHandle selGetElementsByTagNameNS_LocalName_XHandle = Selector.GetHandle ("getElementsByTagNameNS:localName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetMatchedCSSRules_PseudoElement_X = "getMatchedCSSRules:pseudoElement:";
		static readonly NativeHandle selGetMatchedCSSRules_PseudoElement_XHandle = Selector.GetHandle ("getMatchedCSSRules:pseudoElement:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetMatchedCSSRules_PseudoElement_AuthorOnly_X = "getMatchedCSSRules:pseudoElement:authorOnly:";
		static readonly NativeHandle selGetMatchedCSSRules_PseudoElement_AuthorOnly_XHandle = Selector.GetHandle ("getMatchedCSSRules:pseudoElement:authorOnly:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetOverrideStyle_PseudoElement_X = "getOverrideStyle:pseudoElement:";
		static readonly NativeHandle selGetOverrideStyle_PseudoElement_XHandle = Selector.GetHandle ("getOverrideStyle:pseudoElement:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImagesX = "images";
		static readonly NativeHandle selImagesXHandle = Selector.GetHandle ("images");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImplementationX = "implementation";
		static readonly NativeHandle selImplementationXHandle = Selector.GetHandle ("implementation");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImportNode_Deep_X = "importNode:deep:";
		static readonly NativeHandle selImportNode_Deep_XHandle = Selector.GetHandle ("importNode:deep:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInputEncodingX = "inputEncoding";
		static readonly NativeHandle selInputEncodingXHandle = Selector.GetHandle ("inputEncoding");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLastModifiedX = "lastModified";
		static readonly NativeHandle selLastModifiedXHandle = Selector.GetHandle ("lastModified");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLinksX = "links";
		static readonly NativeHandle selLinksXHandle = Selector.GetHandle ("links");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreferredStylesheetSetX = "preferredStylesheetSet";
		static readonly NativeHandle selPreferredStylesheetSetXHandle = Selector.GetHandle ("preferredStylesheetSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQueryCommandEnabled_X = "queryCommandEnabled:";
		static readonly NativeHandle selQueryCommandEnabled_XHandle = Selector.GetHandle ("queryCommandEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQueryCommandIndeterm_X = "queryCommandIndeterm:";
		static readonly NativeHandle selQueryCommandIndeterm_XHandle = Selector.GetHandle ("queryCommandIndeterm:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQueryCommandState_X = "queryCommandState:";
		static readonly NativeHandle selQueryCommandState_XHandle = Selector.GetHandle ("queryCommandState:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQueryCommandSupported_X = "queryCommandSupported:";
		static readonly NativeHandle selQueryCommandSupported_XHandle = Selector.GetHandle ("queryCommandSupported:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQueryCommandValue_X = "queryCommandValue:";
		static readonly NativeHandle selQueryCommandValue_XHandle = Selector.GetHandle ("queryCommandValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQuerySelector_X = "querySelector:";
		static readonly NativeHandle selQuerySelector_XHandle = Selector.GetHandle ("querySelector:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQuerySelectorAll_X = "querySelectorAll:";
		static readonly NativeHandle selQuerySelectorAll_XHandle = Selector.GetHandle ("querySelectorAll:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadyStateX = "readyState";
		static readonly NativeHandle selReadyStateXHandle = Selector.GetHandle ("readyState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReferrerX = "referrer";
		static readonly NativeHandle selReferrerXHandle = Selector.GetHandle ("referrer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedStylesheetSetX = "selectedStylesheetSet";
		static readonly NativeHandle selSelectedStylesheetSetXHandle = Selector.GetHandle ("selectedStylesheetSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBody_X = "setBody:";
		static readonly NativeHandle selSetBody_XHandle = Selector.GetHandle ("setBody:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCharset_X = "setCharset:";
		static readonly NativeHandle selSetCharset_XHandle = Selector.GetHandle ("setCharset:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetCookie_X = "setCookie:";
		static readonly NativeHandle selSetCookie_XHandle = Selector.GetHandle ("setCookie:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetDocumentURI_X = "setDocumentURI:";
		static readonly NativeHandle selSetDocumentURI_XHandle = Selector.GetHandle ("setDocumentURI:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectedStylesheetSet_X = "setSelectedStylesheetSet:";
		static readonly NativeHandle selSetSelectedStylesheetSet_XHandle = Selector.GetHandle ("setSelectedStylesheetSet:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTitle_X = "setTitle:";
		static readonly NativeHandle selSetTitle_XHandle = Selector.GetHandle ("setTitle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetXmlStandalone_X = "setXmlStandalone:";
		static readonly NativeHandle selSetXmlStandalone_XHandle = Selector.GetHandle ("setXmlStandalone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetXmlVersion_X = "setXmlVersion:";
		static readonly NativeHandle selSetXmlVersion_XHandle = Selector.GetHandle ("setXmlVersion:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStyleSheetsX = "styleSheets";
		static readonly NativeHandle selStyleSheetsXHandle = Selector.GetHandle ("styleSheets");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTitleX = "title";
		static readonly NativeHandle selTitleXHandle = Selector.GetHandle ("title");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selXmlEncodingX = "xmlEncoding";
		static readonly NativeHandle selXmlEncodingXHandle = Selector.GetHandle ("xmlEncoding");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selXmlStandaloneX = "xmlStandalone";
		static readonly NativeHandle selXmlStandaloneXHandle = Selector.GetHandle ("xmlStandalone");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selXmlVersionX = "xmlVersion";
		static readonly NativeHandle selXmlVersionXHandle = Selector.GetHandle ("xmlVersion");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("DOMDocument");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
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
		protected DomDocument (NSObjectFlag t) : base (t)
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
		protected internal DomDocument (NativeHandle handle) : base (handle)
		{
		}

		[Export ("adoptNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNode AdoptNode (DomNode source)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			DomNode? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selAdoptNode_XHandle, source__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selAdoptNode_XHandle, source__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (source);
			return ret!;
		}
		[Export ("createAttribute:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomAttr CreateAttribute (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			DomAttr? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomAttr> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCreateAttribute_XHandle, nsname), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomAttr> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCreateAttribute_XHandle, nsname), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("createAttributeNS:qualifiedName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomAttr CreateAttributeNS (string namespaceURI, string qualifiedName)
		{
			if (namespaceURI is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (namespaceURI));
			if (qualifiedName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (qualifiedName));
			var nsnamespaceURI = CFString.CreateNative (namespaceURI);
			var nsqualifiedName = CFString.CreateNative (qualifiedName);
			DomAttr? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomAttr> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selCreateAttributeNS_QualifiedName_XHandle, nsnamespaceURI, nsqualifiedName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomAttr> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selCreateAttributeNS_QualifiedName_XHandle, nsnamespaceURI, nsqualifiedName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsnamespaceURI);
			CFString.ReleaseNative (nsqualifiedName);
			return ret!;
		}
		[Export ("createCDATASection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomCDataSection CreateCDataSection (string data)
		{
			if (data is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (data));
			var nsdata = CFString.CreateNative (data);
			DomCDataSection? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomCDataSection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCreateCDATASection_XHandle, nsdata), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomCDataSection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCreateCDATASection_XHandle, nsdata), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdata);
			return ret!;
		}
		[Export ("createComment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomComment CreateComment (string data)
		{
			if (data is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (data));
			var nsdata = CFString.CreateNative (data);
			DomComment? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomComment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCreateComment_XHandle, nsdata), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomComment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCreateComment_XHandle, nsdata), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdata);
			return ret!;
		}
		[Export ("createCSSStyleDeclaration")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomCssStyleDeclaration CreateCssStyleDeclaration ()
		{
			DomCssStyleDeclaration ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomCssStyleDeclaration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCreateCSSStyleDeclarationXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomCssStyleDeclaration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCreateCSSStyleDeclarationXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("createDocumentFragment")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomDocumentFragment CreateDocumentFragment ()
		{
			DomDocumentFragment ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomDocumentFragment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCreateDocumentFragmentXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomDocumentFragment> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCreateDocumentFragmentXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("createElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomElement CreateElement (string tagName)
		{
			if (tagName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tagName));
			var nstagName = CFString.CreateNative (tagName);
			DomElement? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCreateElement_XHandle, nstagName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCreateElement_XHandle, nstagName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstagName);
			return ret!;
		}
		[Export ("createElementNS:qualifiedName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomElement CreateElementNS (string namespaceURI, string qualifiedName)
		{
			if (namespaceURI is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (namespaceURI));
			if (qualifiedName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (qualifiedName));
			var nsnamespaceURI = CFString.CreateNative (namespaceURI);
			var nsqualifiedName = CFString.CreateNative (qualifiedName);
			DomElement? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selCreateElementNS_QualifiedName_XHandle, nsnamespaceURI, nsqualifiedName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selCreateElementNS_QualifiedName_XHandle, nsnamespaceURI, nsqualifiedName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsnamespaceURI);
			CFString.ReleaseNative (nsqualifiedName);
			return ret!;
		}
		[Export ("createEntityReference:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomEntityReference CreateEntityReference (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			DomEntityReference? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomEntityReference> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCreateEntityReference_XHandle, nsname), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomEntityReference> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCreateEntityReference_XHandle, nsname), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("createEvent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomEvent CreateEvent (string eventType)
		{
			if (eventType is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (eventType));
			var nseventType = CFString.CreateNative (eventType);
			DomEvent? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCreateEvent_XHandle, nseventType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomEvent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCreateEvent_XHandle, nseventType), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nseventType);
			return ret!;
		}
		[Export ("createNodeIterator:whatToShow:filter:expandEntityReferences:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNodeIterator CreateNodeIterator (DomNode root, uint whatToShow, IDomNodeFilter filter, bool expandEntityReferences)
		{
			var root__handle__ = root!.GetNonNullHandle (nameof (root));
			var filter__handle__ = filter!.GetNonNullHandle (nameof (filter));
			DomNodeIterator? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomNodeIterator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UInt32_NativeHandle_bool (this.Handle, selCreateNodeIterator_WhatToShow_Filter_ExpandEntityReferences_XHandle, root__handle__, whatToShow, filter__handle__, expandEntityReferences ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomNodeIterator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UInt32_NativeHandle_bool (&__objc_super__, selCreateNodeIterator_WhatToShow_Filter_ExpandEntityReferences_XHandle, root__handle__, whatToShow, filter__handle__, expandEntityReferences ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (root);
			GC.KeepAlive (filter);
			return ret!;
		}
		[Export ("createProcessingInstruction:data:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomProcessingInstruction CreateProcessingInstruction (string target, string data)
		{
			if (target is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (target));
			if (data is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (data));
			var nstarget = CFString.CreateNative (target);
			var nsdata = CFString.CreateNative (data);
			DomProcessingInstruction? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomProcessingInstruction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selCreateProcessingInstruction_Data_XHandle, nstarget, nsdata), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomProcessingInstruction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selCreateProcessingInstruction_Data_XHandle, nstarget, nsdata), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstarget);
			CFString.ReleaseNative (nsdata);
			return ret!;
		}
		[Export ("createRange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomRange CreateRange ()
		{
			DomRange ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCreateRangeXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomRange> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCreateRangeXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("createTextNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomText CreateTextNode (string data)
		{
			if (data is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (data));
			var nsdata = CFString.CreateNative (data);
			DomText? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomText> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCreateTextNode_XHandle, nsdata), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomText> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCreateTextNode_XHandle, nsdata), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsdata);
			return ret!;
		}
		[Export ("elementFromPoint:y:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomElement ElementFromPoint (int x, int y)
		{
			DomElement ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_int_int (this.Handle, selElementFromPoint_Y_XHandle, x, y), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_int_int (&__objc_super__, selElementFromPoint_Y_XHandle, x, y), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("execCommand:userInterface:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ExecCommand (string command, bool userInterface, string value)
		{
			if (command is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (command));
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nscommand = CFString.CreateNative (command);
			var nsvalue = CFString.CreateNative (value);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_bool_NativeHandle (this.Handle, selExecCommand_UserInterface_Value_XHandle, nscommand, userInterface ? (byte) 1 : (byte) 0, nsvalue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_bool_NativeHandle (&__objc_super__, selExecCommand_UserInterface_Value_XHandle, nscommand, userInterface ? (byte) 1 : (byte) 0, nsvalue);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscommand);
			CFString.ReleaseNative (nsvalue);
			return ret != 0;
		}
		[Export ("execCommand:userInterface:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ExecCommand (string command, bool userInterface)
		{
			if (command is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (command));
			var nscommand = CFString.CreateNative (command);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_bool (this.Handle, selExecCommand_UserInterface_XHandle, nscommand, userInterface ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selExecCommand_UserInterface_XHandle, nscommand, userInterface ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscommand);
			return ret != 0;
		}
		[Export ("execCommand:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ExecCommand (string command)
		{
			if (command is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (command));
			var nscommand = CFString.CreateNative (command);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selExecCommand_XHandle, nscommand);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selExecCommand_XHandle, nscommand);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscommand);
			return ret != 0;
		}
		[Export ("getComputedStyle:pseudoElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomCssStyleDeclaration GetComputedStyle (DomElement element, string pseudoElement)
		{
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			if (pseudoElement is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pseudoElement));
			var nspseudoElement = CFString.CreateNative (pseudoElement);
			DomCssStyleDeclaration? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomCssStyleDeclaration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selGetComputedStyle_PseudoElement_XHandle, element__handle__, nspseudoElement), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomCssStyleDeclaration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selGetComputedStyle_PseudoElement_XHandle, element__handle__, nspseudoElement), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (element);
			CFString.ReleaseNative (nspseudoElement);
			return ret!;
		}
		[Export ("getElementById:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomElement GetElementById (string elementId)
		{
			if (elementId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (elementId));
			var nselementId = CFString.CreateNative (elementId);
			DomElement? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selGetElementById_XHandle, nselementId), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selGetElementById_XHandle, nselementId), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nselementId);
			return ret!;
		}
		[Export ("getElementsByClassName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNodeList GetElementsByClassName (string tagname)
		{
			if (tagname is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tagname));
			var nstagname = CFString.CreateNative (tagname);
			DomNodeList? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomNodeList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selGetElementsByClassName_XHandle, nstagname), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomNodeList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selGetElementsByClassName_XHandle, nstagname), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstagname);
			return ret!;
		}
		[Export ("getElementsByName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNodeList GetElementsByName (string elementName)
		{
			if (elementName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (elementName));
			var nselementName = CFString.CreateNative (elementName);
			DomNodeList? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomNodeList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selGetElementsByName_XHandle, nselementName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomNodeList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selGetElementsByName_XHandle, nselementName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nselementName);
			return ret!;
		}
		[Export ("getElementsByTagName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNodeList GetElementsByTagName (string tagname)
		{
			if (tagname is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tagname));
			var nstagname = CFString.CreateNative (tagname);
			DomNodeList? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomNodeList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selGetElementsByTagName_XHandle, nstagname), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomNodeList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selGetElementsByTagName_XHandle, nstagname), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstagname);
			return ret!;
		}
		[Export ("getElementsByTagNameNS:localName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNodeList GetElementsByTagNameNS (string namespaceURI, string localName)
		{
			if (namespaceURI is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (namespaceURI));
			if (localName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localName));
			var nsnamespaceURI = CFString.CreateNative (namespaceURI);
			var nslocalName = CFString.CreateNative (localName);
			DomNodeList? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomNodeList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selGetElementsByTagNameNS_LocalName_XHandle, nsnamespaceURI, nslocalName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomNodeList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selGetElementsByTagNameNS_LocalName_XHandle, nsnamespaceURI, nslocalName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsnamespaceURI);
			CFString.ReleaseNative (nslocalName);
			return ret!;
		}
		[Export ("getMatchedCSSRules:pseudoElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomCssRuleList GetMatchedCSSRules (DomElement element, string pseudoElement)
		{
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			if (pseudoElement is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pseudoElement));
			var nspseudoElement = CFString.CreateNative (pseudoElement);
			DomCssRuleList? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomCssRuleList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selGetMatchedCSSRules_PseudoElement_XHandle, element__handle__, nspseudoElement), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomCssRuleList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selGetMatchedCSSRules_PseudoElement_XHandle, element__handle__, nspseudoElement), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (element);
			CFString.ReleaseNative (nspseudoElement);
			return ret!;
		}
		[Export ("getMatchedCSSRules:pseudoElement:authorOnly:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomCssRuleList GetMatchedCSSRules (DomElement element, string pseudoElement, bool authorOnly)
		{
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			if (pseudoElement is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pseudoElement));
			var nspseudoElement = CFString.CreateNative (pseudoElement);
			DomCssRuleList? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomCssRuleList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool (this.Handle, selGetMatchedCSSRules_PseudoElement_AuthorOnly_XHandle, element__handle__, nspseudoElement, authorOnly ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomCssRuleList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_bool (&__objc_super__, selGetMatchedCSSRules_PseudoElement_AuthorOnly_XHandle, element__handle__, nspseudoElement, authorOnly ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (element);
			CFString.ReleaseNative (nspseudoElement);
			return ret!;
		}
		[Export ("getOverrideStyle:pseudoElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomCssStyleDeclaration GetOverrideStyle (DomElement element, string pseudoElement)
		{
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			if (pseudoElement is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (pseudoElement));
			var nspseudoElement = CFString.CreateNative (pseudoElement);
			DomCssStyleDeclaration? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomCssStyleDeclaration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selGetOverrideStyle_PseudoElement_XHandle, element__handle__, nspseudoElement), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomCssStyleDeclaration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selGetOverrideStyle_PseudoElement_XHandle, element__handle__, nspseudoElement), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (element);
			CFString.ReleaseNative (nspseudoElement);
			return ret!;
		}
		[Export ("importNode:deep:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNode ImportNode (DomNode importedNode, bool deep)
		{
			var importedNode__handle__ = importedNode!.GetNonNullHandle (nameof (importedNode));
			DomNode? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_bool (this.Handle, selImportNode_Deep_XHandle, importedNode__handle__, deep ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_bool (&__objc_super__, selImportNode_Deep_XHandle, importedNode__handle__, deep ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (importedNode);
			return ret!;
		}
		[Export ("queryCommandEnabled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool QueryCommandEnabled (string command)
		{
			if (command is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (command));
			var nscommand = CFString.CreateNative (command);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selQueryCommandEnabled_XHandle, nscommand);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selQueryCommandEnabled_XHandle, nscommand);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscommand);
			return ret != 0;
		}
		[Export ("queryCommandIndeterm:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool QueryCommandIndeterm (string command)
		{
			if (command is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (command));
			var nscommand = CFString.CreateNative (command);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selQueryCommandIndeterm_XHandle, nscommand);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selQueryCommandIndeterm_XHandle, nscommand);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscommand);
			return ret != 0;
		}
		[Export ("queryCommandState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool QueryCommandState (string command)
		{
			if (command is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (command));
			var nscommand = CFString.CreateNative (command);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selQueryCommandState_XHandle, nscommand);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selQueryCommandState_XHandle, nscommand);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscommand);
			return ret != 0;
		}
		[Export ("queryCommandSupported:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool QueryCommandSupported (string command)
		{
			if (command is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (command));
			var nscommand = CFString.CreateNative (command);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selQueryCommandSupported_XHandle, nscommand);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selQueryCommandSupported_XHandle, nscommand);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscommand);
			return ret != 0;
		}
		[Export ("queryCommandValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string QueryCommandValue (string command)
		{
			if (command is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (command));
			var nscommand = CFString.CreateNative (command);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selQueryCommandValue_XHandle, nscommand), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selQueryCommandValue_XHandle, nscommand), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nscommand);
			return ret!;
		}
		[Export ("querySelector:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomElement QuerySelector (string selectors)
		{
			if (selectors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (selectors));
			var nsselectors = CFString.CreateNative (selectors);
			DomElement? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selQuerySelector_XHandle, nsselectors), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selQuerySelector_XHandle, nsselectors), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsselectors);
			return ret!;
		}
		[Export ("querySelectorAll:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNodeList QuerySelectorAll (string selectors)
		{
			if (selectors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (selectors));
			var nsselectors = CFString.CreateNative (selectors);
			DomNodeList? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomNodeList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selQuerySelectorAll_XHandle, nsselectors), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomNodeList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selQuerySelectorAll_XHandle, nsselectors), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsselectors);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomHtmlCollection Anchors {
			[Export ("anchors", ArgumentSemantic.Retain)]
			get {
				DomHtmlCollection? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomHtmlCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAnchorsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomHtmlCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAnchorsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomHtmlCollection Applets {
			[Export ("applets", ArgumentSemantic.Retain)]
			get {
				DomHtmlCollection? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomHtmlCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAppletsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomHtmlCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAppletsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomHtmlElement Body {
			[Export ("body", ArgumentSemantic.Retain)]
			get {
				DomHtmlElement? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomHtmlElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBodyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomHtmlElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBodyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBody:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetBody_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetBody_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string CharacterSet {
			[Export ("characterSet", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCharacterSetXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCharacterSetXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Charset {
			[Export ("charset", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCharsetXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCharsetXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCharset:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCharset_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCharset_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Cookie {
			[Export ("cookie", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCookieXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCookieXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setCookie:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetCookie_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetCookie_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DefaultCharset {
			[Export ("defaultCharset", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDefaultCharsetXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDefaultCharsetXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomAbstractView DefaultView {
			[Export ("defaultView", ArgumentSemantic.Retain)]
			get {
				DomAbstractView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomAbstractView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDefaultViewXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomAbstractView> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDefaultViewXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomElement DocumentElement {
			[Export ("documentElement", ArgumentSemantic.Retain)]
			get {
				DomElement? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDocumentElementXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDocumentElementXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomDocumentType DocumentType {
			[Export ("doctype", ArgumentSemantic.Retain)]
			get {
				DomDocumentType? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomDocumentType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDoctypeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomDocumentType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDoctypeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DocumentURI {
			[Export ("documentURI", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDocumentURIXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDocumentURIXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setDocumentURI:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetDocumentURI_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetDocumentURI_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Domain {
			[Export ("domain", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selDomainXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selDomainXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomHtmlCollection Forms {
			[Export ("forms", ArgumentSemantic.Retain)]
			get {
				DomHtmlCollection? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomHtmlCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFormsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomHtmlCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFormsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomHtmlCollection Images {
			[Export ("images", ArgumentSemantic.Retain)]
			get {
				DomHtmlCollection? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomHtmlCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selImagesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomHtmlCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selImagesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomImplementation Implementation {
			[Export ("implementation", ArgumentSemantic.Retain)]
			get {
				DomImplementation? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomImplementation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selImplementationXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomImplementation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selImplementationXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string InputEncoding {
			[Export ("inputEncoding", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInputEncodingXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInputEncodingXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string LastModified {
			[Export ("lastModified", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLastModifiedXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLastModifiedXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomHtmlCollection Links {
			[Export ("links", ArgumentSemantic.Retain)]
			get {
				DomHtmlCollection? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomHtmlCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLinksXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomHtmlCollection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLinksXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string PreferredStylesheetSet {
			[Export ("preferredStylesheetSet", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreferredStylesheetSetXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreferredStylesheetSetXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ReadyState {
			[Export ("readyState", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selReadyStateXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selReadyStateXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Referrer {
			[Export ("referrer", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selReferrerXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selReferrerXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string SelectedStylesheetSet {
			[Export ("selectedStylesheetSet", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSelectedStylesheetSetXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSelectedStylesheetSetXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSelectedStylesheetSet:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSelectedStylesheetSet_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSelectedStylesheetSet_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomStyleSheetList StyleSheets {
			[Export ("styleSheets", ArgumentSemantic.Retain)]
			get {
				DomStyleSheetList? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomStyleSheetList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStyleSheetsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomStyleSheetList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStyleSheetsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Title {
			[Export ("title", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTitleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTitleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTitle:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTitle_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTitle_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Url {
			[Export ("URL", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string XmlEncoding {
			[Export ("xmlEncoding", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selXmlEncodingXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selXmlEncodingXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool XmlStandalone {
			[Export ("xmlStandalone")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selXmlStandaloneXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selXmlStandaloneXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setXmlStandalone:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetXmlStandalone_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetXmlStandalone_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string XmlVersion {
			[Export ("xmlVersion", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selXmlVersionXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selXmlVersionXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setXmlVersion:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetXmlVersion_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetXmlVersion_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Obsolete ("Use the 'Anchors' property instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public virtual DomHtmlCollection anchors {
			get {
				return (Anchors as DomHtmlCollection)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Obsolete ("Use the 'Applets' property instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public virtual DomHtmlCollection applets {
			get {
				return (Applets as DomHtmlCollection)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Obsolete ("Use the 'Body' property instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public virtual DomHtmlElement body {
			get {
				return (Body as DomHtmlElement)!;
			}
			set {
				Body = value;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Obsolete ("Use the 'Forms' property instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public virtual DomHtmlCollection forms {
			get {
				return (Forms as DomHtmlCollection)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Obsolete ("Use the 'Images' property instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public virtual DomHtmlCollection images {
			get {
				return (Images as DomHtmlCollection)!;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Obsolete ("Use the 'Links' property instead.", false)]
		[EditorBrowsable (EditorBrowsableState.Never)]
		public virtual DomHtmlCollection links {
			get {
				return (Links as DomHtmlCollection)!;
			}
		}
	} /* class DomDocument */
}
