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
namespace PhotosUI {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>PHProjectExtensionController</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "PHProjectExtensionController", WrapperType = typeof (PHProjectExtensionControllerWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetSupportedProjectTypes", Selector = "supportedProjectTypes", ReturnType = typeof (PhotosUI.PHProjectTypeDescription[]))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "BeginProject", Selector = "beginProjectWithExtensionContext:projectInfo:completion:", ParameterType = new Type [] { typeof (PhotosUI.PHProjectExtensionContext), typeof (PhotosUI.PHProjectInfo), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V16) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ResumeProject", Selector = "resumeProjectWithExtensionContext:completion:", ParameterType = new Type [] { typeof (PhotosUI.PHProjectExtensionContext), typeof (global::System.Action<NSError>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V16) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishProject", Selector = "finishProjectWithCompletionHandler:", ParameterType = new Type [] { typeof (Action) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDAction) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTypeDescriptionDataSource", Selector = "typeDescriptionDataSourceForCategory:invalidator:", ReturnType = typeof (PhotosUI.IPHProjectTypeDescriptionDataSource), ParameterType = new Type [] { typeof (NSString), typeof (PhotosUI.IPHProjectTypeDescriptionInvalidator) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IPHProjectExtensionController : INativeObject, IDisposable
	{
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("supportedProjectTypes")]
		[ObsoletedOSPlatform ("macos10.14")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual PHProjectTypeDescription[] GetSupportedProjectTypes ()
		{
			return _GetSupportedProjectTypes (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.14")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static PHProjectTypeDescription[] _GetSupportedProjectTypes (IPHProjectExtensionController This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			PHProjectTypeDescription[] ret;
			ret = CFArray.ArrayFromHandle<PHProjectTypeDescription>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("supportedProjectTypes")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="extensionContext">To be added.</param><param name="projectInfo">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("beginProjectWithExtensionContext:projectInfo:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void BeginProject (PHProjectExtensionContext extensionContext, PHProjectInfo projectInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="extensionContext">To be added.</param><param name="projectInfo">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _BeginProject (IPHProjectExtensionController This, PHProjectExtensionContext extensionContext, PHProjectInfo projectInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var extensionContext__handle__ = extensionContext!.GetNonNullHandle (nameof (extensionContext));
			var projectInfo__handle__ = projectInfo!.GetNonNullHandle (nameof (projectInfo));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V16.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("beginProjectWithExtensionContext:projectInfo:completion:"), extensionContext__handle__, projectInfo__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (extensionContext);
			GC.KeepAlive (projectInfo);
		}
		/// <param name="extensionContext">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("resumeProjectWithExtensionContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ResumeProject (PHProjectExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="extensionContext">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ResumeProject (IPHProjectExtensionController This, PHProjectExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var extensionContext__handle__ = extensionContext!.GetNonNullHandle (nameof (extensionContext));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V16.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("resumeProjectWithExtensionContext:completion:"), extensionContext__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
			GC.KeepAlive (extensionContext);
		}
		/// <param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("finishProjectWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void FinishProject ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _FinishProject (IPHProjectExtensionController This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("finishProjectWithCompletionHandler:"), (IntPtr) block_ptr_completion);
			GC.KeepAlive (This);
		}
		/// <param name="category">To be added.</param><param name="invalidator">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("typeDescriptionDataSourceForCategory:invalidator:")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected virtual IPHProjectTypeDescriptionDataSource GetTypeDescriptionDataSource (NSString category, IPHProjectTypeDescriptionInvalidator invalidator)
		{
			return _GetTypeDescriptionDataSource (this, category, invalidator);
		}
		/// <param name="category">To be added.</param><param name="invalidator">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IPHProjectTypeDescriptionDataSource _GetTypeDescriptionDataSource (IPHProjectExtensionController This, NSString category, IPHProjectTypeDescriptionInvalidator invalidator)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var category__handle__ = category!.GetNonNullHandle (nameof (category));
			var invalidator__handle__ = invalidator!.GetNonNullHandle (nameof (invalidator));
			IPHProjectTypeDescriptionDataSource? ret;
			ret =  Runtime.GetINativeObject<IPHProjectTypeDescriptionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("typeDescriptionDataSourceForCategory:invalidator:"), category__handle__, invalidator__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (category);
			GC.KeepAlive (invalidator);
			return ret!;
		}
		[DynamicDependencyAttribute ("BeginProject(PhotosUI.PHProjectExtensionContext,PhotosUI.PHProjectInfo,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute ("FinishProject(System.Action)")]
		[DynamicDependencyAttribute ("GetSupportedProjectTypes()")]
		[DynamicDependencyAttribute ("GetTypeDescriptionDataSource(Foundation.NSString,PhotosUI.IPHProjectTypeDescriptionInvalidator)")]
		[DynamicDependencyAttribute ("ResumeProject(PhotosUI.PHProjectExtensionContext,System.Action{Foundation.NSError})")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PHProjectExtensionControllerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IPHProjectExtensionController ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IPHProjectExtensionController" /> interface to support all the methods from the PHProjectExtensionController protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IPHProjectExtensionController" /> interface allow developers to treat instances of the interface as having all the optional methods of the original PHProjectExtensionController protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class PHProjectExtensionController_Extensions {
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.14")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static PHProjectTypeDescription[] GetSupportedProjectTypes (this IPHProjectExtensionController This)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			PHProjectTypeDescription[] ret;
			ret = CFArray.ArrayFromHandle<PHProjectTypeDescription>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("supportedProjectTypes")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <param name="category">To be added.</param><param name="invalidator">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IPHProjectTypeDescriptionDataSource GetTypeDescriptionDataSource (this IPHProjectExtensionController This, NSString category, IPHProjectTypeDescriptionInvalidator invalidator)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var category__handle__ = category!.GetNonNullHandle (nameof (category));
			var invalidator__handle__ = invalidator!.GetNonNullHandle (nameof (invalidator));
			IPHProjectTypeDescriptionDataSource? ret;
			ret =  Runtime.GetINativeObject<IPHProjectTypeDescriptionDataSource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("typeDescriptionDataSourceForCategory:invalidator:"), category__handle__, invalidator__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (category);
			GC.KeepAlive (invalidator);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class PHProjectExtensionControllerWrapper : BaseWrapper, IPHProjectExtensionController {
		public PHProjectExtensionControllerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (PHProjectExtensionControllerWrapper))]
		static PHProjectExtensionControllerWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="extensionContext">To be added.</param><param name="projectInfo">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("beginProjectWithExtensionContext:projectInfo:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void BeginProject (PHProjectExtensionContext extensionContext, PHProjectInfo projectInfo, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var extensionContext__handle__ = extensionContext!.GetNonNullHandle (nameof (extensionContext));
			var projectInfo__handle__ = projectInfo!.GetNonNullHandle (nameof (projectInfo));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V16.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("beginProjectWithExtensionContext:projectInfo:completion:"), extensionContext__handle__, projectInfo__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (extensionContext);
			GC.KeepAlive (projectInfo);
		}
		/// <param name="extensionContext">To be added.</param><param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("resumeProjectWithExtensionContext:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void ResumeProject (PHProjectExtensionContext extensionContext, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V16))]global::System.Action<NSError> completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var extensionContext__handle__ = extensionContext!.GetNonNullHandle (nameof (extensionContext));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V16.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("resumeProjectWithExtensionContext:completion:"), extensionContext__handle__, (IntPtr) block_ptr_completion);
			GC.KeepAlive (extensionContext);
		}
		/// <param name="completion">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("finishProjectWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void FinishProject ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDAction.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("finishProjectWithCompletionHandler:"), (IntPtr) block_ptr_completion);
		}
	}
}
