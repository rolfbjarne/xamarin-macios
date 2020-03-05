//
// UIApplication.cs: Extensions to UIApplication
//
// Authors:
//   Geoff Norton
//
// Copyright 2009, Novell, Inc.
// Copyright 2014, Xamarin Inc.
// Copyright 2019 Microsoft Corporation.
//

using System;
using System.Threading;
using ObjCRuntime;
using System.Runtime.InteropServices;
using Foundation;

namespace UIKit {
	public class UIKitThreadAccessException : Exception {
		public UIKitThreadAccessException () : base ("UIKit Consistency error: you are calling a UIKit method that can only be invoked from the UI thread.")
		{
		}
	}
	
#if WATCH
	// There's no UIApplication on the watch, but we use the class extensively in bindings (EnsureUIThread, etc)
	// so we include it as an internal type.
	internal
#else
	public
#endif
	partial class UIApplication
#if !WATCH 
	: UIResponder
#endif
	{
		static Thread mainThread;
		public static bool CheckForIllegalCrossThreadCalls = true;
		public static bool CheckForEventAndDelegateMismatches = true;

#if !WATCH
		// We link with __Internal here so that this function is interposable from third-party native libraries.
		// See: https://github.com/xamarin/MicrosoftInTune/issues/3 for an example.
		[DllImport (/*Constants.UIKitLibrary*/ "__Internal")]
		extern static int UIApplicationMain (int argc, /* char[]* */ string [] argv, /* NSString* */ IntPtr principalClassName, /* NSString* */ IntPtr delegateClassName);
#endif

		// called from NSExtension.Initialize (so other, future stuff, can be added if needed)
		// NOTE: must be called from the main thread, e.g. for extensions
		internal static void Initialize ()
		{
			if (mainThread != null)
				return;
			
			SynchronizationContext.SetSynchronizationContext (new UIKitSynchronizationContext ());
			mainThread = Thread.CurrentThread;
		}
		
#if !WATCH
		public static void Main (string [] args, string principalClassName, string delegateClassName)
		{
			var p = NSString.CreateNative (principalClassName);
			var d = NSString.CreateNative (delegateClassName);
			try {
				Main (args, p, d);
			} finally {
				// it just looks nicer to release them
				NSString.ReleaseNative (d);
				NSString.ReleaseNative (p);
			}
		}
		
		public static void Main (string [] args, Type principalClass, Type delegateClass)
		{
			Main (args, principalClass == null ? null : new Class (principalClass).Name, delegateClass == null ? null : new Class (delegateClass).Name);
		}

		public static void Main (string [] args)
		{
			Main (args, IntPtr.Zero, IntPtr.Zero);
		}

		static void Main (string [] args, IntPtr principal, IntPtr @delegate)
		{
			Initialize ();
			var rv = UIApplicationMain (args.Length, args, principal, @delegate);
			Console.WriteLine ("UIApplicationMain returned {0}", rv);
		}
#endif

		public static void EnsureUIThread ()
		{
			// note: some extensions, like keyboards, won't call Main (and set mainThread)
			// FIXME: do better than disabling the feature
			if (CheckForIllegalCrossThreadCalls && (mainThread != null) && (mainThread != Thread.CurrentThread))
				throw new UIKitThreadAccessException ();
		}

		internal static void EnsureEventAndDelegateAreNotMismatched (object del, Type expectedType)
		{
			if (CheckForEventAndDelegateMismatches && !(expectedType.IsAssignableFrom (del.GetType ())))
				throw new InvalidOperationException (string.Format("Event registration is overwriting existing delegate. Either just use events or your own delegate: {0} {1}", del.GetType (), expectedType));
		}

		internal static void EnsureDelegateAssignIsNotOverwritingInternalDelegate (object currentDelegateValue, object newDelegateValue, Type internalDelegateType)
		{
			if (UIApplication.CheckForEventAndDelegateMismatches && currentDelegateValue != null && newDelegateValue != null
				&& currentDelegateValue.GetType().IsAssignableFrom (internalDelegateType)
				&& !newDelegateValue.GetType().IsAssignableFrom (internalDelegateType))
				throw new InvalidOperationException (string.Format("Event registration is overwriting existing delegate. Either just use events or your own delegate: {0} {1}", newDelegateValue.GetType(), internalDelegateType));
		}
	}

#if !WATCH
	public partial class UIContentSizeCategoryChangedEventArgs {
		public UIContentSizeCategory NewValue {
			get {
				return UIContentSizeCategoryExtensions.GetValue (WeakNewValue);
			}
		}
	}
#endif
}
