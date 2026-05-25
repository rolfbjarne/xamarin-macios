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
namespace Foundation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSFileManagerDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "NSFileManagerDelegate", WrapperType = typeof (NSFileManagerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldCopyItemAtPath", Selector = "fileManager:shouldCopyItemAtPath:toPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSFileManager), typeof (NSString), typeof (NSString) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldCopyItemAtUrl", Selector = "fileManager:shouldCopyItemAtURL:toURL:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSFileManager), typeof (NSUrl), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldLinkItemAtUrl", Selector = "fileManager:shouldLinkItemAtURL:toURL:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSFileManager), typeof (NSUrl), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldMoveItemAtUrl", Selector = "fileManager:shouldMoveItemAtURL:toURL:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSFileManager), typeof (NSUrl), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldProceedAfterErrorCopyingItem", Selector = "fileManager:shouldProceedAfterError:copyingItemAtURL:toURL:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSFileManager), typeof (NSError), typeof (NSUrl), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldProceedAfterErrorLinkingItem", Selector = "fileManager:shouldProceedAfterError:linkingItemAtURL:toURL:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSFileManager), typeof (NSError), typeof (NSUrl), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldProceedAfterErrorMovingItem", Selector = "fileManager:shouldProceedAfterError:movingItemAtURL:toURL:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSFileManager), typeof (NSError), typeof (NSUrl), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldRemoveItemAtUrl", Selector = "fileManager:shouldRemoveItemAtURL:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSFileManager), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldProceedAfterErrorRemovingItem", Selector = "fileManager:shouldProceedAfterError:removingItemAtURL:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSFileManager), typeof (NSError), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldProceedAfterErrorCopyingItem", Selector = "fileManager:shouldProceedAfterError:copyingItemAtPath:toPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSFileManager), typeof (NSError), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldMoveItemAtPath", Selector = "fileManager:shouldMoveItemAtPath:toPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSFileManager), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldProceedAfterErrorMovingItem", Selector = "fileManager:shouldProceedAfterError:movingItemAtPath:toPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSFileManager), typeof (NSError), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldLinkItemAtPath", Selector = "fileManager:shouldLinkItemAtPath:toPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSFileManager), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldProceedAfterErrorLinkingItem", Selector = "fileManager:shouldProceedAfterError:linkingItemAtPath:toPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSFileManager), typeof (NSError), typeof (string), typeof (string) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldRemoveItemAtPath", Selector = "fileManager:shouldRemoveItemAtPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSFileManager), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldProceedAfterErrorRemovingItem", Selector = "fileManager:shouldProceedAfterError:removingItemAtPath:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSFileManager), typeof (NSError), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface INSFileManagerDelegate : INativeObject, IDisposable
	{
		/// <param name="fm">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>Creates a copy of this object, allocating memory from the specified zone or from the default zone if the argument is null.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("fileManager:shouldCopyItemAtPath:toPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldCopyItemAtPath (NSFileManager fm, NSString srcPath, NSString dstPath)
		{
			return _ShouldCopyItemAtPath (this, fm, srcPath, dstPath);
		}
		/// <param name="fm">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>Creates a copy of this object, allocating memory from the specified zone or from the default zone if the argument is null.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldCopyItemAtPath (INSFileManagerDelegate This, NSFileManager fm, NSString srcPath, NSString dstPath)
		{
			var fm__handle__ = fm!.GetNonNullHandle (nameof (fm));
			var srcPath__handle__ = srcPath!.GetNonNullHandle (nameof (srcPath));
			var dstPath__handle__ = dstPath!.GetNonNullHandle (nameof (dstPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldCopyItemAtPath:toPath:"), fm__handle__, srcPath__handle__, dstPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fm);
			GC.KeepAlive (srcPath);
			GC.KeepAlive (dstPath);
			return ret != 0;
		}
		/// <param name="fm">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("fileManager:shouldCopyItemAtURL:toURL:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldCopyItemAtUrl (NSFileManager fm, NSUrl srcUrl, NSUrl dstUrl)
		{
			return _ShouldCopyItemAtUrl (this, fm, srcUrl, dstUrl);
		}
		/// <param name="fm">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldCopyItemAtUrl (INSFileManagerDelegate This, NSFileManager fm, NSUrl srcUrl, NSUrl dstUrl)
		{
			var fm__handle__ = fm!.GetNonNullHandle (nameof (fm));
			var srcUrl__handle__ = srcUrl!.GetNonNullHandle (nameof (srcUrl));
			var dstUrl__handle__ = dstUrl!.GetNonNullHandle (nameof (dstUrl));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldCopyItemAtURL:toURL:"), fm__handle__, srcUrl__handle__, dstUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fm);
			GC.KeepAlive (srcUrl);
			GC.KeepAlive (dstUrl);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("fileManager:shouldLinkItemAtURL:toURL:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldLinkItemAtUrl (NSFileManager fileManager, NSUrl srcUrl, NSUrl dstUrl)
		{
			return _ShouldLinkItemAtUrl (this, fileManager, srcUrl, dstUrl);
		}
		/// <param name="fileManager">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldLinkItemAtUrl (INSFileManagerDelegate This, NSFileManager fileManager, NSUrl srcUrl, NSUrl dstUrl)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			var srcUrl__handle__ = srcUrl!.GetNonNullHandle (nameof (srcUrl));
			var dstUrl__handle__ = dstUrl!.GetNonNullHandle (nameof (dstUrl));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldLinkItemAtURL:toURL:"), fileManager__handle__, srcUrl__handle__, dstUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			GC.KeepAlive (srcUrl);
			GC.KeepAlive (dstUrl);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("fileManager:shouldMoveItemAtURL:toURL:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldMoveItemAtUrl (NSFileManager fileManager, NSUrl srcUrl, NSUrl dstUrl)
		{
			return _ShouldMoveItemAtUrl (this, fileManager, srcUrl, dstUrl);
		}
		/// <param name="fileManager">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldMoveItemAtUrl (INSFileManagerDelegate This, NSFileManager fileManager, NSUrl srcUrl, NSUrl dstUrl)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			var srcUrl__handle__ = srcUrl!.GetNonNullHandle (nameof (srcUrl));
			var dstUrl__handle__ = dstUrl!.GetNonNullHandle (nameof (dstUrl));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldMoveItemAtURL:toURL:"), fileManager__handle__, srcUrl__handle__, dstUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			GC.KeepAlive (srcUrl);
			GC.KeepAlive (dstUrl);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("fileManager:shouldProceedAfterError:copyingItemAtURL:toURL:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProceedAfterErrorCopyingItem (NSFileManager fileManager, NSError error, NSUrl srcUrl, NSUrl dstUrl)
		{
			return _ShouldProceedAfterErrorCopyingItem (this, fileManager, error, srcUrl, dstUrl);
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldProceedAfterErrorCopyingItem (INSFileManagerDelegate This, NSFileManager fileManager, NSError error, NSUrl srcUrl, NSUrl dstUrl)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var srcUrl__handle__ = srcUrl!.GetNonNullHandle (nameof (srcUrl));
			var dstUrl__handle__ = dstUrl!.GetNonNullHandle (nameof (dstUrl));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldProceedAfterError:copyingItemAtURL:toURL:"), fileManager__handle__, error__handle__, srcUrl__handle__, dstUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			GC.KeepAlive (error);
			GC.KeepAlive (srcUrl);
			GC.KeepAlive (dstUrl);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("fileManager:shouldProceedAfterError:linkingItemAtURL:toURL:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProceedAfterErrorLinkingItem (NSFileManager fileManager, NSError error, NSUrl srcUrl, NSUrl dstUrl)
		{
			return _ShouldProceedAfterErrorLinkingItem (this, fileManager, error, srcUrl, dstUrl);
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldProceedAfterErrorLinkingItem (INSFileManagerDelegate This, NSFileManager fileManager, NSError error, NSUrl srcUrl, NSUrl dstUrl)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var srcUrl__handle__ = srcUrl!.GetNonNullHandle (nameof (srcUrl));
			var dstUrl__handle__ = dstUrl!.GetNonNullHandle (nameof (dstUrl));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldProceedAfterError:linkingItemAtURL:toURL:"), fileManager__handle__, error__handle__, srcUrl__handle__, dstUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			GC.KeepAlive (error);
			GC.KeepAlive (srcUrl);
			GC.KeepAlive (dstUrl);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("fileManager:shouldProceedAfterError:movingItemAtURL:toURL:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProceedAfterErrorMovingItem (NSFileManager fileManager, NSError error, NSUrl srcUrl, NSUrl dstUrl)
		{
			return _ShouldProceedAfterErrorMovingItem (this, fileManager, error, srcUrl, dstUrl);
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldProceedAfterErrorMovingItem (INSFileManagerDelegate This, NSFileManager fileManager, NSError error, NSUrl srcUrl, NSUrl dstUrl)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var srcUrl__handle__ = srcUrl!.GetNonNullHandle (nameof (srcUrl));
			var dstUrl__handle__ = dstUrl!.GetNonNullHandle (nameof (dstUrl));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldProceedAfterError:movingItemAtURL:toURL:"), fileManager__handle__, error__handle__, srcUrl__handle__, dstUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			GC.KeepAlive (error);
			GC.KeepAlive (srcUrl);
			GC.KeepAlive (dstUrl);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="url">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("fileManager:shouldRemoveItemAtURL:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRemoveItemAtUrl (NSFileManager fileManager, NSUrl url)
		{
			return _ShouldRemoveItemAtUrl (this, fileManager, url);
		}
		/// <param name="fileManager">To be added.</param><param name="url">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldRemoveItemAtUrl (INSFileManagerDelegate This, NSFileManager fileManager, NSUrl url)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldRemoveItemAtURL:"), fileManager__handle__, url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			GC.KeepAlive (url);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="url">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("fileManager:shouldProceedAfterError:removingItemAtURL:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProceedAfterErrorRemovingItem (NSFileManager fileManager, NSError error, NSUrl url)
		{
			return _ShouldProceedAfterErrorRemovingItem (this, fileManager, error, url);
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="url">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldProceedAfterErrorRemovingItem (INSFileManagerDelegate This, NSFileManager fileManager, NSError error, NSUrl url)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldProceedAfterError:removingItemAtURL:"), fileManager__handle__, error__handle__, url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			GC.KeepAlive (error);
			GC.KeepAlive (url);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("fileManager:shouldProceedAfterError:copyingItemAtPath:toPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProceedAfterErrorCopyingItem (NSFileManager fileManager, NSError error, string srcPath, string dstPath)
		{
			return _ShouldProceedAfterErrorCopyingItem (this, fileManager, error, srcPath, dstPath);
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldProceedAfterErrorCopyingItem (INSFileManagerDelegate This, NSFileManager fileManager, NSError error, string srcPath, string dstPath)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			if (srcPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (srcPath));
			if (dstPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dstPath));
			var nssrcPath = CFString.CreateNative (srcPath);
			var nsdstPath = CFString.CreateNative (dstPath);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldProceedAfterError:copyingItemAtPath:toPath:"), fileManager__handle__, error__handle__, nssrcPath, nsdstPath);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			GC.KeepAlive (error);
			CFString.ReleaseNative (nssrcPath);
			CFString.ReleaseNative (nsdstPath);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("fileManager:shouldMoveItemAtPath:toPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldMoveItemAtPath (NSFileManager fileManager, string srcPath, string dstPath)
		{
			return _ShouldMoveItemAtPath (this, fileManager, srcPath, dstPath);
		}
		/// <param name="fileManager">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldMoveItemAtPath (INSFileManagerDelegate This, NSFileManager fileManager, string srcPath, string dstPath)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			if (srcPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (srcPath));
			if (dstPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dstPath));
			var nssrcPath = CFString.CreateNative (srcPath);
			var nsdstPath = CFString.CreateNative (dstPath);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldMoveItemAtPath:toPath:"), fileManager__handle__, nssrcPath, nsdstPath);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			CFString.ReleaseNative (nssrcPath);
			CFString.ReleaseNative (nsdstPath);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("fileManager:shouldProceedAfterError:movingItemAtPath:toPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProceedAfterErrorMovingItem (NSFileManager fileManager, NSError error, string srcPath, string dstPath)
		{
			return _ShouldProceedAfterErrorMovingItem (this, fileManager, error, srcPath, dstPath);
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldProceedAfterErrorMovingItem (INSFileManagerDelegate This, NSFileManager fileManager, NSError error, string srcPath, string dstPath)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			if (srcPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (srcPath));
			if (dstPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dstPath));
			var nssrcPath = CFString.CreateNative (srcPath);
			var nsdstPath = CFString.CreateNative (dstPath);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldProceedAfterError:movingItemAtPath:toPath:"), fileManager__handle__, error__handle__, nssrcPath, nsdstPath);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			GC.KeepAlive (error);
			CFString.ReleaseNative (nssrcPath);
			CFString.ReleaseNative (nsdstPath);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("fileManager:shouldLinkItemAtPath:toPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldLinkItemAtPath (NSFileManager fileManager, string srcPath, string dstPath)
		{
			return _ShouldLinkItemAtPath (this, fileManager, srcPath, dstPath);
		}
		/// <param name="fileManager">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldLinkItemAtPath (INSFileManagerDelegate This, NSFileManager fileManager, string srcPath, string dstPath)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			if (srcPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (srcPath));
			if (dstPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dstPath));
			var nssrcPath = CFString.CreateNative (srcPath);
			var nsdstPath = CFString.CreateNative (dstPath);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldLinkItemAtPath:toPath:"), fileManager__handle__, nssrcPath, nsdstPath);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			CFString.ReleaseNative (nssrcPath);
			CFString.ReleaseNative (nsdstPath);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("fileManager:shouldProceedAfterError:linkingItemAtPath:toPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProceedAfterErrorLinkingItem (NSFileManager fileManager, NSError error, string srcPath, string dstPath)
		{
			return _ShouldProceedAfterErrorLinkingItem (this, fileManager, error, srcPath, dstPath);
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldProceedAfterErrorLinkingItem (INSFileManagerDelegate This, NSFileManager fileManager, NSError error, string srcPath, string dstPath)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			if (srcPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (srcPath));
			if (dstPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dstPath));
			var nssrcPath = CFString.CreateNative (srcPath);
			var nsdstPath = CFString.CreateNative (dstPath);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldProceedAfterError:linkingItemAtPath:toPath:"), fileManager__handle__, error__handle__, nssrcPath, nsdstPath);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			GC.KeepAlive (error);
			CFString.ReleaseNative (nssrcPath);
			CFString.ReleaseNative (nsdstPath);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="path">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("fileManager:shouldRemoveItemAtPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRemoveItemAtPath (NSFileManager fileManager, string path)
		{
			return _ShouldRemoveItemAtPath (this, fileManager, path);
		}
		/// <param name="fileManager">To be added.</param><param name="path">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldRemoveItemAtPath (INSFileManagerDelegate This, NSFileManager fileManager, string path)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldRemoveItemAtPath:"), fileManager__handle__, nspath);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			CFString.ReleaseNative (nspath);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="path">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("fileManager:shouldProceedAfterError:removingItemAtPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProceedAfterErrorRemovingItem (NSFileManager fileManager, NSError error, string path)
		{
			return _ShouldProceedAfterErrorRemovingItem (this, fileManager, error, path);
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="path">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldProceedAfterErrorRemovingItem (INSFileManagerDelegate This, NSFileManager fileManager, NSError error, string path)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldProceedAfterError:removingItemAtPath:"), fileManager__handle__, error__handle__, nspath);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			GC.KeepAlive (error);
			CFString.ReleaseNative (nspath);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("ShouldCopyItemAtPath(Foundation.NSFileManager,Foundation.NSString,Foundation.NSString)")]
		[DynamicDependencyAttribute ("ShouldCopyItemAtUrl(Foundation.NSFileManager,Foundation.NSUrl,Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("ShouldLinkItemAtPath(Foundation.NSFileManager,System.String,System.String)")]
		[DynamicDependencyAttribute ("ShouldLinkItemAtUrl(Foundation.NSFileManager,Foundation.NSUrl,Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("ShouldMoveItemAtPath(Foundation.NSFileManager,System.String,System.String)")]
		[DynamicDependencyAttribute ("ShouldMoveItemAtUrl(Foundation.NSFileManager,Foundation.NSUrl,Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("ShouldProceedAfterErrorCopyingItem(Foundation.NSFileManager,Foundation.NSError,Foundation.NSUrl,Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("ShouldProceedAfterErrorCopyingItem(Foundation.NSFileManager,Foundation.NSError,System.String,System.String)")]
		[DynamicDependencyAttribute ("ShouldProceedAfterErrorLinkingItem(Foundation.NSFileManager,Foundation.NSError,Foundation.NSUrl,Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("ShouldProceedAfterErrorLinkingItem(Foundation.NSFileManager,Foundation.NSError,System.String,System.String)")]
		[DynamicDependencyAttribute ("ShouldProceedAfterErrorMovingItem(Foundation.NSFileManager,Foundation.NSError,Foundation.NSUrl,Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("ShouldProceedAfterErrorMovingItem(Foundation.NSFileManager,Foundation.NSError,System.String,System.String)")]
		[DynamicDependencyAttribute ("ShouldProceedAfterErrorRemovingItem(Foundation.NSFileManager,Foundation.NSError,Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("ShouldProceedAfterErrorRemovingItem(Foundation.NSFileManager,Foundation.NSError,System.String)")]
		[DynamicDependencyAttribute ("ShouldRemoveItemAtPath(Foundation.NSFileManager,System.String)")]
		[DynamicDependencyAttribute ("ShouldRemoveItemAtUrl(Foundation.NSFileManager,Foundation.NSUrl)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileManagerDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileManagerDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSFileManagerDelegate" /> interface to support all the methods from the NSFileManagerDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSFileManagerDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSFileManagerDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSFileManagerDelegate_Extensions {
		/// <param name="fm">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>Creates a copy of this object, allocating memory from the specified zone or from the default zone if the argument is null.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldCopyItemAtPath (this INSFileManagerDelegate This, NSFileManager fm, NSString srcPath, NSString dstPath)
		{
			var fm__handle__ = fm!.GetNonNullHandle (nameof (fm));
			var srcPath__handle__ = srcPath!.GetNonNullHandle (nameof (srcPath));
			var dstPath__handle__ = dstPath!.GetNonNullHandle (nameof (dstPath));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldCopyItemAtPath:toPath:"), fm__handle__, srcPath__handle__, dstPath__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fm);
			GC.KeepAlive (srcPath);
			GC.KeepAlive (dstPath);
			return ret != 0;
		}
		/// <param name="fm">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldCopyItemAtUrl (this INSFileManagerDelegate This, NSFileManager fm, NSUrl srcUrl, NSUrl dstUrl)
		{
			var fm__handle__ = fm!.GetNonNullHandle (nameof (fm));
			var srcUrl__handle__ = srcUrl!.GetNonNullHandle (nameof (srcUrl));
			var dstUrl__handle__ = dstUrl!.GetNonNullHandle (nameof (dstUrl));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldCopyItemAtURL:toURL:"), fm__handle__, srcUrl__handle__, dstUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fm);
			GC.KeepAlive (srcUrl);
			GC.KeepAlive (dstUrl);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldLinkItemAtUrl (this INSFileManagerDelegate This, NSFileManager fileManager, NSUrl srcUrl, NSUrl dstUrl)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			var srcUrl__handle__ = srcUrl!.GetNonNullHandle (nameof (srcUrl));
			var dstUrl__handle__ = dstUrl!.GetNonNullHandle (nameof (dstUrl));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldLinkItemAtURL:toURL:"), fileManager__handle__, srcUrl__handle__, dstUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			GC.KeepAlive (srcUrl);
			GC.KeepAlive (dstUrl);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldMoveItemAtUrl (this INSFileManagerDelegate This, NSFileManager fileManager, NSUrl srcUrl, NSUrl dstUrl)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			var srcUrl__handle__ = srcUrl!.GetNonNullHandle (nameof (srcUrl));
			var dstUrl__handle__ = dstUrl!.GetNonNullHandle (nameof (dstUrl));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldMoveItemAtURL:toURL:"), fileManager__handle__, srcUrl__handle__, dstUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			GC.KeepAlive (srcUrl);
			GC.KeepAlive (dstUrl);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldProceedAfterErrorCopyingItem (this INSFileManagerDelegate This, NSFileManager fileManager, NSError error, NSUrl srcUrl, NSUrl dstUrl)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var srcUrl__handle__ = srcUrl!.GetNonNullHandle (nameof (srcUrl));
			var dstUrl__handle__ = dstUrl!.GetNonNullHandle (nameof (dstUrl));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldProceedAfterError:copyingItemAtURL:toURL:"), fileManager__handle__, error__handle__, srcUrl__handle__, dstUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			GC.KeepAlive (error);
			GC.KeepAlive (srcUrl);
			GC.KeepAlive (dstUrl);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldProceedAfterErrorLinkingItem (this INSFileManagerDelegate This, NSFileManager fileManager, NSError error, NSUrl srcUrl, NSUrl dstUrl)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var srcUrl__handle__ = srcUrl!.GetNonNullHandle (nameof (srcUrl));
			var dstUrl__handle__ = dstUrl!.GetNonNullHandle (nameof (dstUrl));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldProceedAfterError:linkingItemAtURL:toURL:"), fileManager__handle__, error__handle__, srcUrl__handle__, dstUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			GC.KeepAlive (error);
			GC.KeepAlive (srcUrl);
			GC.KeepAlive (dstUrl);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldProceedAfterErrorMovingItem (this INSFileManagerDelegate This, NSFileManager fileManager, NSError error, NSUrl srcUrl, NSUrl dstUrl)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var srcUrl__handle__ = srcUrl!.GetNonNullHandle (nameof (srcUrl));
			var dstUrl__handle__ = dstUrl!.GetNonNullHandle (nameof (dstUrl));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldProceedAfterError:movingItemAtURL:toURL:"), fileManager__handle__, error__handle__, srcUrl__handle__, dstUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			GC.KeepAlive (error);
			GC.KeepAlive (srcUrl);
			GC.KeepAlive (dstUrl);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="url">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldRemoveItemAtUrl (this INSFileManagerDelegate This, NSFileManager fileManager, NSUrl url)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldRemoveItemAtURL:"), fileManager__handle__, url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			GC.KeepAlive (url);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="url">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldProceedAfterErrorRemovingItem (this INSFileManagerDelegate This, NSFileManager fileManager, NSError error, NSUrl url)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldProceedAfterError:removingItemAtURL:"), fileManager__handle__, error__handle__, url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			GC.KeepAlive (error);
			GC.KeepAlive (url);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldProceedAfterErrorCopyingItem (this INSFileManagerDelegate This, NSFileManager fileManager, NSError error, string srcPath, string dstPath)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			if (srcPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (srcPath));
			if (dstPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dstPath));
			var nssrcPath = CFString.CreateNative (srcPath);
			var nsdstPath = CFString.CreateNative (dstPath);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldProceedAfterError:copyingItemAtPath:toPath:"), fileManager__handle__, error__handle__, nssrcPath, nsdstPath);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			GC.KeepAlive (error);
			CFString.ReleaseNative (nssrcPath);
			CFString.ReleaseNative (nsdstPath);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldMoveItemAtPath (this INSFileManagerDelegate This, NSFileManager fileManager, string srcPath, string dstPath)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			if (srcPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (srcPath));
			if (dstPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dstPath));
			var nssrcPath = CFString.CreateNative (srcPath);
			var nsdstPath = CFString.CreateNative (dstPath);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldMoveItemAtPath:toPath:"), fileManager__handle__, nssrcPath, nsdstPath);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			CFString.ReleaseNative (nssrcPath);
			CFString.ReleaseNative (nsdstPath);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldProceedAfterErrorMovingItem (this INSFileManagerDelegate This, NSFileManager fileManager, NSError error, string srcPath, string dstPath)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			if (srcPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (srcPath));
			if (dstPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dstPath));
			var nssrcPath = CFString.CreateNative (srcPath);
			var nsdstPath = CFString.CreateNative (dstPath);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldProceedAfterError:movingItemAtPath:toPath:"), fileManager__handle__, error__handle__, nssrcPath, nsdstPath);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			GC.KeepAlive (error);
			CFString.ReleaseNative (nssrcPath);
			CFString.ReleaseNative (nsdstPath);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldLinkItemAtPath (this INSFileManagerDelegate This, NSFileManager fileManager, string srcPath, string dstPath)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			if (srcPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (srcPath));
			if (dstPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dstPath));
			var nssrcPath = CFString.CreateNative (srcPath);
			var nsdstPath = CFString.CreateNative (dstPath);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldLinkItemAtPath:toPath:"), fileManager__handle__, nssrcPath, nsdstPath);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			CFString.ReleaseNative (nssrcPath);
			CFString.ReleaseNative (nsdstPath);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldProceedAfterErrorLinkingItem (this INSFileManagerDelegate This, NSFileManager fileManager, NSError error, string srcPath, string dstPath)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			if (srcPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (srcPath));
			if (dstPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dstPath));
			var nssrcPath = CFString.CreateNative (srcPath);
			var nsdstPath = CFString.CreateNative (dstPath);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldProceedAfterError:linkingItemAtPath:toPath:"), fileManager__handle__, error__handle__, nssrcPath, nsdstPath);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			GC.KeepAlive (error);
			CFString.ReleaseNative (nssrcPath);
			CFString.ReleaseNative (nsdstPath);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="path">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldRemoveItemAtPath (this INSFileManagerDelegate This, NSFileManager fileManager, string path)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldRemoveItemAtPath:"), fileManager__handle__, nspath);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			CFString.ReleaseNative (nspath);
			return ret != 0;
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="path">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldProceedAfterErrorRemovingItem (this INSFileManagerDelegate This, NSFileManager fileManager, NSError error, string path)
		{
			var fileManager__handle__ = fileManager!.GetNonNullHandle (nameof (fileManager));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("fileManager:shouldProceedAfterError:removingItemAtPath:"), fileManager__handle__, error__handle__, nspath);
			GC.KeepAlive (This);
			GC.KeepAlive (fileManager);
			GC.KeepAlive (error);
			CFString.ReleaseNative (nspath);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileManagerDelegateWrapper : BaseWrapper, INSFileManagerDelegate {
		public NSFileManagerDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileManagerDelegateWrapper))]
		static NSFileManagerDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace Foundation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSFileManagerDelegate" /> (for the protocol <c>NSFileManagerDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSFileManagerDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_MacCatalyst__Foundation_NSFileManagerDelegate", false)]
	[Model]
	public unsafe partial class NSFileManagerDelegate : NSObject, INSFileManagerDelegate {
		/// <summary>Creates a new <see cref="NSFileManagerDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSFileManagerDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
			}
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
		protected NSFileManagerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
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
		protected internal NSFileManagerDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="fm">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>Creates a copy of this object, allocating memory from the specified zone or from the default zone if the argument is null.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fileManager:shouldCopyItemAtPath:toPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldCopyItemAtPath (NSFileManager fm, NSString srcPath, NSString dstPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="fm">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fileManager:shouldCopyItemAtURL:toURL:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldCopyItemAtUrl (NSFileManager fm, NSUrl srcUrl, NSUrl dstUrl)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="fileManager">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fileManager:shouldLinkItemAtPath:toPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldLinkItemAtPath (NSFileManager fileManager, string srcPath, string dstPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="fileManager">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fileManager:shouldLinkItemAtURL:toURL:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldLinkItemAtUrl (NSFileManager fileManager, NSUrl srcUrl, NSUrl dstUrl)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="fileManager">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fileManager:shouldMoveItemAtPath:toPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldMoveItemAtPath (NSFileManager fileManager, string srcPath, string dstPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="fileManager">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fileManager:shouldMoveItemAtURL:toURL:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldMoveItemAtUrl (NSFileManager fileManager, NSUrl srcUrl, NSUrl dstUrl)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fileManager:shouldProceedAfterError:copyingItemAtURL:toURL:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProceedAfterErrorCopyingItem (NSFileManager fileManager, NSError error, NSUrl srcUrl, NSUrl dstUrl)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fileManager:shouldProceedAfterError:copyingItemAtPath:toPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProceedAfterErrorCopyingItem (NSFileManager fileManager, NSError error, string srcPath, string dstPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fileManager:shouldProceedAfterError:linkingItemAtURL:toURL:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProceedAfterErrorLinkingItem (NSFileManager fileManager, NSError error, NSUrl srcUrl, NSUrl dstUrl)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fileManager:shouldProceedAfterError:linkingItemAtPath:toPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProceedAfterErrorLinkingItem (NSFileManager fileManager, NSError error, string srcPath, string dstPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcUrl">To be added.</param><param name="dstUrl">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fileManager:shouldProceedAfterError:movingItemAtURL:toURL:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProceedAfterErrorMovingItem (NSFileManager fileManager, NSError error, NSUrl srcUrl, NSUrl dstUrl)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="srcPath">To be added.</param><param name="dstPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fileManager:shouldProceedAfterError:movingItemAtPath:toPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProceedAfterErrorMovingItem (NSFileManager fileManager, NSError error, string srcPath, string dstPath)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="url">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fileManager:shouldProceedAfterError:removingItemAtURL:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProceedAfterErrorRemovingItem (NSFileManager fileManager, NSError error, NSUrl url)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="fileManager">To be added.</param><param name="error">To be added.</param><param name="path">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fileManager:shouldProceedAfterError:removingItemAtPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldProceedAfterErrorRemovingItem (NSFileManager fileManager, NSError error, string path)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="fileManager">To be added.</param><param name="path">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fileManager:shouldRemoveItemAtPath:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRemoveItemAtPath (NSFileManager fileManager, string path)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="fileManager">To be added.</param><param name="url">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("fileManager:shouldRemoveItemAtURL:")]
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldRemoveItemAtUrl (NSFileManager fileManager, NSUrl url)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSFileManagerDelegate */
}
