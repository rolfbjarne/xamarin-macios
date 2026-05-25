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
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSViewContentSelectionInfo</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos15.0")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "NSViewContentSelectionInfo", WrapperType = typeof (NSViewContentSelectionInfoWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SelectionAnchorRect", Selector = "selectionAnchorRect", PropertyType = typeof (CGRect), GetterSelector = "selectionAnchorRect", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSViewContentSelectionInfo : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("SelectionAnchorRect")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSViewContentSelectionInfoWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSViewContentSelectionInfo ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual CGRect SelectionAnchorRect {
			[Export ("selectionAnchorRect")]
			get {
				return _GetSelectionAnchorRect (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static CGRect _GetSelectionAnchorRect (INSViewContentSelectionInfo This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			CGRect ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend (This.Handle, Selector.GetHandle ("selectionAnchorRect"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.CGRect_objc_msgSend_stret (This.Handle, Selector.GetHandle ("selectionAnchorRect"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSViewContentSelectionInfoWrapper : BaseWrapper, INSViewContentSelectionInfo {
		public NSViewContentSelectionInfoWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSViewContentSelectionInfoWrapper))]
		static NSViewContentSelectionInfoWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
