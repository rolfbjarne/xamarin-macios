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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace CoreData {
	/// <summary>Enumerates error codes that can be encountered while working with persistent stores.</summary>
	[Native]
	public enum PersistentStoreErrorType : ulong {
		/// <summary>Indicates that an invalid type was encountered.</summary>
		InvalidType = 134000,
		/// <summary>Indicates that a store was encountered that did not match the specified type.</summary>
		TypeMismatch = 134010,
		/// <summary>Indicates that an incompatible schema was encountered, for example, one that specifies a table that is not present.</summary>
		IncompatibleSchema = 134020,
		/// <summary>Indicates that an error, such as a permissions error, was encountered while saving a persistent store.</summary>
		Save = 134030,
		/// <summary>Indicates that an error occurred while saving one or more stores in a container.</summary>
		IncompleteSave = 134040,
		/// <summary>Indicates that an unresolved merge conflict was encountered while saving.</summary>
		SaveConflicts = 134050,
		/// <summary>Indicates that an error occurred while performing an operation on persistent store.</summary>
		Operation = 134070,
		/// <summary>Indicates that an error occurred while trying to open a persistent store.</summary>
		Open = 134080,
		/// <summary>Indicates that connecting to a persistent store took too long.</summary>
		Timeout = 134090,
		/// <summary>Indicates that the entity version hashes in the persistent store are not compatible with the managed object model.</summary>
		IncompatibleVersionHash = 134100,
	}
}
