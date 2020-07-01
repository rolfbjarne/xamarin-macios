// Copyright 2016 Xamarin Inc. All rights reserved

#if !__TVOS__ && !__WATCHOS__ && !MONOMAC

using System;
using System.Drawing;
using System.IO;
using Foundation;
using MediaPlayer;
using ObjCRuntime;
using UIKit;
using NUnit.Framework;

namespace MonoTouchFixtures.MediaPlayer
{

	[TestFixture]
	[Preserve (AllMembers = true)]
	public class NowPlayingInfoCenterTest
	{
		MPNowPlayingInfo NowPlayingInfo;

		bool v8_0 = TestRuntime.CheckSystemVersion (PlatformName.iOS, 8, 0);
		bool v9_0 = TestRuntime.CheckSystemVersion (PlatformName.iOS, 9, 0);
		bool v10_0 = TestRuntime.CheckSystemVersion (PlatformName.iOS, 10, 0);
		bool v10_3 = TestRuntime.CheckSystemVersion (PlatformName.iOS, 10, 3);

		[SetUp]
		public void SetUp ()
		{
			MPNowPlayingInfoLanguageOption languageOption = null;
			MPNowPlayingInfoLanguageOptionGroup languageOptionGroup = null;
			if (v9_0) {
				languageOption = new MPNowPlayingInfoLanguageOption (MPNowPlayingInfoLanguageOptionType.Audible, "en", null, "English", "en");
				languageOptionGroup = new MPNowPlayingInfoLanguageOptionGroup (new MPNowPlayingInfoLanguageOption [] { languageOption }, languageOption, false);
			}
			string file = Path.Combine (NSBundle.MainBundle.ResourcePath, "basn3p08.png");
			using (var img = UIImage.FromFile (file)) {
				NowPlayingInfo = new MPNowPlayingInfo {
					//MPNowPlayingInfoCenter
					ElapsedPlaybackTime = 1.0,
					PlaybackRate = 1.0,
					DefaultPlaybackRate = 1.0,
					PlaybackQueueIndex = 0,
					PlaybackQueueCount = 10,
					ChapterNumber = 1,
					ChapterCount = 10,
					AvailableLanguageOptions = v9_0 ? new MPNowPlayingInfoLanguageOptionGroup [] { languageOptionGroup } : null,
					CurrentLanguageOptions = v9_0 ? new MPNowPlayingInfoLanguageOption [] { new MPNowPlayingInfoLanguageOption (MPNowPlayingInfoLanguageOptionType.Audible, "en", null, "English", "en") } : null,
					CollectionIdentifier = "Collection",
					ExternalContentIdentifier = "ExternalContent",
					ExternalUserProfileIdentifier = "ExternalUserProfile",
					PlaybackProgress = 0.5f,
					MediaType = MPNowPlayingInfoMediaType.Audio,
					IsLiveStream = false,
					AssetUrl = new NSUrl ("https://developer.xamarin.com"),

					//MPMediaItem
					AlbumTitle = "AlbumTitle",
					AlbumTrackCount = 13,
					AlbumTrackNumber = 1,
					Artist = "Artist",
					Artwork = new MPMediaItemArtwork (img),
					Composer = "Composer",
					DiscCount = 1,
					DiscNumber = 1,
					Genre = "Genre",
					PersistentID = 1,
					PlaybackDuration = 100.0,
					Title = "Title",
				};
			}
		}

		[Test]
		public void NowPlaying ()
		{
			using (var dc = MPNowPlayingInfoCenter.DefaultCenter) {
				dc.NowPlaying = NowPlayingInfo; // internal NSDictionary ToDictionary ()
				var np = dc.NowPlaying; // internal MPNowPlayingInfo (NSDictionary source)

				Asserts.IsInstanceOfType (typeof (double), np.ElapsedPlaybackTime, "#1");
				Asserts.IsInstanceOfType (typeof (double), np.PlaybackRate, "#2");
				if (v8_0)
					Asserts.IsInstanceOfType (typeof (double), np.DefaultPlaybackRate, "#3");
				Asserts.IsInstanceOfType (typeof (int), np.PlaybackQueueIndex, "#4");
				Asserts.IsInstanceOfType (typeof (int), np.PlaybackQueueCount, "#5");
				Asserts.IsInstanceOfType (typeof (int), np.ChapterNumber, "#6");
				Asserts.IsInstanceOfType (typeof (int), np.ChapterCount, "#7");

				if (v9_0) {
					Asserts.IsInstanceOfType (typeof (MPNowPlayingInfoLanguageOptionGroup []), np.AvailableLanguageOptions, "#8");
					Asserts.IsInstanceOfType (typeof (MPNowPlayingInfoLanguageOption []), np.CurrentLanguageOptions, "#9");
				}
				if (v10_0) {
					Asserts.IsInstanceOfType (typeof (string), (object)np.CollectionIdentifier, "#10");
					Asserts.IsInstanceOfType (typeof (string), (object)np.ExternalContentIdentifier, "#11");
					Asserts.IsInstanceOfType (typeof (string), (object)np.ExternalUserProfileIdentifier, "#12");
					Asserts.IsInstanceOfType (typeof (float), np.PlaybackProgress, "#13");
					Asserts.IsInstanceOfType (typeof (MPNowPlayingInfoMediaType), np.MediaType, "#14");
					Asserts.IsInstanceOfType (typeof (bool), np.IsLiveStream, "#15");
				}

				Asserts.IsInstanceOfType (typeof (string), (object)np.AlbumTitle, "#16");
				Asserts.IsInstanceOfType (typeof (int), np.AlbumTrackCount, "#17");
				Asserts.IsInstanceOfType (typeof (int), np.AlbumTrackNumber, "#18");
				Asserts.IsInstanceOfType (typeof (string), (object)np.Artist, "#19");
				Asserts.IsInstanceOfType (typeof (MPMediaItemArtwork), np.Artwork, "#20");
				Asserts.IsInstanceOfType (typeof (string), (object)np.Composer, "#21");
				Asserts.IsInstanceOfType (typeof (int), np.DiscCount, "#22");
				Asserts.IsInstanceOfType (typeof (int), np.DiscNumber, "#23");
				Asserts.IsInstanceOfType (typeof (string), (object)np.Genre, "#24");
				Asserts.IsInstanceOfType (typeof (ulong), np.PersistentID, "#25");
				Asserts.IsInstanceOfType (typeof (double), np.PlaybackDuration, "#26");
				Asserts.IsInstanceOfType (typeof (string), (object)np.Title, "#27");

				if (v10_3)
					Asserts.IsInstanceOfType (typeof (NSUrl), np.AssetUrl, "#28");
			}
		}
	}
}

#endif // !__TVOS__ && !__WATCHOS__
