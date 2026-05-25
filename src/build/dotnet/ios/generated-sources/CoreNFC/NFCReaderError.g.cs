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
namespace CoreNFC {
	/// <summary>Enumerates errors relating to NFC tag detection and reading.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum NFCReaderError : long {
		/// <summary>The session does not support the requested feature.</summary>
		UnsupportedFeature = 1,
		/// <summary>The session violated a security protocol.</summary>
		SecurityViolation = 2,
		InvalidParameter = 3,
		InvalidParameterLength = 4,
		ParameterOutOfBound = 5,
		RadioDisabled = 6,
		Ineligible = 7,
		AccessNotAccepted = 8,
		/// <summary>The connection to the tag was lost.</summary>
		ReaderTransceiveErrorTagConnectionLost = 100,
		/// <summary>The number of configured retries was exceeded.</summary>
		ReaderTransceiveErrorRetryExceeded = 101,
		/// <summary>The tag responded with an error message.</summary>
		ReaderTransceiveErrorTagResponseError = 102,
		ReaderTransceiveErrorSessionInvalidated = 103,
		ReaderTransceiveErrorTagNotConnected = 104,
		ReaderTransceiveErrorPacketTooLong = 105,
		/// <summary>The session was canceled by the user.</summary>
		ReaderSessionInvalidationErrorUserCanceled = 200,
		/// <summary>The session timed out.</summary>
		ReaderSessionInvalidationErrorSessionTimeout = 201,
		/// <summary>The session terminated unexpectedly.</summary>
		ReaderSessionInvalidationErrorSessionTerminatedUnexpectedly = 202,
		/// <summary>The session was invalidated because the system was busy (only one session can run at a time).</summary>
		ReaderSessionInvalidationErrorSystemIsBusy = 203,
		/// <summary>The initial NDEF tag was invalid.</summary>
		ReaderSessionInvalidationErrorFirstNDEFTagRead = 204,
		/// <summary>The command configuration for the tag included invalid values.</summary>
		TagCommandConfigurationErrorInvalidParameters = 300,
		NdefReaderSessionErrorTagNotWritable = 400,
		NdefReaderSessionErrorTagUpdateFailure = 401,
		NdefReaderSessionErrorTagSizeTooSmall = 402,
		NdefReaderSessionErrorZeroLengthMessage = 403,
	}
	/// <summary>Extension methods for the <see cref="global::CoreNFC.NFCReaderError" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::CoreNFC.NFCReaderError" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NFCReaderErrorExtensions {
		[Field ("NFCErrorDomain", "CoreNFC")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the CoreNFC.NFCReaderError value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this NFCReaderError self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.CoreNFC.Handle, "NFCErrorDomain");
			return _domain;
		}
	}
}
