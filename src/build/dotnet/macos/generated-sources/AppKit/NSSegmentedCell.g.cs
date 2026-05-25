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
	[Register("NSSegmentedCell", true)]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSSegmentedCell : NSActionCell {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDrawSegment_InFrame_WithView_X = "drawSegment:inFrame:withView:";
		static readonly NativeHandle selDrawSegment_InFrame_WithView_XHandle = Selector.GetHandle ("drawSegment:inFrame:withView:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageForSegment_X = "imageForSegment:";
		static readonly NativeHandle selImageForSegment_XHandle = Selector.GetHandle ("imageForSegment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImageScalingForSegment_X = "imageScalingForSegment:";
		static readonly NativeHandle selImageScalingForSegment_XHandle = Selector.GetHandle ("imageScalingForSegment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitImageCell_X = "initImageCell:";
		static readonly NativeHandle selInitImageCell_XHandle = Selector.GetHandle ("initImageCell:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitTextCell_X = "initTextCell:";
		static readonly NativeHandle selInitTextCell_XHandle = Selector.GetHandle ("initTextCell:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsEnabledForSegment_X = "isEnabledForSegment:";
		static readonly NativeHandle selIsEnabledForSegment_XHandle = Selector.GetHandle ("isEnabledForSegment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsSelectedForSegment_X = "isSelectedForSegment:";
		static readonly NativeHandle selIsSelectedForSegment_XHandle = Selector.GetHandle ("isSelectedForSegment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLabelForSegment_X = "labelForSegment:";
		static readonly NativeHandle selLabelForSegment_XHandle = Selector.GetHandle ("labelForSegment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMakeNextSegmentKeyX = "makeNextSegmentKey";
		static readonly NativeHandle selMakeNextSegmentKeyXHandle = Selector.GetHandle ("makeNextSegmentKey");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMakePreviousSegmentKeyX = "makePreviousSegmentKey";
		static readonly NativeHandle selMakePreviousSegmentKeyXHandle = Selector.GetHandle ("makePreviousSegmentKey");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMenuForSegment_X = "menuForSegment:";
		static readonly NativeHandle selMenuForSegment_XHandle = Selector.GetHandle ("menuForSegment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSegmentCountX = "segmentCount";
		static readonly NativeHandle selSegmentCountXHandle = Selector.GetHandle ("segmentCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSegmentStyleX = "segmentStyle";
		static readonly NativeHandle selSegmentStyleXHandle = Selector.GetHandle ("segmentStyle");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectSegmentWithTag_X = "selectSegmentWithTag:";
		static readonly NativeHandle selSelectSegmentWithTag_XHandle = Selector.GetHandle ("selectSegmentWithTag:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectedSegmentX = "selectedSegment";
		static readonly NativeHandle selSelectedSegmentXHandle = Selector.GetHandle ("selectedSegment");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEnabled_ForSegment_X = "setEnabled:forSegment:";
		static readonly NativeHandle selSetEnabled_ForSegment_XHandle = Selector.GetHandle ("setEnabled:forSegment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetImage_ForSegment_X = "setImage:forSegment:";
		static readonly NativeHandle selSetImage_ForSegment_XHandle = Selector.GetHandle ("setImage:forSegment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetImageScaling_ForSegment_X = "setImageScaling:forSegment:";
		static readonly NativeHandle selSetImageScaling_ForSegment_XHandle = Selector.GetHandle ("setImageScaling:forSegment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLabel_ForSegment_X = "setLabel:forSegment:";
		static readonly NativeHandle selSetLabel_ForSegment_XHandle = Selector.GetHandle ("setLabel:forSegment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMenu_ForSegment_X = "setMenu:forSegment:";
		static readonly NativeHandle selSetMenu_ForSegment_XHandle = Selector.GetHandle ("setMenu:forSegment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSegmentCount_X = "setSegmentCount:";
		static readonly NativeHandle selSetSegmentCount_XHandle = Selector.GetHandle ("setSegmentCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSegmentStyle_X = "setSegmentStyle:";
		static readonly NativeHandle selSetSegmentStyle_XHandle = Selector.GetHandle ("setSegmentStyle:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelected_ForSegment_X = "setSelected:forSegment:";
		static readonly NativeHandle selSetSelected_ForSegment_XHandle = Selector.GetHandle ("setSelected:forSegment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSelectedSegment_X = "setSelectedSegment:";
		static readonly NativeHandle selSetSelectedSegment_XHandle = Selector.GetHandle ("setSelectedSegment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTag_ForSegment_X = "setTag:forSegment:";
		static readonly NativeHandle selSetTag_ForSegment_XHandle = Selector.GetHandle ("setTag:forSegment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetToolTip_ForSegment_X = "setToolTip:forSegment:";
		static readonly NativeHandle selSetToolTip_ForSegment_XHandle = Selector.GetHandle ("setToolTip:forSegment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTrackingMode_X = "setTrackingMode:";
		static readonly NativeHandle selSetTrackingMode_XHandle = Selector.GetHandle ("setTrackingMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetWidth_ForSegment_X = "setWidth:forSegment:";
		static readonly NativeHandle selSetWidth_ForSegment_XHandle = Selector.GetHandle ("setWidth:forSegment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTagForSegment_X = "tagForSegment:";
		static readonly NativeHandle selTagForSegment_XHandle = Selector.GetHandle ("tagForSegment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selToolTipForSegment_X = "toolTipForSegment:";
		static readonly NativeHandle selToolTipForSegment_XHandle = Selector.GetHandle ("toolTipForSegment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTrackingModeX = "trackingMode";
		static readonly NativeHandle selTrackingModeXHandle = Selector.GetHandle ("trackingMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWidthForSegment_X = "widthForSegment:";
		static readonly NativeHandle selWidthForSegment_XHandle = Selector.GetHandle ("widthForSegment:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSSegmentedCell");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSSegmentedCell" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSSegmentedCell () : base (NSObjectFlag.Empty)
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
		public NSSegmentedCell (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSSegmentedCell (NSObjectFlag t) : base (t)
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
		protected internal NSSegmentedCell (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initTextCell:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSSegmentedCell (string aString)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (aString is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (aString));
			var nsaString = CFString.CreateNative (aString);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitTextCell_XHandle, nsaString), "initTextCell:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitTextCell_XHandle, nsaString), "initTextCell:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsaString);
		}
		[Export ("initImageCell:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSSegmentedCell (NSImage image)
			: base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitImageCell_XHandle, image__handle__), "initImageCell:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitImageCell_XHandle, image__handle__), "initImageCell:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		[Export ("drawSegment:inFrame:withView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DrawSegment (nint segment, CGRect frame, NSView controlView)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var controlView__handle__ = controlView!.GetNonNullHandle (nameof (controlView));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_CGRect_NativeHandle (this.Handle, selDrawSegment_InFrame_WithView_XHandle, segment, frame, controlView__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_CGRect_NativeHandle (&__objc_super__, selDrawSegment_InFrame_WithView_XHandle, segment, frame, controlView__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (controlView);
		}
		[Export ("imageForSegment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSImage GetImageForSegment (nint forSegment)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selImageForSegment_XHandle, forSegment), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selImageForSegment_XHandle, forSegment), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("imageScalingForSegment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSImageScaling GetImageScaling (nint forSegment)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSImageScaling ret;
			if (IsDirectBinding) {
				ret = (NSImageScaling) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_IntPtr (this.Handle, selImageScalingForSegment_XHandle, forSegment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (NSImageScaling) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, selImageScalingForSegment_XHandle, forSegment);
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		[Export ("labelForSegment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string GetLabel (nint forSegment)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selLabelForSegment_XHandle, forSegment), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selLabelForSegment_XHandle, forSegment), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("menuForSegment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMenu GetMenu (nint forSegment)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			NSMenu ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selMenuForSegment_XHandle, forSegment), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSMenu> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selMenuForSegment_XHandle, forSegment), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("tagForSegment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint GetTag (nint forSegment)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selTagForSegment_XHandle, forSegment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, selTagForSegment_XHandle, forSegment);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("toolTipForSegment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetToolTip (nint forSegment)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			string ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, selToolTipForSegment_XHandle, forSegment), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, selToolTipForSegment_XHandle, forSegment), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("widthForSegment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat GetWidth (nint forSegment)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			nfloat ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend_IntPtr (this.Handle, selWidthForSegment_XHandle, forSegment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper_IntPtr (&__objc_super__, selWidthForSegment_XHandle, forSegment);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("makeNextSegmentKey")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertSegmentAfterSelection ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selMakeNextSegmentKeyXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selMakeNextSegmentKeyXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("makePreviousSegmentKey")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertSegmentBeforeSelection ()
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selMakePreviousSegmentKeyXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selMakePreviousSegmentKeyXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("isEnabledForSegment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsEnabled (nint forSegment)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsEnabledForSegment_XHandle, forSegment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, selIsEnabledForSegment_XHandle, forSegment);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("isSelectedForSegment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsSelected (nint forSegment)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIsSelectedForSegment_XHandle, forSegment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, selIsSelectedForSegment_XHandle, forSegment);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("selectSegmentWithTag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SelectSegment (nint tag)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selSelectSegmentWithTag_XHandle, tag);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (&__objc_super__, selSelectSegmentWithTag_XHandle, tag);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		[Export ("setEnabled:forSegment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetEnabled (bool enabled, nint forSegment)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, selSetEnabled_ForSegment_XHandle, enabled ? (byte) 1 : (byte) 0, forSegment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_IntPtr (&__objc_super__, selSetEnabled_ForSegment_XHandle, enabled ? (byte) 1 : (byte) 0, forSegment);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setImage:forSegment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetImage (NSImage image, nint forSegment)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selSetImage_ForSegment_XHandle, image__handle__, forSegment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selSetImage_ForSegment_XHandle, image__handle__, forSegment);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		[Export ("setImageScaling:forSegment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetImageScaling (NSImageScaling scaling, nint forSegment)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_IntPtr (this.Handle, selSetImageScaling_ForSegment_XHandle, (UIntPtr) (ulong) scaling, forSegment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_IntPtr (&__objc_super__, selSetImageScaling_ForSegment_XHandle, (UIntPtr) (ulong) scaling, forSegment);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setLabel:forSegment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetLabel (string label, nint forSegment)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (label is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (label));
			var nslabel = CFString.CreateNative (label);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selSetLabel_ForSegment_XHandle, nslabel, forSegment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selSetLabel_ForSegment_XHandle, nslabel, forSegment);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nslabel);
		}
		[Export ("setMenu:forSegment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMenu (NSMenu menu, nint forSegment)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var menu__handle__ = menu!.GetNonNullHandle (nameof (menu));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selSetMenu_ForSegment_XHandle, menu__handle__, forSegment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selSetMenu_ForSegment_XHandle, menu__handle__, forSegment);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (menu);
		}
		[Export ("setSelected:forSegment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSelected (bool selected, nint forSegment)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, selSetSelected_ForSegment_XHandle, selected ? (byte) 1 : (byte) 0, forSegment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool_IntPtr (&__objc_super__, selSetSelected_ForSegment_XHandle, selected ? (byte) 1 : (byte) 0, forSegment);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setTag:forSegment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTag (nint tag, nint forSegment)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetTag_ForSegment_XHandle, tag, forSegment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, selSetTag_ForSegment_XHandle, tag, forSegment);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("setToolTip:forSegment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetToolTip (string? toolTip, nint forSegment)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var nstoolTip = CFString.CreateNative (toolTip);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, selSetToolTip_ForSegment_XHandle, nstoolTip, forSegment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, selSetToolTip_ForSegment_XHandle, nstoolTip, forSegment);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstoolTip);
		}
		[Export ("setWidth:forSegment:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetWidth (nfloat width, nint forSegment)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat_IntPtr (this.Handle, selSetWidth_ForSegment_XHandle, width, forSegment);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat_IntPtr (&__objc_super__, selSetWidth_ForSegment_XHandle, width, forSegment);
					GC.KeepAlive (this);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint SegmentCount {
			[Export ("segmentCount")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSegmentCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selSegmentCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSegmentCount:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSegmentCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetSegmentCount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSegmentStyle SegmentStyle {
			[Export ("segmentStyle")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSSegmentStyle ret;
				if (IsDirectBinding) {
					ret = (NSSegmentStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSegmentStyleXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSSegmentStyle) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selSegmentStyleXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSegmentStyle:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSegmentStyle_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetSegmentStyle_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint SelectedSegment {
			[Export ("selectedSegment")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSelectedSegmentXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selSelectedSegmentXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setSelectedSegment:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSelectedSegment_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetSelectedSegment_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSSegmentSwitchTracking TrackingMode {
			[Export ("trackingMode")]
			get {
				global::AppKit.NSApplication.EnsureUIThread ();
				NSSegmentSwitchTracking ret;
				if (IsDirectBinding) {
					ret = (NSSegmentSwitchTracking) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selTrackingModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (NSSegmentSwitchTracking) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selTrackingModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTrackingMode:")]
			set {
				global::AppKit.NSApplication.EnsureUIThread ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetTrackingMode_XHandle, (UIntPtr) (ulong) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetTrackingMode_XHandle, (UIntPtr) (ulong) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class NSSegmentedCell */
}
