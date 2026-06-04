//
// Copyright 2011, Kenneth J. Pouncey
//
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

namespace ScriptingBridge {
	// AE.framework/Headers/AEDataModel.h:typedef SInt32 AESendMode;
	/// <summary>Specifies options for sending Apple events.</summary>
	[Flags]
	public enum AESendMode : int {
		/// <summary>Indicates no reply.</summary>
		NoReply = 0x00000001,
		/// <summary>Indicates queue reply.</summary>
		QueueReply = 0x00000002,
		/// <summary>Indicates wait reply.</summary>
		WaitReply = 0x00000003,
		/// <summary>Indicates dont reconnect.</summary>
		DontReconnect = 0x00000080,
		/// <summary>Indicates want receipt.</summary>
		WantReceipt = 0x00000200,
		/// <summary>Indicates never interact.</summary>
		NeverInteract = 0x00000010,
		/// <summary>Indicates can interact.</summary>
		CanInteract = 0x00000020,
		/// <summary>Indicates always interact.</summary>
		AlwaysInteract = 0x00000030,
		/// <summary>Indicates can switch layer.</summary>
		CanSwitchLayer = 0x00000040,
		/// <summary>Indicates dont record.</summary>
		DontRecord = 0x00001000,
		/// <summary>Indicates dont execute.</summary>
		DontExecute = 0x00002000,
		/// <summary>Indicates process non reply events.</summary>
		ProcessNonReplyEvents = 0x00008000,
	}

	// LaunchServices.framework/Headers/LSOpen.h:typedef OptionBits LSLaunchFlags;
	// DirectoryService.framework/Headers/DirServicesTypes.h:typedef UInt32 OptionBits;
	/// <summary>Specifies options for launching applications.</summary>
	[Flags]
	public enum LSLaunchFlags : uint {
		/// <summary>Indicates launch defaults.</summary>
		LaunchDefaults = 0x00000001,
		/// <summary>Indicates launch and print.</summary>
		LaunchAndPrint = 0x00000002,
		/// <summary>Indicates launch reserved2.</summary>
		LaunchReserved2 = 0x00000004,
		/// <summary>Indicates launch reserved3.</summary>
		LaunchReserved3 = 0x00000008,
		/// <summary>Indicates launch reserved4.</summary>
		LaunchReserved4 = 0x00000010,
		/// <summary>Indicates launch reserved5.</summary>
		LaunchReserved5 = 0x00000020,
		/// <summary>Indicates launch and display errors.</summary>
		LaunchAndDisplayErrors = 0x00000040,
		/// <summary>Indicates launch inhibit b g only.</summary>
		LaunchInhibitBGOnly = 0x00000080,
		/// <summary>Indicates launch dont add to recents.</summary>
		LaunchDontAddToRecents = 0x00000100,
		/// <summary>Indicates launch dont switch.</summary>
		LaunchDontSwitch = 0x00000200,
		/// <summary>Indicates launch no params.</summary>
		LaunchNoParams = 0x00000800,
		/// <summary>Indicates launch async.</summary>
		LaunchAsync = 0x00010000,
		/// <summary>Indicates launch start classic.</summary>
		LaunchStartClassic = 0x00020000,
		/// <summary>Indicates launch in classic.</summary>
		LaunchInClassic = 0x00040000,
		/// <summary>Indicates launch new instance.</summary>
		LaunchNewInstance = 0x00080000,
		/// <summary>Indicates launch and hide.</summary>
		LaunchAndHide = 0x00100000,
		/// <summary>Indicates launch and hide others.</summary>
		LaunchAndHideOthers = 0x00200000,
		/// <summary>Indicates launch has untrusted contents.</summary>
		LaunchHasUntrustedContents = 0x00400000,
	}

}
