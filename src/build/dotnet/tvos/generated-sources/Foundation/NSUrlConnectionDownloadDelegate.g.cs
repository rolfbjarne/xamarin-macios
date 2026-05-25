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
namespace Foundation {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>NSURLConnectionDownloadDelegate</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "NSURLConnectionDownloadDelegate", WrapperType = typeof (NSUrlConnectionDownloadDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "WroteData", Selector = "connection:didWriteData:totalBytesWritten:expectedTotalBytes:", ParameterType = new Type [] { typeof (NSUrlConnection), typeof (long), typeof (long), typeof (long) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResumedDownloading", Selector = "connectionDidResumeDownloading:totalBytesWritten:expectedTotalBytes:", ParameterType = new Type [] { typeof (NSUrlConnection), typeof (long), typeof (long) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishedDownloading", Selector = "connectionDidFinishDownloading:destinationURL:", ParameterType = new Type [] { typeof (NSUrlConnection), typeof (NSUrl) }, ParameterByRef = new bool [] { false, false })]
	public partial interface INSUrlConnectionDownloadDelegate : INativeObject, IDisposable, 
		Foundation.INSUrlConnectionDelegate
	{
		/// <param name="connection">To be added.</param><param name="bytesWritten">To be added.</param><param name="totalBytesWritten">To be added.</param><param name="expectedTotalBytes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("connection:didWriteData:totalBytesWritten:expectedTotalBytes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WroteData (NSUrlConnection connection, long bytesWritten, long totalBytesWritten, long expectedTotalBytes)
		{
			_WroteData (this, connection, bytesWritten, totalBytesWritten, expectedTotalBytes);
		}
		/// <param name="connection">To be added.</param><param name="bytesWritten">To be added.</param><param name="totalBytesWritten">To be added.</param><param name="expectedTotalBytes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _WroteData (INSUrlConnectionDownloadDelegate This, NSUrlConnection connection, long bytesWritten, long totalBytesWritten, long expectedTotalBytes)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Int64_Int64_Int64 (This.Handle, Selector.GetHandle ("connection:didWriteData:totalBytesWritten:expectedTotalBytes:"), connection__handle__, bytesWritten, totalBytesWritten, expectedTotalBytes);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
		}
		/// <param name="connection">To be added.</param><param name="totalBytesWritten">To be added.</param><param name="expectedTotalBytes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("connectionDidResumeDownloading:totalBytesWritten:expectedTotalBytes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResumedDownloading (NSUrlConnection connection, long totalBytesWritten, long expectedTotalBytes)
		{
			_ResumedDownloading (this, connection, totalBytesWritten, expectedTotalBytes);
		}
		/// <param name="connection">To be added.</param><param name="totalBytesWritten">To be added.</param><param name="expectedTotalBytes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ResumedDownloading (INSUrlConnectionDownloadDelegate This, NSUrlConnection connection, long totalBytesWritten, long expectedTotalBytes)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Int64_Int64 (This.Handle, Selector.GetHandle ("connectionDidResumeDownloading:totalBytesWritten:expectedTotalBytes:"), connection__handle__, totalBytesWritten, expectedTotalBytes);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
		}
		/// <param name="connection">To be added.</param><param name="destinationUrl">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("connectionDidFinishDownloading:destinationURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishedDownloading (NSUrlConnection connection, NSUrl destinationUrl)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="connection">To be added.</param><param name="destinationUrl">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FinishedDownloading (INSUrlConnectionDownloadDelegate This, NSUrlConnection connection, NSUrl destinationUrl)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var destinationUrl__handle__ = destinationUrl!.GetNonNullHandle (nameof (destinationUrl));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("connectionDidFinishDownloading:destinationURL:"), connection__handle__, destinationUrl__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
			GC.KeepAlive (destinationUrl);
		}
		[DynamicDependencyAttribute ("FinishedDownloading(Foundation.NSUrlConnection,Foundation.NSUrl)")]
		[DynamicDependencyAttribute ("ResumedDownloading(Foundation.NSUrlConnection,System.Int64,System.Int64)")]
		[DynamicDependencyAttribute ("WroteData(Foundation.NSUrlConnection,System.Int64,System.Int64,System.Int64)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUrlConnectionDownloadDelegateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static INSUrlConnectionDownloadDelegate ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="INSUrlConnectionDownloadDelegate" /> interface to support all the methods from the NSURLConnectionDownloadDelegate protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="INSUrlConnectionDownloadDelegate" /> interface allow developers to treat instances of the interface as having all the optional methods of the original NSURLConnectionDownloadDelegate protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class NSUrlConnectionDownloadDelegate_Extensions {
		/// <param name="connection">To be added.</param><param name="bytesWritten">To be added.</param><param name="totalBytesWritten">To be added.</param><param name="expectedTotalBytes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void WroteData (this INSUrlConnectionDownloadDelegate This, NSUrlConnection connection, long bytesWritten, long totalBytesWritten, long expectedTotalBytes)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Int64_Int64_Int64 (This.Handle, Selector.GetHandle ("connection:didWriteData:totalBytesWritten:expectedTotalBytes:"), connection__handle__, bytesWritten, totalBytesWritten, expectedTotalBytes);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
		}
		/// <param name="connection">To be added.</param><param name="totalBytesWritten">To be added.</param><param name="expectedTotalBytes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ResumedDownloading (this INSUrlConnectionDownloadDelegate This, NSUrlConnection connection, long totalBytesWritten, long expectedTotalBytes)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_Int64_Int64 (This.Handle, Selector.GetHandle ("connectionDidResumeDownloading:totalBytesWritten:expectedTotalBytes:"), connection__handle__, totalBytesWritten, expectedTotalBytes);
			GC.KeepAlive (This);
			GC.KeepAlive (connection);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class NSUrlConnectionDownloadDelegateWrapper : BaseWrapper, INSUrlConnectionDownloadDelegate {
		public NSUrlConnectionDownloadDelegateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (NSUrlConnectionDownloadDelegateWrapper))]
		static NSUrlConnectionDownloadDelegateWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="connection">To be added.</param><param name="destinationUrl">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("connectionDidFinishDownloading:destinationURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FinishedDownloading (NSUrlConnection connection, NSUrl destinationUrl)
		{
			var connection__handle__ = connection!.GetNonNullHandle (nameof (connection));
			var destinationUrl__handle__ = destinationUrl!.GetNonNullHandle (nameof (destinationUrl));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("connectionDidFinishDownloading:destinationURL:"), connection__handle__, destinationUrl__handle__);
			GC.KeepAlive (connection);
			GC.KeepAlive (destinationUrl);
		}
	}
}
namespace Foundation {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="INSUrlConnectionDownloadDelegate" /> (for the protocol <c>NSURLConnectionDownloadDelegate</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="INSUrlConnectionDownloadDelegate" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_tvOS__Foundation_NSUrlConnectionDownloadDelegate", false)]
	[Model]
	public unsafe abstract partial class NSUrlConnectionDownloadDelegate : NSUrlConnectionDelegate, INSUrlConnectionDownloadDelegate {
		/// <summary>Creates a new <see cref="NSUrlConnectionDownloadDelegate" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected NSUrlConnectionDownloadDelegate () : base (NSObjectFlag.Empty)
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
		protected NSUrlConnectionDownloadDelegate (NSObjectFlag t) : base (t)
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
		protected internal NSUrlConnectionDownloadDelegate (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="connection">To be added.</param><param name="destinationUrl">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("connectionDidFinishDownloading:destinationURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishedDownloading (NSUrlConnection connection, NSUrl destinationUrl)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="connection">To be added.</param><param name="totalBytesWritten">To be added.</param><param name="expectedTotalBytes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("connectionDidResumeDownloading:totalBytesWritten:expectedTotalBytes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResumedDownloading (NSUrlConnection connection, long totalBytesWritten, long expectedTotalBytes)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="connection">To be added.</param><param name="bytesWritten">To be added.</param><param name="totalBytesWritten">To be added.</param><param name="expectedTotalBytes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("connection:didWriteData:totalBytesWritten:expectedTotalBytes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void WroteData (NSUrlConnection connection, long bytesWritten, long totalBytesWritten, long expectedTotalBytes)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class NSUrlConnectionDownloadDelegate */
}
