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
using GLKit;
using Metal;
using CoreML;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace MediaPlayer {
	/// <summary>A <see cref="T:UIKit.UIView" /> that presents a slider control used to set the system output volume.</summary><remarks>To be added.</remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/MediaPlayer/Reference/MPVolumeView_Class/index.html">Apple documentation for <c>MPVolumeView</c></related>
	[Register("MPVolumeView", true)]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	public unsafe partial class MPVolumeView : global::UIKit.UIView {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPVolumeView");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MPVolumeView" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MPVolumeView () : base (NSObjectFlag.Empty)
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
		public MPVolumeView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MPVolumeView (NSObjectFlag t) : base (t)
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
		protected internal MPVolumeView (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="frame">Frame used by the view, expressed in iOS points.</param><summary>Initializes the MPVolumeView with the specified frame.</summary><remarks><para>This constructor is used to programmatically create a new instance of MPVolumeView with the specified dimension in the frame.   The object will only be displayed once it has been added to a view hierarchy by calling AddSubview in a containing view.</para><para>This constructor is not invoked when deserializing objects from storyboards or XIB files; instead, the constructor that takes an NSCoder parameter is invoked.</para></remarks>
		[Export ("initWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPVolumeView (CGRect frame)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("initWithFrame:"), frame), "initWithFrame:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="state">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("maximumVolumeSliderImageForState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIImage? GetMaximumVolumeSliderImage (global::UIKit.UIControlState state)
		{
			global::UIKit.UIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("maximumVolumeSliderImageForState:"), (UIntPtr) (ulong) state), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("maximumVolumeSliderImageForState:"), (UIntPtr) (ulong) state), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="state">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("minimumVolumeSliderImageForState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIImage? GetMinimumVolumeSliderImage (global::UIKit.UIControlState state)
		{
			global::UIKit.UIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("minimumVolumeSliderImageForState:"), (UIntPtr) (ulong) state), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("minimumVolumeSliderImageForState:"), (UIntPtr) (ulong) state), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="state">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("routeButtonImageForState:")]
		[ObsoletedOSPlatform ("ios13.0", "See 'AVRoutePickerView' for possible replacements.")]
		[ObsoletedOSPlatform ("tvos13.0", "See 'AVRoutePickerView' for possible replacements.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "See 'AVRoutePickerView' for possible replacements.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIImage? GetRouteButtonImage (global::UIKit.UIControlState state)
		{
			global::UIKit.UIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("routeButtonImageForState:"), (UIntPtr) (ulong) state), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("routeButtonImageForState:"), (UIntPtr) (ulong) state), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="bounds">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("routeButtonRectForBounds:")]
		[ObsoletedOSPlatform ("ios13.0", "See 'AVRoutePickerView' for possible replacements.")]
		[ObsoletedOSPlatform ("tvos13.0", "See 'AVRoutePickerView' for possible replacements.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "See 'AVRoutePickerView' for possible replacements.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetRouteButtonRect (CGRect bounds)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("routeButtonRectForBounds:"), bounds);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect (this.Handle, Selector.GetHandle ("routeButtonRectForBounds:"), bounds);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("routeButtonRectForBounds:"), bounds);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (&__objc_super__, Selector.GetHandle ("routeButtonRectForBounds:"), bounds);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="bounds">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("volumeSliderRectForBounds:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetVolumeSliderRect (CGRect bounds)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("volumeSliderRectForBounds:"), bounds);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect (this.Handle, Selector.GetHandle ("volumeSliderRectForBounds:"), bounds);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect (&__objc_super__, Selector.GetHandle ("volumeSliderRectForBounds:"), bounds);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect (&__objc_super__, Selector.GetHandle ("volumeSliderRectForBounds:"), bounds);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="state">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("volumeThumbImageForState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIImage? GetVolumeThumbImage (global::UIKit.UIControlState state)
		{
			global::UIKit.UIImage ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("volumeThumbImageForState:"), (UIntPtr) (ulong) state), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, Selector.GetHandle ("volumeThumbImageForState:"), (UIntPtr) (ulong) state), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="bounds">To be added.</param><param name="columeSliderRect">To be added.</param><param name="value">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("volumeThumbRectForBounds:volumeSliderRect:value:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect GetVolumeThumbRect (CGRect bounds, CGRect columeSliderRect, float value)
		{
			CGRect ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_CGRect_CGRect_float (this.Handle, Selector.GetHandle ("volumeThumbRectForBounds:volumeSliderRect:value:"), bounds, columeSliderRect, value);
				} else {
					ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret_CGRect_CGRect_float (this.Handle, Selector.GetHandle ("volumeThumbRectForBounds:volumeSliderRect:value:"), bounds, columeSliderRect, value);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_CGRect_CGRect_float (&__objc_super__, Selector.GetHandle ("volumeThumbRectForBounds:volumeSliderRect:value:"), bounds, columeSliderRect, value);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret_CGRect_CGRect_float (&__objc_super__, Selector.GetHandle ("volumeThumbRectForBounds:volumeSliderRect:value:"), bounds, columeSliderRect, value);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="image"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="state">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setMaximumVolumeSliderImage:forState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMaximumVolumeSliderImage (global::UIKit.UIImage? image, global::UIKit.UIControlState state)
		{
			var image__handle__ = image.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setMaximumVolumeSliderImage:forState:"), image__handle__, (UIntPtr) (ulong) state);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, Selector.GetHandle ("setMaximumVolumeSliderImage:forState:"), image__handle__, (UIntPtr) (ulong) state);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <param name="image"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="state">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setMinimumVolumeSliderImage:forState:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'AVPlayer.ExternalPlaybackActive' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'AVPlayer.ExternalPlaybackActive' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVPlayer.ExternalPlaybackActive' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMinimumVolumeSliderImage (global::UIKit.UIImage? image, global::UIKit.UIControlState state)
		{
			var image__handle__ = image.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setMinimumVolumeSliderImage:forState:"), image__handle__, (UIntPtr) (ulong) state);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, Selector.GetHandle ("setMinimumVolumeSliderImage:forState:"), image__handle__, (UIntPtr) (ulong) state);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <param name="image"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="state">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setRouteButtonImage:forState:")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'AVRoutePickerView.RoutePickerButtonStyle' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'AVRoutePickerView.RoutePickerButtonStyle' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVRoutePickerView.RoutePickerButtonStyle' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetRouteButtonImage (global::UIKit.UIImage? image, global::UIKit.UIControlState state)
		{
			var image__handle__ = image.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setRouteButtonImage:forState:"), image__handle__, (UIntPtr) (ulong) state);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, Selector.GetHandle ("setRouteButtonImage:forState:"), image__handle__, (UIntPtr) (ulong) state);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <param name="image"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="state">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setVolumeThumbImage:forState:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVolumeThumbImage (global::UIKit.UIImage? image, global::UIKit.UIControlState state)
		{
			var image__handle__ = image.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("setVolumeThumbImage:forState:"), image__handle__, (UIntPtr) (ulong) state);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, Selector.GetHandle ("setVolumeThumbImage:forState:"), image__handle__, (UIntPtr) (ulong) state);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (image);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios13.0", "Use 'AVRouteDetector.MultipleRoutesDetected' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'AVRouteDetector.MultipleRoutesDetected' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVRouteDetector.MultipleRoutesDetected' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool AreWirelessRoutesAvailable {
			[Export ("areWirelessRoutesAvailable")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("areWirelessRoutesAvailable"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("areWirelessRoutesAvailable"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios13.0", "Use 'AVPlayer.ExternalPlaybackActive' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'AVPlayer.ExternalPlaybackActive' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVPlayer.ExternalPlaybackActive' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool IsWirelessRouteActive {
			[Export ("isWirelessRouteActive")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isWirelessRouteActive"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isWirelessRouteActive"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios13.0", "Use 'AVRoutePickerView' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'AVRoutePickerView' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVRoutePickerView' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool ShowsRouteButton {
			[Export ("showsRouteButton")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsRouteButton"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("showsRouteButton"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsRouteButton:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsRouteButton:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShowsRouteButton:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios13.0", "Use 'AVRouteDetector.MultipleRoutesDetected' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'AVRouteDetector.MultipleRoutesDetected' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVRouteDetector.MultipleRoutesDetected' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual bool ShowsVolumeSlider {
			[Export ("showsVolumeSlider")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsVolumeSlider"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("showsVolumeSlider"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setShowsVolumeSlider:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsVolumeSlider:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setShowsVolumeSlider:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios17.0")]
		[ObsoletedOSPlatform ("tvos17.0")]
		[ObsoletedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual global::UIKit.UIImage? VolumeWarningSliderImage {
			[Export ("volumeWarningSliderImage", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIImage? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("volumeWarningSliderImage")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::UIKit.UIImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("volumeWarningSliderImage")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setVolumeWarningSliderImage:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setVolumeWarningSliderImage:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setVolumeWarningSliderImage:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WirelessRouteActiveDidChangeNotification;
		/// <summary>Notification constant for WirelessRouteActiveDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWirelessRouteActiveDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveWirelessRouteActiveDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = MPVolumeView.Notifications.ObserveWirelessRouteActiveDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, MPVolumeView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = MPVolumeView.Notifications.ObserveWirelessRouteActiveDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     MPVolumeView.WirelessRouteActiveDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification WirelessRouteActiveDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WirelessRouteActiveDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (MPVolumeView.WirelessRouteActiveDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("MPVolumeViewWirelessRouteActiveDidChangeNotification",  "MediaPlayer")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'AVPlayer.ExternalPlaybackActive' KVO instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'AVPlayer.ExternalPlaybackActive' KVO instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVPlayer.ExternalPlaybackActive' KVO instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[Advice ("Use MPVolumeView.Notifications.ObserveWirelessRouteActiveDidChange helper method instead.")]
		public static NSString WirelessRouteActiveDidChangeNotification {
			[ObsoletedOSPlatform ("ios13.0", "Use 'AVPlayer.ExternalPlaybackActive' KVO instead.")]
			[ObsoletedOSPlatform ("tvos13.0", "Use 'AVPlayer.ExternalPlaybackActive' KVO instead.")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVPlayer.ExternalPlaybackActive' KVO instead.")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_WirelessRouteActiveDidChangeNotification is null)
					_WirelessRouteActiveDidChangeNotification = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPVolumeViewWirelessRouteActiveDidChangeNotification")!;
				return _WirelessRouteActiveDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _WirelessRoutesAvailableDidChangeNotification;
		/// <summary>Notification constant for WirelessRoutesAvailableDidChange</summary>
		/// <value><see cref="NSString" /> constant, should be used as a token to <see cref="NSNotificationCenter" />.</value>
		/// <remarks>
		///   <para>
		///     This constant can be used with <see cref="NSNotificationCenter" /> to register a listener for this notification.
		///     This is an <see cref="NSString" /> instead of a string, because these values can be used as tokens in some native
		///     libraries instead of being used purely for their actual string content. The 'notification' parameter to the callback
		///     contains extra information that is specific to the notification type.
		///   </para>
		///   <para>
		///     To subscribe to this notification, developers can use the convenience <see cref="Notifications.ObserveWirelessRoutesAvailableDidChange(NSObject,EventHandler{NSNotificationEventArgs})" />
		///     or <see cref="Notifications.ObserveWirelessRoutesAvailableDidChange(EventHandler{NSNotificationEventArgs})" /> methods,
		///     which offers strongly typed access to the parameters of the notification.
		///   </para>
		///   <para>
		///     The following example shows how to use the strongly typed <see cref="Notifications" /> class, to take the guesswork
		///     out of the available properties in the notification:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // Lambda style
		/// //
		///
		/// // listening
		/// notification = MPVolumeView.Notifications.ObserveWirelessRoutesAvailableDidChange ((sender, args) => {
		/// /* Access strongly typed args */
		/// Console.WriteLine ("Notification: {0}", args.Notification);
		/// });
		///
		/// // To stop listening:
		/// notification.Dispose ();
		///
		/// //
		/// // Method style
		/// //
		/// NSObject notification;
		/// void Callback (object sender, MPVolumeView.NSNotificationEventArgs args)
		/// {
		///     // Access strongly typed args
		///     Console.WriteLine ("Notification: {0}", args.Notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     notification = MPVolumeView.Notifications.ObserveWirelessRoutesAvailableDidChange (Callback);
		/// }
		///
		/// void Teardown ()
		/// {
		///     notification.Dispose ();
		/// }]]></code>
		///   </example>
		///   <para>
		///     The following example shows how to use the notification with the DefaultCenter API:
		///   </para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		/// // Lambda style
		/// NSNotificationCenter.DefaultCenter.AddObserver (
		///     MPVolumeView.WirelessRoutesAvailableDidChangeNotification, (notification) => { Console.WriteLine ("Received the notification WirelessRoutesAvailableDidChange", notification); }
		/// );
		///
		/// // Method style
		/// void Callback (NSNotification notification)
		/// {
		///     Console.WriteLine ("Received the notification WirelessRoutesAvailableDidChange", notification);
		/// }
		///
		/// void Setup ()
		/// {
		///     NSNotificationCenter.DefaultCenter.AddObserver (MPVolumeView.WirelessRoutesAvailableDidChangeNotification, Callback);
		/// }
		/// ]]></code>
		///   </example>
		/// </remarks>
		[Field ("MPVolumeViewWirelessRoutesAvailableDidChangeNotification",  "MediaPlayer")]
		[ObsoletedOSPlatform ("ios13.0", "Use 'AVRouteDetector.MultipleRoutesDetectedDidChange' instead.")]
		[ObsoletedOSPlatform ("tvos13.0", "Use 'AVRouteDetector.MultipleRoutesDetectedDidChange' instead.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVRouteDetector.MultipleRoutesDetectedDidChange' instead.")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[Advice ("Use MPVolumeView.Notifications.ObserveWirelessRoutesAvailableDidChange helper method instead.")]
		public static NSString WirelessRoutesAvailableDidChangeNotification {
			[ObsoletedOSPlatform ("ios13.0", "Use 'AVRouteDetector.MultipleRoutesDetectedDidChange' instead.")]
			[ObsoletedOSPlatform ("tvos13.0", "Use 'AVRouteDetector.MultipleRoutesDetectedDidChange' instead.")]
			[ObsoletedOSPlatform ("maccatalyst13.1", "Use 'AVRouteDetector.MultipleRoutesDetectedDidChange' instead.")]
			[UnsupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos14.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_WirelessRoutesAvailableDidChangeNotification is null)
					_WirelessRoutesAvailableDidChangeNotification = Dlfcn.GetStringConstant (Libraries.MediaPlayer.Handle, "MPVolumeViewWirelessRoutesAvailableDidChangeNotification")!;
				return _WirelessRoutesAvailableDidChangeNotification;
			}
		}
		/// <summary>Appearance class for objects of type <see cref="global::MediaPlayer.MPVolumeView" />.</summary>
		/// <remarks>
		///     <para>This appearance class is a strongly typed subclass of UIAppearance that is intended to be used with objects of class <see cref="global::MediaPlayer.MPVolumeView" />.</para>
		///     <para>You can obtain an instance to this class by either accessing the static <see cref="global::MediaPlayer.MPVolumeView.Appearance" /> property or by calling <see cref="global::MediaPlayer.MPVolumeView.AppearanceWhenContainedIn(System.Type[])" /> to get a UIAppearance that is context sensitive.</para>
		/// </remarks>
		public partial class MPVolumeViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal MPVolumeViewAppearance (IntPtr handle) : base (handle) {}
		}
		/// <summary>Strongly-typed property that returns the UIAppearance class for this class.</summary>
		/// <remarks>
		///   <para>Setting any appearance properties on this instance will affect the appearance of all instances of <see cref="global::MediaPlayer.MPVolumeView" />.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::MediaPlayer.MPVolumeView" />, they should use the <see cref="global::MediaPlayer.MPVolumeView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		/// </remarks>
		public static new MPVolumeViewAppearance Appearance {
			get { return new MPVolumeViewAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		/// <summary>Obtains the appearance proxy <see cref="global::MediaPlayer.MPVolumeView.MPVolumeViewAppearance" /> for the subclass of <see cref="global::MediaPlayer.MPVolumeView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::MediaPlayer.MPVolumeView" />.</typeparam>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::MediaPlayer.MPVolumeView.Appearance" /> property, or the <see cref="global::MediaPlayer.MPVolumeView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTheme = MPVolumeView.GetAppearance<MyMPVolumeViewSubclass> ();
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new MPVolumeViewAppearance GetAppearance<T> () where T: MPVolumeView {
			return new MPVolumeViewAppearance (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		/// <param name="containers">List of types that developers want to have as the containers to apply this particular appearance</param>
		/// <summary>Returns a strongly typed <see cref="global::UIKit.UIAppearance" /> for instances of this class when the view is hosted in the specified hierarchy.</summary>
		/// <returns>The appearance proxy object that developers can use to set properties when the given container hierarchy is active</returns>
		/// <remarks>
		///   <para>The returned object represents the <see cref="global::UIKit.UIAppearance" /> proxy where developers can set appearance properties for instances of <see cref="global::MediaPlayer.MPVolumeView" /> when those instances are contained in the hierarchy specified by the <paramref name="containers" /> parameter.</para>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::MediaPlayer.MPVolumeView" />, they should use the <see cref="global::MediaPlayer.MPVolumeView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///     <code lang="csharp lang-csharp"><![CDATA[
		///var mySliders = UISlider.AppearanceWhenContainedIn (typeof (UINavigationBar), typeof (UIPopoverController));
		///mySliders.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new MPVolumeViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new MPVolumeViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::MediaPlayer.MPVolumeView.MPVolumeViewAppearance" /> for <see cref="global::MediaPlayer.MPVolumeView" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = MPVolumeView.GetAppearance (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::MediaPlayer.MPVolumeView" />, they should use the <see cref="global::MediaPlayer.MPVolumeView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection)" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new MPVolumeViewAppearance GetAppearance (UITraitCollection traits) {
			return new MPVolumeViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::MediaPlayer.MPVolumeView.MPVolumeViewAppearance" /> for <see cref="global::MediaPlayer.MPVolumeView" />.</summary>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = MPVolumeView.GetAppearance (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>If developers want to control the appearance of subclasses of <see cref="global::MediaPlayer.MPVolumeView" />, they should use the <see cref="global::MediaPlayer.MPVolumeView.GetAppearance&lt;T&gt;(UIKit.UITraitCollection,System.Type[])" /> method.</para>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new MPVolumeViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new MPVolumeViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::MediaPlayer.MPVolumeView.MPVolumeViewAppearance" /> for the subclass of <see cref="global::MediaPlayer.MPVolumeView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::MediaPlayer.MPVolumeView" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::MediaPlayer.MPVolumeView.Appearance" /> property, or the <see cref="global::MediaPlayer.MPVolumeView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = MPVolumeView.GetAppearance<MyMPVolumeViewSubclass> (myTraits);
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new MPVolumeViewAppearance GetAppearance<T> (UITraitCollection traits) where T: MPVolumeView {
			return new MPVolumeViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		/// <summary>Obtains the appearance proxy <see cref="global::MediaPlayer.MPVolumeView.MPVolumeViewAppearance" /> for the subclass of <see cref="global::MediaPlayer.MPVolumeView" />.</summary>
		/// <typeparam name="T">The type for which the <see cref="global::UIKit.UIAppearance" /> proxy must be returned.  This is a subclass of <see cref="global::MediaPlayer.MPVolumeView" />.</typeparam>
		/// <param name="traits">Trait collection to match.</param>
		/// <param name="containers">List of types that the developer wishes to have as the containers to apply this particular appearance.</param>
		/// <returns>
		///   <para>An appearance proxy object for the specified type.</para>
		/// </returns>
		/// <remarks>
		///   <para>Setting any appearance properties on the returned object will affect the appearance of all classes and subclasses of the type parameter.</para>
		///   <para>Unlike the <see cref="global::MediaPlayer.MPVolumeView.Appearance" /> property, or the <see cref="global::MediaPlayer.MPVolumeView.AppearanceWhenContainedIn(System.Type[])" /> method which only work on instances of this particular class, the proxies returned by this method can be used to change the style of subclasses.</para>
		///   <para>The following example shows how this method works:</para>
		///   <example>
		///   <code lang="csharp lang-csharp"><![CDATA[
		///var myTraits = new UITraitCollection ();
		///var myTheme = MPVolumeView.GetAppearance<MyMPVolumeViewSubclass> (myTraits, typeof (UINavigationBar), typeof (UIPopoverController));
		///myTheme.TintColor = UIColor.Red;
		///]]></code>
		///   </example>
		///   <para>For more information, see the documentation for the <see cref="global::UIKit.UIAppearance" /> class.</para>
		/// </remarks>
		public static new MPVolumeViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: MPVolumeView{
			return new MPVolumeViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		//
		// Notifications
		//
		/// <summary>Notifications posted by the <see cref="global::MediaPlayer.MPVolumeView" /> class.</summary>
		/// <remarks>
		///    <para>This class contains various helper methods that allow developers to observe events posted in the notification hub (<see cref="Foundation.NSNotificationCenter" />).</para>
		///    <para>The methods defined in this class post events that invoke the provided method or lambda with a <see cref="Foundation.NSNotificationEventArgs" /> parameter, which contains strongly typed properties for the notification arguments.</para>
		/// </remarks>
		public static partial class Notifications {
			/// <summary>Strongly typed notification for the <see cref="global::MediaPlayer.MPVolumeView.WirelessRouteActiveDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::MediaPlayer.MPVolumeView.WirelessRouteActiveDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = MPVolumeView.Notifications.ObserveWirelessRouteActiveDidChange ((notification) => {
			///   Console.WriteLine ("Observed WirelessRouteActiveDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWirelessRouteActiveDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WirelessRouteActiveDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::MediaPlayer.MPVolumeView.WirelessRouteActiveDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::MediaPlayer.MPVolumeView.WirelessRouteActiveDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = MPVolumeView.Notifications.ObserveWirelessRouteActiveDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WirelessRouteActiveDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWirelessRouteActiveDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WirelessRouteActiveDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			/// <summary>Strongly typed notification for the <see cref="global::MediaPlayer.MPVolumeView.WirelessRoutesAvailableDidChangeNotification" /> constant.</summary>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::MediaPlayer.MPVolumeView.WirelessRoutesAvailableDidChangeNotification" /> notifications.</para>
			///   <example>
			///   <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for any object
			/// var token = MPVolumeView.Notifications.ObserveWirelessRoutesAvailableDidChange ((notification) => {
			///   Console.WriteLine ("Observed WirelessRoutesAvailableDidChangeNotification!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWirelessRoutesAvailableDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WirelessRoutesAvailableDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			/// <summary>Strongly typed notification for the <see cref="global::MediaPlayer.MPVolumeView.WirelessRoutesAvailableDidChangeNotification" /> constant.</summary>
			/// <param name="objectToObserve">The specific object to observe.</param>
			/// <param name="handler">The handler that responds to the notification when it occurs.</param>
			/// <returns>Token object that can be used to stop receiving notifications by either disposing it or passing it to <see cref="Foundation.NSNotificationCenter.RemoveObservers(System.Collections.Generic.IEnumerable{Foundation.NSObject})" />.</returns>
			/// <remarks>
			///   <para>This method can be used to subscribe to <see cref="global::MediaPlayer.MPVolumeView.WirelessRoutesAvailableDidChangeNotification" /> notifications.</para>
			///   <example>
			///     <code lang="csharp lang-csharp"><![CDATA[
			/// // Listen to all notifications posted for a single object
			/// var token = MPVolumeView.Notifications.ObserveWirelessRoutesAvailableDidChange (objectToObserve, (notification) => {
			///   Console.WriteLine ($"Observed WirelessRoutesAvailableDidChangeNotification for {nameof (objectToObserve)}!");
			/// };
			/// 
			/// // Stop listening for notifications
			/// token.Dispose ();
			/// ]]></code>
			///   </example>
			/// </remarks>
			public static NSObject ObserveWirelessRoutesAvailableDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (WirelessRoutesAvailableDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		}
	} /* class MPVolumeView */
}
