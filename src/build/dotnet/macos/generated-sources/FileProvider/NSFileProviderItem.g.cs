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
namespace FileProvider {
	#pragma warning disable CS1573
	/// <summary>An item the file provider extension manages.</summary><remarks>To be added.</remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSFileProviderItem", WrapperType = typeof (NSFileProviderItemWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetContentType", Selector = "contentType", ReturnType = typeof (UniformTypeIdentifiers.UTType))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCapabilities", Selector = "capabilities", ReturnType = typeof (NSFileProviderItemCapabilities))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDocumentSize", Selector = "documentSize", ReturnType = typeof (NSNumber))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetChildItemCount", Selector = "childItemCount", ReturnType = typeof (NSNumber))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCreationDate", Selector = "creationDate", ReturnType = typeof (NSDate))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetContentModificationDate", Selector = "contentModificationDate", ReturnType = typeof (NSDate))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetLastUsedDate", Selector = "lastUsedDate", ReturnType = typeof (NSDate))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetTagData", Selector = "tagData", ReturnType = typeof (NSData))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsUploaded", Selector = "isUploaded", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsUploading", Selector = "isUploading", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetUploadingError", Selector = "uploadingError", ReturnType = typeof (NSError))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsDownloaded", Selector = "isDownloaded", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsDownloading", Selector = "isDownloading", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetDownloadingError", Selector = "downloadingError", ReturnType = typeof (NSError))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsMostRecentVersionDownloaded", Selector = "isMostRecentVersionDownloaded", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsShared", Selector = "isShared", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsSharedByCurrentUser", Selector = "isSharedByCurrentUser", ReturnType = typeof (bool))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetOwnerNameComponents", Selector = "ownerNameComponents", ReturnType = typeof (NSPersonNameComponents))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetMostRecentEditorNameComponents", Selector = "mostRecentEditorNameComponents", ReturnType = typeof (NSPersonNameComponents))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetUserInfo", Selector = "userInfo", ReturnType = typeof (NSDictionary))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Identifier", Selector = "itemIdentifier", PropertyType = typeof (string), GetterSelector = "itemIdentifier", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ParentIdentifier", Selector = "parentItemIdentifier", PropertyType = typeof (string), GetterSelector = "parentItemIdentifier", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Filename", Selector = "filename", PropertyType = typeof (string), GetterSelector = "filename", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "TypeIdentifier", Selector = "typeIdentifier", PropertyType = typeof (string), GetterSelector = "typeIdentifier", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "FileSystemFlags", Selector = "fileSystemFlags", PropertyType = typeof (NSFileProviderFileSystemFlags), GetterSelector = "fileSystemFlags", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ExtendedAttributes", Selector = "extendedAttributes", PropertyType = typeof (global::Foundation.NSDictionary<NSString, NSData>), GetterSelector = "extendedAttributes", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ItemVersion", Selector = "itemVersion", PropertyType = typeof (NSFileProviderItemVersion), GetterSelector = "itemVersion", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SymlinkTargetPath", Selector = "symlinkTargetPath", PropertyType = typeof (string), GetterSelector = "symlinkTargetPath", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "TypeAndCreator", Selector = "typeAndCreator", PropertyType = typeof (NSFileProviderTypeAndCreator), GetterSelector = "typeAndCreator", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ContentPolicy", Selector = "contentPolicy", PropertyType = typeof (NSFileProviderContentPolicy), GetterSelector = "contentPolicy", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface INSFileProviderItem : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("contentType")]
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UniformTypeIdentifiers.UTType GetContentType ()
		{
			return _GetContentType (this);
		}
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static global::UniformTypeIdentifiers.UTType _GetContentType (INSFileProviderItem This)
		{
			global::UniformTypeIdentifiers.UTType ret;
			ret =  Runtime.GetNSObject<global::UniformTypeIdentifiers.UTType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("contentType")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("capabilities")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSFileProviderItemCapabilities GetCapabilities ()
		{
			return _GetCapabilities (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSFileProviderItemCapabilities _GetCapabilities (INSFileProviderItem This)
		{
			NSFileProviderItemCapabilities ret;
			ret = (NSFileProviderItemCapabilities) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("capabilities"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("documentSize")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber? GetDocumentSize ()
		{
			return _GetDocumentSize (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSNumber? _GetDocumentSize (INSFileProviderItem This)
		{
			NSNumber ret;
			ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("documentSize")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("childItemCount")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber? GetChildItemCount ()
		{
			return _GetChildItemCount (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSNumber? _GetChildItemCount (INSFileProviderItem This)
		{
			NSNumber ret;
			ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("childItemCount")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("creationDate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate? GetCreationDate ()
		{
			return _GetCreationDate (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDate? _GetCreationDate (INSFileProviderItem This)
		{
			NSDate ret;
			ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("creationDate")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("contentModificationDate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate? GetContentModificationDate ()
		{
			return _GetContentModificationDate (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDate? _GetContentModificationDate (INSFileProviderItem This)
		{
			NSDate ret;
			ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("contentModificationDate")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("lastUsedDate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate? GetLastUsedDate ()
		{
			return _GetLastUsedDate (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDate? _GetLastUsedDate (INSFileProviderItem This)
		{
			NSDate ret;
			ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("lastUsedDate")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("tagData")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? GetTagData ()
		{
			return _GetTagData (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSData? _GetTagData (INSFileProviderItem This)
		{
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("tagData")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("isUploaded")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsUploaded ()
		{
			return _IsUploaded (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsUploaded (INSFileProviderItem This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isUploaded"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("isUploading")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsUploading ()
		{
			return _IsUploading (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsUploading (INSFileProviderItem This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isUploading"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("uploadingError")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSError? GetUploadingError ()
		{
			return _GetUploadingError (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSError? _GetUploadingError (INSFileProviderItem This)
		{
			NSError ret;
			ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("uploadingError")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("isDownloaded")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsDownloaded ()
		{
			return _IsDownloaded (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsDownloaded (INSFileProviderItem This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isDownloaded"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("isDownloading")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsDownloading ()
		{
			return _IsDownloading (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsDownloading (INSFileProviderItem This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isDownloading"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("downloadingError")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSError? GetDownloadingError ()
		{
			return _GetDownloadingError (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSError? _GetDownloadingError (INSFileProviderItem This)
		{
			NSError ret;
			ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("downloadingError")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("isMostRecentVersionDownloaded")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsMostRecentVersionDownloaded ()
		{
			return _IsMostRecentVersionDownloaded (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsMostRecentVersionDownloaded (INSFileProviderItem This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isMostRecentVersionDownloaded"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("isShared")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsShared ()
		{
			return _IsShared (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsShared (INSFileProviderItem This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isShared"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("isSharedByCurrentUser")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsSharedByCurrentUser ()
		{
			return _IsSharedByCurrentUser (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsSharedByCurrentUser (INSFileProviderItem This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSharedByCurrentUser"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("ownerNameComponents")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPersonNameComponents? GetOwnerNameComponents ()
		{
			return _GetOwnerNameComponents (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSPersonNameComponents? _GetOwnerNameComponents (INSFileProviderItem This)
		{
			NSPersonNameComponents ret;
			ret =  Runtime.GetNSObject<NSPersonNameComponents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("ownerNameComponents")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("mostRecentEditorNameComponents")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSPersonNameComponents? GetMostRecentEditorNameComponents ()
		{
			return _GetMostRecentEditorNameComponents (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSPersonNameComponents? _GetMostRecentEditorNameComponents (INSFileProviderItem This)
		{
			NSPersonNameComponents ret;
			ret =  Runtime.GetNSObject<NSPersonNameComponents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("mostRecentEditorNameComponents")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("userInfo")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary? GetUserInfo ()
		{
			return _GetUserInfo (this);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary? _GetUserInfo (INSFileProviderItem This)
		{
			NSDictionary ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("userInfo")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[DynamicDependencyAttribute ("ContentPolicy")]
		[DynamicDependencyAttribute ("ExtendedAttributes")]
		[DynamicDependencyAttribute ("Filename")]
		[DynamicDependencyAttribute ("FileSystemFlags")]
		[DynamicDependencyAttribute ("GetCapabilities()")]
		[DynamicDependencyAttribute ("GetChildItemCount()")]
		[DynamicDependencyAttribute ("GetContentModificationDate()")]
		[DynamicDependencyAttribute ("GetContentType()")]
		[DynamicDependencyAttribute ("GetCreationDate()")]
		[DynamicDependencyAttribute ("GetDocumentSize()")]
		[DynamicDependencyAttribute ("GetDownloadingError()")]
		[DynamicDependencyAttribute ("GetLastUsedDate()")]
		[DynamicDependencyAttribute ("GetMostRecentEditorNameComponents()")]
		[DynamicDependencyAttribute ("GetOwnerNameComponents()")]
		[DynamicDependencyAttribute ("GetTagData()")]
		[DynamicDependencyAttribute ("GetUploadingError()")]
		[DynamicDependencyAttribute ("GetUserInfo()")]
		[DynamicDependencyAttribute ("Identifier")]
		[DynamicDependencyAttribute ("IsDownloaded()")]
		[DynamicDependencyAttribute ("IsDownloading()")]
		[DynamicDependencyAttribute ("IsMostRecentVersionDownloaded()")]
		[DynamicDependencyAttribute ("IsShared()")]
		[DynamicDependencyAttribute ("IsSharedByCurrentUser()")]
		[DynamicDependencyAttribute ("IsUploaded()")]
		[DynamicDependencyAttribute ("IsUploading()")]
		[DynamicDependencyAttribute ("ItemVersion")]
		[DynamicDependencyAttribute ("ParentIdentifier")]
		[DynamicDependencyAttribute ("SymlinkTargetPath")]
		[DynamicDependencyAttribute ("TypeAndCreator")]
		[DynamicDependencyAttribute ("TypeIdentifier")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderItemWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSFileProviderItem ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string Identifier {
			[Export ("itemIdentifier")]
			get {
				return _GetIdentifier (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetIdentifier (INSFileProviderItem This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("itemIdentifier")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string ParentIdentifier {
			[Export ("parentItemIdentifier")]
			get {
				return _GetParentIdentifier (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetParentIdentifier (INSFileProviderItem This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("parentItemIdentifier")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string Filename {
			[Export ("filename")]
			get {
				return _GetFilename (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetFilename (INSFileProviderItem This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("filename")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios14.0", "Use 'GetContentType' instead.")]
		[ObsoletedOSPlatform ("macos11.0", "Use 'GetContentType' instead.")]
		[ObsoletedOSPlatform ("maccatalyst14.0", "Use 'GetContentType' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.OptionalMember]
		public virtual string TypeIdentifier {
			[Export ("typeIdentifier")]
			get {
				return _GetTypeIdentifier (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetTypeIdentifier (INSFileProviderItem This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("typeIdentifier")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.OptionalMember]
		public virtual NSFileProviderFileSystemFlags FileSystemFlags {
			[Export ("fileSystemFlags")]
			get {
				return _GetFileSystemFlags (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSFileProviderFileSystemFlags _GetFileSystemFlags (INSFileProviderItem This)
		{
			NSFileProviderFileSystemFlags ret;
			ret = (NSFileProviderFileSystemFlags) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("fileSystemFlags"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.OptionalMember]
		public virtual NSDictionary<NSString, NSData> ExtendedAttributes {
			[Export ("extendedAttributes", ArgumentSemantic.Retain)]
			get {
				return _GetExtendedAttributes (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSDictionary<NSString, NSData> _GetExtendedAttributes (INSFileProviderItem This)
		{
			NSDictionary<NSString, NSData> ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSData>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("extendedAttributes")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.OptionalMember]
		public virtual NSFileProviderItemVersion? ItemVersion {
			[Export ("itemVersion", ArgumentSemantic.Retain)]
			get {
				return _GetItemVersion (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSFileProviderItemVersion _GetItemVersion (INSFileProviderItem This)
		{
			NSFileProviderItemVersion ret;
			ret =  Runtime.GetNSObject<NSFileProviderItemVersion> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("itemVersion")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.OptionalMember]
		public virtual string? SymlinkTargetPath {
			[Export ("symlinkTargetPath")]
			get {
				return _GetSymlinkTargetPath (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetSymlinkTargetPath (INSFileProviderItem This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("symlinkTargetPath")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios16.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.OptionalMember]
		public virtual NSFileProviderTypeAndCreator TypeAndCreator {
			[Export ("typeAndCreator")]
			get {
				return _GetTypeAndCreator (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSFileProviderTypeAndCreator _GetTypeAndCreator (INSFileProviderItem This)
		{
			NSFileProviderTypeAndCreator ret;
			ret = global::ObjCRuntime.Messaging.NSFileProviderTypeAndCreator_objc_msgSend (This.Handle, Selector.GetHandle ("typeAndCreator"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[global::Foundation.OptionalMember]
		public virtual NSFileProviderContentPolicy ContentPolicy {
			[Export ("contentPolicy")]
			get {
				return _GetContentPolicy (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSFileProviderContentPolicy _GetContentPolicy (INSFileProviderItem This)
		{
			NSFileProviderContentPolicy ret;
			ret = (NSFileProviderContentPolicy) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("contentPolicy"));
			GC.KeepAlive (This);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSFileProviderItem" /> interface to support all the methods from the NSFileProviderItem protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSFileProviderItem" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSFileProviderItem protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSFileProviderItem_Extensions {
		[SupportedOSPlatform ("ios14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UniformTypeIdentifiers.UTType GetContentType (this INSFileProviderItem This)
		{
			global::UniformTypeIdentifiers.UTType ret;
			ret =  Runtime.GetNSObject<global::UniformTypeIdentifiers.UTType> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("contentType")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFileProviderItemCapabilities GetCapabilities (this INSFileProviderItem This)
		{
			NSFileProviderItemCapabilities ret;
			ret = (NSFileProviderItemCapabilities) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("capabilities"));
			GC.KeepAlive (This);
			return ret!;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber? GetDocumentSize (this INSFileProviderItem This)
		{
			NSNumber ret;
			ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("documentSize")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber? GetChildItemCount (this INSFileProviderItem This)
		{
			NSNumber ret;
			ret =  Runtime.GetNSObject<NSNumber> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("childItemCount")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDate? GetCreationDate (this INSFileProviderItem This)
		{
			NSDate ret;
			ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("creationDate")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDate? GetContentModificationDate (this INSFileProviderItem This)
		{
			NSDate ret;
			ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("contentModificationDate")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDate? GetLastUsedDate (this INSFileProviderItem This)
		{
			NSDate ret;
			ret =  Runtime.GetNSObject<NSDate> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("lastUsedDate")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSData? GetTagData (this INSFileProviderItem This)
		{
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("tagData")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsUploaded (this INSFileProviderItem This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isUploaded"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsUploading (this INSFileProviderItem This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isUploading"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSError? GetUploadingError (this INSFileProviderItem This)
		{
			NSError ret;
			ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("uploadingError")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsDownloaded (this INSFileProviderItem This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isDownloaded"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsDownloading (this INSFileProviderItem This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isDownloading"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSError? GetDownloadingError (this INSFileProviderItem This)
		{
			NSError ret;
			ret =  Runtime.GetNSObject<NSError> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("downloadingError")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsMostRecentVersionDownloaded (this INSFileProviderItem This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isMostRecentVersionDownloaded"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsShared (this INSFileProviderItem This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isShared"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsSharedByCurrentUser (this INSFileProviderItem This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSharedByCurrentUser"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPersonNameComponents? GetOwnerNameComponents (this INSFileProviderItem This)
		{
			NSPersonNameComponents ret;
			ret =  Runtime.GetNSObject<NSPersonNameComponents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("ownerNameComponents")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSPersonNameComponents? GetMostRecentEditorNameComponents (this INSFileProviderItem This)
		{
			NSPersonNameComponents ret;
			ret =  Runtime.GetNSObject<NSPersonNameComponents> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("mostRecentEditorNameComponents")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary? GetUserInfo (this INSFileProviderItem This)
		{
			NSDictionary ret;
			ret =  Runtime.GetNSObject<NSDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("userInfo")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetTypeIdentifier (this INSFileProviderItem This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("typeIdentifier")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFileProviderFileSystemFlags GetFileSystemFlags (this INSFileProviderItem This)
		{
			NSFileProviderFileSystemFlags ret;
			ret = (NSFileProviderFileSystemFlags) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("fileSystemFlags"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary<NSString, NSData> GetExtendedAttributes (this INSFileProviderItem This)
		{
			NSDictionary<NSString, NSData> ret;
			ret =  Runtime.GetNSObject<NSDictionary<NSString, NSData>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("extendedAttributes")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFileProviderItemVersion GetItemVersion (this INSFileProviderItem This)
		{
			NSFileProviderItemVersion ret;
			ret =  Runtime.GetNSObject<NSFileProviderItemVersion> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("itemVersion")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetSymlinkTargetPath (this INSFileProviderItem This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("symlinkTargetPath")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFileProviderTypeAndCreator GetTypeAndCreator (this INSFileProviderItem This)
		{
			NSFileProviderTypeAndCreator ret;
			ret = global::ObjCRuntime.Messaging.NSFileProviderTypeAndCreator_objc_msgSend (This.Handle, Selector.GetHandle ("typeAndCreator"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSFileProviderContentPolicy GetContentPolicy (this INSFileProviderItem This)
		{
			NSFileProviderContentPolicy ret;
			ret = (NSFileProviderContentPolicy) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("contentPolicy"));
			GC.KeepAlive (This);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSFileProviderItemWrapper : BaseWrapper, INSFileProviderItem {
		public NSFileProviderItemWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSFileProviderItemWrapper))]
		static NSFileProviderItemWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string Identifier {
			[Export ("itemIdentifier")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("itemIdentifier")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string ParentIdentifier {
			[Export ("parentItemIdentifier")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("parentItemIdentifier")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string Filename {
			[Export ("filename")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("filename")), false)!;
				return ret;
			}
		}
	}
}
