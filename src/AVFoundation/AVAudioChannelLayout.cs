//
// Copyright 2014 Xamarin Inc
//
// Authors:
//   Miguel de Icaza (miguel@xamarin.com)
//

// 'AVAudioChannelLayout' defines operator == or operator != but does not override Object.Equals(object o)
#pragma warning disable 0660
// 'AVAudioChannelLayout' defines operator == or operator != but does not override Object.GetHashCode()
#pragma warning disable 0661
// In both of these cases, the NSObject Equals/GetHashCode implementation works fine, so we can ignore these warnings.

using Foundation;
using ObjCRuntime;
using AudioToolbox;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace AVFoundation {
	public partial class AVAudioChannelLayout {
		[ThreadStatic] 
		static IntPtr handleToLayout;

		static IntPtr CreateLayoutPtr (AudioChannelLayout layout)
		{
			int size;
			handleToLayout = layout.ToBlock (out size);
			return handleToLayout;
		}

		[DesignatedInitializer]
		public AVAudioChannelLayout (AudioChannelLayout layout)
#if NET
			: this (CreateLayoutPtr (layout))
#else
			: this ((nint) CreateLayoutPtr (layout))
#endif
		{
			Marshal.FreeHGlobal (handleToLayout);
		}

		public AudioChannelLayout Layout {
			get {
				return AudioChannelLayout.FromHandle (_Layout);
			}
		}
		
		public static bool operator == (AVAudioChannelLayout a, AVAudioChannelLayout b)
		{
			return a.Equals (b);
		}
		
		public static bool operator != (AVAudioChannelLayout a, AVAudioChannelLayout b)
		{
			return !a.Equals (b);
		}
	}
}
