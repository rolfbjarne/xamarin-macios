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
	/// <summary>This interface represents the Objective-C protocol <c>NSOpenSavePanelDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSOpenSavePanelDelegate", WrapperType = typeof (NSOpenSavePanelDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldEnableUrl", Selector = "panel:shouldEnableURL:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSSavePanel), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ValidateUrl", Selector = "panel:validateURL:error:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSSavePanel), typeof (NSUrl), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeToDirectory", Selector = "panel:didChangeToDirectoryURL:", ParameterType = new Type [] { typeof (NSSavePanel), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UserEnteredFilename", Selector = "panel:userEnteredFilename:confirmed:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (NSSavePanel), typeof (string), typeof (bool) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillExpand", Selector = "panel:willExpand:", ParameterType = new Type [] { typeof (NSSavePanel), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionDidChange", Selector = "panelSelectionDidChange:", ParameterType = new Type [] { typeof (NSSavePanel) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsValidFilename", Selector = "panel:isValidFilename:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSSavePanel), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DirectoryDidChange", Selector = "panel:directoryDidChange:", ParameterType = new Type [] { typeof (NSSavePanel), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CompareFilenames", Selector = "panel:compareFilename:with:caseSensitive:", ReturnType = typeof (NSComparisonResult), ParameterType = new Type [] { typeof (NSSavePanel), typeof (string), typeof (string), typeof (bool) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldShowFilename", Selector = "panel:shouldShowFilename:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSSavePanel), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDisplayName", Selector = "panel:displayNameForType:", ReturnType = typeof (string), ParameterType = new Type [] { typeof (NSSavePanel), typeof (UniformTypeIdentifiers.UTType) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelectType", Selector = "panel:didSelectType:", ParameterType = new Type [] { typeof (NSSavePanel), typeof (UniformTypeIdentifiers.UTType) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSOpenSavePanelDelegate : INativeObject, IDisposable
	{
		/// <param name="panel">To be added.</param><param name="url">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("panel:shouldEnableURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEnableUrl (NSSavePanel panel, NSUrl url)
		{
			return _ShouldEnableUrl (this, panel, url);
		}
		/// <param name="panel">To be added.</param><param name="url">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldEnableUrl (INSOpenSavePanelDelegate This, NSSavePanel panel, NSUrl url)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("panel:shouldEnableURL:"), panel__handle__, url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			GC.KeepAlive (url);
			return ret != 0;
		}
		/// <param name="panel">To be added.</param><param name="url">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("panel:validateURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ValidateUrl (NSSavePanel panel, NSUrl url, out NSError? outError)
		{
			return _ValidateUrl (this, panel, url, out outError);
		}
		/// <param name="panel">To be added.</param><param name="url">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static bool _ValidateUrl (INSOpenSavePanelDelegate This, NSSavePanel panel, NSUrl url, out NSError? outError)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("panel:validateURL:error:"), panel__handle__, url__handle__, &outErrorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			GC.KeepAlive (url);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		/// <param name="panel">To be added.</param><param name="newDirectoryUrl">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("panel:didChangeToDirectoryURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeToDirectory (NSSavePanel panel, NSUrl newDirectoryUrl)
		{
			_DidChangeToDirectory (this, panel, newDirectoryUrl);
		}
		/// <param name="panel">To be added.</param><param name="newDirectoryUrl">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidChangeToDirectory (INSOpenSavePanelDelegate This, NSSavePanel panel, NSUrl newDirectoryUrl)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			var newDirectoryUrl__handle__ = newDirectoryUrl!.GetNonNullHandle (nameof (newDirectoryUrl));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("panel:didChangeToDirectoryURL:"), panel__handle__, newDirectoryUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			GC.KeepAlive (newDirectoryUrl);
		}
		/// <param name="panel">To be added.</param><param name="filename">To be added.</param><param name="confirmed">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("panel:userEnteredFilename:confirmed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string UserEnteredFilename (NSSavePanel panel, string filename, bool confirmed)
		{
			return _UserEnteredFilename (this, panel, filename, confirmed);
		}
		/// <param name="panel">To be added.</param><param name="filename">To be added.</param><param name="confirmed">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _UserEnteredFilename (INSOpenSavePanelDelegate This, NSSavePanel panel, string filename, bool confirmed)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			if (filename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filename));
			var nsfilename = CFString.CreateNative (filename);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("panel:userEnteredFilename:confirmed:"), panel__handle__, nsfilename, confirmed ? (byte) 1 : (byte) 0), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			CFString.ReleaseNative (nsfilename);
			return ret!;
		}
		/// <param name="panel">To be added.</param><param name="expanding">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("panel:willExpand:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillExpand (NSSavePanel panel, bool expanding)
		{
			_WillExpand (this, panel, expanding);
		}
		/// <param name="panel">To be added.</param><param name="expanding">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WillExpand (INSOpenSavePanelDelegate This, NSSavePanel panel, bool expanding)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("panel:willExpand:"), panel__handle__, expanding ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
		}
		/// <param name="panel">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("panelSelectionDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionDidChange (NSSavePanel panel)
		{
			_SelectionDidChange (this, panel);
		}
		/// <param name="panel">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SelectionDidChange (INSOpenSavePanelDelegate This, NSSavePanel panel)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("panelSelectionDidChange:"), panel__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
		}
		/// <param name="panel">To be added.</param><param name="fileName">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("panel:isValidFilename:")]
		[ObsoletedOSPlatform ("macos10.6", "Use ValidateUrl instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsValidFilename (NSSavePanel panel, string fileName)
		{
			return _IsValidFilename (this, panel, fileName);
		}
		/// <param name="panel">To be added.</param><param name="fileName">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.6", "Use ValidateUrl instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsValidFilename (INSOpenSavePanelDelegate This, NSSavePanel panel, string fileName)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			if (fileName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fileName));
			var nsfileName = CFString.CreateNative (fileName);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("panel:isValidFilename:"), panel__handle__, nsfileName);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			CFString.ReleaseNative (nsfileName);
			return ret != 0;
		}
		/// <param name="panel">To be added.</param><param name="path">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("panel:directoryDidChange:")]
		[ObsoletedOSPlatform ("macos10.6", "Use DidChangeToDirectory instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DirectoryDidChange (NSSavePanel panel, string path)
		{
			_DirectoryDidChange (this, panel, path);
		}
		/// <param name="panel">To be added.</param><param name="path">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.6", "Use DidChangeToDirectory instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DirectoryDidChange (INSOpenSavePanelDelegate This, NSSavePanel panel, string path)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("panel:directoryDidChange:"), panel__handle__, nspath);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			CFString.ReleaseNative (nspath);
		}
		/// <param name="panel">To be added.</param><param name="name1">To be added.</param><param name="name2">To be added.</param><param name="caseSensitive">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("panel:compareFilename:with:caseSensitive:")]
		[ObsoletedOSPlatform ("macos10.6", "This method does not control sorting order.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSComparisonResult CompareFilenames (NSSavePanel panel, string name1, string name2, bool caseSensitive)
		{
			return _CompareFilenames (this, panel, name1, name2, caseSensitive);
		}
		/// <param name="panel">To be added.</param><param name="name1">To be added.</param><param name="name2">To be added.</param><param name="caseSensitive">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.6", "This method does not control sorting order.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSComparisonResult _CompareFilenames (INSOpenSavePanelDelegate This, NSSavePanel panel, string name1, string name2, bool caseSensitive)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			if (name1 is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name1));
			if (name2 is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name2));
			var nsname1 = CFString.CreateNative (name1);
			var nsname2 = CFString.CreateNative (name2);
			NSComparisonResult ret;
			ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("panel:compareFilename:with:caseSensitive:"), panel__handle__, nsname1, nsname2, caseSensitive ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			CFString.ReleaseNative (nsname1);
			CFString.ReleaseNative (nsname2);
			return ret!;
		}
		/// <param name="panel">To be added.</param><param name="filename">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("panel:shouldShowFilename:")]
		[ObsoletedOSPlatform ("macos10.6", "Use ShouldEnableUrl instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowFilename (NSSavePanel panel, string filename)
		{
			return _ShouldShowFilename (this, panel, filename);
		}
		/// <param name="panel">To be added.</param><param name="filename">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.6", "Use ShouldEnableUrl instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldShowFilename (INSOpenSavePanelDelegate This, NSSavePanel panel, string filename)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			if (filename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filename));
			var nsfilename = CFString.CreateNative (filename);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("panel:shouldShowFilename:"), panel__handle__, nsfilename);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			CFString.ReleaseNative (nsfilename);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("panel:displayNameForType:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetDisplayName (NSSavePanel panel, global::UniformTypeIdentifiers.UTType type)
		{
			return _GetDisplayName (this, panel, type);
		}
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string? _GetDisplayName (INSOpenSavePanelDelegate This, NSSavePanel panel, global::UniformTypeIdentifiers.UTType type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			var type__handle__ = type!.GetNonNullHandle (nameof (type));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("panel:displayNameForType:"), panel__handle__, type__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			GC.KeepAlive (type);
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("panel:didSelectType:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectType (NSSavePanel panel, global::UniformTypeIdentifiers.UTType? type)
		{
			_DidSelectType (this, panel, type);
		}
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidSelectType (INSOpenSavePanelDelegate This, NSSavePanel panel, global::UniformTypeIdentifiers.UTType? type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			var type__handle__ = type.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("panel:didSelectType:"), panel__handle__, type__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			GC.KeepAlive (type);
		}
		[DynamicDependencyAttribute ("CompareFilenames(AppKit.NSSavePanel,System.String,System.String,System.Boolean)")]
		[DynamicDependencyAttribute ("DidChangeToDirectory(AppKit.NSSavePanel,Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("DidSelectType(AppKit.NSSavePanel,UniformTypeIdentifiers.UTType)")]
		[DynamicDependencyAttribute ("DirectoryDidChange(AppKit.NSSavePanel,System.String)")]
		[DynamicDependencyAttribute ("GetDisplayName(AppKit.NSSavePanel,UniformTypeIdentifiers.UTType)")]
		[DynamicDependencyAttribute ("IsValidFilename(AppKit.NSSavePanel,System.String)")]
		[DynamicDependencyAttribute ("SelectionDidChange(AppKit.NSSavePanel)")]
		[DynamicDependencyAttribute ("ShouldEnableUrl(AppKit.NSSavePanel,Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("ShouldShowFilename(AppKit.NSSavePanel,System.String)")]
		[DynamicDependencyAttribute ("UserEnteredFilename(AppKit.NSSavePanel,System.String,System.Boolean)")]
		[DynamicDependencyAttribute ("ValidateUrl(AppKit.NSSavePanel,Foundation.NSUrl,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("WillExpand(AppKit.NSSavePanel,System.Boolean)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSOpenSavePanelDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSOpenSavePanelDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSOpenSavePanelDelegate" /> interface to support all the methods from the NSOpenSavePanelDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSOpenSavePanelDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSOpenSavePanelDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSOpenSavePanelDelegate_Extensions {
		/// <param name="panel">To be added.</param><param name="url">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldEnableUrl (this INSOpenSavePanelDelegate This, NSSavePanel panel, NSUrl url)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("panel:shouldEnableURL:"), panel__handle__, url__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			GC.KeepAlive (url);
			return ret != 0;
		}
		/// <param name="panel">To be added.</param><param name="url">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool ValidateUrl (this INSOpenSavePanelDelegate This, NSSavePanel panel, NSUrl url, out NSError? outError)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle outErrorValue = IntPtr.Zero;
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("panel:validateURL:error:"), panel__handle__, url__handle__, &outErrorValue);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			GC.KeepAlive (url);
			outError = Runtime.GetNSObject<NSError> (outErrorValue)!;
			return ret != 0;
		}
		/// <param name="panel">To be added.</param><param name="newDirectoryUrl">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidChangeToDirectory (this INSOpenSavePanelDelegate This, NSSavePanel panel, NSUrl newDirectoryUrl)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			var newDirectoryUrl__handle__ = newDirectoryUrl!.GetNonNullHandle (nameof (newDirectoryUrl));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("panel:didChangeToDirectoryURL:"), panel__handle__, newDirectoryUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			GC.KeepAlive (newDirectoryUrl);
		}
		/// <param name="panel">To be added.</param><param name="filename">To be added.</param><param name="confirmed">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string UserEnteredFilename (this INSOpenSavePanelDelegate This, NSSavePanel panel, string filename, bool confirmed)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			if (filename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filename));
			var nsfilename = CFString.CreateNative (filename);
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("panel:userEnteredFilename:confirmed:"), panel__handle__, nsfilename, confirmed ? (byte) 1 : (byte) 0), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			CFString.ReleaseNative (nsfilename);
			return ret!;
		}
		/// <param name="panel">To be added.</param><param name="expanding">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WillExpand (this INSOpenSavePanelDelegate This, NSSavePanel panel, bool expanding)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_bool (This.Handle, Selector.GetHandle ("panel:willExpand:"), panel__handle__, expanding ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
		}
		/// <param name="panel">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SelectionDidChange (this INSOpenSavePanelDelegate This, NSSavePanel panel)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("panelSelectionDidChange:"), panel__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
		}
		/// <param name="panel">To be added.</param><param name="fileName">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.6", "Use ValidateUrl instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsValidFilename (this INSOpenSavePanelDelegate This, NSSavePanel panel, string fileName)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			if (fileName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (fileName));
			var nsfileName = CFString.CreateNative (fileName);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("panel:isValidFilename:"), panel__handle__, nsfileName);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			CFString.ReleaseNative (nsfileName);
			return ret != 0;
		}
		/// <param name="panel">To be added.</param><param name="path">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.6", "Use DidChangeToDirectory instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DirectoryDidChange (this INSOpenSavePanelDelegate This, NSSavePanel panel, string path)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			if (path is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (path));
			var nspath = CFString.CreateNative (path);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("panel:directoryDidChange:"), panel__handle__, nspath);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			CFString.ReleaseNative (nspath);
		}
		/// <param name="panel">To be added.</param><param name="name1">To be added.</param><param name="name2">To be added.</param><param name="caseSensitive">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.6", "This method does not control sorting order.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSComparisonResult CompareFilenames (this INSOpenSavePanelDelegate This, NSSavePanel panel, string name1, string name2, bool caseSensitive)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			if (name1 is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name1));
			if (name2 is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name2));
			var nsname1 = CFString.CreateNative (name1);
			var nsname2 = CFString.CreateNative (name2);
			NSComparisonResult ret;
			ret = (NSComparisonResult) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_bool (This.Handle, Selector.GetHandle ("panel:compareFilename:with:caseSensitive:"), panel__handle__, nsname1, nsname2, caseSensitive ? (byte) 1 : (byte) 0);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			CFString.ReleaseNative (nsname1);
			CFString.ReleaseNative (nsname2);
			return ret!;
		}
		/// <param name="panel">To be added.</param><param name="filename">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[ObsoletedOSPlatform ("macos10.6", "Use ShouldEnableUrl instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldShowFilename (this INSOpenSavePanelDelegate This, NSSavePanel panel, string filename)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			if (filename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filename));
			var nsfilename = CFString.CreateNative (filename);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("panel:shouldShowFilename:"), panel__handle__, nsfilename);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			CFString.ReleaseNative (nsfilename);
			return ret != 0;
		}
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string? GetDisplayName (this INSOpenSavePanelDelegate This, NSSavePanel panel, global::UniformTypeIdentifiers.UTType type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			var type__handle__ = type!.GetNonNullHandle (nameof (type));
			string? ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("panel:displayNameForType:"), panel__handle__, type__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			GC.KeepAlive (type);
			return ret!;
		}
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidSelectType (this INSOpenSavePanelDelegate This, NSSavePanel panel, global::UniformTypeIdentifiers.UTType? type)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			var panel__handle__ = panel!.GetNonNullHandle (nameof (panel));
			var type__handle__ = type.GetHandle ();
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("panel:didSelectType:"), panel__handle__, type__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (panel);
			GC.KeepAlive (type);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSOpenSavePanelDelegateWrapper : BaseWrapper, INSOpenSavePanelDelegate {
		public NSOpenSavePanelDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSOpenSavePanelDelegateWrapper))]
		static NSOpenSavePanelDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AppKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSOpenSavePanelDelegate" /> (for the protocol <c>NSOpenSavePanelDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSOpenSavePanelDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AppKit_NSOpenSavePanelDelegate", false)]
	[Model]
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSOpenSavePanelDelegate : NSObject, INSOpenSavePanelDelegate {
		/// <summary>Creates a new <see cref="NSOpenSavePanelDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSOpenSavePanelDelegate () : base (NSObjectFlag.Empty)
		{
			global::AppKit.NSApplication.EnsureUIThread ();
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		protected NSOpenSavePanelDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSOpenSavePanelDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="panel">To be added.</param><param name="name1">To be added.</param><param name="name2">To be added.</param><param name="caseSensitive">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("panel:compareFilename:with:caseSensitive:")]
		[ObsoletedOSPlatform ("macos10.6", "This method does not control sorting order.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSComparisonResult CompareFilenames (NSSavePanel panel, string name1, string name2, bool caseSensitive)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="panel">To be added.</param><param name="newDirectoryUrl">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("panel:didChangeToDirectoryURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidChangeToDirectory (NSSavePanel panel, NSUrl newDirectoryUrl)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("panel:didSelectType:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidSelectType (NSSavePanel panel, global::UniformTypeIdentifiers.UTType? type)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="panel">To be added.</param><param name="path">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("panel:directoryDidChange:")]
		[ObsoletedOSPlatform ("macos10.6", "Use DidChangeToDirectory instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DirectoryDidChange (NSSavePanel panel, string path)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("panel:displayNameForType:")]
		[SupportedOSPlatform ("macos15.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetDisplayName (NSSavePanel panel, global::UniformTypeIdentifiers.UTType type)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="panel">To be added.</param><param name="fileName">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("panel:isValidFilename:")]
		[ObsoletedOSPlatform ("macos10.6", "Use ValidateUrl instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsValidFilename (NSSavePanel panel, string fileName)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="panel">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("panelSelectionDidChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionDidChange (NSSavePanel panel)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="panel">To be added.</param><param name="url">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("panel:shouldEnableURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldEnableUrl (NSSavePanel panel, NSUrl url)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="panel">To be added.</param><param name="filename">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("panel:shouldShowFilename:")]
		[ObsoletedOSPlatform ("macos10.6", "Use ShouldEnableUrl instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldShowFilename (NSSavePanel panel, string filename)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="panel">To be added.</param><param name="filename">To be added.</param><param name="confirmed">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("panel:userEnteredFilename:confirmed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string UserEnteredFilename (NSSavePanel panel, string filename, bool confirmed)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="panel">To be added.</param><param name="url">To be added.</param><param name="outError">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("panel:validateURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ValidateUrl (NSSavePanel panel, NSUrl url, out NSError? outError)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="panel">To be added.</param><param name="expanding">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("panel:willExpand:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WillExpand (NSSavePanel panel, bool expanding)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSOpenSavePanelDelegate */
}
