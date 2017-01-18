﻿using System.Collections.Generic;
using NUnit.Framework;

namespace ParserTests
{
	[TestFixture]
	public class ParserTests
	{
		[TestCase("Charlie.txt", "Charlie and the Chocolate Factory")]
		[TestCase("Cat.txt", "The Cat in the Hat")]
		public void Should_ReturnContentsFromBook_WhenAccessedFromFile(string fileName, string text)
		{
			var parser = new Parser.Parser();

			Assert.That(parser.Read(fileName), Is.Not.Null);
			Assert.That(parser.Read(fileName), Is.EqualTo(text));
		}

		[Test]
		public void Should_CountEachTimeEachWordAppearsInABook()
		{
			var parser = new Parser.Parser();

			var words = new Dictionary<string, int>
			{
				{"The", 1},
				{"Cat", 1},
				{"in", 1},
				{"the", 1},
				{"Hat", 1}
			};

			Assert.That(parser.CountWords("The Cat in the Hat"), Is.EqualTo(words));
		}
	}
}
