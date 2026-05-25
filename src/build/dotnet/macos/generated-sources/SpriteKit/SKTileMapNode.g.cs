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
	/// <summary>A <see cref="T:SpriteKit.SKNode" /> that encapsulates a tiled map and a <see cref="T:SpriteKit.SKTileSet" />.</summary><remarks><para>The <see cref="T:SpriteKit.SKTileMapNode" /> subclass of <see cref="T:SpriteKit.SKNode" /> allows developers to easily create and manipulate tile-based maps with a variety of geometries and perspectives. An <see cref="T:SpriteKit.SKTileMapNode" /> contains a <see cref="T:SpriteKit.SKTileSet" /> that defines the overall map. In addition, the <see cref="T:SpriteKit.SKTileSet" /> contains one or more <see cref="T:SpriteKit.SKTileGroup" /> objects, each of which represents one style of tile, which may have several representations.</para><example><code lang="csharp lang-csharp"><![CDATA[
	/// //Load tile set
	/// var tileSet = SKTileSet.FromName ("MyTileSet");
	/// //Create a 16x16 map
	/// var tileNode = new SKTileMapNode (tileSet, 16, 16, tileSet.DefaultTileSize);
	/// 
	/// //Fill the node's grid with the default tile 
	/// var tg = tileSet.DefaultTileGroup;
	/// tileNode.Fill (tg);
	/// ]]></code><para>The relationship between a <see cref="T:SpriteKit.SKTileMapNode" /> and it's tiles is shown in the following image:</para><para><img href="~/xml/SpriteKit/_images/SKTileMapNode.Hierarchy.png" alt="UML class diagram showing important classes relating to SKTileMapNode" /></para></example></remarks><related type="externalDocumentation" href="https://developer.apple.com/reference/SpriteKit/SKTileMapNode">Apple documentation for <c>SKTileMapNode</c></related>
	[Register("SKTileMapNode", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class SKTileMapNode : SKNode, INSCoding, INSCopying, INSSecureCoding {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnchorPointX = "anchorPoint";
		static readonly NativeHandle selAnchorPointXHandle = Selector.GetHandle ("anchorPoint");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAttributeValuesX = "attributeValues";
		static readonly NativeHandle selAttributeValuesXHandle = Selector.GetHandle ("attributeValues");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBlendModeX = "blendMode";
		static readonly NativeHandle selBlendModeXHandle = Selector.GetHandle ("blendMode");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCenterOfTileAtColumn_Row_X = "centerOfTileAtColumn:row:";
		static readonly NativeHandle selCenterOfTileAtColumn_Row_XHandle = Selector.GetHandle ("centerOfTileAtColumn:row:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorX = "color";
		static readonly NativeHandle selColorXHandle = Selector.GetHandle ("color");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorBlendFactorX = "colorBlendFactor";
		static readonly NativeHandle selColorBlendFactorXHandle = Selector.GetHandle ("colorBlendFactor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEnableAutomappingX = "enableAutomapping";
		static readonly NativeHandle selEnableAutomappingXHandle = Selector.GetHandle ("enableAutomapping");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEncodeWithCoder_X = "encodeWithCoder:";
		static readonly NativeHandle selEncodeWithCoder_XHandle = Selector.GetHandle ("encodeWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFillWithTileGroup_X = "fillWithTileGroup:";
		static readonly NativeHandle selFillWithTileGroup_XHandle = Selector.GetHandle ("fillWithTileGroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithCoder_X = "initWithCoder:";
		static readonly NativeHandle selInitWithCoder_XHandle = Selector.GetHandle ("initWithCoder:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTileSet_Columns_Rows_TileSize_X = "initWithTileSet:columns:rows:tileSize:";
		static readonly NativeHandle selInitWithTileSet_Columns_Rows_TileSize_XHandle = Selector.GetHandle ("initWithTileSet:columns:rows:tileSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTileSet_Columns_Rows_TileSize_FillWithTileGroup_X = "initWithTileSet:columns:rows:tileSize:fillWithTileGroup:";
		static readonly NativeHandle selInitWithTileSet_Columns_Rows_TileSize_FillWithTileGroup_XHandle = Selector.GetHandle ("initWithTileSet:columns:rows:tileSize:fillWithTileGroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithTileSet_Columns_Rows_TileSize_TileGroupLayout_X = "initWithTileSet:columns:rows:tileSize:tileGroupLayout:";
		static readonly NativeHandle selInitWithTileSet_Columns_Rows_TileSize_TileGroupLayout_XHandle = Selector.GetHandle ("initWithTileSet:columns:rows:tileSize:tileGroupLayout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLightingBitMaskX = "lightingBitMask";
		static readonly NativeHandle selLightingBitMaskXHandle = Selector.GetHandle ("lightingBitMask");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMapSizeX = "mapSize";
		static readonly NativeHandle selMapSizeXHandle = Selector.GetHandle ("mapSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfColumnsX = "numberOfColumns";
		static readonly NativeHandle selNumberOfColumnsXHandle = Selector.GetHandle ("numberOfColumns");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNumberOfRowsX = "numberOfRows";
		static readonly NativeHandle selNumberOfRowsXHandle = Selector.GetHandle ("numberOfRows");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAnchorPoint_X = "setAnchorPoint:";
		static readonly NativeHandle selSetAnchorPoint_XHandle = Selector.GetHandle ("setAnchorPoint:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAttributeValues_X = "setAttributeValues:";
		static readonly NativeHandle selSetAttributeValues_XHandle = Selector.GetHandle ("setAttributeValues:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetBlendMode_X = "setBlendMode:";
		static readonly NativeHandle selSetBlendMode_XHandle = Selector.GetHandle ("setBlendMode:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetColor_X = "setColor:";
		static readonly NativeHandle selSetColor_XHandle = Selector.GetHandle ("setColor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetColorBlendFactor_X = "setColorBlendFactor:";
		static readonly NativeHandle selSetColorBlendFactor_XHandle = Selector.GetHandle ("setColorBlendFactor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEnableAutomapping_X = "setEnableAutomapping:";
		static readonly NativeHandle selSetEnableAutomapping_XHandle = Selector.GetHandle ("setEnableAutomapping:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLightingBitMask_X = "setLightingBitMask:";
		static readonly NativeHandle selSetLightingBitMask_XHandle = Selector.GetHandle ("setLightingBitMask:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNumberOfColumns_X = "setNumberOfColumns:";
		static readonly NativeHandle selSetNumberOfColumns_XHandle = Selector.GetHandle ("setNumberOfColumns:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetNumberOfRows_X = "setNumberOfRows:";
		static readonly NativeHandle selSetNumberOfRows_XHandle = Selector.GetHandle ("setNumberOfRows:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShader_X = "setShader:";
		static readonly NativeHandle selSetShader_XHandle = Selector.GetHandle ("setShader:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTileGroup_AndTileDefinition_ForColumn_Row_X = "setTileGroup:andTileDefinition:forColumn:row:";
		static readonly NativeHandle selSetTileGroup_AndTileDefinition_ForColumn_Row_XHandle = Selector.GetHandle ("setTileGroup:andTileDefinition:forColumn:row:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTileGroup_ForColumn_Row_X = "setTileGroup:forColumn:row:";
		static readonly NativeHandle selSetTileGroup_ForColumn_Row_XHandle = Selector.GetHandle ("setTileGroup:forColumn:row:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTileSet_X = "setTileSet:";
		static readonly NativeHandle selSetTileSet_XHandle = Selector.GetHandle ("setTileSet:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTileSize_X = "setTileSize:";
		static readonly NativeHandle selSetTileSize_XHandle = Selector.GetHandle ("setTileSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetValue_ForAttributeNamed_X = "setValue:forAttributeNamed:";
		static readonly NativeHandle selSetValue_ForAttributeNamed_XHandle = Selector.GetHandle ("setValue:forAttributeNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShaderX = "shader";
		static readonly NativeHandle selShaderXHandle = Selector.GetHandle ("shader");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTileColumnIndexFromPosition_X = "tileColumnIndexFromPosition:";
		static readonly NativeHandle selTileColumnIndexFromPosition_XHandle = Selector.GetHandle ("tileColumnIndexFromPosition:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTileDefinitionAtColumn_Row_X = "tileDefinitionAtColumn:row:";
		static readonly NativeHandle selTileDefinitionAtColumn_Row_XHandle = Selector.GetHandle ("tileDefinitionAtColumn:row:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTileGroupAtColumn_Row_X = "tileGroupAtColumn:row:";
		static readonly NativeHandle selTileGroupAtColumn_Row_XHandle = Selector.GetHandle ("tileGroupAtColumn:row:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTileMapNodeWithTileSet_Columns_Rows_TileSize_X = "tileMapNodeWithTileSet:columns:rows:tileSize:";
		static readonly NativeHandle selTileMapNodeWithTileSet_Columns_Rows_TileSize_XHandle = Selector.GetHandle ("tileMapNodeWithTileSet:columns:rows:tileSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTileMapNodeWithTileSet_Columns_Rows_TileSize_FillWithTileGroup_X = "tileMapNodeWithTileSet:columns:rows:tileSize:fillWithTileGroup:";
		static readonly NativeHandle selTileMapNodeWithTileSet_Columns_Rows_TileSize_FillWithTileGroup_XHandle = Selector.GetHandle ("tileMapNodeWithTileSet:columns:rows:tileSize:fillWithTileGroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTileMapNodeWithTileSet_Columns_Rows_TileSize_TileGroupLayout_X = "tileMapNodeWithTileSet:columns:rows:tileSize:tileGroupLayout:";
		static readonly NativeHandle selTileMapNodeWithTileSet_Columns_Rows_TileSize_TileGroupLayout_XHandle = Selector.GetHandle ("tileMapNodeWithTileSet:columns:rows:tileSize:tileGroupLayout:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTileMapNodesWithTileSet_Columns_Rows_TileSize_FromNoiseMap_TileTypeNoiseMapThresholds_X = "tileMapNodesWithTileSet:columns:rows:tileSize:fromNoiseMap:tileTypeNoiseMapThresholds:";
		static readonly NativeHandle selTileMapNodesWithTileSet_Columns_Rows_TileSize_FromNoiseMap_TileTypeNoiseMapThresholds_XHandle = Selector.GetHandle ("tileMapNodesWithTileSet:columns:rows:tileSize:fromNoiseMap:tileTypeNoiseMapThresholds:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTileRowIndexFromPosition_X = "tileRowIndexFromPosition:";
		static readonly NativeHandle selTileRowIndexFromPosition_XHandle = Selector.GetHandle ("tileRowIndexFromPosition:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTileSetX = "tileSet";
		static readonly NativeHandle selTileSetXHandle = Selector.GetHandle ("tileSet");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTileSizeX = "tileSize";
		static readonly NativeHandle selTileSizeXHandle = Selector.GetHandle ("tileSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selValueForAttributeNamed_X = "valueForAttributeNamed:";
		static readonly NativeHandle selValueForAttributeNamed_XHandle = Selector.GetHandle ("valueForAttributeNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("SKTileMapNode");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="SKTileMapNode" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public SKTileMapNode () : base (NSObjectFlag.Empty)
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
		public SKTileMapNode (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected SKTileMapNode (NSObjectFlag t) : base (t)
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
		protected internal SKTileMapNode (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="tileSet">To be added.</param><param name="columns">To be added.</param><param name="rows">To be added.</param><param name="tileSize">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithTileSet:columns:rows:tileSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SKTileMapNode (SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize)
			: base (NSObjectFlag.Empty)
		{
			var tileSet__handle__ = tileSet!.GetNonNullHandle (nameof (tileSet));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_CGSize (this.Handle, selInitWithTileSet_Columns_Rows_TileSize_XHandle, tileSet__handle__, columns, rows, tileSize), "initWithTileSet:columns:rows:tileSize:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_UIntPtr_CGSize (&__objc_super__, selInitWithTileSet_Columns_Rows_TileSize_XHandle, tileSet__handle__, columns, rows, tileSize), "initWithTileSet:columns:rows:tileSize:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tileSet);
		}
		/// <param name="tileSet">To be added.</param><param name="columns">To be added.</param><param name="rows">To be added.</param><param name="tileSize">To be added.</param><param name="tileGroup">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithTileSet:columns:rows:tileSize:fillWithTileGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SKTileMapNode (SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize, SKTileGroup tileGroup)
			: base (NSObjectFlag.Empty)
		{
			var tileSet__handle__ = tileSet!.GetNonNullHandle (nameof (tileSet));
			var tileGroup__handle__ = tileGroup!.GetNonNullHandle (nameof (tileGroup));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_CGSize_NativeHandle (this.Handle, selInitWithTileSet_Columns_Rows_TileSize_FillWithTileGroup_XHandle, tileSet__handle__, columns, rows, tileSize, tileGroup__handle__), "initWithTileSet:columns:rows:tileSize:fillWithTileGroup:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_UIntPtr_CGSize_NativeHandle (&__objc_super__, selInitWithTileSet_Columns_Rows_TileSize_FillWithTileGroup_XHandle, tileSet__handle__, columns, rows, tileSize, tileGroup__handle__), "initWithTileSet:columns:rows:tileSize:fillWithTileGroup:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tileSet);
			GC.KeepAlive (tileGroup);
		}
		/// <param name="tileSet">To be added.</param><param name="columns">To be added.</param><param name="rows">To be added.</param><param name="tileSize">To be added.</param><param name="tileGroupLayout">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithTileSet:columns:rows:tileSize:tileGroupLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public SKTileMapNode (SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize, SKTileGroup[] tileGroupLayout)
			: base (NSObjectFlag.Empty)
		{
			var tileSet__handle__ = tileSet!.GetNonNullHandle (nameof (tileSet));
			if (tileGroupLayout is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tileGroupLayout));
			using var nsa_tileGroupLayout = NSArray.FromNSObjects (tileGroupLayout);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_CGSize_NativeHandle (this.Handle, selInitWithTileSet_Columns_Rows_TileSize_TileGroupLayout_XHandle, tileSet__handle__, columns, rows, tileSize, nsa_tileGroupLayout.Handle), "initWithTileSet:columns:rows:tileSize:tileGroupLayout:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_UIntPtr_CGSize_NativeHandle (&__objc_super__, selInitWithTileSet_Columns_Rows_TileSize_TileGroupLayout_XHandle, tileSet__handle__, columns, rows, tileSize, nsa_tileGroupLayout.Handle), "initWithTileSet:columns:rows:tileSize:tileGroupLayout:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tileSet);
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public new virtual NSObject Copy (NSZone? zone)
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
		/// <param name="tileSet">To be added.</param><param name="columns">To be added.</param><param name="rows">To be added.</param><param name="tileSize">To be added.</param><summary>Factory method to create an <see cref="T:SpriteKit.SKTileMapNode" /> with the specified properties.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tileMapNodeWithTileSet:columns:rows:tileSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTileMapNode Create (SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize)
		{
			var tileSet__handle__ = tileSet!.GetNonNullHandle (nameof (tileSet));
			SKTileMapNode? ret;
			ret =  Runtime.GetNSObject<SKTileMapNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_CGSize (class_ptr, selTileMapNodeWithTileSet_Columns_Rows_TileSize_XHandle, tileSet__handle__, columns, rows, tileSize), false)!;
			GC.KeepAlive (tileSet);
			return ret!;
		}
		/// <param name="tileSet">To be added.</param><param name="columns">To be added.</param><param name="rows">To be added.</param><param name="tileSize">To be added.</param><param name="tileGroup">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tileMapNodeWithTileSet:columns:rows:tileSize:fillWithTileGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTileMapNode Create (SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize, SKTileGroup tileGroup)
		{
			var tileSet__handle__ = tileSet!.GetNonNullHandle (nameof (tileSet));
			var tileGroup__handle__ = tileGroup!.GetNonNullHandle (nameof (tileGroup));
			SKTileMapNode? ret;
			ret =  Runtime.GetNSObject<SKTileMapNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_CGSize_NativeHandle (class_ptr, selTileMapNodeWithTileSet_Columns_Rows_TileSize_FillWithTileGroup_XHandle, tileSet__handle__, columns, rows, tileSize, tileGroup__handle__), false)!;
			GC.KeepAlive (tileSet);
			GC.KeepAlive (tileGroup);
			return ret!;
		}
		/// <param name="tileSet">To be added.</param><param name="columns">To be added.</param><param name="rows">To be added.</param><param name="tileSize">To be added.</param><param name="tileGroupLayout">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tileMapNodeWithTileSet:columns:rows:tileSize:tileGroupLayout:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTileMapNode Create (SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize, SKTileGroup[] tileGroupLayout)
		{
			var tileSet__handle__ = tileSet!.GetNonNullHandle (nameof (tileSet));
			if (tileGroupLayout is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tileGroupLayout));
			using var nsa_tileGroupLayout = NSArray.FromNSObjects (tileGroupLayout);
			SKTileMapNode? ret;
			ret =  Runtime.GetNSObject<SKTileMapNode> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_CGSize_NativeHandle (class_ptr, selTileMapNodeWithTileSet_Columns_Rows_TileSize_TileGroupLayout_XHandle, tileSet__handle__, columns, rows, tileSize, nsa_tileGroupLayout.Handle), false)!;
			GC.KeepAlive (tileSet);
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
		public new virtual void EncodeTo (NSCoder encoder)
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
		[Export ("fillWithTileGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Fill (SKTileGroup? tileGroup)
		{
			var tileGroup__handle__ = tileGroup.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selFillWithTileGroup_XHandle, tileGroup__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selFillWithTileGroup_XHandle, tileGroup__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tileGroup);
		}
		/// <param name="tileSet">To be added.</param><param name="columns">To be added.</param><param name="rows">To be added.</param><param name="tileSize">To be added.</param><param name="noiseMap">To be added.</param><param name="thresholds">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tileMapNodesWithTileSet:columns:rows:tileSize:fromNoiseMap:tileTypeNoiseMapThresholds:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static SKTileMapNode[] FromTileSet (SKTileSet tileSet, nuint columns, nuint rows, CGSize tileSize, global::GameplayKit.GKNoiseMap noiseMap, NSNumber[] thresholds)
		{
			var tileSet__handle__ = tileSet!.GetNonNullHandle (nameof (tileSet));
			var noiseMap__handle__ = noiseMap!.GetNonNullHandle (nameof (noiseMap));
			if (thresholds is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (thresholds));
			using var nsa_thresholds = NSArray.FromNSObjects (thresholds);
			SKTileMapNode[]? ret;
			ret = CFArray.ArrayFromHandle<SKTileMapNode>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_CGSize_NativeHandle_NativeHandle (class_ptr, selTileMapNodesWithTileSet_Columns_Rows_TileSize_FromNoiseMap_TileTypeNoiseMapThresholds_XHandle, tileSet__handle__, columns, rows, tileSize, noiseMap__handle__, nsa_thresholds.Handle), false)!;
			GC.KeepAlive (tileSet);
			GC.KeepAlive (noiseMap);
			return ret!;
		}
		/// <param name="column">To be added.</param><param name="row">To be added.</param><summary>Retrieves the <see cref="T:CoreGraphics.CGPoint" /> at the center of the specified position.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("centerOfTileAtColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint GetCenterOfTile (nuint column, nuint row)
		{
			CGPoint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend_UIntPtr_UIntPtr (this.Handle, selCenterOfTileAtColumn_Row_XHandle, column, row);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper_UIntPtr_UIntPtr (&__objc_super__, selCenterOfTileAtColumn_Row_XHandle, column, row);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("tileColumnIndexFromPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetTileColumnIndex (CGPoint position)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_CGPoint (this.Handle, selTileColumnIndexFromPosition_XHandle, position);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_CGPoint (&__objc_super__, selTileColumnIndexFromPosition_XHandle, position);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="column">To be added.</param><param name="row">To be added.</param><summary>Gets the <see cref="T:SpriteKit.SKTileDefinition" /> for the tile at the specified position.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tileDefinitionAtColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKTileDefinition? GetTileDefinition (nuint column, nuint row)
		{
			SKTileDefinition ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SKTileDefinition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr (this.Handle, selTileDefinitionAtColumn_Row_XHandle, column, row), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SKTileDefinition> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_UIntPtr (&__objc_super__, selTileDefinitionAtColumn_Row_XHandle, column, row), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="column">To be added.</param><param name="row">To be added.</param><summary>Gets the <see cref="T:SpriteKit.SKTileGroup" /> for the tile at the specified position.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("tileGroupAtColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKTileGroup? GetTileGroup (nuint column, nuint row)
		{
			SKTileGroup ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SKTileGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_UIntPtr (this.Handle, selTileGroupAtColumn_Row_XHandle, column, row), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SKTileGroup> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_UIntPtr (&__objc_super__, selTileGroupAtColumn_Row_XHandle, column, row), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("tileRowIndexFromPosition:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetTileRowIndex (CGPoint position)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_CGPoint (this.Handle, selTileRowIndexFromPosition_XHandle, position);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_CGPoint (&__objc_super__, selTileRowIndexFromPosition_XHandle, position);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("valueForAttributeNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKAttributeValue? GetValue (string key)
		{
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			SKAttributeValue? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<SKAttributeValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selValueForAttributeNamed_XHandle, nskey), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<SKAttributeValue> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selValueForAttributeNamed_XHandle, nskey), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nskey);
			return ret!;
		}
		/// <param name="tileGroup"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="column">To be added.</param><param name="row">To be added.</param><summary>Sets the <see cref="T:SpriteKit.SKTileGroup" /> at the specified location.</summary><remarks>To be added.</remarks>
		[Export ("setTileGroup:forColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTileGroup (SKTileGroup? tileGroup, nuint column, nuint row)
		{
			var tileGroup__handle__ = tileGroup.GetHandle ();
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (this.Handle, selSetTileGroup_ForColumn_Row_XHandle, tileGroup__handle__, column, row);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_UIntPtr (&__objc_super__, selSetTileGroup_ForColumn_Row_XHandle, tileGroup__handle__, column, row);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tileGroup);
		}
		/// <param name="tileGroup">To be added.</param><param name="tileDefinition">To be added.</param><param name="column">To be added.</param><param name="row">To be added.</param><summary>Sets the <paramref name="tileGroup" /> and <paramref name="tileDefinition" /> at the specified location.</summary><remarks>To be added.</remarks>
		[Export ("setTileGroup:andTileDefinition:forColumn:row:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetTileGroup (SKTileGroup tileGroup, SKTileDefinition tileDefinition, nuint column, nuint row)
		{
			var tileGroup__handle__ = tileGroup!.GetNonNullHandle (nameof (tileGroup));
			var tileDefinition__handle__ = tileDefinition!.GetNonNullHandle (nameof (tileDefinition));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_UIntPtr (this.Handle, selSetTileGroup_AndTileDefinition_ForColumn_Row_XHandle, tileGroup__handle__, tileDefinition__handle__, column, row);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_UIntPtr (&__objc_super__, selSetTileGroup_AndTileDefinition_ForColumn_Row_XHandle, tileGroup__handle__, tileDefinition__handle__, column, row);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (tileGroup);
			GC.KeepAlive (tileDefinition);
		}
		[Export ("setValue:forAttributeNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetValue (SKAttributeValue value, string key)
		{
			var value__handle__ = value!.GetNonNullHandle (nameof (value));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			var nskey = CFString.CreateNative (key);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetValue_ForAttributeNamed_XHandle, value__handle__, nskey);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetValue_ForAttributeNamed_XHandle, value__handle__, nskey);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (value);
			CFString.ReleaseNative (nskey);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGPoint AnchorPoint {
			[Export ("anchorPoint", ArgumentSemantic.Assign)]
			get {
				CGPoint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSend (this.Handle, selAnchorPointXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGPoint_objc_msgSendSuper (&__objc_super__, selAnchorPointXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setAnchorPoint:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGPoint (this.Handle, selSetAnchorPoint_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGPoint (&__objc_super__, selSetAnchorPoint_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDictionary<NSString, SKAttributeValue> AttributeValues {
			[Export ("attributeValues", ArgumentSemantic.Copy)]
			get {
				NSDictionary<NSString, SKAttributeValue>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary<NSString, SKAttributeValue>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAttributeValuesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSDictionary<NSString, SKAttributeValue>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAttributeValuesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAttributeValues:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAttributeValues_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAttributeValues_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKBlendMode BlendMode {
			[Export ("blendMode", ArgumentSemantic.Assign)]
			get {
				SKBlendMode ret;
				if (IsDirectBinding) {
					ret = (SKBlendMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selBlendModeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (SKBlendMode) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selBlendModeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setBlendMode:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetBlendMode_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetBlendMode_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::AppKit.NSColor Color {
			[Export ("color", ArgumentSemantic.Retain)]
			get {
				global::AppKit.NSColor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selColorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<global::AppKit.NSColor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selColorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setColor:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetColor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetColor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nfloat ColorBlendFactor {
			[Export ("colorBlendFactor")]
			get {
				nfloat ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSend (this.Handle, selColorBlendFactorXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.nfloat_objc_msgSendSuper (&__objc_super__, selColorBlendFactorXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setColorBlendFactor:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_nfloat (this.Handle, selSetColorBlendFactor_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_nfloat (&__objc_super__, selSetColorBlendFactor_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool EnableAutomapping {
			[Export ("enableAutomapping")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selEnableAutomappingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selEnableAutomappingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setEnableAutomapping:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetEnableAutomapping_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetEnableAutomapping_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual uint LightingBitMask {
			[Export ("lightingBitMask")]
			get {
				uint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selLightingBitMaskXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (&__objc_super__, selLightingBitMaskXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLightingBitMask:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetLightingBitMask_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (&__objc_super__, selSetLightingBitMask_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize MapSize {
			[Export ("mapSize")]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selMapSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selMapSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint NumberOfColumns {
			[Export ("numberOfColumns")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selNumberOfColumnsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfColumnsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setNumberOfColumns:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetNumberOfColumns_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetNumberOfColumns_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint NumberOfRows {
			[Export ("numberOfRows")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selNumberOfRowsXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selNumberOfRowsXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setNumberOfRows:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetNumberOfRows_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetNumberOfRows_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKShader? Shader {
			[Export ("shader", ArgumentSemantic.Retain)]
			get {
				SKShader? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SKShader> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selShaderXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SKShader> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selShaderXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setShader:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetShader_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetShader_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_TileSet_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual SKTileSet TileSet {
			[Export ("tileSet", ArgumentSemantic.Assign)]
			get {
				SKTileSet? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<SKTileSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTileSetXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<SKTileSet> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTileSetXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				MarkDirty ();
				__mt_TileSet_var = ret;
				return ret!;
			}
			[Export ("setTileSet:", ArgumentSemantic.Assign)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTileSet_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTileSet_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
				MarkDirty ();
				__mt_TileSet_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize TileSize {
			[Export ("tileSize", ArgumentSemantic.Assign)]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSend (this.Handle, selTileSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.CGSize_objc_msgSendSuper (&__objc_super__, selTileSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setTileSize:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_CGSize (this.Handle, selSetTileSize_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_CGSize (&__objc_super__, selSetTileSize_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_TileSet_var = null;
			}
		}
	} /* class SKTileMapNode */
}
