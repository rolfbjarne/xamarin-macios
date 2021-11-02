//
// INSearchCallHistoryIntent.cs
//
// Authors:
//	Alex Soto  <alexsoto@microsoft.com>
//
// Copyright 2017 Xamarin Inc. All rights reserved.
//

#if !TVOS
using System;
using Foundation;
using ObjCRuntime;

namespace Intents {
#if !NET && __MACOS__ // INSearchCallHistoryIntent isn't in macOS
	public partial class INSearchCallHistoryIntent {

		public bool? Unseen {
			get { return WeakUnseen?.BoolValue; }
		}
	}
#endif // !NET && __MACOS__
}
#endif // !TVOS
