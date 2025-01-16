//
// NSAlert.cs
//
// Author:
//   Aaron Bockover <abock@xamarin.com>
//
// Copyright 2012 Xamarin Inc. (http://xamarin.com)
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

#if !__MACCATALYST__ // Mac Catalyst doesn't have NSAlert

using System;
using System.Collections.Generic;
using System.Runtime.Versioning;

using Foundation;
using ObjCRuntime;

#nullable enable

namespace AppKit {
	[Register ("__MonoMac_NSAlertDidEndDispatcher")]
	internal class NSAlertDidEndDispatcher : NSObject {
		const string selector = "alertDidEnd:returnCode:contextInfo:";
		public static readonly Selector Selector = new Selector (selector);

		Action<nint>? action;

		public NSAlertDidEndDispatcher (Action<nint> action)
		{
			this.action = action;
			IsDirectBinding = false;
			DangerousRetain ();
		}

		[Export (selector)]
		[Preserve (Conditional = true)]
		public void OnAlertDidEnd (NSAlert alert, nint returnCode, IntPtr context)
		{
			try {
				if (action is not null)
					action (returnCode);
			} finally {
				action = null;
				DangerousRelease ();
			}
		}
	}

	public partial class NSAlert {
		public void BeginSheet (NSWindow window)
		{
			BeginSheet (window, (v) => { });
		}

#if !XAMCORE_5_0
		[Obsolete ("Use 'BeginSheet (NSWindow, Action<NSModalResponse>) instead.")]
		public void BeginSheet (NSWindow window, Action? onEnded)
		{
			BeginSheet (window, r => {
				if (onEnded is not null)
					onEnded ();
			});
		}
#endif

#if !XAMCORE_5_0
		[Obsolete ("Use 'BeginSheet (NSWindow, Action<NSModalResponse>) instead.")]
		public void BeginSheetForResponse (NSWindow window, Action<nint> onEnded)
		{
			BeginSheet (window, (NSModalResponse response) => onEnded ((nint) response));
		}
#endif


#if XAMCORE_5_0
		public NSModalResponse RunSheetModal (NSWindow window)
#else
		public nint RunSheetModal (NSWindow window)
#endif
		{
			return RunSheetModal (window, NSApplication.SharedApplication);
		}

#if XAMCORE_5_0
		public NSModalResponse RunSheetModal (NSWindow? window, NSApplication application)
#else
		public nint RunSheetModal (NSWindow? window, NSApplication application)
#endif
		{
			if (application is null)
				throw new ArgumentNullException ("application");

			// same behavior as BeginSheet with a null window
			if (window is null)
				return RunModal ();

#if XAMCORE_5_0
			var returnCode = NSModalResponse.Stop;
#else
			nint returnCode = -1000;
#endif

			BeginSheet (window, (NSModalResponse r) => {
#if XAMCORE_5_0
				returnCode = r;
#else
				returnCode = (nint) r;
#endif
				application.StopModal ();
			});

			application.RunModalForWindow (Window);

			return returnCode;
		}
	}
}
#endif // __MACCATALYST__
