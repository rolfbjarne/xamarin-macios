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
namespace IOSurface {
	public partial class IOSurfaceOptions : DictionaryContainer {
#if !COREBUILD
		/// <summary>Creates a new <see cref="IOSurfaceOptions" /> with default (empty) values.</summary>
		public IOSurfaceOptions () : base (new NSMutableDictionary ()) {}
		/// <summary>Creates a new <see cref="IOSurfaceOptions" /> from the values that are specified in <paramref name="dictionary" />.</summary>
		/// <param name="dictionary">The dictionary to use to populate the properties of this type.</param>
		public IOSurfaceOptions (NSDictionary? dictionary) : base (dictionary) {}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public nint? AllocSize {
			get {
				return  GetNIntValue (IOSurfacePropertyKey.AllocSizeKey!);
			}
			set {
				SetNumberValue (IOSurfacePropertyKey.AllocSizeKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public nint? Width {
			get {
				return  GetNIntValue (IOSurfacePropertyKey.WidthKey!);
			}
			set {
				SetNumberValue (IOSurfacePropertyKey.WidthKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public nint? Height {
			get {
				return  GetNIntValue (IOSurfacePropertyKey.HeightKey!);
			}
			set {
				SetNumberValue (IOSurfacePropertyKey.HeightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public nint? BytesPerRow {
			get {
				return  GetNIntValue (IOSurfacePropertyKey.BytesPerRowKey!);
			}
			set {
				SetNumberValue (IOSurfacePropertyKey.BytesPerRowKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public nint? BytesPerElement {
			get {
				return  GetNIntValue (IOSurfacePropertyKey.BytesPerElementKey!);
			}
			set {
				SetNumberValue (IOSurfacePropertyKey.BytesPerElementKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public nint? ElementWidth {
			get {
				return  GetNIntValue (IOSurfacePropertyKey.ElementWidthKey!);
			}
			set {
				SetNumberValue (IOSurfacePropertyKey.ElementWidthKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public nint? ElementHeight {
			get {
				return  GetNIntValue (IOSurfacePropertyKey.ElementHeightKey!);
			}
			set {
				SetNumberValue (IOSurfacePropertyKey.ElementHeightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public nint? Offset {
			get {
				return  GetNIntValue (IOSurfacePropertyKey.OffsetKey!);
			}
			set {
				SetNumberValue (IOSurfacePropertyKey.OffsetKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public NSDictionary[]? PlaneInfo {
			get {
				return GetArray<NSDictionary> (IOSurfacePropertyKey.PlaneInfoKey!);
			}
			set {
				SetArrayValue (IOSurfacePropertyKey.PlaneInfoKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public nint? PlaneWidth {
			get {
				return  GetNIntValue (IOSurfacePropertyKey.PlaneWidthKey!);
			}
			set {
				SetNumberValue (IOSurfacePropertyKey.PlaneWidthKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public nint? PlaneHeight {
			get {
				return  GetNIntValue (IOSurfacePropertyKey.PlaneHeightKey!);
			}
			set {
				SetNumberValue (IOSurfacePropertyKey.PlaneHeightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public nint? PlaneBytesPerRow {
			get {
				return  GetNIntValue (IOSurfacePropertyKey.PlaneBytesPerRowKey!);
			}
			set {
				SetNumberValue (IOSurfacePropertyKey.PlaneBytesPerRowKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public nint? PlaneOffset {
			get {
				return  GetNIntValue (IOSurfacePropertyKey.PlaneOffsetKey!);
			}
			set {
				SetNumberValue (IOSurfacePropertyKey.PlaneOffsetKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public nint? PlaneSize {
			get {
				return  GetNIntValue (IOSurfacePropertyKey.PlaneSizeKey!);
			}
			set {
				SetNumberValue (IOSurfacePropertyKey.PlaneSizeKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public nint? PlaneBase {
			get {
				return  GetNIntValue (IOSurfacePropertyKey.PlaneBaseKey!);
			}
			set {
				SetNumberValue (IOSurfacePropertyKey.PlaneBaseKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public nint? PlaneBytesPerElement {
			get {
				return  GetNIntValue (IOSurfacePropertyKey.PlaneBytesPerElementKey!);
			}
			set {
				SetNumberValue (IOSurfacePropertyKey.PlaneBytesPerElementKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public nint? PlaneElementWidth {
			get {
				return  GetNIntValue (IOSurfacePropertyKey.PlaneElementWidthKey!);
			}
			set {
				SetNumberValue (IOSurfacePropertyKey.PlaneElementWidthKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public nint? PlaneElementHeight {
			get {
				return  GetNIntValue (IOSurfacePropertyKey.PlaneElementHeightKey!);
			}
			set {
				SetNumberValue (IOSurfacePropertyKey.PlaneElementHeightKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public IOSurfaceMemoryMap? CacheMode {
			get {
				return (IOSurfaceMemoryMap?) GetInt32Value (IOSurfacePropertyKey.CacheModeKey!);
			}
			set {
				SetNumberValue (IOSurfacePropertyKey.CacheModeKey!, (System.Int32?)value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public uint? PixelFormat {
			get {
				return  GetUInt32Value (IOSurfacePropertyKey.PixelFormatKey!);
			}
			set {
				SetNumberValue (IOSurfacePropertyKey.PixelFormatKey!, value);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		public bool? PixelSizeCastingAllowed {
			get {
				return  GetBoolValue (IOSurfacePropertyKey.PixelSizeCastingAllowedKey!);
			}
			set {
				SetBooleanValue (IOSurfacePropertyKey.PixelSizeCastingAllowedKey!, value);
			}
		}
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public string? Name {
			get {
				return GetStringValue (IOSurfacePropertyKey.NameKey!);
			}
			set {
				SetStringValue (IOSurfacePropertyKey.NameKey!, value);
			}
		}
#endif
	}
}
