//
// PHPhotoLibrary.cs: Provides a couple of overload methods
//
// Authors:
//   Miguel de Icaza
//
// Copyright 2014 Xamarin Inc
//

#nullable enable

using System.Collections;
using System.Collections.Generic;

namespace Photos {
	public partial class PHPhotoLibrary {
		class __phlib_observer : PHPhotoLibraryChangeObserver {
			Action<PHChange> observer;

			public __phlib_observer (Action<PHChange> observer)
			{
				this.observer = observer;
			}

			public override void PhotoLibraryDidChange (PHChange changeInstance)
			{
				observer (changeInstance);
			}
		}

		/// <param name="changeObserver">The change observer.</param>
		///         <summary>To be added.</summary>
		///         <returns>To be added.</returns>
		public object RegisterChangeObserver (Action<PHChange> changeObserver)
		{
			var token = new __phlib_observer (changeObserver);
			RegisterChangeObserver (token);
			return token;
		}

		/// <param name="registeredToken">The registered token.</param>
		///         <summary>To be added.</summary>
		public void UnregisterChangeObserver (object registeredToken)
		{
			if (registeredToken is __phlib_observer observer)
				UnregisterChangeObserver (observer);
			else
				throw new ArgumentException ("registeredToken should be a value returned by RegisterChangeObserver(PHChange)");
		}
	}
}
