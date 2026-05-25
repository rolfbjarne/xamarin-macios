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
namespace Accounts {
	/// <summary>An enumeration whose values indicate the result of a credential renewal request (see <see cref="M:Accounts.ACAccountStore.RenewCredentials(Accounts.ACAccount,System.Action{Accounts.ACAccountCredentialRenewResult,Foundation.NSError})" />).</summary>
	[Native]
	public enum ACAccountCredentialRenewResult : long {
		/// <summary>The renewal succeeded.</summary>
		Renewed = 0,
		/// <summary>The user has disallowed access.</summary>
		Rejected = 1,
		/// <summary>There was an error in processing.</summary>
		Failed = 2,
	}
}
