using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UnityExtensions
{
	public static class CollectionExtensions
	{
		public static bool IsNullOrEmpty(this ICollection collection)
		{
			return collection == null || collection.Count == 0;
		}

		public static bool AddIf<T>(this ICollection<T> collection, Predicate<T> predicate, T item)
		{
			if (predicate(item))
			{
				collection.Add(item);
				return true;
			}

			return false;
		}

		public static bool RemoveIf<T>(this ICollection<T> collection, Predicate<T> predicate, T item)
		{
			if (predicate(item))
			{
				collection.Remove(item);
				return true;
			}

			return false;
		}

		public static bool AddIfNotContains<T>(this ICollection<T> collection, T item)
		{
			if (!collection.Contains(item))
			{
				collection.Add(item);
				return true;
			}

			return false;
		}
	}
}