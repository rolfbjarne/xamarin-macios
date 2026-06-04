// 
// CFUrl.cs: Implements the managed CFUrl
//
// Authors:
//     Miguel de Icaza
//     Rolf Bjarne Kvinge <rolf@xamarin.com>
//     
// Copyright 2009 Novell, Inc
// Copyright 2012-2014 Xamarin Inc. All rights reserved.
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

#nullable enable

namespace CoreFoundation {

	// CFURLPathStyle -> CFIndex -> CFURL.h
	/// <summary>Url Style.</summary>
	///     <remarks>How should the path be interpreted by the CFUrl methods.</remarks>
	[Native]
	public enum CFUrlPathStyle : long {
		/// <summary>As a POSIX filename.   Path elements are separated with a slash character.</summary>
		POSIX = 0,
		/// <summary>As an Apple HFS filename.   Path elements are separated with a colon.</summary>
		HFS = 1,
		/// <summary>Window style filename.</summary>
		Windows = 2,
	};

	/// <summary>URL class used by C-only Cocoa APIs.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	// CFURL.h
	public class CFUrl : NativeObject {
#if !COREBUILD
		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFURLRef */ IntPtr CFURLCreateWithFileSystemPath (/* CFAllocatorRef */ IntPtr allocator,
			/* CFStringRef */ IntPtr filePath,
			/* CFURLPathStyle */ nint pathStyle,
			/* Boolean */ byte isDirectory);

		[Preserve (Conditional = true)]
		internal CFUrl (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}

		/// <param name="filename">The filename.</param>
		///         <summary>Creates a CFUrl from APathname.</summary>
		static public CFUrl? FromFile (string filename)
		{
			if (filename is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (filename));
			var strHandle = CFString.CreateNative (filename);
			try {
				var handle = CFURLCreateWithFileSystemPath (IntPtr.Zero, strHandle, (nint) (long) CFUrlPathStyle.POSIX, (byte) 0);
				if (handle == IntPtr.Zero)
					return null;
				return new CFUrl (handle, true);
			} finally {
				CFString.ReleaseNative (strHandle);
			}
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFURLRef */ IntPtr CFURLCreateWithString (/* CFAllocatorRef */ IntPtr allocator,
			/* CFStringRef */ IntPtr URLString,
			/* CFStringRef */ IntPtr baseURL);

		/// <param name="url">The URL to use.</param>
		///         <param name="baseurl">The baseurl.</param>
		///         <summary>Creates a CFUrl from a string and a base URL. </summary>
		static public CFUrl? FromUrlString (string url, CFUrl? baseurl)
		{
			if (url is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (url));
			var strHandle = CFString.CreateNative (url);
			try {
				return FromStringHandle (strHandle, baseurl);
			} finally {
				CFString.ReleaseNative (strHandle);
			}
		}

		internal static CFUrl? FromStringHandle (IntPtr cfstringHandle, CFUrl? baseurl)
		{
			var handle = CFURLCreateWithString (IntPtr.Zero, cfstringHandle, baseurl.GetHandle ());
			GC.KeepAlive (baseurl);
			if (handle == IntPtr.Zero)
				return null;
			return new CFUrl (handle, true);
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFStringRef */ IntPtr CFURLGetString (/* CFURLRef */ IntPtr anURL);

		/// <summary>Returns the string representation of this URL.</summary>
		public override string? ToString ()
		{
			return CFString.FromHandle (CFURLGetString (Handle));
		}

		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* CFStringRef */ IntPtr CFURLCopyFileSystemPath (/* CFURLRef */ IntPtr anURL,
			/* CFURLPathStyle */ nint style);

		/// <summary>Gets or sets the file system path.</summary>
		public string? FileSystemPath {
			get {
				return GetFileSystemPath (Handle);
			}
		}

		static internal string? GetFileSystemPath (IntPtr hcfurl)
		{
			return CFString.FromHandle (CFURLCopyFileSystemPath (hcfurl, 0), true);
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		[DllImport (Constants.CoreFoundationLibrary)]
		extern static /* Boolean */ byte CFURLIsFileReferenceURL (/* CFURLRef */IntPtr url);

		/// <summary>Gets or sets the is file reference.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("tvos")]
		public bool IsFileReference {
			get {
				return CFURLIsFileReferenceURL (Handle) != 0;
			}
		}

		/// <summary>Type identifier for the CoreFoundation.CFUrl type.</summary>
		///         <remarks>
		///           <para>The returned token is the CoreFoundation type identifier (CFType) that has been assigned to this class.</para>
		///           <para>This can be used to determine type identity between different CoreFoundation objects.</para>
		///           <para>You can retrieve the type of a CoreFoundation object by invoking the <see cref="CoreFoundation.CFType.GetTypeID(System.IntPtr)" /> on the native handle of the object</para>
		///           <example>
		///             <code lang="csharp lang-csharp"><![CDATA[bool isCFUrl = (CFType.GetTypeID (foo.Handle) == CFUrl.GetTypeID ());]]></code>
		///           </example>
		///         </remarks>
		[DllImport (Constants.CoreFoundationLibrary, EntryPoint = "CFURLGetTypeID")]
		public extern static /* CFTypeID */ nint GetTypeID ();
#endif // !COREBUILD
	}
}
