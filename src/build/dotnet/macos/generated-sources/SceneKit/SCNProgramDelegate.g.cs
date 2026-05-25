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
namespace SceneKit {
	#pragma warning disable CS1573
	/// <summary>Delegate object for SCNProgram objects.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SceneKit/Reference/SCNProgramDelegate_Protocol/index.html">Apple documentation for <c>SCNProgramDelegate</c></related>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "SCNProgramDelegate", WrapperType = typeof (SCNProgramDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "BindValue", Selector = "program:bindValueForSymbol:atLocation:programID:renderer:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (SCNProgram), typeof (string), typeof (uint), typeof (uint), typeof (SCNRenderer) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UnbindValue", Selector = "program:unbindValueForSymbol:atLocation:programID:renderer:", ParameterType = new Type [] { typeof (SCNProgram), typeof (string), typeof (uint), typeof (uint), typeof (SCNRenderer) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleError", Selector = "program:handleError:", ParameterType = new Type [] { typeof (SCNProgram), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "IsProgramOpaque", Selector = "programIsOpaque:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (SCNProgram) }, ParameterByRef = new bool [] { false })]
	public partial interface ISCNProgramDelegate : INativeObject, IDisposable
	{
		/// <param name="program">To be added.</param><param name="symbol">To be added.</param><param name="location">To be added.</param><param name="programID">To be added.</param><param name="renderer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("program:bindValueForSymbol:atLocation:programID:renderer:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.10")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool BindValue (SCNProgram program, string symbol, uint location, uint programID, SCNRenderer renderer)
		{
			return _BindValue (this, program, symbol, location, programID, renderer);
		}
		/// <param name="program">To be added.</param><param name="symbol">To be added.</param><param name="location">To be added.</param><param name="programID">To be added.</param><param name="renderer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.10")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _BindValue (ISCNProgramDelegate This, SCNProgram program, string symbol, uint location, uint programID, SCNRenderer renderer)
		{
			var program__handle__ = program!.GetNonNullHandle (nameof (program));
			if (symbol is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (symbol));
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			var nssymbol = CFString.CreateNative (symbol);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_UInt32_UInt32_NativeHandle (This.Handle, Selector.GetHandle ("program:bindValueForSymbol:atLocation:programID:renderer:"), program__handle__, nssymbol, location, programID, renderer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (program);
			GC.KeepAlive (renderer);
			CFString.ReleaseNative (nssymbol);
			return ret != 0;
		}
		/// <param name="program">To be added.</param><param name="symbol">To be added.</param><param name="location">To be added.</param><param name="programID">To be added.</param><param name="renderer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("program:unbindValueForSymbol:atLocation:programID:renderer:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.10")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnbindValue (SCNProgram program, string symbol, uint location, uint programID, SCNRenderer renderer)
		{
			_UnbindValue (this, program, symbol, location, programID, renderer);
		}
		/// <param name="program">To be added.</param><param name="symbol">To be added.</param><param name="location">To be added.</param><param name="programID">To be added.</param><param name="renderer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.10")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _UnbindValue (ISCNProgramDelegate This, SCNProgram program, string symbol, uint location, uint programID, SCNRenderer renderer)
		{
			var program__handle__ = program!.GetNonNullHandle (nameof (program));
			if (symbol is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (symbol));
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			var nssymbol = CFString.CreateNative (symbol);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UInt32_UInt32_NativeHandle (This.Handle, Selector.GetHandle ("program:unbindValueForSymbol:atLocation:programID:renderer:"), program__handle__, nssymbol, location, programID, renderer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (program);
			GC.KeepAlive (renderer);
			CFString.ReleaseNative (nssymbol);
		}
		/// <param name="program">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("program:handleError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleError (SCNProgram program, NSError error)
		{
			_HandleError (this, program, error);
		}
		/// <param name="program">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _HandleError (ISCNProgramDelegate This, SCNProgram program, NSError error)
		{
			var program__handle__ = program!.GetNonNullHandle (nameof (program));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("program:handleError:"), program__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (program);
			GC.KeepAlive (error);
		}
		/// <param name="program">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("programIsOpaque:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos10.10", "Use the SCNProgram's Opaque property instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsProgramOpaque (SCNProgram program)
		{
			return _IsProgramOpaque (this, program);
		}
		/// <param name="program">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos10.10", "Use the SCNProgram's Opaque property instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _IsProgramOpaque (ISCNProgramDelegate This, SCNProgram program)
		{
			var program__handle__ = program!.GetNonNullHandle (nameof (program));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("programIsOpaque:"), program__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (program);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("BindValue(SceneKit.SCNProgram,System.String,System.UInt32,System.UInt32,SceneKit.SCNRenderer)")]
		[DynamicDependencyAttribute ("HandleError(SceneKit.SCNProgram,Foundation.NSError)")]
		[DynamicDependencyAttribute ("IsProgramOpaque(SceneKit.SCNProgram)")]
		[DynamicDependencyAttribute ("UnbindValue(SceneKit.SCNProgram,System.String,System.UInt32,System.UInt32,SceneKit.SCNRenderer)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SCNProgramDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ISCNProgramDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ISCNProgramDelegate" /> interface to support all the methods from the SCNProgramDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ISCNProgramDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original SCNProgramDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class SCNProgramDelegate_Extensions {
		/// <param name="program">To be added.</param><param name="symbol">To be added.</param><param name="location">To be added.</param><param name="programID">To be added.</param><param name="renderer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.10")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool BindValue (this ISCNProgramDelegate This, SCNProgram program, string symbol, uint location, uint programID, SCNRenderer renderer)
		{
			var program__handle__ = program!.GetNonNullHandle (nameof (program));
			if (symbol is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (symbol));
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			var nssymbol = CFString.CreateNative (symbol);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_UInt32_UInt32_NativeHandle (This.Handle, Selector.GetHandle ("program:bindValueForSymbol:atLocation:programID:renderer:"), program__handle__, nssymbol, location, programID, renderer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (program);
			GC.KeepAlive (renderer);
			CFString.ReleaseNative (nssymbol);
			return ret != 0;
		}
		/// <param name="program">To be added.</param><param name="symbol">To be added.</param><param name="location">To be added.</param><param name="programID">To be added.</param><param name="renderer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.10")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UnbindValue (this ISCNProgramDelegate This, SCNProgram program, string symbol, uint location, uint programID, SCNRenderer renderer)
		{
			var program__handle__ = program!.GetNonNullHandle (nameof (program));
			if (symbol is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (symbol));
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			var nssymbol = CFString.CreateNative (symbol);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UInt32_UInt32_NativeHandle (This.Handle, Selector.GetHandle ("program:unbindValueForSymbol:atLocation:programID:renderer:"), program__handle__, nssymbol, location, programID, renderer__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (program);
			GC.KeepAlive (renderer);
			CFString.ReleaseNative (nssymbol);
		}
		/// <param name="program">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void HandleError (this ISCNProgramDelegate This, SCNProgram program, NSError error)
		{
			var program__handle__ = program!.GetNonNullHandle (nameof (program));
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("program:handleError:"), program__handle__, error__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (program);
			GC.KeepAlive (error);
		}
		/// <param name="program">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos10.10", "Use the SCNProgram's Opaque property instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsProgramOpaque (this ISCNProgramDelegate This, SCNProgram program)
		{
			var program__handle__ = program!.GetNonNullHandle (nameof (program));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("programIsOpaque:"), program__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (program);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class SCNProgramDelegateWrapper : BaseWrapper, ISCNProgramDelegate {
		public SCNProgramDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (SCNProgramDelegateWrapper))]
		static SCNProgramDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace SceneKit {
	/// <summary>Delegate object for SCNProgram objects.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SceneKit/Reference/SCNProgramDelegate_Protocol/index.html">Apple documentation for <c>SCNProgramDelegate</c></related>
	[Protocol()]
	[Register("Microsoft_macOS__SceneKit_SCNProgramDelegate", false)]
	[Model]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SCNProgramDelegate : NSObject, ISCNProgramDelegate {
		/// <summary>Creates a new <see cref="SCNProgramDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCNProgramDelegate () : base (NSObjectFlag.Empty)
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
		protected SCNProgramDelegate (NSObjectFlag t) : base (t)
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
		protected internal SCNProgramDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="program">To be added.</param><param name="symbol">To be added.</param><param name="location">To be added.</param><param name="programID">To be added.</param><param name="renderer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("program:bindValueForSymbol:atLocation:programID:renderer:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.10")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool BindValue (SCNProgram program, string symbol, uint location, uint programID, SCNRenderer renderer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="program">To be added.</param><param name="error">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("program:handleError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HandleError (SCNProgram program, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="program">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("programIsOpaque:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[ObsoletedOSPlatform ("macos10.10", "Use the SCNProgram's Opaque property instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsProgramOpaque (SCNProgram program)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="program">To be added.</param><param name="symbol">To be added.</param><param name="location">To be added.</param><param name="programID">To be added.</param><param name="renderer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("program:unbindValueForSymbol:atLocation:programID:renderer:")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("macos10.10")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnbindValue (SCNProgram program, string symbol, uint location, uint programID, SCNRenderer renderer)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class SCNProgramDelegate */
}
