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
namespace MediaExtension {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MEFormatReader</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos15.0")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "MEFormatReader", WrapperType = typeof (MEFormatReaderWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LoadFileInfo", Selector = "loadFileInfoWithCompletionHandler:", ParameterType = new Type [] { typeof (MediaExtension.MEFormatReaderLoadFileInfoCallback) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDMEFormatReaderLoadFileInfoCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LoadMetadata", Selector = "loadMetadataWithCompletionHandler:", ParameterType = new Type [] { typeof (MediaExtension.MEFormatReaderLoadMetadataCallback) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDMEFormatReaderLoadMetadataCallback) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "LoadTrackReaders", Selector = "loadTrackReadersWithCompletionHandler:", ParameterType = new Type [] { typeof (MediaExtension.MEFormatReaderLoadTrackReadersCallback) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDMEFormatReaderLoadTrackReadersCallback) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ParseAdditionalFragments", Selector = "parseAdditionalFragmentsWithCompletionHandler:", ParameterType = new Type [] { typeof (MediaExtension.MEFormatReaderParseAdditionalFragmentsCallback) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDMEFormatReaderParseAdditionalFragmentsCallback) })]
	public partial interface IMEFormatReader : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("loadFileInfoWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadFileInfo ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMEFormatReaderLoadFileInfoCallback))]MEFormatReaderLoadFileInfoCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _LoadFileInfo (IMEFormatReader This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMEFormatReaderLoadFileInfoCallback))]MEFormatReaderLoadFileInfoCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMEFormatReaderLoadFileInfoCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("loadFileInfoWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("loadMetadataWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadMetadata ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMEFormatReaderLoadMetadataCallback))]MEFormatReaderLoadMetadataCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _LoadMetadata (IMEFormatReader This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMEFormatReaderLoadMetadataCallback))]MEFormatReaderLoadMetadataCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMEFormatReaderLoadMetadataCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("loadMetadataWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.RequiredMember]
		[Export ("loadTrackReadersWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void LoadTrackReaders ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMEFormatReaderLoadTrackReadersCallback))]MEFormatReaderLoadTrackReadersCallback completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _LoadTrackReaders (IMEFormatReader This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMEFormatReaderLoadTrackReadersCallback))]MEFormatReaderLoadTrackReadersCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMEFormatReaderLoadTrackReadersCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("loadTrackReadersWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[global::Foundation.OptionalMember]
		[Export ("parseAdditionalFragmentsWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void ParseAdditionalFragments ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMEFormatReaderParseAdditionalFragmentsCallback))]MEFormatReaderParseAdditionalFragmentsCallback completionHandler)
		{
			_ParseAdditionalFragments (this, completionHandler);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static void _ParseAdditionalFragments (IMEFormatReader This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMEFormatReaderParseAdditionalFragmentsCallback))]MEFormatReaderParseAdditionalFragmentsCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMEFormatReaderParseAdditionalFragmentsCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("parseAdditionalFragmentsWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
			GC.KeepAlive (This);
		}
		[DynamicDependencyAttribute ("LoadFileInfo(MediaExtension.MEFormatReaderLoadFileInfoCallback)")]
		[DynamicDependencyAttribute ("LoadMetadata(MediaExtension.MEFormatReaderLoadMetadataCallback)")]
		[DynamicDependencyAttribute ("LoadTrackReaders(MediaExtension.MEFormatReaderLoadTrackReadersCallback)")]
		[DynamicDependencyAttribute ("ParseAdditionalFragments(MediaExtension.MEFormatReaderParseAdditionalFragmentsCallback)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MEFormatReaderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMEFormatReader ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MEFormatReaderWrapper : BaseWrapper, IMEFormatReader {
		public MEFormatReaderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MEFormatReaderWrapper))]
		static MEFormatReaderWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("loadFileInfoWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void LoadFileInfo ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMEFormatReaderLoadFileInfoCallback))]MEFormatReaderLoadFileInfoCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMEFormatReaderLoadFileInfoCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("loadFileInfoWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
		}
		[Export ("loadMetadataWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void LoadMetadata ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMEFormatReaderLoadMetadataCallback))]MEFormatReaderLoadMetadataCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMEFormatReaderLoadMetadataCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("loadMetadataWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
		}
		[Export ("loadTrackReadersWithCompletionHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void LoadTrackReaders ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMEFormatReaderLoadTrackReadersCallback))]MEFormatReaderLoadTrackReadersCallback completionHandler)
		{
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMEFormatReaderLoadTrackReadersCallback.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("loadTrackReadersWithCompletionHandler:"), (IntPtr) block_ptr_completionHandler);
		}
	}
}
