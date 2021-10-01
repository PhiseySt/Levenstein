﻿using System;

namespace OptimizedMemoryLevenshteinConsole.Methods
{
	public static class Levenshtein
	{

		public static int LevenshteinMethod(string a, string b)
		{

			if (string.IsNullOrEmpty(a))
			{
				if (!string.IsNullOrEmpty(b))
				{
					return b.Length;
				}
				return 0;
			}

			if (string.IsNullOrEmpty(b))
			{
				if (!string.IsNullOrEmpty(a))
				{
					return a.Length;
				}
				return 0;
			}

			int[,] d = new int[a.Length + 1, b.Length + 1];

			for (int i = 0; i <= d.GetUpperBound(0); i += 1)
			{
				d[i, 0] = i;
			}

			for (int i = 0; i <= d.GetUpperBound(1); i += 1)
			{
				d[0, i] = i;
			}

			for (int i = 1; i <= d.GetUpperBound(0); i += 1)
			{
				for (int j = 1; j <= d.GetUpperBound(1); j += 1)
				{
					var cost = (a[i - 1] != b[j - 1]) ? 1 : 0;

					var min1 = d[i - 1, j] + 1;
					var min2 = d[i, j - 1] + 1;
					var min3 = d[i - 1, j - 1] + cost;
					d[i, j] = Math.Min(Math.Min(min1, min2), min3);
				}
			}

			return d[d.GetUpperBound(0), d.GetUpperBound(1)];

		}
    }
}
