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
	[Register("DOMElement", true)]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos10.14", "No longer supported.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class DomElement : DomNode {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBlurX = "blur";
		static readonly NativeHandle selBlurXHandle = Selector.GetHandle ("blur");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChildElementCountX = "childElementCount";
		static readonly NativeHandle selChildElementCountXHandle = Selector.GetHandle ("childElementCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClassNameX = "className";
		static readonly NativeHandle selClassNameXHandle = Selector.GetHandle ("className");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClientHeightX = "clientHeight";
		static readonly NativeHandle selClientHeightXHandle = Selector.GetHandle ("clientHeight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClientLeftX = "clientLeft";
		static readonly NativeHandle selClientLeftXHandle = Selector.GetHandle ("clientLeft");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClientTopX = "clientTop";
		static readonly NativeHandle selClientTopXHandle = Selector.GetHandle ("clientTop");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClientWidthX = "clientWidth";
		static readonly NativeHandle selClientWidthXHandle = Selector.GetHandle ("clientWidth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selContains_X = "contains:";
		static readonly NativeHandle selContains_XHandle = Selector.GetHandle ("contains:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFirstElementChildX = "firstElementChild";
		static readonly NativeHandle selFirstElementChildXHandle = Selector.GetHandle ("firstElementChild");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFocusX = "focus";
		static readonly NativeHandle selFocusXHandle = Selector.GetHandle ("focus");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetAttribute_X = "getAttribute:";
		static readonly NativeHandle selGetAttribute_XHandle = Selector.GetHandle ("getAttribute:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetAttributeNS_LocalName_X = "getAttributeNS:localName:";
		static readonly NativeHandle selGetAttributeNS_LocalName_XHandle = Selector.GetHandle ("getAttributeNS:localName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetAttributeNode_X = "getAttributeNode:";
		static readonly NativeHandle selGetAttributeNode_XHandle = Selector.GetHandle ("getAttributeNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetAttributeNodeNS_LocalName_X = "getAttributeNodeNS:localName:";
		static readonly NativeHandle selGetAttributeNodeNS_LocalName_XHandle = Selector.GetHandle ("getAttributeNodeNS:localName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetElementsByClassName_X = "getElementsByClassName:";
		static readonly NativeHandle selGetElementsByClassName_XHandle = Selector.GetHandle ("getElementsByClassName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetElementsByTagName_X = "getElementsByTagName:";
		static readonly NativeHandle selGetElementsByTagName_XHandle = Selector.GetHandle ("getElementsByTagName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGetElementsByTagNameNS_LocalName_X = "getElementsByTagNameNS:localName:";
		static readonly NativeHandle selGetElementsByTagNameNS_LocalName_XHandle = Selector.GetHandle ("getElementsByTagNameNS:localName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasAttribute_X = "hasAttribute:";
		static readonly NativeHandle selHasAttribute_XHandle = Selector.GetHandle ("hasAttribute:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasAttributeNS_LocalName_X = "hasAttributeNS:localName:";
		static readonly NativeHandle selHasAttributeNS_LocalName_XHandle = Selector.GetHandle ("hasAttributeNS:localName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInnerTextX = "innerText";
		static readonly NativeHandle selInnerTextXHandle = Selector.GetHandle ("innerText");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLastElementChildX = "lastElementChild";
		static readonly NativeHandle selLastElementChildXHandle = Selector.GetHandle ("lastElementChild");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNextElementSiblingX = "nextElementSibling";
		static readonly NativeHandle selNextElementSiblingXHandle = Selector.GetHandle ("nextElementSibling");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOffsetHeightX = "offsetHeight";
		static readonly NativeHandle selOffsetHeightXHandle = Selector.GetHandle ("offsetHeight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOffsetLeftX = "offsetLeft";
		static readonly NativeHandle selOffsetLeftXHandle = Selector.GetHandle ("offsetLeft");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOffsetParentX = "offsetParent";
		static readonly NativeHandle selOffsetParentXHandle = Selector.GetHandle ("offsetParent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOffsetTopX = "offsetTop";
		static readonly NativeHandle selOffsetTopXHandle = Selector.GetHandle ("offsetTop");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOffsetWidthX = "offsetWidth";
		static readonly NativeHandle selOffsetWidthXHandle = Selector.GetHandle ("offsetWidth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreviousElementSiblingX = "previousElementSibling";
		static readonly NativeHandle selPreviousElementSiblingXHandle = Selector.GetHandle ("previousElementSibling");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQuerySelector_X = "querySelector:";
		static readonly NativeHandle selQuerySelector_XHandle = Selector.GetHandle ("querySelector:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selQuerySelectorAll_X = "querySelectorAll:";
		static readonly NativeHandle selQuerySelectorAll_XHandle = Selector.GetHandle ("querySelectorAll:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAttribute_X = "removeAttribute:";
		static readonly NativeHandle selRemoveAttribute_XHandle = Selector.GetHandle ("removeAttribute:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAttributeNS_LocalName_X = "removeAttributeNS:localName:";
		static readonly NativeHandle selRemoveAttributeNS_LocalName_XHandle = Selector.GetHandle ("removeAttributeNS:localName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAttributeNode_X = "removeAttributeNode:";
		static readonly NativeHandle selRemoveAttributeNode_XHandle = Selector.GetHandle ("removeAttributeNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollByLines_X = "scrollByLines:";
		static readonly NativeHandle selScrollByLines_XHandle = Selector.GetHandle ("scrollByLines:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollByPages_X = "scrollByPages:";
		static readonly NativeHandle selScrollByPages_XHandle = Selector.GetHandle ("scrollByPages:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollHeightX = "scrollHeight";
		static readonly NativeHandle selScrollHeightXHandle = Selector.GetHandle ("scrollHeight");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollIntoView_X = "scrollIntoView:";
		static readonly NativeHandle selScrollIntoView_XHandle = Selector.GetHandle ("scrollIntoView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollIntoViewIfNeeded_X = "scrollIntoViewIfNeeded:";
		static readonly NativeHandle selScrollIntoViewIfNeeded_XHandle = Selector.GetHandle ("scrollIntoViewIfNeeded:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollLeftX = "scrollLeft";
		static readonly NativeHandle selScrollLeftXHandle = Selector.GetHandle ("scrollLeft");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollTopX = "scrollTop";
		static readonly NativeHandle selScrollTopXHandle = Selector.GetHandle ("scrollTop");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selScrollWidthX = "scrollWidth";
		static readonly NativeHandle selScrollWidthXHandle = Selector.GetHandle ("scrollWidth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAttribute_Value_X = "setAttribute:value:";
		static readonly NativeHandle selSetAttribute_Value_XHandle = Selector.GetHandle ("setAttribute:value:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAttributeNS_QualifiedName_Value_X = "setAttributeNS:qualifiedName:value:";
		static readonly NativeHandle selSetAttributeNS_QualifiedName_Value_XHandle = Selector.GetHandle ("setAttributeNS:qualifiedName:value:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAttributeNode_X = "setAttributeNode:";
		static readonly NativeHandle selSetAttributeNode_XHandle = Selector.GetHandle ("setAttributeNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAttributeNodeNS_X = "setAttributeNodeNS:";
		static readonly NativeHandle selSetAttributeNodeNS_XHandle = Selector.GetHandle ("setAttributeNodeNS:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetClassName_X = "setClassName:";
		static readonly NativeHandle selSetClassName_XHandle = Selector.GetHandle ("setClassName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetScrollLeft_X = "setScrollLeft:";
		static readonly NativeHandle selSetScrollLeft_XHandle = Selector.GetHandle ("setScrollLeft:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetScrollTop_X = "setScrollTop:";
		static readonly NativeHandle selSetScrollTop_XHandle = Selector.GetHandle ("setScrollTop:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStyleX = "style";
		static readonly NativeHandle selStyleXHandle = Selector.GetHandle ("style");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTagNameX = "tagName";
		static readonly NativeHandle selTagNameXHandle = Selector.GetHandle ("tagName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWebkitRequestFullScreen_X = "webkitRequestFullScreen:";
		static readonly NativeHandle selWebkitRequestFullScreen_XHandle = Selector.GetHandle ("webkitRequestFullScreen:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("DOMElement");
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
		protected DomElement (NSObjectFlag t) : base (t)
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
		protected internal DomElement (NativeHandle handle) : base (handle)
		{
		}

		[Export ("blur")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Blur ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selBlurXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selBlurXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("contains:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Contains (DomElement element)
		{
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selContains_XHandle, element__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selContains_XHandle, element__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (element);
			return ret != 0;
		}
		[Export ("focus")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Focus ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selFocusXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selFocusXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("getAttribute:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetAttribute (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selGetAttribute_XHandle, nsname), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selGetAttribute_XHandle, nsname), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("getAttributeNS:localName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetAttributeNS (string namespaceURI, string localName)
		{
			if (namespaceURI is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (namespaceURI));
			if (localName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localName));
			var nsnamespaceURI = CFString.CreateNative (namespaceURI);
			var nslocalName = CFString.CreateNative (localName);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selGetAttributeNS_LocalName_XHandle, nsnamespaceURI, nslocalName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selGetAttributeNS_LocalName_XHandle, nsnamespaceURI, nslocalName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsnamespaceURI);
			CFString.ReleaseNative (nslocalName);
			return ret!;
		}
		[Export ("getAttributeNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomAttr GetAttributeNode (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			DomAttr? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomAttr> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selGetAttributeNode_XHandle, nsname), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomAttr> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selGetAttributeNode_XHandle, nsname), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("getAttributeNodeNS:localName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomAttr GetAttributeNodeNS (string namespaceURI, string localName)
		{
			if (namespaceURI is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (namespaceURI));
			if (localName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localName));
			var nsnamespaceURI = CFString.CreateNative (namespaceURI);
			var nslocalName = CFString.CreateNative (localName);
			DomAttr? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomAttr> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selGetAttributeNodeNS_LocalName_XHandle, nsnamespaceURI, nslocalName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomAttr> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selGetAttributeNodeNS_LocalName_XHandle, nsnamespaceURI, nslocalName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsnamespaceURI);
			CFString.ReleaseNative (nslocalName);
			return ret!;
		}
		[Export ("getElementsByClassName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNodeList GetElementsByClassName (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			DomNodeList? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomNodeList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selGetElementsByClassName_XHandle, nsname), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomNodeList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selGetElementsByClassName_XHandle, nsname), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("getElementsByTagName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNodeList GetElementsByTagName (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			DomNodeList? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomNodeList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selGetElementsByTagName_XHandle, nsname), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomNodeList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selGetElementsByTagName_XHandle, nsname), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
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
		[Export ("hasAttribute:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasAttribute (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selHasAttribute_XHandle, nsname);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selHasAttribute_XHandle, nsname);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			return ret != 0;
		}
		[Export ("hasAttributeNS:localName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasAttributeNS (string namespaceURI, string localName)
		{
			if (namespaceURI is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (namespaceURI));
			if (localName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localName));
			var nsnamespaceURI = CFString.CreateNative (namespaceURI);
			var nslocalName = CFString.CreateNative (localName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selHasAttributeNS_LocalName_XHandle, nsnamespaceURI, nslocalName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selHasAttributeNS_LocalName_XHandle, nsnamespaceURI, nslocalName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsnamespaceURI);
			CFString.ReleaseNative (nslocalName);
			return ret != 0;
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
		[Export ("removeAttribute:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAttribute (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveAttribute_XHandle, nsname);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveAttribute_XHandle, nsname);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
		}
		[Export ("removeAttributeNS:localName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAttributeNS (string namespaceURI, string localName)
		{
			if (namespaceURI is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (namespaceURI));
			if (localName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (localName));
			var nsnamespaceURI = CFString.CreateNative (namespaceURI);
			var nslocalName = CFString.CreateNative (localName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selRemoveAttributeNS_LocalName_XHandle, nsnamespaceURI, nslocalName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selRemoveAttributeNS_LocalName_XHandle, nsnamespaceURI, nslocalName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsnamespaceURI);
			CFString.ReleaseNative (nslocalName);
		}
		[Export ("removeAttributeNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomAttr RemoveAttributeNode (DomAttr oldAttr)
		{
			var oldAttr__handle__ = oldAttr!.GetNonNullHandle (nameof (oldAttr));
			DomAttr? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomAttr> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selRemoveAttributeNode_XHandle, oldAttr__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomAttr> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveAttributeNode_XHandle, oldAttr__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (oldAttr);
			return ret!;
		}
		[Export ("scrollByLines:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrollByLines (int lines)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selScrollByLines_XHandle, lines);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int (&__objc_super__, selScrollByLines_XHandle, lines);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("scrollByPages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrollByPages (int pages)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selScrollByPages_XHandle, pages);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int (&__objc_super__, selScrollByPages_XHandle, pages);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("scrollIntoView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrollIntoView (bool alignWithTop)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selScrollIntoView_XHandle, alignWithTop ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selScrollIntoView_XHandle, alignWithTop ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("scrollIntoViewIfNeeded:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrollIntoViewIfNeeded (bool centerIfNeeded)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selScrollIntoViewIfNeeded_XHandle, centerIfNeeded ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selScrollIntoViewIfNeeded_XHandle, centerIfNeeded ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setAttribute:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAttribute (string name, string value)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsname = CFString.CreateNative (name);
			var nsvalue = CFString.CreateNative (value);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetAttribute_Value_XHandle, nsname, nsvalue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetAttribute_Value_XHandle, nsname, nsvalue);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
			CFString.ReleaseNative (nsvalue);
		}
		[Export ("setAttributeNS:qualifiedName:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAttributeNS (string namespaceURI, string qualifiedName, string value)
		{
			if (namespaceURI is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (namespaceURI));
			if (qualifiedName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (qualifiedName));
			if (value is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
			var nsnamespaceURI = CFString.CreateNative (namespaceURI);
			var nsqualifiedName = CFString.CreateNative (qualifiedName);
			var nsvalue = CFString.CreateNative (value);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selSetAttributeNS_QualifiedName_Value_XHandle, nsnamespaceURI, nsqualifiedName, nsvalue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selSetAttributeNS_QualifiedName_Value_XHandle, nsnamespaceURI, nsqualifiedName, nsvalue);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsnamespaceURI);
			CFString.ReleaseNative (nsqualifiedName);
			CFString.ReleaseNative (nsvalue);
		}
		[Export ("setAttributeNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomAttr SetAttributeNode (DomAttr newAttr)
		{
			var newAttr__handle__ = newAttr!.GetNonNullHandle (nameof (newAttr));
			DomAttr? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomAttr> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selSetAttributeNode_XHandle, newAttr__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomAttr> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAttributeNode_XHandle, newAttr__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newAttr);
			return ret!;
		}
		[Export ("setAttributeNodeNS:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomAttr SetAttributeNodeNS (DomAttr newAttr)
		{
			var newAttr__handle__ = newAttr!.GetNonNullHandle (nameof (newAttr));
			DomAttr? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomAttr> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selSetAttributeNodeNS_XHandle, newAttr__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomAttr> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAttributeNodeNS_XHandle, newAttr__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newAttr);
			return ret!;
		}
		[Export ("webkitRequestFullScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WebKitRequestFullScreen (ushort flags)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UInt16 (this.Handle, selWebkitRequestFullScreen_XHandle, flags);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt16 (&__objc_super__, selWebkitRequestFullScreen_XHandle, flags);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint ChildElementCount {
			[Export ("childElementCount")]
			get {
				uint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selChildElementCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selChildElementCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ClassName {
			[Export ("className", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selClassNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selClassNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setClassName:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetClassName_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetClassName_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int ClientHeight {
			[Export ("clientHeight")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selClientHeightXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selClientHeightXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int ClientLeft {
			[Export ("clientLeft")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selClientLeftXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selClientLeftXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int ClientTop {
			[Export ("clientTop")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selClientTopXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selClientTopXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int ClientWidth {
			[Export ("clientWidth")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selClientWidthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selClientWidthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomElement FirstElementChild {
			[Export ("firstElementChild", ArgumentSemantic.Retain)]
			get {
				DomElement? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFirstElementChildXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFirstElementChildXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string InnerText {
			[Export ("innerText", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selInnerTextXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selInnerTextXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomElement LastElementChild {
			[Export ("lastElementChild", ArgumentSemantic.Retain)]
			get {
				DomElement? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLastElementChildXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLastElementChildXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomElement NextElementSibling {
			[Export ("nextElementSibling", ArgumentSemantic.Retain)]
			get {
				DomElement? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNextElementSiblingXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNextElementSiblingXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int OffsetHeight {
			[Export ("offsetHeight")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selOffsetHeightXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selOffsetHeightXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int OffsetLeft {
			[Export ("offsetLeft")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selOffsetLeftXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selOffsetLeftXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomElement OffsetParent {
			[Export ("offsetParent", ArgumentSemantic.Retain)]
			get {
				DomElement? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOffsetParentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOffsetParentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int OffsetTop {
			[Export ("offsetTop")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selOffsetTopXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selOffsetTopXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int OffsetWidth {
			[Export ("offsetWidth")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selOffsetWidthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selOffsetWidthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomElement PreviousElementSibling {
			[Export ("previousElementSibling", ArgumentSemantic.Retain)]
			get {
				DomElement? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreviousElementSiblingXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreviousElementSiblingXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int ScrollHeight {
			[Export ("scrollHeight")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selScrollHeightXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selScrollHeightXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int ScrollLeft {
			[Export ("scrollLeft")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selScrollLeftXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selScrollLeftXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setScrollLeft:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetScrollLeft_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int (&__objc_super__, selSetScrollLeft_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int ScrollTop {
			[Export ("scrollTop")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selScrollTopXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selScrollTopXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setScrollTop:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetScrollTop_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int (&__objc_super__, selSetScrollTop_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int ScrollWidth {
			[Export ("scrollWidth")]
			get {
				int ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selScrollWidthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.int_objc_msgSendSuper (&__objc_super__, selScrollWidthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomCssStyleDeclaration Style {
			[Export ("style", ArgumentSemantic.Retain)]
			get {
				DomCssStyleDeclaration? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomCssStyleDeclaration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selStyleXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomCssStyleDeclaration> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selStyleXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string TagName {
			[Export ("tagName", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTagNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTagNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class DomElement */
}
