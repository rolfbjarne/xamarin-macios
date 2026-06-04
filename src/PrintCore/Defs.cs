//
// Defs.cs: PrintCore definitions
//
// Authors:
//   Miguel de Icaza (miguel@gnome.org)
//
// Copyright 2016 Microsoft Inc
//

#nullable enable

using System.Threading;
using System.IO;

using PMObject = System.IntPtr;

namespace PrintCore {

	/// <summary>Specifies status code values.</summary>
	public enum PMStatusCode {
		/// <summary>Ok.</summary>
		Ok = 0,
		/// <summary>General Error.</summary>
		GeneralError = -30870,
		/// <summary>Out Of Scope.</summary>
		OutOfScope = -30871,
		/// <summary>Invalid Parameter.</summary>
		InvalidParameter = -50,
		/// <summary>No Default Printer.</summary>
		NoDefaultPrinter = -30872,
		/// <summary>Not Implemented.</summary>
		NotImplemented = -30873,
		/// <summary>No Such Entry.</summary>
		NoSuchEntry = -30874,
		/// <summary>Invalid Print Settings.</summary>
		InvalidPrintSettings = -30875,
		/// <summary>Invalid Page Format.</summary>
		InvalidPageFormat = -30876,
		/// <summary>Value Out Of Range.</summary>
		ValueOutOfRange = -30877,
		/// <summary>Lock Ignored.</summary>
		LockIgnored = -30878,

		/// <summary>Invalid Print Session.</summary>
		InvalidPrintSession = -30879,
		/// <summary>Invalid Printer.</summary>
		InvalidPrinter = -30880,
		/// <summary>Object In Use.</summary>
		ObjectInUse = -30881,
		/// <summary>Invalid Preset.</summary>
		InvalidPreset = -30899,

		/// <summary>Allocation Failure.</summary>
		AllocationFailure = -108,
		/// <summary>Internal Error.</summary>
		InternalError = -30870,

		/// <summary>Invalid Index.</summary>
		InvalidIndex = -30882,
		/// <summary>String Conversion Failure.</summary>
		StringConversionFailure = -30883,
		/// <summary>X M L Parse Error.</summary>
		XMLParseError = -30884,

		/// <summary>Invalid Job Template.</summary>
		InvalidJobTemplate = -30885,
		/// <summary>Invalid Printer Info.</summary>
		InvalidPrinterInfo = -30886,
		/// <summary>Invalid Connection.</summary>
		InvalidConnection = -30887,
		/// <summary>Invalid Key.</summary>
		InvalidKey = -30888,
		/// <summary>Invalid Value.</summary>
		InvalidValue = -30889,
		/// <summary>Invalid Allocator.</summary>
		InvalidAllocator = -30890,
		/// <summary>Invalid Ticket.</summary>
		InvalidTicket = -30891,
		/// <summary>Invalid Item.</summary>
		InvalidItem = -30892,
		/// <summary>Invalid Type.</summary>
		InvalidType = -30893,
		/// <summary>Invalid Reply.</summary>
		InvalidReply = -30894,
		/// <summary>Invalid File Type.</summary>
		InvalidFileType = -30895,
		/// <summary>Invalid Object.</summary>
		InvalidObject = -30896,
		/// <summary>Invalid Paper.</summary>
		InvalidPaper = -30897,
		/// <summary>Invalid Calibration Target.</summary>
		InvalidCalibrationTarget = -30898,

		/// <summary>No Default Item.</summary>
		NoDefaultItem = -9500,
		/// <summary>No Default Settings.</summary>
		NoDefaultSettings = -9501,
		/// <summary>Invalid Pde Context.</summary>
		InvalidPdeContext = -9530,
		/// <summary>Dont Switch Pde Error.</summary>
		DontSwitchPdeError = -9531,
		/// <summary>Unable To Find Process.</summary>
		UnableToFindProcess = -9532,
		/// <summary>Feature Not Installed.</summary>
		FeatureNotInstalled = -9533,

		/// <summary>Invalid Pbm Ref.</summary>
		InvalidPbmRef = -9540,
		/// <summary>No Selected Printers.</summary>
		NoSelectedPrinters = -9541,
		/// <summary>Invalid Lookup Spec.</summary>
		InvalidLookupSpec = -9542,
		/// <summary>Sync Request Failed.</summary>
		SyncRequestFailed = -9543,
		/// <summary>Edit Request Failed.</summary>
		EditRequestFailed = -9544,
		/// <summary>Pr Browser No U I.</summary>
		PrBrowserNoUI = -9545,

		/// <summary>Ticket Type Not Found.</summary>
		TicketTypeNotFound = -9580,
		/// <summary>Update Ticket Failed.</summary>
		UpdateTicketFailed = -9581,
		/// <summary>Validate Ticket Failed.</summary>
		ValidateTicketFailed = -9582,
		/// <summary>Sub Ticket Not Found.</summary>
		SubTicketNotFound = -9583,
		/// <summary>Invalid Sub Ticket.</summary>
		InvalidSubTicket = -9584,
		/// <summary>Delete Sub Ticket Failed.</summary>
		DeleteSubTicketFailed = -9585,
		/// <summary>Item Is Locked.</summary>
		ItemIsLocked = -9586,
		/// <summary>Ticket Is Locked.</summary>
		TicketIsLocked = -9587,
		/// <summary>Template Is Locked.</summary>
		TemplateIsLocked = -9588,
		/// <summary>Key Not Found.</summary>
		KeyNotFound = -9589,
		/// <summary>Key Not Unique.</summary>
		KeyNotUnique = -9590,
		/// <summary>Unknown Data Type.</summary>
		UnknownDataType = -9591,

		/// <summary>Create Message Failed.</summary>
		CreateMessageFailed = -9620,
		/// <summary>Server Communication Failed.</summary>
		ServerCommunicationFailed = -9621,
		/// <summary>Key Or Value Not Found.</summary>
		KeyOrValueNotFound = -9623,
		/// <summary>Messaging Error.</summary>
		MessagingError = -9624,

		/// <summary>Server Not Found.</summary>
		ServerNotFound = -9630,
		/// <summary>Server Already Running.</summary>
		ServerAlreadyRunning = -9631,
		/// <summary>Server Suspended.</summary>
		ServerSuspended = -9632,
		/// <summary>Server Attribute Restricted.</summary>
		ServerAttributeRestricted = -9633,
		/// <summary>File Or Dir Operation Failed.</summary>
		FileOrDirOperationFailed = -9634,
		/// <summary>User Or Group Not Found.</summary>
		UserOrGroupNotFound = -9635,
		/// <summary>Permission Error.</summary>
		PermissionError = -9636,
		/// <summary>Unknown Message.</summary>
		UnknownMessage = -9637,
		/// <summary>Queue Not Found.</summary>
		QueueNotFound = -9638,
		/// <summary>Queue Already Exists.</summary>
		QueueAlreadyExists = -9639,
		/// <summary>Queue Job Failed.</summary>
		QueueJobFailed = -9640,
		/// <summary>Job Not Found.</summary>
		JobNotFound = -9641,
		/// <summary>Job Busy.</summary>
		JobBusy = -9642,
		/// <summary>Job Canceled.</summary>
		JobCanceled = -9643,
		/// <summary>Document Not Found.</summary>
		DocumentNotFound = -9644,

		/// <summary>P M Symbol Not Found.</summary>
		PMSymbolNotFound = -9660,
		/// <summary>I O M Symbol Not Found.</summary>
		IOMSymbolNotFound = -9661,
		/// <summary>Cvm Symbol Not Found.</summary>
		CvmSymbolNotFound = -9662,
		/// <summary>Invalid P M Context.</summary>
		InvalidPMContext = -9663,
		/// <summary>Invalid I O M Context.</summary>
		InvalidIOMContext = -9664,
		/// <summary>Invalid Cvm Context.</summary>
		InvalidCvmContext = -9665,
		/// <summary>Invalid Job I D.</summary>
		InvalidJobID = -9666,
		/// <summary>No Printer Job I D.</summary>
		NoPrinterJobID = -9667,
		/// <summary>Job Stream Open Failed.</summary>
		JobStreamOpenFailed = -9668,
		/// <summary>Job Stream Read Failed.</summary>
		JobStreamReadFailed = -9669,
		/// <summary>Job Stream End Error.</summary>
		JobStreamEndError = -9670,
		/// <summary>Job Manager Aborted.</summary>
		JobManagerAborted = -9671,
		/// <summary>Job Get Ticket Bad Format Error.</summary>
		JobGetTicketBadFormatError = -9672,
		/// <summary>Job Get Ticket Read Error.</summary>
		JobGetTicketReadError = -9673,

		/// <summary>Plugin Not Found.</summary>
		PluginNotFound = -9701,
		/// <summary>Plugin Registeration Failed.</summary>
		PluginRegisterationFailed = -9702,
		/// <summary>Font Not Found.</summary>
		FontNotFound = -9703,
		/// <summary>Font Name Too Long.</summary>
		FontNameTooLong = -9704,
		/// <summary>General C G Error.</summary>
		GeneralCGError = -9705,
		/// <summary>Invalid State.</summary>
		InvalidState = -9706,
		/// <summary>Unexpected Imaging Error.</summary>
		UnexpectedImagingError = -9707,

		/// <summary>Invalid Printer Address.</summary>
		InvalidPrinterAddress = -9780,
		/// <summary>Open Failed.</summary>
		OpenFailed = -9781,
		/// <summary>Read Failed.</summary>
		ReadFailed = -9782,
		/// <summary>Write Failed.</summary>
		WriteFailed = -9783,
		/// <summary>Status Failed.</summary>
		StatusFailed = -9784,
		/// <summary>Close Failed.</summary>
		CloseFailed = -9785,
		/// <summary>Unsupported Connection.</summary>
		UnsupportedConnection = -9786,
		/// <summary>I O Attr Not Available.</summary>
		IOAttrNotAvailable = -9787,
		/// <summary>Read Got Zero Data.</summary>
		ReadGotZeroData = -9788,
	}

	/// <summary>Specifies printer state values.</summary>
	public enum PMPrinterState : System.UInt16 {
		/// <summary>Idle.</summary>
		Idle = 3,
		/// <summary>Processing.</summary>
		Processing = 4,
		/// <summary>Stopped.</summary>
		Stopped = 5,
	}

	/// <summary>Specifies duplex mode values.</summary>
	public enum PMDuplexMode : System.UInt32 {
		/// <summary>None.</summary>
		None = 1,
		/// <summary>No Tumble.</summary>
		NoTumble = 2,
		/// <summary>Tumble.</summary>
		Tumble = 3,
		/// <summary>Simplex Tumble.</summary>
		SimplexTumble = 4,
	}

	/// <summary>Specifies orientation values.</summary>
	public enum PMOrientation : System.UInt16 {
		/// <summary>Portrait.</summary>
		Portrait = 1,
		/// <summary>Landscape.</summary>
		Landscape = 2,
		/// <summary>Reverse Portrait.</summary>
		ReversePortrait = 3,
		/// <summary>Reverse Landscape.</summary>
		ReverseLandscape = 4,
	}

	/// <summary>Specifies the type of page-to-paper mapping to use when printing.</summary>
	[SupportedOSPlatform ("macos")]
	public enum PMPageToPaperMappingType {
		/// <summary>No page-to-paper mapping is applied.</summary>
		None = 1,
		/// <summary>The page is scaled to fit the paper size.</summary>
		ScaleToFit = 2,
	}

	/// <summary>Represents resolution.</summary>
	[SupportedOSPlatform ("macos")]
	[StructLayout (LayoutKind.Sequential)]
	public struct PMResolution {

		double hRes;
		double vRes;
		/// <summary>The horizontal resolution.</summary>
		public double HorizontalResolution => hRes;
		/// <summary>The vertical resolution.</summary>
		public double VerticalResolution => vRes;

		/// <param name="horizontal">The horizontal resolution.</param>
		/// <param name="vertical">The vertical resolution.</param>
		/// <summary>Creates a resolution with the specified values.</summary>
		public PMResolution (double horizontal, double vertical)
		{
			hRes = horizontal;
			vRes = vertical;
		}
		/// <summary>Returns a string representation of this instance.</summary>
		public override string ToString ()
		{
			return $"[HorizontalResolution={hRes},VerticalResolution={vRes}]";
		}
	}

	/// <summary>Represents rect.</summary>
	[SupportedOSPlatform ("macos")]
	[StructLayout (LayoutKind.Sequential)]
	public struct PMRect {
		internal double top;
		internal double left;
		internal double bottom;
		internal double right;

		/// <summary>The top.</summary>
		public double Top => top;
		/// <summary>The left.</summary>
		public double Left => left;
		/// <summary>The bottom.</summary>
		public double Bottom => bottom;
		/// <summary>The right.</summary>
		public double Right => right;

		/// <param name="top">The top value.</param>
		/// <param name="bottom">The bottom value.</param>
		/// <param name="left">The left value.</param>
		/// <param name="right">The right value.</param>
		/// <summary>Creates a rectangle with the specified values.</summary>
		public PMRect (double top, double bottom, double left, double right)
		{
			this.top = top;
			this.bottom = bottom;
			this.left = left;
			this.right = right;
		}

		/// <summary>Returns a string representation of this instance.</summary>
		public override string ToString ()
		{
			return $"[Top={top},Bottom={bottom},Left={left},Right={right}]";
		}
	}

	/// <summary>Represents paper margins.</summary>
	[SupportedOSPlatform ("macos")]
	[StructLayout (LayoutKind.Sequential)]
	public struct PMPaperMargins {
		PMRect Rect;

		/// <summary>The top.</summary>
		public double Top => Rect.top;
		/// <summary>The left.</summary>
		public double Left => Rect.left;
		/// <summary>The bottom.</summary>
		public double Bottom => Rect.bottom;
		/// <summary>The right.</summary>
		public double Right => Rect.right;

		/// <param name="top">The top value.</param>
		/// <param name="bottom">The bottom value.</param>
		/// <param name="left">The left value.</param>
		/// <param name="right">The right value.</param>
		/// <summary>Creates paper margins with the specified values.</summary>
		public PMPaperMargins (double top, double bottom, double left, double right)
		{
			Rect = new PMRect (top, bottom, left, right);
		}

		/// <summary>Returns a string representation of this instance.</summary>
		public override string ToString ()
		{
			return Rect.ToString ();
		}
	}
}
