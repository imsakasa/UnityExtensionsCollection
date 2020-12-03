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

		private static char[] STRING_COMMA_SEPARATOR = { ',' };
		public static IList<string> SplitComma(this string listString)
		{
			return listString.Split(STRING_COMMA_SEPARATOR, StringSplitOptions.RemoveEmptyEntries);
		}

		public static T ToEnum<T>(this string str)
		{
			Type enumType = typeof(T);
			return (T)Enum.Parse(enumType, str);
		}
	}
}