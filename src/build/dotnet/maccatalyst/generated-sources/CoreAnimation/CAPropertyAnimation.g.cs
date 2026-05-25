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
namespace CoreAnimation {
	/// <summary>An animation that can animate object properties.</summary><remarks>For a list of common properties to animate, see the documentation for <see cref="P:CoreAnimation.CAPropertyAnimation.KeyPath" /></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GraphicsImaging/Reference/CAPropertyAnimation_class/index.html">Apple documentation for <c>CAPropertyAnimation</c></related>
	[Register("CAPropertyAnimation", true)]
	public unsafe partial class CAPropertyAnimation : CAAnimation {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("CAPropertyAnimation");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="CAPropertyAnimation" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CAPropertyAnimation () : base (NSObjectFlag.Empty)
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
		public CAPropertyAnimation (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected CAPropertyAnimation (NSObjectFlag t) : base (t)
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
		protected internal CAPropertyAnimation (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="path"><para>A key path represening the property to animate.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a property animation from the specified keypath.</summary><returns>The new animation.</returns><remarks><para>The animation created will animate the property specified by the keypath.</para><list type="table"><listheader><term>Property</term><description>Action</description></listheader><item><term>anchorPoint</term><description>Animates for 0.25 seconds or the duration of the current transaction using a CABasicAnimation.</description></item><item><term>backgroundColor</term><description>Animates for 0.25 seconds or the duration of the current transaction using a CABasicAnimation.   Subproperties are animated with basic animations.</description></item><item><term>backgroundFilters</term><description>Animates using a CATransition for 0.25 seconds or the duration of the transaction.   The default animation type is CATransition.Fade and the range is from 0.0 to 1.0. The filter subproperties are animated with a CABasicAnimation.</description></item><item><term>borderColor</term><description>Animates for 0.25 seconds or the duration of the current transaction using a CABasicAnimation.</description></item><item><term>borderWidth</term><description>Animates for 0.25 seconds or the duration of the current transaction using a CABasicAnimation.</description></item><item><term>bounds</term><description>Animates for 0.25 seconds or the duration of the current transaction using a CABasicAnimation.</description></item><item><term>compositingFilter</term><description>Animates using a CATransition for 0.25 seconds or the duration of the transaction.   The default animation type is CATransition.Fade and the range is from 0.0 to 1.0. Subproperties are animated with basic animations.</description></item><item><term>contents</term><description>Animates for 0.25 seconds or the duration of the current transaction using a CABasicAnimation.</description></item><item><term>contentsRect</term><description>Animates for 0.25 seconds or the duration of the current transaction using a CABasicAnimation.</description></item><item><term>cornerRadius</term><description>Animates for 0.25 seconds or the duration of the current transaction using a CABasicAnimation.</description></item><item><term>doubleSided</term><description>No default implied animation is set.</description></item><item><term>filters</term><description>Animates for 0.25 seconds or the duration of the current transaction using a CABasicAnimation. Sub-properties of the filters are animated using the default implied CABasicAnimation described in Table 10.</description></item><item><term>frame</term><description>The frame property itself is not animatable. You can achieve the same results by modifying the bounds and position properties instead.</description></item><item><term>hidden</term><description>Animates for 0.25 seconds or the duration of the current transaction using a CABasicAnimation.</description></item><item><term>mask</term><description>Animates for 0.25 seconds or the duration of the current transaction using a CABasicAnimation. This property is available only on Mac OS X.</description></item><item><term>masksToBounds</term><description>Animates for 0.25 seconds or the duration of the current transaction using a CABasicAnimation.</description></item><item><term>opacity</term><description>Animates for 0.25 seconds or the duration of the current transaction using a CABasicAnimation.</description></item><item><term>position</term><description>Animates for 0.25 seconds or the duration of the current transaction using a CABasicAnimation.</description></item><item><term>shadowColor</term><description>Animates for 0.25 seconds or the duration of the current transaction using a CABasicAnimation. This property is available only on Mac OS X.</description></item><item><term>shadowOffset</term><description>Uses the default implied CABasicAnimation described in Table 10. This property is available only on Mac OS X.</description></item><item><term>shadowOpacity</term><description>Animates for 0.25 seconds or the duration of the current transaction using a CABasicAnimation. This property is available only on Mac OS X.</description></item><item><term>shadowRadius</term><description>Animates for 0.25 seconds or the duration of the current transaction using a CABasicAnimation. This property is available only on Mac OS X.</description></item><item><term>sublayers</term><description>Animates using a CATransition for 0.25 seconds or the duration of the transaction.   The default animation type is CATransition.Fade and the range is from 0.0 to 1.0..</description></item><item><term>sublayerTransform</term><description>Animates for 0.25 seconds or the duration of the current transaction using a CABasicAnimation.</description></item><item><term>transform</term><description>Animates for 0.25 seconds or the duration of the current transaction using a CABasicAnimation.</description></item><item><term>zPosition</term><description>Animates for 0.25 seconds or the duration of the current transaction using a CABasicAnimation.</description></item></list></remarks>
		[Export ("animationWithKeyPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CAPropertyAnimation FromKeyPath (string? path)
		{
			var nspath = CFString.CreateNative (path);
			CAPropertyAnimation? ret;
			ret =  Runtime.GetNSObject<CAPropertyAnimation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, Selector.GetHandle ("animationWithKeyPath:"), nspath), false)!;
			CFString.ReleaseNative (nspath);
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Additive {
			[Export ("isAdditive")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAdditive"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isAdditive"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setAdditive:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAdditive:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setAdditive:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Cumulative {
			[Export ("isCumulative")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isCumulative"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("isCumulative"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setCumulative:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCumulative:"), value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, Selector.GetHandle ("setCumulative:"), value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? KeyPath {
			[Export ("keyPath", ArgumentSemantic.Copy)]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("keyPath")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("keyPath")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setKeyPath:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setKeyPath:"), nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setKeyPath:"), nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CAValueFunction? ValueFunction {
			[Export ("valueFunction", ArgumentSemantic.Retain)]
			get {
				CAValueFunction? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<CAValueFunction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("valueFunction")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<CAValueFunction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("valueFunction")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setValueFunction:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setValueFunction:"), value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("setValueFunction:"), value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
	} /* class CAPropertyAnimation */
}
