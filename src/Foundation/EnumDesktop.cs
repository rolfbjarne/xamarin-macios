//
// Copyright 2010, Novell, Inc.
// Copyright 2012 Xamarin Inc.
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

// FIXME: EnumDesktop.cs should be merged into Enums.cs

namespace Foundation {
	[NoiOS, NoTV, NoMacCatalyst]
	[Internal]
	internal enum NSAttributedStringDataType {
		RTF,
		RTFD,
		HTML,
	}

	// NSTask.h:typedef NS_ENUM(NSInteger, NSTaskTerminationReason)
	[Native]
	[NoiOS, NoTV, NoMacCatalyst]
	public enum NSTaskTerminationReason : long {
		/// <summary>Indicates exit.</summary>
		Exit = 1,
		/// <summary>Indicates uncaught signal.</summary>
		UncaughtSignal = 2,
	}

	// The following constants where taken from MonoDevelop Carbon.cs MacInterop file
	[NoiOS, NoTV]
	[MacCatalyst (13, 1)]
	public enum AEEventID : uint {
		/// <summary>Indicates open application.</summary>
		OpenApplication = 1868656752, // 'oapp'
		/// <summary>Indicates reopen application.</summary>
		ReopenApplication = 1918988400, //'rapp'
		/// <summary>Indicates open documents.</summary>
		OpenDocuments = 1868853091, // 'odoc'
		/// <summary>Indicates print documents.</summary>
		PrintDocuments = 188563030, // 'pdoc'
		/// <summary>Indicates open contents.</summary>
		OpenContents = 1868787566, // 'ocon'
		/// <summary>Indicates quit application.</summary>
		QuitApplication = 1903520116, // 'quit'
		/// <summary>Indicates show preferences.</summary>
		ShowPreferences = 1886545254, // 'pref'
		/// <summary>Indicates application died.</summary>
		ApplicationDied = 1868720500, // 'obit'
		/// <summary>Indicates get url.</summary>
		GetUrl = 1196773964, // 'GURL'
	}

	[NoiOS, NoTV]
	[MacCatalyst (13, 1)]
	public enum AEEventClass : uint {
		/// <summary>Indicates mouse.</summary>
		Mouse = 1836021107, // 'mous'
		/// <summary>Indicates keyboard.</summary>
		Keyboard = 1801812322, // 'keyb'
		/// <summary>Indicates text input.</summary>
		TextInput = 1952807028, // 'text'
		/// <summary>Indicates application.</summary>
		Application = 1634758764, // 'appl'
		/// <summary>Indicates remote apple event.</summary>
		RemoteAppleEvent = 1701867619,  //'eppc' //remote apple event?
		/// <summary>Indicates menu.</summary>
		Menu = 1835363957, // 'menu'
		/// <summary>Indicates window.</summary>
		Window = 2003398244, // 'wind'
		/// <summary>Indicates control.</summary>
		Control = 1668183148, // 'cntl'
		/// <summary>Indicates command.</summary>
		Command = 1668113523, // 'cmds'
		/// <summary>Indicates tablet.</summary>
		Tablet = 1952607348, // 'tblt'
		/// <summary>Indicates volume.</summary>
		Volume = 1987013664, // 'vol '
		/// <summary>Indicates appearance.</summary>
		Appearance = 1634758765, // 'appm'
		/// <summary>Indicates service.</summary>
		Service = 1936028278, // 'serv'
		/// <summary>Indicates toolbar.</summary>
		Toolbar = 1952604530, // 'tbar'
		/// <summary>Indicates toolbar item.</summary>
		ToolbarItem = 1952606580, // 'tbit'
		/// <summary>Indicates accessibility.</summary>
		Accessibility = 1633903461, // 'acce'
		/// <summary>Indicates h i object.</summary>
		HIObject = 1751740258, // 'hiob'
		/// <summary>Indicates apple event.</summary>
		AppleEvent = 1634039412, // 'aevt'
		/// <summary>Indicates internet.</summary>
		Internet = 1196773964, // 'GURL'
	}

	// Added from NSUserNotification.h
	[NoiOS, NoTV, NoMacCatalyst]
	[Native]
	[Advice ("'NSUserNotification' usages should be replaced with 'UserNotifications' framework.")]
	public enum NSUserNotificationActivationType : long {
		/// <summary>Indicates none.</summary>
		None = 0,
		/// <summary>Indicates contents clicked.</summary>
		ContentsClicked = 1,
		/// <summary>Indicates action button clicked.</summary>
		ActionButtonClicked = 2,
		/// <summary>Indicates replied.</summary>
		Replied = 3,
		/// <summary>Indicates additional action clicked.</summary>
		AdditionalActionClicked = 4,
	}

	[NoiOS, NoTV, NoMacCatalyst]
	[Native]
	[Flags]
	public enum NSAppleEventSendOptions : ulong {
		/// <summary>Indicates no reply.</summary>
		NoReply = 0x00000001, // kAENoReply,
		/// <summary>Indicates queue reply.</summary>
		QueueReply = 0x00000002, // kAEQueueReply,
		/// <summary>Indicates wait for reply.</summary>
		WaitForReply = 0x00000003, // kAEWaitReply,
		/// <summary>Indicates never interact.</summary>
		NeverInteract = 0x00000010, // kAENeverInteract,
		/// <summary>Indicates can interact.</summary>
		CanInteract = 0x00000020, // kAECanInteract,
		/// <summary>Indicates always interact.</summary>
		AlwaysInteract = 0x00000030, // kAEAlwaysInteract,
		/// <summary>Indicates can switch layer.</summary>
		CanSwitchLayer = 0x00000040, // kAECanSwitchLayer,
		/// <summary>Indicates dont record.</summary>
		DontRecord = 0x00001000, // kAEDontRecord,
		/// <summary>Indicates dont execute.</summary>
		DontExecute = 0x00002000, // kAEDontExecute,
		/// <summary>Indicates dont annotate.</summary>
		DontAnnotate = 0x00010000, // kAEDoNotAutomaticallyAddAnnotationsToEvent,
		/// <summary>Indicates default options.</summary>
		DefaultOptions = WaitForReply | CanInteract,
	}
}
