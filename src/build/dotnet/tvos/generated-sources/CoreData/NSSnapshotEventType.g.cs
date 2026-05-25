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
namespace CoreData {
	/// <summary>Enumerates reasons that a managed object may need to reinitialize certain values when it awakes.</summary><remarks><para>The values in this enumeration are returned by the <see cref="M:CoreData.NSManagedObject.AwakeFromSnapshotEvents(CoreData.NSSnapshotEventType)" /> method.</para></remarks>
	[Native]
	public enum NSSnapshotEventType : ulong {
		/// <summary>Indicates that an insertion was undone.</summary>
		UndoInsertion = 2,
		/// <summary>Indicates that a deletion was undone.</summary>
		UndoDeletion = 4,
		/// <summary>Indicates that an update was undone.</summary>
		UndoUpdate = 8,
		/// <summary>Indicates that a rollback occurred.</summary>
		Rollback = 16,
		/// <summary>Indicates that a managed object was refreshed.</summary>
		Refresh = 32,
		/// <summary>Indicates that a conflict was resolved while saving.</summary>
		MergePolicy = 64,
	}
}
