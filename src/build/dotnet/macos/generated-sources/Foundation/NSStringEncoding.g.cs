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
namespace Foundation {
	/// <summary>Encodings supported by NSString.Encode.</summary><remarks>The encodings supported by NSData and NSString.</remarks>
	[Native]
	public enum NSStringEncoding : ulong {
		/// <summary>ASCII encoding contains, 7-bit of information stored in 8 bits.</summary>
		ASCIIStringEncoding = 1,
		/// <summary>To be added.</summary>
		NEXTSTEP = 2,
		/// <summary>To be added.</summary>
		JapaneseEUC = 3,
		/// <summary>8-bit based variable-length character encoding for Unicode. </summary>
		UTF8 = 4,
		/// <summary>8-bit ISO/IEC 8859-1, also knows as Latin1 encoding.</summary>
		ISOLatin1 = 5,
		/// <summary>To be added.</summary>
		Symbol = 6,
		/// <summary>To be added.</summary>
		NonLossyASCII = 7,
		/// <summary>To be added.</summary>
		ShiftJIS = 8,
		/// <summary>8-bit ISO/IEC 8859-2, also knows as Latin2 encoding.</summary>
		ISOLatin2 = 9,
		/// <summary>To be added.</summary>
		Unicode = 10,
		/// <summary>To be added.</summary>
		WindowsCP1251 = 11,
		/// <summary>To be added.</summary>
		WindowsCP1252 = 12,
		/// <summary>To be added.</summary>
		WindowsCP1253 = 13,
		/// <summary>To be added.</summary>
		WindowsCP1254 = 14,
		/// <summary>To be added.</summary>
		WindowsCP1250 = 15,
		/// <summary>To be added.</summary>
		ISO2022JP = 21,
		/// <summary>To be added.</summary>
		MacOSRoman = 30,
		/// <summary>16 bit-based variable length encoding, blocks are interpreted as big endian.</summary>
		UTF16BigEndian = 2415919360,
		/// <summary>16 bit-based variable length encoding, blocks are interpreted as litle endian. </summary>
		UTF16LittleEndian = 2483028224,
		/// <summary>32-bit unicode encoding.</summary>
		UTF32 = 2348810496,
		/// <summary>32 bit encoding, blocks are interpreted as big endian.</summary>
		UTF32BigEndian = 2550137088,
		/// <summary>32 bit encoding, blocks are interpreted as little endian.</summary>
		UTF32LittleEndian = 2617245952,
	}
}
