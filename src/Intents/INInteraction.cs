//
// INInteraction.cs
//
// Authors:
//	Alex Soto  <alexsoto@microsoft.com>
//
// Copyright 2017 Xamarin Inc. All rights reserved.
//

#if IOS

#nullable enable

namespace Intents {
	public partial class INInteraction {

		/// <typeparam name="T">The type to return the parameter value as.</typeparam>
		/// <param name="parameter">The parameter whose value to retrieve.</param>
		/// <summary>Returns the specified <paramref name="parameter" /> as an instance of <typeparamref name="T" />.</summary>
		/// <returns>The parameter value as an instance of <typeparamref name="T" />.</returns>
		public T GetParameterValue<T> (INParameter parameter) where T : NSObject
		{
			return Runtime.GetNSObject<T> (_GetParameterValue (parameter))!;
		}
	}
}
#endif
