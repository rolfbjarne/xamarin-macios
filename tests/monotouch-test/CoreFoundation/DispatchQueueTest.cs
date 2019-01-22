﻿//
// Unit tests for DispatchQueue
//
// Authors:
//	Rolf Bjarne Kvinge <rolf@xamarin.com>
//
// Copyright 2018 Microsoft Corp. All rights reserved.
//

using System;
using System.IO;
#if XAMCORE_2_0
using CoreFoundation;
using Foundation;
using ObjCRuntime;
#if MONOMAC
using AppKit;
#else
using UIKit;
#endif
#else
using MonoTouch.CoreFoundation;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
#endif
using NUnit.Framework;
using System.Drawing;
using System.Threading;

#if XAMCORE_2_0
using RectangleF = CoreGraphics.CGRect;
using SizeF = CoreGraphics.CGSize;
using PointF = CoreGraphics.CGPoint;
#else
using nfloat=global::System.Single;
using nint=global::System.Int32;
using nuint=global::System.UInt32;
#endif

namespace MonoTouchFixtures.CoreFoundation
{

	[TestFixture]
	[Preserve(AllMembers = true)]
	public class DispatchQueueTests
	{
		[Test]
		public void CtorWithAttributes ()
		{
			TestRuntime.AssertXcodeVersion (8, 0);

			using (var queue = new DispatchQueue ("1", new DispatchQueue.Attributes
			{
				AutoreleaseFrequency = DispatchQueue.AutoreleaseFrequency.Inherit,
			}))
			{
				Assert.AreNotEqual (IntPtr.Zero, queue.Handle, "Handle 1");
			}

			using (var queue = new DispatchQueue ("2", new DispatchQueue.Attributes
			{
				IsInitiallyInactive = true,
			}))
			{
				queue.Activate (); // must activate the queue before it can be released according to Apple's documentation
				Assert.AreNotEqual (IntPtr.Zero, queue.Handle, "Handle 2");
			}

			using (var queue = new DispatchQueue ("3", new DispatchQueue.Attributes
			{
				QualityOfService = DispatchQualityOfService.Utility,
			}))
			{
				Assert.AreNotEqual (IntPtr.Zero, queue.Handle, "Handle 3");
				Assert.AreEqual (DispatchQualityOfService.Utility, queue.QualityOfService, "QualityOfService 3");
			}

			using (var target_queue = new DispatchQueue ("4 - target")) {
				using (var queue = new DispatchQueue ("4", new DispatchQueue.Attributes
				{
					QualityOfService = DispatchQualityOfService.Background,
					AutoreleaseFrequency = DispatchQueue.AutoreleaseFrequency.WorkItem,
					RelativePriority = -1,
				}, target_queue))
				{
					Assert.AreNotEqual (IntPtr.Zero, queue.Handle, "Handle 4");
					Assert.AreEqual (DispatchQualityOfService.Background, queue.GetQualityOfService (out var relative_priority), "QualityOfService 4");
					Assert.AreEqual (-1, relative_priority, "RelativePriority 4");
				}
			}
		}

		[Test]
		public void Specific ()
		{
			using (var queue = new DispatchQueue ("Specific"))
			{
				var key = (IntPtr) 0x31415926;
				queue.SetSpecific (key, "hello world");
				Assert.AreEqual ("hello world", queue.GetSpecific (key), "Key");
			}
		}

		[Test]
		public void DispatchSync ()
		{
			TestRuntime.AssertSystemVersion (PlatformName.iOS, 8, 0, throwIfOtherPlatform: false);
			TestRuntime.AssertSystemVersion (PlatformName.MacOSX, 10, 10, throwIfOtherPlatform: false);

			using (var queue = new DispatchQueue ("DispatchSync")) {
				var called = false;
				var callback = new Action (() => called = true);
				queue.DispatchSync (callback);
				Assert.IsTrue (called, "Called");

				called = false;
				using (var dg = new DispatchBlock (callback))
					queue.DispatchSync (dg);
				Assert.IsTrue (called, "Called DispatchBlock");
			}
		}

		[Test]
		public void DispatchBarrierSync ()
		{
			TestRuntime.AssertSystemVersion (PlatformName.iOS, 8, 0, throwIfOtherPlatform: false);
			TestRuntime.AssertSystemVersion (PlatformName.MacOSX, 10, 10, throwIfOtherPlatform: false);

			using (var queue = new DispatchQueue ("DispatchBarrierSync")) {
				var called = false;
				var callback = new Action (() => called = true);
				queue.DispatchBarrierSync (callback);
				Assert.IsTrue (called, "Called");

				called = false;
				using (var dg = new DispatchBlock (callback))
					queue.DispatchBarrierSync (dg);
				Assert.IsTrue (called, "Called DispatchBlock");
			}
		}

		[Test]
		public void DispatchAsync ()
		{
			TestRuntime.AssertSystemVersion (PlatformName.iOS, 8, 0, throwIfOtherPlatform: false);
			TestRuntime.AssertSystemVersion (PlatformName.MacOSX, 10, 10, throwIfOtherPlatform: false);

			using (var queue = new DispatchQueue ("DispatchAsync")) {
				var called = false;
				var callback = new Action (() => called = true);
				queue.DispatchAsync (callback);
				TestRuntime.RunAsync (TimeSpan.FromSeconds (5), () => { }, () => called);
				Assert.IsTrue (called, "Called");

				called = false;
				using (var dg = new DispatchBlock (callback)) {
					queue.DispatchAsync (dg);
					dg.Wait (TimeSpan.FromSeconds (5));
				}
				Assert.IsTrue (called, "Called DispatchBlock");
			}
		}

		[Test]
		public void DispatchBarrierAsync ()
		{
			TestRuntime.AssertSystemVersion (PlatformName.iOS, 8, 0, throwIfOtherPlatform: false);
			TestRuntime.AssertSystemVersion (PlatformName.MacOSX, 10, 10, throwIfOtherPlatform: false);

			using (var queue = new DispatchQueue ("DispatchBarrierAsync")) {
				var called = false;
				var callback = new Action (() => called = true);
				queue.DispatchBarrierAsync (callback);
				TestRuntime.RunAsync (TimeSpan.FromSeconds (5), () => { }, () => called);
				Assert.IsTrue (called, "Called");

				called = false;
				using (var dg = new DispatchBlock (callback)) {
					queue.DispatchBarrierAsync (dg);
					dg.Wait (TimeSpan.FromSeconds (5));
				}
				Assert.IsTrue (called, "Called DispatchBlock");
			}
		}

		[Test]
		public void MainQueue ()
		{
			Assert.AreEqual (DispatchQueue.CurrentQueue, DispatchQueue.MainQueue, "MainQueue");
		}
	}
}
