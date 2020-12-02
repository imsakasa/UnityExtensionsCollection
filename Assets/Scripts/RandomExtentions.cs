using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityExtensions
{
	public static class RandomExtensions
	{
		public static bool CoinToss(this Random @this)
		{
			return @this.Next(2) == 0;
		}

		public static T OneOf<T>(this Random @this, params T[] things)
		{
			return things[@this.Next(things.Length)];
		}
	}
}