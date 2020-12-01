using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityExtensions
{
	public static class DictionaryExtensions
	{
		public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> source, TKey key, TValue defaultVal = default(TValue))
		{
			if (source == null || source.Count == 0)
			{
				return defaultVal;
			}

			TValue result;
			if (source.TryGetValue(key, out result))
			{
				return result;
			}

			return defaultVal;
		}
	}
}