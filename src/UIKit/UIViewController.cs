// 
// UIViewController.cs: Implements some nicer methods for UIViewController
//
// Authors:
//   Miguel de Icaza.
//     
// Copyright 2009 Novell, Inc
// Copyright 2013 Xamarin Inc. (http://xamarin.com)
//

#if !WATCH

using System;
using System.Collections;
using System.Collections.Generic;
using Foundation;
#if HAS_IAD && !NET
using iAd;
#endif
using ObjCRuntime;
using CoreGraphics;

// Disable until we get around to enable + fix any issues.
#nullable disable

namespace UIKit {
	public partial class UIViewController : IEnumerable {

		// https://bugzilla.xamarin.com/show_bug.cgi?id=3189
		static Stack<UIViewController> modal;

		static void PushModal (UIViewController controller)
		{
			if (modal is null)
				modal = new Stack<UIViewController> ();
			modal.Push (controller);
		}

		// DismissModalViewControllerAnimated can be called on on any controller in the hierarchy
		// note: if you dismiss something that is not in the hierarchy then you remove references to everything :(
		static void PopModal (UIViewController controller)
		{
			// handle the dismiss from the presenter
			// https://bugzilla.xamarin.com/show_bug.cgi?id=3489#c2
			if (modal is null || (modal.Count == 0))
				return;

			UIViewController pop = modal.Pop ();
			while (pop != controller && (modal.Count > 0)) {
				pop = modal.Pop ();
			}
		}

		public void Add (UIView view)
		{
			View.AddSubview (view);
		}

		public IEnumerator GetEnumerator ()
		{
			UIView [] subviews = View.Subviews;
			if (subviews is null)
				yield break;
			foreach (UIView uiv in subviews)
				yield return uiv;
		}

#if HAS_IAD && !NET
		// This is a [Category] -> C# extension method (see adlib.cs) but it targets on static selector
		// the resulting syntax does not look good in user code so we provide a better looking API
		// https://trello.com/c/iQpXOxCd/227-category-and-static-methods-selectors
		// note: we cannot reuse the same method name - as it would break compilation of existing apps
		[Obsoleted (PlatformName.iOS, 15,0, PlatformArchitecture.None, Constants.iAdRemoved)]
		static public void PrepareForInterstitialAds ()
		{
		}
#endif

#region Inlined from the UITraitChangeObservable protocol
		/// <summary>
		/// Registers a callback handler that will be executed when one of the specified traits changes.
		/// </summary>
		/// <param name="traits">The traits to observe.</param>
		/// <param name="handler">The callback to execute when any of the specified traits changes.</param>
		/// <returns>A token that can be used to unregister the callback by calling <see cref="M:UnregisterForTraitChanges" />.</returns>
		public IUITraitChangeRegistration RegisterForTraitChanges (Type [] traits, Action<IUITraitEnvironment, UITraitCollection> handler)
		{
			return base (IUITraitChangeObservable).RegisterForTraitChanges (traits, handler);
		}

		/// <summary>
		/// Registers a callback handler that will be executed when one of the specified traits changes.
		/// </summary>
		/// <param name="traits">The traits to observe.</param>
		/// <param name="handler">The callback to execute when any of the specified traits changes.</param>
		/// <returns>A token that can be used to unregister the callback by calling <see cref="M:UnregisterForTraitChanges" />.</returns>
		public unsafe IUITraitChangeRegistration RegisterForTraitChanges (Action<IUITraitEnvironment, UITraitCollection> handler, params Type [] traits)
		{
			// Add an override with 'params', unfortunately this means reordering the parameters.
			return base (IUITraitChangeObservable).RegisterForTraitChanges (handler, traits);
		}

		/// <summary>
		/// Registers a callback handler that will be executed when the specified trait changes.
		/// </summary>
		/// <typeparam name="T">The trait to observe.</typeparam>
		/// <param name="handler">The callback to execute when any of the specified traits changes.</param>
		/// <returns>A token that can be used to unregister the callback by calling <see cref="M:UnregisterForTraitChanges" />.</returns>
		public unsafe IUITraitChangeRegistration RegisterForTraitChanges<T> (Action<IUITraitEnvironment, UITraitCollection> handler)
			where T : IUITraitDefinition
		{
			return base (IUITraitChangeObservable).RegisterForTraitChanges<T> (handler);
		}

		/// <summary>
		/// Registers a callback handler that will be executed when any of the specified traits changes.
		/// </summary>
		/// <typeparam name="T1">A trait to observe</typeparam>
		/// <typeparam name="T2">A trait to observe</typeparam>
		/// <param name="handler">The callback to execute when any of the specified traits changes.</param>
		/// <returns>A token that can be used to unregister the callback by calling <see cref="M:UnregisterForTraitChanges" />.</returns>
		public unsafe IUITraitChangeRegistration RegisterForTraitChanges<T1, T2> (Action<IUITraitEnvironment, UITraitCollection> handler)
			where T1 : IUITraitDefinition
			where T2 : IUITraitDefinition
		{
			return base (IUITraitChangeObservable).RegisterForTraitChanges<T1, T2> (handler);
		}

		/// <summary>
		/// Registers a callback handler that will be executed when any of the specified traits changes.
		/// </summary>
		/// <typeparam name="T1">A trait to observe</typeparam>
		/// <typeparam name="T2">A trait to observe</typeparam>
		/// <typeparam name="T3">A trait to observe</typeparam>
		/// <param name="handler">The callback to execute when any of the specified traits changes.</param>
		/// <returns>A token that can be used to unregister the callback by calling <see cref="M:UnregisterForTraitChanges" />.</returns>
		public unsafe IUITraitChangeRegistration RegisterForTraitChanges<T1, T2, T3> (Action<IUITraitEnvironment, UITraitCollection> handler)
			where T1 : IUITraitDefinition
			where T2 : IUITraitDefinition
			where T3 : IUITraitDefinition
		{
			return base (IUITraitChangeObservable).RegisterForTraitChanges<T1, T2, T3> (handler);
		}

		/// <summary>
		/// Registers a callback handler that will be executed when any of the specified traits changes.
		/// </summary>
		/// <typeparam name="T1">A trait to observe</typeparam>
		/// <typeparam name="T2">A trait to observe</typeparam>
		/// <typeparam name="T3">A trait to observe</typeparam>
		/// <typeparam name="T4">A trait to observe</typeparam>
		/// <param name="handler">The callback to execute when any of the specified traits changes.</param>
		/// <returns>A token that can be used to unregister the callback by calling <see cref="M:UnregisterForTraitChanges" />.</returns>
		public unsafe IUITraitChangeRegistration RegisterForTraitChanges<T1, T2, T3, T4> (Action<IUITraitEnvironment, UITraitCollection> handler)
			where T1 : IUITraitDefinition
			where T2 : IUITraitDefinition
			where T3 : IUITraitDefinition
			where T4 : IUITraitDefinition
		{
			return base (IUITraitChangeObservable).RegisterForTraitChanges<T1, T2, T3, T4> (handler);
		}

		/// <summary>
		/// Registers a selector that will be called on the specified object when any of the specified traits changes.
		/// </summary>
		/// <param name="traits">The traits to observe.</param>
		/// <param name="target">The object whose specified selector will be called.</param>
		/// <param name="action">The selector to call on the specified object.</param>
		/// <returns>A token that can be used to unregister the callback by calling <see cref="M:UnregisterForTraitChanges" />.</returns>
		public IUITraitChangeRegistration RegisterForTraitChanges (Type [] traits, NSObject target, Selector action)
		{
			return base (IUITraitChangeObservable).RegisterForTraitChanges (traits, target, action);
		}

		/// <summary>
		/// Registers a selector that will be called on the current object when any of the specified traits changes.
		/// </summary>
		/// <param name="traits">The traits to observe.</param>
		/// <param name="action">The selector to call on the current object.</param>
		/// <returns>A token that can be used to unregister the callback by calling <see cref="M:UnregisterForTraitChanges" />.</returns>
		public IUITraitChangeRegistration RegisterForTraitChanges (Type [] traits, Selector action)
		{
			return base (IUITraitChangeObservable).RegisterForTraitChanges (traits, action);
		}

#if !XAMCORE_5_0 && NET
		/// <summary>
		/// Registers a selector that will be called on the specified object when any of the specified traits changes.
		/// </summary>
		/// <param name="traits">The traits to observe.</param>
		/// <param name="handler">The callback to execute when any of the specified traits changes.</param>
		/// <returns>A token that can be used to unregister the callback by calling <see cref="M:UnregisterForTraitChanges" />.</returns>
		[BindingImpl (BindingImplOptions.Optimizable)]
		public IUITraitChangeRegistration RegisterForTraitChanges (Class [] traits, [BlockProxy (typeof (ObjCRuntime.Trampolines.IUITraitChangeObservable_RegisterForTraitChanges_NIDAction))] global::System.Action<IUITraitEnvironment, UITraitCollection> handler)
		{
			return base (IUITraitChangeObservable).RegisterForTraitChanges (traits, handler);
		}

		/// <summary>
		/// Registers a selector that will be called on the specified object when any of the specified traits changes.
		/// </summary>
		/// <param name="traits">The traits to observe.</param>
		/// <param name="target">The object whose specified selector will be called.</param>
		/// <param name="action">The selector to call on the specified object.</param>
		/// <returns>A token that can be used to unregister the callback by calling <see cref="M:UnregisterForTraitChanges" />.</returns>
		[BindingImpl (BindingImplOptions.Optimizable)]
		public IUITraitChangeRegistration RegisterForTraitChanges (Class [] traits, NSObject target, Selector action)
		{
			return base (IUITraitChangeObservable).RegisterForTraitChanges (traits, target, action);
		}

		/// <summary>
		/// Registers a selector that will be called on the specified object when any of the specified traits changes.
		/// </summary>
		/// <param name="traits">The traits to observe.</param>
		/// <param name="action">The selector to call on the current object.</param>
		/// <returns>A token that can be used to unregister the callback by calling <see cref="M:UnregisterForTraitChanges" />.</returns>
		[BindingImpl (BindingImplOptions.Optimizable)]
		public IUITraitChangeRegistration RegisterForTraitChanges (Class [] traits, Selector action)
		{
			return base (IUITraitChangeObservable).RegisterForTraitChanges (traits, action);
		}
#endif // !XAMCORE_5_0
#endregion
	}
}

#endif // !WATCH
