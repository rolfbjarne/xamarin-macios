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
	[Register("NSMutableOrderedSet", true)]
	public unsafe partial class NSMutableOrderedSet : NSOrderedSet {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("NSMutableOrderedSet");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="NSMutableOrderedSet" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NSMutableOrderedSet () : base (NSObjectFlag.Empty)
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
		public NSMutableOrderedSet (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected NSMutableOrderedSet (NSObjectFlag t) : base (t)
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
		protected internal NSMutableOrderedSet (NativeHandle handle) : base (handle)
		{
		}

		[Export ("initWithObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSMutableOrderedSet (NSObject start)
			: base (NSObjectFlag.Empty)
		{
			var start__handle__ = start!.GetNonNullHandle (nameof (start));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithObject:"), start__handle__), "initWithObject:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithObject:"), start__handle__), "initWithObject:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (start);
		}
		[Export ("initWithSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSMutableOrderedSet (NSSet source)
			: base (NSObjectFlag.Empty)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithSet:"), source__handle__), "initWithSet:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithSet:"), source__handle__), "initWithSet:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (source);
		}
		[Export ("initWithOrderedSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSMutableOrderedSet (NSOrderedSet source)
			: base (NSObjectFlag.Empty)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithOrderedSet:"), source__handle__), "initWithOrderedSet:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithOrderedSet:"), source__handle__), "initWithOrderedSet:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (source);
		}
		/// <param name="capacity">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithCapacity:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSMutableOrderedSet (nint capacity)
			: base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCapacity:"), capacity), "initWithCapacity:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("initWithCapacity:"), capacity), "initWithCapacity:");
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("initWithArray:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal NSMutableOrderedSet (NSArray array)
			: base (NSObjectFlag.Empty)
		{
			var array__handle__ = array!.GetNonNullHandle (nameof (array));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("initWithArray:"), array__handle__), "initWithArray:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("initWithArray:"), array__handle__), "initWithArray:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (array);
		}
		[Export ("addObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Add (NSObject obj)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addObject:"), obj__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addObject:"), obj__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
		}
		[Export ("addObjectsFromArray:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddObjects (NSObject[] source)
		{
			if (source is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (source));
			using var nsa_source = NSArray.FromNSObjects (source);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addObjectsFromArray:"), nsa_source.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("addObjectsFromArray:"), nsa_source.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="first">To be added.</param><param name="second">To be added.</param><summary>Exchanges the objects at the specified indices.</summary><remarks>To be added.</remarks>
		[Export ("exchangeObjectAtIndex:withObjectAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ExchangeObject (nint first, nint second)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("exchangeObjectAtIndex:withObjectAtIndex:"), first, second);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (&__objc_super__, Selector.GetHandle ("exchangeObjectAtIndex:withObjectAtIndex:"), first, second);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="obj">To be added.</param><param name="atIndex">To be added.</param><summary>Inserts the specified object at the specified index.</summary><remarks>To be added.</remarks>
		[Export ("insertObject:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Insert (NSObject obj, nint atIndex)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("insertObject:atIndex:"), obj__handle__, atIndex);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("insertObject:atIndex:"), obj__handle__, atIndex);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
		}
		[Export ("insertObjects:atIndexes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void InsertObjects (NSObject[] objects, NSIndexSet atIndexes)
		{
			if (objects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objects));
			var atIndexes__handle__ = atIndexes!.GetNonNullHandle (nameof (atIndexes));
			using var nsa_objects = NSArray.FromNSObjects (objects);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("insertObjects:atIndexes:"), nsa_objects.Handle, atIndexes__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("insertObjects:atIndexes:"), nsa_objects.Handle, atIndexes__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (atIndexes);
		}
		[Export ("intersectOrderedSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Intersect (NSOrderedSet intersectWith)
		{
			var intersectWith__handle__ = intersectWith!.GetNonNullHandle (nameof (intersectWith));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("intersectOrderedSet:"), intersectWith__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("intersectOrderedSet:"), intersectWith__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (intersectWith);
		}
		[Export ("intersectSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Intersect (NSSet intersectWith)
		{
			var intersectWith__handle__ = intersectWith!.GetNonNullHandle (nameof (intersectWith));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("intersectSet:"), intersectWith__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("intersectSet:"), intersectWith__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (intersectWith);
		}
		[Export ("minusSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void MinusSet (NSSet other)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("minusSet:"), other__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("minusSet:"), other__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
		}
		[Export ("minusOrderedSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void MinusSet (NSOrderedSet other)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("minusOrderedSet:"), other__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("minusOrderedSet:"), other__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
		}
		/// <param name="indexSet">To be added.</param><param name="destination">To be added.</param><summary>Moves the objects currently at the specified indices so that they start at the specified destination index.</summary><remarks>To be added.</remarks>
		[Export ("moveObjectsAtIndexes:toIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveObjects (NSIndexSet indexSet, nint destination)
		{
			var indexSet__handle__ = indexSet!.GetNonNullHandle (nameof (indexSet));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("moveObjectsAtIndexes:toIndex:"), indexSet__handle__, destination);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("moveObjectsAtIndexes:toIndex:"), indexSet__handle__, destination);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexSet);
		}
		/// <param name="index">To be added.</param><summary>Removes the object at the specified index.</summary><remarks>To be added.</remarks>
		[Export ("removeObjectAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Remove (nint index)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeObjectAtIndex:"), index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, Selector.GetHandle ("removeObjectAtIndex:"), index);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeAllObjects")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAllObjects ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("removeAllObjects"));
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, Selector.GetHandle ("removeAllObjects"));
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveObject (NSObject obj)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeObject:"), obj__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeObject:"), obj__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
		}
		[Export ("removeObjectsAtIndexes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveObjects (NSIndexSet indexSet)
		{
			var indexSet__handle__ = indexSet!.GetNonNullHandle (nameof (indexSet));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeObjectsAtIndexes:"), indexSet__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeObjectsAtIndexes:"), indexSet__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexSet);
		}
		[Export ("removeObjectsInRange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveObjects (NSRange range)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange (this.Handle, Selector.GetHandle ("removeObjectsInRange:"), range);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange (&__objc_super__, Selector.GetHandle ("removeObjectsInRange:"), range);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("removeObjectsInArray:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveObjects (NSObject[] objects)
		{
			if (objects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objects));
			using var nsa_objects = NSArray.FromNSObjects (objects);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeObjectsInArray:"), nsa_objects.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("removeObjectsInArray:"), nsa_objects.Handle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="objectAtIndex">To be added.</param><param name="newObject">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("replaceObjectAtIndex:withObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Replace (nint objectAtIndex, NSObject newObject)
		{
			var newObject__handle__ = newObject!.GetNonNullHandle (nameof (newObject));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_NativeHandle (this.Handle, Selector.GetHandle ("replaceObjectAtIndex:withObject:"), objectAtIndex, newObject__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("replaceObjectAtIndex:withObject:"), objectAtIndex, newObject__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newObject);
		}
		[Export ("replaceObjectsAtIndexes:withObjects:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceObjects (NSIndexSet indexSet, NSObject[] replacementObjects)
		{
			var indexSet__handle__ = indexSet!.GetNonNullHandle (nameof (indexSet));
			if (replacementObjects is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (replacementObjects));
			using var nsa_replacementObjects = NSArray.FromNSObjects (replacementObjects);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("replaceObjectsAtIndexes:withObjects:"), indexSet__handle__, nsa_replacementObjects.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, Selector.GetHandle ("replaceObjectsAtIndexes:withObjects:"), indexSet__handle__, nsa_replacementObjects.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexSet);
		}
		/// <param name="obj">To be added.</param><param name="index">To be added.</param><summary>Appends or replaces the object at the specified index.</summary><remarks>To be added.</remarks>
		[Export ("setObject:atIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetObject (NSObject obj, nint index)
		{
			var obj__handle__ = obj!.GetNonNullHandle (nameof (obj));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_IntPtr (this.Handle, Selector.GetHandle ("setObject:atIndex:"), obj__handle__, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_IntPtr (&__objc_super__, Selector.GetHandle ("setObject:atIndex:"), obj__handle__, index);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (obj);
		}
		[Export ("sortUsingComparator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Sort ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSComparator))]NSComparator comparator)
		{
			if (comparator is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (comparator));
			using var block_comparator = Trampolines.SDNSComparator.CreateBlock (comparator);
			BlockLiteral *block_ptr_comparator = &block_comparator;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("sortUsingComparator:"), (IntPtr) block_ptr_comparator);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("sortUsingComparator:"), (IntPtr) block_ptr_comparator);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("sortWithOptions:usingComparator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void Sort (NSSortOptions sortOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSComparator))]NSComparator comparator)
		{
			if (comparator is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (comparator));
			using var block_comparator = Trampolines.SDNSComparator.CreateBlock (comparator);
			BlockLiteral *block_ptr_comparator = &block_comparator;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("sortWithOptions:usingComparator:"), (UIntPtr) (ulong) sortOptions, (IntPtr) block_ptr_comparator);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("sortWithOptions:usingComparator:"), (UIntPtr) (ulong) sortOptions, (IntPtr) block_ptr_comparator);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("sortRange:options:usingComparator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void SortRange (NSRange range, NSSortOptions sortOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDNSComparator))]NSComparator comparator)
		{
			if (comparator is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (comparator));
			using var block_comparator = Trampolines.SDNSComparator.CreateBlock (comparator);
			BlockLiteral *block_ptr_comparator = &block_comparator;
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NSRange_UIntPtr_NativeHandle (this.Handle, Selector.GetHandle ("sortRange:options:usingComparator:"), range, (UIntPtr) (ulong) sortOptions, (IntPtr) block_ptr_comparator);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NSRange_UIntPtr_NativeHandle (&__objc_super__, Selector.GetHandle ("sortRange:options:usingComparator:"), range, (UIntPtr) (ulong) sortOptions, (IntPtr) block_ptr_comparator);
					GC.KeepAlive (this);
				}
			}
		}
		[Export ("unionSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void UnionSet (NSSet other)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("unionSet:"), other__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("unionSet:"), other__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
		}
		[Export ("unionOrderedSet:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual void UnionSet (NSOrderedSet other)
		{
			var other__handle__ = other!.GetNonNullHandle (nameof (other));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("unionOrderedSet:"), other__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, Selector.GetHandle ("unionOrderedSet:"), other__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (other);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal void _Add (nint obj)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addObject:"), obj);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal void _AddObjects (NSArray source)
		{
			var source__handle__ = source!.GetNonNullHandle (nameof (source));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addObjectsFromArray:"), source__handle__);
			GC.KeepAlive (source);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal void _Insert (nint obj, nint atIndex)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("insertObject:atIndex:"), obj, atIndex);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal void _InsertObjects (NSArray objects, NSIndexSet atIndexes)
		{
			var objects__handle__ = objects!.GetNonNullHandle (nameof (objects));
			var atIndexes__handle__ = atIndexes!.GetNonNullHandle (nameof (atIndexes));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("insertObjects:atIndexes:"), objects__handle__, atIndexes__handle__);
			GC.KeepAlive (objects);
			GC.KeepAlive (atIndexes);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal void _RemoveObject (nint obj)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeObject:"), obj);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal void _RemoveObjects (NSArray objects)
		{
			var objects__handle__ = objects!.GetNonNullHandle (nameof (objects));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeObjectsInArray:"), objects__handle__);
			GC.KeepAlive (objects);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal void _Replace (nint objectAtIndex, nint newObject)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("replaceObjectAtIndex:withObject:"), objectAtIndex, newObject);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal void _ReplaceObjects (NSIndexSet indexSet, NSArray replacementObjects)
		{
			var indexSet__handle__ = indexSet!.GetNonNullHandle (nameof (indexSet));
			var replacementObjects__handle__ = replacementObjects!.GetNonNullHandle (nameof (replacementObjects));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("replaceObjectsAtIndexes:withObjects:"), indexSet__handle__, replacementObjects__handle__);
			GC.KeepAlive (indexSet);
			GC.KeepAlive (replacementObjects);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal void _SetObject (nint obj, nint index)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setObject:atIndex:"), obj, index);
		}
	} /* class NSMutableOrderedSet */
}
