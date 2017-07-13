﻿//
// INSetCarLockStatusIntent.cs
//
// Authors:
//	Alex Soto  <alexsoto@microsoft.com>
//
// Copyright 2017 Xamarin Inc. All rights reserved.
//

#if XAMCORE_2_0 && (IOS || TVOS)

using XamCore.Foundation;
using XamCore.Intents;
using XamCore.ObjCRuntime;

namespace XamCore.Intents {

	public partial class INSetCarLockStatusIntent {

		public INSetCarLockStatusIntent (bool? locked, INSpeakableString carName) :
			this (locked.HasValue ? new NSNumber (locked.Value) : null, carName)
		{
		}

		// if/when we update the generator to allow this pattern we can move this back
		// into bindings and making them virtual (not a breaking change)

		public bool? Locked {
			get { return _Locked == null ? null : (bool?) _Locked.BoolValue; }
		}
	}
}

#endif
