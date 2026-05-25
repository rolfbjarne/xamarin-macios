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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace SceneKit {
	/// <summary>Provides vertex data that, in conjunction with SCNGeometryElements, define a 3D object.</summary><remarks><para>Developers who wish to programmatically generate custom <see cref="T:SceneKit.SCNGeometry" /> objects use the <see cref="M:SceneKit.SCNGeometry.Create(SceneKit.SCNGeometrySource[],SceneKit.SCNGeometryElement[])" /> method. The form and number of the <see cref="T:SceneKit.SCNGeometrySource" /> objects varies based on the manner in which the developer is describing the geometry (for instance, whether vertex data comes as a series of triplets describing triangles or a moving series that describes a triangle strip) and whether the geometry will simply be colored or have a texture map.</para><para>The following code demonstrates the custom code to create a custom four-sided pyramid. This example shows the use of vertices, defining triangles, on which a single texture is mapped. Note how specific index values within <c>locs</c> are used to define <c>indices</c> and how the ordering within <c>locs</c> affects <c>normals</c> and <c>txCoords</c>. Also, notice how the triplets in <c>indices</c> are linked to <c>SCNGeometryPrimitiveType.Triangles</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// //Lower-left
	/// var a = new SCNVector3(-1, -1, 0);
	/// //Upper-right
	/// var b = new SCNVector3(1, 1, 0);
	/// 
	/// var halfX = (c.X + a.X) / 2;
	/// var halfY = (c.Y + a.Y) / 2;
	/// var halfZ = (c.Z + a.Z) / 2;
	/// 
	/// var b = new SCNVector3(a.X, c.Y, halfZ);
	/// var d = new SCNVector3(c.X, a.Y, halfZ);
	/// //Elevate the midpoint so that it's clearly a pyramid
	/// var midPoint = new SCNVector3(halfX, halfY, halfZ + 1.0);
	/// 
	/// //The vertices of the geometry
	/// var locs = new [] {
	/// 	a, b, c, d, midPoint
	/// };
	/// var locSource = SCNGeometrySource.FromVertices(locs);
	/// 
	/// //Note that this relies on the ordering of locs above
	/// //and it defines triangles (could be triangle strips, etc.)
	/// var indices = new [] {
	/// 	//Triangles are defined counter-clockwise!
	/// 	4, 1, 0,
	/// 	1, 4, 2,
	/// 	2, 4, 3,
	/// 	3, 4, 0
	/// };
	/// 
	/// 
	/// var idxArray = new byte[indices.Length][];
	/// for(int i = 0; i < idxArray.Length; i++)
	/// {
	/// 	idxArray[i] = BitConverter.GetBytes(indices[i]);
	/// }
	/// var idxData = NSData.FromArray(idxArray.SelectMany(id => id).ToArray());
	/// 
	/// //Note that this relies on indices defining triangles
	/// var element = SCNGeometryElement.FromData(idxData, SCNGeometryPrimitiveType.Triangles, indices.Length / 3, sizeof(int));
	/// 
	/// //Normals are relative to geometry
	/// var normals = new [] {
	/// 	new SCNVector3(0, 0, 1),
	/// 	new SCNVector3(0, 0, 1),
	/// 	new SCNVector3(0, 0, 1),
	/// 	new SCNVector3(0, 0, 1),
	/// 	new SCNVector3(0, 0, 1),
	/// };;
	/// var normSource = SCNGeometrySource.FromNormals(normals);
	/// 
	/// //These texture coords will cause the texture to wrap 
	/// var txCoords = new [] {
	/// 	new CGPoint(0, 0),
	/// 	new CGPoint(0, 1),
	/// 	new CGPoint(1, 1),
	/// 	new CGPoint(1, 0),
	/// new CGPoint(0.5, 0.5)
	/// };
	/// 
	/// var txCoordsSource = SCNGeometrySource.FromTextureCoordinates(txCoords);
	/// 
	/// var geometry = SCNGeometry.Create(new [] { locSource, normSource, txCoordsSource }, new [] { element });
	/// ]]></code></example></remarks><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SceneKit/Reference/SCNGeometrySource_Class/index.html">Apple documentation for <c>SCNGeometrySource</c></related>
	[Register("SCNGeometrySource", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SCNGeometrySource : NSObject, INSCoding, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SCNGeometrySource");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="SCNGeometrySource" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SCNGeometrySource () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
				GC.KeepAlive (this);
				}
			}
		}

		/// <summary>A constructor that initializes the object from the data stored in the unarchiver object.</summary>
		/// <param name="coder">The unarchiver object.</param>
		/// <remarks>
		///   <para>This constructor is provided to allow the class to be initialized from an unarchiver (for example, during NIB deserialization). This is part of the <see cref="Foundation.NSCoding" /> protocol.</para>
		///   <para>If developers want to create a subclass of this object and continue to support deserialization from an archive, they should implement a constructor with an identical signature: taking a single parameter of type <see cref="Foundation.NSCoder" /> and decorate it with the <c>[Export("initWithCoder:"]</c> attribute.</para>
		///   <para>The state of this object can also be serialized by using the <see cref="Foundation.INSCoding.EncodeTo" /> companion method.</para>
		/// </remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public SCNGeometrySource (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
				GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (coder);
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
		protected SCNGeometrySource (NSObjectFlag t) : base (t)
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
		protected internal SCNGeometrySource (NativeHandle handle) : base (handle)
		{
		}

		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		/// <param name="data">To be added.</param><param name="geometrySourceSemantic">To be added.</param><param name="vectorCount">To be added.</param><param name="floatComponents">To be added.</param><param name="componentsPerVector">To be added.</param><param name="bytesPerComponent">To be added.</param><param name="offset">To be added.</param><param name="stride">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("geometrySourceWithData:semantic:vectorCount:floatComponents:componentsPerVector:bytesPerComponent:dataOffset:dataStride:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNGeometrySource FromData (NSData data, NSString geometrySourceSemantic, nint vectorCount, bool floatComponents, nint componentsPerVector, nint bytesPerComponent, nint offset, nint stride)
		{
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var geometrySourceSemantic__handle__ = geometrySourceSemantic!.GetNonNullHandle (nameof (geometrySourceSemantic));
			SCNGeometrySource? ret;
			ret =  Runtime.GetNSObject<SCNGeometrySource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_bool_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("geometrySourceWithData:semantic:vectorCount:floatComponents:componentsPerVector:bytesPerComponent:dataOffset:dataStride:"), data__handle__, geometrySourceSemantic__handle__, vectorCount, floatComponents ? (byte) 1 : (byte) 0, componentsPerVector, bytesPerComponent, offset, stride), false)!;
			GC.KeepAlive (data);
			GC.KeepAlive (geometrySourceSemantic);
			return ret!;
		}
		/// <param name="mtlBuffer">To be added.</param><param name="vertexFormat">To be added.</param><param name="geometrySourceSemantic">To be added.</param><param name="vertexCount">To be added.</param><param name="offset">To be added.</param><param name="stride">To be added.</param><summary>Factory method to create a new <see cref="T:SceneKit.SCNGeometrySource" /> from a data buffer.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("geometrySourceWithBuffer:vertexFormat:semantic:vertexCount:dataOffset:dataStride:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SCNGeometrySource FromMetalBuffer (global::Metal.IMTLBuffer mtlBuffer, global::Metal.MTLVertexFormat vertexFormat, NSString geometrySourceSemantic, nint vertexCount, nint offset, nint stride)
		{
			var mtlBuffer__handle__ = mtlBuffer!.GetNonNullHandle (nameof (mtlBuffer));
			var geometrySourceSemantic__handle__ = geometrySourceSemantic!.GetNonNullHandle (nameof (geometrySourceSemantic));
			SCNGeometrySource? ret;
			ret =  Runtime.GetNSObject<SCNGeometrySource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("geometrySourceWithBuffer:vertexFormat:semantic:vertexCount:dataOffset:dataStride:"), mtlBuffer__handle__, (UIntPtr) (ulong) vertexFormat, geometrySourceSemantic__handle__, vertexCount, offset, stride), false)!;
			GC.KeepAlive (mtlBuffer);
			GC.KeepAlive (geometrySourceSemantic);
			return ret!;
		}
		[Export ("geometrySourceWithNormals:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static SCNGeometrySource FromNormals (nint normals, nint count)
		{
			SCNGeometrySource ret;
			ret =  Runtime.GetNSObject<SCNGeometrySource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("geometrySourceWithNormals:count:"), normals, count), false)!;
			return ret;
		}
		[Export ("geometrySourceWithTextureCoordinates:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static SCNGeometrySource FromTextureCoordinates (nint texcoords, nint count)
		{
			SCNGeometrySource ret;
			ret =  Runtime.GetNSObject<SCNGeometrySource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("geometrySourceWithTextureCoordinates:count:"), texcoords, count), false)!;
			return ret;
		}
		[Export ("geometrySourceWithVertices:count:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static SCNGeometrySource FromVertices (nint vertices, nint count)
		{
			SCNGeometrySource ret;
			ret =  Runtime.GetNSObject<SCNGeometrySource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("geometrySourceWithVertices:count:"), vertices, count), false)!;
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint BytesPerComponent {
			[Export ("bytesPerComponent")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("bytesPerComponent"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("bytesPerComponent"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint ComponentsPerVector {
			[Export ("componentsPerVector")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("componentsPerVector"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("componentsPerVector"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData Data {
			[Export ("data")]
			get {
				NSData? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("data")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("data")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint DataOffset {
			[Export ("dataOffset")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dataOffset"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("dataOffset"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint DataStride {
			[Export ("dataStride")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("dataStride"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("dataStride"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool FloatComponents {
			[Export ("floatComponents")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("floatComponents"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("floatComponents"));
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSString Semantic {
			[Export ("semantic")]
			get {
				NSString? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("semantic")), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSString> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("semantic")), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint VectorCount {
			[Export ("vectorCount")]
			get {
				nint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("vectorCount"));
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("vectorCount"));
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class SCNGeometrySource */
}
