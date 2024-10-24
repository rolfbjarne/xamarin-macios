﻿using System;
using System.Diagnostics;

using Darwin;

using NUnit.Framework;

namespace apitest
{
	[TestFixture]
	public class KernelNotificationTest
	{
		KernelEvent [] CreateEvents (Process process)
		{
			return new KernelEvent [] {
				new KernelEvent {
					Ident = (IntPtr) process.Id,
					Filter = EventFilter.Proc,
					Flags = EventFlags.Add,
					FilterFlags = (uint) (FilterFlags.ProcExit),
				}
			};
		}

		[Test]
		public void KEvent ()
		{
			// (KernelEvent[], KernelEvent[])
			using (var sleep = Process.Start ("/bin/sleep", "0.5")) {
				using (var kqueue = new KernelQueue ()) {
					var events = CreateEvents (sleep);
					Assert.IsTrue (kqueue.KEvent (events, events), "kevent");
				}
			}

			// (KernelEvent[], KernelEvent[], TimeSpan?)
			using (var sleep = Process.Start ("/bin/sleep", "0.5")) {
				using (var kqueue = new KernelQueue ()) {
					var events = CreateEvents (sleep);
					Assert.AreEqual (1, kqueue.KEvent (events, events, TimeSpan.FromSeconds (5)), "kevent");
				}
			}

			// (KernelEvent[], KernelEvent[], TimeSpan?)
			using (var sleep = Process.Start ("/bin/sleep", "0.5")) {
				using (var kqueue = new KernelQueue ()) {
					var events = CreateEvents (sleep);
					Assert.AreEqual (1, kqueue.KEvent (events, events, null), "kevent");
				}
			}

			// (KernelEvent[], int, KernelEvent[], int, TimeSpec?)
			using (var sleep = Process.Start ("/bin/sleep", "0.5")) {
				using (var kqueue = new KernelQueue ()) {
					var events = CreateEvents (sleep);
					TimeSpec ts = new TimeSpec
					{
						Seconds = 5,
					};
					Assert.AreEqual (1, kqueue.KEvent (events, events.Length, events, events.Length, ts), "kevent");
				}
			}

			// (KernelEvent[], int, KernelEvent[], int, TimeSpec?)
			using (var sleep = Process.Start ("/bin/sleep", "0.5")) {
				using (var kqueue = new KernelQueue ()) {
					var events = CreateEvents (sleep);
					Assert.AreEqual (1, kqueue.KEvent (events, events.Length, events, events.Length, null), "kevent");
				}
			}

			// (KernelEvent[], int, KernelEvent[], int, ref TimeSpec)
			using (var sleep = Process.Start ("/bin/sleep", "0.5")) {
				using (var kqueue = new KernelQueue ()) {
					var events = CreateEvents (sleep);
					TimeSpec ts = new TimeSpec
					{
						Seconds = 5,
					};
					Assert.IsTrue (kqueue.KEvent (events, events.Length, events, events.Length, ref ts), "kevent");
				}
			}

			// (KernelEvent[], KernelEvent[], ref TimeSpec)
			using (var sleep = Process.Start ("/bin/sleep", "0.5")) {
				using (var kqueue = new KernelQueue ()) {
					var events = CreateEvents (sleep);
					TimeSpec ts = new TimeSpec
					{
						Seconds = 5,
					};
					Assert.IsTrue (kqueue.KEvent (events, events, ref ts), "kevent");
				}
			}

			// (KernelEvent[], int, KernelEvent[], int)
			using (var sleep = Process.Start ("/bin/sleep", "0.5")) {
				using (var kqueue = new KernelQueue ()) {
					var events = CreateEvents (sleep);
					Assert.IsTrue (kqueue.KEvent (events, events.Length, events, events.Length), "kevent");
				}
			}
		}

		[Test]
		public void KEventExceptions ()
		{
			using (var sleep = Process.Start ("/bin/sleep", "0")) {
				using (var kqueue = new KernelQueue ()) {
					var events = CreateEvents (sleep);
					var empty = new KernelEvent [0];

					Assert.Throws<ArgumentNullException> (() => kqueue.KEvent (null, events, null), "a1");
					Assert.Throws<ArgumentNullException> (() => kqueue.KEvent (events, null, null), "a2");
					Assert.Throws<ArgumentNullException> (() => kqueue.KEvent (null, null, null), "a3");
					Assert.Throws<ArgumentOutOfRangeException> (() => kqueue.KEvent (events, empty, null), "a4");
					Assert.Throws<ArgumentOutOfRangeException> (() => kqueue.KEvent (empty, events, null), "a5");

					Assert.Throws<ArgumentNullException> (() => kqueue.KEvent (null, 1, events, 1, null), "b1");
					Assert.Throws<ArgumentNullException> (() => kqueue.KEvent (events, 1, null, 1, null), "b2");
					Assert.Throws<ArgumentNullException> (() => kqueue.KEvent (null, 1, null, 1, null), "b3");
					Assert.Throws<ArgumentOutOfRangeException> (() => kqueue.KEvent (events, 1, empty, 1, null), "b4");
					Assert.Throws<ArgumentOutOfRangeException> (() => kqueue.KEvent (empty, 1, events, 1, null), "b5");
					Assert.Throws<ArgumentOutOfRangeException> (() => kqueue.KEvent (events, 1, events, 2, null), "b6");
					Assert.Throws<ArgumentOutOfRangeException> (() => kqueue.KEvent (events, 2, events, 1, null), "b7");
				}
			}
		}
	}
}
