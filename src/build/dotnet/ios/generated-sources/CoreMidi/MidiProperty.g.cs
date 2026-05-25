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
namespace CoreMidi {
	internal enum MidiProperty : int {
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		Name = 0,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		Manufacturer = 1,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		Model = 2,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		UniqueId = 3,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		DeviceId = 4,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		ReceiveChannels = 5,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		TransmitChannels = 6,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		MaxSysExSpeed = 7,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		AdvanceScheduleTimeMuSec = 8,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		IsEmbeddedEntity = 9,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		IsBroadcast = 10,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		SingleRealtimeEntity = 11,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		ConnectionUniqueId = 12,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		Offline = 13,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		Private = 14,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		DriverOwner = 15,
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		FactoryPatchNameFile = 16,
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		UserPatchNameFile = 17,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		NameConfiguration = 18,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		NameConfigurationDictionary = 19,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		Image = 20,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		DriverVersion = 21,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		SupportsGeneralMidi = 22,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		SupportsMmc = 23,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		CanRoute = 24,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		ReceivesClock = 25,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		ReceivesMtc = 26,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		ReceivesNotes = 27,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		ReceivesProgramChanges = 28,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		ReceivesBankSelectMsb = 29,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		ReceivesBankSelectLsb = 30,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		TransmitsClock = 31,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		TransmitsMtc = 32,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		TransmitsNotes = 33,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		TransmitsProgramChanges = 34,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		TransmitsBankSelectMsb = 35,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		TransmitsBankSelectLsb = 36,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		PanDisruptsStereo = 37,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		IsSampler = 38,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		IsDrumMachine = 39,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		IsMixer = 40,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		IsEffectUnit = 41,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		MaxReceiveChannels = 42,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		MaxTransmitChannels = 43,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		DriverDeviceEditorApp = 44,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		SupportsShowControl = 45,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		DisplayName = 46,
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		ProtocolId = 47,
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		UmpActiveGroupBitmap = 48,
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		UmpCanTransmitGroupless = 49,
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		AssociatedEndpoint = 50,
	}
	/// <summary>Extension methods for the <see cref="global::CoreMidi.MidiProperty" /> enumeration.</summary>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static internal partial class MidiPropertyExtensions {
		static IntPtr[] values = new IntPtr [49];
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyName", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyName {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyName", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyManufacturer", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyManufacturer {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyManufacturer", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyModel", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyModel {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyModel", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyUniqueID", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyUniqueID {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyUniqueID", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyDeviceID", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyDeviceID {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyDeviceID", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyReceiveChannels", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyReceiveChannels {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyReceiveChannels", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyTransmitChannels", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyTransmitChannels {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyTransmitChannels", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyMaxSysExSpeed", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyMaxSysExSpeed {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyMaxSysExSpeed", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyAdvanceScheduleTimeMuSec", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyAdvanceScheduleTimeMuSec {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyAdvanceScheduleTimeMuSec", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyIsEmbeddedEntity", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyIsEmbeddedEntity {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyIsEmbeddedEntity", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyIsBroadcast", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyIsBroadcast {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyIsBroadcast", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertySingleRealtimeEntity", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertySingleRealtimeEntity {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertySingleRealtimeEntity", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyConnectionUniqueID", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyConnectionUniqueID {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyConnectionUniqueID", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyOffline", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyOffline {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyOffline", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyPrivate", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyPrivate {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyPrivate", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyDriverOwner", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyDriverOwner {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyDriverOwner", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyNameConfiguration", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyNameConfiguration {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyNameConfiguration", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyNameConfigurationDictionary", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyNameConfigurationDictionary {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyNameConfigurationDictionary", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyImage", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyImage {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyImage", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyDriverVersion", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyDriverVersion {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyDriverVersion", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertySupportsGeneralMIDI", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertySupportsGeneralMIDI {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertySupportsGeneralMIDI", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertySupportsMMC", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertySupportsMMC {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertySupportsMMC", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyCanRoute", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyCanRoute {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyCanRoute", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyReceivesClock", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyReceivesClock {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyReceivesClock", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyReceivesMTC", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyReceivesMTC {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyReceivesMTC", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyReceivesNotes", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyReceivesNotes {
			get {
				fixed (IntPtr *storage = &values [25])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyReceivesNotes", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyReceivesProgramChanges", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyReceivesProgramChanges {
			get {
				fixed (IntPtr *storage = &values [26])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyReceivesProgramChanges", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyReceivesBankSelectMSB", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyReceivesBankSelectMSB {
			get {
				fixed (IntPtr *storage = &values [27])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyReceivesBankSelectMSB", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyReceivesBankSelectLSB", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyReceivesBankSelectLSB {
			get {
				fixed (IntPtr *storage = &values [28])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyReceivesBankSelectLSB", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyTransmitsClock", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyTransmitsClock {
			get {
				fixed (IntPtr *storage = &values [29])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyTransmitsClock", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyTransmitsMTC", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyTransmitsMTC {
			get {
				fixed (IntPtr *storage = &values [30])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyTransmitsMTC", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyTransmitsNotes", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyTransmitsNotes {
			get {
				fixed (IntPtr *storage = &values [31])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyTransmitsNotes", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyTransmitsProgramChanges", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyTransmitsProgramChanges {
			get {
				fixed (IntPtr *storage = &values [32])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyTransmitsProgramChanges", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyTransmitsBankSelectMSB", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyTransmitsBankSelectMSB {
			get {
				fixed (IntPtr *storage = &values [33])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyTransmitsBankSelectMSB", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyTransmitsBankSelectLSB", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyTransmitsBankSelectLSB {
			get {
				fixed (IntPtr *storage = &values [34])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyTransmitsBankSelectLSB", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyPanDisruptsStereo", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyPanDisruptsStereo {
			get {
				fixed (IntPtr *storage = &values [35])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyPanDisruptsStereo", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyIsSampler", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyIsSampler {
			get {
				fixed (IntPtr *storage = &values [36])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyIsSampler", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyIsDrumMachine", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyIsDrumMachine {
			get {
				fixed (IntPtr *storage = &values [37])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyIsDrumMachine", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyIsMixer", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyIsMixer {
			get {
				fixed (IntPtr *storage = &values [38])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyIsMixer", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyIsEffectUnit", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyIsEffectUnit {
			get {
				fixed (IntPtr *storage = &values [39])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyIsEffectUnit", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyMaxReceiveChannels", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyMaxReceiveChannels {
			get {
				fixed (IntPtr *storage = &values [40])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyMaxReceiveChannels", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyMaxTransmitChannels", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyMaxTransmitChannels {
			get {
				fixed (IntPtr *storage = &values [41])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyMaxTransmitChannels", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyDriverDeviceEditorApp", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyDriverDeviceEditorApp {
			get {
				fixed (IntPtr *storage = &values [42])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyDriverDeviceEditorApp", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertySupportsShowControl", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertySupportsShowControl {
			get {
				fixed (IntPtr *storage = &values [43])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertySupportsShowControl", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyDisplayName", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyDisplayName {
			get {
				fixed (IntPtr *storage = &values [44])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyDisplayName", storage);
			}
		}
		[UnsupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[Field ("kMIDIPropertyProtocolID", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyProtocolID {
			get {
				fixed (IntPtr *storage = &values [45])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyProtocolID", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[Field ("kMIDIPropertyUMPActiveGroupBitmap", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyUMPActiveGroupBitmap {
			get {
				fixed (IntPtr *storage = &values [46])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyUMPActiveGroupBitmap", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[UnsupportedOSPlatform ("tvos")]
		[Field ("kMIDIPropertyUMPCanTransmitGroupless", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyUMPCanTransmitGroupless {
			get {
				fixed (IntPtr *storage = &values [47])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyUMPCanTransmitGroupless", storage);
			}
		}
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[UnsupportedOSPlatform ("tvos")]
		[Field ("kMIDIPropertyAssociatedEndpoint", "CoreMidi")]
		internal unsafe static IntPtr kMIDIPropertyAssociatedEndpoint {
			get {
				fixed (IntPtr *storage = &values [48])
					return Dlfcn.CachePointer (Libraries.CoreMidi.Handle, "kMIDIPropertyAssociatedEndpoint", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this MidiProperty self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // MidiProperty.Name
				ptr = kMIDIPropertyName;
				break;
			case 1: // MidiProperty.Manufacturer
				ptr = kMIDIPropertyManufacturer;
				break;
			case 2: // MidiProperty.Model
				ptr = kMIDIPropertyModel;
				break;
			case 3: // MidiProperty.UniqueId
				ptr = kMIDIPropertyUniqueID;
				break;
			case 4: // MidiProperty.DeviceId
				ptr = kMIDIPropertyDeviceID;
				break;
			case 5: // MidiProperty.ReceiveChannels
				ptr = kMIDIPropertyReceiveChannels;
				break;
			case 6: // MidiProperty.TransmitChannels
				ptr = kMIDIPropertyTransmitChannels;
				break;
			case 7: // MidiProperty.MaxSysExSpeed
				ptr = kMIDIPropertyMaxSysExSpeed;
				break;
			case 8: // MidiProperty.AdvanceScheduleTimeMuSec
				ptr = kMIDIPropertyAdvanceScheduleTimeMuSec;
				break;
			case 9: // MidiProperty.IsEmbeddedEntity
				ptr = kMIDIPropertyIsEmbeddedEntity;
				break;
			case 10: // MidiProperty.IsBroadcast
				ptr = kMIDIPropertyIsBroadcast;
				break;
			case 11: // MidiProperty.SingleRealtimeEntity
				ptr = kMIDIPropertySingleRealtimeEntity;
				break;
			case 12: // MidiProperty.ConnectionUniqueId
				ptr = kMIDIPropertyConnectionUniqueID;
				break;
			case 13: // MidiProperty.Offline
				ptr = kMIDIPropertyOffline;
				break;
			case 14: // MidiProperty.Private
				ptr = kMIDIPropertyPrivate;
				break;
			case 15: // MidiProperty.DriverOwner
				ptr = kMIDIPropertyDriverOwner;
				break;
			case 18: // MidiProperty.NameConfiguration
				ptr = kMIDIPropertyNameConfiguration;
				break;
			case 19: // MidiProperty.NameConfigurationDictionary
				ptr = kMIDIPropertyNameConfigurationDictionary;
				break;
			case 20: // MidiProperty.Image
				ptr = kMIDIPropertyImage;
				break;
			case 21: // MidiProperty.DriverVersion
				ptr = kMIDIPropertyDriverVersion;
				break;
			case 22: // MidiProperty.SupportsGeneralMidi
				ptr = kMIDIPropertySupportsGeneralMIDI;
				break;
			case 23: // MidiProperty.SupportsMmc
				ptr = kMIDIPropertySupportsMMC;
				break;
			case 24: // MidiProperty.CanRoute
				ptr = kMIDIPropertyCanRoute;
				break;
			case 25: // MidiProperty.ReceivesClock
				ptr = kMIDIPropertyReceivesClock;
				break;
			case 26: // MidiProperty.ReceivesMtc
				ptr = kMIDIPropertyReceivesMTC;
				break;
			case 27: // MidiProperty.ReceivesNotes
				ptr = kMIDIPropertyReceivesNotes;
				break;
			case 28: // MidiProperty.ReceivesProgramChanges
				ptr = kMIDIPropertyReceivesProgramChanges;
				break;
			case 29: // MidiProperty.ReceivesBankSelectMsb
				ptr = kMIDIPropertyReceivesBankSelectMSB;
				break;
			case 30: // MidiProperty.ReceivesBankSelectLsb
				ptr = kMIDIPropertyReceivesBankSelectLSB;
				break;
			case 31: // MidiProperty.TransmitsClock
				ptr = kMIDIPropertyTransmitsClock;
				break;
			case 32: // MidiProperty.TransmitsMtc
				ptr = kMIDIPropertyTransmitsMTC;
				break;
			case 33: // MidiProperty.TransmitsNotes
				ptr = kMIDIPropertyTransmitsNotes;
				break;
			case 34: // MidiProperty.TransmitsProgramChanges
				ptr = kMIDIPropertyTransmitsProgramChanges;
				break;
			case 35: // MidiProperty.TransmitsBankSelectMsb
				ptr = kMIDIPropertyTransmitsBankSelectMSB;
				break;
			case 36: // MidiProperty.TransmitsBankSelectLsb
				ptr = kMIDIPropertyTransmitsBankSelectLSB;
				break;
			case 37: // MidiProperty.PanDisruptsStereo
				ptr = kMIDIPropertyPanDisruptsStereo;
				break;
			case 38: // MidiProperty.IsSampler
				ptr = kMIDIPropertyIsSampler;
				break;
			case 39: // MidiProperty.IsDrumMachine
				ptr = kMIDIPropertyIsDrumMachine;
				break;
			case 40: // MidiProperty.IsMixer
				ptr = kMIDIPropertyIsMixer;
				break;
			case 41: // MidiProperty.IsEffectUnit
				ptr = kMIDIPropertyIsEffectUnit;
				break;
			case 42: // MidiProperty.MaxReceiveChannels
				ptr = kMIDIPropertyMaxReceiveChannels;
				break;
			case 43: // MidiProperty.MaxTransmitChannels
				ptr = kMIDIPropertyMaxTransmitChannels;
				break;
			case 44: // MidiProperty.DriverDeviceEditorApp
				ptr = kMIDIPropertyDriverDeviceEditorApp;
				break;
			case 45: // MidiProperty.SupportsShowControl
				ptr = kMIDIPropertySupportsShowControl;
				break;
			case 46: // MidiProperty.DisplayName
				ptr = kMIDIPropertyDisplayName;
				break;
			case 47: // MidiProperty.ProtocolId
				ptr = kMIDIPropertyProtocolID;
				break;
			case 48: // MidiProperty.UmpActiveGroupBitmap
				ptr = kMIDIPropertyUMPActiveGroupBitmap;
				break;
			case 49: // MidiProperty.UmpCanTransmitGroupless
				ptr = kMIDIPropertyUMPCanTransmitGroupless;
				break;
			case 50: // MidiProperty.AssociatedEndpoint
				ptr = kMIDIPropertyAssociatedEndpoint;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::CoreMidi.MidiProperty" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static MidiProperty GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (kMIDIPropertyName))
				return MidiProperty.Name;
			if (constant.IsEqualTo (kMIDIPropertyManufacturer))
				return MidiProperty.Manufacturer;
			if (constant.IsEqualTo (kMIDIPropertyModel))
				return MidiProperty.Model;
			if (constant.IsEqualTo (kMIDIPropertyUniqueID))
				return MidiProperty.UniqueId;
			if (constant.IsEqualTo (kMIDIPropertyDeviceID))
				return MidiProperty.DeviceId;
			if (constant.IsEqualTo (kMIDIPropertyReceiveChannels))
				return MidiProperty.ReceiveChannels;
			if (constant.IsEqualTo (kMIDIPropertyTransmitChannels))
				return MidiProperty.TransmitChannels;
			if (constant.IsEqualTo (kMIDIPropertyMaxSysExSpeed))
				return MidiProperty.MaxSysExSpeed;
			if (constant.IsEqualTo (kMIDIPropertyAdvanceScheduleTimeMuSec))
				return MidiProperty.AdvanceScheduleTimeMuSec;
			if (constant.IsEqualTo (kMIDIPropertyIsEmbeddedEntity))
				return MidiProperty.IsEmbeddedEntity;
			if (constant.IsEqualTo (kMIDIPropertyIsBroadcast))
				return MidiProperty.IsBroadcast;
			if (constant.IsEqualTo (kMIDIPropertySingleRealtimeEntity))
				return MidiProperty.SingleRealtimeEntity;
			if (constant.IsEqualTo (kMIDIPropertyConnectionUniqueID))
				return MidiProperty.ConnectionUniqueId;
			if (constant.IsEqualTo (kMIDIPropertyOffline))
				return MidiProperty.Offline;
			if (constant.IsEqualTo (kMIDIPropertyPrivate))
				return MidiProperty.Private;
			if (constant.IsEqualTo (kMIDIPropertyDriverOwner))
				return MidiProperty.DriverOwner;
			if (constant.IsEqualTo (kMIDIPropertyNameConfiguration))
				return MidiProperty.NameConfiguration;
			if (constant.IsEqualTo (kMIDIPropertyNameConfigurationDictionary))
				return MidiProperty.NameConfigurationDictionary;
			if (constant.IsEqualTo (kMIDIPropertyImage))
				return MidiProperty.Image;
			if (constant.IsEqualTo (kMIDIPropertyDriverVersion))
				return MidiProperty.DriverVersion;
			if (constant.IsEqualTo (kMIDIPropertySupportsGeneralMIDI))
				return MidiProperty.SupportsGeneralMidi;
			if (constant.IsEqualTo (kMIDIPropertySupportsMMC))
				return MidiProperty.SupportsMmc;
			if (constant.IsEqualTo (kMIDIPropertyCanRoute))
				return MidiProperty.CanRoute;
			if (constant.IsEqualTo (kMIDIPropertyReceivesClock))
				return MidiProperty.ReceivesClock;
			if (constant.IsEqualTo (kMIDIPropertyReceivesMTC))
				return MidiProperty.ReceivesMtc;
			if (constant.IsEqualTo (kMIDIPropertyReceivesNotes))
				return MidiProperty.ReceivesNotes;
			if (constant.IsEqualTo (kMIDIPropertyReceivesProgramChanges))
				return MidiProperty.ReceivesProgramChanges;
			if (constant.IsEqualTo (kMIDIPropertyReceivesBankSelectMSB))
				return MidiProperty.ReceivesBankSelectMsb;
			if (constant.IsEqualTo (kMIDIPropertyReceivesBankSelectLSB))
				return MidiProperty.ReceivesBankSelectLsb;
			if (constant.IsEqualTo (kMIDIPropertyTransmitsClock))
				return MidiProperty.TransmitsClock;
			if (constant.IsEqualTo (kMIDIPropertyTransmitsMTC))
				return MidiProperty.TransmitsMtc;
			if (constant.IsEqualTo (kMIDIPropertyTransmitsNotes))
				return MidiProperty.TransmitsNotes;
			if (constant.IsEqualTo (kMIDIPropertyTransmitsProgramChanges))
				return MidiProperty.TransmitsProgramChanges;
			if (constant.IsEqualTo (kMIDIPropertyTransmitsBankSelectMSB))
				return MidiProperty.TransmitsBankSelectMsb;
			if (constant.IsEqualTo (kMIDIPropertyTransmitsBankSelectLSB))
				return MidiProperty.TransmitsBankSelectLsb;
			if (constant.IsEqualTo (kMIDIPropertyPanDisruptsStereo))
				return MidiProperty.PanDisruptsStereo;
			if (constant.IsEqualTo (kMIDIPropertyIsSampler))
				return MidiProperty.IsSampler;
			if (constant.IsEqualTo (kMIDIPropertyIsDrumMachine))
				return MidiProperty.IsDrumMachine;
			if (constant.IsEqualTo (kMIDIPropertyIsMixer))
				return MidiProperty.IsMixer;
			if (constant.IsEqualTo (kMIDIPropertyIsEffectUnit))
				return MidiProperty.IsEffectUnit;
			if (constant.IsEqualTo (kMIDIPropertyMaxReceiveChannels))
				return MidiProperty.MaxReceiveChannels;
			if (constant.IsEqualTo (kMIDIPropertyMaxTransmitChannels))
				return MidiProperty.MaxTransmitChannels;
			if (constant.IsEqualTo (kMIDIPropertyDriverDeviceEditorApp))
				return MidiProperty.DriverDeviceEditorApp;
			if (constant.IsEqualTo (kMIDIPropertySupportsShowControl))
				return MidiProperty.SupportsShowControl;
			if (constant.IsEqualTo (kMIDIPropertyDisplayName))
				return MidiProperty.DisplayName;
			if (constant.IsEqualTo (kMIDIPropertyProtocolID))
				return MidiProperty.ProtocolId;
			if (constant.IsEqualTo (kMIDIPropertyUMPActiveGroupBitmap))
				return MidiProperty.UmpActiveGroupBitmap;
			if (constant.IsEqualTo (kMIDIPropertyUMPCanTransmitGroupless))
				return MidiProperty.UmpCanTransmitGroupless;
			if (constant.IsEqualTo (kMIDIPropertyAssociatedEndpoint))
				return MidiProperty.AssociatedEndpoint;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::CoreMidi.MidiProperty" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static MidiProperty GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::CoreMidi.MidiProperty" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static MidiProperty? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::CoreMidi.MidiProperty" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this MidiProperty[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSString?> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (value.GetConstant ());
			}
			return rv.ToArray ();
		}
		/// <summary>Converts an array of <see cref="NSString" /> values into an array of their corresponding enum values.</summary>
		/// <param name="values">The array if <see cref="NSString" /> values to convert.</param>
		internal static MidiProperty[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<MidiProperty> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
