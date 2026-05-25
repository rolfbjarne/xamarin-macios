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
namespace CoreData {
	/// <summary>Enumerates error codes that can be encountered while working with object graphs.</summary>
	[Native]
	public enum ObjectGraphManagementErrorType : ulong {
		/// <summary>Indicates that a lock could not be obtained on a managed object context.</summary>
		ManagedObjectContextLocking = 132000,
		/// <summary>Indicates that a lock could not be obtained on a persistent store.</summary>
		PersistentStoreCoordinatorLocking = 132010,
		/// <summary>Indicates that an attempt was made to fire a fault at an object that does not exist.</summary>
		ManagedObjectReferentialIntegrity = 133000,
		/// <summary>Indicates that an object being saved contains a relationship to an object in another store.</summary>
		ManagedObjectExternalRelationship = 133010,
		/// <summary>Indicates that a merge failed due to a merge policy.</summary>
		ManagedObjectMerge = 133020,
	}
}
