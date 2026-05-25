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
namespace CryptoTokenKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>TKTokenSessionDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "TKTokenSessionDelegate", WrapperType = typeof (TKTokenSessionDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "BeginAuthentication", Selector = "tokenSession:beginAuthForOperation:constraint:error:", ReturnType = typeof (CryptoTokenKit.TKTokenAuthOperation), ParameterType = new Type [] { typeof (CryptoTokenKit.TKTokenSession), typeof (CryptoTokenKit.TKTokenOperation), typeof (NSObject), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SupportsOperation", Selector = "tokenSession:supportsOperation:usingKey:algorithm:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (CryptoTokenKit.TKTokenSession), typeof (CryptoTokenKit.TKTokenOperation), typeof (NSObject), typeof (CryptoTokenKit.TKTokenKeyAlgorithm) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SignData", Selector = "tokenSession:signData:usingKey:algorithm:error:", ReturnType = typeof (NSData), ParameterType = new Type [] { typeof (CryptoTokenKit.TKTokenSession), typeof (NSData), typeof (NSObject), typeof (CryptoTokenKit.TKTokenKeyAlgorithm), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, false, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DecryptData", Selector = "tokenSession:decryptData:usingKey:algorithm:error:", ReturnType = typeof (NSData), ParameterType = new Type [] { typeof (CryptoTokenKit.TKTokenSession), typeof (NSData), typeof (NSObject), typeof (CryptoTokenKit.TKTokenKeyAlgorithm), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, false, true })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformKeyExchange", Selector = "tokenSession:performKeyExchangeWithPublicKey:usingKey:algorithm:parameters:error:", ReturnType = typeof (NSData), ParameterType = new Type [] { typeof (CryptoTokenKit.TKTokenSession), typeof (NSData), typeof (NSObject), typeof (CryptoTokenKit.TKTokenKeyAlgorithm), typeof (CryptoTokenKit.TKTokenKeyExchangeParameters), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, false, false, true })]
	public partial interface ITKTokenSessionDelegate : INativeObject, IDisposable
	{
		[global::Foundation.OptionalMember]
		[Export ("tokenSession:beginAuthForOperation:constraint:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual TKTokenAuthOperation? BeginAuthentication (TKTokenSession session, TKTokenOperation operation, NSObject constraint, out NSError? error)
		{
			return _BeginAuthentication (this, session, operation, constraint, out error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static TKTokenAuthOperation? _BeginAuthentication (ITKTokenSessionDelegate This, TKTokenSession session, TKTokenOperation operation, NSObject constraint, out NSError? error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var constraint__handle__ = constraint!.GetNonNullHandle (nameof (constraint));
			NativeHandle errorValue = IntPtr.Zero;
			TKTokenAuthOperation? ret;
			ret =  Runtime.GetNSObject<TKTokenAuthOperation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("tokenSession:beginAuthForOperation:constraint:error:"), session__handle__, (IntPtr) (long) operation, constraint__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (constraint);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("tokenSession:supportsOperation:usingKey:algorithm:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SupportsOperation (TKTokenSession session, TKTokenOperation operation, NSObject keyObjectId, TKTokenKeyAlgorithm algorithm)
		{
			return _SupportsOperation (this, session, operation, keyObjectId, algorithm);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _SupportsOperation (ITKTokenSessionDelegate This, TKTokenSession session, TKTokenOperation operation, NSObject keyObjectId, TKTokenKeyAlgorithm algorithm)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var keyObjectId__handle__ = keyObjectId!.GetNonNullHandle (nameof (keyObjectId));
			var algorithm__handle__ = algorithm!.GetNonNullHandle (nameof (algorithm));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenSession:supportsOperation:usingKey:algorithm:"), session__handle__, (IntPtr) (long) operation, keyObjectId__handle__, algorithm__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (keyObjectId);
			GC.KeepAlive (algorithm);
			return ret != 0;
		}
		[global::Foundation.OptionalMember]
		[Export ("tokenSession:signData:usingKey:algorithm:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSData? SignData (TKTokenSession session, NSData dataToSign, NSObject keyObjectId, TKTokenKeyAlgorithm algorithm, out NSError? error)
		{
			return _SignData (this, session, dataToSign, keyObjectId, algorithm, out error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSData? _SignData (ITKTokenSessionDelegate This, TKTokenSession session, NSData dataToSign, NSObject keyObjectId, TKTokenKeyAlgorithm algorithm, out NSError? error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var dataToSign__handle__ = dataToSign!.GetNonNullHandle (nameof (dataToSign));
			var keyObjectId__handle__ = keyObjectId!.GetNonNullHandle (nameof (keyObjectId));
			var algorithm__handle__ = algorithm!.GetNonNullHandle (nameof (algorithm));
			NativeHandle errorValue = IntPtr.Zero;
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("tokenSession:signData:usingKey:algorithm:error:"), session__handle__, dataToSign__handle__, keyObjectId__handle__, algorithm__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (dataToSign);
			GC.KeepAlive (keyObjectId);
			GC.KeepAlive (algorithm);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("tokenSession:decryptData:usingKey:algorithm:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSData? DecryptData (TKTokenSession session, NSData ciphertext, NSObject keyObjectId, TKTokenKeyAlgorithm algorithm, out NSError? error)
		{
			return _DecryptData (this, session, ciphertext, keyObjectId, algorithm, out error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSData? _DecryptData (ITKTokenSessionDelegate This, TKTokenSession session, NSData ciphertext, NSObject keyObjectId, TKTokenKeyAlgorithm algorithm, out NSError? error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var ciphertext__handle__ = ciphertext!.GetNonNullHandle (nameof (ciphertext));
			var keyObjectId__handle__ = keyObjectId!.GetNonNullHandle (nameof (keyObjectId));
			var algorithm__handle__ = algorithm!.GetNonNullHandle (nameof (algorithm));
			NativeHandle errorValue = IntPtr.Zero;
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("tokenSession:decryptData:usingKey:algorithm:error:"), session__handle__, ciphertext__handle__, keyObjectId__handle__, algorithm__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (ciphertext);
			GC.KeepAlive (keyObjectId);
			GC.KeepAlive (algorithm);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.OptionalMember]
		[Export ("tokenSession:performKeyExchangeWithPublicKey:usingKey:algorithm:parameters:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSData? PerformKeyExchange (TKTokenSession session, NSData otherPartyPublicKeyData, NSObject objectId, TKTokenKeyAlgorithm algorithm, TKTokenKeyExchangeParameters parameters, out NSError? error)
		{
			return _PerformKeyExchange (this, session, otherPartyPublicKeyData, objectId, algorithm, parameters, out error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static NSData? _PerformKeyExchange (ITKTokenSessionDelegate This, TKTokenSession session, NSData otherPartyPublicKeyData, NSObject objectId, TKTokenKeyAlgorithm algorithm, TKTokenKeyExchangeParameters parameters, out NSError? error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var otherPartyPublicKeyData__handle__ = otherPartyPublicKeyData!.GetNonNullHandle (nameof (otherPartyPublicKeyData));
			var objectId__handle__ = objectId!.GetNonNullHandle (nameof (objectId));
			var algorithm__handle__ = algorithm!.GetNonNullHandle (nameof (algorithm));
			var parameters__handle__ = parameters!.GetNonNullHandle (nameof (parameters));
			NativeHandle errorValue = IntPtr.Zero;
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("tokenSession:performKeyExchangeWithPublicKey:usingKey:algorithm:parameters:error:"), session__handle__, otherPartyPublicKeyData__handle__, objectId__handle__, algorithm__handle__, parameters__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (otherPartyPublicKeyData);
			GC.KeepAlive (objectId);
			GC.KeepAlive (algorithm);
			GC.KeepAlive (parameters);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[DynamicDependencyAttribute ("BeginAuthentication(CryptoTokenKit.TKTokenSession,CryptoTokenKit.TKTokenOperation,Foundation.NSObject,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("DecryptData(CryptoTokenKit.TKTokenSession,Foundation.NSData,Foundation.NSObject,CryptoTokenKit.TKTokenKeyAlgorithm,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("PerformKeyExchange(CryptoTokenKit.TKTokenSession,Foundation.NSData,Foundation.NSObject,CryptoTokenKit.TKTokenKeyAlgorithm,CryptoTokenKit.TKTokenKeyExchangeParameters,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("SignData(CryptoTokenKit.TKTokenSession,Foundation.NSData,Foundation.NSObject,CryptoTokenKit.TKTokenKeyAlgorithm,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("SupportsOperation(CryptoTokenKit.TKTokenSession,CryptoTokenKit.TKTokenOperation,Foundation.NSObject,CryptoTokenKit.TKTokenKeyAlgorithm)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (TKTokenSessionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static ITKTokenSessionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="ITKTokenSessionDelegate" /> interface to support all the methods from the TKTokenSessionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="ITKTokenSessionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original TKTokenSessionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class TKTokenSessionDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static TKTokenAuthOperation? BeginAuthentication (this ITKTokenSessionDelegate This, TKTokenSession session, TKTokenOperation operation, NSObject constraint, out NSError? error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var constraint__handle__ = constraint!.GetNonNullHandle (nameof (constraint));
			NativeHandle errorValue = IntPtr.Zero;
			TKTokenAuthOperation? ret;
			ret =  Runtime.GetNSObject<TKTokenAuthOperation> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("tokenSession:beginAuthForOperation:constraint:error:"), session__handle__, (IntPtr) (long) operation, constraint__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (constraint);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SupportsOperation (this ITKTokenSessionDelegate This, TKTokenSession session, TKTokenOperation operation, NSObject keyObjectId, TKTokenKeyAlgorithm algorithm)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var keyObjectId__handle__ = keyObjectId!.GetNonNullHandle (nameof (keyObjectId));
			var algorithm__handle__ = algorithm!.GetNonNullHandle (nameof (algorithm));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("tokenSession:supportsOperation:usingKey:algorithm:"), session__handle__, (IntPtr) (long) operation, keyObjectId__handle__, algorithm__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (keyObjectId);
			GC.KeepAlive (algorithm);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSData? SignData (this ITKTokenSessionDelegate This, TKTokenSession session, NSData dataToSign, NSObject keyObjectId, TKTokenKeyAlgorithm algorithm, out NSError? error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var dataToSign__handle__ = dataToSign!.GetNonNullHandle (nameof (dataToSign));
			var keyObjectId__handle__ = keyObjectId!.GetNonNullHandle (nameof (keyObjectId));
			var algorithm__handle__ = algorithm!.GetNonNullHandle (nameof (algorithm));
			NativeHandle errorValue = IntPtr.Zero;
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("tokenSession:signData:usingKey:algorithm:error:"), session__handle__, dataToSign__handle__, keyObjectId__handle__, algorithm__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (dataToSign);
			GC.KeepAlive (keyObjectId);
			GC.KeepAlive (algorithm);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSData? DecryptData (this ITKTokenSessionDelegate This, TKTokenSession session, NSData ciphertext, NSObject keyObjectId, TKTokenKeyAlgorithm algorithm, out NSError? error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var ciphertext__handle__ = ciphertext!.GetNonNullHandle (nameof (ciphertext));
			var keyObjectId__handle__ = keyObjectId!.GetNonNullHandle (nameof (keyObjectId));
			var algorithm__handle__ = algorithm!.GetNonNullHandle (nameof (algorithm));
			NativeHandle errorValue = IntPtr.Zero;
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("tokenSession:decryptData:usingKey:algorithm:error:"), session__handle__, ciphertext__handle__, keyObjectId__handle__, algorithm__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (ciphertext);
			GC.KeepAlive (keyObjectId);
			GC.KeepAlive (algorithm);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSData? PerformKeyExchange (this ITKTokenSessionDelegate This, TKTokenSession session, NSData otherPartyPublicKeyData, NSObject objectId, TKTokenKeyAlgorithm algorithm, TKTokenKeyExchangeParameters parameters, out NSError? error)
		{
			var session__handle__ = session!.GetNonNullHandle (nameof (session));
			var otherPartyPublicKeyData__handle__ = otherPartyPublicKeyData!.GetNonNullHandle (nameof (otherPartyPublicKeyData));
			var objectId__handle__ = objectId!.GetNonNullHandle (nameof (objectId));
			var algorithm__handle__ = algorithm!.GetNonNullHandle (nameof (algorithm));
			var parameters__handle__ = parameters!.GetNonNullHandle (nameof (parameters));
			NativeHandle errorValue = IntPtr.Zero;
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("tokenSession:performKeyExchangeWithPublicKey:usingKey:algorithm:parameters:error:"), session__handle__, otherPartyPublicKeyData__handle__, objectId__handle__, algorithm__handle__, parameters__handle__, &errorValue), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (session);
			GC.KeepAlive (otherPartyPublicKeyData);
			GC.KeepAlive (objectId);
			GC.KeepAlive (algorithm);
			GC.KeepAlive (parameters);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class TKTokenSessionDelegateWrapper : BaseWrapper, ITKTokenSessionDelegate {
		public TKTokenSessionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (TKTokenSessionDelegateWrapper))]
		static TKTokenSessionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace CryptoTokenKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="ITKTokenSessionDelegate" /> (for the protocol <c>TKTokenSessionDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="ITKTokenSessionDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__CryptoTokenKit_TKTokenSessionDelegate", false)]
	[Model]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class TKTokenSessionDelegate : NSObject, ITKTokenSessionDelegate {
		/// <summary>Creates a new <see cref="TKTokenSessionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TKTokenSessionDelegate () : base (NSObjectFlag.Empty)
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
		protected TKTokenSessionDelegate (NSObjectFlag t) : base (t)
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
		protected internal TKTokenSessionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("tokenSession:beginAuthForOperation:constraint:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual TKTokenAuthOperation? BeginAuthentication (TKTokenSession session, TKTokenOperation operation, NSObject constraint, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tokenSession:decryptData:usingKey:algorithm:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSData? DecryptData (TKTokenSession session, NSData ciphertext, NSObject keyObjectId, TKTokenKeyAlgorithm algorithm, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tokenSession:performKeyExchangeWithPublicKey:usingKey:algorithm:parameters:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSData? PerformKeyExchange (TKTokenSession session, NSData otherPartyPublicKeyData, NSObject objectId, TKTokenKeyAlgorithm algorithm, TKTokenKeyExchangeParameters parameters, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tokenSession:signData:usingKey:algorithm:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual NSData? SignData (TKTokenSession session, NSData dataToSign, NSObject keyObjectId, TKTokenKeyAlgorithm algorithm, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("tokenSession:supportsOperation:usingKey:algorithm:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SupportsOperation (TKTokenSession session, TKTokenOperation operation, NSObject keyObjectId, TKTokenKeyAlgorithm algorithm)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class TKTokenSessionDelegate */
}
