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
namespace WebKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>WebDocumentRepresentation</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos10.14", "No longer supported.")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "WebDocumentRepresentation", WrapperType = typeof (WebDocumentRepresentationWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDataSource", Selector = "setDataSource:", ParameterType = new Type [] { typeof (WebKit.WebDataSource) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReceivedData", Selector = "receivedData:withDataSource:", ParameterType = new Type [] { typeof (NSData), typeof (WebKit.WebDataSource) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "ReceivedError", Selector = "receivedError:withDataSource:", ParameterType = new Type [] { typeof (NSError), typeof (WebKit.WebDataSource) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishedLoading", Selector = "finishedLoadingWithDataSource:", ParameterType = new Type [] { typeof (WebKit.WebDataSource) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "CanProvideDocumentSource", Selector = "canProvideDocumentSource", PropertyType = typeof (bool), GetterSelector = "canProvideDocumentSource", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "DocumentSource", Selector = "documentSource", PropertyType = typeof (string), GetterSelector = "documentSource", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Title", Selector = "title", PropertyType = typeof (string), GetterSelector = "title", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IWebDocumentRepresentation : INativeObject, IDisposable
	{
		/// <param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("setDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDataSource (WebDataSource dataSource)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetDataSource (IWebDocumentRepresentation This, WebDataSource dataSource)
		{
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setDataSource:"), dataSource__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (dataSource);
		}
		/// <param name="data">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("receivedData:withDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedData (NSData data, WebDataSource dataSource)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="data">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReceivedData (IWebDocumentRepresentation This, NSData data, WebDataSource dataSource)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("receivedData:withDataSource:"), data__handle__, dataSource__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (data);
			GC.KeepAlive (dataSource);
		}
		/// <param name="error">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("receivedError:withDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedError (NSError error, WebDataSource dataSource)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="error">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _ReceivedError (IWebDocumentRepresentation This, NSError error, WebDataSource dataSource)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("receivedError:withDataSource:"), error__handle__, dataSource__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (error);
			GC.KeepAlive (dataSource);
		}
		/// <param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("finishedLoadingWithDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishedLoading (WebDataSource dataSource)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _FinishedLoading (IWebDocumentRepresentation This, WebDataSource dataSource)
		{
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("finishedLoadingWithDataSource:"), dataSource__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (dataSource);
		}
		[DynamicDependencyAttribute ("CanProvideDocumentSource")]
		[DynamicDependencyAttribute ("DocumentSource")]
		[DynamicDependencyAttribute ("FinishedLoading(WebKit.WebDataSource)")]
		[DynamicDependencyAttribute ("ReceivedData(Foundation.NSData,WebKit.WebDataSource)")]
		[DynamicDependencyAttribute ("ReceivedError(Foundation.NSError,WebKit.WebDataSource)")]
		[DynamicDependencyAttribute ("SetDataSource(WebKit.WebDataSource)")]
		[DynamicDependencyAttribute ("Title")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WebDocumentRepresentationWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IWebDocumentRepresentation ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual bool CanProvideDocumentSource {
			[Export ("canProvideDocumentSource")]
			get {
				return _GetCanProvideDocumentSource (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetCanProvideDocumentSource (IWebDocumentRepresentation This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("canProvideDocumentSource"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string DocumentSource {
			[Export ("documentSource")]
			get {
				return _GetDocumentSource (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetDocumentSource (IWebDocumentRepresentation This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("documentSource")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string Title {
			[Export ("title")]
			get {
				return _GetTitle (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetTitle (IWebDocumentRepresentation This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("title")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class WebDocumentRepresentationWrapper : BaseWrapper, IWebDocumentRepresentation {
		public WebDocumentRepresentationWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (WebDocumentRepresentationWrapper))]
		static WebDocumentRepresentationWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetDataSource (WebDataSource dataSource)
		{
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setDataSource:"), dataSource__handle__);
			GC.KeepAlive (dataSource);
		}
		/// <param name="data">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("receivedData:withDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ReceivedData (NSData data, WebDataSource dataSource)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("receivedData:withDataSource:"), data__handle__, dataSource__handle__);
			GC.KeepAlive (data);
			GC.KeepAlive (dataSource);
		}
		/// <param name="error">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("receivedError:withDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void ReceivedError (NSError error, WebDataSource dataSource)
		{
			var error__handle__ = error!.GetNonNullHandle (nameof (error));
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("receivedError:withDataSource:"), error__handle__, dataSource__handle__);
			GC.KeepAlive (error);
			GC.KeepAlive (dataSource);
		}
		/// <param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("finishedLoadingWithDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void FinishedLoading (WebDataSource dataSource)
		{
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("finishedLoadingWithDataSource:"), dataSource__handle__);
			GC.KeepAlive (dataSource);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public bool CanProvideDocumentSource {
			[Export ("canProvideDocumentSource")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canProvideDocumentSource"));
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string DocumentSource {
			[Export ("documentSource")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("documentSource")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string Title {
			[Export ("title")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("title")), false)!;
				return ret;
			}
		}
	}
}
namespace WebKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IWebDocumentRepresentation" /> (for the protocol <c>WebDocumentRepresentation</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IWebDocumentRepresentation" />.</para>
	/// </summary>
	[Protocol()]
	[Register("Microsoft_macOS__WebKit_WebDocumentRepresentation", false)]
	[Model]
	[UnsupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("maccatalyst")]
	[ObsoletedOSPlatform ("macos10.14", "No longer supported.")]
	[SupportedOSPlatform ("macos")]
	public unsafe abstract partial class WebDocumentRepresentation : NSObject, IWebDocumentRepresentation {
		/// <summary>Creates a new <see cref="WebDocumentRepresentation" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected WebDocumentRepresentation () : base (NSObjectFlag.Empty)
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
		protected WebDocumentRepresentation (NSObjectFlag t) : base (t)
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
		protected internal WebDocumentRepresentation (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("finishedLoadingWithDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FinishedLoading (WebDataSource dataSource)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="data">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("receivedData:withDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedData (NSData data, WebDataSource dataSource)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="error">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("receivedError:withDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReceivedError (NSError error, WebDataSource dataSource)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="dataSource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setDataSource:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetDataSource (WebDataSource dataSource)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanProvideDocumentSource {
			[Export ("canProvideDocumentSource")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string DocumentSource {
			[Export ("documentSource")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Title {
			[Export ("title")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
	} /* class WebDocumentRepresentation */
}
