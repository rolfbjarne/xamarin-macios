﻿//
// AVCaptureSynchronizedDataCollection.cs
//
// Authors:
//	Alex Soto  <alexsoto@microsoft.com>
//
// Copyright 2017 Xamarin Inc. All rights reserved.
//

#if IOS || MONOMAC
using System;
using System.Collections;
using System.Collections.Generic;
using XamCore.Foundation;

namespace XamCore.AVFoundation {
	public partial class AVCaptureSynchronizedDataCollection { //: IEnumerable<AVCaptureOutput>
		public AVCaptureSynchronizedData this [AVCaptureOutput captureOutput] {
			get {
				return GetSynchronizedData (captureOutput);
			}
		}

		// TODO: Enable IEnumerable/NSFastEnumerator once radar://34641736 is fixed
		//https://trello.com/c/iFtsFSWs
		//public IEnumerator<AVCaptureOutput> GetEnumerator ()
		//{
		//	return new NSFastEnumerator<AVCaptureOutput> (this);
		//}

		//IEnumerator IEnumerable.GetEnumerator ()
		//{
		//	return GetEnumerator (); ;
		//}
	}
}
#endif // IOS || MONOMAC
