using System.Collections.Generic;
using NUnit.Framework;

[Category (CATEGORY)]
public class MobileSampleTester : SampleTester
{
	const string REPO = "mobile-samples";
	const string CATEGORY = "mobilesamples"; // categories can't contain dashes
	public MobileSampleTester ()
		: base (REPO)
	{
	}

	static string [] GetSolutions ()
	{
		return GetSolutionsImpl (REPO);
	}

	protected override Dictionary<string, string> GetIgnoredSolutionsImpl ()
	{
		return new Dictionary<string, string>
		{
			{ "AnalogClock/AnalogClock.sln", "Contains android project(s) (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "AsyncAwait/AsyncAwait.sln", "Contains android project(s) (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "AsyncAwait/Windows/Windows.sln", "build fails with: /tmp/xamarin-macios-sample-builder/repositories/mobile-samples/AsyncAwait/Windows/Windows.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\"." },
			{ "Azure/GetStartedWithData/Android/XamarinTodoQuickStart.Android.sln", "Contains android project(s)" },
			{ "Azure/GetStartedWithData/iOS/XamarinTodoQuickStart.iOS.sln",
				@"build fails with:
	TodoItem.cs(2,7): error CS0246: The type or namespace name `Newtonsoft' could not be found. Are you missing an assembly reference?
	TodoService.cs(9,18): error CS0234: The type or namespace name `WindowsAzure' does not exist in the namespace `Microsoft'. Are you missing an assembly reference?
	TodoService.cs (20,17): error CS0246: The type or namespace name `MobileServiceClient' could not be found. Are you missing an assembly reference?
	TodoService.cs(21,17): error CS0246: The type or namespace name `IMobileServiceTable' could not be found. Are you missing an assembly reference?"
			},
			{ "Azure/GetStartedWithPush/Android/XamarinTodoQuickStart.Android.sln", "Contains android project(s) (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Azure/GetStartedWithPush/Android/XamarinTodoQuickStart.Android.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Azure/GetStartedWithPush/iOS/XamarinTodoQuickStart.iOS.sln",
				@"build fails with:
	TodoItem.cs(2,7): error CS0246: The type or namespace name `Newtonsoft' could not be found. Are you missing an assembly reference?
	TodoService.cs(5,17): error CS0234: The type or namespace name `WindowsAzure' does not exist in the namespace `Microsoft'. Are you missing an assembly reference?
	TodoService.cs (15,17): error CS0246: The type or namespace name `MobileServiceClient' could not be found. Are you missing an assembly reference?
	TodoService.cs(16,17): error CS0246: The type or namespace name `IMobileServiceTable' could not be found. Are you missing an assembly reference?"
			},
			{ "Azure/GetStartedWithUsers/Android/XamarinTodoQuickStart.Android.sln", "Contains android project(s) (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Azure/GetStartedWithUsers/Android/XamarinTodoQuickStart.Android.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Azure/GetStartedWithUsers/iOS/XamarinTodoQuickStart.iOS.sln",
				@"build fails with:
	TodoItem.cs(2,7): error CS0246: The type or namespace name `Newtonsoft' could not be found. Are you missing an assembly reference?
	TodoService.cs(5,17): error CS0234: The type or namespace name `WindowsAzure' does not exist in the namespace `Microsoft'. Are you missing an assembly reference?
	TodoService.cs (16,17): error CS0246: The type or namespace name `MobileServiceClient' could not be found. Are you missing an assembly reference?
	TodoService.cs(17,17): error CS0246: The type or namespace name `MobileServiceUser' could not be found. Are you missing an assembly reference?
	TodoService.cs(18,17): error CS0246: The type or namespace name `IMobileServiceTable' could not be found. Are you missing an assembly reference?
	TodoService.cs(20,16): error CS0246: The type or namespace name `MobileServiceUser' could not be found. Are you missing an assembly reference?"
			},
			{ "Azure/GettingStarted/Android/XamarinTodoQuickStart.Android.sln", "Contains android project(s) (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Azure/GettingStarted/Android/XamarinTodoQuickStart.Android.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Azure/GettingStarted/iOS/XamarinTodoQuickStart.iOS.sln",
				@"build fails with:
	TodoItem.cs(2,7): error CS0246: The type or namespace name `Newtonsoft' could not be found. Are you missing an assembly reference?
	TodoService.cs(5,17): error CS0234: The type or namespace name `WindowsAzure' does not exist in the namespace `Microsoft'. Are you missing an assembly reference?
	TodoService.cs (14,17): error CS0246: The type or namespace name `MobileServiceClient' could not be found. Are you missing an assembly reference?
	TodoService.cs(15,17): error CS0246: The type or namespace name `IMobileServiceTable' could not be found. Are you missing an assembly reference?"
			},
			{ "Azure/NotificationHubs/Android/XamarinTodoQuickStart.Android.sln", "Contains android project(s) (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Azure/NotificationHubs/Android/XamarinTodoQuickStart.Android.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Azure/NotificationHubs/iOS/NotificationHubQuickStart.sln",
				@"build fails with:
	AppDelegate.cs(6,7): error CS0246: The type or namespace name `WindowsAzure' could not be found. Are you missing an assembly reference?
	AppDelegate.cs(16,17): error CS0246: The type or namespace name `SBNotificationHub' could not be found. Are you missing an assembly reference?"
			},
			{ "Azure/ValidateModifyData/Android/XamarinTodoQuickStart.Android.sln", "Contains android project(s) (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Azure/ValidateModifyData/Android/XamarinTodoQuickStart.Android.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Azure/ValidateModifyData/iOS/XamarinTodoQuickStart.iOS.sln",
				@"build fails with:
	TodoItem.cs(2,7): error CS0246: The type or namespace name `Newtonsoft' could not be found. Are you missing an assembly reference?
	TodoService.cs(5,17): error CS0234: The type or namespace name `WindowsAzure' does not exist in the namespace `Microsoft'. Are you missing an assembly reference?
	TodoService.cs (15,17): error CS0246: The type or namespace name `MobileServiceClient' could not be found. Are you missing an assembly reference?
	TodoService.cs(16,17): error CS0246: The type or namespace name `IMobileServiceTable' could not be found. Are you missing an assembly reference?"
			},
			{ "BackgroundLocationDemo/BackgroundLocationDemo.sln", "Contains android project(s) (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "BackgroundLocationDemo/location.Android/location.Droid.sln", "Contains android project(s) (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/BackgroundLocationDemo/location.Android/location.Droid.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "BluetoothLEExplorer/BluetoothLEExplorer.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "BluetoothLEExplorer/Components/mbprogresshud-0.8/samples/MBProgressHUDDemo/MBProgressHUDDemo.sln", "build error: /tmp/xamarin-macios-sample-builder/repositories/mobile-samples/BluetoothLEExplorer/Components/mbprogresshud-0.8/samples/MBProgressHUDDemo/MBProgressHUDDemo/MBProgressHUDDemo.csproj: error : Target named 'Build' not found in the project." },
			{ "BluetoothLEExplorer/Components/mbprogresshud-0.9.0/samples/MBProgressHUDDemo-classic/MBProgressHUDDemo-classic.sln", "XI/Classic, must be ported to XI/Unified" },
			{ "BluetoothLEExplorer/Components/mbprogresshud-0.9.0/samples/MBProgressHUDDemo/MBProgressHUDDemo.sln",
				@"build errors:
	AppDelegate.cs(400,24): error CS0115: `MBProgressHUDDemo.MyNSUrlConnectionDelegete.ReceivedResponse(Foundation.NSUrlConnection, Foundation.NSUrlResponse)' is marked as an override but no suitable method found to override
	AppDelegate.cs(407,24): error CS0115: `MBProgressHUDDemo.MyNSUrlConnectionDelegete.ReceivedData(Foundation.NSUrlConnection, Foundation.NSData)' is marked as an override but no suitable method found to override
	AppDelegate.cs(413,24): error CS0115: `MBProgressHUDDemo.MyNSUrlConnectionDelegete.FinishedLoading(Foundation.NSUrlConnection)' is marked as an override but no suitable method found to override"
			},
			{ "BouncingGame/BouncingGame.sln", "nuget restore failed: Unable to find version '1.7.1.0' of package 'CocosSharp'." },
			{ "CCAction/ActionProject.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "CCAudioEngine/CCAudioEngineSample.sln", "nuget restore: Unable to find version '1.7.1.0' of package 'CocosSharp'." },
			{ "CCDrawNode/CustomRendering.sln", "nuget restore failed: Unable to find version '1.5.0.1' of package 'CocosSharp.PCL.Shared'." },
			{ "CCRenderTexture/RenderTextureExample.sln", "nuget restore failed: Unable to find version '1.7.1.0' of package 'CocosSharp'." },
			{ "Camera/Camera.sln", "build error: MainViewController.cs(8,7): error CS0246: The type or namespace name `Xamarin' could not be found. Are you missing an assembly reference?" },
			{ "Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.Android.Samples/ContactsSample/ContactsSample.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.Android.Samples/ContactsSample/ContactsSample.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.Android.Samples/GeolocationSample/GeolocationSample.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.Android.Samples/GeolocationSample/GeolocationSample.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.Android.Samples/MediaPickerSample/MediaPickerSample.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.Android.Samples/MediaPickerSample/MediaPickerSample.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.Android.Samples/Xamarin.Mobile.Android.Samples.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.Android.Samples/Xamarin.Mobile.Android.Samples.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.WP.Samples/Xamarin.Mobile.WP.Samples.sln", "wp (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.WP.Samples/Xamarin.Mobile.WP.Samples.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.WP8.Samples/Xamarin.Mobile.WP8.Samples.sln", "wp8 (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.WP8.Samples/Xamarin.Mobile.WP8.Samples.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.WinRT.Samples/Xamarin.Mobile.WinRT.Samples.sln", "winrt (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.WinRT.Samples/Xamarin.Mobile.WinRT.Samples.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.iOS.Samples/Xamarin.Mobile.iOS.Samples.sln", "XI/Classic, must be ported to XI/Unified" },
			{ "Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.iOS.Samples/Geolocation/GeolocationSample.sln", "build error: /tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.iOS.Samples/Geolocation/GeolocationSample.sln: error : Could not find the project file '/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Camera/Components/xamarin.mobile-0.6.3/samples/Xamarin.Mobile.iOS.Samples/Geolocation/GeolocationSample.csproj'" },
			{ "CameraMovement3DMG/MonoGame3D.sln",
				@"nuget restore failed:
	Unable to find version '3.5.1.1679' of package 'MonoGame.Framework.iOS'.
	Unable to find version '3.3.0.0' of package 'MonoGame.Framework.Android'."
			},
			{ "CoinTime/CoinTime.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "ContentControls/AndroidContentControls/AndroidContentControls.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/ContentControls/AndroidContentControls/AndroidContentControls.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "ContentControls/ContentControls.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "DataAccess/Advanced/DataAccess_Adv.sln",
				@"nuget restore failed:
	Unable to find version '1.1.1' of package 'sqlite-net-pcl'.
	Unable to find version '0.8.6' of package 'SQLitePCL.raw'."
			},
			{ "DataAccess/Basic/DataAccess_Basic.sln",
				@"nuget restore failed:
	Unable to find version '1.1.1' of package 'sqlite-net-pcl'.
	Unable to find version '0.8.6' of package 'SQLitePCL.raw'."
			},
			{ "DataAccess/Basic/iOS/DataAccess_Basic.sln",
				@"nuget restore failed:
	Unable to find version '1.1.1' of package 'sqlite-net-pcl'.
	Unable to find version '0.8.6' of package 'SQLitePCL.raw'."
			},
			{ "EmbeddedResources/EmbeddedResources.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "FruityFalls/FruityFalls.sln", "nuget restore failed: Unable to find version '1.7.1.0' of package 'CocosSharp'." },
			{ "GLKeysES30/GLKeysES30.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "ModelRenderingMG/MonoGame3D.sln",
				@"nuget restore failed:
	Unable to find version '3.5.1.1679' of package 'MonoGame.Framework.iOS'.
	Unable to find version '3.3.0.0' of package 'MonoGame.Framework.Android'."
			},
			{ "ModelsAndVertsMG/MonoGame3D.sln",
				@"nuget restore failed:
	Unable to find version '3.5.1.1679' of package 'MonoGame.Framework.iOS'.
	Unable to find version '3.3.0.0' of package 'MonoGame.Framework.Android'."
			},
			{ "MonoGameTvOs/MonoGameTvOs.sln", "build failure: MTOUCH: error MT4116: Could not register the assembly 'MonoGameTvOs': error MT4118: Cannot register two managed types ('MonoGameTvOs.AppDelegate, MonoGameTvOs' and 'MonoGameTvOs.Application, MonoGameTvOs') with the same native name ('AppDelegate')." },
			{ "MultiThreading/MultiThreading.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "Notifications/Notifications.sln", @"nuget restore failed: Unable to find version '20.0.0.4' of package 'Xamarin.Android.Support.v4'." },
			{ "Phoneword/Phoneword.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "Phoneword/Phoneword_Android.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Phoneword/Phoneword_Android.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Phoneword/Phoneword_Cmd.sln", "? (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Phoneword/Phoneword_Cmd.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Phoneword/Phoneword_Win8.sln", "win8 (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Phoneword/Phoneword_Win8.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "Phoneword/Phoneword_WP7.sln", "android (!?) (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "Profiling/AndroidAsyncImage/AsyncImageAndroid.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/Profiling/AndroidAsyncImage/AsyncImageAndroid.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "RazorTodo/RazorNativeTodo/RazorNativeTodo.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "RazorTodo/RazorTodo/RazorTodo.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "SharingCode/NativeShared.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "SoMA/SoMA.sln",
				@"build errors:
	SoMAViewController.cs(5,7): error CS0246: The type or namespace name `Xamarin' could not be found. Are you missing an assembly reference?
	PhotoScreen.cs(11,7): error CS0246: The type or namespace name `Xamarin' could not be found. Are you missing an assembly reference?
	PhotoScreen.cs(12,7): error CS0246: The type or namespace name `Xamarin' could not be found. Are you missing an assembly reference?
	PhotoScreen.cs(13,7): error CS0246: The type or namespace name `Xamarin' could not be found. Are you missing an assembly reference?
	PhotoScreen.cs(14,7): error CS0246: The type or namespace name `Xamarin' could not be found. Are you missing an assembly reference?
	../Core/ShareItem.cs(2,7): error CS0246: The type or namespace name `SQLite' could not be found. Are you missing an assembly reference?
	../Core/SomaDatabase.cs(2,7): error CS0246: The type or namespace name `SQLite' could not be found. Are you missing an assembly reference?
	../Core/SomaDatabase.cs(13,30): error CS0246: The type or namespace name `SQLiteConnection' could not be found. Are you missing an assembly reference?
	PhotoScreen.cs(19,3): error CS0246: The type or namespace name `MediaPickerController' could not be found. Are you missing an assembly reference?
	PhotoScreen.cs(184,15): error CS0246: The type or namespace name `Service' could not be found. Are you missing an assembly reference?"
			},
			{ "SoMA/SoMA_VisualStudio.sln", "XI/Classic, must be ported to XI/Unified" },
			{ "SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.Android.Samples/ContactsSample/ContactsSample.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.Android.Samples/ContactsSample/ContactsSample.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.Android.Samples/GeolocationSample/GeolocationSample.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.Android.Samples/GeolocationSample/GeolocationSample.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.Android.Samples/MediaPickerSample/MediaPickerSample.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.Android.Samples/MediaPickerSample/MediaPickerSample.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.Android.Samples/Xamarin.Mobile.Android.Samples.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.Android.Samples/Xamarin.Mobile.Android.Samples.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.WP.Samples/Xamarin.Mobile.WP.Samples.sln", "windows phone (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.WP.Samples/Xamarin.Mobile.WP.Samples.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.WP8.Samples/Xamarin.Mobile.WP8.Samples.sln", "win8 (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.WP8.Samples/Xamarin.Mobile.WP8.Samples.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.WinRT.Samples/Xamarin.Mobile.WinRT.Samples.sln", "winrt (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.WinRT.Samples/Xamarin.Mobile.WinRT.Samples.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "SoMA/iOS/Components/xamarin.mobile-0.6.2.1/samples/Xamarin.Mobile.iOS.Samples/Xamarin.Mobile.iOS.Samples.sln", "XI/Classic, must be ported to XI/Unified" },
			{ "SoMA/iOS/Components/xamarin.social-1.0.1/samples/Xamarin.Social.Sample.Android/Xamarin.Social.Sample.Android.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/SoMA/iOS/Components/xamarin.social-1.0.1/samples/Xamarin.Social.Sample.Android/Xamarin.Social.Sample.Android.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "SoMA/iOS/Components/xamarin.social-1.0.1/samples/Xamarin.Social.Sample.iOS/Xamarin.Social.Sample.iOS.sln", "XI/Classic, must be ported to XI/Unified" },
			{ "SpriteSheetDemo/SpriteSheetDemo.sln",
				@"nuget restore failed:
	Unable to find version '1.7.0.0-pre1' of package 'CocosSharp'.
	Unable to find version '1.7.0.0-pre1' of package 'CocosSharp.Forms'.
	Unable to find version '1.5.1.6471' of package 'Xamarin.Forms'.
	Unable to find version '2.0.0.6490' of package 'Xamarin.Forms'.
	Unable to find version '23.0.1.3' of package 'Xamarin.Android.Support.Design'.
	Unable to find version '23.0.1.3' of package 'Xamarin.Android.Support.v4'.
	Unable to find version '23.0.1.3' of package 'Xamarin.Android.Support.v7.AppCompat'.
	Unable to find version '23.0.1.3' of package 'Xamarin.Android.Support.v7.CardView'.
	Unable to find version '23.0.1.3' of package 'Xamarin.Android.Support.v7.MediaRouter'."
			},
			{ "StandardControls/AndroidStandardControls/AndroidStandardControls.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/StandardControls/AndroidStandardControls/AndroidStandardControls.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "TablesLists/AndroidListView/AndroidListView.sln", "android (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/TablesLists/AndroidListView/AndroidListView.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "TablesLists/TablesLists.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "Tasky/Tasky.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "TaskyPortable/TaskyPortable.sln",
				@"nuget restore failed:
	Unable to find version '1.0.11' of package 'sqlite-net-pcl'.
	Unable to find version '0.8.4' of package 'SQLitePCL.raw_basic'.
	Unable to find version '0.7.1' of package 'SQLitePCL.raw_basic'."
			},
			{ "TaskyPro/Tasky.Win8(deprecated)/TaskyWin8.sln", "win8 (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/TaskyPro/Tasky.Win8(deprecated)/TaskyWin8.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "TaskyPro/Tasky.Win81/TaskyWin8.sln", "win8 (/tmp/xamarin-macios-sample-builder/repositories/mobile-samples/TaskyPro/Tasky.Win81/TaskyWin8.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\".)" },
			{ "TaskyPro/TaskyPro.sln",
				@"nuget restore failed:
	Unable to find version '1.0.11' of package 'sqlite-net-pcl'.
	Unable to find version '0.7.1' of package 'SQLitePCL.raw_basic'."
			},
			{ "TexturedCubeES30/TexturedCube.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "TipCalc/TipCalc.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "Touch/Touch.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "VisualBasic/TaskyPortableVB/TaskyPortableVB.sln", "build error: /tmp/xamarin-macios-sample-builder/repositories/mobile-samples/VisualBasic/TaskyPortableVB/TaskyiOS/TaskyiOS.csproj: error : Target named 'Build' not found in the project." },
			{ "VisualBasic/TaskyPortableVB/TaskyPortableVisualBasicLibrary/TaskyPortableVisualBasicLibrary.sln", "build error: /tmp/xamarin-macios-sample-builder/repositories/mobile-samples/VisualBasic/TaskyPortableVB/TaskyPortableVisualBasicLibrary/TaskyPortableVisualBasicLibrary.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\"." },
			{ "VisualBasic/XamarinFormsVB/XamarinFormsVB.sln",
				@"nuget restore failed:
	Unable to find version '1.4.4.6392' of package 'Xamarin.Forms'.
	Unable to find version '22.2.1.0' of package 'Xamarin.Android.Support.v4'."
			},
			{ "WCF-Walkthrough/HelloWorld/HelloWorld.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "WalkingGameMG/WalkingGame.sln",
				@"nuget restore failed:
	Unable to find version '3.5.1.1679' of package 'MonoGame.Framework.iOS'.
	Unable to find version '3.5.1.1679' of package 'MonoGame.Framework.Android'."
			},
			{ "Weather/WeatherApp.sln",
				@"nuget restore failed:
	Unable to find version '1.1.10' of package 'Microsoft.Bcl'.
	Unable to find version '1.0.14' of package 'Microsoft.Bcl.Build'.
	Unable to find version '2.2.29' of package 'Microsoft.Net.Http'."
			},
			{ "WebServices/HelloWorld/HelloWorld.sln", "android (error XA5205: The Android SDK Directory could not be found. Please set via /p:AndroidSdkDirectory.)" },
			{ "WebServices/WebServiceSamples/RestSample/RestSample.sln", "build fails with: /tmp/xamarin-macios-sample-builder/repositories/mobile-samples/WebServices/WebServiceSamples/RestSample/RestSample.sln: error : Invalid solution configuration and platform: \"Debug|iPhone\"." },
			{ "WebServices/WebServiceSamples/WebServices.RxNorm/src/WebServices.RxNormSample.sln", "XI/Classic. Must be ported to XI/Unified." },
			{ "XamarinInsights/Android/XamarinInsightsAndroid.sln", "nuget restore failed: Unable to find version '1.10.4.112' of package 'Xamarin.Insights'." },
			{ "XamarinInsights/iOS/XamarinInsightsiOS.sln", "nuget restore failed: Unable to find version '1.10.4.112' of package 'Xamarin.Insights'." },
		};
	}
}
