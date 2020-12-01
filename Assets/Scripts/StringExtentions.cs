using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityExtensions
{
	public static class StringExtensions
	{
		public static string Format(this string format, params object[] values)
		{
			return String.Format(format, values);
		}
	}
}