//
// Copyright 2011, Kenneth J. Pouncey
//
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

//
// scriptingbridge.cs: Bindings for the ScriptingBridge.Framework API
//
using AppKit;

namespace ScriptingBridge {


	[BaseType (typeof (NSObject))]
	interface SBObject : NSCoding {

		/// <param name="properties">The properties.</param>
		/// <summary>Creates a new <see cref="ScriptingBridge.SBObject" /> with the specified properties.</summary>
		[Export ("initWithProperties:")]
		NativeHandle Constructor (NSDictionary properties);

		/// <param name="data">The data to use.</param>
		/// <summary>Creates a new <see cref="ScriptingBridge.SBObject" /> with the specified data.</summary>
		[Export ("initWithData:")]
		NativeHandle Constructor (NSObject data);

		/// <summary>Gets the object by evaluating the reference.</summary>
		/// <value>The evaluated object.</value>
		[Export ("get")]
		NSObject Get { get; }

		// part of SBObject.h include file, not in the official documentation
		/// <summary>Gets the last error that occurred.</summary>
		/// <value>The last error, or <see langword="null" /> if no error occurred.</value>
		[Export ("lastError")]
		NSError LastError { get; }
	}

#pragma warning disable 0618 // SBElement can only access children elements via NSMutableArray base type
	[BaseType (typeof (NSMutableArray))]
	[DisableDefaultCtor] // *** -[SBElementArray init]: should never be used.
	interface SBElementArray {
		/// <param name="capacity">The capacity.</param>
		/// <summary>Creates a new <see cref="ScriptingBridge.SBElementArray" /> with the specified capacity.</summary>
		[Export ("initWithCapacity:")]
		NativeHandle Constructor (nuint capacity);

		/// <param name="name">The name to use.</param>
		/// <summary>Returns the object with the specified name.</summary>
		/// <returns>The object with the specified name.</returns>
		[Export ("objectWithName:")]
		NSObject ObjectWithName (string name);

		/// <param name="identifier">The identifier to use.</param>
		/// <summary>Returns the object with the specified identifier.</summary>
		/// <returns>The object with the specified identifier.</returns>
		[Export ("objectWithID:")]
		NSObject ObjectWithID (NSObject identifier);

		/// <param name="location">The location.</param>
		/// <summary>Returns the object at the specified location.</summary>
		/// <returns>The object at the specified location.</returns>
		[Export ("objectAtLocation:")]
		NSObject ObjectAtLocation (NSObject location);

		/// <param name="selector">The selector.</param>
		/// <summary>Returns an array of results from applying the selector to each element.</summary>
		/// <returns>An array of results.</returns>
		[Export ("arrayByApplyingSelector:")]
		NSObject [] ArrayByApplyingSelector (Selector selector);

		/// <param name="aSelector">The a selector.</param>
		///         <param name="argument">The argument.</param>
		/// <summary>Returns an array of results from applying the selector with the argument to each element.</summary>
		/// <returns>An array of results.</returns>
		[Export ("arrayByApplyingSelector:withObject:")]
		NSObject [] ArrayByApplyingSelector (Selector aSelector, NSObject argument);

		/// <summary>Gets the array by evaluating the reference.</summary>
		/// <returns>The evaluated array.</returns>
		[Export ("get")]
		NSObject [] Get ();
	}
#pragma warning restore 0618


	// TODO: The documentation says these are rarely used so will clean these up later
	//	interface SBObject {
	//		[Export ("initWithElementCode:properties:data:")]
	//		NSObject InitWithElementCodepropertiesdata (DescType code, NSDictionary properties, NSObject data);
	//
	//		[Export ("propertyWithCode:")]
	//		SBObject PropertyWithCode (AEKeyword code);
	//
	//		[Export ("propertyWithClass:code:")]
	//		SBObject PropertyWithClasscode (Class cls, AEKeyword code);
	//
	//		[Export ("elementArrayWithCode:")]
	//		SBElementArray ElementArrayWithCode (DescType code);
	//
	//		[Export ("sendEvent:id:parameters:...")]
	//		NSObject SendEventidparameters... (AEEventClass eventClass, AEEventID eventID, DescType firstParamCode,, );
	//
	//		[Export ("setTo:")]
	//		void SetTo (NSObject value);
	//
	//	}

	[BaseType (typeof (SBObject), Delegates = new string [] { "WeakDelegate" }, Events = new Type [] { typeof (SBApplicationDelegate) })]
	[DisableDefaultCtor] // An uncaught exception was raised: *** -[SBApplication init]: should never be used.
	interface SBApplication : NSCoding {
		/// <param name="url">The URL to use.</param>
		/// <summary>Creates a new <see cref="ScriptingBridge.SBApplication" /> with the specified URL.</summary>
		[Export ("initWithURL:")]
		NativeHandle Constructor (NSUrl url);

		/// <param name="pid">The pid.</param>
		/// <summary>Creates a new <see cref="ScriptingBridge.SBApplication" /> with the specified process identifier.</summary>
		[Export ("initWithProcessIdentifier:")]
		NativeHandle Constructor (int /* pid_t = int */ pid);

		/// <param name="ident">The ident.</param>
		/// <summary>Creates a new <see cref="ScriptingBridge.SBApplication" /> with the specified bundle identifier.</summary>
		[Export ("initWithBundleIdentifier:")]
		NativeHandle Constructor (string ident);

		[Internal]
		[Static]
		[Export ("applicationWithBundleIdentifier:")]
		IntPtr _FromBundleIdentifier (string ident);

		[Internal]
		[Static]
		[Export ("applicationWithURL:")]
		IntPtr _FromURL (NSUrl url);

		[Internal]
		[Static]
		[Export ("applicationWithProcessIdentifier:")]
		IntPtr _FromProcessIdentifier (int /* pid_t = int */ pid);

		/// <param name="className">The class name.</param>
		/// <summary>Returns the class for the specified scripting class name.</summary>
		/// <returns>The Objective-C class for the scripting class.</returns>
		[Export ("classForScriptingClass:")]
		Class ClassForScripting (string className);

		/// <summary>Gets a value that indicates whether the application is running.</summary>
		/// <value><see langword="true" /> if the application is running; otherwise, <see langword="false" />.</value>
		[Export ("isRunning")]
		bool IsRunning { get; }

		/// <summary>Activates the application.</summary>
		[Export ("activate")]
		void Activate ();

		/// <summary>Gets or sets the delegate.</summary>
		/// <value>The delegate, or <see langword="null" />.</value>
		[Export ("delegate", ArgumentSemantic.Retain), NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>Gets or sets the strongly-typed delegate.</summary>
		/// <value>The delegate.</value>
		[Wrap ("WeakDelegate")]
		ISBApplicationDelegate Delegate { get; set; }

		/// <summary>Gets or sets the launch flags.</summary>
		/// <value>The launch flags.</value>
		[Export ("launchFlags")]
		LSLaunchFlags LaunchFlags { get; set; }

		/// <summary>Gets or sets the send mode.</summary>
		/// <value>The Apple event send mode.</value>
		[Export ("sendMode")]
		AESendMode SendMode { get; set; }

		/// <summary>Gets or sets the timeout in ticks.</summary>
		/// <value>The timeout value.</value>
		[Export ("timeout")]
		nint Timeout { get; set; }
	}

	interface ISBApplicationDelegate { }

	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface SBApplicationDelegate {
		[Abstract]
		[Export ("eventDidFail:withError:"), DelegateName ("SBApplicationError"), DefaultValue (null)]
		NSObject EventFailed (IntPtr appleEvent, NSError error);
	}

}
