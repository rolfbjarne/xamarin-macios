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
namespace BrowserEngineKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>BETextInputDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos17.4")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios17.4")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[Protocol (Name = "BETextInputDelegate", WrapperType = typeof (BETextInputDelegateWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ShouldDeferEventHandlingToSystem", Selector = "shouldDeferEventHandlingToSystemForTextInput:context:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (BrowserEngineKit.IBETextInput), typeof (BrowserEngineKit.BEKeyEntryContext) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetCandidateSuggestions", Selector = "textInput:setCandidateSuggestions:", ParameterType = new Type [] { typeof (BrowserEngineKit.IBETextInput), typeof (BrowserEngineKit.BETextSuggestion[]) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SelectionWillChange", Selector = "selectionWillChangeForTextInput:", ParameterType = new Type [] { typeof (BrowserEngineKit.IBETextInput) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SelectionDidChange", Selector = "selectionDidChangeForTextInput:", ParameterType = new Type [] { typeof (BrowserEngineKit.IBETextInput) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "DeferReplaceTextActionToSystem", Selector = "textInput:deferReplaceTextActionToSystem:", ParameterType = new Type [] { typeof (BrowserEngineKit.IBETextInput), typeof (NSObject) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "InvalidateTextEntryContext", Selector = "invalidateTextEntryContextForTextInput:", ParameterType = new Type [] { typeof (BrowserEngineKit.IBETextInput) }, ParameterByRef = new bool [] { false })]
	public partial interface IBETextInputDelegate : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("shouldDeferEventHandlingToSystemForTextInput:context:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDeferEventHandlingToSystem (IBETextInput textInput, BEKeyEntryContext keyEventContext)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldDeferEventHandlingToSystem (IBETextInputDelegate This, IBETextInput textInput, BEKeyEntryContext keyEventContext)
		{
			var textInput__handle__ = textInput!.GetNonNullHandle (nameof (textInput));
			var keyEventContext__handle__ = keyEventContext!.GetNonNullHandle (nameof (keyEventContext));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("shouldDeferEventHandlingToSystemForTextInput:context:"), textInput__handle__, keyEventContext__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textInput);
			GC.KeepAlive (keyEventContext);
			return ret != 0;
		}
		[global::Foundation.RequiredMember]
		[Export ("textInput:setCandidateSuggestions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCandidateSuggestions (IBETextInput textInput, BETextSuggestion[]? suggestions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetCandidateSuggestions (IBETextInputDelegate This, IBETextInput textInput, BETextSuggestion[]? suggestions)
		{
			var textInput__handle__ = textInput!.GetNonNullHandle (nameof (textInput));
			using var nsa_suggestions = suggestions is null ? null : NSArray.FromNSObjects (suggestions);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textInput:setCandidateSuggestions:"), textInput__handle__, nsa_suggestions.GetHandle ());
			GC.KeepAlive (This);
			GC.KeepAlive (textInput);
		}
		[global::Foundation.RequiredMember]
		[Export ("selectionWillChangeForTextInput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionWillChange (IBETextInput textInput)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SelectionWillChange (IBETextInputDelegate This, IBETextInput textInput)
		{
			var textInput__handle__ = textInput!.GetNonNullHandle (nameof (textInput));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("selectionWillChangeForTextInput:"), textInput__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textInput);
		}
		[global::Foundation.RequiredMember]
		[Export ("selectionDidChangeForTextInput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionDidChange (IBETextInput textInput)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SelectionDidChange (IBETextInputDelegate This, IBETextInput textInput)
		{
			var textInput__handle__ = textInput!.GetNonNullHandle (nameof (textInput));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("selectionDidChangeForTextInput:"), textInput__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textInput);
		}
		[global::Foundation.RequiredMember]
		[Export ("textInput:deferReplaceTextActionToSystem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeferReplaceTextActionToSystem (IBETextInput textInput, NSObject sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DeferReplaceTextActionToSystem (IBETextInputDelegate This, IBETextInput textInput, NSObject sender)
		{
			var textInput__handle__ = textInput!.GetNonNullHandle (nameof (textInput));
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("textInput:deferReplaceTextActionToSystem:"), textInput__handle__, sender__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textInput);
			GC.KeepAlive (sender);
		}
		[global::Foundation.RequiredMember]
		[Export ("invalidateTextEntryContextForTextInput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateTextEntryContext (IBETextInput textInput)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _InvalidateTextEntryContext (IBETextInputDelegate This, IBETextInput textInput)
		{
			var textInput__handle__ = textInput!.GetNonNullHandle (nameof (textInput));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("invalidateTextEntryContextForTextInput:"), textInput__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (textInput);
		}
		[DynamicDependencyAttribute ("DeferReplaceTextActionToSystem(BrowserEngineKit.IBETextInput,Foundation.NSObject)")]
		[DynamicDependencyAttribute ("InvalidateTextEntryContext(BrowserEngineKit.IBETextInput)")]
		[DynamicDependencyAttribute ("SelectionDidChange(BrowserEngineKit.IBETextInput)")]
		[DynamicDependencyAttribute ("SelectionWillChange(BrowserEngineKit.IBETextInput)")]
		[DynamicDependencyAttribute ("SetCandidateSuggestions(BrowserEngineKit.IBETextInput,BrowserEngineKit.BETextSuggestion[])")]
		[DynamicDependencyAttribute ("ShouldDeferEventHandlingToSystem(BrowserEngineKit.IBETextInput,BrowserEngineKit.BEKeyEntryContext)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (BETextInputDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IBETextInputDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class BETextInputDelegateWrapper : BaseWrapper, IBETextInputDelegate {
		public BETextInputDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (BETextInputDelegateWrapper))]
		static BETextInputDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("shouldDeferEventHandlingToSystemForTextInput:context:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool ShouldDeferEventHandlingToSystem (IBETextInput textInput, BEKeyEntryContext keyEventContext)
		{
			var textInput__handle__ = textInput!.GetNonNullHandle (nameof (textInput));
			var keyEventContext__handle__ = keyEventContext!.GetNonNullHandle (nameof (keyEventContext));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("shouldDeferEventHandlingToSystemForTextInput:context:"), textInput__handle__, keyEventContext__handle__);
			GC.KeepAlive (textInput);
			GC.KeepAlive (keyEventContext);
			return ret != 0;
		}
		[Export ("textInput:setCandidateSuggestions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetCandidateSuggestions (IBETextInput textInput, BETextSuggestion[]? suggestions)
		{
			var textInput__handle__ = textInput!.GetNonNullHandle (nameof (textInput));
			using var nsa_suggestions = suggestions is null ? null : NSArray.FromNSObjects (suggestions);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("textInput:setCandidateSuggestions:"), textInput__handle__, nsa_suggestions.GetHandle ());
			GC.KeepAlive (textInput);
		}
		[Export ("selectionWillChangeForTextInput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SelectionWillChange (IBETextInput textInput)
		{
			var textInput__handle__ = textInput!.GetNonNullHandle (nameof (textInput));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("selectionWillChangeForTextInput:"), textInput__handle__);
			GC.KeepAlive (textInput);
		}
		[Export ("selectionDidChangeForTextInput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SelectionDidChange (IBETextInput textInput)
		{
			var textInput__handle__ = textInput!.GetNonNullHandle (nameof (textInput));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("selectionDidChangeForTextInput:"), textInput__handle__);
			GC.KeepAlive (textInput);
		}
		[Export ("textInput:deferReplaceTextActionToSystem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void DeferReplaceTextActionToSystem (IBETextInput textInput, NSObject sender)
		{
			var textInput__handle__ = textInput!.GetNonNullHandle (nameof (textInput));
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("textInput:deferReplaceTextActionToSystem:"), textInput__handle__, sender__handle__);
			GC.KeepAlive (textInput);
			GC.KeepAlive (sender);
		}
		[Export ("invalidateTextEntryContextForTextInput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InvalidateTextEntryContext (IBETextInput textInput)
		{
			var textInput__handle__ = textInput!.GetNonNullHandle (nameof (textInput));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("invalidateTextEntryContextForTextInput:"), textInput__handle__);
			GC.KeepAlive (textInput);
		}
	}
}
namespace BrowserEngineKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IBETextInputDelegate" /> (for the protocol <c>BETextInputDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IBETextInputDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__BrowserEngineKit_BETextInputDelegate", false)]
	[Model]
	[SupportedOSPlatform ("tvos17.4")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios17.4")]
	[UnsupportedOSPlatform ("maccatalyst")]
	public unsafe abstract partial class BETextInputDelegate : NSObject, IBETextInputDelegate {
		/// <summary>Creates a new <see cref="BETextInputDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected BETextInputDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			GC.KeepAlive (this);
			}
		}

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
		protected BETextInputDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
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
		protected internal BETextInputDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("textInput:deferReplaceTextActionToSystem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DeferReplaceTextActionToSystem (IBETextInput textInput, NSObject sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("invalidateTextEntryContextForTextInput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InvalidateTextEntryContext (IBETextInput textInput)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("selectionDidChangeForTextInput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionDidChange (IBETextInput textInput)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("selectionWillChangeForTextInput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SelectionWillChange (IBETextInput textInput)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("textInput:setCandidateSuggestions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetCandidateSuggestions (IBETextInput textInput, BETextSuggestion[]? suggestions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("shouldDeferEventHandlingToSystemForTextInput:context:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldDeferEventHandlingToSystem (IBETextInput textInput, BEKeyEntryContext keyEventContext)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class BETextInputDelegate */
}
