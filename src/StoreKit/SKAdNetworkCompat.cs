//
// SKAdNetworkCompat.cs
//
// Authors:
//	Alex Soto  <alexsoto@microsoft.com>
//
// Copyright 2018 Microsoft Corporation.
//

using System;
using System.ComponentModel;
using System.Runtime.Versioning;

using Foundation;
using ObjCRuntime;

#if !NET
using NativeHandle = System.IntPtr;
#endif

#if TVOS && !XAMCORE_4_0
namespace StoreKit {
	[Obsolete ("Not usable from tvOS and will be removed in the future.")]
#if NET
	[UnsupportedOSPlatform ("tvos")]
#else
	[Unavailable (PlatformName.TvOS)]
#endif
	public class SKAdNetwork : NSObject {

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SKAdNetwork");
		
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected SKAdNetwork (NSObjectFlag t) : base (t) { }

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal SKAdNetwork (NativeHandle handle) : base (handle) { }

		[Obsolete ("Throws a 'NotSupportedException'.")]
		public static void RegisterAppForAdNetworkAttribution () => throw new NotSupportedException ();
	}
}
#endif
