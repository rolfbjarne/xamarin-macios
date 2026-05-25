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
namespace CoreData {
	/// <summary>Enumerates error codes that can be encountered while migrating stores.</summary>
	[Native]
	public enum MigrationErrorType : int {
		/// <summary>An unspecified error occurred.</summary>
		Migration = 134110,
		/// <summary>The migration was canceled.</summary>
		MigrationCancelled = 134120,
		/// <summary>The source data model was missing.</summary>
		MigrationMissingSourceModel = 134130,
		/// <summary>The mapping model was missing.</summary>
		MigrationMissingMappingModel = 134140,
		/// <summary>There was a problem with the source store.</summary>
		MigrationManagerSourceStore = 134150,
		/// <summary>There was a problem with the destination store.</summary>
		MigrationManagerDestinationStore = 134160,
		/// <summary>An error occurred while processing an entity migration policy.</summary>
		EntityMigrationPolicy = 134170,
		/// <summary>An error occurred while creating an inferred mapping model.</summary>
		InferredMappingModel = 134190,
		/// <summary>An error occurred while importing an external record.</summary>
		ExternalRecordImport = 134200,
		/// <summary>To be added.</summary>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		HistoryTokenExpired = 134301,
	}
}
