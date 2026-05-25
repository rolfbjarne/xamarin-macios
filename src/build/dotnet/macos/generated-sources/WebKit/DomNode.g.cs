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
	[Register("DOMNode", true)]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos10.14", "No longer supported.")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class DomNode : DomObject, IDomEventTarget, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddEventListener_Listener_UseCapture_X = "addEventListener:listener:useCapture:";
		static readonly NativeHandle selAddEventListener_Listener_UseCapture_XHandle = Selector.GetHandle ("addEventListener:listener:useCapture:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAppendChild_X = "appendChild:";
		static readonly NativeHandle selAppendChild_XHandle = Selector.GetHandle ("appendChild:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributesX = "attributes";
		static readonly NativeHandle selAttributesXHandle = Selector.GetHandle ("attributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBaseURIX = "baseURI";
		static readonly NativeHandle selBaseURIXHandle = Selector.GetHandle ("baseURI");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChildNodesX = "childNodes";
		static readonly NativeHandle selChildNodesXHandle = Selector.GetHandle ("childNodes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCloneNode_X = "cloneNode:";
		static readonly NativeHandle selCloneNode_XHandle = Selector.GetHandle ("cloneNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCompareDocumentPosition_X = "compareDocumentPosition:";
		static readonly NativeHandle selCompareDocumentPosition_XHandle = Selector.GetHandle ("compareDocumentPosition:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDispatchEvent_X = "dispatchEvent:";
		static readonly NativeHandle selDispatchEvent_XHandle = Selector.GetHandle ("dispatchEvent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFirstChildX = "firstChild";
		static readonly NativeHandle selFirstChildXHandle = Selector.GetHandle ("firstChild");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasAttributesX = "hasAttributes";
		static readonly NativeHandle selHasAttributesXHandle = Selector.GetHandle ("hasAttributes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selHasChildNodesX = "hasChildNodes";
		static readonly NativeHandle selHasChildNodesXHandle = Selector.GetHandle ("hasChildNodes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInsertBefore_RefChild_X = "insertBefore:refChild:";
		static readonly NativeHandle selInsertBefore_RefChild_XHandle = Selector.GetHandle ("insertBefore:refChild:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsContentEditableX = "isContentEditable";
		static readonly NativeHandle selIsContentEditableXHandle = Selector.GetHandle ("isContentEditable");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsDefaultNamespace_X = "isDefaultNamespace:";
		static readonly NativeHandle selIsDefaultNamespace_XHandle = Selector.GetHandle ("isDefaultNamespace:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEqualNode_X = "isEqualNode:";
		static readonly NativeHandle selIsEqualNode_XHandle = Selector.GetHandle ("isEqualNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSameNode_X = "isSameNode:";
		static readonly NativeHandle selIsSameNode_XHandle = Selector.GetHandle ("isSameNode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSupported_Version_X = "isSupported:version:";
		static readonly NativeHandle selIsSupported_Version_XHandle = Selector.GetHandle ("isSupported:version:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLastChildX = "lastChild";
		static readonly NativeHandle selLastChildXHandle = Selector.GetHandle ("lastChild");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLocalNameX = "localName";
		static readonly NativeHandle selLocalNameXHandle = Selector.GetHandle ("localName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLookupNamespaceURI_X = "lookupNamespaceURI:";
		static readonly NativeHandle selLookupNamespaceURI_XHandle = Selector.GetHandle ("lookupNamespaceURI:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLookupPrefix_X = "lookupPrefix:";
		static readonly NativeHandle selLookupPrefix_XHandle = Selector.GetHandle ("lookupPrefix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNamespaceURIX = "namespaceURI";
		static readonly NativeHandle selNamespaceURIXHandle = Selector.GetHandle ("namespaceURI");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNextSiblingX = "nextSibling";
		static readonly NativeHandle selNextSiblingXHandle = Selector.GetHandle ("nextSibling");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNodeNameX = "nodeName";
		static readonly NativeHandle selNodeNameXHandle = Selector.GetHandle ("nodeName");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNodeTypeX = "nodeType";
		static readonly NativeHandle selNodeTypeXHandle = Selector.GetHandle ("nodeType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNodeValueX = "nodeValue";
		static readonly NativeHandle selNodeValueXHandle = Selector.GetHandle ("nodeValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNormalizeX = "normalize";
		static readonly NativeHandle selNormalizeXHandle = Selector.GetHandle ("normalize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOwnerDocumentX = "ownerDocument";
		static readonly NativeHandle selOwnerDocumentXHandle = Selector.GetHandle ("ownerDocument");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParentElementX = "parentElement";
		static readonly NativeHandle selParentElementXHandle = Selector.GetHandle ("parentElement");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selParentNodeX = "parentNode";
		static readonly NativeHandle selParentNodeXHandle = Selector.GetHandle ("parentNode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPrefixX = "prefix";
		static readonly NativeHandle selPrefixXHandle = Selector.GetHandle ("prefix");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPreviousSiblingX = "previousSibling";
		static readonly NativeHandle selPreviousSiblingXHandle = Selector.GetHandle ("previousSibling");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveChild_X = "removeChild:";
		static readonly NativeHandle selRemoveChild_XHandle = Selector.GetHandle ("removeChild:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveEventListener_Listener_UseCapture_X = "removeEventListener:listener:useCapture:";
		static readonly NativeHandle selRemoveEventListener_Listener_UseCapture_XHandle = Selector.GetHandle ("removeEventListener:listener:useCapture:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplaceChild_OldChild_X = "replaceChild:oldChild:";
		static readonly NativeHandle selReplaceChild_OldChild_XHandle = Selector.GetHandle ("replaceChild:oldChild:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNodeValue_X = "setNodeValue:";
		static readonly NativeHandle selSetNodeValue_XHandle = Selector.GetHandle ("setNodeValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPrefix_X = "setPrefix:";
		static readonly NativeHandle selSetPrefix_XHandle = Selector.GetHandle ("setPrefix:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTextContent_X = "setTextContent:";
		static readonly NativeHandle selSetTextContent_XHandle = Selector.GetHandle ("setTextContent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextContentX = "textContent";
		static readonly NativeHandle selTextContentXHandle = Selector.GetHandle ("textContent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("DOMNode");
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
		protected DomNode (NSObjectFlag t) : base (t)
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
		protected internal DomNode (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="type">To be added.</param><param name="listener">To be added.</param><param name="useCapture">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("addEventListener:listener:useCapture:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "No longer supported.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddEventListener (string type, IDomEventListener listener, bool useCapture)
		{
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var listener__handle__ = listener!.GetNonNullHandle (nameof (listener));
			var nstype = CFString.CreateNative (type);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (this.Handle, selAddEventListener_Listener_UseCapture_XHandle, nstype, listener__handle__, useCapture ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_bool (&__objc_super__, selAddEventListener_Listener_UseCapture_XHandle, nstype, listener__handle__, useCapture ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (listener);
			CFString.ReleaseNative (nstype);
		}
		[Export ("appendChild:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNode AppendChild (DomNode newChild)
		{
			var newChild__handle__ = newChild!.GetNonNullHandle (nameof (newChild));
			DomNode? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selAppendChild_XHandle, newChild__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selAppendChild_XHandle, newChild__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newChild);
			return ret!;
		}
		[Export ("cloneNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNode CloneNode (bool deep)
		{
			DomNode ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_bool (this.Handle, selCloneNode_XHandle, deep ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_bool (&__objc_super__, selCloneNode_XHandle, deep ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("compareDocumentPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomDocumentPosition CompareDocumentPosition (DomNode other)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			DomDocumentPosition ret;
			if (IsDirectBinding) {
				ret = (DomDocumentPosition) global::ObjCRuntime.Messaging.UInt16_objc_msgSend_NativeHandle (this.Handle, selCompareDocumentPosition_XHandle, other__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (DomDocumentPosition) global::ObjCRuntime.Messaging.UInt16_objc_msgSendSuper_NativeHandle (&__objc_super__, selCompareDocumentPosition_XHandle, other__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
			return ret!;
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "No longer supported.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual NSObject Copy (NSZone? zone)
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
		/// <param name="evt">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("dispatchEvent:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "No longer supported.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DispatchEvent (DomEvent evt)
		{
			var evt__handle__ = evt!.GetNonNullHandle (nameof (evt));
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selDispatchEvent_XHandle, evt__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selDispatchEvent_XHandle, evt__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (evt);
			return ret != 0;
		}
		[Export ("hasAttributes")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasAttributes ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasAttributesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasAttributesXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("hasChildNodes")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasChildNodes ()
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selHasChildNodesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selHasChildNodesXHandle);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("insertBefore:refChild:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNode InsertBefore (DomNode newChild, DomNode? refChild)
		{
			var newChild__handle__ = newChild!.GetNonNullHandle (nameof (newChild));
			var refChild__handle__ = refChild.GetHandle ();
			DomNode? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInsertBefore_RefChild_XHandle, newChild__handle__, refChild__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInsertBefore_RefChild_XHandle, newChild__handle__, refChild__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newChild);
			GC.KeepAlive (refChild);
			return ret!;
		}
		[Export ("isDefaultNamespace:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsDefaultNamespace (string namespaceURI)
		{
			if (namespaceURI is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (namespaceURI));
			var nsnamespaceURI = CFString.CreateNative (namespaceURI);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsDefaultNamespace_XHandle, nsnamespaceURI);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsDefaultNamespace_XHandle, nsnamespaceURI);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsnamespaceURI);
			return ret != 0;
		}
		[Export ("isEqualNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEqualNode (DomNode? other)
		{
			var other__handle__ = other.GetHandle ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsEqualNode_XHandle, other__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsEqualNode_XHandle, other__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
			return ret != 0;
		}
		[Export ("isSameNode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsSameNode (DomNode? other)
		{
			var other__handle__ = other.GetHandle ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (this.Handle, selIsSameNode_XHandle, other__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle (&__objc_super__, selIsSameNode_XHandle, other__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
			return ret != 0;
		}
		[Export ("isSupported:version:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsSupported (string feature, string version)
		{
			if (feature is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (feature));
			if (version is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (version));
			var nsfeature = CFString.CreateNative (feature);
			var nsversion = CFString.CreateNative (version);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selIsSupported_Version_XHandle, nsfeature, nsversion);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selIsSupported_Version_XHandle, nsfeature, nsversion);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsfeature);
			CFString.ReleaseNative (nsversion);
			return ret != 0;
		}
		[Export ("lookupNamespaceURI:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string LookupNamespace (string prefix)
		{
			if (prefix is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (prefix));
			var nsprefix = CFString.CreateNative (prefix);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selLookupNamespaceURI_XHandle, nsprefix), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selLookupNamespaceURI_XHandle, nsprefix), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsprefix);
			return ret!;
		}
		[Export ("lookupPrefix:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string LookupPrefix (string namespaceURI)
		{
			if (namespaceURI is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (namespaceURI));
			var nsnamespaceURI = CFString.CreateNative (namespaceURI);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selLookupPrefix_XHandle, nsnamespaceURI), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selLookupPrefix_XHandle, nsnamespaceURI), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsnamespaceURI);
			return ret!;
		}
		[Export ("normalize")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Normalize ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selNormalizeXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selNormalizeXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeChild:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNode RemoveChild (DomNode oldChild)
		{
			var oldChild__handle__ = oldChild!.GetNonNullHandle (nameof (oldChild));
			DomNode? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selRemoveChild_XHandle, oldChild__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveChild_XHandle, oldChild__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (oldChild);
			return ret!;
		}
		/// <param name="type">To be added.</param><param name="listener">To be added.</param><param name="useCapture">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeEventListener:listener:useCapture:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos12.0", "No longer supported.")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveEventListener (string type, IDomEventListener listener, bool useCapture)
		{
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var listener__handle__ = listener!.GetNonNullHandle (nameof (listener));
			var nstype = CFString.CreateNative (type);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_bool (this.Handle, selRemoveEventListener_Listener_UseCapture_XHandle, nstype, listener__handle__, useCapture ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_bool (&__objc_super__, selRemoveEventListener_Listener_UseCapture_XHandle, nstype, listener__handle__, useCapture ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (listener);
			CFString.ReleaseNative (nstype);
		}
		[Export ("replaceChild:oldChild:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNode ReplaceChild (DomNode newChild, DomNode oldChild)
		{
			var newChild__handle__ = newChild!.GetNonNullHandle (nameof (newChild));
			var oldChild__handle__ = oldChild!.GetNonNullHandle (nameof (oldChild));
			DomNode? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selReplaceChild_OldChild_XHandle, newChild__handle__, oldChild__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selReplaceChild_OldChild_XHandle, newChild__handle__, oldChild__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newChild);
			GC.KeepAlive (oldChild);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNamedNodeMap Attributes {
			[Export ("attributes", ArgumentSemantic.Retain)]
			get {
				DomNamedNodeMap? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomNamedNodeMap> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAttributesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomNamedNodeMap> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAttributesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string BaseURI {
			[Export ("baseURI", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBaseURIXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBaseURIXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNodeList ChildNodes {
			[Export ("childNodes", ArgumentSemantic.Retain)]
			get {
				DomNodeList? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomNodeList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selChildNodesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomNodeList> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selChildNodesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNode FirstChild {
			[Export ("firstChild", ArgumentSemantic.Retain)]
			get {
				DomNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFirstChildXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFirstChildXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsContentEditable {
			[Export ("isContentEditable")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsContentEditableXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsContentEditableXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNode LastChild {
			[Export ("lastChild", ArgumentSemantic.Retain)]
			get {
				DomNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLastChildXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLastChildXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string LocalName {
			[Export ("localName", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLocalNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLocalNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Name {
			[Export ("nodeName", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNodeNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNodeNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string NamespaceURI {
			[Export ("namespaceURI", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNamespaceURIXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNamespaceURIXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNode NextSibling {
			[Export ("nextSibling", ArgumentSemantic.Retain)]
			get {
				DomNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNextSiblingXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNextSiblingXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNodeType NodeType {
			[Export ("nodeType")]
			get {
				DomNodeType ret;
				if (IsDirectBinding) {
					ret = (DomNodeType) global::ObjCRuntime.Messaging.UInt16_objc_msgSend (this.Handle, selNodeTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (DomNodeType) global::ObjCRuntime.Messaging.UInt16_objc_msgSendSuper (&__objc_super__, selNodeTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string NodeValue {
			[Export ("nodeValue", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNodeValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNodeValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setNodeValue:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetNodeValue_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetNodeValue_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomDocument OwnerDocument {
			[Export ("ownerDocument", ArgumentSemantic.Retain)]
			get {
				DomDocument? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomDocument> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOwnerDocumentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomDocument> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOwnerDocumentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomElement ParentElement {
			[Export ("parentElement", ArgumentSemantic.Retain)]
			get {
				DomElement? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selParentElementXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomElement> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selParentElementXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNode ParentNode {
			[Export ("parentNode", ArgumentSemantic.Retain)]
			get {
				DomNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selParentNodeXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selParentNodeXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Prefix {
			[Export ("prefix", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPrefixXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPrefixXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPrefix:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetPrefix_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetPrefix_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual DomNode PreviousSibling {
			[Export ("previousSibling", ArgumentSemantic.Retain)]
			get {
				DomNode? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selPreviousSiblingXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<DomNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selPreviousSiblingXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string TextContent {
			[Export ("textContent", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextContentXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextContentXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTextContent:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTextContent_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTextContent_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
	} /* class DomNode */
}
