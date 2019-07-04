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
	[Introduced (PlatformName.iOS, 9,0, PlatformArchitecture.All)]
	[Protocol (Name = "WKImageAnimatable", WrapperType = typeof (WKImageAnimatableWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StartAnimating", Selector = "startAnimating")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StartAnimating", Selector = "startAnimatingWithImagesInRange:duration:repeatCount:", ParameterType = new Type [] { typeof (NSRange), typeof (double), typeof (nint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "StopAnimating", Selector = "stopAnimating")]
	public interface IWKImageAnimatable : INativeObject, IDisposable
	{
		[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("startAnimating")]
		[Preserve (Conditional = true)]
		void StartAnimating ();
		
		[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("startAnimatingWithImagesInRange:duration:repeatCount:")]
		[Preserve (Conditional = true)]
		void StartAnimating (NSRange imageRange, double duration, nint repeatCount);
		
		[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 8,2, PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("stopAnimating")]
		[Preserve (Conditional = true)]
		void StopAnimating ();
		
	}
	
	internal sealed class WKImageAnimatableWrapper : BaseWrapper, IWKImageAnimatable {
		[Preserve (Conditional = true)]
		public WKImageAnimatableWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("startAnimating")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void StartAnimating ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("startAnimating"));
		}
		
		[Export ("startAnimatingWithImagesInRange:duration:repeatCount:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void StartAnimating (NSRange imageRange, double duration, nint repeatCount)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_Double_nint (this.Handle, Selector.GetHandle ("startAnimatingWithImagesInRange:duration:repeatCount:"), imageRange, duration, repeatCount);
		}
		
		[Export ("stopAnimating")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void StopAnimating ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stopAnimating"));
		}
		
	}
}
