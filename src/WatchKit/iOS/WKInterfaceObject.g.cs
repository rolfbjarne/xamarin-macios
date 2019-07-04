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
using System.Runtime.InteropServices;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;

namespace WatchKit {
	[Register("WKInterfaceObject", true)]
	[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
	public unsafe partial class WKInterfaceObject : NSObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("WKInterfaceObject");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected WKInterfaceObject (NSObjectFlag t) : base (t)
		{
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal WKInterfaceObject (IntPtr handle) : base (handle)
		{
		}

		[Export ("accessibilityActivate")]
		[Introduced (PlatformName.iOS, 7,0, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityActivate ()
		{
			if (IsDirectBinding) {
				return global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityActivate"));
			} else {
				return global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessibilityActivate"));
			}
		}
		
		[Export ("setAlpha:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetAlpha (nfloat alpha)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setAlpha:"), alpha);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setAlpha:"), alpha);
			}
		}
		
		[Export ("setHeight:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetHeight (nfloat height)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setHeight:"), height);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setHeight:"), height);
			}
		}
		
		[Export ("setHidden:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetHidden (bool hidden)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setHidden:"), hidden);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setHidden:"), hidden);
			}
		}
		
		[Export ("setWidth:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetWidth (nfloat width)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setWidth:"), width);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setWidth:"), width);
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint AccessibilityActivationPoint {
			[Export ("accessibilityActivationPoint")]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityActivationPoint"));
						} else {
							global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("accessibilityActivationPoint"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityActivationPoint"));
					} else {
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityActivationPoint"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessibilityActivationPoint"));
						} else {
							global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("accessibilityActivationPoint"));
						}
					} else if (IntPtr.Size == 8) {
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessibilityActivationPoint"));
					} else {
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessibilityActivationPoint"));
					}
				}
				return ret;
			}
			
			[Export ("setAccessibilityActivationPoint:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("setAccessibilityActivationPoint:"), value);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("setAccessibilityActivationPoint:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[Introduced (PlatformName.TvOS, 11,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		public virtual NSAttributedString AccessibilityAttributedHint {
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			[Introduced (PlatformName.TvOS, 11,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
			[Export ("accessibilityAttributedHint", ArgumentSemantic.Copy)]
			get {
			#if ARCH_32
				throw new PlatformNotSupportedException ("This API is not supported on this version of iOS");
			#else
				NSAttributedString ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityAttributedHint")));
				} else {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessibilityAttributedHint")));
				}
				return ret;
			#endif
			}
			
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			[Introduced (PlatformName.TvOS, 11,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
			[Export ("setAccessibilityAttributedHint:", ArgumentSemantic.Copy)]
			set {
			#if ARCH_32
				throw new PlatformNotSupportedException ("This API is not supported on this version of iOS");
			#else
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilityAttributedHint:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAccessibilityAttributedHint:"), value == null ? IntPtr.Zero : value.Handle);
				}
			#endif
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[Introduced (PlatformName.TvOS, 11,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		public virtual NSAttributedString AccessibilityAttributedLabel {
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			[Introduced (PlatformName.TvOS, 11,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
			[Export ("accessibilityAttributedLabel", ArgumentSemantic.Copy)]
			get {
			#if ARCH_32
				throw new PlatformNotSupportedException ("This API is not supported on this version of iOS");
			#else
				NSAttributedString ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityAttributedLabel")));
				} else {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessibilityAttributedLabel")));
				}
				return ret;
			#endif
			}
			
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			[Introduced (PlatformName.TvOS, 11,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
			[Export ("setAccessibilityAttributedLabel:", ArgumentSemantic.Copy)]
			set {
			#if ARCH_32
				throw new PlatformNotSupportedException ("This API is not supported on this version of iOS");
			#else
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilityAttributedLabel:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAccessibilityAttributedLabel:"), value == null ? IntPtr.Zero : value.Handle);
				}
			#endif
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[Introduced (PlatformName.TvOS, 11,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		public virtual NSAttributedString AccessibilityAttributedValue {
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			[Introduced (PlatformName.TvOS, 11,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
			[Export ("accessibilityAttributedValue", ArgumentSemantic.Copy)]
			get {
			#if ARCH_32
				throw new PlatformNotSupportedException ("This API is not supported on this version of iOS");
			#else
				NSAttributedString ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityAttributedValue")));
				} else {
					ret =  Runtime.GetNSObject<NSAttributedString> (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessibilityAttributedValue")));
				}
				return ret;
			#endif
			}
			
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			[Introduced (PlatformName.TvOS, 11,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
			[Export ("setAccessibilityAttributedValue:", ArgumentSemantic.Copy)]
			set {
			#if ARCH_32
				throw new PlatformNotSupportedException ("This API is not supported on this version of iOS");
			#else
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilityAttributedValue:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAccessibilityAttributedValue:"), value == null ? IntPtr.Zero : value.Handle);
				}
			#endif
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityElementsHidden {
			[Export ("accessibilityElementsHidden")]
			get {
				if (IsDirectBinding) {
					return global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityElementsHidden"));
				} else {
					return global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessibilityElementsHidden"));
				}
			}
			
			[Export ("setAccessibilityElementsHidden:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilityElementsHidden:"), value);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAccessibilityElementsHidden:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGRect AccessibilityFrame {
			[Export ("accessibilityFrame")]
			get {
				CGRect ret;
				if (IsDirectBinding) {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityFrame"));
						} else {
							global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("accessibilityFrame"));
						}
					} else if (IntPtr.Size == 8) {
						global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("accessibilityFrame"));
					} else {
						global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("accessibilityFrame"));
					}
				} else {
					if (Runtime.Arch == Arch.DEVICE) {
						if (IntPtr.Size == 8) {
							ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessibilityFrame"));
						} else {
							global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("accessibilityFrame"));
						}
					} else if (IntPtr.Size == 8) {
						global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("accessibilityFrame"));
					} else {
						global::ObjCRuntime.Messaging.CGRect_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("accessibilityFrame"));
					}
				}
				return ret;
			}
			
			[Export ("setAccessibilityFrame:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGRect (this.Handle, Selector.GetHandle ("setAccessibilityFrame:"), value);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGRect (this.SuperHandle, Selector.GetHandle ("setAccessibilityFrame:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string AccessibilityHint {
			[Export ("accessibilityHint", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityHint")));
				} else {
					return NSString.FromHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessibilityHint")));
				}
			}
			
			[Export ("setAccessibilityHint:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilityHint:"), nsvalue);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAccessibilityHint:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string AccessibilityLabel {
			[Export ("accessibilityLabel", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityLabel")));
				} else {
					return NSString.FromHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessibilityLabel")));
				}
			}
			
			[Export ("setAccessibilityLabel:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilityLabel:"), nsvalue);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAccessibilityLabel:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string AccessibilityLanguage {
			[Export ("accessibilityLanguage", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityLanguage")));
				} else {
					return NSString.FromHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessibilityLanguage")));
				}
			}
			
			[Export ("setAccessibilityLanguage:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilityLanguage:"), nsvalue);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAccessibilityLanguage:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
		public virtual UIAccessibilityNavigationStyle AccessibilityNavigationStyle {
			[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
			[Export ("accessibilityNavigationStyle")]
			get {
				UIAccessibilityNavigationStyle ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (UIAccessibilityNavigationStyle) global::ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityNavigationStyle"));
					} else {
						ret = (UIAccessibilityNavigationStyle) global::ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityNavigationStyle"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (UIAccessibilityNavigationStyle) global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessibilityNavigationStyle"));
					} else {
						ret = (UIAccessibilityNavigationStyle) global::ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessibilityNavigationStyle"));
					}
				}
				return ret;
			}
			
			[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
			[Export ("setAccessibilityNavigationStyle:")]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ObjCRuntime.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setAccessibilityNavigationStyle:"), (Int64)value);
					} else {
						global::ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setAccessibilityNavigationStyle:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setAccessibilityNavigationStyle:"), (Int64)value);
					} else {
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setAccessibilityNavigationStyle:"), (int)value);
					}
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Introduced (PlatformName.iOS, 7,0, PlatformArchitecture.All)]
		public virtual UIBezierPath AccessibilityPath {
			[Introduced (PlatformName.iOS, 7,0, PlatformArchitecture.All)]
			[Export ("accessibilityPath", ArgumentSemantic.Copy)]
			get {
				UIBezierPath ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<UIBezierPath> (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityPath")));
				} else {
					ret =  Runtime.GetNSObject<UIBezierPath> (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessibilityPath")));
				}
				return ret;
			}
			
			[Introduced (PlatformName.iOS, 7,0, PlatformArchitecture.All)]
			[Export ("setAccessibilityPath:", ArgumentSemantic.Copy)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilityPath:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAccessibilityPath:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual UIAccessibilityTrait AccessibilityTraits {
			[Export ("accessibilityTraits")]
			get {
				if (IsDirectBinding) {
					return (UIAccessibilityTrait) global::ObjCRuntime.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityTraits"));
				} else {
					return (UIAccessibilityTrait) global::ObjCRuntime.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessibilityTraits"));
				}
			}
			
			[Export ("setAccessibilityTraits:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setAccessibilityTraits:"), (Int64)value);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setAccessibilityTraits:"), (Int64)value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string AccessibilityValue {
			[Export ("accessibilityValue", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityValue")));
				} else {
					return NSString.FromHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessibilityValue")));
				}
			}
			
			[Export ("setAccessibilityValue:", ArgumentSemantic.Copy)]
			set {
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAccessibilityValue:"), nsvalue);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAccessibilityValue:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AccessibilityViewIsModal {
			[Export ("accessibilityViewIsModal")]
			get {
				if (IsDirectBinding) {
					return global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("accessibilityViewIsModal"));
				} else {
					return global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("accessibilityViewIsModal"));
				}
			}
			
			[Export ("setAccessibilityViewIsModal:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAccessibilityViewIsModal:"), value);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAccessibilityViewIsModal:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string InterfaceProperty {
			[Export ("interfaceProperty")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("interfaceProperty")));
				} else {
					return NSString.FromHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("interfaceProperty")));
				}
			}
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsAccessibilityElement {
			[Export ("isAccessibilityElement")]
			get {
				if (IsDirectBinding) {
					return global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAccessibilityElement"));
				} else {
					return global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isAccessibilityElement"));
				}
			}
			
			[Export ("setIsAccessibilityElement:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsAccessibilityElement:"), value);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsAccessibilityElement:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Introduced (PlatformName.iOS, 6,0, PlatformArchitecture.All)]
		public virtual bool ShouldGroupAccessibilityChildren {
			[Introduced (PlatformName.iOS, 6,0, PlatformArchitecture.All)]
			[Export ("shouldGroupAccessibilityChildren")]
			get {
				if (IsDirectBinding) {
					return global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldGroupAccessibilityChildren"));
				} else {
					return global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldGroupAccessibilityChildren"));
				}
			}
			
			[Introduced (PlatformName.iOS, 6,0, PlatformArchitecture.All)]
			[Export ("setShouldGroupAccessibilityChildren:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldGroupAccessibilityChildren:"), value);
				} else {
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldGroupAccessibilityChildren:"), value);
				}
			}
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _AnnouncementDidFinishNotification;
		[Field ("UIAccessibilityAnnouncementDidFinishNotification",  "WatchKit")]
		[Introduced (PlatformName.iOS, 6,0, PlatformArchitecture.All)]
		[Advice ("Use WKInterfaceObject.Notifications.ObserveAnnouncementDidFinish helper method instead.")]
		public static NSString AnnouncementDidFinishNotification {
			[Introduced (PlatformName.iOS, 6,0, PlatformArchitecture.All)]
			get {
				if (_AnnouncementDidFinishNotification == null)
					_AnnouncementDidFinishNotification = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityAnnouncementDidFinishNotification");
				return _AnnouncementDidFinishNotification;
			}
		}
		[Field ("UIAccessibilityAnnouncementNotification",  "WatchKit")]
		public static int AnnouncementNotification {
			get {
				return Dlfcn.GetInt32 (Libraries.WatchKit.Handle, "UIAccessibilityAnnouncementNotification");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _AssistiveTechnologyKey;
		[Field ("UIAccessibilityAssistiveTechnologyKey",  "WatchKit")]
		[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
		[Advice ("Use WKInterfaceObject.Notifications.ObserveAssistiveTechnologyKey helper method instead.")]
		public static NSString AssistiveTechnologyKey {
			[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
			get {
				if (_AssistiveTechnologyKey == null)
					_AssistiveTechnologyKey = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityAssistiveTechnologyKey");
				return _AssistiveTechnologyKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _AssistiveTouchStatusDidChangeNotification;
		[Field ("UIAccessibilityAssistiveTouchStatusDidChangeNotification",  "WatchKit")]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 10,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.TvOS, 10,0, PlatformArchitecture.All)]
		[Advice ("Use WKInterfaceObject.Notifications.ObserveAssistiveTouchStatusDidChange helper method instead.")]
		public static NSString AssistiveTouchStatusDidChangeNotification {
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			[Introduced (PlatformName.iOS, 10,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.TvOS, 10,0, PlatformArchitecture.All)]
			get {
				if (_AssistiveTouchStatusDidChangeNotification == null)
					_AssistiveTouchStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityAssistiveTouchStatusDidChangeNotification");
				return _AssistiveTouchStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _BoldTextStatusDidChangeNotification;
		[Field ("UIAccessibilityBoldTextStatusDidChangeNotification",  "WatchKit")]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
		[Advice ("Use WKInterfaceObject.Notifications.ObserveBoldTextStatusDidChange helper method instead.")]
		public static NSString BoldTextStatusDidChangeNotification {
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
			get {
				if (_BoldTextStatusDidChangeNotification == null)
					_BoldTextStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityBoldTextStatusDidChangeNotification");
				return _BoldTextStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _ClosedCaptioningStatusDidChangeNotification;
		[Field ("UIAccessibilityClosedCaptioningStatusDidChangeNotification",  "WatchKit")]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[Advice ("Use WKInterfaceObject.Notifications.ObserveClosedCaptioningStatusDidChange helper method instead.")]
		public static NSString ClosedCaptioningStatusDidChangeNotification {
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			get {
				if (_ClosedCaptioningStatusDidChangeNotification == null)
					_ClosedCaptioningStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityClosedCaptioningStatusDidChangeNotification");
				return _ClosedCaptioningStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _DarkerSystemColorsStatusDidChangeNotification;
		[Field ("UIAccessibilityDarkerSystemColorsStatusDidChangeNotification",  "WatchKit")]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
		[Advice ("Use WKInterfaceObject.Notifications.ObserveDarkerSystemColorsStatusDidChange helper method instead.")]
		public static NSString DarkerSystemColorsStatusDidChangeNotification {
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
			get {
				if (_DarkerSystemColorsStatusDidChangeNotification == null)
					_DarkerSystemColorsStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityDarkerSystemColorsStatusDidChangeNotification");
				return _DarkerSystemColorsStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _ElementFocusedNotification;
		[Field ("UIAccessibilityElementFocusedNotification",  "WatchKit")]
		[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
		[Advice ("Use WKInterfaceObject.Notifications.ObserveElementFocused helper method instead.")]
		public static NSString ElementFocusedNotification {
			[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
			get {
				if (_ElementFocusedNotification == null)
					_ElementFocusedNotification = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityElementFocusedNotification");
				return _ElementFocusedNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _FocusedElementKey;
		[Field ("UIAccessibilityFocusedElementKey",  "WatchKit")]
		[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
		[Advice ("Use WKInterfaceObject.Notifications.ObserveFocusedElementKey helper method instead.")]
		public static NSString FocusedElementKey {
			[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
			get {
				if (_FocusedElementKey == null)
					_FocusedElementKey = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityFocusedElementKey");
				return _FocusedElementKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _GrayscaleStatusDidChangeNotification;
		[Field ("UIAccessibilityGrayscaleStatusDidChangeNotification",  "WatchKit")]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
		[Advice ("Use WKInterfaceObject.Notifications.ObserveGrayscaleStatusDidChange helper method instead.")]
		public static NSString GrayscaleStatusDidChangeNotification {
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
			get {
				if (_GrayscaleStatusDidChangeNotification == null)
					_GrayscaleStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityGrayscaleStatusDidChangeNotification");
				return _GrayscaleStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _GuidedAccessStatusDidChangeNotification;
		[Field ("UIAccessibilityGuidedAccessStatusDidChangeNotification",  "WatchKit")]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 6,0, PlatformArchitecture.All)]
		[Advice ("Use WKInterfaceObject.Notifications.ObserveGuidedAccessStatusDidChange helper method instead.")]
		public static NSString GuidedAccessStatusDidChangeNotification {
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			[Introduced (PlatformName.iOS, 6,0, PlatformArchitecture.All)]
			get {
				if (_GuidedAccessStatusDidChangeNotification == null)
					_GuidedAccessStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityGuidedAccessStatusDidChangeNotification");
				return _GuidedAccessStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _HearingDevicePairedEarDidChangeNotification;
		[Field ("UIAccessibilityHearingDevicePairedEarDidChangeNotification",  "WatchKit")]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[Unavailable (PlatformName.TvOS, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 10,0, PlatformArchitecture.All)]
		[Advice ("Use WKInterfaceObject.Notifications.ObserveHearingDevicePairedEarDidChange helper method instead.")]
		public static NSString HearingDevicePairedEarDidChangeNotification {
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			[Unavailable (PlatformName.TvOS, PlatformArchitecture.All)]
			[Introduced (PlatformName.iOS, 10,0, PlatformArchitecture.All)]
			get {
				if (_HearingDevicePairedEarDidChangeNotification == null)
					_HearingDevicePairedEarDidChangeNotification = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityHearingDevicePairedEarDidChangeNotification");
				return _HearingDevicePairedEarDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _InvertColorsStatusDidChangeNotification;
		[Field ("UIAccessibilityInvertColorsStatusDidChangeNotification",  "WatchKit")]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 6,0, PlatformArchitecture.All)]
		[Advice ("Use WKInterfaceObject.Notifications.ObserveInvertColorsStatusDidChange helper method instead.")]
		public static NSString InvertColorsStatusDidChangeNotification {
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			[Introduced (PlatformName.iOS, 6,0, PlatformArchitecture.All)]
			get {
				if (_InvertColorsStatusDidChangeNotification == null)
					_InvertColorsStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityInvertColorsStatusDidChangeNotification");
				return _InvertColorsStatusDidChangeNotification;
			}
		}
		[Field ("UIAccessibilityLayoutChangedNotification",  "WatchKit")]
		public static int LayoutChangedNotification {
			get {
				return Dlfcn.GetInt32 (Libraries.WatchKit.Handle, "UIAccessibilityLayoutChangedNotification");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _MonoAudioStatusDidChangeNotification;
		[Field ("UIAccessibilityMonoAudioStatusDidChangeNotification",  "WatchKit")]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[Advice ("Use WKInterfaceObject.Notifications.ObserveMonoAudioStatusDidChange helper method instead.")]
		public static NSString MonoAudioStatusDidChangeNotification {
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			get {
				if (_MonoAudioStatusDidChangeNotification == null)
					_MonoAudioStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityMonoAudioStatusDidChangeNotification");
				return _MonoAudioStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _NotificationSwitchControlIdentifier;
		[Field ("UIAccessibilityNotificationSwitchControlIdentifier",  "WatchKit")]
		[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
		public static NSString NotificationSwitchControlIdentifier {
			[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
			get {
				if (_NotificationSwitchControlIdentifier == null)
					_NotificationSwitchControlIdentifier = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityNotificationSwitchControlIdentifier");
				return _NotificationSwitchControlIdentifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _NotificationVoiceOverIdentifier;
		[Field ("UIAccessibilityNotificationVoiceOverIdentifier",  "WatchKit")]
		[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
		public static NSString NotificationVoiceOverIdentifier {
			[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
			get {
				if (_NotificationVoiceOverIdentifier == null)
					_NotificationVoiceOverIdentifier = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityNotificationVoiceOverIdentifier");
				return _NotificationVoiceOverIdentifier;
			}
		}
		[Field ("UIAccessibilityPageScrolledNotification",  "WatchKit")]
		public static int PageScrolledNotification {
			get {
				return Dlfcn.GetInt32 (Libraries.WatchKit.Handle, "UIAccessibilityPageScrolledNotification");
			}
		}
		[Field ("UIAccessibilityPauseAssistiveTechnologyNotification",  "WatchKit")]
		[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
		public static int PauseAssistiveTechnologyNotification {
			[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
			get {
				return Dlfcn.GetInt32 (Libraries.WatchKit.Handle, "UIAccessibilityPauseAssistiveTechnologyNotification");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _ReduceMotionStatusDidChangeNotification;
		[Field ("UIAccessibilityReduceMotionStatusDidChangeNotification",  "WatchKit")]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
		[Advice ("Use WKInterfaceObject.Notifications.ObserveReduceMotionStatusDidChange helper method instead.")]
		public static NSString ReduceMotionStatusDidChangeNotification {
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
			get {
				if (_ReduceMotionStatusDidChangeNotification == null)
					_ReduceMotionStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityReduceMotionStatusDidChangeNotification");
				return _ReduceMotionStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _ReduceTransparencyStatusDidChangeNotification;
		[Field ("UIAccessibilityReduceTransparencyStatusDidChangeNotification",  "WatchKit")]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
		[Advice ("Use WKInterfaceObject.Notifications.ObserveReduceTransparencyStatusDidChange helper method instead.")]
		public static NSString ReduceTransparencyStatusDidChangeNotification {
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
			get {
				if (_ReduceTransparencyStatusDidChangeNotification == null)
					_ReduceTransparencyStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityReduceTransparencyStatusDidChangeNotification");
				return _ReduceTransparencyStatusDidChangeNotification;
			}
		}
		[Field ("UIAccessibilityResumeAssistiveTechnologyNotification",  "WatchKit")]
		[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
		public static int ResumeAssistiveTechnologyNotification {
			[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
			get {
				return Dlfcn.GetInt32 (Libraries.WatchKit.Handle, "UIAccessibilityResumeAssistiveTechnologyNotification");
			}
		}
		[Field ("UIAccessibilityScreenChangedNotification",  "WatchKit")]
		public static int ScreenChangedNotification {
			get {
				return Dlfcn.GetInt32 (Libraries.WatchKit.Handle, "UIAccessibilityScreenChangedNotification");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _ShakeToUndoDidChangeNotification;
		[Field ("UIAccessibilityShakeToUndoDidChangeNotification",  "WatchKit")]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
		[Advice ("Use WKInterfaceObject.Notifications.ObserveShakeToUndoDidChange helper method instead.")]
		public static NSString ShakeToUndoDidChangeNotification {
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
			get {
				if (_ShakeToUndoDidChangeNotification == null)
					_ShakeToUndoDidChangeNotification = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityShakeToUndoDidChangeNotification");
				return _ShakeToUndoDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _SpeakScreenStatusDidChangeNotification;
		[Field ("UIAccessibilitySpeakScreenStatusDidChangeNotification",  "WatchKit")]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
		[Advice ("Use WKInterfaceObject.Notifications.ObserveSpeakScreenStatusDidChange helper method instead.")]
		public static NSString SpeakScreenStatusDidChangeNotification {
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
			get {
				if (_SpeakScreenStatusDidChangeNotification == null)
					_SpeakScreenStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilitySpeakScreenStatusDidChangeNotification");
				return _SpeakScreenStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _SpeakSelectionStatusDidChangeNotification;
		[Field ("UIAccessibilitySpeakSelectionStatusDidChangeNotification",  "WatchKit")]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
		[Advice ("Use WKInterfaceObject.Notifications.ObserveSpeakSelectionStatusDidChange helper method instead.")]
		public static NSString SpeakSelectionStatusDidChangeNotification {
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
			get {
				if (_SpeakSelectionStatusDidChangeNotification == null)
					_SpeakSelectionStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilitySpeakSelectionStatusDidChangeNotification");
				return _SpeakSelectionStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _SpeechAttributeIpaNotation;
		[Field ("UIAccessibilitySpeechAttributeIPANotation",  "WatchKit")]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.TvOS, 11,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
		public static NSString SpeechAttributeIpaNotation {
			[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.TvOS, 11,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
			get {
				if (_SpeechAttributeIpaNotation == null)
					_SpeechAttributeIpaNotation = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilitySpeechAttributeIPANotation");
				return _SpeechAttributeIpaNotation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _SpeechAttributeLanguage;
		[Field ("UIAccessibilitySpeechAttributeLanguage",  "WatchKit")]
		[Introduced (PlatformName.iOS, 7,0, PlatformArchitecture.All)]
		public static NSString SpeechAttributeLanguage {
			[Introduced (PlatformName.iOS, 7,0, PlatformArchitecture.All)]
			get {
				if (_SpeechAttributeLanguage == null)
					_SpeechAttributeLanguage = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilitySpeechAttributeLanguage");
				return _SpeechAttributeLanguage;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _SpeechAttributePitch;
		[Field ("UIAccessibilitySpeechAttributePitch",  "WatchKit")]
		[Introduced (PlatformName.iOS, 7,0, PlatformArchitecture.All)]
		public static NSString SpeechAttributePitch {
			[Introduced (PlatformName.iOS, 7,0, PlatformArchitecture.All)]
			get {
				if (_SpeechAttributePitch == null)
					_SpeechAttributePitch = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilitySpeechAttributePitch");
				return _SpeechAttributePitch;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _SpeechAttributePunctuation;
		[Field ("UIAccessibilitySpeechAttributePunctuation",  "WatchKit")]
		[Introduced (PlatformName.iOS, 7,0, PlatformArchitecture.All)]
		public static NSString SpeechAttributePunctuation {
			[Introduced (PlatformName.iOS, 7,0, PlatformArchitecture.All)]
			get {
				if (_SpeechAttributePunctuation == null)
					_SpeechAttributePunctuation = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilitySpeechAttributePunctuation");
				return _SpeechAttributePunctuation;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _SpeechAttributeQueueAnnouncement;
		[Field ("UIAccessibilitySpeechAttributeQueueAnnouncement",  "WatchKit")]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.TvOS, 11,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
		public static NSString SpeechAttributeQueueAnnouncement {
			[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.TvOS, 11,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
			get {
				if (_SpeechAttributeQueueAnnouncement == null)
					_SpeechAttributeQueueAnnouncement = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilitySpeechAttributeQueueAnnouncement");
				return _SpeechAttributeQueueAnnouncement;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _SwitchControlStatusDidChangeNotification;
		[Field ("UIAccessibilitySwitchControlStatusDidChangeNotification",  "WatchKit")]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
		[Advice ("Use WKInterfaceObject.Notifications.ObserveSwitchControlStatusDidChange helper method instead.")]
		public static NSString SwitchControlStatusDidChangeNotification {
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			[Introduced (PlatformName.iOS, 8,0, PlatformArchitecture.All)]
			get {
				if (_SwitchControlStatusDidChangeNotification == null)
					_SwitchControlStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilitySwitchControlStatusDidChangeNotification");
				return _SwitchControlStatusDidChangeNotification;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _TextAttributeCustom;
		[Field ("UIAccessibilityTextAttributeCustom",  "WatchKit")]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.TvOS, 11,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
		public static NSString TextAttributeCustom {
			[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.TvOS, 11,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
			get {
				if (_TextAttributeCustom == null)
					_TextAttributeCustom = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityTextAttributeCustom");
				return _TextAttributeCustom;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _TextAttributeHeadingLevel;
		[Field ("UIAccessibilityTextAttributeHeadingLevel",  "WatchKit")]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.TvOS, 11,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
		public static NSString TextAttributeHeadingLevel {
			[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.TvOS, 11,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.WatchOS, 4,0, PlatformArchitecture.All)]
			get {
				if (_TextAttributeHeadingLevel == null)
					_TextAttributeHeadingLevel = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityTextAttributeHeadingLevel");
				return _TextAttributeHeadingLevel;
			}
		}
		[Field ("UIAccessibilityTraitAdjustable",  "WatchKit")]
		public static long TraitAdjustable {
			get {
				return Dlfcn.GetInt64 (Libraries.WatchKit.Handle, "UIAccessibilityTraitAdjustable");
			}
		}
		[Field ("UIAccessibilityTraitAllowsDirectInteraction",  "WatchKit")]
		public static long TraitAllowsDirectInteraction {
			get {
				return Dlfcn.GetInt64 (Libraries.WatchKit.Handle, "UIAccessibilityTraitAllowsDirectInteraction");
			}
		}
		[Field ("UIAccessibilityTraitButton",  "WatchKit")]
		public static long TraitButton {
			get {
				return Dlfcn.GetInt64 (Libraries.WatchKit.Handle, "UIAccessibilityTraitButton");
			}
		}
		[Field ("UIAccessibilityTraitCausesPageTurn",  "WatchKit")]
		public static long TraitCausesPageTurn {
			get {
				return Dlfcn.GetInt64 (Libraries.WatchKit.Handle, "UIAccessibilityTraitCausesPageTurn");
			}
		}
		[Field ("UIAccessibilityTraitHeader",  "WatchKit")]
		[Introduced (PlatformName.iOS, 6,0, PlatformArchitecture.All)]
		public static long TraitHeader {
			[Introduced (PlatformName.iOS, 6,0, PlatformArchitecture.All)]
			get {
				return Dlfcn.GetInt64 (Libraries.WatchKit.Handle, "UIAccessibilityTraitHeader");
			}
		}
		[Field ("UIAccessibilityTraitImage",  "WatchKit")]
		public static long TraitImage {
			get {
				return Dlfcn.GetInt64 (Libraries.WatchKit.Handle, "UIAccessibilityTraitImage");
			}
		}
		[Field ("UIAccessibilityTraitKeyboardKey",  "WatchKit")]
		public static long TraitKeyboardKey {
			get {
				return Dlfcn.GetInt64 (Libraries.WatchKit.Handle, "UIAccessibilityTraitKeyboardKey");
			}
		}
		[Field ("UIAccessibilityTraitLink",  "WatchKit")]
		public static long TraitLink {
			get {
				return Dlfcn.GetInt64 (Libraries.WatchKit.Handle, "UIAccessibilityTraitLink");
			}
		}
		[Field ("UIAccessibilityTraitNone",  "WatchKit")]
		public static long TraitNone {
			get {
				return Dlfcn.GetInt64 (Libraries.WatchKit.Handle, "UIAccessibilityTraitNone");
			}
		}
		[Field ("UIAccessibilityTraitNotEnabled",  "WatchKit")]
		public static long TraitNotEnabled {
			get {
				return Dlfcn.GetInt64 (Libraries.WatchKit.Handle, "UIAccessibilityTraitNotEnabled");
			}
		}
		[Field ("UIAccessibilityTraitPlaysSound",  "WatchKit")]
		public static long TraitPlaysSound {
			get {
				return Dlfcn.GetInt64 (Libraries.WatchKit.Handle, "UIAccessibilityTraitPlaysSound");
			}
		}
		[Field ("UIAccessibilityTraitSearchField",  "WatchKit")]
		public static long TraitSearchField {
			get {
				return Dlfcn.GetInt64 (Libraries.WatchKit.Handle, "UIAccessibilityTraitSearchField");
			}
		}
		[Field ("UIAccessibilityTraitSelected",  "WatchKit")]
		public static long TraitSelected {
			get {
				return Dlfcn.GetInt64 (Libraries.WatchKit.Handle, "UIAccessibilityTraitSelected");
			}
		}
		[Field ("UIAccessibilityTraitStartsMediaSession",  "WatchKit")]
		public static long TraitStartsMediaSession {
			get {
				return Dlfcn.GetInt64 (Libraries.WatchKit.Handle, "UIAccessibilityTraitStartsMediaSession");
			}
		}
		[Field ("UIAccessibilityTraitStaticText",  "WatchKit")]
		public static long TraitStaticText {
			get {
				return Dlfcn.GetInt64 (Libraries.WatchKit.Handle, "UIAccessibilityTraitStaticText");
			}
		}
		[Field ("UIAccessibilityTraitSummaryElement",  "WatchKit")]
		public static long TraitSummaryElement {
			get {
				return Dlfcn.GetInt64 (Libraries.WatchKit.Handle, "UIAccessibilityTraitSummaryElement");
			}
		}
		[Field ("UIAccessibilityTraitTabBar",  "WatchKit")]
		[Introduced (PlatformName.iOS, 10,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.TvOS, 10,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.WatchOS, 3,0, PlatformArchitecture.All)]
		public static long TraitTabBar {
			[Introduced (PlatformName.iOS, 10,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.TvOS, 10,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.WatchOS, 3,0, PlatformArchitecture.All)]
			get {
				return Dlfcn.GetInt64 (Libraries.WatchKit.Handle, "UIAccessibilityTraitTabBar");
			}
		}
		[Field ("UIAccessibilityTraitUpdatesFrequently",  "WatchKit")]
		public static long TraitUpdatesFrequently {
			get {
				return Dlfcn.GetInt64 (Libraries.WatchKit.Handle, "UIAccessibilityTraitUpdatesFrequently");
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _UnfocusedElementKey;
		[Field ("UIAccessibilityUnfocusedElementKey",  "WatchKit")]
		[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
		[Advice ("Use WKInterfaceObject.Notifications.ObserveUnfocusedElementKey helper method instead.")]
		public static NSString UnfocusedElementKey {
			[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
			get {
				if (_UnfocusedElementKey == null)
					_UnfocusedElementKey = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityUnfocusedElementKey");
				return _UnfocusedElementKey;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _VoiceOverStatusChanged;
		[Field ("UIAccessibilityVoiceOverStatusChanged",  "WatchKit")]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use 'VoiceOverStatusDidChangeNotification' instead.")]
		[Deprecated (PlatformName.TvOS, 11,0, message: "Use 'VoiceOverStatusDidChangeNotification' instead.")]
		public static NSString VoiceOverStatusChanged {
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			[Deprecated (PlatformName.iOS, 11,0, message: "Use 'VoiceOverStatusDidChangeNotification' instead.")]
			[Deprecated (PlatformName.TvOS, 11,0, message: "Use 'VoiceOverStatusDidChangeNotification' instead.")]
			get {
				if (_VoiceOverStatusChanged == null)
					_VoiceOverStatusChanged = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityVoiceOverStatusChanged");
				return _VoiceOverStatusChanged;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString _VoiceOverStatusDidChangeNotification;
		[Field ("UIAccessibilityVoiceOverStatusDidChangeNotification",  "WatchKit")]
		[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
		[Introduced (PlatformName.TvOS, 11,0, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
		[Advice ("Use WKInterfaceObject.Notifications.ObserveVoiceOverStatusDidChange helper method instead.")]
		public static NSString VoiceOverStatusDidChangeNotification {
			[Unavailable (PlatformName.WatchOS, PlatformArchitecture.All)]
			[Introduced (PlatformName.TvOS, 11,0, PlatformArchitecture.All)]
			[Introduced (PlatformName.iOS, 11,0, PlatformArchitecture.All)]
			get {
				if (_VoiceOverStatusDidChangeNotification == null)
					_VoiceOverStatusDidChangeNotification = Dlfcn.GetStringConstant (Libraries.WatchKit.Handle, "UIAccessibilityVoiceOverStatusDidChangeNotification");
				return _VoiceOverStatusDidChangeNotification;
			}
		}
		
		
		//
		// Notifications
		//
		public static partial class Notifications {
		
			public static NSObject ObserveAnnouncementDidFinish (EventHandler<UIKit.UIAccessibilityAnnouncementFinishedEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AnnouncementDidFinishNotification, notification => handler (null, new UIKit.UIAccessibilityAnnouncementFinishedEventArgs (notification)));
			}
			public static NSObject ObserveAnnouncementDidFinish (NSObject objectToObserve, EventHandler<UIKit.UIAccessibilityAnnouncementFinishedEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AnnouncementDidFinishNotification, notification => handler (null, new UIKit.UIAccessibilityAnnouncementFinishedEventArgs (notification)), objectToObserve);
			}
			public static NSObject ObserveAssistiveTechnologyKey (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AssistiveTechnologyKey, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveAssistiveTechnologyKey (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AssistiveTechnologyKey, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			public static NSObject ObserveAssistiveTouchStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AssistiveTouchStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveAssistiveTouchStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AssistiveTouchStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			public static NSObject ObserveBoldTextStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (BoldTextStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveBoldTextStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (BoldTextStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			public static NSObject ObserveClosedCaptioningStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ClosedCaptioningStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveClosedCaptioningStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ClosedCaptioningStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			public static NSObject ObserveDarkerSystemColorsStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DarkerSystemColorsStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveDarkerSystemColorsStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (DarkerSystemColorsStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			public static NSObject ObserveElementFocused (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ElementFocusedNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveElementFocused (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ElementFocusedNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			public static NSObject ObserveFocusedElementKey (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (FocusedElementKey, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveFocusedElementKey (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (FocusedElementKey, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			public static NSObject ObserveGrayscaleStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (GrayscaleStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveGrayscaleStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (GrayscaleStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			public static NSObject ObserveGuidedAccessStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (GuidedAccessStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveGuidedAccessStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (GuidedAccessStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			public static NSObject ObserveHearingDevicePairedEarDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (HearingDevicePairedEarDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveHearingDevicePairedEarDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (HearingDevicePairedEarDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			public static NSObject ObserveInvertColorsStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (InvertColorsStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveInvertColorsStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (InvertColorsStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			public static NSObject ObserveMonoAudioStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (MonoAudioStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveMonoAudioStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (MonoAudioStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			public static NSObject ObserveReduceMotionStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ReduceMotionStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveReduceMotionStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ReduceMotionStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			public static NSObject ObserveReduceTransparencyStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ReduceTransparencyStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveReduceTransparencyStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ReduceTransparencyStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			public static NSObject ObserveShakeToUndoDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ShakeToUndoDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveShakeToUndoDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (ShakeToUndoDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			public static NSObject ObserveSpeakScreenStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SpeakScreenStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveSpeakScreenStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SpeakScreenStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			public static NSObject ObserveSpeakSelectionStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SpeakSelectionStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveSpeakSelectionStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SpeakSelectionStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			public static NSObject ObserveSwitchControlStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SwitchControlStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveSwitchControlStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (SwitchControlStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			public static NSObject ObserveUnfocusedElementKey (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (UnfocusedElementKey, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveUnfocusedElementKey (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (UnfocusedElementKey, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
			public static NSObject ObserveVoiceOverStatusDidChange (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (VoiceOverStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveVoiceOverStatusDidChange (NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (VoiceOverStatusDidChangeNotification, notification => handler (null, new NSNotificationEventArgs (notification)), objectToObserve);
			}
		
		}
	} /* class WKInterfaceObject */
}
