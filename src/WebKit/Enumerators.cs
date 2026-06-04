#if __MACOS__

#nullable enable

using System.Collections;
using System.Collections.Generic;
using CoreFoundation;

namespace WebKit {

/// <typeparam name="T">The type of elements in the container.</typeparam>
///     <summary>Represents an indexed container that provides count-based access to elements.</summary>
	public interface IIndexedContainer<T> {
	/// <summary>Gets the number of elements in the container.</summary>
		int Count { get; }
		T this [int index] { get; }
	}

	internal class IndexedContainerEnumerator<T> : IEnumerator<T> {
		public IndexedContainerEnumerator (IIndexedContainer<T> container)
		{
			_container = container;
			Reset ();
		}

		public void Dispose ()
		{
			_container = null;
		}

		public T Current {
			get {
				if (_container is null)
					throw new ObjectDisposedException (nameof (_container));
				return _container [_index];
			}
		}

		object? IEnumerator.Current {
			get { return ((IEnumerator<T>) this).Current; }
		}

		public bool MoveNext ()
		{
			if (_container is null)
				throw new ObjectDisposedException (nameof (_container));
			return ++_index < _container.Count;
		}

		public void Reset ()
		{
			_index = -1;
		}

		IIndexedContainer<T>? _container;
		int _index;
	}

	public partial class DomCssRuleList : IIndexedContainer<DomCssRule>, IEnumerable<DomCssRule> {
	/// <summary>Returns an enumerator that iterates through the CSS rules.</summary>
		public IEnumerator<DomCssRule> GetEnumerator ()
		{
			return new IndexedContainerEnumerator<DomCssRule> (this);
		}

	/// <summary>Returns an enumerator that iterates through the CSS rules.</summary>
		IEnumerator IEnumerable.GetEnumerator ()
		{
			return ((IEnumerable<DomCssRule>) this).GetEnumerator ();
		}
	}

	public partial class DomCssStyleDeclaration : IIndexedContainer<string>, IEnumerable<string> {
	/// <summary>Returns an enumerator that iterates through the style properties.</summary>
		public IEnumerator<string> GetEnumerator ()
		{
			return new IndexedContainerEnumerator<string> (this);
		}

	/// <summary>Returns an enumerator that iterates through the style properties.</summary>
		IEnumerator IEnumerable.GetEnumerator ()
		{
			return ((IEnumerable<string>) this).GetEnumerator ();
		}
	}

	public partial class DomHtmlCollection : IIndexedContainer<DomNode>, IEnumerable<DomNode> {
	/// <summary>Returns an enumerator that iterates through the HTML collection.</summary>
		public IEnumerator<DomNode> GetEnumerator ()
		{
			return new IndexedContainerEnumerator<DomNode> (this);
		}

	/// <summary>Returns an enumerator that iterates through the HTML collection.</summary>
		IEnumerator IEnumerable.GetEnumerator ()
		{
			return ((IEnumerable<DomNode>) this).GetEnumerator ();
		}
	}

	public partial class DomMediaList : IIndexedContainer<string>, IEnumerable<string> {
	/// <summary>Returns an enumerator that iterates through the media list.</summary>
		public IEnumerator<string> GetEnumerator ()
		{
			return new IndexedContainerEnumerator<string> (this);
		}

	/// <summary>Returns an enumerator that iterates through the media list.</summary>
		IEnumerator IEnumerable.GetEnumerator ()
		{
			return ((IEnumerable<string>) this).GetEnumerator ();
		}
	}

	public partial class DomNamedNodeMap : IIndexedContainer<DomNode>, IEnumerable<DomNode> {
	/// <summary>Returns an enumerator that iterates through the named node map.</summary>
		public IEnumerator<DomNode> GetEnumerator ()
		{
			return new IndexedContainerEnumerator<DomNode> (this);
		}

	/// <summary>Returns an enumerator that iterates through the named node map.</summary>
		IEnumerator IEnumerable.GetEnumerator ()
		{
			return ((IEnumerable<DomNode>) this).GetEnumerator ();
		}
	}

	public partial class DomNodeList : IIndexedContainer<DomNode>, IEnumerable<DomNode> {
	/// <summary>Returns an enumerator that iterates through the node list.</summary>
		public IEnumerator<DomNode> GetEnumerator ()
		{
			return new IndexedContainerEnumerator<DomNode> (this);
		}

	/// <summary>Returns an enumerator that iterates through the node list.</summary>
		IEnumerator IEnumerable.GetEnumerator ()
		{
			return ((IEnumerable<DomNode>) this).GetEnumerator ();
		}
	}

	public partial class DomStyleSheetList : IIndexedContainer<DomStyleSheet>, IEnumerable<DomStyleSheet> {
	/// <summary>Returns an enumerator that iterates through the style sheet list.</summary>
		public IEnumerator<DomStyleSheet> GetEnumerator ()
		{
			return new IndexedContainerEnumerator<DomStyleSheet> (this);
		}

	/// <summary>Returns an enumerator that iterates through the style sheet list.</summary>
		IEnumerator IEnumerable.GetEnumerator ()
		{
			return ((IEnumerable<DomStyleSheet>) this).GetEnumerator ();
		}
	}
}

#endif // __MACOS__
