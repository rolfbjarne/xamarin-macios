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
	/// <summary>Holds a key for restoring storyboards.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class UIStateRestoration  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ViewControllerStoryboardKey;
		/// <summary>Represents the value associated with the constant UIStateRestorationViewControllerStoryboardKey</summary><value></value><remarks><para>Application developers who wish to implement state restoration would use this method in the following manner:</para><example><code lang="csharp lang-csharp"><![CDATA[
		/// [Adopts ("UIViewControllerRestoration")]
		/// class MyUIViewController : UIViewController {
		/// 
		/// [Export ("viewControllerWithRestorationIdentifierPath:")]
		/// static UIViewController FromIdentifierPath (string [] identifierComponents, NSCoder coder)
		/// {
		/// var sb = (UIStoryboard) coder.DecodeObject (UIStateRestoration.ViewControllerStoryboardKey);
		/// if (sb != null){
		/// var vc = (MyUIViewController) sb.InstantiateViewController ("MyViewController");
		/// vc.RestorationIdentifier = identifierComponents [identifierComponents.Length-1];
		/// vc.RestorationClass = Class.GetHandle (typeof (MyViewController));
		/// }
		/// }
		/// }
		/// ]]></code></example></remarks>
		[Field ("UIStateRestorationViewControllerStoryboardKey",  "UIKit")]
		public static NSString ViewControllerStoryboardKey {
			get {
				if (_ViewControllerStoryboardKey is null)
					_ViewControllerStoryboardKey = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UIStateRestorationViewControllerStoryboardKey")!;
				return _ViewControllerStoryboardKey;
			}
		}
	} /* class UIStateRestoration */
}
