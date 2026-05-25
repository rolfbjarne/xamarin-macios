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
namespace SpriteKit {
	/// <summary>Holds shareable uniform data for SKShader objects.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/SpriteKit/Reference/SKUniform_Ref/index.html">Apple documentation for <c>SKUniform</c></related>
	[Register("SKUniform", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SKUniform : NSObject, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFloatValueX = "floatValue";
		static readonly NativeHandle selFloatValueXHandle = Selector.GetHandle ("floatValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_X = "initWithName:";
		static readonly NativeHandle selInitWithName_XHandle = Selector.GetHandle ("initWithName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_Float_X = "initWithName:float:";
		static readonly NativeHandle selInitWithName_Float_XHandle = Selector.GetHandle ("initWithName:float:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_MatrixFloat2x2_X = "initWithName:matrixFloat2x2:";
		static readonly NativeHandle selInitWithName_MatrixFloat2x2_XHandle = Selector.GetHandle ("initWithName:matrixFloat2x2:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_MatrixFloat3x3_X = "initWithName:matrixFloat3x3:";
		static readonly NativeHandle selInitWithName_MatrixFloat3x3_XHandle = Selector.GetHandle ("initWithName:matrixFloat3x3:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_MatrixFloat4x4_X = "initWithName:matrixFloat4x4:";
		static readonly NativeHandle selInitWithName_MatrixFloat4x4_XHandle = Selector.GetHandle ("initWithName:matrixFloat4x4:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_Texture_X = "initWithName:texture:";
		static readonly NativeHandle selInitWithName_Texture_XHandle = Selector.GetHandle ("initWithName:texture:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_VectorFloat2_X = "initWithName:vectorFloat2:";
		static readonly NativeHandle selInitWithName_VectorFloat2_XHandle = Selector.GetHandle ("initWithName:vectorFloat2:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_VectorFloat3_X = "initWithName:vectorFloat3:";
		static readonly NativeHandle selInitWithName_VectorFloat3_XHandle = Selector.GetHandle ("initWithName:vectorFloat3:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_VectorFloat4_X = "initWithName:vectorFloat4:";
		static readonly NativeHandle selInitWithName_VectorFloat4_XHandle = Selector.GetHandle ("initWithName:vectorFloat4:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatrixFloat2x2ValueX = "matrixFloat2x2Value";
		static readonly NativeHandle selMatrixFloat2x2ValueXHandle = Selector.GetHandle ("matrixFloat2x2Value");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatrixFloat3x3ValueX = "matrixFloat3x3Value";
		static readonly NativeHandle selMatrixFloat3x3ValueXHandle = Selector.GetHandle ("matrixFloat3x3Value");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMatrixFloat4x4ValueX = "matrixFloat4x4Value";
		static readonly NativeHandle selMatrixFloat4x4ValueXHandle = Selector.GetHandle ("matrixFloat4x4Value");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNameX = "name";
		static readonly NativeHandle selNameXHandle = Selector.GetHandle ("name");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFloatValue_X = "setFloatValue:";
		static readonly NativeHandle selSetFloatValue_XHandle = Selector.GetHandle ("setFloatValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMatrixFloat2x2Value_X = "setMatrixFloat2x2Value:";
		static readonly NativeHandle selSetMatrixFloat2x2Value_XHandle = Selector.GetHandle ("setMatrixFloat2x2Value:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMatrixFloat3x3Value_X = "setMatrixFloat3x3Value:";
		static readonly NativeHandle selSetMatrixFloat3x3Value_XHandle = Selector.GetHandle ("setMatrixFloat3x3Value:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMatrixFloat4x4Value_X = "setMatrixFloat4x4Value:";
		static readonly NativeHandle selSetMatrixFloat4x4Value_XHandle = Selector.GetHandle ("setMatrixFloat4x4Value:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTextureValue_X = "setTextureValue:";
		static readonly NativeHandle selSetTextureValue_XHandle = Selector.GetHandle ("setTextureValue:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVectorFloat2Value_X = "setVectorFloat2Value:";
		static readonly NativeHandle selSetVectorFloat2Value_XHandle = Selector.GetHandle ("setVectorFloat2Value:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVectorFloat3Value_X = "setVectorFloat3Value:";
		static readonly NativeHandle selSetVectorFloat3Value_XHandle = Selector.GetHandle ("setVectorFloat3Value:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVectorFloat4Value_X = "setVectorFloat4Value:";
		static readonly NativeHandle selSetVectorFloat4Value_XHandle = Selector.GetHandle ("setVectorFloat4Value:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureValueX = "textureValue";
		static readonly NativeHandle selTextureValueXHandle = Selector.GetHandle ("textureValue");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUniformTypeX = "uniformType";
		static readonly NativeHandle selUniformTypeXHandle = Selector.GetHandle ("uniformType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUniformWithName_X = "uniformWithName:";
		static readonly NativeHandle selUniformWithName_XHandle = Selector.GetHandle ("uniformWithName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUniformWithName_Float_X = "uniformWithName:float:";
		static readonly NativeHandle selUniformWithName_Float_XHandle = Selector.GetHandle ("uniformWithName:float:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUniformWithName_MatrixFloat2x2_X = "uniformWithName:matrixFloat2x2:";
		static readonly NativeHandle selUniformWithName_MatrixFloat2x2_XHandle = Selector.GetHandle ("uniformWithName:matrixFloat2x2:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUniformWithName_MatrixFloat3x3_X = "uniformWithName:matrixFloat3x3:";
		static readonly NativeHandle selUniformWithName_MatrixFloat3x3_XHandle = Selector.GetHandle ("uniformWithName:matrixFloat3x3:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUniformWithName_MatrixFloat4x4_X = "uniformWithName:matrixFloat4x4:";
		static readonly NativeHandle selUniformWithName_MatrixFloat4x4_XHandle = Selector.GetHandle ("uniformWithName:matrixFloat4x4:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUniformWithName_Texture_X = "uniformWithName:texture:";
		static readonly NativeHandle selUniformWithName_Texture_XHandle = Selector.GetHandle ("uniformWithName:texture:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUniformWithName_VectorFloat2_X = "uniformWithName:vectorFloat2:";
		static readonly NativeHandle selUniformWithName_VectorFloat2_XHandle = Selector.GetHandle ("uniformWithName:vectorFloat2:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUniformWithName_VectorFloat3_X = "uniformWithName:vectorFloat3:";
		static readonly NativeHandle selUniformWithName_VectorFloat3_XHandle = Selector.GetHandle ("uniformWithName:vectorFloat3:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUniformWithName_VectorFloat4_X = "uniformWithName:vectorFloat4:";
		static readonly NativeHandle selUniformWithName_VectorFloat4_XHandle = Selector.GetHandle ("uniformWithName:vectorFloat4:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVectorFloat2ValueX = "vectorFloat2Value";
		static readonly NativeHandle selVectorFloat2ValueXHandle = Selector.GetHandle ("vectorFloat2Value");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVectorFloat3ValueX = "vectorFloat3Value";
		static readonly NativeHandle selVectorFloat3ValueXHandle = Selector.GetHandle ("vectorFloat3Value");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVectorFloat4ValueX = "vectorFloat4Value";
		static readonly NativeHandle selVectorFloat4ValueXHandle = Selector.GetHandle ("vectorFloat4Value");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SKUniform");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="SKUniform" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SKUniform () : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.Init), "init");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, global::ObjCRuntime.Selector.Init), "init");
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
		public SKUniform (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
			} else {
				unsafe {
				var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
				InitializeHandle (global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
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
		protected SKUniform (NSObjectFlag t) : base (t)
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
		protected internal SKUniform (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SKUniform (string name)
			: base (NSObjectFlag.Empty)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithName_XHandle, nsname), "initWithName:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithName_XHandle, nsname), "initWithName:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
		}
		[Export ("initWithName:texture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SKUniform (string name, SKTexture? texture)
			: base (NSObjectFlag.Empty)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var texture__handle__ = texture.GetHandle ();
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithName_Texture_XHandle, nsname, texture__handle__), "initWithName:texture:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithName_Texture_XHandle, nsname, texture__handle__), "initWithName:texture:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (texture);
			CFString.ReleaseNative (nsname);
		}
		[Export ("initWithName:float:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SKUniform (string name, float value)
			: base (NSObjectFlag.Empty)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_float (this.Handle, selInitWithName_Float_XHandle, nsname, value), "initWithName:float:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_float (&__objc_super__, selInitWithName_Float_XHandle, nsname, value), "initWithName:float:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
		}
		[Export ("initWithName:vectorFloat2:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SKUniform (string name, global::System.Numerics.Vector2 value)
			: base (NSObjectFlag.Empty)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NativeHandle_Vector2 (this.Handle, selInitWithName_VectorFloat2_XHandle, nsname, value), "initWithName:vectorFloat2:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSendSuper_NativeHandle_Vector2 (&__objc_super__, selInitWithName_VectorFloat2_XHandle, nsname, value), "initWithName:vectorFloat2:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
		}
		[Export ("initWithName:vectorFloat3:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SKUniform (string name, global::System.Numerics.Vector3 value)
			: base (NSObjectFlag.Empty)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NativeHandle_Vector3 (this.Handle, selInitWithName_VectorFloat3_XHandle, nsname, value), "initWithName:vectorFloat3:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSendSuper_NativeHandle_Vector3 (&__objc_super__, selInitWithName_VectorFloat3_XHandle, nsname, value), "initWithName:vectorFloat3:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
		}
		[Export ("initWithName:vectorFloat4:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SKUniform (string name, global::System.Numerics.Vector4 value)
			: base (NSObjectFlag.Empty)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NativeHandle_Vector4 (this.Handle, selInitWithName_VectorFloat4_XHandle, nsname, value), "initWithName:vectorFloat4:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSendSuper_NativeHandle_Vector4 (&__objc_super__, selInitWithName_VectorFloat4_XHandle, nsname, value), "initWithName:vectorFloat4:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
		}
		[Export ("initWithName:matrixFloat2x2:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SKUniform (string name, NMatrix2 value)
			: base (NSObjectFlag.Empty)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NativeHandle_NMatrix2 (this.Handle, selInitWithName_MatrixFloat2x2_XHandle, nsname, value), "initWithName:matrixFloat2x2:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSendSuper_NativeHandle_NMatrix2 (&__objc_super__, selInitWithName_MatrixFloat2x2_XHandle, nsname, value), "initWithName:matrixFloat2x2:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
		}
		[Export ("initWithName:matrixFloat3x3:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SKUniform (string name, NMatrix3 value)
			: base (NSObjectFlag.Empty)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NativeHandle_NMatrix3 (this.Handle, selInitWithName_MatrixFloat3x3_XHandle, nsname, value), "initWithName:matrixFloat3x3:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSendSuper_NativeHandle_NMatrix3 (&__objc_super__, selInitWithName_MatrixFloat3x3_XHandle, nsname, value), "initWithName:matrixFloat3x3:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
		}
		[Export ("initWithName:matrixFloat4x4:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SKUniform (string name, NMatrix4 value)
			: base (NSObjectFlag.Empty)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NativeHandle_NMatrix4 (this.Handle, selInitWithName_MatrixFloat4x4_XHandle, nsname, value), "initWithName:matrixFloat4x4:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSendSuper_NativeHandle_NMatrix4 (&__objc_super__, selInitWithName_MatrixFloat4x4_XHandle, nsname, value), "initWithName:matrixFloat4x4:");
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		[Export ("uniformWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKUniform Create (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			SKUniform? ret;
			ret =  Runtime.GetNSObject<SKUniform> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selUniformWithName_XHandle, nsname), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("uniformWithName:texture:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKUniform Create (string name, SKTexture? texture)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var texture__handle__ = texture.GetHandle ();
			var nsname = CFString.CreateNative (name);
			SKUniform? ret;
			ret =  Runtime.GetNSObject<SKUniform> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selUniformWithName_Texture_XHandle, nsname, texture__handle__), false)!;
			GC.KeepAlive (texture);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("uniformWithName:float:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKUniform Create (string name, float value)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			SKUniform? ret;
			ret =  Runtime.GetNSObject<SKUniform> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_float (class_ptr, selUniformWithName_Float_XHandle, nsname, value), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("uniformWithName:vectorFloat2:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKUniform Create (string name, global::System.Numerics.Vector2 value)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			IntPtr exception_gchandle = IntPtr.Zero;
			SKUniform? ret;
			ret =  Runtime.GetNSObject<SKUniform> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NativeHandle_Vector2_exception (class_ptr, selUniformWithName_VectorFloat2_XHandle, nsname, value, &exception_gchandle), false)!;
			Runtime.ThrowException (exception_gchandle);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("uniformWithName:vectorFloat3:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKUniform Create (string name, global::System.Numerics.Vector3 value)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			SKUniform? ret;
			ret =  Runtime.GetNSObject<SKUniform> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NativeHandle_Vector3 (class_ptr, selUniformWithName_VectorFloat3_XHandle, nsname, value), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("uniformWithName:vectorFloat4:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKUniform Create (string name, global::System.Numerics.Vector4 value)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			SKUniform? ret;
			ret =  Runtime.GetNSObject<SKUniform> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NativeHandle_Vector4 (class_ptr, selUniformWithName_VectorFloat4_XHandle, nsname, value), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("uniformWithName:matrixFloat2x2:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKUniform Create (string name, NMatrix2 value)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			SKUniform? ret;
			ret =  Runtime.GetNSObject<SKUniform> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NativeHandle_NMatrix2 (class_ptr, selUniformWithName_MatrixFloat2x2_XHandle, nsname, value), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("uniformWithName:matrixFloat3x3:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKUniform Create (string name, NMatrix3 value)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			SKUniform? ret;
			ret =  Runtime.GetNSObject<SKUniform> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NativeHandle_NMatrix3 (class_ptr, selUniformWithName_MatrixFloat3x3_XHandle, nsname, value), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("uniformWithName:matrixFloat4x4:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKUniform Create (string name, NMatrix4 value)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			SKUniform? ret;
			ret =  Runtime.GetNSObject<SKUniform> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NativeHandle_NMatrix4 (class_ptr, selUniformWithName_MatrixFloat4x4_XHandle, nsname, value), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
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
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selEncodeWithCoder_XHandle, encoder__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selEncodeWithCoder_XHandle, encoder__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (encoder);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual float FloatValue {
			[Export ("floatValue")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selFloatValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selFloatValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFloatValue:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetFloatValue_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetFloatValue_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::System.Numerics.Vector2 FloatVector2Value {
			[Export ("vectorFloat2Value", ArgumentSemantic.Assign)]
			get {
				global::System.Numerics.Vector2 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector2_objc_msgSend (this.Handle, selVectorFloat2ValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector2_objc_msgSendSuper (&__objc_super__, selVectorFloat2ValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setVectorFloat2Value:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_Vector2 (this.Handle, selSetVectorFloat2Value_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_Vector2 (&__objc_super__, selSetVectorFloat2Value_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::System.Numerics.Vector3 FloatVector3Value {
			[Export ("vectorFloat3Value", ArgumentSemantic.Assign)]
			get {
				global::System.Numerics.Vector3 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSend (this.Handle, selVectorFloat3ValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSendSuper (&__objc_super__, selVectorFloat3ValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setVectorFloat3Value:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_Vector3 (this.Handle, selSetVectorFloat3Value_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_Vector3 (&__objc_super__, selSetVectorFloat3Value_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::System.Numerics.Vector4 FloatVector4Value {
			[Export ("vectorFloat4Value", ArgumentSemantic.Assign)]
			get {
				global::System.Numerics.Vector4 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector4_objc_msgSend (this.Handle, selVectorFloat4ValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector4_objc_msgSendSuper (&__objc_super__, selVectorFloat4ValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setVectorFloat4Value:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_Vector4 (this.Handle, selSetVectorFloat4Value_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_Vector4 (&__objc_super__, selSetVectorFloat4Value_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NMatrix2 MatrixFloat2x2Value {
			[Export ("matrixFloat2x2Value", ArgumentSemantic.Assign)]
			get {
				NMatrix2 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix2_objc_msgSend (this.Handle, selMatrixFloat2x2ValueXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix2_objc_msgSendSuper (&__objc_super__, selMatrixFloat2x2ValueXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMatrixFloat2x2Value:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NMatrix2 (this.Handle, selSetMatrixFloat2x2Value_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_NMatrix2 (&__objc_super__, selSetMatrixFloat2x2Value_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NMatrix3 MatrixFloat3x3Value {
			[Export ("matrixFloat3x3Value", ArgumentSemantic.Assign)]
			get {
				NMatrix3 ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix3_objc_msgSend (this.Handle, selMatrixFloat3x3ValueXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix3_objc_msgSend_stret (this.Handle, selMatrixFloat3x3ValueXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix3_objc_msgSendSuper (&__objc_super__, selMatrixFloat3x3ValueXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix3_objc_msgSendSuper_stret (&__objc_super__, selMatrixFloat3x3ValueXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setMatrixFloat3x3Value:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NMatrix3 (this.Handle, selSetMatrixFloat3x3Value_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_NMatrix3 (&__objc_super__, selSetMatrixFloat3x3Value_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NMatrix4 MatrixFloat4x4Value {
			[Export ("matrixFloat4x4Value", ArgumentSemantic.Assign)]
			get {
				NMatrix4 ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend (this.Handle, selMatrixFloat4x4ValueXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSend_stret (this.Handle, selMatrixFloat4x4ValueXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper (&__objc_super__, selMatrixFloat4x4ValueXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.xamarin_simd__NMatrix4_objc_msgSendSuper_stret (&__objc_super__, selMatrixFloat4x4ValueXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setMatrixFloat4x4Value:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NMatrix4 (this.Handle, selSetMatrixFloat4x4Value_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_NMatrix4 (&__objc_super__, selSetMatrixFloat4x4Value_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string Name {
			[Export ("name")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selNameXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selNameXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKTexture? TextureValue {
			[Export ("textureValue")]
			get {
				SKTexture? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SKTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTextureValueXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SKTexture> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTextureValueXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTextureValue:")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTextureValue_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTextureValue_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKUniformType UniformType {
			[Export ("uniformType")]
			get {
				SKUniformType ret;
				if (IsDirectBinding) {
					ret = (SKUniformType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUniformTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (SKUniformType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selUniformTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class SKUniform */
}
