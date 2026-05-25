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
namespace Foundation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSConnectionDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[ObsoletedOSPlatform ("macos10.13", "Use 'NSXpcConnection' instead.")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "NSConnectionDelegate", WrapperType = typeof (NSConnectionDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AuthenticateComponents", Selector = "authenticateComponents:withData:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSArray), typeof (NSData) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAuthenticationData", Selector = "authenticationDataForComponents:", ReturnType = typeof (NSData), ParameterType = new Type [] { typeof (NSArray) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldMakeNewConnection", Selector = "connection:shouldMakeNewConnection:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSConnection), typeof (NSConnection) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleRequest", Selector = "connection:handleRequest:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSConnection), typeof (NSDistantObjectRequest) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateConversation", Selector = "createConversationForConnection:", ReturnType = typeof (NSObject), ParameterType = new Type [] { typeof (NSConnection) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AllowNewConnection", Selector = "makeNewConnection:sender:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (NSConnection), typeof (NSConnection) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSConnectionDelegate : INativeObject, IDisposable
	{
		/// <param name="components">To be added.</param><param name="authenticationData">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("authenticateComponents:withData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AuthenticateComponents (NSArray components, NSData authenticationData)
		{
			return _AuthenticateComponents (this, components, authenticationData);
		}
		/// <param name="components">To be added.</param><param name="authenticationData">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _AuthenticateComponents (INSConnectionDelegate This, NSArray components, NSData authenticationData)
		{
			var components__handle__ = components!.GetNonNullHandle (nameof (components));
			var authenticationData__handle__ = authenticationData!.GetNonNullHandle (nameof (authenticationData));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("authenticateComponents:withData:"), components__handle__, authenticationData__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (components);
			GC.KeepAlive (authenticationData);
			return ret != 0;
		}
		/// <param name="components">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("authenticationDataForComponents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData GetAuthenticationData (NSArray components)
		{
			return _GetAuthenticationData (this, components);
		}
		/// <param name="components">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSData _GetAuthenticationData (INSConnectionDelegate This, NSArray components)
		{
			var components__handle__ = components!.GetNonNullHandle (nameof (components));
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("authenticationDataForComponents:"), components__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (components);
			return ret!;
		}
		/// <param name="parentConnection">To be added.</param><param name="newConnection">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("connection:shouldMakeNewConnection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldMakeNewConnection (NSConnection parentConnection, NSConnection newConnection)
		{
			return _ShouldMakeNewConnection (this, parentConnection, newConnection);
		}
		/// <param name="parentConnection">To be added.</param><param name="newConnection">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _ShouldMakeNewConnection (INSConnectionDelegate This, NSConnection parentConnection, NSConnection newConnection)
		{
			var parentConnection__handle__ = parentConnection!.GetNonNullHandle (nameof (parentConnection));
			var newConnection__handle__ = newConnection!.GetNonNullHandle (nameof (newConnection));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:shouldMakeNewConnection:"), parentConnection__handle__, newConnection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (parentConnection);
			GC.KeepAlive (newConnection);
			return ret != 0;
		}
		/// <param name="connection">To be added.</param><param name="request">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("connection:handleRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HandleRequest (NSConnection connection, NSDistantObjectRequest request)
		{
			return _HandleRequest (this, connection, request);
		}
		/// <param name="connection">To be added.</param><param name="request">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _HandleRequest (INSConnectionDelegate This, NSConnection connection, NSDistantObjectRequest request)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:handleRequest:"), connection__handle__, request__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (request);
			return ret != 0;
		}
		/// <param name="connection">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("createConversationForConnection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject CreateConversation (NSConnection connection)
		{
			return _CreateConversation (this, connection);
		}
		/// <param name="connection">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _CreateConversation (INSConnectionDelegate This, NSConnection connection)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("createConversationForConnection:"), connection__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			return ret!;
		}
		/// <param name="newConnection">To be added.</param><param name="parentConnection">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("makeNewConnection:sender:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowNewConnection (NSConnection newConnection, NSConnection parentConnection)
		{
			return _AllowNewConnection (this, newConnection, parentConnection);
		}
		/// <param name="newConnection">To be added.</param><param name="parentConnection">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _AllowNewConnection (INSConnectionDelegate This, NSConnection newConnection, NSConnection parentConnection)
		{
			var newConnection__handle__ = newConnection!.GetNonNullHandle (nameof (newConnection));
			var parentConnection__handle__ = parentConnection!.GetNonNullHandle (nameof (parentConnection));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("makeNewConnection:sender:"), newConnection__handle__, parentConnection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (newConnection);
			GC.KeepAlive (parentConnection);
			return ret != 0;
		}
		[DynamicDependencyAttribute ("AllowNewConnection(Foundation.NSConnection,Foundation.NSConnection)")]
		[DynamicDependencyAttribute ("AuthenticateComponents(Foundation.NSArray,Foundation.NSData)")]
		[DynamicDependencyAttribute ("CreateConversation(Foundation.NSConnection)")]
		[DynamicDependencyAttribute ("GetAuthenticationData(Foundation.NSArray)")]
		[DynamicDependencyAttribute ("HandleRequest(Foundation.NSConnection,Foundation.NSDistantObjectRequest)")]
		[DynamicDependencyAttribute ("ShouldMakeNewConnection(Foundation.NSConnection,Foundation.NSConnection)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSConnectionDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSConnectionDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSConnectionDelegate" /> interface to support all the methods from the NSConnectionDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSConnectionDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSConnectionDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSConnectionDelegate_Extensions {
		/// <param name="components">To be added.</param><param name="authenticationData">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AuthenticateComponents (this INSConnectionDelegate This, NSArray components, NSData authenticationData)
		{
			var components__handle__ = components!.GetNonNullHandle (nameof (components));
			var authenticationData__handle__ = authenticationData!.GetNonNullHandle (nameof (authenticationData));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("authenticateComponents:withData:"), components__handle__, authenticationData__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (components);
			GC.KeepAlive (authenticationData);
			return ret != 0;
		}
		/// <param name="components">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSData GetAuthenticationData (this INSConnectionDelegate This, NSArray components)
		{
			var components__handle__ = components!.GetNonNullHandle (nameof (components));
			NSData? ret;
			ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("authenticationDataForComponents:"), components__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (components);
			return ret!;
		}
		/// <param name="parentConnection">To be added.</param><param name="newConnection">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShouldMakeNewConnection (this INSConnectionDelegate This, NSConnection parentConnection, NSConnection newConnection)
		{
			var parentConnection__handle__ = parentConnection!.GetNonNullHandle (nameof (parentConnection));
			var newConnection__handle__ = newConnection!.GetNonNullHandle (nameof (newConnection));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:shouldMakeNewConnection:"), parentConnection__handle__, newConnection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (parentConnection);
			GC.KeepAlive (newConnection);
			return ret != 0;
		}
		/// <param name="connection">To be added.</param><param name="request">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HandleRequest (this INSConnectionDelegate This, NSConnection connection, NSDistantObjectRequest request)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:handleRequest:"), connection__handle__, request__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (request);
			return ret != 0;
		}
		/// <param name="connection">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject CreateConversation (this INSConnectionDelegate This, NSConnection connection)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("createConversationForConnection:"), connection__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			return ret!;
		}
		/// <param name="newConnection">To be added.</param><param name="parentConnection">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AllowNewConnection (this INSConnectionDelegate This, NSConnection newConnection, NSConnection parentConnection)
		{
			var newConnection__handle__ = newConnection!.GetNonNullHandle (nameof (newConnection));
			var parentConnection__handle__ = parentConnection!.GetNonNullHandle (nameof (parentConnection));
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("makeNewConnection:sender:"), newConnection__handle__, parentConnection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (newConnection);
			GC.KeepAlive (parentConnection);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSConnectionDelegateWrapper : BaseWrapper, INSConnectionDelegate {
		public NSConnectionDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSConnectionDelegateWrapper))]
		static NSConnectionDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace Foundation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSConnectionDelegate" /> (for the protocol <c>NSConnectionDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSConnectionDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__Foundation_NSConnectionDelegate", false)]
	[Model]
	[ObsoletedOSPlatform ("macos10.13", "Use 'NSXpcConnection' instead.")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[SupportedOSPlatform ("macos")]
	public unsafe partial class NSConnectionDelegate : NSObject, INSConnectionDelegate {
		/// <summary>Creates a new <see cref="NSConnectionDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSConnectionDelegate () : base (NSObjectFlag.Empty)
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
		protected NSConnectionDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSConnectionDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="newConnection">To be added.</param><param name="parentConnection">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("makeNewConnection:sender:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AllowNewConnection (NSConnection newConnection, NSConnection parentConnection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="components">To be added.</param><param name="authenticationData">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("authenticateComponents:withData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AuthenticateComponents (NSArray components, NSData authenticationData)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="connection">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("createConversationForConnection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject CreateConversation (NSConnection connection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="components">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("authenticationDataForComponents:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData GetAuthenticationData (NSArray components)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="connection">To be added.</param><param name="request">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("connection:handleRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HandleRequest (NSConnection connection, NSDistantObjectRequest request)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="parentConnection">To be added.</param><param name="newConnection">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("connection:shouldMakeNewConnection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShouldMakeNewConnection (NSConnection parentConnection, NSConnection newConnection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSConnectionDelegate */
}
