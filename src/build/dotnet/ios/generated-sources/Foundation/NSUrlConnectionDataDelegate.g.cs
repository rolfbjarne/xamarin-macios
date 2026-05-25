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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Foundation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSURLConnectionDataDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "NSURLConnectionDataDelegate", WrapperType = typeof (NSUrlConnectionDataDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillSendRequest", Selector = "connection:willSendRequest:redirectResponse:", ReturnType = typeof (NSUrlRequest), ParameterType = new Type [] { typeof (NSUrlConnection), typeof (NSUrlRequest), typeof (NSUrlResponse) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedResponse", Selector = "connection:didReceiveResponse:", ParameterType = new Type [] { typeof (NSUrlConnection), typeof (NSUrlResponse) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedData", Selector = "connection:didReceiveData:", ParameterType = new Type [] { typeof (NSUrlConnection), typeof (NSData) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "NeedNewBodyStream", Selector = "connection:needNewBodyStream:", ReturnType = typeof (NSInputStream), ParameterType = new Type [] { typeof (NSUrlConnection), typeof (NSUrlRequest) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SentBodyData", Selector = "connection:didSendBodyData:totalBytesWritten:totalBytesExpectedToWrite:", ParameterType = new Type [] { typeof (NSUrlConnection), typeof (IntPtr), typeof (IntPtr), typeof (IntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillCacheResponse", Selector = "connection:willCacheResponse:", ReturnType = typeof (NSCachedUrlResponse), ParameterType = new Type [] { typeof (NSUrlConnection), typeof (NSCachedUrlResponse) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FinishedLoading", Selector = "connectionDidFinishLoading:", ParameterType = new Type [] { typeof (NSUrlConnection) }, ParameterByRef = new bool [] { false })]
	public partial interface INSUrlConnectionDataDelegate : INativeObject, IDisposable, 
		Foundation.INSUrlConnectionDelegate
	{
		/// <param name="connection">To be added.</param><param name="request">To be added.</param><param name="response">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("connection:willSendRequest:redirectResponse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrlRequest WillSendRequest (NSUrlConnection connection, NSUrlRequest request, NSUrlResponse response)
		{
			return _WillSendRequest (this, connection, request, response);
		}
		/// <param name="connection">To be added.</param><param name="request">To be added.</param><param name="response">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSUrlRequest _WillSendRequest (INSUrlConnectionDataDelegate This, NSUrlConnection connection, NSUrlRequest request, NSUrlResponse response)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			NSUrlRequest? ret;
			ret =  Runtime.GetNSObject<NSUrlRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:willSendRequest:redirectResponse:"), connection__handle__, request__handle__, response__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (request);
			GC.KeepAlive (response);
			return ret!;
		}
		/// <param name="connection">To be added.</param><param name="response">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("connection:didReceiveResponse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedResponse (NSUrlConnection connection, NSUrlResponse response)
		{
			_ReceivedResponse (this, connection, response);
		}
		/// <param name="connection">To be added.</param><param name="response">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReceivedResponse (INSUrlConnectionDataDelegate This, NSUrlConnection connection, NSUrlResponse response)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:didReceiveResponse:"), connection__handle__, response__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (response);
		}
		/// <param name="connection">To be added.</param><param name="data">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("connection:didReceiveData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedData (NSUrlConnection connection, NSData data)
		{
			_ReceivedData (this, connection, data);
		}
		/// <param name="connection">To be added.</param><param name="data">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReceivedData (INSUrlConnectionDataDelegate This, NSUrlConnection connection, NSData data)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:didReceiveData:"), connection__handle__, data__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (data);
		}
		/// <param name="connection">To be added.</param><param name="request">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("connection:needNewBodyStream:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSInputStream NeedNewBodyStream (NSUrlConnection connection, NSUrlRequest request)
		{
			return _NeedNewBodyStream (this, connection, request);
		}
		/// <param name="connection">To be added.</param><param name="request">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSInputStream _NeedNewBodyStream (INSUrlConnectionDataDelegate This, NSUrlConnection connection, NSUrlRequest request)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			NSInputStream? ret;
			ret =  Runtime.GetNSObject<NSInputStream> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:needNewBodyStream:"), connection__handle__, request__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (request);
			return ret!;
		}
		/// <param name="connection">To be added.</param><param name="bytesWritten">To be added.</param><param name="totalBytesWritten">To be added.</param><param name="totalBytesExpectedToWrite">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("connection:didSendBodyData:totalBytesWritten:totalBytesExpectedToWrite:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SentBodyData (NSUrlConnection connection, nint bytesWritten, nint totalBytesWritten, nint totalBytesExpectedToWrite)
		{
			_SentBodyData (this, connection, bytesWritten, totalBytesWritten, totalBytesExpectedToWrite);
		}
		/// <param name="connection">To be added.</param><param name="bytesWritten">To be added.</param><param name="totalBytesWritten">To be added.</param><param name="totalBytesExpectedToWrite">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SentBodyData (INSUrlConnectionDataDelegate This, NSUrlConnection connection, nint bytesWritten, nint totalBytesWritten, nint totalBytesExpectedToWrite)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("connection:didSendBodyData:totalBytesWritten:totalBytesExpectedToWrite:"), connection__handle__, bytesWritten, totalBytesWritten, totalBytesExpectedToWrite);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
		}
		/// <param name="connection">To be added.</param><param name="cachedResponse">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("connection:willCacheResponse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCachedUrlResponse WillCacheResponse (NSUrlConnection connection, NSCachedUrlResponse cachedResponse)
		{
			return _WillCacheResponse (this, connection, cachedResponse);
		}
		/// <param name="connection">To be added.</param><param name="cachedResponse">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSCachedUrlResponse _WillCacheResponse (INSUrlConnectionDataDelegate This, NSUrlConnection connection, NSCachedUrlResponse cachedResponse)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var cachedResponse__handle__ = cachedResponse!.GetNonNullHandle (nameof (cachedResponse));
			NSCachedUrlResponse? ret;
			ret =  Runtime.GetNSObject<NSCachedUrlResponse> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:willCacheResponse:"), connection__handle__, cachedResponse__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (cachedResponse);
			return ret!;
		}
		/// <param name="connection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("connectionDidFinishLoading:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishedLoading (NSUrlConnection connection)
		{
			_FinishedLoading (this, connection);
		}
		/// <param name="connection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FinishedLoading (INSUrlConnectionDataDelegate This, NSUrlConnection connection)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("connectionDidFinishLoading:"), connection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
		}
		[DynamicDependencyAttribute ("FinishedLoading(Foundation.NSUrlConnection)")]
		[DynamicDependencyAttribute ("NeedNewBodyStream(Foundation.NSUrlConnection,Foundation.NSUrlRequest)")]
		[DynamicDependencyAttribute ("ReceivedData(Foundation.NSUrlConnection,Foundation.NSData)")]
		[DynamicDependencyAttribute ("ReceivedResponse(Foundation.NSUrlConnection,Foundation.NSUrlResponse)")]
		[DynamicDependencyAttribute ("SentBodyData(Foundation.NSUrlConnection,System.IntPtr,System.IntPtr,System.IntPtr)")]
		[DynamicDependencyAttribute ("WillCacheResponse(Foundation.NSUrlConnection,Foundation.NSCachedUrlResponse)")]
		[DynamicDependencyAttribute ("WillSendRequest(Foundation.NSUrlConnection,Foundation.NSUrlRequest,Foundation.NSUrlResponse)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUrlConnectionDataDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSUrlConnectionDataDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSUrlConnectionDataDelegate" /> interface to support all the methods from the NSURLConnectionDataDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSUrlConnectionDataDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSURLConnectionDataDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSUrlConnectionDataDelegate_Extensions {
		/// <param name="connection">To be added.</param><param name="request">To be added.</param><param name="response">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSUrlRequest WillSendRequest (this INSUrlConnectionDataDelegate This, NSUrlConnection connection, NSUrlRequest request, NSUrlResponse response)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			NSUrlRequest? ret;
			ret =  Runtime.GetNSObject<NSUrlRequest> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:willSendRequest:redirectResponse:"), connection__handle__, request__handle__, response__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (request);
			GC.KeepAlive (response);
			return ret!;
		}
		/// <param name="connection">To be added.</param><param name="response">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReceivedResponse (this INSUrlConnectionDataDelegate This, NSUrlConnection connection, NSUrlResponse response)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:didReceiveResponse:"), connection__handle__, response__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (response);
		}
		/// <param name="connection">To be added.</param><param name="data">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ReceivedData (this INSUrlConnectionDataDelegate This, NSUrlConnection connection, NSData data)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:didReceiveData:"), connection__handle__, data__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (data);
		}
		/// <param name="connection">To be added.</param><param name="request">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSInputStream NeedNewBodyStream (this INSUrlConnectionDataDelegate This, NSUrlConnection connection, NSUrlRequest request)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var request__handle__ = request!.GetNonNullHandle (nameof (request));
			NSInputStream? ret;
			ret =  Runtime.GetNSObject<NSInputStream> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:needNewBodyStream:"), connection__handle__, request__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (request);
			return ret!;
		}
		/// <param name="connection">To be added.</param><param name="bytesWritten">To be added.</param><param name="totalBytesWritten">To be added.</param><param name="totalBytesExpectedToWrite">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SentBodyData (this INSUrlConnectionDataDelegate This, NSUrlConnection connection, nint bytesWritten, nint totalBytesWritten, nint totalBytesExpectedToWrite)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("connection:didSendBodyData:totalBytesWritten:totalBytesExpectedToWrite:"), connection__handle__, bytesWritten, totalBytesWritten, totalBytesExpectedToWrite);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
		}
		/// <param name="connection">To be added.</param><param name="cachedResponse">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSCachedUrlResponse WillCacheResponse (this INSUrlConnectionDataDelegate This, NSUrlConnection connection, NSCachedUrlResponse cachedResponse)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var cachedResponse__handle__ = cachedResponse!.GetNonNullHandle (nameof (cachedResponse));
			NSCachedUrlResponse? ret;
			ret =  Runtime.GetNSObject<NSCachedUrlResponse> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connection:willCacheResponse:"), connection__handle__, cachedResponse__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (cachedResponse);
			return ret!;
		}
		/// <param name="connection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FinishedLoading (this INSUrlConnectionDataDelegate This, NSUrlConnection connection)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("connectionDidFinishLoading:"), connection__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSUrlConnectionDataDelegateWrapper : BaseWrapper, INSUrlConnectionDataDelegate {
		public NSUrlConnectionDataDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUrlConnectionDataDelegateWrapper))]
		static NSUrlConnectionDataDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
	}
}
namespace Foundation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSUrlConnectionDataDelegate" /> (for the protocol <c>NSURLConnectionDataDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSUrlConnectionDataDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_iOS__Foundation_NSUrlConnectionDataDelegate", false)]
	[Model]
	public unsafe partial class NSUrlConnectionDataDelegate : NSUrlConnectionDelegate, INSUrlConnectionDataDelegate {
		/// <summary>Creates a new <see cref="NSUrlConnectionDataDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSUrlConnectionDataDelegate () : base (NSObjectFlag.Empty)
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
		protected NSUrlConnectionDataDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSUrlConnectionDataDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="connection">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("connectionDidFinishLoading:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishedLoading (NSUrlConnection connection)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="connection">To be added.</param><param name="request">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("connection:needNewBodyStream:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSInputStream NeedNewBodyStream (NSUrlConnection connection, NSUrlRequest request)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="connection">To be added.</param><param name="data">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("connection:didReceiveData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedData (NSUrlConnection connection, NSData data)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="connection">To be added.</param><param name="response">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("connection:didReceiveResponse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedResponse (NSUrlConnection connection, NSUrlResponse response)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="connection">To be added.</param><param name="bytesWritten">To be added.</param><param name="totalBytesWritten">To be added.</param><param name="totalBytesExpectedToWrite">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("connection:didSendBodyData:totalBytesWritten:totalBytesExpectedToWrite:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SentBodyData (NSUrlConnection connection, nint bytesWritten, nint totalBytesWritten, nint totalBytesExpectedToWrite)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="connection">To be added.</param><param name="cachedResponse">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("connection:willCacheResponse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSCachedUrlResponse WillCacheResponse (NSUrlConnection connection, NSCachedUrlResponse cachedResponse)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="connection">To be added.</param><param name="request">To be added.</param><param name="response">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("connection:willSendRequest:redirectResponse:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrlRequest WillSendRequest (NSUrlConnection connection, NSUrlRequest request, NSUrlResponse response)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSUrlConnectionDataDelegate */
}
