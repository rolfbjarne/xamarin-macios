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
	[Register("WKInterfaceTable", true)]
	[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
	public unsafe partial class WKInterfaceTable : WKInterfaceObject {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("WKInterfaceTable");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected WKInterfaceTable (NSObjectFlag t) : base (t)
		{
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal WKInterfaceTable (IntPtr handle) : base (handle)
		{
		}

		[Export ("rowControllerAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject GetRowController (nint index)
		{
			if (IsDirectBinding) {
				return Runtime.GetNSObject (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_nint (this.Handle, Selector.GetHandle ("rowControllerAtIndex:"), index));
			} else {
				return Runtime.GetNSObject (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("rowControllerAtIndex:"), index));
			}
		}
		
		[Export ("insertRowsAtIndexes:withRowType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertRows (NSIndexSet rowIndexes, string rowType)
		{
			if (rowIndexes == null)
				throw new ArgumentNullException ("rowIndexes");
			if (rowType == null)
				throw new ArgumentNullException ("rowType");
			var nsrowType = NSString.CreateNative (rowType);
			
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("insertRowsAtIndexes:withRowType:"), rowIndexes.Handle, nsrowType);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("insertRowsAtIndexes:withRowType:"), rowIndexes.Handle, nsrowType);
			}
			NSString.ReleaseNative (nsrowType);
			
		}
		
		[Export ("removeRowsAtIndexes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveRows (NSIndexSet rowIndexes)
		{
			if (rowIndexes == null)
				throw new ArgumentNullException ("rowIndexes");
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeRowsAtIndexes:"), rowIndexes.Handle);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeRowsAtIndexes:"), rowIndexes.Handle);
			}
		}
		
		[Export ("scrollToRowAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ScrollToRow (nint index)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("scrollToRowAtIndex:"), index);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("scrollToRowAtIndex:"), index);
			}
		}
		
		[Export ("setNumberOfRows:withRowType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetNumberOfRows (nint numberOfRows, string rowType)
		{
			if (rowType == null)
				throw new ArgumentNullException ("rowType");
			var nsrowType = NSString.CreateNative (rowType);
			
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("setNumberOfRows:withRowType:"), numberOfRows, nsrowType);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nint_IntPtr (this.SuperHandle, Selector.GetHandle ("setNumberOfRows:withRowType:"), numberOfRows, nsrowType);
			}
			NSString.ReleaseNative (nsrowType);
			
		}
		
		[Export ("setRowTypes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetRowTypes (string[] rowTypes)
		{
			if (rowTypes == null)
				throw new ArgumentNullException ("rowTypes");
			var nsa_rowTypes = NSArray.FromStrings (rowTypes);
			
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRowTypes:"), nsa_rowTypes.Handle);
			} else {
				global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRowTypes:"), nsa_rowTypes.Handle);
			}
			nsa_rowTypes.Dispose ();
			
		}
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint NumberOfRows {
			[Export ("numberOfRows")]
			get {
				if (IsDirectBinding) {
					return global::ObjCRuntime.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("numberOfRows"));
				} else {
					return global::ObjCRuntime.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("numberOfRows"));
				}
			}
			
		}
		
	} /* class WKInterfaceTable */
}
