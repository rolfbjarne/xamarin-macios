// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.IO;
using System.Text;

#nullable enable

/// <summary>
/// A Stream wrapper that allows the underlying FileStream to be swapped
/// without reallocating the StreamWriter's internal buffers.
/// Used to reuse a single StreamWriter across multiple output files.
/// </summary>
sealed class SwappableStream : Stream {
	FileStream? current;

	public void Open (string path)
	{
		current = new FileStream (path, FileMode.Create, FileAccess.Write, FileShare.None, bufferSize: 4096);
	}

	public void CloseFile ()
	{
		current?.Flush ();
		current?.Dispose ();
		current = null;
	}

	public override bool CanRead => false;
	public override bool CanSeek => false;
	public override bool CanWrite => true;
	public override long Length => throw new NotSupportedException ();
	public override long Position {
		get => throw new NotSupportedException ();
		set => throw new NotSupportedException ();
	}

	public override void Flush ()
	{
		current?.Flush ();
	}

	public override int Read (byte [] buffer, int offset, int count) => throw new NotSupportedException ();
	public override long Seek (long offset, SeekOrigin origin) => throw new NotSupportedException ();
	public override void SetLength (long value) => throw new NotSupportedException ();

	public override void Write (byte [] buffer, int offset, int count)
	{
		current!.Write (buffer, offset, count);
	}

	public override void Write (ReadOnlySpan<byte> buffer)
	{
		current!.Write (buffer);
	}

	protected override void Dispose (bool disposing)
	{
		if (disposing)
			CloseFile ();
		base.Dispose (disposing);
	}
}

/// <summary>
/// A StreamWriter wrapper whose Dispose only flushes the writer and closes
/// the underlying file, but does NOT dispose the StreamWriter's internal buffers.
/// This allows the same StreamWriter+buffers to be reused for the next file.
/// </summary>
sealed class ReusableFileWriter : StreamWriter {
	readonly SwappableStream swappableStream;

	public ReusableFileWriter (SwappableStream stream, Encoding encoding, int bufferSize)
		: base (stream, encoding, bufferSize, leaveOpen: true)
	{
		swappableStream = stream;
	}

	/// <summary>
	/// Opens a new file for writing. Must be called before writing.
	/// </summary>
	public void OpenFile (string path)
	{
		swappableStream.Open (path);
	}

	/// <summary>
	/// Flushes the writer and closes the underlying file.
	/// The writer's buffers are preserved for reuse.
	/// </summary>
	public void CloseFile ()
	{
		Flush ();
		swappableStream.CloseFile ();
	}

	protected override void Dispose (bool disposing)
	{
		// Only close the file, don't dispose the base StreamWriter
		// so that internal buffers are preserved for reuse.
		if (disposing)
			CloseFile ();
		// Intentionally NOT calling base.Dispose() to keep buffers alive
	}
}
