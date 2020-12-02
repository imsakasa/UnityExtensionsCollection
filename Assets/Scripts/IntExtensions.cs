using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityExtensions
{
	public static class IntExtensions
	{
		public static bool IsEven(this int @this)
		{
			return @this % 2 == 0;
		}

		public static bool IsOdd(this int @this)
		{
			return @this % 2 != 0;
		}

		public static bool InBetween(this int value, int min, int max)
		{
			return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
		}
	}
}