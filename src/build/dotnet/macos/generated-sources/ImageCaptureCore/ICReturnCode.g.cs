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
namespace ImageCaptureCore {
	[Native]
	public enum ICReturnCode : long {
		Success = 0,
		InvalidParam = -9922,
		CommunicationTimedOut = -9923,
		ScanOperationCanceled = -9924,
		ScannerInUseByLocalUser = -9925,
		ScannerInUseByRemoteUser = -9926,
		DeviceFailedToOpenSession = -9927,
		DeviceFailedToCloseSession = -9928,
		ScannerFailedToSelectFunctionalUnit = -9929,
		ScannerFailedToCompleteOverviewScan = -9930,
		ScannerFailedToCompleteScan = -9931,
		ReceivedUnsolicitedScannerStatusInfo = -9932,
		ReceivedUnsolicitedScannerErrorInfo = -9933,
		DownloadFailed = -9934,
		UploadFailed = -9935,
		FailedToCompletePassThroughCommand = -9936,
		DownloadCanceled = -9937,
		FailedToEnableTethering = -9938,
		FailedToDisableTethering = -9939,
		FailedToCompleteSendMessageRequest = -9940,
		DeleteFilesFailed = -9941,
		DeleteFilesCanceled = -9942,
		DeviceIsPasscodeLocked = -9943,
		DeviceFailedToTakePicture = -9944,
		DeviceSoftwareNotInstalled = -9945,
		DeviceSoftwareIsBeingInstalled = -9946,
		DeviceSoftwareInstallationCompleted = -9947,
		DeviceSoftwareInstallationCanceled = -9948,
		DeviceSoftwareInstallationFailed = -9949,
		DeviceSoftwareNotAvailable = -9950,
		DeviceCouldNotPair = -9951,
		DeviceCouldNotUnpair = -9952,
		DeviceNeedsCredentials = -9953,
		DeviceIsBusyEnumerating = -9954,
		DeviceCommandGeneralFailure = -9955,
		DeviceFailedToCompleteTransfer = -9956,
		DeviceFailedToSendData = -9957,
		SessionNotOpened = -9958,
		ThumbnailNotAvailable = -21000,
		ThumbnailAlreadyFetching = -21001,
		ThumbnailCanceled = -21002,
		ThumbnailInvalid = -21003,
		ErrorDeviceEjected = -21300,
		MetadataNotAvailable = -21050,
		MetadataAlreadyFetching = -21051,
		MetadataCanceled = -21052,
		MetadataInvalid = -21053,
		MultiErrorDictionary = -30000,
	}
}
