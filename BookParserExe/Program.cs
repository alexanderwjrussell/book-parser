using System;

namespace BookParserExe
{
	public class Program
	{
		public static void Main()
		{
			var parser = new Parser.Parser();

			var primeChecker = new Parser.PrimeChecker();

			var countedWords = parser.CountWords(parser.Read("TheRailwayChildren.txt"));

			foreach (var word in countedWords)
			{
				Console.WriteLine(word.Key + " : " + word.Value + " : " + primeChecker.IsPrime(word.Value));
			}
		}
	}
}
