#if !NET

public static class QueueExtensions {
	public static bool TryDequeue<T> (this Queue<T> queue, [MaybeNullWhen(false)] out T item) {
		if (queue.Count == 0) {
			item = default;
			return false;
		}
		item = queue.Dequeue ();
		return true;
	}

	public static bool TryAdd<T, V> (this Dictionary<T, V> dictionary, T key, V value) {
		if (dictionary.ContainsKey (key))
			return false;
		dictionary.Add (key, value);
		return true;
	}
}

#endif
