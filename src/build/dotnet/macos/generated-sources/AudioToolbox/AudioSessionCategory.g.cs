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
namespace AudioToolbox {
	/// <summary>Categories for your audio session.</summary>
	public enum AudioSessionCategory : int {
		/// <summary>
		/// 	    Use this category if playing audio is not your
		/// 	    application's main use and if your application can be used
		/// 	    with the sound off.  This allows background music to be
		/// 	    mixed with the audio your application produces.
		/// 	  </summary>
		AmbientSound = 1634558569,
		/// <summary>
		/// 	    This is the default audio session category.
		/// 	  </summary>
		SoloAmbientSound = 1936682095,
		/// <summary>
		/// 	    Use this if the main use of your application is to play back music.
		/// 	  </summary>
		MediaPlayback = 1835361385,
		/// <summary>
		/// 	    Used to record audio.   This will prevent background audio and messages from playing back.
		/// 	  </summary>
		RecordAudio = 1919247201,
		/// <summary>
		/// 	    Used to perform both playback and recording at the same time, for example for live chat applications.   
		/// 	  </summary>
		PlayAndRecord = 1886151026,
		/// <summary>
		/// 	    Use this category when you want to use the hardware accelerated audio support to perform audio conversions.   
		/// 	  </summary>
		AudioProcessing = 1886547811,
	}
}
