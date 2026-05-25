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
namespace CoreWlan {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum CWStatus : long {
		/// <summary>To be added.</summary>
		Ok = 0,
		/// <summary>To be added.</summary>
		EAPOL = 1,
		/// <summary>To be added.</summary>
		InvalidParameter = -3900,
		/// <summary>To be added.</summary>
		NoMemory = -3901,
		/// <summary>To be added.</summary>
		Unknown = -3902,
		/// <summary>To be added.</summary>
		NotSupported = -3903,
		/// <summary>To be added.</summary>
		InvalidFormat = -3904,
		/// <summary>To be added.</summary>
		Timeout = -3905,
		/// <summary>To be added.</summary>
		UnspecifiedFailure = -3906,
		/// <summary>To be added.</summary>
		UnsupportedCapabilities = -3907,
		/// <summary>To be added.</summary>
		ReassociationDenied = -3908,
		/// <summary>To be added.</summary>
		AssociationDenied = -3909,
		/// <summary>To be added.</summary>
		AuthenticationAlgorithmUnsupported = -3910,
		/// <summary>To be added.</summary>
		InvalidAuthenticationSequenceNumber = -3911,
		/// <summary>To be added.</summary>
		ChallengeFailure = -3912,
		/// <summary>To be added.</summary>
		APFull = -3913,
		/// <summary>To be added.</summary>
		UnsupportedRateSet = -3914,
		/// <summary>To be added.</summary>
		ShortSlotUnsupported = -3915,
		/// <summary>To be added.</summary>
		DSSSOFDMUnsupported = -3916,
		/// <summary>To be added.</summary>
		InvalidInformationElement = -3917,
		/// <summary>To be added.</summary>
		InvalidGroupCipher = -3918,
		/// <summary>To be added.</summary>
		InvalidPairwiseCipher = -3919,
		/// <summary>To be added.</summary>
		InvalidAKMP = -3920,
		/// <summary>To be added.</summary>
		UnsupportedRSNVersion = -3921,
		/// <summary>To be added.</summary>
		InvalidRSNCapabilities = -3922,
		/// <summary>To be added.</summary>
		CipherSuiteRejected = -3923,
		/// <summary>To be added.</summary>
		InvalidPMK = -3924,
		/// <summary>To be added.</summary>
		SupplicantTimeout = -3925,
		/// <summary>To be added.</summary>
		HTFeaturesNotSupported = -3926,
		/// <summary>To be added.</summary>
		PCOTransitionTimeNotSupported = -3927,
		/// <summary>To be added.</summary>
		ReferenceNotBound = -3928,
		/// <summary>To be added.</summary>
		IPCFailure = -3929,
		/// <summary>To be added.</summary>
		OperationNotPermitted = -3930,
		/// <summary>To be added.</summary>
		Status = -3931,
	}
	/// <summary>Extension methods for the <see cref="global::CoreWlan.CWStatus" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::CoreWlan.CWStatus" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CWStatusExtensions {
		[Field ("CWErrorDomain", "CoreWlan")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the CoreWlan.CWStatus value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this CWStatus self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.CoreWlan.Handle, "CWErrorDomain");
			return _domain;
		}
	}
}
