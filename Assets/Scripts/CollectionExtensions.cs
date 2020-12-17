using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UnityExtensions
{
	public static class CollectionExtensions
	{
		public static bool IsNullOrEmpty(this IList collection)
		{
			return collection == null || collection.Count == 0;
		}

		public static void AddRange<T, S>(this IList<T> list, params S[] values) where S : T
		{
			foreach (S value in values)
			{
				list.Add(value);
			}
		}

		public static bool AddIf<T>(this IList<T> list, Predicate<T> predicate, T item)
		{
			if (predicate(item))
			{
				list.Add(item);
				return true;
			}

			return false;
		}

		public static bool RemoveIf<T>(this IList<T> list, Predicate<T> predicate, T item)
		{
			if (predicate(item))
			{
				list.Remove(item);
				return true;
			}

			return false;
		}

		public static bool AddIfNotContains<T>(this IList<T> list, T item)
		{
			if (!list.Contains(item))
			{
				list.Add(item);
				return true;
			}

			return false;
		}
	}
}