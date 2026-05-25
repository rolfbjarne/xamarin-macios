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
namespace Security {
	internal unsafe static partial class SecAttributeKey  {
		/// <summary>Represents the value associated with the constant 'kSecAttrAccessGroup'.</summary>
		[Field ("kSecAttrAccessGroup",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static nint AccessGroup {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrAccessGroup");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrAccessGroupToken'.</summary>
		[Field ("kSecAttrAccessGroupToken",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static nint AccessGroupToken {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrAccessGroupToken");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrAccessible'.</summary>
		[Field ("kSecAttrAccessible",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static nint Accessible {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrAccessible");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrAccount'.</summary>
		[Field ("kSecAttrAccount",  "Security")]
		public static nint Account {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrAccount");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrApplicationLabel'.</summary>
		[Field ("kSecAttrApplicationLabel",  "Security")]
		public static nint ApplicationLabel {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrApplicationLabel");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrAuthenticationType'.</summary>
		[Field ("kSecAttrAuthenticationType",  "Security")]
		public static nint AuthenticationType {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrAuthenticationType");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrCertificateEncoding'.</summary>
		[Field ("kSecAttrCertificateEncoding",  "Security")]
		public static nint CertificateEncoding {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrCertificateEncoding");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrCertificateType'.</summary>
		[Field ("kSecAttrCertificateType",  "Security")]
		public static nint CertificateType {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrCertificateType");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrComment'.</summary>
		[Field ("kSecAttrComment",  "Security")]
		public static nint Comment {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrComment");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrCreationDate'.</summary>
		[Field ("kSecAttrCreationDate",  "Security")]
		public static nint CreationDate {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrCreationDate");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrCreator'.</summary>
		[Field ("kSecAttrCreator",  "Security")]
		public static nint Creator {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrCreator");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrDescription'.</summary>
		[Field ("kSecAttrDescription",  "Security")]
		public static nint Description {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrDescription");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrGeneric'.</summary>
		[Field ("kSecAttrGeneric",  "Security")]
		public static nint Generic {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrGeneric");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrIsExtractable'.</summary>
		[Field ("kSecAttrIsExtractable",  "Security")]
		public static nint IsExtractable {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrIsExtractable");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrIsInvisible'.</summary>
		[Field ("kSecAttrIsInvisible",  "Security")]
		public static nint IsInvisible {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrIsInvisible");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrIsNegative'.</summary>
		[Field ("kSecAttrIsNegative",  "Security")]
		public static nint IsNegative {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrIsNegative");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrIsSensitive'.</summary>
		[Field ("kSecAttrIsSensitive",  "Security")]
		public static nint IsSensitive {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrIsSensitive");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrIssuer'.</summary>
		[Field ("kSecAttrIssuer",  "Security")]
		public static nint Issuer {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrIssuer");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrKeyClass'.</summary>
		[Field ("kSecAttrKeyClass",  "Security")]
		public static nint KeyClass {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrKeyClass");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrModificationDate'.</summary>
		[Field ("kSecAttrModificationDate",  "Security")]
		public static nint ModificationDate {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrModificationDate");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrPath'.</summary>
		[Field ("kSecAttrPath",  "Security")]
		public static nint Path {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrPath");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrPersistentReference'.</summary>
		[Field ("kSecAttrPersistentReference",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static nint PersistentReference {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrPersistentReference");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrPort'.</summary>
		[Field ("kSecAttrPort",  "Security")]
		public static nint Port {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrPort");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrProtocol'.</summary>
		[Field ("kSecAttrProtocol",  "Security")]
		public static nint Protocol {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrProtocol");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrPublicKeyHash'.</summary>
		[Field ("kSecAttrPublicKeyHash",  "Security")]
		public static nint PublicKeyHash {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrPublicKeyHash");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrTokenIDSecureEnclave'.</summary>
		[Field ("kSecAttrTokenIDSecureEnclave",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static nint SecureEnclave {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrTokenIDSecureEnclave");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrSecurityDomain'.</summary>
		[Field ("kSecAttrSecurityDomain",  "Security")]
		public static nint SecurityDomain {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrSecurityDomain");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrSerialNumber'.</summary>
		[Field ("kSecAttrSerialNumber",  "Security")]
		public static nint SerialNumber {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrSerialNumber");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrServer'.</summary>
		[Field ("kSecAttrServer",  "Security")]
		public static nint Server {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrServer");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrService'.</summary>
		[Field ("kSecAttrService",  "Security")]
		public static nint Service {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrService");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrSubject'.</summary>
		[Field ("kSecAttrSubject",  "Security")]
		public static nint Subject {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrSubject");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrSubjectKeyID'.</summary>
		[Field ("kSecAttrSubjectKeyID",  "Security")]
		public static nint SubjectKeyID {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrSubjectKeyID");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrSyncViewHint'.</summary>
		[Field ("kSecAttrSyncViewHint",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static nint SyncViewHint {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrSyncViewHint");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrSynchronizable'.</summary>
		[Field ("kSecAttrSynchronizable",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static nint Synchronizable {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrSynchronizable");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrSynchronizableAny'.</summary>
		[Field ("kSecAttrSynchronizableAny",  "Security")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public static nint SynchronizableAny {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrSynchronizableAny");
			}
		}
		/// <summary>Represents the value associated with the constant 'kSecAttrType'.</summary>
		[Field ("kSecAttrType",  "Security")]
		public static nint Type {
			get {
				return Dlfcn.GetIntPtr (Libraries.Security.Handle, "kSecAttrType");
			}
		}
	} /* class SecAttributeKey */
}
