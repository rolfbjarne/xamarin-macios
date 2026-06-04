// 
// CVMetalTextureAttributes.cs
//
// Authors: Alex Soto (alexsoto@microsoft.com)
//
// Copyright 2017 Xamarin Inc.
//

using Metal;

#nullable enable

namespace CoreVideo {
	/// <summary>Provides attributes for configuring Metal texture caches.</summary>
	public partial class CVMetalTextureAttributes : DictionaryContainer {

		/// <summary>Gets or sets the Metal texture usage flags.</summary>
		public MTLTextureUsage? Usage {
			get {
				return (MTLTextureUsage?) (uint?) GetNUIntValue (CVMetalTextureAttributesKeys.UsageKey);
			}
			set {
				SetNumberValue (CVMetalTextureAttributesKeys.UsageKey, (nuint?) (uint?) value);
			}
		}
	}
}
