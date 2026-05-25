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
namespace ImageKit {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>IKImageBrowserItem</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "IKImageBrowserItem", WrapperType = typeof (IKImageBrowserItemWrapper), IsInformal = true)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ImageUID", Selector = "imageUID", PropertyType = typeof (string), GetterSelector = "imageUID", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ImageRepresentationType", Selector = "imageRepresentationType", PropertyType = typeof (NSString), GetterSelector = "imageRepresentationType", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ImageRepresentation", Selector = "imageRepresentation", PropertyType = typeof (NSObject), GetterSelector = "imageRepresentation", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ImageVersion", Selector = "imageVersion", PropertyType = typeof (IntPtr), GetterSelector = "imageVersion", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ImageTitle", Selector = "imageTitle", PropertyType = typeof (string), GetterSelector = "imageTitle", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ImageSubtitle", Selector = "imageSubtitle", PropertyType = typeof (string), GetterSelector = "imageSubtitle", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "IsSelectable", Selector = "isSelectable", PropertyType = typeof (bool), GetterSelector = "isSelectable", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IIKImageBrowserItem : INativeObject, IDisposable
	{
		[DynamicDependencyAttribute ("ImageRepresentation")]
		[DynamicDependencyAttribute ("ImageRepresentationType")]
		[DynamicDependencyAttribute ("ImageSubtitle")]
		[DynamicDependencyAttribute ("ImageTitle")]
		[DynamicDependencyAttribute ("ImageUID")]
		[DynamicDependencyAttribute ("ImageVersion")]
		[DynamicDependencyAttribute ("IsSelectable")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (IKImageBrowserItemWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IIKImageBrowserItem ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string ImageUID {
			[Export ("imageUID")]
			get {
				return _GetImageUID (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetImageUID (IIKImageBrowserItem This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("imageUID")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSString ImageRepresentationType {
			[Export ("imageRepresentationType")]
			get {
				return _GetImageRepresentationType (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSString _GetImageRepresentationType (IIKImageBrowserItem This)
		{
			NSString ret;
			ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("imageRepresentationType")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual NSObject ImageRepresentation {
			[Export ("imageRepresentation")]
			get {
				return _GetImageRepresentation (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSObject _GetImageRepresentation (IIKImageBrowserItem This)
		{
			NSObject ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("imageRepresentation")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual nint ImageVersion {
			[Export ("imageVersion")]
			get {
				return _GetImageVersion (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nint _GetImageVersion (IIKImageBrowserItem This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("imageVersion"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual string ImageTitle {
			[Export ("imageTitle")]
			get {
				return _GetImageTitle (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetImageTitle (IIKImageBrowserItem This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("imageTitle")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual string ImageSubtitle {
			[Export ("imageSubtitle")]
			get {
				return _GetImageSubtitle (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetImageSubtitle (IIKImageBrowserItem This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("imageSubtitle")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.OptionalMember]
		public virtual bool IsSelectable {
			[Export ("isSelectable")]
			get {
				return _GetIsSelectable (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetIsSelectable (IIKImageBrowserItem This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSelectable"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IIKImageBrowserItem" /> interface to support all the methods from the IKImageBrowserItem protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IIKImageBrowserItem" /> interface allow developers to treat instances of the interface as having all the optional methods of the original IKImageBrowserItem protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class IKImageBrowserItem_Extensions {
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint GetImageVersion (this IIKImageBrowserItem This)
		{
			nint ret;
			ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("imageVersion"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetImageTitle (this IIKImageBrowserItem This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("imageTitle")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetImageSubtitle (this IIKImageBrowserItem This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("imageSubtitle")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetIsSelectable (this IIKImageBrowserItem This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSelectable"));
			GC.KeepAlive (This);
			return ret != 0;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class IKImageBrowserItemWrapper : BaseWrapper, IIKImageBrowserItem {
		public IKImageBrowserItemWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (IKImageBrowserItemWrapper))]
		static IKImageBrowserItemWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string ImageUID {
			[Export ("imageUID")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("imageUID")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSString ImageRepresentationType {
			[Export ("imageRepresentationType")]
			get {
				NSString ret;
				ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("imageRepresentationType")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject ImageRepresentation {
			[Export ("imageRepresentation")]
			get {
				NSObject ret;
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("imageRepresentation")), false)!;
				return ret;
			}
		}
	}
}
namespace ImageKit {
	/// <summary>
	///   <para>This is a class that implements the interface <see cref="IIKImageBrowserItem" /> (for the protocol <c>IKImageBrowserItem</c>).</para>
	///   <para>Subclass this class to easily create a type that implements the protocol.</para>
	///   <para>An alternative is to create a subclass of <see cref="NSObject" /> and then implemented the interface <see cref="IIKImageBrowserItem" />.</para>
	/// </summary>
	[Protocol(IsInformal = true)]
	[Register("Microsoft_macOS__ImageKit_IKImageBrowserItem", false)]
	[Model]
	public unsafe abstract partial class IKImageBrowserItem : NSObject, IIKImageBrowserItem {
		/// <summary>Creates a new <see cref="IKImageBrowserItem" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected IKImageBrowserItem () : base (NSObjectFlag.Empty)
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
		protected IKImageBrowserItem (NSObjectFlag t) : base (t)
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
		protected internal IKImageBrowserItem (NativeHandle handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject ImageRepresentation {
			[Export ("imageRepresentation")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString ImageRepresentationType {
			[Export ("imageRepresentationType")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ImageSubtitle {
			[Export ("imageSubtitle")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ImageTitle {
			[Export ("imageTitle")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ImageUID {
			[Export ("imageUID")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ImageVersion {
			[Export ("imageVersion")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsSelectable {
			[Export ("isSelectable")]
			get {
				throw new ModelNotImplementedException ();
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CGImageRepresentationType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserCGImageRepresentationType",  "ImageKit")]
		public static NSString CGImageRepresentationType {
			get {
				if (_CGImageRepresentationType is null)
					_CGImageRepresentationType = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserCGImageRepresentationType")!;
				return _CGImageRepresentationType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CGImageSourceRepresentationType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserCGImageSourceRepresentationType",  "ImageKit")]
		public static NSString CGImageSourceRepresentationType {
			get {
				if (_CGImageSourceRepresentationType is null)
					_CGImageSourceRepresentationType = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserCGImageSourceRepresentationType")!;
				return _CGImageSourceRepresentationType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IconRefPathRepresentationType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserIconRefPathRepresentationType",  "ImageKit")]
		public static NSString IconRefPathRepresentationType {
			get {
				if (_IconRefPathRepresentationType is null)
					_IconRefPathRepresentationType = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserIconRefPathRepresentationType")!;
				return _IconRefPathRepresentationType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _IconRefRepresentationType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserIconRefRepresentationType",  "ImageKit")]
		public static NSString IconRefRepresentationType {
			get {
				if (_IconRefRepresentationType is null)
					_IconRefRepresentationType = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserIconRefRepresentationType")!;
				return _IconRefRepresentationType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSBitmapImageRepresentationType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserNSBitmapImageRepresentationType",  "ImageKit")]
		public static NSString NSBitmapImageRepresentationType {
			get {
				if (_NSBitmapImageRepresentationType is null)
					_NSBitmapImageRepresentationType = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserNSBitmapImageRepresentationType")!;
				return _NSBitmapImageRepresentationType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSDataRepresentationType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserNSDataRepresentationType",  "ImageKit")]
		public static NSString NSDataRepresentationType {
			get {
				if (_NSDataRepresentationType is null)
					_NSDataRepresentationType = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserNSDataRepresentationType")!;
				return _NSDataRepresentationType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSImageRepresentationType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserNSImageRepresentationType",  "ImageKit")]
		public static NSString NSImageRepresentationType {
			get {
				if (_NSImageRepresentationType is null)
					_NSImageRepresentationType = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserNSImageRepresentationType")!;
				return _NSImageRepresentationType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NSURLRepresentationType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserNSURLRepresentationType",  "ImageKit")]
		public static NSString NSURLRepresentationType {
			get {
				if (_NSURLRepresentationType is null)
					_NSURLRepresentationType = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserNSURLRepresentationType")!;
				return _NSURLRepresentationType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PDFPageRepresentationType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserPDFPageRepresentationType",  "ImageKit")]
		public static NSString PDFPageRepresentationType {
			get {
				if (_PDFPageRepresentationType is null)
					_PDFPageRepresentationType = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserPDFPageRepresentationType")!;
				return _PDFPageRepresentationType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PathRepresentationType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserPathRepresentationType",  "ImageKit")]
		public static NSString PathRepresentationType {
			get {
				if (_PathRepresentationType is null)
					_PathRepresentationType = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserPathRepresentationType")!;
				return _PathRepresentationType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QCCompositionPathRepresentationType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserQCCompositionPathRepresentationType",  "ImageKit")]
		public static NSString QCCompositionPathRepresentationType {
			get {
				if (_QCCompositionPathRepresentationType is null)
					_QCCompositionPathRepresentationType = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserQCCompositionPathRepresentationType")!;
				return _QCCompositionPathRepresentationType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QCCompositionRepresentationType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserQCCompositionRepresentationType",  "ImageKit")]
		public static NSString QCCompositionRepresentationType {
			get {
				if (_QCCompositionRepresentationType is null)
					_QCCompositionRepresentationType = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserQCCompositionRepresentationType")!;
				return _QCCompositionRepresentationType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QTMoviePathRepresentationType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserQTMoviePathRepresentationType",  "ImageKit")]
		public static NSString QTMoviePathRepresentationType {
			get {
				if (_QTMoviePathRepresentationType is null)
					_QTMoviePathRepresentationType = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserQTMoviePathRepresentationType")!;
				return _QTMoviePathRepresentationType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QTMovieRepresentationType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserQTMovieRepresentationType",  "ImageKit")]
		public static NSString QTMovieRepresentationType {
			get {
				if (_QTMovieRepresentationType is null)
					_QTMovieRepresentationType = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserQTMovieRepresentationType")!;
				return _QTMovieRepresentationType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _QuickLookPathRepresentationType;
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("IKImageBrowserQuickLookPathRepresentationType",  "ImageKit")]
		public static NSString QuickLookPathRepresentationType {
			get {
				if (_QuickLookPathRepresentationType is null)
					_QuickLookPathRepresentationType = Dlfcn.GetStringConstant (Libraries.ImageKit.Handle, "IKImageBrowserQuickLookPathRepresentationType")!;
				return _QuickLookPathRepresentationType;
			}
		}
	} /* class IKImageBrowserItem */
}
