using System;
using OptimizedMemoryLevenshteinConsole.Methods;

namespace OptimizedMemoryLevenshteinConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите слово 1");
			var word1 = Console.ReadLine();
			Console.WriteLine("Введите слово 2");
			var word2 = Console.ReadLine();
			var result = Levenshtein.LevenshteinMethod(word1, word2);
			var result2 = OptimizedMemoryLevenshtein.LevenshteinOptimizedMethod(word1, word2);
			Console.WriteLine($"Результат методом Левенштейна: {result}");
			Console.WriteLine($"Результат оптимизированным методом Левенштейна: {result2}");
			Console.ReadLine();
		}
	}
}
