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
namespace ModelIO {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MDLObjectContainerComponent</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MDLObjectContainerComponent", WrapperType = typeof (MDLObjectContainerComponentWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AddObject", Selector = "addObject:", ParameterType = new Type [] { typeof (MDLObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveObject", Selector = "removeObject:", ParameterType = new Type [] { typeof (MDLObject) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetObject", Selector = "objectAtIndexedSubscript:", ReturnType = typeof (MDLObject), ParameterType = new Type [] { typeof (UIntPtr) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Count", Selector = "count", PropertyType = typeof (UIntPtr), GetterSelector = "count", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Objects", Selector = "objects", PropertyType = typeof (MDLObject[]), GetterSelector = "objects", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface IMDLObjectContainerComponent : INativeObject, IDisposable, 
		ModelIO.IMDLComponent
	{
		/// <param name="object">To be added.</param><summary>Adds <paramref name="object" /> to the list of objects that are contained by this IMDLObjectContainerComponent.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("addObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddObject (MDLObject @object)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="object">To be added.</param><summary>Adds <paramref name="object" /> to the list of objects that are contained by this IMDLObjectContainerComponent.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _AddObject (IMDLObjectContainerComponent This, MDLObject @object)
		{
			var @object__handle__ = @object!.GetNonNullHandle (nameof (@object));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("addObject:"), @object__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (@object);
		}
		/// <param name="object">To be added.</param><summary>Removes <paramref name="object" /> from the list of objects that are contained by this IMDLObjectContainerComponent.</summary><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("removeObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveObject (MDLObject @object)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="object">To be added.</param><summary>Removes <paramref name="object" /> from the list of objects that are contained by this IMDLObjectContainerComponent.</summary><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _RemoveObject (IMDLObjectContainerComponent This, MDLObject @object)
		{
			var @object__handle__ = @object!.GetNonNullHandle (nameof (@object));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("removeObject:"), @object__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (@object);
		}
		/// <param name="index">The index of the object to get.</param><summary>Returns the object at the specified <paramref name="index" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("objectAtIndexedSubscript:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLObject GetObject (nuint index)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="index">The index of the object to get.</param><summary>Returns the object at the specified <paramref name="index" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MDLObject _GetObject (IMDLObjectContainerComponent This, nuint index)
		{
			MDLObject ret;
			ret =  Runtime.GetNSObject<MDLObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("objectAtIndexedSubscript:"), index), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[DynamicDependencyAttribute ("AddObject(ModelIO.MDLObject)")]
		[DynamicDependencyAttribute ("Count")]
		[DynamicDependencyAttribute ("GetObject(System.UIntPtr)")]
		[DynamicDependencyAttribute ("Objects")]
		[DynamicDependencyAttribute ("RemoveObject(ModelIO.MDLObject)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MDLObjectContainerComponentWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMDLObjectContainerComponent ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>Gets the number of objects in this container.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual nuint Count {
			[Export ("count")]
			get {
				return _GetCount (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetCount (IMDLObjectContainerComponent This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("count"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Gets the list of objects that belong to this IMDLObjectContainerComponent.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MDLObject[] Objects {
			[Export ("objects", ArgumentSemantic.Retain)]
			get {
				return _GetObjects (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MDLObject[] _GetObjects (IMDLObjectContainerComponent This)
		{
			MDLObject[] ret;
			ret = CFArray.ArrayFromHandle<MDLObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("objects")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MDLObjectContainerComponentWrapper : BaseWrapper, IMDLObjectContainerComponent {
		public MDLObjectContainerComponentWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MDLObjectContainerComponentWrapper))]
		static MDLObjectContainerComponentWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="object">To be added.</param><summary>Adds <paramref name="object" /> to the list of objects that are contained by this IMDLObjectContainerComponent.</summary><remarks>To be added.</remarks>
		[Export ("addObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void AddObject (MDLObject @object)
		{
			var @object__handle__ = @object!.GetNonNullHandle (nameof (@object));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("addObject:"), @object__handle__);
			GC.KeepAlive (@object);
		}
		/// <param name="object">To be added.</param><summary>Removes <paramref name="object" /> from the list of objects that are contained by this IMDLObjectContainerComponent.</summary><remarks>To be added.</remarks>
		[Export ("removeObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void RemoveObject (MDLObject @object)
		{
			var @object__handle__ = @object!.GetNonNullHandle (nameof (@object));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("removeObject:"), @object__handle__);
			GC.KeepAlive (@object);
		}
		/// <param name="index">The index of the object to get.</param><summary>Returns the object at the specified <paramref name="index" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("objectAtIndexedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLObject GetObject (nuint index)
		{
			MDLObject ret;
			ret =  Runtime.GetNSObject<MDLObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("objectAtIndexedSubscript:"), index), false)!;
			return ret;
		}
		/// <summary>Gets the number of objects in this container.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public nuint Count {
			[Export ("count")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("count"));
				return ret;
			}
		}
		/// <summary>Gets the list of objects that belong to this IMDLObjectContainerComponent.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLObject[] Objects {
			[Export ("objects", ArgumentSemantic.Retain)]
			get {
				MDLObject[] ret;
				ret = CFArray.ArrayFromHandle<MDLObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("objects")), false)!;
				return ret;
			}
		}
	}
}
