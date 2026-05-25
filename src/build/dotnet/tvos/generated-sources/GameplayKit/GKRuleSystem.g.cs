//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace GameplayKit {
	/// <summary>Maintains a collection of <see cref="T:GameplayKit.GKRule" /> objects, activating them as appropriate.</summary><remarks><para>The <see cref="T:GameplayKit.GKRuleSystem" /> class allows developers to build expert systems. Both classical and fuzzy-logic systems are supported.</para><para>At any time, a <see cref="T:GameplayKit.GKRule" /> is either in the <see cref="P:GameplayKit.GKRuleSystem.Agenda" /> collection of rules to be evaluated or the <see cref="P:GameplayKit.GKRuleSystem.Executed" /> collection. The <see cref="M:GameplayKit.GKRuleSystem.Reset" /> method moves all rules back to the <see cref="P:GameplayKit.GKRuleSystem.Agenda" /> collection. </para><para>The method <see cref="M:GameplayKit.GKRuleSystem.Evaluate" /> evaluates the predicates of every rule in the <see cref="P:GameplayKit.GKRuleSystem.Agenda" />, according to their <see cref="P:GameplayKit.GKRule.Salience" /> and, secondarily, the order in which they were added to the <see cref="T:GameplayKit.GKRuleSystem" />. Rules whose predicate evaluates to <see langword="true" /> have their action function executed and are placed in the <see cref="P:GameplayKit.GKRuleSystem.Executed" /> collection.</para><para>The following demonstrates the "FizzBuzz" challenge: If a number is evenly divisible by 3, output "fizz". If evenly divisible by 5, output "buzz". Otherwise, output the number itself. Note that this code properly sets the <c>output</c> to "buzzfizz" on an input of 15, since both the <c>fizzRule</c> and <c>buzzRule</c> evaluate to <see langword="true" />.</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// var clearRule = GKRule.FromPredicate ((rules) => reset, rules => {
	/// 	output = "";
	/// 	reset = false;
	/// });
	/// clearRule.Salience = 1;
	/// 
	/// var fizzRule = GKRule.FromPredicate (mod (3), rules => {
	/// 	output += "fizz";
	/// });
	/// fizzRule.Salience = 2;
	/// var buzzRule = GKRule.FromPredicate (mod (5), rules => { 
	/// 	output += "buzz";
	/// });
	/// buzzRule.Salience = 2;
	/// 
	/// var outputRule = GKRule.FromPredicate (rules => true, rules => {
	/// 	System.Console.WriteLine (output == "" ? input.ToString () : output);
	/// 	reset = true;
	/// });
	/// outputRule.Salience = 3;
	/// 
	/// var rs = new GKRuleSystem ();
	/// rs.AddRules (new [] {
	/// 	clearRule,
	/// 	fizzRule,
	/// 	buzzRule,
	/// 	outputRule
	/// });
	/// 
	/// for (input = 1; input < 16; input++) {
	/// 	rs.Evaluate ();
	/// 	rs.Reset ();
	/// }
	/// 
	/// ]]></code></example></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/GameplayKit/Reference/GKRuleSystem_Class/index.html">Apple documentation for <c>GKRuleSystem</c></related>
	[Register("GKRuleSystem", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class GKRuleSystem : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("GKRuleSystem");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Constructor to call on derived classes to skip initialization and merely allocate the object.</summary>
		/// <param name="t">Unused sentinel value, pass NSObjectFlag.Empty.</param>
		/// <remarks>
		///     <para>
		///         This constructor should be called by derived classes when they completely construct the object in managed code and merely want the runtime to allocate and initialize the <see cref="Foundation.NSObject" />.
		///         This is required to implement the two-step initialization process that Objective-C uses, the first step is to perform the object allocation, the second step is to initialize the object.
		///         When developers invoke this constructor, they take advantage of a direct path that goes all the way up to <see cref="Foundation.NSObject" /> to merely allocate the object's memory and bind the Objective-C and C# objects together.
		///         The actual initialization of the object is up to the developer.
		///     </para>
		///     <para>
		///         This constructor is typically used by the binding generator to allocate the object, but prevent the actual initialization to take place.
		///         Once the allocation has taken place, the constructor has to initialize the object.
		///         With constructors generated by the binding generator this means that it manually invokes one of the "init" methods to initialize the object.
		///     </para>
		///     <para>It is the developer's responsibility to completely initialize the object if they chain up using this constructor chain.</para>
		///     <para>
		///         In general, if the developer's constructor invokes the corresponding base implementation, then it should also call an Objective-C init method.
		///         If this is not the case, developers should instead chain to the proper constructor in their class.
		///     </para>
		///     <para>
		///         The argument value is ignored and merely ensures that the only code that is executed is the construction phase is the basic <see cref="Foundation.NSObject" /> allocation and runtime type registration.
		///         Typically the chaining would look like this:
		///     </para>
		///     <example>
		///             <code lang="csharp lang-csharp"><![CDATA[
		/// //
		/// // The NSObjectFlag constructor merely allocates the object and registers the C# class with the Objective-C runtime if necessary.
		/// // No actual initXxx method is invoked, that is done later in the constructor
		/// //
		/// // This is taken from the iOS SDK's source code for the UIView class:
		/// //
		/// [Export ("initWithFrame:")]
		/// public UIView (CGRect frame) : base (NSObjectFlag.Empty)
		/// {
		///     // Invoke the init method now.
		///     var initWithFrame = new Selector ("initWithFrame:").Handle;
		///     if (IsDirectBinding) {
		///         Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSend_CGRect (this.Handle, initWithFrame, frame);
		///     } else {
		///         unsafe {
		///             var __objc_super__ = new ObjCRuntime.ObjCSuper (this);
		///             Handle = ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_CGRect (&__objc_super__, initWithFrame, frame);
		///         }
		///         GC.KeepAlive (this);
		///     }
		/// }
		/// ]]></code>
		///     </example>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected GKRuleSystem (NSObjectFlag t) : base (t)
		{
		}

		/// <summary>A constructor used when creating managed representations of unmanaged objects. Called by the runtime.</summary>
		/// <param name="handle">Pointer (handle) to the unmanaged object.</param>
		/// <remarks>
		///     <para>
		///         This constructor is invoked by the runtime infrastructure (<see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" />) to create a new managed representation for a pointer to an unmanaged Objective-C object.
		///         Developers should not invoke this method directly, instead they should call <see cref="ObjCRuntime.Runtime.GetNSObject(System.IntPtr)" /> as it will prevent two instances of a managed object pointing to the same native object.
		///     </para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal GKRuleSystem (NativeHandle handle) : base (handle)
		{
		}

		[Export ("init")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public GKRuleSystem ()
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("init")), "init");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("addRule:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddRule (GKRule rule)
		{
			var rule__handle__ = rule!.GetNonNullHandle (nameof (rule));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addRule:"), rule__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addRule:"), rule__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (rule);
		}
		[Export ("addRulesFromArray:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddRules (GKRule[] rules)
		{
			if (rules is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (rules));
			using var nsa_rules = NSArray.FromNSObjects (rules);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addRulesFromArray:"), nsa_rules.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addRulesFromArray:"), nsa_rules.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("assertFact:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AssertFact (NSObject fact)
		{
			var fact__handle__ = fact!.GetNonNullHandle (nameof (fact));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("assertFact:"), fact__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("assertFact:"), fact__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fact);
		}
		[Export ("assertFact:grade:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AssertFact (NSObject fact, float grade)
		{
			var fact__handle__ = fact!.GetNonNullHandle (nameof (fact));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_float (this.Handle, Selector.GetHandle ("assertFact:grade:"), fact__handle__, grade);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_float (&__objc_super__, Selector.GetHandle ("assertFact:grade:"), fact__handle__, grade);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fact);
		}
		[Export ("evaluate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Evaluate ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("evaluate"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("evaluate"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("gradeForFact:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float GetGrade (NSObject fact)
		{
			var fact__handle__ = fact!.GetNonNullHandle (nameof (fact));
			float ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("gradeForFact:"), fact__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("gradeForFact:"), fact__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fact);
			return ret!;
		}
		[Export ("maximumGradeForFacts:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float GetMaximumGrade (NSObject[] facts)
		{
			if (facts is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (facts));
			using var nsa_facts = NSArray.FromNSObjects (facts);
			float ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("maximumGradeForFacts:"), nsa_facts.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("maximumGradeForFacts:"), nsa_facts.Handle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("minimumGradeForFacts:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float GetMinimumGrade (NSObject[] facts)
		{
			if (facts is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (facts));
			using var nsa_facts = NSArray.FromNSObjects (facts);
			float ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.float_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("minimumGradeForFacts:"), nsa_facts.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("minimumGradeForFacts:"), nsa_facts.Handle);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("removeAllRules")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllRules ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllRules"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("removeAllRules"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("reset")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Reset ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("reset"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("reset"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("retractFact:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RetractFact (NSObject fact)
		{
			var fact__handle__ = fact!.GetNonNullHandle (nameof (fact));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("retractFact:"), fact__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("retractFact:"), fact__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fact);
		}
		[Export ("retractFact:grade:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RetractFact (NSObject fact, float grade)
		{
			var fact__handle__ = fact!.GetNonNullHandle (nameof (fact));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_float (this.Handle, Selector.GetHandle ("retractFact:grade:"), fact__handle__, grade);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_float (&__objc_super__, Selector.GetHandle ("retractFact:grade:"), fact__handle__, grade);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (fact);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GKRule[] Agenda {
			[Export ("agenda", ArgumentSemantic.Retain)]
			get {
				GKRule[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<GKRule>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("agenda")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<GKRule>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("agenda")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GKRule[] Executed {
			[Export ("executed", ArgumentSemantic.Retain)]
			get {
				GKRule[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<GKRule>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("executed")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<GKRule>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("executed")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[] Facts {
			[Export ("facts", ArgumentSemantic.Retain)]
			get {
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("facts")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<NSObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("facts")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual GKRule[] Rules {
			[Export ("rules", ArgumentSemantic.Retain)]
			get {
				GKRule[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<GKRule>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("rules")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<GKRule>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("rules")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMutableDictionary State {
			[Export ("state", ArgumentSemantic.Retain)]
			get {
				NSMutableDictionary? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("state")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSMutableDictionary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("state")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class GKRuleSystem */
}
