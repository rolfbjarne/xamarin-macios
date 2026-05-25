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
namespace UIKit {
	/// <summary>An enumeration of keyboard types.</summary><remarks><para>In order to change the keyboard appearance, the currently displaying keyboard must be dismissed. This is achieved by having the <see cref="T:UIKit.UIControl" /> associated with the keyboard resigning as first responder, changing the keyboard type, and then re-subscribed as the first subscriber, as shown in the following code:</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// void AddKeyboardTypeButton (UIKeyboardType kbType, RectangleF frame)
	/// {
	/// 	  var kbButton = UIButton.FromType (UIButtonType.RoundedRect);
	/// 	  kbButton.Frame = frame;
	/// 	  kbButton.SetTitle (kbType.ToString (), UIControlState.Normal);
	/// 	  View.AddSubview (kbButton);
	/// 	  kbButton.TouchUpInside += (sender, e) => {
	/// 		    myTextField.ResignFirstResponder ();
	/// 		    myTextField.KeyboardType = kbType;
	/// 		    myTextField.BecomeFirstResponder ();
	/// 	  };
	/// }
	/// ]]></code></example></remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native]
	public enum UIKeyboardType : long {
		/// <summary>The default keyboard for the current input type.</summary>
		Default = 0,
		/// <summary>Displays standard ASCII characters.</summary>
		ASCIICapable = 1,
		/// <summary>Displays standard ASCII characters.</summary>
		AsciiCapable = 1,
		/// <summary>Numbers and punctuation.</summary>
		NumbersAndPunctuation = 2,
		/// <summary>Characters, '.', '/', and '.com' keys, and access to numbers and punctuation.</summary>
		Url = 3,
		/// <summary>Numbers.</summary>
		NumberPad = 4,
		/// <summary>Numbers plus access to #, *, 'pause', and 'wait'.</summary>
		PhonePad = 5,
		/// <summary>Characters plus access to numbers.</summary>
		NamePhonePad = 6,
		/// <summary>Characters, an @ symbol, and access to numbers and punctuation.</summary>
		EmailAddress = 7,
		/// <summary>Displays numbers and decimal point.</summary>
		DecimalPad = 8,
		/// <summary>Characters, @ and # keys, and access to numbers and punctuation.</summary>
		Twitter = 9,
		/// <summary>Optimized for Web search terms and URL entry. </summary>
		WebSearch = 10,
		/// <summary>Displays numbers and decimal point by using standard ASCII characters.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		AsciiCapableNumberPad = 11,
	}
}
