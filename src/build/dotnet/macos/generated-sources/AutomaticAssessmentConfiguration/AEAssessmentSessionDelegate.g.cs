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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AutomaticAssessmentConfiguration {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>AEAssessmentSessionDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios13.4")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "AEAssessmentSessionDelegate", WrapperType = typeof (AEAssessmentSessionDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBegin", Selector = "assessmentSessionDidBegin:", ParameterType = new Type [] { typeof (AutomaticAssessmentConfiguration.AEAssessmentSession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedToBegin", Selector = "assessmentSession:failedToBeginWithError:", ParameterType = new Type [] { typeof (AutomaticAssessmentConfiguration.AEAssessmentSession), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WasInterrupted", Selector = "assessmentSession:wasInterruptedWithError:", ParameterType = new Type [] { typeof (AutomaticAssessmentConfiguration.AEAssessmentSession), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEnd", Selector = "assessmentSessionDidEnd:", ParameterType = new Type [] { typeof (AutomaticAssessmentConfiguration.AEAssessmentSession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdate", Selector = "assessmentSessionDidUpdate:", ParameterType = new Type [] { typeof (AutomaticAssessmentConfiguration.AEAssessmentSession) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedToUpdate", Selector = "assessmentSession:failedToUpdateToConfiguration:error:", ParameterType = new Type [] { typeof (AutomaticAssessmentConfiguration.AEAssessmentSession), typeof (AutomaticAssessmentConfiguration.AEAssessmentConfiguration), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IAEAssessmentSessionDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("assessmentSessionDidBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBegin (AEAssessmentSession session)
		{
			_DidBegin (this, session);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidBegin (IAEAssessmentSessionDelegate This, AEAssessmentSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("assessmentSessionDidBegin:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[global::Foundation.OptionalMember]
		[Export ("assessmentSession:failedToBeginWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToBegin (AEAssessmentSession session, NSError error)
		{
			_FailedToBegin (this, session, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedToBegin (IAEAssessmentSessionDelegate This, AEAssessmentSession session, NSError error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("assessmentSession:failedToBeginWithError:"), session__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("assessmentSession:wasInterruptedWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WasInterrupted (AEAssessmentSession session, NSError error)
		{
			_WasInterrupted (this, session, error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WasInterrupted (IAEAssessmentSessionDelegate This, AEAssessmentSession session, NSError error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("assessmentSession:wasInterruptedWithError:"), session__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (error);
		}
		[global::Foundation.OptionalMember]
		[Export ("assessmentSessionDidEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEnd (AEAssessmentSession session)
		{
			_DidEnd (this, session);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidEnd (IAEAssessmentSessionDelegate This, AEAssessmentSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("assessmentSessionDidEnd:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[global::Foundation.OptionalMember]
		[Export ("assessmentSessionDidUpdate:")]
		[SupportedOSPlatform ("ios17.5")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdate (AEAssessmentSession session)
		{
			_DidUpdate (this, session);
		}
		[SupportedOSPlatform ("ios17.5")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _DidUpdate (IAEAssessmentSessionDelegate This, AEAssessmentSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("assessmentSessionDidUpdate:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[global::Foundation.OptionalMember]
		[Export ("assessmentSession:failedToUpdateToConfiguration:error:")]
		[SupportedOSPlatform ("ios17.5")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToUpdate (AEAssessmentSession session, AEAssessmentConfiguration configuration, NSError error)
		{
			_FailedToUpdate (this, session, configuration, error);
		}
		[SupportedOSPlatform ("ios17.5")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FailedToUpdate (IAEAssessmentSessionDelegate This, AEAssessmentSession session, AEAssessmentConfiguration configuration, NSError error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("assessmentSession:failedToUpdateToConfiguration:error:"), session__handle__, configuration__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (configuration);
			GC.KeepAlive (error);
		}
		[DynamicDependencyAttribute ("DidBegin(AutomaticAssessmentConfiguration.AEAssessmentSession)")]
		[DynamicDependencyAttribute ("DidEnd(AutomaticAssessmentConfiguration.AEAssessmentSession)")]
		[DynamicDependencyAttribute ("DidUpdate(AutomaticAssessmentConfiguration.AEAssessmentSession)")]
		[DynamicDependencyAttribute ("FailedToBegin(AutomaticAssessmentConfiguration.AEAssessmentSession,Foundation.NSError)")]
		[DynamicDependencyAttribute ("FailedToUpdate(AutomaticAssessmentConfiguration.AEAssessmentSession,AutomaticAssessmentConfiguration.AEAssessmentConfiguration,Foundation.NSError)")]
		[DynamicDependencyAttribute ("WasInterrupted(AutomaticAssessmentConfiguration.AEAssessmentSession,Foundation.NSError)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AEAssessmentSessionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IAEAssessmentSessionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IAEAssessmentSessionDelegate" /> interface to support all the methods from the AEAssessmentSessionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IAEAssessmentSessionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original AEAssessmentSessionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class AEAssessmentSessionDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidBegin (this IAEAssessmentSessionDelegate This, AEAssessmentSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("assessmentSessionDidBegin:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FailedToBegin (this IAEAssessmentSessionDelegate This, AEAssessmentSession session, NSError error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("assessmentSession:failedToBeginWithError:"), session__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WasInterrupted (this IAEAssessmentSessionDelegate This, AEAssessmentSession session, NSError error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("assessmentSession:wasInterruptedWithError:"), session__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidEnd (this IAEAssessmentSessionDelegate This, AEAssessmentSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("assessmentSessionDidEnd:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[SupportedOSPlatform ("ios17.5")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DidUpdate (this IAEAssessmentSessionDelegate This, AEAssessmentSession session)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("assessmentSessionDidUpdate:"), session__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
		}
		[SupportedOSPlatform ("ios17.5")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FailedToUpdate (this IAEAssessmentSessionDelegate This, AEAssessmentSession session, AEAssessmentConfiguration configuration, NSError error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("assessmentSession:failedToUpdateToConfiguration:error:"), session__handle__, configuration__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (configuration);
			GC.KeepAlive (error);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class AEAssessmentSessionDelegateWrapper : BaseWrapper, IAEAssessmentSessionDelegate {
		public AEAssessmentSessionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (AEAssessmentSessionDelegateWrapper))]
		static AEAssessmentSessionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace AutomaticAssessmentConfiguration {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IAEAssessmentSessionDelegate" /> (for the protocol <c>AEAssessmentSessionDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IAEAssessmentSessionDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__AutomaticAssessmentConfiguration_AEAssessmentSessionDelegate", false)]
	[Model]
	[SupportedOSPlatform ("ios13.4")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class AEAssessmentSessionDelegate : NSObject, IAEAssessmentSessionDelegate {
		/// <summary>Creates a new <see cref="AEAssessmentSessionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AEAssessmentSessionDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			unsafe {
			var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
			InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		protected AEAssessmentSessionDelegate (NSObjectFlag t) : base (t)
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
		protected internal AEAssessmentSessionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("assessmentSessionDidBegin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidBegin (AEAssessmentSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("assessmentSessionDidEnd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidEnd (AEAssessmentSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("assessmentSessionDidUpdate:")]
		[SupportedOSPlatform ("ios17.5")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DidUpdate (AEAssessmentSession session)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("assessmentSession:failedToBeginWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToBegin (AEAssessmentSession session, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("assessmentSession:failedToUpdateToConfiguration:error:")]
		[SupportedOSPlatform ("ios17.5")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FailedToUpdate (AEAssessmentSession session, AEAssessmentConfiguration configuration, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("assessmentSession:wasInterruptedWithError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WasInterrupted (AEAssessmentSession session, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class AEAssessmentSessionDelegate */
}
