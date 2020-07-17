//
// ExceptionMode.cs:
//
// Authors:
//   Rolf Bjarne Kvinge <rolf@xamarin.com>
//
// Copyright 2016 Xamarin Inc.

using System;

#if MMP || MTOUCH || BUNDLER
using Xamarin.Bundler;
using Xamarin.Utils;
#endif

namespace ObjCRuntime {
	/* This enum must always match the identical enum in runtime/xamarin/main.h */
	public enum MarshalObjectiveCExceptionMode {
		Default                  = 0,
		UnwindManagedCode        = 1, // not available for watchOS/COOP, default for the other platforms
		ThrowManagedException    = 2, // default for watchOS/COOP
		Abort                    = 3,
		Disable                  = 4, // this will also prevent the corresponding event from working
	}

	/* This enum must always match the identical enum in runtime/xamarin/main.h */
	public enum MarshalManagedExceptionMode {
		Default                  = 0,
		UnwindNativeCode         = 1, // not available for watchOS/COOP, default for the other platforms
		ThrowObjectiveCException = 2, // default for watchOS/COOP
		Abort                    = 3,
		Disable                  = 4, // this will also prevent the corresponding event from working
	}

#if MMP || MTOUCH || BUNDLER
	static class MarshalExceptions {
		public static bool TryParseManagedExceptionMode (string value, out MarshalManagedExceptionMode mode)
		{
			mode = MarshalManagedExceptionMode.Default;

			switch (value) {
			case "default":
				mode = MarshalManagedExceptionMode.Default;
				break;
			case "unwindnative":
			case "unwindnativecode":
				mode = MarshalManagedExceptionMode.UnwindNativeCode;
				break;
			case "throwobjectivec":
			case "throwobjectivecexception":
				mode = MarshalManagedExceptionMode.ThrowObjectiveCException;
				break;
			case "abort":
				mode = MarshalManagedExceptionMode.Abort;
				break;
			case "disable":
				mode = MarshalManagedExceptionMode.Disable;
				break;
			default:
				return false;
			}

			return true;
		}

		public static bool TryParseObjectiveCExceptionMode (string value, out MarshalObjectiveCExceptionMode mode)
		{
			mode = MarshalObjectiveCExceptionMode.Default;
			switch (value) {
			case "default":
				mode = MarshalObjectiveCExceptionMode.Default;
				break;
			case "unwindmanaged":
			case "unwindmanagedcode":
				mode = MarshalObjectiveCExceptionMode.UnwindManagedCode;
				break;
			case "throwmanaged":
			case "throwmanagedexception":
				mode = MarshalObjectiveCExceptionMode.ThrowManagedException;
				break;
			case "abort":
				mode = MarshalObjectiveCExceptionMode.Abort;
				break;
			case "disable":
				mode = MarshalObjectiveCExceptionMode.Disable;
				break;
			default:
				return false;
			}
			return true;
		}

		public static MarshalManagedExceptionMode GetManagedExceptionMode (ApplePlatform platform, MarshalManagedExceptionMode mode, bool? enableCoopGC, bool isSimulator, bool isDebug, string product, out bool isDefaultMode)
		{
			var rv = mode;
			isDefaultMode = false;
			if (mode == MarshalManagedExceptionMode.Default) {
				if (enableCoopGC == true) {
					rv = MarshalManagedExceptionMode.ThrowObjectiveCException;
				} else {
					switch (platform) {
					case ApplePlatform.iOS:
					case ApplePlatform.TVOS:
					case ApplePlatform.WatchOS:
						rv = isDebug && isSimulator ? MarshalManagedExceptionMode.UnwindNativeCode : MarshalManagedExceptionMode.Disable;
						break;
					case ApplePlatform.MacOSX:
						rv = isDebug ? MarshalManagedExceptionMode.UnwindNativeCode : MarshalManagedExceptionMode.Disable;
						break;
					default:
						throw ErrorHelper.CreateError (71, Errors.MX0071 /* Unknown platform: {0}. This usually indicates a bug in {1}; please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new with a test case. */, platform.ToString (), product);
					}
				}
				isDefaultMode = true;
			}
			return rv;
		}

		public static MarshalObjectiveCExceptionMode GetObjectiveCExceptionMode (ApplePlatform platform, MarshalObjectiveCExceptionMode mode, bool? enableCoopGC, bool isSimulator, bool isDebug, string product)
		{
			var rv = mode;
			if (mode == MarshalObjectiveCExceptionMode.Default) {
				if (enableCoopGC == true) {
					rv = MarshalObjectiveCExceptionMode.ThrowManagedException;
				} else {
					switch (platform) {
					case ApplePlatform.iOS:
					case ApplePlatform.TVOS:
					case ApplePlatform.WatchOS:
						rv = isDebug && isSimulator ? MarshalObjectiveCExceptionMode.UnwindManagedCode : MarshalObjectiveCExceptionMode.Disable;
						break;
					case ApplePlatform.MacOSX:
						rv = isDebug ? MarshalObjectiveCExceptionMode.ThrowManagedException : MarshalObjectiveCExceptionMode.Disable;
						break;
					default:
						throw ErrorHelper.CreateError (71, Errors.MX0071 /* Unknown platform: {0}. This usually indicates a bug in {1}; please file a bug report at https://github.com/xamarin/xamarin-macios/issues/new with a test case. */, platform.ToString (), product);
					}
				}
			}
			return rv;
		}
	}
#endif // MMP || MTOUCH || BUNDLER
}
