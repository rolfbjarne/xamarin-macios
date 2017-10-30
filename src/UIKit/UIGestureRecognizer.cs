// 
// UIGestureRecognizer: Implements some helper methods for UIGestureRecognizer
//
// Authors:
//   Miguel de Icaza
//     
// Copyright 2010 Novell, Inc
// Copyright 2011-2013 Xamarin Inc. All rights reserved
//

#if !WATCH

using System;
using System.Collections;
using XamCore.Foundation; 
using XamCore.ObjCRuntime;
using XamCore.CoreGraphics;

namespace XamCore.UIKit {
	public partial class UIGestureRecognizer {
		object recognizers;
		const string tsel = "target";
		internal const string parametrized_selector = "target:";
#if !XAMCORE_2_0
		[Obsolete ("Don't use, this field has been removed the Unified API. Use 'Selector.GetHandle (<string>)' instead.")]
		public static Selector ParametrizedSelector = new Selector ("target:");
#endif
		[DesignatedInitializer]
		public UIGestureRecognizer (NSAction action) : this (Selector.GetHandle (tsel), new ParameterlessDispatch (action))
		{
		}

		//
		// Signature swapped, this is only used so we can store the "token" in recognizers
		//
		public UIGestureRecognizer (Selector sel, Token token) : this (token, sel)
		{
			recognizers = token;
			MarkDirty ();
		}

		internal UIGestureRecognizer (IntPtr sel, Token token) : this (token, sel)
		{
			recognizers = token;
			MarkDirty ();
		}
		
		[Register ("__UIGestureRecognizerToken")]
		public class Token : NSObject {
			public Token ()
			{
				IsDirectBinding = false;
			}
		}

		[Register ("__UIGestureRecognizerParameterlessToken")]
		public class ParameterlessDispatch : Token {
			NSAction action;
			
			internal ParameterlessDispatch (NSAction action)
			{
				this.action = action;
			}
			
			[Export ("target")]
			[Preserve (Conditional = true)]
			public void Activated ()
			{
				action ();
			}
		}

		[Register ("__UIGestureRecognizerParametrizedToken")]
		public class ParametrizedDispatch : Token {
			Action<UIGestureRecognizer> action;
			
			internal ParametrizedDispatch (Action<UIGestureRecognizer> action)
			{
				this.action = action;
			}
			
			[Export ("target:")]
			[Preserve (Conditional = true)]
			public void Activated (UIGestureRecognizer sender)
			{
				action (sender);
			}
		}
		
		public Token AddTarget (NSAction action)
		{
			if (action == null)
				throw new ArgumentNullException ("action");

			var t = new ParameterlessDispatch (action);
			RegisterTarget (t, Selector.GetHandle (tsel));
			return t;
		}

		public Token AddTarget (Action<NSObject> action) 
		{
			if (action == null)
				throw new ArgumentNullException ("action");

			var t = new ParametrizedDispatch (action);
			RegisterTarget (t, Selector.GetHandle (parametrized_selector));
			return t;
		}

		void RegisterTarget (Token target, IntPtr sel)
		{
			AddTarget (target, sel);
			MarkDirty ();
			if (recognizers == null)
				recognizers = target;
			else {
				Hashtable table = recognizers as Hashtable;
				if (table == null){
					table = new Hashtable ();
					table [recognizers] = recognizers;
					recognizers = table;
				}
				table [target] = target;
			}
		}

		public void RemoveTarget (Token token)
		{
			if (token == null)
				throw new ArgumentNullException ("token");
			if (recognizers == null)
				return;
			if (recognizers == token)
				recognizers = null;
			Hashtable asHash = recognizers as Hashtable;
			if (asHash != null)
				asHash.Remove (token);
			RemoveTarget (token, token is ParametrizedDispatch ? Selector.GetHandle (parametrized_selector) : Selector.GetHandle (tsel));
		}
	}

#if !TVOS
	public partial class UIRotationGestureRecognizer : UIGestureRecognizer {
		public UIRotationGestureRecognizer (NSAction action) : base (action) {}
		public UIRotationGestureRecognizer (Action<UIRotationGestureRecognizer> action) : base (Selector.GetHandle (UIGestureRecognizer.parametrized_selector), new Callback (action)) {}

		[Register ("__UIRotationGestureRecognizer")]
		class Callback : Token {
			Action<UIRotationGestureRecognizer> action;
			
			internal Callback (Action<UIRotationGestureRecognizer> action)
			{
				this.action = action;
			}
			
			[Export ("target:")]
			[Preserve (Conditional = true)]
			public void Activated (UIRotationGestureRecognizer sender)
			{
				action (sender);
			}
		}
	}
#endif

	public partial class UILongPressGestureRecognizer : UIGestureRecognizer {
		public UILongPressGestureRecognizer (NSAction action) : base (action) {}
		public UILongPressGestureRecognizer (Action<UILongPressGestureRecognizer> action) : base (Selector.GetHandle (UIGestureRecognizer.parametrized_selector), new Callback (action)) {}

		[Register ("__UILongPressGestureRecognizer")]
		class Callback : Token {
			Action<UILongPressGestureRecognizer> action;
			
			internal Callback (Action<UILongPressGestureRecognizer> action)
			{
				this.action = action;
			}
			
			[Export ("target:")]
			[Preserve (Conditional = true)]
			public void Activated (UILongPressGestureRecognizer sender)
			{
				action (sender);
			}
		}
	}

	public partial class UITapGestureRecognizer : UIGestureRecognizer {
		public UITapGestureRecognizer (NSAction action) : base (action) {}
		public UITapGestureRecognizer (Action<UITapGestureRecognizer> action) : base (Selector.GetHandle (UIGestureRecognizer.parametrized_selector), new Callback (action)) {}

		[Register ("__UITapGestureRecognizer")]
		class Callback : Token {
			Action<UITapGestureRecognizer> action;
			
			internal Callback (Action<UITapGestureRecognizer> action)
			{
				this.action = action;
			}
			
			[Export ("target:")]
			[Preserve (Conditional = true)]
			public void Activated (UITapGestureRecognizer sender)
			{
				action (sender);
			}
		}
	}

	public partial class UIPanGestureRecognizer : UIGestureRecognizer {
		public UIPanGestureRecognizer (NSAction action) : base (action) {}
		public UIPanGestureRecognizer (Action<UIPanGestureRecognizer> action) : base (Selector.GetHandle (UIGestureRecognizer.parametrized_selector), new Callback (action)) {}

		internal UIPanGestureRecognizer (IntPtr sel, Token token) : base (token, sel) {}

		[Register ("__UIPanGestureRecognizer")]
		class Callback : Token {
			Action<UIPanGestureRecognizer> action;
			
			internal Callback (Action<UIPanGestureRecognizer> action)
			{
				this.action = action;
			}
			
			[Export ("target:")]
			[Preserve (Conditional = true)]
			public void Activated (UIPanGestureRecognizer sender)
			{
				action (sender);
			}
		}
	}

#if !TVOS
	public partial class UIPinchGestureRecognizer : UIGestureRecognizer {
		public UIPinchGestureRecognizer (NSAction action) : base (action) {}
		public UIPinchGestureRecognizer (Action<UIPinchGestureRecognizer> action) : base (Selector.GetHandle (UIGestureRecognizer.parametrized_selector), new Callback (action)) {}

		[Register ("__UIPinchGestureRecognizer")]
		class Callback : Token {
			Action<UIPinchGestureRecognizer> action;
			
			internal Callback (Action<UIPinchGestureRecognizer> action)
			{
				this.action = action;
			}
			
			[Export ("target:")]
			[Preserve (Conditional = true)]
			public void Activated (UIPinchGestureRecognizer sender)
			{
				action (sender);
			}
		}
	}
#endif

	public partial class UISwipeGestureRecognizer : UIGestureRecognizer {
		public UISwipeGestureRecognizer (NSAction action) : base (action) {}
		public UISwipeGestureRecognizer (Action<UISwipeGestureRecognizer> action) : base (Selector.GetHandle (UIGestureRecognizer.parametrized_selector), new Callback (action)) {}

		[Register ("__UISwipeGestureRecognizer")]
		class Callback : Token {
			Action<UISwipeGestureRecognizer> action;
			
			internal Callback (Action<UISwipeGestureRecognizer> action)
			{
				this.action = action;
			}
			
			[Export ("target:")]
			[Preserve (Conditional = true)]
			public void Activated (UISwipeGestureRecognizer sender)
			{
				action (sender);
			}
		}
	}

#if !TVOS
	public partial class UIScreenEdgePanGestureRecognizer : UIPanGestureRecognizer {
		public UIScreenEdgePanGestureRecognizer (NSAction action) : base (action) {}
		public UIScreenEdgePanGestureRecognizer (Action<UIScreenEdgePanGestureRecognizer> action) : base (Selector.GetHandle (UIGestureRecognizer.parametrized_selector), new Callback (action)) {}

		[Register ("__UIScreenEdgePanGestureRecognizer")]
		class Callback : Token {
			Action<UIScreenEdgePanGestureRecognizer> action;

			internal Callback (Action<UIScreenEdgePanGestureRecognizer> action)
			{
				this.action = action;
			}

			[Export ("target:")]
			[Preserve (Conditional = true)]
			public void Activated (UIScreenEdgePanGestureRecognizer sender)
			{
				action (sender);
			}
		}
	}
#endif
}

#endif // !WATCH
